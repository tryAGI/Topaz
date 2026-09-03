
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Preview of the credit settlement that would occur if the request is canceled now.
    /// </summary>
    public sealed partial class CancelEstimateResponse
    {
        /// <summary>
        /// Example: c1f96dc2-c448-00e6-82ed-14ecb6403c62
        /// </summary>
        /// <example>c1f96dc2-c448-00e6-82ed-14ecb6403c62</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public global::System.Guid? RequestId { get; set; }

        /// <summary>
        /// Example: processing
        /// </summary>
        /// <example>processing</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.CancelEstimateResponseStatusJsonConverter))]
        public global::Topaz.CancelEstimateResponseStatus? Status { get; set; }

        /// <summary>
        /// False if the request is already canceling or canceled<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelable")]
        public bool? Cancelable { get; set; }

        /// <summary>
        /// Processing progress used for settlement, as a percentage (0-100)<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public int? Progress { get; set; }

        /// <summary>
        /// Credits currently reserved for the request<br/>
        /// Example: 12
        /// </summary>
        /// <example>12</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("creditsReserved")]
        public int? CreditsReserved { get; set; }

        /// <summary>
        /// Credits that would be charged for work completed so far<br/>
        /// Example: 7
        /// </summary>
        /// <example>7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("creditsToCommit")]
        public int? CreditsToCommit { get; set; }

        /// <summary>
        /// Credits that would be refunded<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("creditsToRefund")]
        public int? CreditsToRefund { get; set; }

        /// <summary>
        /// Example: Canceling now will charge approximately 7 credit(s) for work completed so far; 5 credit(s) would be refunded.
        /// </summary>
        /// <example>Canceling now will charge approximately 7 credit(s) for work completed so far; 5 credit(s) would be refunded.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelEstimateResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Example: c1f96dc2-c448-00e6-82ed-14ecb6403c62
        /// </param>
        /// <param name="status">
        /// Example: processing
        /// </param>
        /// <param name="cancelable">
        /// False if the request is already canceling or canceled<br/>
        /// Example: true
        /// </param>
        /// <param name="progress">
        /// Processing progress used for settlement, as a percentage (0-100)<br/>
        /// Example: 50
        /// </param>
        /// <param name="creditsReserved">
        /// Credits currently reserved for the request<br/>
        /// Example: 12
        /// </param>
        /// <param name="creditsToCommit">
        /// Credits that would be charged for work completed so far<br/>
        /// Example: 7
        /// </param>
        /// <param name="creditsToRefund">
        /// Credits that would be refunded<br/>
        /// Example: 5
        /// </param>
        /// <param name="message">
        /// Example: Canceling now will charge approximately 7 credit(s) for work completed so far; 5 credit(s) would be refunded.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelEstimateResponse(
            global::System.Guid? requestId,
            global::Topaz.CancelEstimateResponseStatus? status,
            bool? cancelable,
            int? progress,
            int? creditsReserved,
            int? creditsToCommit,
            int? creditsToRefund,
            string? message)
        {
            this.RequestId = requestId;
            this.Status = status;
            this.Cancelable = cancelable;
            this.Progress = progress;
            this.CreditsReserved = creditsReserved;
            this.CreditsToCommit = creditsToCommit;
            this.CreditsToRefund = creditsToRefund;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelEstimateResponse" /> class.
        /// </summary>
        public CancelEstimateResponse()
        {
        }

    }
}