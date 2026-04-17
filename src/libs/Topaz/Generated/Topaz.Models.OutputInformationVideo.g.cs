
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OutputInformationVideo
    {
        /// <summary>
        /// Desired output resolution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Topaz.OutputInformationVideoResolution Resolution { get; set; }

        /// <summary>
        /// Frame rate<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("frameRate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FrameRate { get; set; }

        /// <summary>
        /// Audio bitrate, if audioTransfer is Copy or Convert. Default values for the codec are used if not provided.<br/>
        /// Example: 320
        /// </summary>
        /// <example>320</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioBitrate")]
        public string? AudioBitrate { get; set; }

        /// <summary>
        /// __Required if audioTransfer is Copy or Convert.__<br/>
        /// Example: AAC
        /// </summary>
        /// <example>AAC</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioCodec")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.OutputInformationVideoAudioCodecJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Topaz.OutputInformationVideoAudioCodec AudioCodec { get; set; }

        /// <summary>
        /// Example: Copy
        /// </summary>
        /// <example>Copy</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioTransfer")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.OutputInformationVideoAudioTransferJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Topaz.OutputInformationVideoAudioTransfer AudioTransfer { get; set; }

        /// <summary>
        /// Video codec ID, if known. Defaults to videoEncoder.<br/>
        /// Example: h265-main-win-nvidia
        /// </summary>
        /// <example>h265-main-win-nvidia</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("codecId")]
        public string? CodecId { get; set; }

        /// <summary>
        /// Example: H265
        /// </summary>
        /// <example>H265</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoEncoder")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.OutputInformationVideoVideoEncoderJsonConverter))]
        public global::Topaz.OutputInformationVideoVideoEncoder? VideoEncoder { get; set; }

        /// <summary>
        /// __Required if dynamicCompressionLevel is not provided.__ Constant bitrate, suffixed with "k" for kilobits or "m" for megabits per second.<br/>
        /// Example: 1k
        /// </summary>
        /// <example>1k</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoBitrate")]
        public string? VideoBitrate { get; set; }

        /// <summary>
        /// __Required if videoBitrate is not provided.__ Automatic CQP selection.<br/>
        /// Example: Mid
        /// </summary>
        /// <example>Mid</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamicCompressionLevel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.OutputInformationVideoDynamicCompressionLevelJsonConverter))]
        public global::Topaz.OutputInformationVideoDynamicCompressionLevel? DynamicCompressionLevel { get; set; }

        /// <summary>
        /// Codec profile specific to videoEncoder. The following are some combinations of available profiles based on the 'videoEncoder' selection &lt;table&gt; &lt;tr&gt; &lt;td&gt;H264&lt;/td&gt; &lt;td&gt;H265&lt;/td&gt; &lt;td&gt;ProRes &lt;td&gt;AV1 &lt;td&gt;VP9 &lt;/tr&gt; &lt;tr&gt; &lt;td&gt;High&lt;/td&gt; &lt;td&gt;Main, Main10&lt;/td&gt; &lt;td&gt;422 Proxy, 422 LT, 422 Std, 422 HQ&lt;/td&gt; &lt;td&gt;8-bit, 10-bit&lt;/td&gt; &lt;td&gt;Good, Best&lt;/td&gt; &lt;/tr&gt; &lt;/table&gt;<br/>
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
        /// Desired output container<br/>
        /// Example: mp4
        /// </summary>
        /// <example>mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("container")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.OutputInformationVideoContainerJsonConverter))]
        public global::Topaz.OutputInformationVideoContainer? Container { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputInformationVideo" /> class.
        /// </summary>
        /// <param name="resolution">
        /// Desired output resolution
        /// </param>
        /// <param name="frameRate">
        /// Frame rate<br/>
        /// Example: 30
        /// </param>
        /// <param name="audioCodec">
        /// __Required if audioTransfer is Copy or Convert.__<br/>
        /// Example: AAC
        /// </param>
        /// <param name="audioTransfer">
        /// Example: Copy
        /// </param>
        /// <param name="audioBitrate">
        /// Audio bitrate, if audioTransfer is Copy or Convert. Default values for the codec are used if not provided.<br/>
        /// Example: 320
        /// </param>
        /// <param name="codecId">
        /// Video codec ID, if known. Defaults to videoEncoder.<br/>
        /// Example: h265-main-win-nvidia
        /// </param>
        /// <param name="videoEncoder">
        /// Example: H265
        /// </param>
        /// <param name="videoBitrate">
        /// __Required if dynamicCompressionLevel is not provided.__ Constant bitrate, suffixed with "k" for kilobits or "m" for megabits per second.<br/>
        /// Example: 1k
        /// </param>
        /// <param name="dynamicCompressionLevel">
        /// __Required if videoBitrate is not provided.__ Automatic CQP selection.<br/>
        /// Example: Mid
        /// </param>
        /// <param name="videoProfile">
        /// Codec profile specific to videoEncoder. The following are some combinations of available profiles based on the 'videoEncoder' selection &lt;table&gt; &lt;tr&gt; &lt;td&gt;H264&lt;/td&gt; &lt;td&gt;H265&lt;/td&gt; &lt;td&gt;ProRes &lt;td&gt;AV1 &lt;td&gt;VP9 &lt;/tr&gt; &lt;tr&gt; &lt;td&gt;High&lt;/td&gt; &lt;td&gt;Main, Main10&lt;/td&gt; &lt;td&gt;422 Proxy, 422 LT, 422 Std, 422 HQ&lt;/td&gt; &lt;td&gt;8-bit, 10-bit&lt;/td&gt; &lt;td&gt;Good, Best&lt;/td&gt; &lt;/tr&gt; &lt;/table&gt;<br/>
        /// Example: Main
        /// </param>
        /// <param name="cropToFit">
        /// Center cropping to fit the output dimensions<br/>
        /// Example: true
        /// </param>
        /// <param name="container">
        /// Desired output container<br/>
        /// Example: mp4
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputInformationVideo(
            global::Topaz.OutputInformationVideoResolution resolution,
            double frameRate,
            global::Topaz.OutputInformationVideoAudioCodec audioCodec,
            global::Topaz.OutputInformationVideoAudioTransfer audioTransfer,
            string? audioBitrate,
            string? codecId,
            global::Topaz.OutputInformationVideoVideoEncoder? videoEncoder,
            string? videoBitrate,
            global::Topaz.OutputInformationVideoDynamicCompressionLevel? dynamicCompressionLevel,
            string? videoProfile,
            bool? cropToFit,
            global::Topaz.OutputInformationVideoContainer? container)
        {
            this.Resolution = resolution ?? throw new global::System.ArgumentNullException(nameof(resolution));
            this.FrameRate = frameRate;
            this.AudioBitrate = audioBitrate;
            this.AudioCodec = audioCodec;
            this.AudioTransfer = audioTransfer;
            this.CodecId = codecId;
            this.VideoEncoder = videoEncoder;
            this.VideoBitrate = videoBitrate;
            this.DynamicCompressionLevel = dynamicCompressionLevel;
            this.VideoProfile = videoProfile;
            this.CropToFit = cropToFit;
            this.Container = container;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputInformationVideo" /> class.
        /// </summary>
        public OutputInformationVideo()
        {
        }
    }
}