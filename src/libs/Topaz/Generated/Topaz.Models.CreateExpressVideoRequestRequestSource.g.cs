
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Source details for the video
    /// </summary>
    public sealed partial class CreateExpressVideoRequestRequestSource
    {
        /// <summary>
        /// The container format of the video file. Matched case-insensitively.<br/>
        /// Example: mp4
        /// </summary>
        /// <example>mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("container")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.CreateExpressVideoRequestRequestSourceContainerJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Topaz.CreateExpressVideoRequestRequestSourceContainer Container { get; set; }

        /// <summary>
        /// MD5 hash of the source video file in hex<br/>
        /// Example: 5d41402abc4b2a76b9719d911017c592
        /// </summary>
        /// <example>5d41402abc4b2a76b9719d911017c592</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("md5Hash")]
        public string? Md5Hash { get; set; }

        /// <summary>
        /// External storage configuration for source or destination files. `provider` is required.<br/>
        /// Provide either `presignedUrl` alone, or all three of `awsCredentials`, `bucketName`, and `key` together for AWS STS AssumeRole-based access.<br/>
        /// For destinations only, you may instead provide `multipart` with your own pre-signed multi-part upload URLs.<br/>
        /// Source access is verified when the request is created: the presigned URL is fetched, or the object is read using the assumed role. A failure here returns a 400.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external")]
        public global::Topaz.ExternalStorage? External { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExpressVideoRequestRequestSource" /> class.
        /// </summary>
        /// <param name="container">
        /// The container format of the video file. Matched case-insensitively.<br/>
        /// Example: mp4
        /// </param>
        /// <param name="md5Hash">
        /// MD5 hash of the source video file in hex<br/>
        /// Example: 5d41402abc4b2a76b9719d911017c592
        /// </param>
        /// <param name="external">
        /// External storage configuration for source or destination files. `provider` is required.<br/>
        /// Provide either `presignedUrl` alone, or all three of `awsCredentials`, `bucketName`, and `key` together for AWS STS AssumeRole-based access.<br/>
        /// For destinations only, you may instead provide `multipart` with your own pre-signed multi-part upload URLs.<br/>
        /// Source access is verified when the request is created: the presigned URL is fetched, or the object is read using the assumed role. A failure here returns a 400.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateExpressVideoRequestRequestSource(
            global::Topaz.CreateExpressVideoRequestRequestSourceContainer container,
            string? md5Hash,
            global::Topaz.ExternalStorage? external)
        {
            this.Container = container;
            this.Md5Hash = md5Hash;
            this.External = external;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExpressVideoRequestRequestSource" /> class.
        /// </summary>
        public CreateExpressVideoRequestRequestSource()
        {
        }

    }
}