
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Frame/field type of the video<br/>
    /// Example: Progressive
    /// </summary>
    public enum UpscaleFilterVideoType
    {
        /// <summary>
        /// 
        /// </summary>
        Interlaced,
        /// <summary>
        /// 
        /// </summary>
        Progressive,
        /// <summary>
        /// 
        /// </summary>
        ProgressiveInterlaced,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpscaleFilterVideoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpscaleFilterVideoType value)
        {
            return value switch
            {
                UpscaleFilterVideoType.Interlaced => "Interlaced",
                UpscaleFilterVideoType.Progressive => "Progressive",
                UpscaleFilterVideoType.ProgressiveInterlaced => "ProgressiveInterlaced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpscaleFilterVideoType? ToEnum(string value)
        {
            return value switch
            {
                "Interlaced" => UpscaleFilterVideoType.Interlaced,
                "Progressive" => UpscaleFilterVideoType.Progressive,
                "ProgressiveInterlaced" => UpscaleFilterVideoType.ProgressiveInterlaced,
                _ => null,
            };
        }
    }
}