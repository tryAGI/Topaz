
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Source details for the video
    /// </summary>
    public sealed partial class CreateExpressVideoRequestRequestSource
    {
        /// <summary>
        /// The container format of the video file<br/>
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
        /// 
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
        /// The container format of the video file<br/>
        /// Example: mp4
        /// </param>
        /// <param name="md5Hash">
        /// MD5 hash of the source video file in hex<br/>
        /// Example: 5d41402abc4b2a76b9719d911017c592
        /// </param>
        /// <param name="external"></param>
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