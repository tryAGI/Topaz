using System.ComponentModel;
using System.Globalization;
using Microsoft.Extensions.AI;

namespace Topaz;

/// <summary>
/// Extensions for using <see cref="TopazClient"/> as MEAI <see cref="AIFunction"/>
/// tools with any <see cref="IChatClient"/>.
/// </summary>
[CLSCompliant(false)]
public static class TopazToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that enhances (upscales, sharpens, denoises)
    /// an image URL using Topaz Labs. Submits an async job and returns the process ID,
    /// which can be passed to <see cref="AsGetImageStatusTool"/> and
    /// <see cref="AsDownloadImageResultTool"/> to poll status and fetch the result URL.
    /// </summary>
    /// <param name="client">The Topaz client.</param>
    public static AIFunction AsEnhanceImageTool(this TopazClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("Publicly accessible URL of the source image (JPEG, PNG, or TIFF)")] string imageUrl,
                [Description("Optional model: 'Standard V2' (default), 'High Fidelity V2', 'Low Resolution V2', 'CGI', 'Text Refine'")] string? model,
                [Description("Optional desired output width in pixels (height scales proportionally if only one is set)")] int? outputWidth,
                [Description("Optional desired output height in pixels (width scales proportionally if only one is set)")] int? outputHeight,
                CancellationToken cancellationToken) =>
            {
                var request = new EnhanceGANRequest
                {
                    SourceUrl = imageUrl,
                    Model = string.IsNullOrWhiteSpace(model) ? null : EnhanceGANRequestModelExtensions.ToEnum(model!),
                    OutputWidth = outputWidth,
                    OutputHeight = outputHeight,
                };

                var response = await client.Enhance.PostEnhanceAsync(
                    request: request,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return $"Image enhancement job submitted.\nProcess ID: {response.ProcessId}\nSource ID: {response.SourceId}\nETA (unix): {response.Eta}";
            },
            name: "TopazEnhanceImage",
            description: "Submits an async image enhancement job (upscale + denoise + sharpen) to Topaz Labs. Accepts an image URL and returns a process_id used to poll status and fetch the enhanced image.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that returns the current status of an image
    /// processing job given its <c>process_id</c>.
    /// </summary>
    /// <param name="client">The Topaz client.</param>
    public static AIFunction AsGetImageStatusTool(this TopazClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("The process_id returned by an image enhancement / sharpen / denoise / restore / lighting / matting / tool request")] string processId,
                CancellationToken cancellationToken) =>
            {
                if (!Guid.TryParse(processId, out var pid))
                {
                    return $"Invalid process_id: '{processId}' is not a valid GUID.";
                }

                var status = await client.ImageStatus.GetStatusAsync(
                    processId: pid,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return
                    $"Process ID: {status.ProcessId}\n" +
                    $"Status: {status.Status.ToValueString()}\n" +
                    $"Progress: {status.Progress}%\n" +
                    $"ETA (unix): {status.Eta}\n" +
                    $"Model: {status.Model}\n" +
                    $"Credits: {status.Credits}";
            },
            name: "TopazGetImageStatus",
            description: "Returns the status, progress percentage, and ETA of a Topaz image processing job given its process_id.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that returns a temporary presigned URL
    /// for downloading the enhanced output image of a completed job.
    /// </summary>
    /// <param name="client">The Topaz client.</param>
    public static AIFunction AsDownloadImageResultTool(this TopazClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("The process_id of a completed Topaz image job")] string processId,
                CancellationToken cancellationToken) =>
            {
                if (!Guid.TryParse(processId, out var pid))
                {
                    return $"Invalid process_id: '{processId}' is not a valid GUID.";
                }

                var response = await client.Download.GetDownloadOutputAsync(
                    processId: pid,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return
                    $"Enhanced image download URL (expires at unix {response.Expiry}):\n" +
                    response.DownloadUrl;
            },
            name: "TopazDownloadImageResult",
            description: "Returns a temporary presigned URL for downloading the enhanced output image of a completed Topaz job. The URL expires after one hour.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that returns the current status
    /// (progress, FPS, download URL) of a Topaz video enhancement request.
    /// </summary>
    /// <param name="client">The Topaz client.</param>
    public static AIFunction AsGetVideoStatusTool(this TopazClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("The requestId returned by a Topaz video CreateRequest or CreateExpressRequest call")] string requestId,
                CancellationToken cancellationToken) =>
            {
                if (!Guid.TryParse(requestId, out var rid))
                {
                    return $"Invalid requestId: '{requestId}' is not a valid GUID.";
                }

                var status = await client.GetRequestStatus.GetVideoRequestStatusAsync(
                    requestId: rid,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var parts = new List<string>
                {
                    $"Status: {(status.Status?.ToValueString() ?? "unknown")}",
                    $"Progress: {status.Progress?.ToString("F1", CultureInfo.InvariantCulture) ?? "?"}%",
                };
                if (!string.IsNullOrWhiteSpace(status.Message)) parts.Add($"Message: {status.Message}");
                if (status.AverageFps is { } avgFps) parts.Add($"Average FPS: {avgFps.ToString("F2", CultureInfo.InvariantCulture)}");
                if (status.CombinedFps is { } combFps) parts.Add($"Combined FPS: {combFps.ToString("F2", CultureInfo.InvariantCulture)}");
                if (!string.IsNullOrWhiteSpace(status.OutputSize)) parts.Add($"Output size: {status.OutputSize}");
                if (status.Download?.Url is { Length: > 0 } dl) parts.Add($"Download URL: {dl}");
                return string.Join("\n", parts);
            },
            name: "TopazGetVideoStatus",
            description: "Returns the progress, FPS, and (when complete) download URL of a Topaz video enhancement request given its requestId.");
    }
}
