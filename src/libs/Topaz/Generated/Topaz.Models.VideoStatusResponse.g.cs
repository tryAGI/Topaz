
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
        /// Processing state for each chunk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processingJobs")]
        public global::System.Collections.Generic.IList<global::Topaz.ProcessingStatIntermediateItem>? ProcessingJobs { get; set; }

        /// <summary>
        /// Signed download URL to the enhanced video file.
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
        /// <param name="processingJobs">
        /// Processing state for each chunk
        /// </param>
        /// <param name="download">
        /// Signed download URL to the enhanced video file.
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
            global::System.Collections.Generic.IList<global::Topaz.ProcessingStatIntermediateItem>? processingJobs,
            global::Topaz.EnhancedDownloadSignedUrlResponse? download)
        {
            this.Status = status;
            this.Progress = progress;
            this.Estimates = estimates;
            this.OutputSize = outputSize;
            this.AverageFps = averageFps;
            this.CombinedFps = combinedFps;
            this.Message = message;
            this.ProcessingJobs = processingJobs;
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