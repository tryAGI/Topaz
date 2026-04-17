
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SystemStatusResponse
    {
        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("isAvailable")]
        public bool? IsAvailable { get; set; }

        /// <summary>
        /// Example: Cloud rendering is temporarily disabled for maintenance
        /// </summary>
        /// <example>Cloud rendering is temporarily disabled for maintenance</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("availabilityMessage")]
        public string? AvailabilityMessage { get; set; }

        /// <summary>
        /// List of supported models<br/>
        /// Example: [apo-8, prob-4, sl-1]
        /// </summary>
        /// <example>[apo-8, prob-4, sl-1]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportedModels")]
        public global::System.Collections.Generic.IList<string>? SupportedModels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemStatusResponse" /> class.
        /// </summary>
        /// <param name="isAvailable">
        /// Example: false
        /// </param>
        /// <param name="availabilityMessage">
        /// Example: Cloud rendering is temporarily disabled for maintenance
        /// </param>
        /// <param name="supportedModels">
        /// List of supported models<br/>
        /// Example: [apo-8, prob-4, sl-1]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SystemStatusResponse(
            bool? isAvailable,
            string? availabilityMessage,
            global::System.Collections.Generic.IList<string>? supportedModels)
        {
            this.IsAvailable = isAvailable;
            this.AvailabilityMessage = availabilityMessage;
            this.SupportedModels = supportedModels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemStatusResponse" /> class.
        /// </summary>
        public SystemStatusResponse()
        {
        }
    }
}