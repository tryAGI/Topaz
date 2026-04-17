
#nullable enable

namespace Topaz
{
    /// <summary>
    /// The model to use for processing the image.<br/>
    /// Default Value: Standard V2
    /// </summary>
    public enum EstimateGANRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        Adjust,
        /// <summary>
        /// 
        /// </summary>
        AdjustV2,
        /// <summary>
        /// 
        /// </summary>
        Cgi,
        /// <summary>
        /// 
        /// </summary>
        Colorize,
        /// <summary>
        /// 
        /// </summary>
        Extreme,
        /// <summary>
        /// 
        /// </summary>
        HighFidelityV2,
        /// <summary>
        /// 
        /// </summary>
        LensBlur,
        /// <summary>
        /// 
        /// </summary>
        LensBlurV2,
        /// <summary>
        /// 
        /// </summary>
        LowResolutionV2,
        /// <summary>
        /// 
        /// </summary>
        MotionBlur,
        /// <summary>
        /// 
        /// </summary>
        Natural,
        /// <summary>
        /// 
        /// </summary>
        Normal,
        /// <summary>
        /// 
        /// </summary>
        Object,
        /// <summary>
        /// 
        /// </summary>
        Portrait,
        /// <summary>
        /// 
        /// </summary>
        Refocus,
        /// <summary>
        /// 
        /// </summary>
        Standard,
        /// <summary>
        /// 
        /// </summary>
        StandardV2,
        /// <summary>
        /// 
        /// </summary>
        Strong,
        /// <summary>
        /// 
        /// </summary>
        TextRefine,
        /// <summary>
        /// 
        /// </summary>
        TransparencyUpscale,
        /// <summary>
        /// 
        /// </summary>
        WhiteBalance,
        /// <summary>
        /// 
        /// </summary>
        Wildlife,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EstimateGANRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimateGANRequestModel value)
        {
            return value switch
            {
                EstimateGANRequestModel.Adjust => "Adjust",
                EstimateGANRequestModel.AdjustV2 => "Adjust V2",
                EstimateGANRequestModel.Cgi => "CGI",
                EstimateGANRequestModel.Colorize => "Colorize",
                EstimateGANRequestModel.Extreme => "Extreme",
                EstimateGANRequestModel.HighFidelityV2 => "High Fidelity V2",
                EstimateGANRequestModel.LensBlur => "Lens Blur",
                EstimateGANRequestModel.LensBlurV2 => "Lens Blur V2",
                EstimateGANRequestModel.LowResolutionV2 => "Low Resolution V2",
                EstimateGANRequestModel.MotionBlur => "Motion Blur",
                EstimateGANRequestModel.Natural => "Natural",
                EstimateGANRequestModel.Normal => "Normal",
                EstimateGANRequestModel.Object => "Object",
                EstimateGANRequestModel.Portrait => "Portrait",
                EstimateGANRequestModel.Refocus => "Refocus",
                EstimateGANRequestModel.Standard => "Standard",
                EstimateGANRequestModel.StandardV2 => "Standard V2",
                EstimateGANRequestModel.Strong => "Strong",
                EstimateGANRequestModel.TextRefine => "Text Refine",
                EstimateGANRequestModel.TransparencyUpscale => "Transparency Upscale",
                EstimateGANRequestModel.WhiteBalance => "White Balance",
                EstimateGANRequestModel.Wildlife => "Wildlife",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimateGANRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "Adjust" => EstimateGANRequestModel.Adjust,
                "Adjust V2" => EstimateGANRequestModel.AdjustV2,
                "CGI" => EstimateGANRequestModel.Cgi,
                "Colorize" => EstimateGANRequestModel.Colorize,
                "Extreme" => EstimateGANRequestModel.Extreme,
                "High Fidelity V2" => EstimateGANRequestModel.HighFidelityV2,
                "Lens Blur" => EstimateGANRequestModel.LensBlur,
                "Lens Blur V2" => EstimateGANRequestModel.LensBlurV2,
                "Low Resolution V2" => EstimateGANRequestModel.LowResolutionV2,
                "Motion Blur" => EstimateGANRequestModel.MotionBlur,
                "Natural" => EstimateGANRequestModel.Natural,
                "Normal" => EstimateGANRequestModel.Normal,
                "Object" => EstimateGANRequestModel.Object,
                "Portrait" => EstimateGANRequestModel.Portrait,
                "Refocus" => EstimateGANRequestModel.Refocus,
                "Standard" => EstimateGANRequestModel.Standard,
                "Standard V2" => EstimateGANRequestModel.StandardV2,
                "Strong" => EstimateGANRequestModel.Strong,
                "Text Refine" => EstimateGANRequestModel.TextRefine,
                "Transparency Upscale" => EstimateGANRequestModel.TransparencyUpscale,
                "White Balance" => EstimateGANRequestModel.WhiteBalance,
                "Wildlife" => EstimateGANRequestModel.Wildlife,
                _ => null,
            };
        }
    }
}