
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolGANRequest
    {
        /// <summary>
        /// The image file to be processed. Supported formats:<br/>
        ///   - png
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Unique identifier of the source image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_id")]
        public string? SourceId { get; set; }

        /// <summary>
        /// The URL of the source image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// The model to use for processing the image.<br/>
        /// Default Value: Transparency Upscale
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.ToolGANRequestModelJsonConverter))]
        public global::Topaz.ToolGANRequestModel? Model { get; set; }

        /// <summary>
        /// The desired height of the output image in pixels. Your image will automatically be upscaled to this specified value. If only one of `output_height` and `output_width` is set, then the other dimension is scaled proportionally.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_height")]
        public int? OutputHeight { get; set; }

        /// <summary>
        /// The desired width of the output image in pixels. Your image will automatically be upscaled to this specified value. If only one of `output_height` and `output_width` is set, then the other dimension is scaled proportionally.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_width")]
        public int? OutputWidth { get; set; }

        /// <summary>
        /// Default behavior is to letterbox the image if a differing aspect ratio is chosen. Enable `crop_to_fill` by setting this to `true` if you instead want to crop the image to fill the dimensions.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crop_to_fill")]
        public bool? CropToFill { get; set; }

        /// <summary>
        /// The desired format of the output image.<br/>
        /// Default Value: png
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.ToolGANRequestOutputFormatJsonConverter))]
        public global::Topaz.ToolGANRequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
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
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolGANRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolGANRequest(
            string? image,
            string? sourceId,
            string? sourceUrl,
            global::Topaz.ToolGANRequestModel? model,
            int? outputHeight,
            int? outputWidth,
            bool? cropToFill,
            global::Topaz.ToolGANRequestOutputFormat? outputFormat,
            string? webhookUrl)
        {
            this.Image = image;
            this.SourceId = sourceId;
            this.SourceUrl = sourceUrl;
            this.Model = model;
            this.OutputHeight = outputHeight;
            this.OutputWidth = outputWidth;
            this.CropToFill = cropToFill;
            this.OutputFormat = outputFormat;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolGANRequest" /> class.
        /// </summary>
        public ToolGANRequest()
        {
        }
    }
}