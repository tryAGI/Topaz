
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompleteVideoUploadRequestUploadResult
    {
        /// <summary>
        /// Part number of the uploaded part, starting from 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partNum")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PartNum { get; set; }

        /// <summary>
        /// eTag value returned by S3 upon upload of the part
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eTag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ETag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompleteVideoUploadRequestUploadResult" /> class.
        /// </summary>
        /// <param name="partNum">
        /// Part number of the uploaded part, starting from 1
        /// </param>
        /// <param name="eTag">
        /// eTag value returned by S3 upon upload of the part
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompleteVideoUploadRequestUploadResult(
            int partNum,
            string eTag)
        {
            this.PartNum = partNum;
            this.ETag = eTag ?? throw new global::System.ArgumentNullException(nameof(eTag));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompleteVideoUploadRequestUploadResult" /> class.
        /// </summary>
        public CompleteVideoUploadRequestUploadResult()
        {
        }
    }
}