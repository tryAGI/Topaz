
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EstimationBulkResponseItemVariant2
    {
        /// <summary>
        /// Indicates that an error occurred while processing this item in the bulk request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.EstimationBulkResponseItemVariant2StatusJsonConverter))]
        public global::Topaz.EstimationBulkResponseItemVariant2Status Status { get; set; }

        /// <summary>
        /// HTTP-like error code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Code { get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimationBulkResponseItemVariant2" /> class.
        /// </summary>
        /// <param name="code">
        /// HTTP-like error code
        /// </param>
        /// <param name="message">
        /// Error message
        /// </param>
        /// <param name="status">
        /// Indicates that an error occurred while processing this item in the bulk request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EstimationBulkResponseItemVariant2(
            int code,
            string message,
            global::Topaz.EstimationBulkResponseItemVariant2Status status)
        {
            this.Status = status;
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimationBulkResponseItemVariant2" /> class.
        /// </summary>
        public EstimationBulkResponseItemVariant2()
        {
        }
    }
}