
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompleteVideoUploadRequest
    {
        /// <summary>
        /// MD5 hash of the source video file in hex<br/>
        /// Example: 4d186321c1a7f0f354b297e8914ab240
        /// </summary>
        /// <example>4d186321c1a7f0f354b297e8914ab240</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("md5Hash")]
        public string? Md5Hash { get; set; }

        /// <summary>
        /// An array of part number and ETag pairs of the uploaded parts. ETags are returned by S3 upon upload of the part.<br/>
        /// Example: [{"partNum":1,"eTag":"ff00a2c854712e4b4765eeefa084baa5-305"}, {"partNum":2,"eTag":"92ee1d92cda0f9f8de4429c9596773aa-34"}]
        /// </summary>
        /// <example>[{"partNum":1,"eTag":"ff00a2c854712e4b4765eeefa084baa5-305"}, {"partNum":2,"eTag":"92ee1d92cda0f9f8de4429c9596773aa-34"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadResults")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Topaz.CompleteVideoUploadRequestUploadResult> UploadResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompleteVideoUploadRequest" /> class.
        /// </summary>
        /// <param name="uploadResults">
        /// An array of part number and ETag pairs of the uploaded parts. ETags are returned by S3 upon upload of the part.<br/>
        /// Example: [{"partNum":1,"eTag":"ff00a2c854712e4b4765eeefa084baa5-305"}, {"partNum":2,"eTag":"92ee1d92cda0f9f8de4429c9596773aa-34"}]
        /// </param>
        /// <param name="md5Hash">
        /// MD5 hash of the source video file in hex<br/>
        /// Example: 4d186321c1a7f0f354b297e8914ab240
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompleteVideoUploadRequest(
            global::System.Collections.Generic.IList<global::Topaz.CompleteVideoUploadRequestUploadResult> uploadResults,
            string? md5Hash)
        {
            this.Md5Hash = md5Hash;
            this.UploadResults = uploadResults ?? throw new global::System.ArgumentNullException(nameof(uploadResults));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompleteVideoUploadRequest" /> class.
        /// </summary>
        public CompleteVideoUploadRequest()
        {
        }
    }
}