
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteAllStatusesResponse
    {
        /// <summary>
        /// The number of statuses that were deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_count")]
        public int? DeletedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAllStatusesResponse" /> class.
        /// </summary>
        /// <param name="deletedCount">
        /// The number of statuses that were deleted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteAllStatusesResponse(
            int? deletedCount)
        {
            this.DeletedCount = deletedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAllStatusesResponse" /> class.
        /// </summary>
        public DeleteAllStatusesResponse()
        {
        }
    }
}