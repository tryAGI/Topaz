
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Bookkeeping from the processing pipeline. Populated only for requests handled by the generative pipeline; an empty object for every other request.
    /// </summary>
    public sealed partial class VideoRequestRecordProcessing
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topserving")]
        public global::Topaz.VideoRequestRecordProcessingTopserving? Topserving { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoRequestRecordProcessing" /> class.
        /// </summary>
        /// <param name="topserving"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoRequestRecordProcessing(
            global::Topaz.VideoRequestRecordProcessingTopserving? topserving)
        {
            this.Topserving = topserving;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoRequestRecordProcessing" /> class.
        /// </summary>
        public VideoRequestRecordProcessing()
        {
        }

    }
}