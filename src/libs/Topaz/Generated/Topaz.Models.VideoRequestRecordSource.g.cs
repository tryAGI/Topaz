
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Source details. `frameCount`, `frameRate`, `resolution`, `size` and `duration` start as the values you supplied and are corrected once the system analyzes the file.
    /// </summary>
    public sealed partial class VideoRequestRecordSource
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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public global::Topaz.VideoRequestRecordSourceResolution? Resolution { get; set; }

        /// <summary>
        /// In bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public long? Size { get; set; }

        /// <summary>
        /// In seconds, or the frame count for image sequence requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Image sequence requests only
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startNumber")]
        public int? StartNumber { get; set; }

        /// <summary>
        /// Image sequence requests only, exclusive
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endNumber")]
        public int? EndNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("md5Hash")]
        public string? Md5Hash { get; set; }

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
        /// Initializes a new instance of the <see cref="VideoRequestRecordSource" /> class.
        /// </summary>
        /// <param name="container">
        /// Example: mp4
        /// </param>
        /// <param name="frameCount"></param>
        /// <param name="frameRate"></param>
        /// <param name="resolution"></param>
        /// <param name="size">
        /// In bytes
        /// </param>
        /// <param name="duration">
        /// In seconds, or the frame count for image sequence requests
        /// </param>
        /// <param name="startNumber">
        /// Image sequence requests only
        /// </param>
        /// <param name="endNumber">
        /// Image sequence requests only, exclusive
        /// </param>
        /// <param name="md5Hash"></param>
        /// <param name="download">
        /// Signed download URL to the enhanced video file.<br/>
        /// The URL is generated once and then reused for the lifetime of the request — subsequent calls return the same `url`, `expiresIn` and `expiresAt` rather than a freshly signed URL.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoRequestRecordSource(
            string? container,
            double? frameCount,
            double? frameRate,
            global::Topaz.VideoRequestRecordSourceResolution? resolution,
            long? size,
            double? duration,
            int? startNumber,
            int? endNumber,
            string? md5Hash,
            global::Topaz.EnhancedDownloadSignedUrlResponse? download)
        {
            this.Container = container;
            this.FrameCount = frameCount;
            this.FrameRate = frameRate;
            this.Resolution = resolution;
            this.Size = size;
            this.Duration = duration;
            this.StartNumber = startNumber;
            this.EndNumber = endNumber;
            this.Md5Hash = md5Hash;
            this.Download = download;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoRequestRecordSource" /> class.
        /// </summary>
        public VideoRequestRecordSource()
        {
        }

    }
}