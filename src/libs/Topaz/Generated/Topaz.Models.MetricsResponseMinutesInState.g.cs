
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetricsResponseMinutesInState
    {
        /// <summary>
        /// Example: 1.23
        /// </summary>
        /// <example>1.23</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pendingSourceUpload")]
        public double? PendingSourceUpload { get; set; }

        /// <summary>
        /// Example: 1.23
        /// </summary>
        /// <example>1.23</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("initializing")]
        public double? Initializing { get; set; }

        /// <summary>
        /// Example: 1.23
        /// </summary>
        /// <example>1.23</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("preprocessing")]
        public double? Preprocessing { get; set; }

        /// <summary>
        /// Example: 3.21
        /// </summary>
        /// <example>3.21</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing")]
        public double? Processing { get; set; }

        /// <summary>
        /// Example: 3.21
        /// </summary>
        /// <example>3.21</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("postprocessing")]
        public double? Postprocessing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsResponseMinutesInState" /> class.
        /// </summary>
        /// <param name="pendingSourceUpload">
        /// Example: 1.23
        /// </param>
        /// <param name="initializing">
        /// Example: 1.23
        /// </param>
        /// <param name="preprocessing">
        /// Example: 1.23
        /// </param>
        /// <param name="processing">
        /// Example: 3.21
        /// </param>
        /// <param name="postprocessing">
        /// Example: 3.21
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetricsResponseMinutesInState(
            double? pendingSourceUpload,
            double? initializing,
            double? preprocessing,
            double? processing,
            double? postprocessing)
        {
            this.PendingSourceUpload = pendingSourceUpload;
            this.Initializing = initializing;
            this.Preprocessing = preprocessing;
            this.Processing = processing;
            this.Postprocessing = postprocessing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsResponseMinutesInState" /> class.
        /// </summary>
        public MetricsResponseMinutesInState()
        {
        }
    }
}