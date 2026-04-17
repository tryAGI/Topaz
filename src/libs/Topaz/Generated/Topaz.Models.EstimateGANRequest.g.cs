
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EstimateGANRequest
    {
        /// <summary>
        /// Indicates which category of model is being used.<br/>
        /// Default Value: Enhance
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.EstimateGANRequestCategoryJsonConverter))]
        public global::Topaz.EstimateGANRequestCategory? Category { get; set; }

        /// <summary>
        /// The model to use for processing the image.<br/>
        /// Default Value: Standard V2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.EstimateGANRequestModelJsonConverter))]
        public global::Topaz.EstimateGANRequestModel? Model { get; set; }

        /// <summary>
        /// The height of the input image in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputHeight { get; set; }

        /// <summary>
        /// The width of the input image in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputWidth { get; set; }

        /// <summary>
        /// The desired height of the output image in pixels. Your image will automatically be upscaled to this specified value. If only one of `output_height` and `output_width` is set, then the other dimension is scaled proportionally. Only applicable for Enhance models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_height")]
        public int? OutputHeight { get; set; }

        /// <summary>
        /// The desired width of the output image in pixels. Your image will automatically be upscaled to this specified value. If only one of `output_height` and `output_width` is set, then the other dimension is scaled proportionally. Only applicable for Enhance models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_width")]
        public int? OutputWidth { get; set; }

        /// <summary>
        /// Default behavior is to letterbox the image if a differing aspect ratio is chosen. Enable `crop_to_fill` by setting this to `true` if you instead want to crop the image to fill the dimensions.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crop_to_fill")]
        public bool? CropToFill { get; set; }

        /// <summary>
        /// The desired format of the output image.<br/>
        /// Default Value: jpeg
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Topaz.JsonConverters.EstimateGANRequestOutputFormatJsonConverter))]
        public global::Topaz.EstimateGANRequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimateGANRequest" /> class.
        /// </summary>
        /// <param name="inputHeight">
        /// The height of the input image in pixels.
        /// </param>
        /// <param name="inputWidth">
        /// The width of the input image in pixels.
        /// </param>
        /// <param name="category">
        /// Indicates which category of model is being used.<br/>
        /// Default Value: Enhance
        /// </param>
        /// <param name="model">
        /// The model to use for processing the image.<br/>
        /// Default Value: Standard V2
        /// </param>
        /// <param name="outputHeight">
        /// The desired height of the output image in pixels. Your image will automatically be upscaled to this specified value. If only one of `output_height` and `output_width` is set, then the other dimension is scaled proportionally. Only applicable for Enhance models.
        /// </param>
        /// <param name="outputWidth">
        /// The desired width of the output image in pixels. Your image will automatically be upscaled to this specified value. If only one of `output_height` and `output_width` is set, then the other dimension is scaled proportionally. Only applicable for Enhance models.
        /// </param>
        /// <param name="cropToFill">
        /// Default behavior is to letterbox the image if a differing aspect ratio is chosen. Enable `crop_to_fill` by setting this to `true` if you instead want to crop the image to fill the dimensions.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="outputFormat">
        /// The desired format of the output image.<br/>
        /// Default Value: jpeg
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EstimateGANRequest(
            int inputHeight,
            int inputWidth,
            global::Topaz.EstimateGANRequestCategory? category,
            global::Topaz.EstimateGANRequestModel? model,
            int? outputHeight,
            int? outputWidth,
            bool? cropToFill,
            global::Topaz.EstimateGANRequestOutputFormat? outputFormat)
        {
            this.Category = category;
            this.Model = model;
            this.InputHeight = inputHeight;
            this.InputWidth = inputWidth;
            this.OutputHeight = outputHeight;
            this.OutputWidth = outputWidth;
            this.CropToFill = cropToFill;
            this.OutputFormat = outputFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimateGANRequest" /> class.
        /// </summary>
        public EstimateGANRequest()
        {
        }
    }
}