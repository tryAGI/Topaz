
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Source details for the video
    /// </summary>
    public sealed partial class CreateVideoRequestRequestSource
    {
        /// <summary>
        /// The container format of the video file<br/>
        /// Example: mp4
        /// </summary>
        /// <example>mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("container")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.CreateVideoRequestRequestSourceContainerJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Topaz.CreateVideoRequestRequestSourceContainer Container { get; set; }

        /// <summary>
        /// Size of the video file in bytes<br/>
        /// Example: 123456000
        /// </summary>
        /// <example>123456000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Size { get; set; }

        /// <summary>
        /// Duration of the video file in seconds<br/>
        /// Example: 600
        /// </summary>
        /// <example>600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Duration { get; set; }

        /// <summary>
        /// Total number of frames in the video<br/>
        /// Example: 18000
        /// </summary>
        /// <example>18000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("frameCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FrameCount { get; set; }

        /// <summary>
        /// Frame rate of the video<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("frameRate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FrameRate { get; set; }

        /// <summary>
        /// Resolution details of the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Topaz.CreateVideoRequestRequestSourceResolution Resolution { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateVideoRequestRequestSource" /> class.
        /// </summary>
        /// <param name="container">
        /// The container format of the video file<br/>
        /// Example: mp4
        /// </param>
        /// <param name="size">
        /// Size of the video file in bytes<br/>
        /// Example: 123456000
        /// </param>
        /// <param name="duration">
        /// Duration of the video file in seconds<br/>
        /// Example: 600
        /// </param>
        /// <param name="frameCount">
        /// Total number of frames in the video<br/>
        /// Example: 18000
        /// </param>
        /// <param name="frameRate">
        /// Frame rate of the video<br/>
        /// Example: 30
        /// </param>
        /// <param name="resolution">
        /// Resolution details of the video
        /// </param>
        /// <param name="external"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoRequestRequestSource(
            global::Topaz.CreateVideoRequestRequestSourceContainer container,
            int size,
            double duration,
            double frameCount,
            double frameRate,
            global::Topaz.CreateVideoRequestRequestSourceResolution resolution,
            global::Topaz.ExternalStorage? external)
        {
            this.Container = container;
            this.Size = size;
            this.Duration = duration;
            this.FrameCount = frameCount;
            this.FrameRate = frameRate;
            this.Resolution = resolution ?? throw new global::System.ArgumentNullException(nameof(resolution));
            this.External = external;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoRequestRequestSource" /> class.
        /// </summary>
        public CreateVideoRequestRequestSource()
        {
        }
    }
}