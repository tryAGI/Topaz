
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Signed download URL to the enhanced video file.
    /// </summary>
    public sealed partial class EnhancedDownloadSignedUrlResponse
    {
        /// <summary>
        /// Example: https://videocloud.r2.cloudflarestorage.com/0193893a-a2ba-799e-b258-928f02c0f419/enhanced.mp4?X-Amz-Algorithm=AWS4-HMAC-SHA256...x-id=GetObject
        /// </summary>
        /// <example>https://videocloud.r2.cloudflarestorage.com/0193893a-a2ba-799e-b258-928f02c0f419/enhanced.mp4?X-Amz-Algorithm=AWS4-HMAC-SHA256...x-id=GetObject</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// TTL in milliseconds<br/>
        /// Example: 86400000
        /// </summary>
        /// <example>86400000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresIn")]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// Time in milliseconds since UTC epoch<br/>
        /// Example: 1727213400000
        /// </summary>
        /// <example>1727213400000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        public long? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnhancedDownloadSignedUrlResponse" /> class.
        /// </summary>
        /// <param name="url">
        /// Example: https://videocloud.r2.cloudflarestorage.com/0193893a-a2ba-799e-b258-928f02c0f419/enhanced.mp4?X-Amz-Algorithm=AWS4-HMAC-SHA256...x-id=GetObject
        /// </param>
        /// <param name="expiresIn">
        /// TTL in milliseconds<br/>
        /// Example: 86400000
        /// </param>
        /// <param name="expiresAt">
        /// Time in milliseconds since UTC epoch<br/>
        /// Example: 1727213400000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnhancedDownloadSignedUrlResponse(
            string? url,
            int? expiresIn,
            long? expiresAt)
        {
            this.Url = url;
            this.ExpiresIn = expiresIn;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnhancedDownloadSignedUrlResponse" /> class.
        /// </summary>
        public EnhancedDownloadSignedUrlResponse()
        {
        }
    }
}