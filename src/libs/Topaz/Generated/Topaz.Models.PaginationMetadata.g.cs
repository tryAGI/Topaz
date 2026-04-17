
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaginationMetadata
    {
        /// <summary>
        /// The cursor to use for retrieving the next page of results. Omitted if there are no more pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Indicates whether there are more pages of results available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_next_page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasNextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationMetadata" /> class.
        /// </summary>
        /// <param name="hasNextPage">
        /// Indicates whether there are more pages of results available.
        /// </param>
        /// <param name="nextCursor">
        /// The cursor to use for retrieving the next page of results. Omitted if there are no more pages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaginationMetadata(
            bool hasNextPage,
            string? nextCursor)
        {
            this.NextCursor = nextCursor;
            this.HasNextPage = hasNextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationMetadata" /> class.
        /// </summary>
        public PaginationMetadata()
        {
        }
    }
}