
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Present only if the request failed. The `errorCode` originates from the processing pipeline and may take values beyond the synchronous API error codes returned in HTTP error responses.
    /// </summary>
    public sealed partial class VideoRequestRecordError
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Failure code from the processing pipeline.<br/>
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoRequestRecordError" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorCode">
        /// Failure code from the processing pipeline.<br/>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoRequestRecordError(
            string? message,
            string? errorCode)
        {
            this.Message = message;
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoRequestRecordError" /> class.
        /// </summary>
        public VideoRequestRecordError()
        {
        }

    }
}