
#nullable enable

namespace Topaz
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VideoRequestRecordDestination
    {
        /// <summary>
        /// Example: mp4
        /// </summary>
        /// <example>mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("container")]
        public string? Container { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frameCount")]
        public double? FrameCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frameRate")]
        public double? FrameRate { get; set; }

        /// <summary>
        /// In seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// In bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public long? Size { get; set; }

        /// <summary>
        /// Signed download URL to the enhanced video file.<br/>
        /// The URL is generated once and then reused for the lifetime of the request — subsequent calls return the same `url`, `expiresIn` and `expiresAt` rather than a freshly signed URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download")]
        public global::Topaz.EnhancedDownloadSignedUrlResponse? Download { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoRequestRecordDestination" /> class.
        /// </summary>
        /// <param name="container">
        /// Example: mp4
        /// </param>
        /// <param name="frameCount"></param>
        /// <param name="frameRate"></param>
        /// <param name="duration">
        /// In seconds
        /// </param>
        /// <param name="size">
        /// In bytes
        /// </param>
        /// <param name="download">
        /// Signed download URL to the enhanced video file.<br/>
        /// The URL is generated once and then reused for the lifetime of the request — subsequent calls return the same `url`, `expiresIn` and `expiresAt` rather than a freshly signed URL.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoRequestRecordDestination(
            string? container,
            double? frameCount,
            double? frameRate,
            double? duration,
            long? size,
            global::Topaz.EnhancedDownloadSignedUrlResponse? download)
        {
            this.Container = container;
            this.FrameCount = frameCount;
            this.FrameRate = frameRate;
            this.Duration = duration;
            this.Size = size;
            this.Download = download;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoRequestRecordDestination" /> class.
        /// </summary>
        public VideoRequestRecordDestination()
        {
        }

    }
}