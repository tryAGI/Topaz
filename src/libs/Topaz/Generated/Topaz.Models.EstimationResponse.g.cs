
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EstimationResponse
    {
        /// <summary>
        /// The estimated time taken in seconds for the image to be enhanced with the given parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Duration { get; set; }

        /// <summary>
        /// The number of credits that would be consumed if the given requests was executed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Credits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimationResponse" /> class.
        /// </summary>
        /// <param name="duration">
        /// The estimated time taken in seconds for the image to be enhanced with the given parameters.
        /// </param>
        /// <param name="credits">
        /// The number of credits that would be consumed if the given requests was executed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EstimationResponse(
            int duration,
            int credits)
        {
            this.Duration = duration;
            this.Credits = credits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimationResponse" /> class.
        /// </summary>
        public EstimationResponse()
        {
        }
    }
}