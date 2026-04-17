
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateExpressVideoRequestResponse4
    {
        /// <summary>
        /// Example: Service unavailable
        /// </summary>
        /// <example>Service unavailable</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExpressVideoRequestResponse4" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Service unavailable
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateExpressVideoRequestResponse4(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExpressVideoRequestResponse4" /> class.
        /// </summary>
        public CreateExpressVideoRequestResponse4()
        {
        }
    }
}