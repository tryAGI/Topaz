
#nullable enable

namespace Topaz
{
    /// <summary>
    /// The desired format of the output image.<br/>
    /// Default Value: jpeg
    /// </summary>
    public enum LightingGANRequestOutputFormat
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
    public static class LightingGANRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LightingGANRequestOutputFormat value)
        {
            return value switch
            {
                LightingGANRequestOutputFormat.Jpeg => "jpeg",
                LightingGANRequestOutputFormat.Jpg => "jpg",
                LightingGANRequestOutputFormat.Png => "png",
                LightingGANRequestOutputFormat.Tif => "tif",
                LightingGANRequestOutputFormat.Tiff => "tiff",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LightingGANRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => LightingGANRequestOutputFormat.Jpeg,
                "jpg" => LightingGANRequestOutputFormat.Jpg,
                "png" => LightingGANRequestOutputFormat.Png,
                "tif" => LightingGANRequestOutputFormat.Tif,
                "tiff" => LightingGANRequestOutputFormat.Tiff,
                _ => null,
            };
        }
    }
}