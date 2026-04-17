
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Resolution details of the video
    /// </summary>
    public sealed partial class CreateVideoRequestRequestSourceResolution
    {
        /// <summary>
        /// Width of the video in pixels<br/>
        /// Example: 1920
        /// </summary>
        /// <example>1920</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Width { get; set; }

        /// <summary>
        /// Height of the video in pixels<br/>
        /// Example: 1080
        /// </summary>
        /// <example>1080</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Height { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoRequestRequestSourceResolution" /> class.
        /// </summary>
        /// <param name="width">
        /// Width of the video in pixels<br/>
        /// Example: 1920
        /// </param>
        /// <param name="height">
        /// Height of the video in pixels<br/>
        /// Example: 1080
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoRequestRequestSourceResolution(
            int width,
            int height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoRequestRequestSourceResolution" /> class.
        /// </summary>
        public CreateVideoRequestRequestSourceResolution()
        {
        }
    }
}