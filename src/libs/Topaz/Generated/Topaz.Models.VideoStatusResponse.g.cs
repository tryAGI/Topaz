
#nullable enable

namespace Topaz
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VideoStatusResponse
    {
        /// <summary>
        /// Example: processing
        /// </summary>
        /// <example>processing</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.VideoStatusResponseStatusJsonConverter))]
        public global::Topaz.VideoStatusResponseStatus? Status { get; set; }

        /// <summary>
        /// Total progress of the request in percentage<br/>
        /// Example: 82
        /// </summary>
        /// <example>82</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public double? Progress { get; set; }

        /// <summary>
        /// Lower and upper bound estimates
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimates")]
        public global::Topaz.RequestEstimates? Estimates { get; set; }

        /// <summary>
        /// Example: 10 GB
        /// </summary>
        /// <example>10 GB</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputSize")]
        public string? OutputSize { get; set; }

        /// <summary>
        /// Average processing speed of each node<br/>
        /// Example: 1.23
        /// </summary>
        /// <example>1.23</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("averageFps")]
        public double? AverageFps { get; set; }

        /// <summary>
        /// Combined processing speed of all nodes<br/>
        /// Example: 12.34
        /// </summary>
        /// <example>12.34</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("combinedFps")]
        public double? CombinedFps { get; set; }

        /// <summary>
        /// Example: Processing
        /// </summary>
        /// <example>Processing</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Present only when `status` is `failed`. Originates from the processing pipeline.<br/>
        /// Known values include:<br/>
        /// - INSUFFICIENT_CREDITS<br/>
        /// - CREDIT_DIFFERENCE<br/>
        /// - INVALID_INPUT<br/>
        /// - FORBIDDEN<br/>
        /// - UNAUTHORIZED<br/>
        /// - TIMEOUT_UPLOAD_SOURCE<br/>
        /// - TIMEOUT_QUEUE<br/>
        /// - TIMEOUT_PROCESSING<br/>
        /// - PROCESSING_FAILURE<br/>
        /// - SERVER_MAINTENANCE<br/>
        /// - SERVER_ERROR<br/>
        /// - HARDWARE_FAILURE<br/>
        /// - UNKNOWN<br/>
        /// Example: PROCESSING_FAILURE
        /// </summary>
        /// <example>PROCESSING_FAILURE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorCode")]
        public string? ErrorCode { get; set; }

        /// <summary>
        /// Processing state for each chunk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processingJobs")]
        public global::System.Collections.Generic.IList<global::Topaz.ProcessingStatIntermediateItem>? ProcessingJobs { get; set; }

        /// <summary>
        /// Present only while the request is still awaiting the source upload<br/>
        /// Example: GDlWC7qIaE6okS41Xf/ktpuS5XzTRabg
        /// </summary>
        /// <example>GDlWC7qIaE6okS41Xf/ktpuS5XzTRabg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadId")]
        public string? UploadId { get; set; }

        /// <summary>
        /// Outstanding upload URLs, present only while the request is still awaiting the source upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        public global::System.Collections.Generic.IList<string>? Urls { get; set; }

        /// <summary>
        /// URL to a before/after comparison view. Present only for free renders.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comparisonTool")]
        public string? ComparisonTool { get; set; }

        /// <summary>
        /// Signed download URL to the enhanced video file.<br/>
        /// The URL is generated once and then reused for the lifetime of the request — subsequent calls return the same `url`, `expiresIn` and `expiresAt` rather than a freshly signed URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download")]
        public global::Topaz.EnhancedDownloadSignedUrlResponse? Download { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoStatusResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Example: processing
        /// </param>
        /// <param name="progress">
        /// Total progress of the request in percentage<br/>
        /// Example: 82
        /// </param>
        /// <param name="estimates">
        /// Lower and upper bound estimates
        /// </param>
        /// <param name="outputSize">
        /// Example: 10 GB
        /// </param>
        /// <param name="averageFps">
        /// Average processing speed of each node<br/>
        /// Example: 1.23
        /// </param>
        /// <param name="combinedFps">
        /// Combined processing speed of all nodes<br/>
        /// Example: 12.34
        /// </param>
        /// <param name="message">
        /// Example: Processing
        /// </param>
        /// <param name="errorCode">
        /// Present only when `status` is `failed`. Originates from the processing pipeline.<br/>
        /// Known values include:<br/>
        /// - INSUFFICIENT_CREDITS<br/>
        /// - CREDIT_DIFFERENCE<br/>
        /// - INVALID_INPUT<br/>
        /// - FORBIDDEN<br/>
        /// - UNAUTHORIZED<br/>
        /// - TIMEOUT_UPLOAD_SOURCE<br/>
        /// - TIMEOUT_QUEUE<br/>
        /// - TIMEOUT_PROCESSING<br/>
        /// - PROCESSING_FAILURE<br/>
        /// - SERVER_MAINTENANCE<br/>
        /// - SERVER_ERROR<br/>
        /// - HARDWARE_FAILURE<br/>
        /// - UNKNOWN<br/>
        /// Example: PROCESSING_FAILURE
        /// </param>
        /// <param name="processingJobs">
        /// Processing state for each chunk
        /// </param>
        /// <param name="uploadId">
        /// Present only while the request is still awaiting the source upload<br/>
        /// Example: GDlWC7qIaE6okS41Xf/ktpuS5XzTRabg
        /// </param>
        /// <param name="urls">
        /// Outstanding upload URLs, present only while the request is still awaiting the source upload
        /// </param>
        /// <param name="comparisonTool">
        /// URL to a before/after comparison view. Present only for free renders.
        /// </param>
        /// <param name="download">
        /// Signed download URL to the enhanced video file.<br/>
        /// The URL is generated once and then reused for the lifetime of the request — subsequent calls return the same `url`, `expiresIn` and `expiresAt` rather than a freshly signed URL.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoStatusResponse(
            global::Topaz.VideoStatusResponseStatus? status,
            double? progress,
            global::Topaz.RequestEstimates? estimates,
            string? outputSize,
            double? averageFps,
            double? combinedFps,
            string? message,
            string? errorCode,
            global::System.Collections.Generic.IList<global::Topaz.ProcessingStatIntermediateItem>? processingJobs,
            string? uploadId,
            global::System.Collections.Generic.IList<string>? urls,
            string? comparisonTool,
            global::Topaz.EnhancedDownloadSignedUrlResponse? download)
        {
            this.Status = status;
            this.Progress = progress;
            this.Estimates = estimates;
            this.OutputSize = outputSize;
            this.AverageFps = averageFps;
            this.CombinedFps = combinedFps;
            this.Message = message;
            this.ErrorCode = errorCode;
            this.ProcessingJobs = processingJobs;
            this.UploadId = uploadId;
            this.Urls = urls;
            this.ComparisonTool = comparisonTool;
            this.Download = download;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoStatusResponse" /> class.
        /// </summary>
        public VideoStatusResponse()
        {
        }

    }
}