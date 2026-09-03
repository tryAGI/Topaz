
#nullable enable

namespace Topaz
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VideoRequestRecordTransaction
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.VideoRequestRecordTransactionOperationJsonConverter))]
        public global::Topaz.VideoRequestRecordTransactionOperation? Operation { get; set; }

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
        /// Initializes a new instance of the <see cref="VideoRequestRecordTransaction" /> class.
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="amount">
        /// Amount involved in the transaction, in credits
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoRequestRecordTransaction(
            global::Topaz.VideoRequestRecordTransactionOperation? operation,
            double? amount)
        {
            this.Operation = operation;
            this.Amount = amount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoRequestRecordTransaction" /> class.
        /// </summary>
        public VideoRequestRecordTransaction()
        {
        }

    }
}