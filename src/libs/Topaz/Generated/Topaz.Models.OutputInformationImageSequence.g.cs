
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OutputInformationImageSequence
    {
        /// <summary>
        /// Desired output resolution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Topaz.OutputInformationImageSequenceResolution Resolution { get; set; }

        /// <summary>
        /// Frame rate<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("frameRate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FrameRate { get; set; }

        /// <summary>
        /// Video codec ID, if known. Defaults to videoEncoder.<br/>
        /// Example: h265-main-win-nvidia
        /// </summary>
        /// <example>h265-main-win-nvidia</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("codecId")]
        public string? CodecId { get; set; }

        /// <summary>
        /// Example: TIFF
        /// </summary>
        /// <example>TIFF</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoEncoder")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.OutputInformationImageSequenceVideoEncoderJsonConverter))]
        public global::Topaz.OutputInformationImageSequenceVideoEncoder? VideoEncoder { get; set; }

        /// <summary>
        /// Codec profile specific to videoEncoder<br/>
        /// Example: Main
        /// </summary>
        /// <example>Main</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoProfile")]
        public string? VideoProfile { get; set; }

        /// <summary>
        /// Center cropping to fit the output dimensions<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cropToFit")]
        public bool? CropToFit { get; set; }

        /// <summary>
        /// Desired output container, defaults to the input container<br/>
        /// Example: TIFF
        /// </summary>
        /// <example>TIFF</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("container")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.OutputInformationImageSequenceContainerJsonConverter))]
        public global::Topaz.OutputInformationImageSequenceContainer? Container { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputInformationImageSequence" /> class.
        /// </summary>
        /// <param name="resolution">
        /// Desired output resolution
        /// </param>
        /// <param name="frameRate">
        /// Frame rate<br/>
        /// Example: 30
        /// </param>
        /// <param name="codecId">
        /// Video codec ID, if known. Defaults to videoEncoder.<br/>
        /// Example: h265-main-win-nvidia
        /// </param>
        /// <param name="videoEncoder">
        /// Example: TIFF
        /// </param>
        /// <param name="videoProfile">
        /// Codec profile specific to videoEncoder<br/>
        /// Example: Main
        /// </param>
        /// <param name="cropToFit">
        /// Center cropping to fit the output dimensions<br/>
        /// Example: true
        /// </param>
        /// <param name="container">
        /// Desired output container, defaults to the input container<br/>
        /// Example: TIFF
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputInformationImageSequence(
            global::Topaz.OutputInformationImageSequenceResolution resolution,
            double frameRate,
            string? codecId,
            global::Topaz.OutputInformationImageSequenceVideoEncoder? videoEncoder,
            string? videoProfile,
            bool? cropToFit,
            global::Topaz.OutputInformationImageSequenceContainer? container)
        {
            this.Resolution = resolution ?? throw new global::System.ArgumentNullException(nameof(resolution));
            this.FrameRate = frameRate;
            this.CodecId = codecId;
            this.VideoEncoder = videoEncoder;
            this.VideoProfile = videoProfile;
            this.CropToFit = cropToFit;
            this.Container = container;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputInformationImageSequence" /> class.
        /// </summary>
        public OutputInformationImageSequence()
        {
        }
    }
}