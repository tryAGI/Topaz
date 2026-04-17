
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AcceptResponse
    {
        /// <summary>
        /// Upload ID for completing multi-part upload<br/>
        /// Example: GDlWC7qIaE6okS41Xf/ktpuS5XzTRabg
        /// </summary>
        /// <example>GDlWC7qIaE6okS41Xf/ktpuS5XzTRabg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadId")]
        public string? UploadId { get; set; }

        /// <summary>
        /// URLs to PUT the parts to. The source video should be split into urls.length number of byte ranges.<br/>
        /// Example: [https://videocloud.s3.amazonaws.com/0193893a-a2ba-799e-b258-928f02c0f419/source.mp4?X-Amz-Algorithm=AWS4-HMAC-SHA256...x-id=UploadPart, https://videocloud.s3.amazonaws.com/0193893a-a2ba-799e-b258-928f02c0f419/source.mp4?X-Amz-Algorithm=AWS4-HMAC-SHA256...x-id=UploadPart]
        /// </summary>
        /// <example>[https://videocloud.s3.amazonaws.com/0193893a-a2ba-799e-b258-928f02c0f419/source.mp4?X-Amz-Algorithm=AWS4-HMAC-SHA256...x-id=UploadPart, https://videocloud.s3.amazonaws.com/0193893a-a2ba-799e-b258-928f02c0f419/source.mp4?X-Amz-Algorithm=AWS4-HMAC-SHA256...x-id=UploadPart]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        public global::System.Collections.Generic.IList<string>? Urls { get; set; }

        /// <summary>
        /// The endpoint will return message only if the video will be sourced from an external storage provider<br/>
        /// Example: Accepted
        /// </summary>
        /// <example>Accepted</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptResponse" /> class.
        /// </summary>
        /// <param name="uploadId">
        /// Upload ID for completing multi-part upload<br/>
        /// Example: GDlWC7qIaE6okS41Xf/ktpuS5XzTRabg
        /// </param>
        /// <param name="urls">
        /// URLs to PUT the parts to. The source video should be split into urls.length number of byte ranges.<br/>
        /// Example: [https://videocloud.s3.amazonaws.com/0193893a-a2ba-799e-b258-928f02c0f419/source.mp4?X-Amz-Algorithm=AWS4-HMAC-SHA256...x-id=UploadPart, https://videocloud.s3.amazonaws.com/0193893a-a2ba-799e-b258-928f02c0f419/source.mp4?X-Amz-Algorithm=AWS4-HMAC-SHA256...x-id=UploadPart]
        /// </param>
        /// <param name="message">
        /// The endpoint will return message only if the video will be sourced from an external storage provider<br/>
        /// Example: Accepted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AcceptResponse(
            string? uploadId,
            global::System.Collections.Generic.IList<string>? urls,
            string? message)
        {
            this.UploadId = uploadId;
            this.Urls = urls;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptResponse" /> class.
        /// </summary>
        public AcceptResponse()
        {
        }
    }
}