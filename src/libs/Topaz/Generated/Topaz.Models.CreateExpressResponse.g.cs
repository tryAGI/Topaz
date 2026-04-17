
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateExpressResponse
    {
        /// <summary>
        /// Example: c1f96dc2-c448-00e6-82ed-14ecb6403c62
        /// </summary>
        /// <example>c1f96dc2-c448-00e6-82ed-14ecb6403c62</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public global::System.Guid? RequestId { get; set; }

        /// <summary>
        /// Upload ID for completing multi-part upload<br/>
        /// Example: GDlWC7qIaE6okS41Xf/ktpuS5XzTRabg
        /// </summary>
        /// <example>GDlWC7qIaE6okS41Xf/ktpuS5XzTRabg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadId")]
        public string? UploadId { get; set; }

        /// <summary>
        /// URL to PUT the parts to<br/>
        /// Example: [https://videocloud.s3.amazonaws.com/0193893a-a2ba-799e-b258-928f02c0f419/source.mp4?X-Amz-Algorithm=AWS4-HMAC-SHA256...x-id=PutObject]
        /// </summary>
        /// <example>[https://videocloud.s3.amazonaws.com/0193893a-a2ba-799e-b258-928f02c0f419/source.mp4?X-Amz-Algorithm=AWS4-HMAC-SHA256...x-id=PutObject]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadUrls")]
        public global::System.Collections.Generic.IList<string>? UploadUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExpressResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Example: c1f96dc2-c448-00e6-82ed-14ecb6403c62
        /// </param>
        /// <param name="uploadId">
        /// Upload ID for completing multi-part upload<br/>
        /// Example: GDlWC7qIaE6okS41Xf/ktpuS5XzTRabg
        /// </param>
        /// <param name="uploadUrls">
        /// URL to PUT the parts to<br/>
        /// Example: [https://videocloud.s3.amazonaws.com/0193893a-a2ba-799e-b258-928f02c0f419/source.mp4?X-Amz-Algorithm=AWS4-HMAC-SHA256...x-id=PutObject]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateExpressResponse(
            global::System.Guid? requestId,
            string? uploadId,
            global::System.Collections.Generic.IList<string>? uploadUrls)
        {
            this.RequestId = requestId;
            this.UploadId = uploadId;
            this.UploadUrls = uploadUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExpressResponse" /> class.
        /// </summary>
        public CreateExpressResponse()
        {
        }
    }
}