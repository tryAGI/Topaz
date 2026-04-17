
#nullable enable

namespace Topaz
{
    /// <summary>
    /// The model to use for processing the image.<br/>
    /// Default Value: Adjust
    /// </summary>
    public enum LightingGANRequestModel
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
        Colorize,
        /// <summary>
        /// 
        /// </summary>
        WhiteBalance,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LightingGANRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LightingGANRequestModel value)
        {
            return value switch
            {
                LightingGANRequestModel.Adjust => "Adjust",
                LightingGANRequestModel.AdjustV2 => "Adjust V2",
                LightingGANRequestModel.Colorize => "Colorize",
                LightingGANRequestModel.WhiteBalance => "White Balance",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LightingGANRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "Adjust" => LightingGANRequestModel.Adjust,
                "Adjust V2" => LightingGANRequestModel.AdjustV2,
                "Colorize" => LightingGANRequestModel.Colorize,
                "White Balance" => LightingGANRequestModel.WhiteBalance,
                _ => null,
            };
        }
    }
}