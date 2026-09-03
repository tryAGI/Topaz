
#nullable enable

namespace Topaz
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateVideoRequestResponse4
    {
        /// <summary>
        /// Example: Service unavailable
        /// </summary>
        /// <example>Service unavailable</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: SERVER_MAINTENANCE
        /// </summary>
        /// <example>SERVER_MAINTENANCE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorCode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.CreateVideoRequestResponseErrorCode4JsonConverter))]
        public global::Topaz.CreateVideoRequestResponseErrorCode4? ErrorCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoRequestResponse4" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Service unavailable
        /// </param>
        /// <param name="errorCode">
        /// Example: SERVER_MAINTENANCE
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoRequestResponse4(
            string? message,
            global::Topaz.CreateVideoRequestResponseErrorCode4? errorCode)
        {
            this.Message = message;
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoRequestResponse4" /> class.
        /// </summary>
        public CreateVideoRequestResponse4()
        {
        }

    }
}