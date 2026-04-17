
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVideoRequestRequestNotifications
    {
        /// <summary>
        /// Your URL for Topaz Labs to POST webhook notifications to. Webhooks are sent on successful completions and processing failures.<br/>
        /// Example: https://www.myvideos.com/webhooks/topazlabs
        /// </summary>
        /// <example>https://www.myvideos.com/webhooks/topazlabs</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookUrl")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoRequestRequestNotifications" /> class.
        /// </summary>
        /// <param name="webhookUrl">
        /// Your URL for Topaz Labs to POST webhook notifications to. Webhooks are sent on successful completions and processing failures.<br/>
        /// Example: https://www.myvideos.com/webhooks/topazlabs
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoRequestRequestNotifications(
            string? webhookUrl)
        {
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoRequestRequestNotifications" /> class.
        /// </summary>
        public CreateVideoRequestRequestNotifications()
        {
        }
    }
}