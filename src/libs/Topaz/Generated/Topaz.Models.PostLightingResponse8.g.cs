
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostLightingResponse8
    {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public int? Code { get; set; }

        /// <summary>
        /// A human readable error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostLightingResponse8" /> class.
        /// </summary>
        /// <param name="message">
        /// A human readable error message.
        /// </param>
        /// <param name="code">
        /// The HTTP status code.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostLightingResponse8(
            string message,
            int? code)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostLightingResponse8" /> class.
        /// </summary>
        public PostLightingResponse8()
        {
        }
    }
}