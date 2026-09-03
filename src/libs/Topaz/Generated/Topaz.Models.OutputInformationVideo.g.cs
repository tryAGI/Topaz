
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Desired output settings.<br/>
    /// Some values are adjusted server-side before processing:<br/>
    /// - `resolution` width and height are rounded up to the nearest multiple of 4.<br/>
    /// - `resolution` is forced to the source resolution when no upscale model is present in `filters`.<br/>
    /// - `frameRate` is forced to the source frame rate when no frame interpolation model is present in `filters`, and defaults to it when omitted.<br/>
    /// - With a frame interpolation model, `frameRate` and that filter's `fps` are both set to the greater of the two.<br/>
    /// - `container` is forced to `mov` when `videoEncoder` is `ProRes` and to `mp4` when it is `AV1` or `VP9`, and defaults to `mp4` otherwise.<br/>
    /// The express endpoint supplies no source metadata, so nothing is inferred from the source there: only `resolution` is required, `frameRate` is required only when a frame interpolation filter omits its own `fps`, and the rest of the fields listed as required below take the defaults noted above.<br/>
    /// #### Supported encoders and profiles<br/>
    /// Every accepted `videoEncoder` / `videoProfile` pair is listed below. `videoEncoder` defaults to `H265` and `videoProfile` to the default profile of the chosen encoder. Any other combination is rejected with `400` `INVALID_INPUT`, and the error message lists the profiles the encoder does support.<br/>
    /// | **videoEncoder** | **videoProfile**     | **container**       | **Max resolution** |<br/>
    /// |------------------|----------------------|---------------------|--------------------|<br/>
    /// | AV1              | `8-bit` _(default)_  | `mp4`               | 16384 x 8704       |<br/>
    /// | AV1              | `10-bit`             | `mp4`               | 16384 x 8704       |<br/>
    /// | H264             | `High` _(default)_   | `mp4`, `mov`, `mkv` | 4096 x 4096        |<br/>
    /// | H265             | `Main`               | `mp4`, `mov`, `mkv` | 8192 x 8192        |<br/>
    /// | H265             | `Main10` _(default)_ | `mp4`, `mov`, `mkv` | 8192 x 8192        |<br/>
    /// | ProRes           | `422 Proxy`          | `mov`               | 16386 x 16386      |<br/>
    /// | ProRes           | `422 LT`             | `mov`               | 16386 x 16386      |<br/>
    /// | ProRes           | `422 Std`            | `mov`               | 16386 x 16386      |<br/>
    /// | ProRes           | `422 HQ` _(default)_ | `mov`               | 16386 x 16386      |<br/>
    /// | VP9              | `Good` _(default)_   | `mp4`               | 8192 x 8192        |<br/>
    /// | VP9              | `Best`               | `mp4`               | 8192 x 8192        |<br/>
    /// - Encoder and profile values are matched case-insensitively.<br/>
    /// - **Max resolution** applies in either orientation, so AV1 also accepts 8704 x 16384. Exceeding it is rejected with `400` `INVALID_INPUT`.<br/>
    /// - **container** lists the containers you can receive for that encoder. ProRes, AV1, and VP9 replace whatever `container` you send with the single value shown; H264 and H265 honor your choice among the values shown.<br/>
    /// - `videoBitrate` is capped per encoder — **800 mbps** for AV1, **2000 mbps** for H264, H265, and VP9, and uncapped for ProRes. A higher value is rejected with `400` `INVALID_INPUT` — unless `dynamicCompressionLevel` is also set, in which case `videoBitrate` is discarded and the compression level is used instead.<br/>
    /// - `VP9` requires `videoBitrate`. Selecting it without one is rejected with `400` `INVALID_INPUT`.<br/>
    /// - `dynamicCompressionLevel` maps to a CQP value defined per encoder and profile, and applies to AV1, H264, and H265 only.<br/>
    /// - For ProRes and VP9 the storage portion of the cost estimate is derived from the source file size rather than a predicted output size.
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
        /// __Required unless audioTransfer is None.__<br/>
        /// Example: AAC
        /// </summary>
        /// <example>AAC</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioCodec")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.OutputInformationVideoAudioCodecJsonConverter))]
        public global::Topaz.OutputInformationVideoAudioCodec? AudioCodec { get; set; }

        /// <summary>
        /// Example: Copy
        /// </summary>
        /// <example>Copy</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioTransfer")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.OutputInformationVideoAudioTransferJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Topaz.OutputInformationVideoAudioTransfer AudioTransfer { get; set; }

        /// <summary>
        /// Video encoder for the output. Defaults to `H265`. See **Supported encoders and profiles** above for the profiles, containers, and limits of each encoder.<br/>
        /// Example: H265
        /// </summary>
        /// <example>H265</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoEncoder")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.OutputInformationVideoVideoEncoderJsonConverter))]
        public global::Topaz.OutputInformationVideoVideoEncoder? VideoEncoder { get; set; }

        /// <summary>
        /// Constant bitrate, suffixed with "k" for kilobits or "m" for megabits per second. Mutually exclusive with `dynamicCompressionLevel`. __Required when `videoEncoder` is `VP9`.__ Each encoder caps this value — see **Supported encoders and profiles** above.<br/>
        /// Example: 1k
        /// </summary>
        /// <example>1k</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoBitrate")]
        public string? VideoBitrate { get; set; }

        /// <summary>
        /// Automatic CQP selection. Mutually exclusive with `videoBitrate`. If neither is provided, this defaults to `High`. Applies to the `AV1`, `H264`, and `H265` encoders only.<br/>
        /// Example: Mid
        /// </summary>
        /// <example>Mid</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamicCompressionLevel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.OutputInformationVideoDynamicCompressionLevelJsonConverter))]
        public global::Topaz.OutputInformationVideoDynamicCompressionLevel? DynamicCompressionLevel { get; set; }

        /// <summary>
        /// Codec profile, specific to the chosen `videoEncoder`. Defaults to that encoder's default profile (`Main10` for `H265`). See **Supported encoders and profiles** above for the accepted values.<br/>
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
        /// Desired output container. Defaults to `mp4`. Ignored and replaced with `mov` when `videoEncoder` is `ProRes`, and with `mp4` when it is `AV1` or `VP9`.<br/>
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
        /// <param name="audioTransfer">
        /// Example: Copy
        /// </param>
        /// <param name="audioBitrate">
        /// Audio bitrate, if audioTransfer is Copy or Convert. Default values for the codec are used if not provided.<br/>
        /// Example: 320
        /// </param>
        /// <param name="audioCodec">
        /// __Required unless audioTransfer is None.__<br/>
        /// Example: AAC
        /// </param>
        /// <param name="videoEncoder">
        /// Video encoder for the output. Defaults to `H265`. See **Supported encoders and profiles** above for the profiles, containers, and limits of each encoder.<br/>
        /// Example: H265
        /// </param>
        /// <param name="videoBitrate">
        /// Constant bitrate, suffixed with "k" for kilobits or "m" for megabits per second. Mutually exclusive with `dynamicCompressionLevel`. __Required when `videoEncoder` is `VP9`.__ Each encoder caps this value — see **Supported encoders and profiles** above.<br/>
        /// Example: 1k
        /// </param>
        /// <param name="dynamicCompressionLevel">
        /// Automatic CQP selection. Mutually exclusive with `videoBitrate`. If neither is provided, this defaults to `High`. Applies to the `AV1`, `H264`, and `H265` encoders only.<br/>
        /// Example: Mid
        /// </param>
        /// <param name="videoProfile">
        /// Codec profile, specific to the chosen `videoEncoder`. Defaults to that encoder's default profile (`Main10` for `H265`). See **Supported encoders and profiles** above for the accepted values.<br/>
        /// Example: Main
        /// </param>
        /// <param name="cropToFit">
        /// Center cropping to fit the output dimensions<br/>
        /// Example: true
        /// </param>
        /// <param name="container">
        /// Desired output container. Defaults to `mp4`. Ignored and replaced with `mov` when `videoEncoder` is `ProRes`, and with `mp4` when it is `AV1` or `VP9`.<br/>
        /// Example: mp4
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputInformationVideo(
            global::Topaz.OutputInformationVideoResolution resolution,
            double frameRate,
            global::Topaz.OutputInformationVideoAudioTransfer audioTransfer,
            string? audioBitrate,
            global::Topaz.OutputInformationVideoAudioCodec? audioCodec,
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