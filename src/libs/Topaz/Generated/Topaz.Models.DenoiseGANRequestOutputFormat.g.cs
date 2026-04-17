
#nullable enable

namespace Topaz
{
    /// <summary>
    /// The desired format of the output image.<br/>
    /// Default Value: jpeg
    /// </summary>
    public enum DenoiseGANRequestOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Jpeg,
        /// <summary>
        /// 
        /// </summary>
        Jpg,
        /// <summary>
        /// 
        /// </summary>
        Png,
        /// <summary>
        /// 
        /// </summary>
        Tif,
        /// <summary>
        /// 
        /// </summary>
        Tiff,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DenoiseGANRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DenoiseGANRequestOutputFormat value)
        {
            return value switch
            {
                DenoiseGANRequestOutputFormat.Jpeg => "jpeg",
                DenoiseGANRequestOutputFormat.Jpg => "jpg",
                DenoiseGANRequestOutputFormat.Png => "png",
                DenoiseGANRequestOutputFormat.Tif => "tif",
                DenoiseGANRequestOutputFormat.Tiff => "tiff",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DenoiseGANRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => DenoiseGANRequestOutputFormat.Jpeg,
                "jpg" => DenoiseGANRequestOutputFormat.Jpg,
                "png" => DenoiseGANRequestOutputFormat.Png,
                "tif" => DenoiseGANRequestOutputFormat.Tif,
                "tiff" => DenoiseGANRequestOutputFormat.Tiff,
                _ => null,
            };
        }
    }
}