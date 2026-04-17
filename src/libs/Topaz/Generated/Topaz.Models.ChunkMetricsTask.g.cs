
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChunkMetricsTask
    {
        /// <summary>
        /// Example: 12.3
        /// </summary>
        /// <example>12.3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("minutesProcessing")]
        public double? MinutesProcessing { get; set; }

        /// <summary>
        /// Example: 320
        /// </summary>
        /// <example>320</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputFrames")]
        public int? InputFrames { get; set; }

        /// <summary>
        /// Example: 320
        /// </summary>
        /// <example>320</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputFrames")]
        public int? OutputFrames { get; set; }

        /// <summary>
        /// Example: 100 MB
        /// </summary>
        /// <example>100 MB</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputSize")]
        public string? InputSize { get; set; }

        /// <summary>
        /// Example: 200 MB
        /// </summary>
        /// <example>200 MB</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputSize")]
        public string? OutputSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkMetricsTask" /> class.
        /// </summary>
        /// <param name="minutesProcessing">
        /// Example: 12.3
        /// </param>
        /// <param name="inputFrames">
        /// Example: 320
        /// </param>
        /// <param name="outputFrames">
        /// Example: 320
        /// </param>
        /// <param name="inputSize">
        /// Example: 100 MB
        /// </param>
        /// <param name="outputSize">
        /// Example: 200 MB
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChunkMetricsTask(
            double? minutesProcessing,
            int? inputFrames,
            int? outputFrames,
            string? inputSize,
            string? outputSize)
        {
            this.MinutesProcessing = minutesProcessing;
            this.InputFrames = inputFrames;
            this.OutputFrames = outputFrames;
            this.InputSize = inputSize;
            this.OutputSize = outputSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkMetricsTask" /> class.
        /// </summary>
        public ChunkMetricsTask()
        {
        }
    }
}