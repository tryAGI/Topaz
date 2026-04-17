
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Optional specification of field order for interlaced input videos<br/>
    /// Example: Auto
    /// </summary>
    public enum UpscaleFilterFieldOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        BottomFirst,
        /// <summary>
        /// 
        /// </summary>
        TopFirst,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpscaleFilterFieldOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpscaleFilterFieldOrder value)
        {
            return value switch
            {
                UpscaleFilterFieldOrder.Auto => "Auto",
                UpscaleFilterFieldOrder.BottomFirst => "BottomFirst",
                UpscaleFilterFieldOrder.TopFirst => "TopFirst",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpscaleFilterFieldOrder? ToEnum(string value)
        {
            return value switch
            {
                "Auto" => UpscaleFilterFieldOrder.Auto,
                "BottomFirst" => UpscaleFilterFieldOrder.BottomFirst,
                "TopFirst" => UpscaleFilterFieldOrder.TopFirst,
                _ => null,
            };
        }
    }
}