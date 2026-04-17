
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVideoRequestRequestDestination
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external")]
        public global::Topaz.ExternalStorage? External { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoRequestRequestDestination" /> class.
        /// </summary>
        /// <param name="external"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoRequestRequestDestination(
            global::Topaz.ExternalStorage? external)
        {
            this.External = external;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoRequestRequestDestination" /> class.
        /// </summary>
        public CreateVideoRequestRequestDestination()
        {
        }
    }
}