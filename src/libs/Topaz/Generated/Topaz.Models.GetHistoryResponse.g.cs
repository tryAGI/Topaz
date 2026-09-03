
#nullable enable

namespace Topaz
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetHistoryResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::System.Collections.Generic.IList<global::Topaz.VideoRequestRecord>? Result { get; set; }

        /// <summary>
        /// Cursor to pass as the `cursor` query parameter to fetch the next page. `null` when there are no more results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetHistoryResponse" /> class.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="nextCursor">
        /// Cursor to pass as the `cursor` query parameter to fetch the next page. `null` when there are no more results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetHistoryResponse(
            global::System.Collections.Generic.IList<global::Topaz.VideoRequestRecord>? result,
            string? nextCursor)
        {
            this.Result = result;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetHistoryResponse" /> class.
        /// </summary>
        public GetHistoryResponse()
        {
        }

    }
}