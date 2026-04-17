/*
order: 10
title: Client Creation
slug: client-creation

Basic example showing how to create a Topaz Labs client.
*/

namespace Topaz.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Example_ClientCreation()
    {
        //// Create a Topaz Labs client using your API key.
        //// Get one at https://www.topazlabs.com/api.

        var apiKey =
            Environment.GetEnvironmentVariable("TOPAZ_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("TOPAZ_API_KEY environment variable is not found.");

        using var client = new TopazClient(apiKey);

        //// The client exposes organized sub-clients covering both the Image and Video APIs:
        //// Image-side:
        //// - `client.Enhance` -- upscale / enhance images (precision + generative)
        //// - `client.Sharpen` -- specialized sharpening
        //// - `client.Denoise` -- noise reduction
        //// - `client.Restore` -- generative restoration
        //// - `client.Lighting` -- exposure / color correction
        //// - `client.Matting` -- background segmentation
        //// - `client.Tool` -- specialized tools (transparent upscale, etc.)
        //// - `client.Estimate` -- estimate credits/time before running a job
        //// - `client.ImageStatus` / `client.Download` / `client.Cancel` -- manage async jobs
        //// Video-side:
        //// - `client.CreateRequest` / `client.CreateExpressRequest` -- kick off a video job
        //// - `client.AcceptRequest` / `client.CompleteUpload` -- multipart upload workflow
        //// - `client.GetRequestStatus` / `client.GetRequestMetrics` / `client.GetRequestHistory`
        //// - `client.CancelRequest` / `client.DeleteFiles`
        //// - `client.VideoStatus` -- video cloud system status

        client.Should().NotBeNull();
        client.Enhance.Should().NotBeNull();
        client.ImageStatus.Should().NotBeNull();
        client.Download.Should().NotBeNull();
        client.CreateRequest.Should().NotBeNull();
        client.GetRequestStatus.Should().NotBeNull();
    }
}
