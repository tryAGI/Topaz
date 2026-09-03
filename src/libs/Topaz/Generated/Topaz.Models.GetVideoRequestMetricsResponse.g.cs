
#nullable enable

namespace Topaz
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetVideoRequestMetricsResponse
    {
        /// <summary>
        /// Example: Unauthorized
        /// </summary>
        /// <example>Unauthorized</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: UNAUTHORIZED
        /// </summary>
        /// <example>UNAUTHORIZED</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorCode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.GetVideoRequestMetricsResponseErrorCodeJsonConverter))]
        public global::Topaz.GetVideoRequestMetricsResponseErrorCode? ErrorCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVideoRequestMetricsResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Unauthorized
        /// </param>
        /// <param name="errorCode">
        /// Example: UNAUTHORIZED
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetVideoRequestMetricsResponse(
            string? message,
            global::Topaz.GetVideoRequestMetricsResponseErrorCode? errorCode)
        {
            this.Message = message;
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVideoRequestMetricsResponse" /> class.
        /// </summary>
        public GetVideoRequestMetricsResponse()
        {
        }

    }
}