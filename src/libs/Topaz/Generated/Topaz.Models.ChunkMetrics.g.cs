
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChunkMetrics
    {
        /// <summary>
        /// Index of the chunk starting from 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunkIndex")]
        public int? ChunkIndex { get; set; }

        /// <summary>
        /// Multiple enhancement tasks may have been run on a chunk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasks")]
        public global::System.Collections.Generic.IList<global::Topaz.ChunkMetricsTask>? Tasks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkMetrics" /> class.
        /// </summary>
        /// <param name="chunkIndex">
        /// Index of the chunk starting from 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="tasks">
        /// Multiple enhancement tasks may have been run on a chunk
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChunkMetrics(
            int? chunkIndex,
            global::System.Collections.Generic.IList<global::Topaz.ChunkMetricsTask>? tasks)
        {
            this.ChunkIndex = chunkIndex;
            this.Tasks = tasks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkMetrics" /> class.
        /// </summary>
        public ChunkMetrics()
        {
        }
    }
}