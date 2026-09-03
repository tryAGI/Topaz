
#nullable enable

namespace Topaz
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VideoRequestRecordProcessingTopserving
    {
        /// <summary>
        /// Timestamp of the last progress report received from the processing backend, in milliseconds since UTC epoch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUpdated")]
        public double? LastUpdated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoRequestRecordProcessingTopserving" /> class.
        /// </summary>
        /// <param name="lastUpdated">
        /// Timestamp of the last progress report received from the processing backend, in milliseconds since UTC epoch
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoRequestRecordProcessingTopserving(
            double? lastUpdated)
        {
            this.LastUpdated = lastUpdated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoRequestRecordProcessingTopserving" /> class.
        /// </summary>
        public VideoRequestRecordProcessingTopserving()
        {
        }

    }
}