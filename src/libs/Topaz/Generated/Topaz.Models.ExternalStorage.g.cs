
#nullable enable

namespace Topaz
{
    /// <summary>
    /// External storage configuration for source or destination files. `provider` is required.<br/>
    /// Provide either `presignedUrl` alone, or all three of `awsCredentials`, `bucketName`, and `key` together for AWS STS AssumeRole-based access.<br/>
    /// For destinations only, you may instead provide `multipart` with your own pre-signed multi-part upload URLs.<br/>
    /// Source access is verified when the request is created: the presigned URL is fetched, or the object is read using the assumed role. A failure here returns a 400.
    /// </summary>
    public sealed partial class ExternalStorage
    {
        /// <summary>
        /// Example: s3
        /// </summary>
        /// <example>s3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.ExternalStorageProviderJsonConverter))]
        public global::Topaz.ExternalStorageProvider Provider { get; set; }

        /// <summary>
        /// Presigned URL to download the source video from or upload the output video to. Provide this alone, or use `awsCredentials`, `bucketName`, and `key` instead.<br/>
        /// Example: https://videocloud.s3.amazonaws.com/0193893a-a2ba-799e-b258-928f02c0f419/output.mp4?X-Amz-Algorithm=AWS4-HMAC-SHA256...x-id=PutObject
        /// </summary>
        /// <example>https://videocloud.s3.amazonaws.com/0193893a-a2ba-799e-b258-928f02c0f419/output.mp4?X-Amz-Algorithm=AWS4-HMAC-SHA256...x-id=PutObject</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("presignedUrl")]
        public string? PresignedUrl { get; set; }

        /// <summary>
        /// AWS STS AssumeRole credentials for accessing the bucket. Required when using `awsCredentials`/`bucketName`/`key` instead of `presignedUrl`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("awsCredentials")]
        public global::Topaz.CredentialsS3? AwsCredentials { get; set; }

        /// <summary>
        /// S3 bucket name. Required when using `awsCredentials`/`bucketName`/`key` instead of `presignedUrl`.<br/>
        /// Example: galaxies
        /// </summary>
        /// <example>galaxies</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucketName")]
        public string? BucketName { get; set; }

        /// <summary>
        /// S3 object key. Required when using `awsCredentials`/`bucketName`/`key` instead of `presignedUrl`.<br/>
        /// The example includes the standard specifier for image sequence requests, with optional directory path. It must begin with "%" and end with the integer specifier "d". The "0" in the example indicates left-padding with zeroes, and "6" indicates the number of digits in the file name.<br/>
        /// Keys for video requests must be valid characters supported by S3.<br/>
        /// Example: milky_way/%06d.tiff
        /// </summary>
        /// <example>milky_way/%06d.tiff</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Destination only. Your own pre-signed multi-part upload URLs. These are not validated by Topaz Labs before use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multipart")]
        public global::Topaz.ExternalStorageMultipart? Multipart { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalStorage" /> class.
        /// </summary>
        /// <param name="provider">
        /// Example: s3
        /// </param>
        /// <param name="presignedUrl">
        /// Presigned URL to download the source video from or upload the output video to. Provide this alone, or use `awsCredentials`, `bucketName`, and `key` instead.<br/>
        /// Example: https://videocloud.s3.amazonaws.com/0193893a-a2ba-799e-b258-928f02c0f419/output.mp4?X-Amz-Algorithm=AWS4-HMAC-SHA256...x-id=PutObject
        /// </param>
        /// <param name="awsCredentials">
        /// AWS STS AssumeRole credentials for accessing the bucket. Required when using `awsCredentials`/`bucketName`/`key` instead of `presignedUrl`.
        /// </param>
        /// <param name="bucketName">
        /// S3 bucket name. Required when using `awsCredentials`/`bucketName`/`key` instead of `presignedUrl`.<br/>
        /// Example: galaxies
        /// </param>
        /// <param name="key">
        /// S3 object key. Required when using `awsCredentials`/`bucketName`/`key` instead of `presignedUrl`.<br/>
        /// The example includes the standard specifier for image sequence requests, with optional directory path. It must begin with "%" and end with the integer specifier "d". The "0" in the example indicates left-padding with zeroes, and "6" indicates the number of digits in the file name.<br/>
        /// Keys for video requests must be valid characters supported by S3.<br/>
        /// Example: milky_way/%06d.tiff
        /// </param>
        /// <param name="multipart">
        /// Destination only. Your own pre-signed multi-part upload URLs. These are not validated by Topaz Labs before use.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExternalStorage(
            global::Topaz.ExternalStorageProvider provider,
            string? presignedUrl,
            global::Topaz.CredentialsS3? awsCredentials,
            string? bucketName,
            string? key,
            global::Topaz.ExternalStorageMultipart? multipart)
        {
            this.Provider = provider;
            this.PresignedUrl = presignedUrl;
            this.AwsCredentials = awsCredentials;
            this.BucketName = bucketName;
            this.Key = key;
            this.Multipart = multipart;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalStorage" /> class.
        /// </summary>
        public ExternalStorage()
        {
        }

    }
}