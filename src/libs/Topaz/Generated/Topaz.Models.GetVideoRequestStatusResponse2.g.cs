
#nullable enable

namespace Topaz
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetVideoRequestStatusResponse2
    {
        /// <summary>
        /// Example: Forbidden
        /// </summary>
        /// <example>Forbidden</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: FORBIDDEN
        /// </summary>
        /// <example>FORBIDDEN</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorCode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.GetVideoRequestStatusResponseErrorCode2JsonConverter))]
        public global::Topaz.GetVideoRequestStatusResponseErrorCode2? ErrorCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVideoRequestStatusResponse2" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Forbidden
        /// </param>
        /// <param name="errorCode">
        /// Example: FORBIDDEN
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetVideoRequestStatusResponse2(
            string? message,
            global::Topaz.GetVideoRequestStatusResponseErrorCode2? errorCode)
        {
            this.Message = message;
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVideoRequestStatusResponse2" /> class.
        /// </summary>
        public GetVideoRequestStatusResponse2()
        {
        }

    }
}