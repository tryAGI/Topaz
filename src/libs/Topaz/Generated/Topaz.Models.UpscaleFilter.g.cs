
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpscaleFilter
    {
        /// <summary>
        /// Short code name for the AI model<br/>
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
        /// Size of generated grain<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("grainSize")]
        public double? GrainSize { get; set; }

        /// <summary>
        /// Reintroduce source details into the output video<br/>
        /// Example: 0.7
        /// </summary>
        /// <example>0.7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("recoverOriginalDetailValue")]
        public double? RecoverOriginalDetailValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpscaleFilter" /> class.
        /// </summary>
        /// <param name="model">
        /// Short code name for the AI model<br/>
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
        /// <param name="grainSize">
        /// Size of generated grain<br/>
        /// Example: 1
        /// </param>
        /// <param name="recoverOriginalDetailValue">
        /// Reintroduce source details into the output video<br/>
        /// Example: 0.7
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
            double? grainSize,
            double? recoverOriginalDetailValue)
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
            this.GrainSize = grainSize;
            this.RecoverOriginalDetailValue = recoverOriginalDetailValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpscaleFilter" /> class.
        /// </summary>
        public UpscaleFilter()
        {
        }
    }
}