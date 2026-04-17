
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FrameInterpolationFilter
    {
        /// <summary>
        /// Short code name for the AI model<br/>
        /// Example: apo-8
        /// </summary>
        /// <example>apo-8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.FrameInterpolationFilterModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Topaz.FrameInterpolationFilterModel Model { get; set; }

        /// <summary>
        /// Slow motion factor applied to input video. For example, a value of 2 makes the output twice as slow and doubles the duration.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slowmo")]
        public double? Slowmo { get; set; }

        /// <summary>
        /// Output frame rate, does not increase duration<br/>
        /// Example: 60
        /// </summary>
        /// <example>60</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fps")]
        public double? Fps { get; set; }

        /// <summary>
        /// Analyze input for duplicate frames and remove them<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duplicate")]
        public bool? Duplicate { get; set; }

        /// <summary>
        /// Sensitivity of detection for duplicate frames<br/>
        /// Example: 0.01
        /// </summary>
        /// <example>0.01</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duplicateThreshold")]
        public double? DuplicateThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FrameInterpolationFilter" /> class.
        /// </summary>
        /// <param name="model">
        /// Short code name for the AI model<br/>
        /// Example: apo-8
        /// </param>
        /// <param name="slowmo">
        /// Slow motion factor applied to input video. For example, a value of 2 makes the output twice as slow and doubles the duration.<br/>
        /// Example: 2
        /// </param>
        /// <param name="fps">
        /// Output frame rate, does not increase duration<br/>
        /// Example: 60
        /// </param>
        /// <param name="duplicate">
        /// Analyze input for duplicate frames and remove them<br/>
        /// Example: true
        /// </param>
        /// <param name="duplicateThreshold">
        /// Sensitivity of detection for duplicate frames<br/>
        /// Example: 0.01
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FrameInterpolationFilter(
            global::Topaz.FrameInterpolationFilterModel model,
            double? slowmo,
            double? fps,
            bool? duplicate,
            double? duplicateThreshold)
        {
            this.Model = model;
            this.Slowmo = slowmo;
            this.Fps = fps;
            this.Duplicate = duplicate;
            this.DuplicateThreshold = duplicateThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FrameInterpolationFilter" /> class.
        /// </summary>
        public FrameInterpolationFilter()
        {
        }
    }
}