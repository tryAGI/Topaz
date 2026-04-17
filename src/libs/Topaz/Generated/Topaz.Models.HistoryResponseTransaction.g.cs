
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HistoryResponseTransaction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.HistoryResponseTransactionOperationJsonConverter))]
        public global::Topaz.HistoryResponseTransactionOperation? Operation { get; set; }

        /// <summary>
        /// Amount involved in the transaction, in credits
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryResponseTransaction" /> class.
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="amount">
        /// Amount involved in the transaction, in credits
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HistoryResponseTransaction(
            global::Topaz.HistoryResponseTransactionOperation? operation,
            double? amount)
        {
            this.Operation = operation;
            this.Amount = amount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryResponseTransaction" /> class.
        /// </summary>
        public HistoryResponseTransaction()
        {
        }
    }
}