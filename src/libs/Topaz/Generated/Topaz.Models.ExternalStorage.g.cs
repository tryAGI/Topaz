
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
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
        /// Presigned URL to download the source video from or upload the output video to<br/>
        /// Example: https://videocloud.s3.amazonaws.com/0193893a-a2ba-799e-b258-928f02c0f419/output.mp4?X-Amz-Algorithm=AWS4-HMAC-SHA256...x-id=PutObject
        /// </summary>
        /// <example>https://videocloud.s3.amazonaws.com/0193893a-a2ba-799e-b258-928f02c0f419/output.mp4?X-Amz-Algorithm=AWS4-HMAC-SHA256...x-id=PutObject</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("presignedUrl")]
        public string? PresignedUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("awsCredentials")]
        public global::Topaz.CredentialsS3? AwsCredentials { get; set; }

        /// <summary>
        /// Example: galaxies
        /// </summary>
        /// <example>galaxies</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucketName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BucketName { get; set; }

        /// <summary>
        /// The example includes the standard specifier for image sequence requests, with optional directory path. It must begin with "%" and end with the integer specifier "d". The "0" in the example indicates left-padding with zeroes, and "6" indicates the number of digits in the file name.<br/>
        /// Keys for video requests must be valid characters supported by S3.<br/>
        /// Example: milky_way/%06d.tiff
        /// </summary>
        /// <example>milky_way/%06d.tiff</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalStorage" /> class.
        /// </summary>
        /// <param name="bucketName">
        /// Example: galaxies
        /// </param>
        /// <param name="key">
        /// The example includes the standard specifier for image sequence requests, with optional directory path. It must begin with "%" and end with the integer specifier "d". The "0" in the example indicates left-padding with zeroes, and "6" indicates the number of digits in the file name.<br/>
        /// Keys for video requests must be valid characters supported by S3.<br/>
        /// Example: milky_way/%06d.tiff
        /// </param>
        /// <param name="provider">
        /// Example: s3
        /// </param>
        /// <param name="presignedUrl">
        /// Presigned URL to download the source video from or upload the output video to<br/>
        /// Example: https://videocloud.s3.amazonaws.com/0193893a-a2ba-799e-b258-928f02c0f419/output.mp4?X-Amz-Algorithm=AWS4-HMAC-SHA256...x-id=PutObject
        /// </param>
        /// <param name="awsCredentials"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExternalStorage(
            string bucketName,
            string key,
            global::Topaz.ExternalStorageProvider provider,
            string? presignedUrl,
            global::Topaz.CredentialsS3? awsCredentials)
        {
            this.Provider = provider;
            this.PresignedUrl = presignedUrl;
            this.AwsCredentials = awsCredentials;
            this.BucketName = bucketName ?? throw new global::System.ArgumentNullException(nameof(bucketName));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalStorage" /> class.
        /// </summary>
        public ExternalStorage()
        {
        }
    }
}