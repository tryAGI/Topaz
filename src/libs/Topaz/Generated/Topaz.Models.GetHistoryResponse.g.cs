
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
        public global::System.Collections.Generic.IList<global::Topaz.HistoryResponse>? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetHistoryResponse" /> class.
        /// </summary>
        /// <param name="result"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetHistoryResponse(
            global::System.Collections.Generic.IList<global::Topaz.HistoryResponse>? result)
        {
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetHistoryResponse" /> class.
        /// </summary>
        public GetHistoryResponse()
        {
        }
    }
}