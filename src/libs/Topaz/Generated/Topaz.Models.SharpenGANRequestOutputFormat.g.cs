
#nullable enable

namespace Topaz
{
    /// <summary>
    /// The desired format of the output image.<br/>
    /// Default Value: jpeg
    /// </summary>
    public enum SharpenGANRequestOutputFormat
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
    public static class SharpenGANRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SharpenGANRequestOutputFormat value)
        {
            return value switch
            {
                SharpenGANRequestOutputFormat.Jpeg => "jpeg",
                SharpenGANRequestOutputFormat.Jpg => "jpg",
                SharpenGANRequestOutputFormat.Png => "png",
                SharpenGANRequestOutputFormat.Tif => "tif",
                SharpenGANRequestOutputFormat.Tiff => "tiff",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SharpenGANRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => SharpenGANRequestOutputFormat.Jpeg,
                "jpg" => SharpenGANRequestOutputFormat.Jpg,
                "png" => SharpenGANRequestOutputFormat.Png,
                "tif" => SharpenGANRequestOutputFormat.Tif,
                "tiff" => SharpenGANRequestOutputFormat.Tiff,
                _ => null,
            };
        }
    }
}