
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AsyncResponse
    {
        /// <summary>
        /// Unique identifier of the image processing job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("process_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProcessId { get; set; }

        /// <summary>
        /// Unique identifier of the source image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceId { get; set; }

        /// <summary>
        /// Estimated time of arrival (ETA) for the process to complete in Unix time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Eta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncResponse" /> class.
        /// </summary>
        /// <param name="processId">
        /// Unique identifier of the image processing job.
        /// </param>
        /// <param name="sourceId">
        /// Unique identifier of the source image.
        /// </param>
        /// <param name="eta">
        /// Estimated time of arrival (ETA) for the process to complete in Unix time.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncResponse(
            string processId,
            string sourceId,
            int eta)
        {
            this.ProcessId = processId ?? throw new global::System.ArgumentNullException(nameof(processId));
            this.SourceId = sourceId ?? throw new global::System.ArgumentNullException(nameof(sourceId));
            this.Eta = eta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncResponse" /> class.
        /// </summary>
        public AsyncResponse()
        {
        }
    }
}