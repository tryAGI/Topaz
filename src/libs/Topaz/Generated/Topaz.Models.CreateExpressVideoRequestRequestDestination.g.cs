
#nullable enable

namespace Topaz
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateExpressVideoRequestRequestDestination
    {
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
        /// Initializes a new instance of the <see cref="CreateExpressVideoRequestRequestDestination" /> class.
        /// </summary>
        /// <param name="external">
        /// External storage configuration for source or destination files. `provider` is required.<br/>
        /// Provide either `presignedUrl` alone, or all three of `awsCredentials`, `bucketName`, and `key` together for AWS STS AssumeRole-based access.<br/>
        /// For destinations only, you may instead provide `multipart` with your own pre-signed multi-part upload URLs.<br/>
        /// Source access is verified when the request is created: the presigned URL is fetched, or the object is read using the assumed role. A failure here returns a 400.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateExpressVideoRequestRequestDestination(
            global::Topaz.ExternalStorage? external)
        {
            this.External = external;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExpressVideoRequestRequestDestination" /> class.
        /// </summary>
        public CreateExpressVideoRequestRequestDestination()
        {
        }

    }
}