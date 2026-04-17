
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DownloadResponse
    {
        /// <summary>
        /// The presigned URL for downloading the image. This URL is temporary and will **expire after 1 hour**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DownloadUrl { get; set; }

        /// <summary>
        /// The presigned URL for fetching the metadata of the image's file. Useful for retrieving the image's size before download. This URL is temporary and will **expire after 1 hour**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HeadUrl { get; set; }

        /// <summary>
        /// The expiration time (in Unix epoch) of the presigned download link, set as 1 hour after download link generation. After this time, the link will no longer be valid.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiry")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Expiry { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadResponse" /> class.
        /// </summary>
        /// <param name="downloadUrl">
        /// The presigned URL for downloading the image. This URL is temporary and will **expire after 1 hour**.
        /// </param>
        /// <param name="headUrl">
        /// The presigned URL for fetching the metadata of the image's file. Useful for retrieving the image's size before download. This URL is temporary and will **expire after 1 hour**.
        /// </param>
        /// <param name="expiry">
        /// The expiration time (in Unix epoch) of the presigned download link, set as 1 hour after download link generation. After this time, the link will no longer be valid.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DownloadResponse(
            string downloadUrl,
            string headUrl,
            int expiry)
        {
            this.DownloadUrl = downloadUrl ?? throw new global::System.ArgumentNullException(nameof(downloadUrl));
            this.HeadUrl = headUrl ?? throw new global::System.ArgumentNullException(nameof(headUrl));
            this.Expiry = expiry;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadResponse" /> class.
        /// </summary>
        public DownloadResponse()
        {
        }
    }
}