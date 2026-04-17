
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
        /// Example: 56
        /// </summary>
        /// <example>56</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpuUtilization")]
        public double? GpuUtilization { get; set; }

        /// <summary>
        /// In percentage<br/>
        /// Example: 65
        /// </summary>
        /// <example>65</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpuMemoryUtilization")]
        public double? GpuMemoryUtilization { get; set; }

        /// <summary>
        /// The number of latest processing stat records used in the average calculation<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampleCount")]
        public int? SampleCount { get; set; }

        /// <summary>
        /// Example: 123
        /// </summary>
        /// <example>123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentFrame")]
        public int? CurrentFrame { get; set; }

        /// <summary>
        /// This value and currentFrame is used to calculate the progress %<br/>
        /// Example: 320
        /// </summary>
        /// <example>320</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expectedOutputFrames")]
        public int? ExpectedOutputFrames { get; set; }

        /// <summary>
        /// Timestamp of the latest stat record in milliseconds since UTC epoch<br/>
        /// Example: 1727213410471
        /// </summary>
        /// <example>1727213410471</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("latestLogTs")]
        public long? LatestLogTs { get; set; }

        /// <summary>
        /// In bytes<br/>
        /// Example: 123456
        /// </summary>
        /// <example>123456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentSize")]
        public long? CurrentSize { get; set; }

        /// <summary>
        /// Processing speed of the node<br/>
        /// Example: 2.34
        /// </summary>
        /// <example>2.34</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fps")]
        public double? Fps { get; set; }

        /// <summary>
        /// In percentage<br/>
        /// Example: 90
        /// </summary>
        /// <example>90</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public double? Progress { get; set; }

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
        /// <param name="gpuUtilization">
        /// In percentage<br/>
        /// Example: 56
        /// </param>
        /// <param name="gpuMemoryUtilization">
        /// In percentage<br/>
        /// Example: 65
        /// </param>
        /// <param name="sampleCount">
        /// The number of latest processing stat records used in the average calculation<br/>
        /// Example: 20
        /// </param>
        /// <param name="currentFrame">
        /// Example: 123
        /// </param>
        /// <param name="expectedOutputFrames">
        /// This value and currentFrame is used to calculate the progress %<br/>
        /// Example: 320
        /// </param>
        /// <param name="latestLogTs">
        /// Timestamp of the latest stat record in milliseconds since UTC epoch<br/>
        /// Example: 1727213410471
        /// </param>
        /// <param name="currentSize">
        /// In bytes<br/>
        /// Example: 123456
        /// </param>
        /// <param name="fps">
        /// Processing speed of the node<br/>
        /// Example: 2.34
        /// </param>
        /// <param name="progress">
        /// In percentage<br/>
        /// Example: 90
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProcessingStatIntermediateItem(
            global::System.Guid? chunkId,
            int? chunkIndex,
            int? taskIndex,
            global::Topaz.ProcessingStatIntermediateItemStatus? status,
            double? gpuUtilization,
            double? gpuMemoryUtilization,
            int? sampleCount,
            int? currentFrame,
            int? expectedOutputFrames,
            long? latestLogTs,
            long? currentSize,
            double? fps,
            double? progress)
        {
            this.ChunkId = chunkId;
            this.ChunkIndex = chunkIndex;
            this.TaskIndex = taskIndex;
            this.Status = status;
            this.GpuUtilization = gpuUtilization;
            this.GpuMemoryUtilization = gpuMemoryUtilization;
            this.SampleCount = sampleCount;
            this.CurrentFrame = currentFrame;
            this.ExpectedOutputFrames = expectedOutputFrames;
            this.LatestLogTs = latestLogTs;
            this.CurrentSize = currentSize;
            this.Fps = fps;
            this.Progress = progress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessingStatIntermediateItem" /> class.
        /// </summary>
        public ProcessingStatIntermediateItem()
        {
        }
    }
}