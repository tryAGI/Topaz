
#nullable enable

namespace Topaz
{
    /// <summary>
    /// The model to use for processing the image.<br/>
    /// Default Value: Standard V2
    /// </summary>
    public enum EstimateBulkRequestItemModel
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
        DustScratch,
        /// <summary>
        /// 
        /// </summary>
        DustScratchV2,
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
        RecoveryV2,
        /// <summary>
        /// 
        /// </summary>
        Redefine,
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
        StandardMax,
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
        SuperFocusV2,
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
        /// <summary>
        /// 
        /// </summary>
        Wonder,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EstimateBulkRequestItemModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimateBulkRequestItemModel value)
        {
            return value switch
            {
                EstimateBulkRequestItemModel.Adjust => "Adjust",
                EstimateBulkRequestItemModel.AdjustV2 => "Adjust V2",
                EstimateBulkRequestItemModel.Cgi => "CGI",
                EstimateBulkRequestItemModel.Colorize => "Colorize",
                EstimateBulkRequestItemModel.DustScratch => "Dust-Scratch",
                EstimateBulkRequestItemModel.DustScratchV2 => "Dust-Scratch V2",
                EstimateBulkRequestItemModel.Extreme => "Extreme",
                EstimateBulkRequestItemModel.HighFidelityV2 => "High Fidelity V2",
                EstimateBulkRequestItemModel.LensBlur => "Lens Blur",
                EstimateBulkRequestItemModel.LensBlurV2 => "Lens Blur V2",
                EstimateBulkRequestItemModel.LowResolutionV2 => "Low Resolution V2",
                EstimateBulkRequestItemModel.MotionBlur => "Motion Blur",
                EstimateBulkRequestItemModel.Natural => "Natural",
                EstimateBulkRequestItemModel.Normal => "Normal",
                EstimateBulkRequestItemModel.Object => "Object",
                EstimateBulkRequestItemModel.Portrait => "Portrait",
                EstimateBulkRequestItemModel.RecoveryV2 => "Recovery V2",
                EstimateBulkRequestItemModel.Redefine => "Redefine",
                EstimateBulkRequestItemModel.Refocus => "Refocus",
                EstimateBulkRequestItemModel.Standard => "Standard",
                EstimateBulkRequestItemModel.StandardMax => "Standard MAX",
                EstimateBulkRequestItemModel.StandardV2 => "Standard V2",
                EstimateBulkRequestItemModel.Strong => "Strong",
                EstimateBulkRequestItemModel.SuperFocusV2 => "Super Focus V2",
                EstimateBulkRequestItemModel.TextRefine => "Text Refine",
                EstimateBulkRequestItemModel.TransparencyUpscale => "Transparency Upscale",
                EstimateBulkRequestItemModel.WhiteBalance => "White Balance",
                EstimateBulkRequestItemModel.Wildlife => "Wildlife",
                EstimateBulkRequestItemModel.Wonder => "Wonder",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimateBulkRequestItemModel? ToEnum(string value)
        {
            return value switch
            {
                "Adjust" => EstimateBulkRequestItemModel.Adjust,
                "Adjust V2" => EstimateBulkRequestItemModel.AdjustV2,
                "CGI" => EstimateBulkRequestItemModel.Cgi,
                "Colorize" => EstimateBulkRequestItemModel.Colorize,
                "Dust-Scratch" => EstimateBulkRequestItemModel.DustScratch,
                "Dust-Scratch V2" => EstimateBulkRequestItemModel.DustScratchV2,
                "Extreme" => EstimateBulkRequestItemModel.Extreme,
                "High Fidelity V2" => EstimateBulkRequestItemModel.HighFidelityV2,
                "Lens Blur" => EstimateBulkRequestItemModel.LensBlur,
                "Lens Blur V2" => EstimateBulkRequestItemModel.LensBlurV2,
                "Low Resolution V2" => EstimateBulkRequestItemModel.LowResolutionV2,
                "Motion Blur" => EstimateBulkRequestItemModel.MotionBlur,
                "Natural" => EstimateBulkRequestItemModel.Natural,
                "Normal" => EstimateBulkRequestItemModel.Normal,
                "Object" => EstimateBulkRequestItemModel.Object,
                "Portrait" => EstimateBulkRequestItemModel.Portrait,
                "Recovery V2" => EstimateBulkRequestItemModel.RecoveryV2,
                "Redefine" => EstimateBulkRequestItemModel.Redefine,
                "Refocus" => EstimateBulkRequestItemModel.Refocus,
                "Standard" => EstimateBulkRequestItemModel.Standard,
                "Standard MAX" => EstimateBulkRequestItemModel.StandardMax,
                "Standard V2" => EstimateBulkRequestItemModel.StandardV2,
                "Strong" => EstimateBulkRequestItemModel.Strong,
                "Super Focus V2" => EstimateBulkRequestItemModel.SuperFocusV2,
                "Text Refine" => EstimateBulkRequestItemModel.TextRefine,
                "Transparency Upscale" => EstimateBulkRequestItemModel.TransparencyUpscale,
                "White Balance" => EstimateBulkRequestItemModel.WhiteBalance,
                "Wildlife" => EstimateBulkRequestItemModel.Wildlife,
                "Wonder" => EstimateBulkRequestItemModel.Wonder,
                _ => null,
            };
        }
    }
}