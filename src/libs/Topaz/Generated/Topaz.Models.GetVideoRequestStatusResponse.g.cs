
#nullable enable

namespace Topaz
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetVideoRequestStatusResponse
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.GetVideoRequestStatusResponseErrorCodeJsonConverter))]
        public global::Topaz.GetVideoRequestStatusResponseErrorCode? ErrorCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVideoRequestStatusResponse" /> class.
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
        public GetVideoRequestStatusResponse(
            string? message,
            global::Topaz.GetVideoRequestStatusResponseErrorCode? errorCode)
        {
            this.Message = message;
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVideoRequestStatusResponse" /> class.
        /// </summary>
        public GetVideoRequestStatusResponse()
        {
        }

    }
}