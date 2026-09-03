
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Destination only. Your own pre-signed multi-part upload URLs. These are not validated by Topaz Labs before use.
    /// </summary>
    public sealed partial class ExternalStorageMultipart
    {
        /// <summary>
        /// Example: GDlWC7qIaE6okS41Xf/ktpuS5XzTRabg
        /// </summary>
        /// <example>GDlWC7qIaE6okS41Xf/ktpuS5XzTRabg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UploadId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Urls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalStorageMultipart" /> class.
        /// </summary>
        /// <param name="uploadId">
        /// Example: GDlWC7qIaE6okS41Xf/ktpuS5XzTRabg
        /// </param>
        /// <param name="urls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExternalStorageMultipart(
            string uploadId,
            global::System.Collections.Generic.IList<string> urls)
        {
            this.UploadId = uploadId ?? throw new global::System.ArgumentNullException(nameof(uploadId));
            this.Urls = urls ?? throw new global::System.ArgumentNullException(nameof(urls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalStorageMultipart" /> class.
        /// </summary>
        public ExternalStorageMultipart()
        {
        }

    }
}