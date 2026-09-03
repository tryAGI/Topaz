
#nullable enable

namespace Topaz
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AcceptVideoRequestResponse
    {
        /// <summary>
        /// Example: Invalid input
        /// </summary>
        /// <example>Invalid input</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: INVALID_INPUT
        /// </summary>
        /// <example>INVALID_INPUT</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorCode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.AcceptVideoRequestResponseErrorCodeJsonConverter))]
        public global::Topaz.AcceptVideoRequestResponseErrorCode? ErrorCode { get; set; }

        /// <summary>
        /// Present when the request failed schema validation. One entry per offending field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::Topaz.AcceptVideoRequestResponseError>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptVideoRequestResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Invalid input
        /// </param>
        /// <param name="errorCode">
        /// Example: INVALID_INPUT
        /// </param>
        /// <param name="errors">
        /// Present when the request failed schema validation. One entry per offending field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AcceptVideoRequestResponse(
            string? message,
            global::Topaz.AcceptVideoRequestResponseErrorCode? errorCode,
            global::System.Collections.Generic.IList<global::Topaz.AcceptVideoRequestResponseError>? errors)
        {
            this.Message = message;
            this.ErrorCode = errorCode;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptVideoRequestResponse" /> class.
        /// </summary>
        public AcceptVideoRequestResponse()
        {
        }

    }
}