
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaginatedStatusesResponse
    {
        /// <summary>
        /// Array of status responses for the current page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Topaz.StatusResponse> Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Topaz.PaginationMetadata Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedStatusesResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Array of status responses for the current page.
        /// </param>
        /// <param name="pagination"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaginatedStatusesResponse(
            global::System.Collections.Generic.IList<global::Topaz.StatusResponse> data,
            global::Topaz.PaginationMetadata pagination)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedStatusesResponse" /> class.
        /// </summary>
        public PaginatedStatusesResponse()
        {
        }
    }
}