
#nullable enable

namespace Topaz
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetVideoRequestStatusResponse3
    {
        /// <summary>
        /// Example: Not Found
        /// </summary>
        /// <example>Not Found</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: INVALID_INPUT
        /// </summary>
        /// <example>INVALID_INPUT</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorCode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.GetVideoRequestStatusResponseErrorCode3JsonConverter))]
        public global::Topaz.GetVideoRequestStatusResponseErrorCode3? ErrorCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVideoRequestStatusResponse3" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Not Found
        /// </param>
        /// <param name="errorCode">
        /// Example: INVALID_INPUT
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetVideoRequestStatusResponse3(
            string? message,
            global::Topaz.GetVideoRequestStatusResponseErrorCode3? errorCode)
        {
            this.Message = message;
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVideoRequestStatusResponse3" /> class.
        /// </summary>
        public GetVideoRequestStatusResponse3()
        {
        }

    }
}