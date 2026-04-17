
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HistoryResponse
    {
        /// <summary>
        /// Unique request identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public double? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.HistoryResponseStatusJsonConverter))]
        public global::Topaz.HistoryResponseStatus? Status { get; set; }

        /// <summary>
        /// Timestamp the request reached the state, if applicable, in milliseconds since UTC epoch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ts")]
        public global::Topaz.HistoryResponseTs? Ts { get; set; }

        /// <summary>
        /// Timestamp of the last event, in milliseconds since UTC epoch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastEventTs")]
        public double? LastEventTs { get; set; }

        /// <summary>
        /// Lower and upper bound estimates
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimates")]
        public global::Topaz.RequestEstimates? Estimates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transactions")]
        public global::System.Collections.Generic.IList<global::Topaz.HistoryResponseTransaction>? Transactions { get; set; }

        /// <summary>
        /// Error message, if the request was a failure
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Topaz.HistoryResponseError? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique request identifier
        /// </param>
        /// <param name="userId"></param>
        /// <param name="status"></param>
        /// <param name="ts">
        /// Timestamp the request reached the state, if applicable, in milliseconds since UTC epoch
        /// </param>
        /// <param name="lastEventTs">
        /// Timestamp of the last event, in milliseconds since UTC epoch
        /// </param>
        /// <param name="estimates">
        /// Lower and upper bound estimates
        /// </param>
        /// <param name="transactions"></param>
        /// <param name="error">
        /// Error message, if the request was a failure
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HistoryResponse(
            global::System.Guid? id,
            double? userId,
            global::Topaz.HistoryResponseStatus? status,
            global::Topaz.HistoryResponseTs? ts,
            double? lastEventTs,
            global::Topaz.RequestEstimates? estimates,
            global::System.Collections.Generic.IList<global::Topaz.HistoryResponseTransaction>? transactions,
            global::Topaz.HistoryResponseError? error)
        {
            this.Id = id;
            this.UserId = userId;
            this.Status = status;
            this.Ts = ts;
            this.LastEventTs = lastEventTs;
            this.Estimates = estimates;
            this.Transactions = transactions;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryResponse" /> class.
        /// </summary>
        public HistoryResponse()
        {
        }
    }
}