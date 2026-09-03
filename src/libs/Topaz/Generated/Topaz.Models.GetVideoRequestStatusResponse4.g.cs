
#nullable enable

namespace Topaz
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetVideoRequestStatusResponse4
    {
        /// <summary>
        /// Example: Internal server error
        /// </summary>
        /// <example>Internal server error</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: SERVER_ERROR
        /// </summary>
        /// <example>SERVER_ERROR</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorCode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.GetVideoRequestStatusResponseErrorCode4JsonConverter))]
        public global::Topaz.GetVideoRequestStatusResponseErrorCode4? ErrorCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVideoRequestStatusResponse4" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Internal server error
        /// </param>
        /// <param name="errorCode">
        /// Example: SERVER_ERROR
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetVideoRequestStatusResponse4(
            string? message,
            global::Topaz.GetVideoRequestStatusResponseErrorCode4? errorCode)
        {
            this.Message = message;
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVideoRequestStatusResponse4" /> class.
        /// </summary>
        public GetVideoRequestStatusResponse4()
        {
        }

    }
}