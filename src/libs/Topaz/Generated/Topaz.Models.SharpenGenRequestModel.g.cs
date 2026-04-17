
#nullable enable

namespace Topaz
{
    /// <summary>
    /// The model to use for processing the image.<br/>
    /// Default Value: Super Focus V2
    /// </summary>
    public enum SharpenGenRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        SuperFocusV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SharpenGenRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SharpenGenRequestModel value)
        {
            return value switch
            {
                SharpenGenRequestModel.SuperFocusV2 => "Super Focus V2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SharpenGenRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "Super Focus V2" => SharpenGenRequestModel.SuperFocusV2,
                _ => null,
            };
        }
    }
}