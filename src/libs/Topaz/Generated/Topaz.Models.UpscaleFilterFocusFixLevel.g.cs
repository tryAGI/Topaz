
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Downscales video input for stronger correction of blurred subjects<br/>
    /// Example: Normal
    /// </summary>
    public enum UpscaleFilterFocusFixLevel
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Normal,
        /// <summary>
        /// 
        /// </summary>
        Strong,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpscaleFilterFocusFixLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpscaleFilterFocusFixLevel value)
        {
            return value switch
            {
                UpscaleFilterFocusFixLevel.None => "None",
                UpscaleFilterFocusFixLevel.Normal => "Normal",
                UpscaleFilterFocusFixLevel.Strong => "Strong",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpscaleFilterFocusFixLevel? ToEnum(string value)
        {
            return value switch
            {
                "None" => UpscaleFilterFocusFixLevel.None,
                "Normal" => UpscaleFilterFocusFixLevel.Normal,
                "Strong" => UpscaleFilterFocusFixLevel.Strong,
                _ => null,
            };
        }
    }
}