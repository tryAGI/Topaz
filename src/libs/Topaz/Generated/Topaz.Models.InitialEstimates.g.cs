
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Initial cost and time estimate, recorded when the request is costed. Absent until then — express requests are costed after the source has been received and analyzed.
    /// </summary>
    public sealed partial class InitialEstimates
    {
        /// <summary>
        /// In credits<br/>
        /// Example: [10, 12]
        /// </summary>
        /// <example>[10, 12]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public global::System.Collections.Generic.IList<int>? Cost { get; set; }

        /// <summary>
        /// In seconds<br/>
        /// Example: [600, 700]
        /// </summary>
        /// <example>[600, 700]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        public global::System.Collections.Generic.IList<int>? Time { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InitialEstimates" /> class.
        /// </summary>
        /// <param name="cost">
        /// In credits<br/>
        /// Example: [10, 12]
        /// </param>
        /// <param name="time">
        /// In seconds<br/>
        /// Example: [600, 700]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InitialEstimates(
            global::System.Collections.Generic.IList<int>? cost,
            global::System.Collections.Generic.IList<int>? time)
        {
            this.Cost = cost;
            this.Time = time;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InitialEstimates" /> class.
        /// </summary>
        public InitialEstimates()
        {
        }

    }
}