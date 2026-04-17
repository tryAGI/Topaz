
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateResponse
    {
        /// <summary>
        /// Example: c1f96dc2-c448-00e6-82ed-14ecb6403c62
        /// </summary>
        /// <example>c1f96dc2-c448-00e6-82ed-14ecb6403c62</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public global::System.Guid? RequestId { get; set; }

        /// <summary>
        /// Lower and upper bound estimates
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimates")]
        public global::Topaz.RequestEstimates? Estimates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Example: c1f96dc2-c448-00e6-82ed-14ecb6403c62
        /// </param>
        /// <param name="estimates">
        /// Lower and upper bound estimates
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateResponse(
            global::System.Guid? requestId,
            global::Topaz.RequestEstimates? estimates)
        {
            this.RequestId = requestId;
            this.Estimates = estimates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponse" /> class.
        /// </summary>
        public CreateResponse()
        {
        }
    }
}