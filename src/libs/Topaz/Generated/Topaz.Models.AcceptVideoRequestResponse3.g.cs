
#nullable enable

namespace Topaz
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AcceptVideoRequestResponse3
    {
        /// <summary>
        /// Example: Insufficient credits
        /// </summary>
        /// <example>Insufficient credits</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: INSUFFICIENT_CREDITS
        /// </summary>
        /// <example>INSUFFICIENT_CREDITS</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorCode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.AcceptVideoRequestResponseErrorCode3JsonConverter))]
        public global::Topaz.AcceptVideoRequestResponseErrorCode3? ErrorCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptVideoRequestResponse3" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Insufficient credits
        /// </param>
        /// <param name="errorCode">
        /// Example: INSUFFICIENT_CREDITS
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AcceptVideoRequestResponse3(
            string? message,
            global::Topaz.AcceptVideoRequestResponseErrorCode3? errorCode)
        {
            this.Message = message;
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptVideoRequestResponse3" /> class.
        /// </summary>
        public AcceptVideoRequestResponse3()
        {
        }

    }
}