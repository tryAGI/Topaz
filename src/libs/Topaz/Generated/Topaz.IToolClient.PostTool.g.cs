#nullable enable

namespace Topaz
{
    public partial interface IToolClient
    {
        /// <summary>
        /// Tool<br/>
        /// Returns `process_id` and `eta` to use as an efficient way to track the progress of the image tool processing job:<br/>
        ///   - Use the `Status` endpoints to check the status of this job using the returned `process_id`.<br/>
        ///   - Use the `Download` endpoints to download the input or processed image (once it is ready).<br/>
        ///   - Use the `Cancel` endpoint to cancel the job while it is in progress.<br/>
        /// The same `process_id` and `eta` are also returned in the response headers as `X-Process-ID` and `X-ETA` respectively.<br/>
        /// &gt; The `eta` represents when the job is expected to finish in Unix time. We recommend using this to know when you can expect your (bulk) jobs to finish processing.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.AsyncResponse> PostToolAsync(

            global::Topaz.ToolGANRequest request,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Tool<br/>
        /// Returns `process_id` and `eta` to use as an efficient way to track the progress of the image tool processing job:<br/>
        ///   - Use the `Status` endpoints to check the status of this job using the returned `process_id`.<br/>
        ///   - Use the `Download` endpoints to download the input or processed image (once it is ready).<br/>
        ///   - Use the `Cancel` endpoint to cancel the job while it is in progress.<br/>
        /// The same `process_id` and `eta` are also returned in the response headers as `X-Process-ID` and `X-ETA` respectively.<br/>
        /// &gt; The `eta` represents when the job is expected to finish in Unix time. We recommend using this to know when you can expect your (bulk) jobs to finish processing.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Topaz.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.AutoSDKHttpResponse<global::Topaz.AsyncResponse>> PostToolAsResponseAsync(

            global::Topaz.ToolGANRequest request,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Tool<br/>
        /// Returns `process_id` and `eta` to use as an efficient way to track the progress of the image tool processing job:<br/>
        ///   - Use the `Status` endpoints to check the status of this job using the returned `process_id`.<br/>
        ///   - Use the `Download` endpoints to download the input or processed image (once it is ready).<br/>
        ///   - Use the `Cancel` endpoint to cancel the job while it is in progress.<br/>
        /// The same `process_id` and `eta` are also returned in the response headers as `X-Process-ID` and `X-ETA` respectively.<br/>
        /// &gt; The `eta` represents when the job is expected to finish in Unix time. We recommend using this to know when you can expect your (bulk) jobs to finish processing.
        /// </summary>
        /// <param name="image">
        /// The image file to be processed. Supported formats:<br/>
        ///   - png
        /// </param>
        /// <param name="sourceId">
        /// Unique identifier of the source image.
        /// </param>
        /// <param name="sourceUrl">
        /// The URL of the source image.
        /// </param>
        /// <param name="model">
        /// The model to use for processing the image.<br/>
        /// Default Value: Transparency Upscale
        /// </param>
        /// <param name="outputHeight">
        /// The desired height of the output image in pixels. Your image will automatically be upscaled to this specified value. If only one of `output_height` and `output_width` is set, then the other dimension is scaled proportionally.
        /// </param>
        /// <param name="outputWidth">
        /// The desired width of the output image in pixels. Your image will automatically be upscaled to this specified value. If only one of `output_height` and `output_width` is set, then the other dimension is scaled proportionally.
        /// </param>
        /// <param name="cropToFill">
        /// Default behavior is to letterbox the image if a differing aspect ratio is chosen. Enable `crop_to_fill` by setting this to `true` if you instead want to crop the image to fill the dimensions.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="outputFormat">
        /// The desired format of the output image.<br/>
        /// Default Value: png
        /// </param>
        /// <param name="webhookUrl">
        /// The URL to send the webhook to. When provided, a POST request with a JSON payload will be sent to this URL when the job status changes or completes.<br/>
        /// **Request Body:**<br/>
        /// The webhook will be sent as a POST request with `Content-Type: application/json` containing the following fields:<br/>
        ///   - `notification_id` (string, ULID): Unique identifier for this notification. Can be used to order messages in case they are received out of order; see the [ULID specification](https://github.com/ulid/spec)<br/>
        ///   - `process_id` (string, UUID): Unique identifier of the image processing job.<br/>
        ///   - `status` (string): Current status of the job (i.e., "Pending", "Processing", "Completed", "Cancelled", "Failed").<br/>
        ///   - `creation_time` (integer): Unix timestamp in seconds when the job was created.<br/>
        ///   - `modification_time` (integer): Unix timestamp in seconds when the job was last modified.<br/>
        ///   - `progress` (integer): Progress of the job as a percentage (0-100).<br/>
        ///   - `download_url` (string, optional): Presigned GET URL for the processed image. Only present once the job is completed.<br/>
        ///   - `head_url` (string, optional): Presigned HEAD URL for the processed image. Only present once the job is completed.<br/>
        ///   - `input_download_url` (string): Presigned GET URL for the input image.<br/>
        ///   - `input_head_url` (string): Presigned HEAD URL for the input image.<br/>
        /// **Retry Behavior:**<br/>
        /// If the webhook endpoint returns a 5xx server error, the system will retry the webhook with exponential backoff. The backoff starts at 5 seconds and doubles with each retry attempt (5s, 10s, 20s, 40s, etc.), up to a maximum of 15 minutes. Client errors (4xx status codes) are not retried and the notification is discarded.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Topaz.AsyncResponse> PostToolAsync(
            string? image = default,
            string? sourceId = default,
            string? sourceUrl = default,
            global::Topaz.ToolGANRequestModel? model = default,
            int? outputHeight = default,
            int? outputWidth = default,
            bool? cropToFill = default,
            global::Topaz.ToolGANRequestOutputFormat? outputFormat = default,
            string? webhookUrl = default,
            global::Topaz.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}