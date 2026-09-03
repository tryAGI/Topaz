
#nullable enable

namespace Topaz
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VideoRequestRecordOverrides
    {
        /// <summary>
        /// Whether the request was placed on higher-performance processing hardware
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forceHighPerformance")]
        public bool? ForceHighPerformance { get; set; }

        /// <summary>
        /// Whether the enhanced output carries a Topaz Labs watermark. Absent or `false` unless the request was created through a client that watermarks its output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shouldAddWatermark")]
        public bool? ShouldAddWatermark { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoRequestRecordOverrides" /> class.
        /// </summary>
        /// <param name="forceHighPerformance">
        /// Whether the request was placed on higher-performance processing hardware
        /// </param>
        /// <param name="shouldAddWatermark">
        /// Whether the enhanced output carries a Topaz Labs watermark. Absent or `false` unless the request was created through a client that watermarks its output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoRequestRecordOverrides(
            bool? forceHighPerformance,
            bool? shouldAddWatermark)
        {
            this.ForceHighPerformance = forceHighPerformance;
            this.ShouldAddWatermark = shouldAddWatermark;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoRequestRecordOverrides" /> class.
        /// </summary>
        public VideoRequestRecordOverrides()
        {
        }

    }
}