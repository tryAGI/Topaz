
#nullable enable

namespace Topaz
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpscaleFilter
    {
        /// <summary>
        /// Short code name for the AI model.<br/>
        /// Newer models may be accepted before they appear in this list — call `GET /video/status` for the authoritative set of currently supported models.<br/>
        /// Example: prob-4
        /// </summary>
        /// <example>prob-4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.UpscaleFilterModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Topaz.UpscaleFilterModel Model { get; set; }

        /// <summary>
        /// Frame/field type of the video<br/>
        /// Example: Progressive
        /// </summary>
        /// <example>Progressive</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.UpscaleFilterVideoTypeJsonConverter))]
        public global::Topaz.UpscaleFilterVideoType? VideoType { get; set; }

        /// <summary>
        /// Parameter mode of the selected model<br/>
        /// - Auto - parameter estimation is used with no customization<br/>
        /// - Relative - uses auto parameters with optional weights added<br/>
        /// - Manual - all parameters are manually set<br/>
        /// Example: Auto
        /// </summary>
        /// <example>Auto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.UpscaleFilterAutoJsonConverter))]
        public global::Topaz.UpscaleFilterAuto? Auto { get; set; }

        /// <summary>
        /// Optional specification of field order for interlaced input videos<br/>
        /// Example: Auto
        /// </summary>
        /// <example>Auto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fieldOrder")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.UpscaleFilterFieldOrderJsonConverter))]
        public global::Topaz.UpscaleFilterFieldOrder? FieldOrder { get; set; }

        /// <summary>
        /// Downscales video input for stronger correction of blurred subjects<br/>
        /// Example: Normal
        /// </summary>
        /// <example>Normal</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("focusFixLevel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.UpscaleFilterFocusFixLevelJsonConverter))]
        public global::Topaz.UpscaleFilterFocusFixLevel? FocusFixLevel { get; set; }

        /// <summary>
        /// Adjust strength of compression recovery<br/>
        /// Example: 0.1
        /// </summary>
        /// <example>0.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("compression")]
        public double? Compression { get; set; }

        /// <summary>
        /// Amount of detail reconstruction<br/>
        /// Example: 0.2
        /// </summary>
        /// <example>0.2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public double? Details { get; set; }

        /// <summary>
        /// Adds noise to input to reduce over-smoothing<br/>
        /// Example: 0.01
        /// </summary>
        /// <example>0.01</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prenoise")]
        public double? Prenoise { get; set; }

        /// <summary>
        /// Amount of noise reduction<br/>
        /// Example: 0.3
        /// </summary>
        /// <example>0.3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("noise")]
        public double? Noise { get; set; }

        /// <summary>
        /// Amount of halo reduction<br/>
        /// Example: 0.4
        /// </summary>
        /// <example>0.4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("halo")]
        public double? Halo { get; set; }

        /// <summary>
        /// Adjust anti-aliasing and deblurring strength<br/>
        /// Example: 0.5
        /// </summary>
        /// <example>0.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("preblur")]
        public double? Preblur { get; set; }

        /// <summary>
        /// Amount of sharpness applied<br/>
        /// Example: 0.6
        /// </summary>
        /// <example>0.6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("blur")]
        public double? Blur { get; set; }

        /// <summary>
        /// Adds grain after AI model processing<br/>
        /// Example: 0.02
        /// </summary>
        /// <example>0.02</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("grain")]
        public double? Grain { get; set; }

        /// <summary>
        /// Grain granularity<br/>
        /// Example: 0.5
        /// </summary>
        /// <example>0.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("grainSigma")]
        public double? GrainSigma { get; set; }

        /// <summary>
        /// Size of generated grain<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("grainSize")]
        public double? GrainSize { get; set; }

        /// <summary>
        /// Type of grain<br/>
        /// Example: gaussian
        /// </summary>
        /// <example>gaussian</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("grainType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.UpscaleFilterGrainTypeJsonConverter))]
        public global::Topaz.UpscaleFilterGrainType? GrainType { get; set; }

        /// <summary>
        /// Reintroduce source details into the output video<br/>
        /// Example: 0.7
        /// </summary>
        /// <example>0.7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("recoverOriginalDetailValue")]
        public double? RecoverOriginalDetailValue { get; set; }

        /// <summary>
        /// HDR transfer function. Applies to the Hyperion model (`hyp-1`).<br/>
        /// Example: pq
        /// </summary>
        /// <example>pq</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("transferFunction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.UpscaleFilterTransferFunctionJsonConverter))]
        public global::Topaz.UpscaleFilterTransferFunction? TransferFunction { get; set; }

        /// <summary>
        /// Exposure adjustment. Applies to the Hyperion model (`hyp-1`).<br/>
        /// Example: 0.5
        /// </summary>
        /// <example>0.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("adjustExposure")]
        public double? AdjustExposure { get; set; }

        /// <summary>
        /// Saturation boost. Applies to the Hyperion model (`hyp-1`).<br/>
        /// Example: 0.5
        /// </summary>
        /// <example>0.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("boostSaturation")]
        public double? BoostSaturation { get; set; }

        /// <summary>
        /// Threshold above which pixels are treated as highlights. Applies to the Hyperion model (`hyp-1`).<br/>
        /// Example: 0.6
        /// </summary>
        /// <example>0.6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlightThreshold")]
        public double? HighlightThreshold { get; set; }

        /// <summary>
        /// Correct rolling shutter distortion.<br/>
        /// __Required when the stabilization model (`stab-1`) is used.__ Omitting it returns a 400.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rollingShutterCorrection")]
        public bool? RollingShutterCorrection { get; set; }

        /// <summary>
        /// Stabilization strength. Applies to the stabilization model (`stab-1`).<br/>
        /// Example: 8
        /// </summary>
        /// <example>8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("strength")]
        public double? Strength { get; set; }

        /// <summary>
        /// Amount of motion jitter reduction. Applies to the stabilization model (`stab-1`).<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reduceMotionJitter")]
        public int? ReduceMotionJitter { get; set; }

        /// <summary>
        /// Preserve the full frame rather than cropping to hide stabilization borders. Applies to the stabilization model (`stab-1`).<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fullFrame")]
        public bool? FullFrame { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpscaleFilter" /> class.
        /// </summary>
        /// <param name="model">
        /// Short code name for the AI model.<br/>
        /// Newer models may be accepted before they appear in this list — call `GET /video/status` for the authoritative set of currently supported models.<br/>
        /// Example: prob-4
        /// </param>
        /// <param name="videoType">
        /// Frame/field type of the video<br/>
        /// Example: Progressive
        /// </param>
        /// <param name="auto">
        /// Parameter mode of the selected model<br/>
        /// - Auto - parameter estimation is used with no customization<br/>
        /// - Relative - uses auto parameters with optional weights added<br/>
        /// - Manual - all parameters are manually set<br/>
        /// Example: Auto
        /// </param>
        /// <param name="fieldOrder">
        /// Optional specification of field order for interlaced input videos<br/>
        /// Example: Auto
        /// </param>
        /// <param name="focusFixLevel">
        /// Downscales video input for stronger correction of blurred subjects<br/>
        /// Example: Normal
        /// </param>
        /// <param name="compression">
        /// Adjust strength of compression recovery<br/>
        /// Example: 0.1
        /// </param>
        /// <param name="details">
        /// Amount of detail reconstruction<br/>
        /// Example: 0.2
        /// </param>
        /// <param name="prenoise">
        /// Adds noise to input to reduce over-smoothing<br/>
        /// Example: 0.01
        /// </param>
        /// <param name="noise">
        /// Amount of noise reduction<br/>
        /// Example: 0.3
        /// </param>
        /// <param name="halo">
        /// Amount of halo reduction<br/>
        /// Example: 0.4
        /// </param>
        /// <param name="preblur">
        /// Adjust anti-aliasing and deblurring strength<br/>
        /// Example: 0.5
        /// </param>
        /// <param name="blur">
        /// Amount of sharpness applied<br/>
        /// Example: 0.6
        /// </param>
        /// <param name="grain">
        /// Adds grain after AI model processing<br/>
        /// Example: 0.02
        /// </param>
        /// <param name="grainSigma">
        /// Grain granularity<br/>
        /// Example: 0.5
        /// </param>
        /// <param name="grainSize">
        /// Size of generated grain<br/>
        /// Example: 1
        /// </param>
        /// <param name="grainType">
        /// Type of grain<br/>
        /// Example: gaussian
        /// </param>
        /// <param name="recoverOriginalDetailValue">
        /// Reintroduce source details into the output video<br/>
        /// Example: 0.7
        /// </param>
        /// <param name="transferFunction">
        /// HDR transfer function. Applies to the Hyperion model (`hyp-1`).<br/>
        /// Example: pq
        /// </param>
        /// <param name="adjustExposure">
        /// Exposure adjustment. Applies to the Hyperion model (`hyp-1`).<br/>
        /// Example: 0.5
        /// </param>
        /// <param name="boostSaturation">
        /// Saturation boost. Applies to the Hyperion model (`hyp-1`).<br/>
        /// Example: 0.5
        /// </param>
        /// <param name="highlightThreshold">
        /// Threshold above which pixels are treated as highlights. Applies to the Hyperion model (`hyp-1`).<br/>
        /// Example: 0.6
        /// </param>
        /// <param name="rollingShutterCorrection">
        /// Correct rolling shutter distortion.<br/>
        /// __Required when the stabilization model (`stab-1`) is used.__ Omitting it returns a 400.<br/>
        /// Example: true
        /// </param>
        /// <param name="strength">
        /// Stabilization strength. Applies to the stabilization model (`stab-1`).<br/>
        /// Example: 8
        /// </param>
        /// <param name="reduceMotionJitter">
        /// Amount of motion jitter reduction. Applies to the stabilization model (`stab-1`).<br/>
        /// Example: 2
        /// </param>
        /// <param name="fullFrame">
        /// Preserve the full frame rather than cropping to hide stabilization borders. Applies to the stabilization model (`stab-1`).<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpscaleFilter(
            global::Topaz.UpscaleFilterModel model,
            global::Topaz.UpscaleFilterVideoType? videoType,
            global::Topaz.UpscaleFilterAuto? auto,
            global::Topaz.UpscaleFilterFieldOrder? fieldOrder,
            global::Topaz.UpscaleFilterFocusFixLevel? focusFixLevel,
            double? compression,
            double? details,
            double? prenoise,
            double? noise,
            double? halo,
            double? preblur,
            double? blur,
            double? grain,
            double? grainSigma,
            double? grainSize,
            global::Topaz.UpscaleFilterGrainType? grainType,
            double? recoverOriginalDetailValue,
            global::Topaz.UpscaleFilterTransferFunction? transferFunction,
            double? adjustExposure,
            double? boostSaturation,
            double? highlightThreshold,
            bool? rollingShutterCorrection,
            double? strength,
            int? reduceMotionJitter,
            bool? fullFrame)
        {
            this.Model = model;
            this.VideoType = videoType;
            this.Auto = auto;
            this.FieldOrder = fieldOrder;
            this.FocusFixLevel = focusFixLevel;
            this.Compression = compression;
            this.Details = details;
            this.Prenoise = prenoise;
            this.Noise = noise;
            this.Halo = halo;
            this.Preblur = preblur;
            this.Blur = blur;
            this.Grain = grain;
            this.GrainSigma = grainSigma;
            this.GrainSize = grainSize;
            this.GrainType = grainType;
            this.RecoverOriginalDetailValue = recoverOriginalDetailValue;
            this.TransferFunction = transferFunction;
            this.AdjustExposure = adjustExposure;
            this.BoostSaturation = boostSaturation;
            this.HighlightThreshold = highlightThreshold;
            this.RollingShutterCorrection = rollingShutterCorrection;
            this.Strength = strength;
            this.ReduceMotionJitter = reduceMotionJitter;
            this.FullFrame = fullFrame;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpscaleFilter" /> class.
        /// </summary>
        public UpscaleFilter()
        {
        }

    }
}