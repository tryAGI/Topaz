
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Desired output resolution
    /// </summary>
    public sealed partial class OutputInformationVideoResolution
    {
        /// <summary>
        /// Width in pixels. The maximum size depends on the encoder and can be referenced using the table below &lt;table&gt; &lt;tr&gt; &lt;td&gt;H264&lt;/td&gt; &lt;td&gt;H265&lt;/td&gt; &lt;td&gt;ProRes &lt;td&gt;AV1 &lt;td&gt;VP9 &lt;/tr&gt; &lt;tr&gt; &lt;td&gt;4096&lt;/td&gt; &lt;td&gt;8192&lt;/td&gt; &lt;td&gt;16386&lt;/td&gt; &lt;td&gt;16384&lt;/td&gt; &lt;td&gt;8192&lt;/td&gt; &lt;/tr&gt; &lt;/table&gt;<br/>
        /// Example: 7680
        /// </summary>
        /// <example>7680</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Width { get; set; }

        /// <summary>
        /// Height in pixels. The maximum size depends on the encoder and can be referenced using the table below &lt;table&gt; &lt;tr&gt; &lt;td&gt;H264&lt;/td&gt; &lt;td&gt;H265&lt;/td&gt; &lt;td&gt;ProRes &lt;td&gt;AV1 &lt;td&gt;VP9 &lt;/tr&gt; &lt;tr&gt; &lt;td&gt;4096&lt;/td&gt; &lt;td&gt;8192&lt;/td&gt; &lt;td&gt;16386&lt;/td&gt; &lt;td&gt;8704&lt;/td&gt; &lt;td&gt;8192&lt;/td&gt; &lt;/tr&gt; &lt;/table&gt;<br/>
        /// Example: 4320
        /// </summary>
        /// <example>4320</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Height { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputInformationVideoResolution" /> class.
        /// </summary>
        /// <param name="width">
        /// Width in pixels. The maximum size depends on the encoder and can be referenced using the table below &lt;table&gt; &lt;tr&gt; &lt;td&gt;H264&lt;/td&gt; &lt;td&gt;H265&lt;/td&gt; &lt;td&gt;ProRes &lt;td&gt;AV1 &lt;td&gt;VP9 &lt;/tr&gt; &lt;tr&gt; &lt;td&gt;4096&lt;/td&gt; &lt;td&gt;8192&lt;/td&gt; &lt;td&gt;16386&lt;/td&gt; &lt;td&gt;16384&lt;/td&gt; &lt;td&gt;8192&lt;/td&gt; &lt;/tr&gt; &lt;/table&gt;<br/>
        /// Example: 7680
        /// </param>
        /// <param name="height">
        /// Height in pixels. The maximum size depends on the encoder and can be referenced using the table below &lt;table&gt; &lt;tr&gt; &lt;td&gt;H264&lt;/td&gt; &lt;td&gt;H265&lt;/td&gt; &lt;td&gt;ProRes &lt;td&gt;AV1 &lt;td&gt;VP9 &lt;/tr&gt; &lt;tr&gt; &lt;td&gt;4096&lt;/td&gt; &lt;td&gt;8192&lt;/td&gt; &lt;td&gt;16386&lt;/td&gt; &lt;td&gt;8704&lt;/td&gt; &lt;td&gt;8192&lt;/td&gt; &lt;/tr&gt; &lt;/table&gt;<br/>
        /// Example: 4320
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputInformationVideoResolution(
            int width,
            int height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputInformationVideoResolution" /> class.
        /// </summary>
        public OutputInformationVideoResolution()
        {
        }
    }
}