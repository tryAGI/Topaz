
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateExpressVideoRequestRequest
    {
        /// <summary>
        /// Source details for the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Topaz.CreateExpressVideoRequestRequestSource Source { get; set; }

        /// <summary>
        /// Array of UpscaleFilter or FrameInterpolationFilter objects<br/>
        /// Example: [{"model":"prob-4","videoType":"Progressive","auto":"Auto","fieldOrder":"Auto","focusFixLevel":"Normal","compression":0.1,"details":0.2,"prenoise":0.01,"noise":0.3,"halo":0.4,"preblur":0.5,"blur":0.6,"grain":0.02,"grainSize":1,"recoverOriginalDetailValue":0.7}, {"model":"apo-8","slowmo":2,"fps":60,"duplicate":true,"duplicateThreshold":0.01}]
        /// </summary>
        /// <example>[{"model":"prob-4","videoType":"Progressive","auto":"Auto","fieldOrder":"Auto","focusFixLevel":"Normal","compression":0.1,"details":0.2,"prenoise":0.01,"noise":0.3,"halo":0.4,"preblur":0.5,"blur":0.6,"grain":0.02,"grainSize":1,"recoverOriginalDetailValue":0.7}, {"model":"apo-8","slowmo":2,"fps":60,"duplicate":true,"duplicateThreshold":0.01}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Topaz.AnyOf<global::Topaz.UpscaleFilter, global::Topaz.FrameInterpolationFilter>> Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Topaz.OutputInformationVideo Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        public global::Topaz.CreateExpressVideoRequestRequestDestination? Destination { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notifications")]
        public global::Topaz.CreateExpressVideoRequestRequestNotifications? Notifications { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExpressVideoRequestRequest" /> class.
        /// </summary>
        /// <param name="source">
        /// Source details for the video
        /// </param>
        /// <param name="filters">
        /// Array of UpscaleFilter or FrameInterpolationFilter objects<br/>
        /// Example: [{"model":"prob-4","videoType":"Progressive","auto":"Auto","fieldOrder":"Auto","focusFixLevel":"Normal","compression":0.1,"details":0.2,"prenoise":0.01,"noise":0.3,"halo":0.4,"preblur":0.5,"blur":0.6,"grain":0.02,"grainSize":1,"recoverOriginalDetailValue":0.7}, {"model":"apo-8","slowmo":2,"fps":60,"duplicate":true,"duplicateThreshold":0.01}]
        /// </param>
        /// <param name="output"></param>
        /// <param name="destination"></param>
        /// <param name="notifications"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateExpressVideoRequestRequest(
            global::Topaz.CreateExpressVideoRequestRequestSource source,
            global::System.Collections.Generic.IList<global::Topaz.AnyOf<global::Topaz.UpscaleFilter, global::Topaz.FrameInterpolationFilter>> filters,
            global::Topaz.OutputInformationVideo output,
            global::Topaz.CreateExpressVideoRequestRequestDestination? destination,
            global::Topaz.CreateExpressVideoRequestRequestNotifications? notifications)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.Destination = destination;
            this.Notifications = notifications;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExpressVideoRequestRequest" /> class.
        /// </summary>
        public CreateExpressVideoRequestRequest()
        {
        }
    }
}