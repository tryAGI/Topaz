
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Type of grain<br/>
    /// Example: gaussian
    /// </summary>
    public enum UpscaleFilterGrainType
    {
        /// <summary>
        ///
        /// </summary>
        Gaussian,
        /// <summary>
        ///
        /// </summary>
        Grey,
        /// <summary>
        ///
        /// </summary>
        SilverRich,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpscaleFilterGrainTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpscaleFilterGrainType value)
        {
            return value switch
            {
                UpscaleFilterGrainType.Gaussian => "gaussian",
                UpscaleFilterGrainType.Grey => "grey",
                UpscaleFilterGrainType.SilverRich => "silver_rich",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpscaleFilterGrainType? ToEnum(string value)
        {
            return value switch
            {
                "gaussian" => UpscaleFilterGrainType.Gaussian,
                "grey" => UpscaleFilterGrainType.Grey,
                "silver_rich" => UpscaleFilterGrainType.SilverRich,
                _ => null,
            };
        }
    }
}