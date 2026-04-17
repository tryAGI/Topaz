
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetricsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minutesInState")]
        public global::Topaz.MetricsResponseMinutesInState? MinutesInState { get; set; }

        /// <summary>
        /// Time taken for the final enhanced video to become available for download after user finished uploading the source video.<br/>
        /// Example: 12.34
        /// </summary>
        /// <example>12.34</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("minutesToEnhance")]
        public double? MinutesToEnhance { get; set; }

        /// <summary>
        /// Example: 3000
        /// </summary>
        /// <example>3000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputFrames")]
        public int? InputFrames { get; set; }

        /// <summary>
        /// Example: 3000
        /// </summary>
        /// <example>3000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputFrames")]
        public int? OutputFrames { get; set; }

        /// <summary>
        /// Example: 300 MB
        /// </summary>
        /// <example>300 MB</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputSize")]
        public string? InputSize { get; set; }

        /// <summary>
        /// Example: 400 MB
        /// </summary>
        /// <example>400 MB</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputSize")]
        public string? OutputSize { get; set; }

        /// <summary>
        /// Metrics for each chunk<br/>
        /// Example: [{"chunkIndex":0,"tasks":[{"minutesProcessing":12.3,"inputFrames":320,"outputFrames":320,"inputSize":"100 MB","outputSize":"200 MB"}]}, {"chunkIndex":1,"tasks":[{"minutesProcessing":12.2,"inputFrames":319,"outputFrames":319,"inputSize":"99 MB","outputSize":"199 MB"}]}]
        /// </summary>
        /// <example>[{"chunkIndex":0,"tasks":[{"minutesProcessing":12.3,"inputFrames":320,"outputFrames":320,"inputSize":"100 MB","outputSize":"200 MB"}]}, {"chunkIndex":1,"tasks":[{"minutesProcessing":12.2,"inputFrames":319,"outputFrames":319,"inputSize":"99 MB","outputSize":"199 MB"}]}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunks")]
        public global::System.Collections.Generic.IList<global::Topaz.ChunkMetrics>? Chunks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsResponse" /> class.
        /// </summary>
        /// <param name="minutesInState"></param>
        /// <param name="minutesToEnhance">
        /// Time taken for the final enhanced video to become available for download after user finished uploading the source video.<br/>
        /// Example: 12.34
        /// </param>
        /// <param name="inputFrames">
        /// Example: 3000
        /// </param>
        /// <param name="outputFrames">
        /// Example: 3000
        /// </param>
        /// <param name="inputSize">
        /// Example: 300 MB
        /// </param>
        /// <param name="outputSize">
        /// Example: 400 MB
        /// </param>
        /// <param name="chunks">
        /// Metrics for each chunk<br/>
        /// Example: [{"chunkIndex":0,"tasks":[{"minutesProcessing":12.3,"inputFrames":320,"outputFrames":320,"inputSize":"100 MB","outputSize":"200 MB"}]}, {"chunkIndex":1,"tasks":[{"minutesProcessing":12.2,"inputFrames":319,"outputFrames":319,"inputSize":"99 MB","outputSize":"199 MB"}]}]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetricsResponse(
            global::Topaz.MetricsResponseMinutesInState? minutesInState,
            double? minutesToEnhance,
            int? inputFrames,
            int? outputFrames,
            string? inputSize,
            string? outputSize,
            global::System.Collections.Generic.IList<global::Topaz.ChunkMetrics>? chunks)
        {
            this.MinutesInState = minutesInState;
            this.MinutesToEnhance = minutesToEnhance;
            this.InputFrames = inputFrames;
            this.OutputFrames = outputFrames;
            this.InputSize = inputSize;
            this.OutputSize = outputSize;
            this.Chunks = chunks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsResponse" /> class.
        /// </summary>
        public MetricsResponse()
        {
        }
    }
}