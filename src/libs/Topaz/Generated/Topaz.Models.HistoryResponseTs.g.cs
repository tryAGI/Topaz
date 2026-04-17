
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Timestamp the request reached the state, if applicable, in milliseconds since UTC epoch
    /// </summary>
    public sealed partial class HistoryResponseTs
    {
        /// <summary>
        /// Request created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested")]
        public double? Requested { get; set; }

        /// <summary>
        /// User has accepted the costs and began uploading the source video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepted")]
        public double? Accepted { get; set; }

        /// <summary>
        /// System received the source video and began initializing resources
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initializing")]
        public double? Initializing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preprocessing")]
        public double? Preprocessing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing")]
        public double? Processing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("postprocessing")]
        public double? Postprocessing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("complete")]
        public double? Complete { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canceling")]
        public double? Canceling { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canceled")]
        public double? Canceled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        public double? Failed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryResponseTs" /> class.
        /// </summary>
        /// <param name="requested">
        /// Request created
        /// </param>
        /// <param name="accepted">
        /// User has accepted the costs and began uploading the source video
        /// </param>
        /// <param name="initializing">
        /// System received the source video and began initializing resources
        /// </param>
        /// <param name="preprocessing"></param>
        /// <param name="processing"></param>
        /// <param name="postprocessing"></param>
        /// <param name="complete"></param>
        /// <param name="canceling"></param>
        /// <param name="canceled"></param>
        /// <param name="failed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HistoryResponseTs(
            double? requested,
            double? accepted,
            double? initializing,
            double? preprocessing,
            double? processing,
            double? postprocessing,
            double? complete,
            double? canceling,
            double? canceled,
            double? failed)
        {
            this.Requested = requested;
            this.Accepted = accepted;
            this.Initializing = initializing;
            this.Preprocessing = preprocessing;
            this.Processing = processing;
            this.Postprocessing = postprocessing;
            this.Complete = complete;
            this.Canceling = canceling;
            this.Canceled = canceled;
            this.Failed = failed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryResponseTs" /> class.
        /// </summary>
        public HistoryResponseTs()
        {
        }
    }
}