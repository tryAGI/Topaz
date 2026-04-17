
#nullable enable

namespace Topaz
{
    /// <summary>
    /// The model to use for processing the image.<br/>
    /// Default Value: Standard
    /// </summary>
    public enum SharpenGANRequestModel
    {
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
        MotionBlur,
        /// <summary>
        /// 
        /// </summary>
        Natural,
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
        Strong,
        /// <summary>
        /// 
        /// </summary>
        Wildlife,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SharpenGANRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SharpenGANRequestModel value)
        {
            return value switch
            {
                SharpenGANRequestModel.LensBlur => "Lens Blur",
                SharpenGANRequestModel.LensBlurV2 => "Lens Blur V2",
                SharpenGANRequestModel.MotionBlur => "Motion Blur",
                SharpenGANRequestModel.Natural => "Natural",
                SharpenGANRequestModel.Portrait => "Portrait",
                SharpenGANRequestModel.Refocus => "Refocus",
                SharpenGANRequestModel.Standard => "Standard",
                SharpenGANRequestModel.Strong => "Strong",
                SharpenGANRequestModel.Wildlife => "Wildlife",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SharpenGANRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "Lens Blur" => SharpenGANRequestModel.LensBlur,
                "Lens Blur V2" => SharpenGANRequestModel.LensBlurV2,
                "Motion Blur" => SharpenGANRequestModel.MotionBlur,
                "Natural" => SharpenGANRequestModel.Natural,
                "Portrait" => SharpenGANRequestModel.Portrait,
                "Refocus" => SharpenGANRequestModel.Refocus,
                "Standard" => SharpenGANRequestModel.Standard,
                "Strong" => SharpenGANRequestModel.Strong,
                "Wildlife" => SharpenGANRequestModel.Wildlife,
                _ => null,
            };
        }
    }
}