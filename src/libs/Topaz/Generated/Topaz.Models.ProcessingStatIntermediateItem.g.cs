
#nullable enable

namespace Topaz
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProcessingStatIntermediateItem
    {
        /// <summary>
        /// Example: c1f96dc2-c448-00e6-82ed-14ecb6403c62
        /// </summary>
        /// <example>c1f96dc2-c448-00e6-82ed-14ecb6403c62</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunkId")]
        public global::System.Guid? ChunkId { get; set; }

        /// <summary>
        /// Index of the chunk starting from 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunkIndex")]
        public int? ChunkIndex { get; set; }

        /// <summary>
        /// Index of a chunk's enhancement task starting from 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskIndex")]
        public int? TaskIndex { get; set; }

        /// <summary>
        /// Example: processing
        /// </summary>
        /// <example>processing</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.ProcessingStatIntermediateItemStatusJsonConverter))]
        public global::Topaz.ProcessingStatIntermediateItemStatus? Status { get; set; }

        /// <summary>
        /// In percentage<br/>
        /// Example: 90
        /// </summary>
        /// <example>90</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public double? Progress { get; set; }

        /// <summary>
        /// Processing speed of the node<br/>
        /// Example: 2.34
        /// </summary>
        /// <example>2.34</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("averageFps")]
        public double? AverageFps { get; set; }

        /// <summary>
        /// In percentage<br/>
        /// Example: 56
        /// </summary>
        /// <example>56</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("averageGpuUtilization")]
        public double? AverageGpuUtilization { get; set; }

        /// <summary>
        /// In percentage<br/>
        /// Example: 65
        /// </summary>
        /// <example>65</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("averageGpuMemoryUtilization")]
        public double? AverageGpuMemoryUtilization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessingStatIntermediateItem" /> class.
        /// </summary>
        /// <param name="chunkId">
        /// Example: c1f96dc2-c448-00e6-82ed-14ecb6403c62
        /// </param>
        /// <param name="chunkIndex">
        /// Index of the chunk starting from 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="taskIndex">
        /// Index of a chunk's enhancement task starting from 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="status">
        /// Example: processing
        /// </param>
        /// <param name="progress">
        /// In percentage<br/>
        /// Example: 90
        /// </param>
        /// <param name="averageFps">
        /// Processing speed of the node<br/>
        /// Example: 2.34
        /// </param>
        /// <param name="averageGpuUtilization">
        /// In percentage<br/>
        /// Example: 56
        /// </param>
        /// <param name="averageGpuMemoryUtilization">
        /// In percentage<br/>
        /// Example: 65
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProcessingStatIntermediateItem(
            global::System.Guid? chunkId,
            int? chunkIndex,
            int? taskIndex,
            global::Topaz.ProcessingStatIntermediateItemStatus? status,
            double? progress,
            double? averageFps,
            double? averageGpuUtilization,
            double? averageGpuMemoryUtilization)
        {
            this.ChunkId = chunkId;
            this.ChunkIndex = chunkIndex;
            this.TaskIndex = taskIndex;
            this.Status = status;
            this.Progress = progress;
            this.AverageFps = averageFps;
            this.AverageGpuUtilization = averageGpuUtilization;
            this.AverageGpuMemoryUtilization = averageGpuMemoryUtilization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessingStatIntermediateItem" /> class.
        /// </summary>
        public ProcessingStatIntermediateItem()
        {
        }

    }
}