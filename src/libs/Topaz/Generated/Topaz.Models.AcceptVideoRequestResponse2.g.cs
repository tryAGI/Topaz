
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AcceptVideoRequestResponse2
    {
        /// <summary>
        /// Example: Unauthorized
        /// </summary>
        /// <example>Unauthorized</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptVideoRequestResponse2" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Unauthorized
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AcceptVideoRequestResponse2(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptVideoRequestResponse2" /> class.
        /// </summary>
        public AcceptVideoRequestResponse2()
        {
        }
    }
}