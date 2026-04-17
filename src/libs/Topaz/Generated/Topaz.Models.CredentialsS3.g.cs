
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CredentialsS3
    {
        /// <summary>
        /// AWS ARN of the role to assume<br/>
        /// Example: arn:aws:iam::123456789:role/topazlabs
        /// </summary>
        /// <example>arn:aws:iam::123456789:role/topazlabs</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("roleArn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoleArn { get; set; }

        /// <summary>
        /// Kind of like a secret string for extra layer of security<br/>
        /// Example: MSTnuGztXtTU25XKjVfMJCsujv6VtAGtv1TGSjtOL6M=
        /// </summary>
        /// <example>MSTnuGztXtTU25XKjVfMJCsujv6VtAGtv1TGSjtOL6M=</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialsS3" /> class.
        /// </summary>
        /// <param name="roleArn">
        /// AWS ARN of the role to assume<br/>
        /// Example: arn:aws:iam::123456789:role/topazlabs
        /// </param>
        /// <param name="externalId">
        /// Kind of like a secret string for extra layer of security<br/>
        /// Example: MSTnuGztXtTU25XKjVfMJCsujv6VtAGtv1TGSjtOL6M=
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CredentialsS3(
            string roleArn,
            string externalId)
        {
            this.RoleArn = roleArn ?? throw new global::System.ArgumentNullException(nameof(roleArn));
            this.ExternalId = externalId ?? throw new global::System.ArgumentNullException(nameof(externalId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialsS3" /> class.
        /// </summary>
        public CredentialsS3()
        {
        }
    }
}