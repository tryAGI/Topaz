
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Parameter mode of the selected model<br/>
    /// - Auto - parameter estimation is used with no customization<br/>
    /// - Relative - uses auto parameters with optional weights added<br/>
    /// - Manual - all parameters are manually set<br/>
    /// Example: Auto
    /// </summary>
    public enum UpscaleFilterAuto
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Manual,
        /// <summary>
        /// 
        /// </summary>
        Relative,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpscaleFilterAutoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpscaleFilterAuto value)
        {
            return value switch
            {
                UpscaleFilterAuto.Auto => "Auto",
                UpscaleFilterAuto.Manual => "Manual",
                UpscaleFilterAuto.Relative => "Relative",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpscaleFilterAuto? ToEnum(string value)
        {
            return value switch
            {
                "Auto" => UpscaleFilterAuto.Auto,
                "Manual" => UpscaleFilterAuto.Manual,
                "Relative" => UpscaleFilterAuto.Relative,
                _ => null,
            };
        }
    }
}