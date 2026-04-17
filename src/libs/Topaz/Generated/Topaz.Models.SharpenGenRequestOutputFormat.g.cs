
#nullable enable

namespace Topaz
{
    /// <summary>
    /// The desired format of the output image.<br/>
    /// Default Value: jpeg
    /// </summary>
    public enum SharpenGenRequestOutputFormat
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
    public static class SharpenGenRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SharpenGenRequestOutputFormat value)
        {
            return value switch
            {
                SharpenGenRequestOutputFormat.Jpeg => "jpeg",
                SharpenGenRequestOutputFormat.Jpg => "jpg",
                SharpenGenRequestOutputFormat.Png => "png",
                SharpenGenRequestOutputFormat.Tif => "tif",
                SharpenGenRequestOutputFormat.Tiff => "tiff",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SharpenGenRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => SharpenGenRequestOutputFormat.Jpeg,
                "jpg" => SharpenGenRequestOutputFormat.Jpg,
                "png" => SharpenGenRequestOutputFormat.Png,
                "tif" => SharpenGenRequestOutputFormat.Tif,
                "tiff" => SharpenGenRequestOutputFormat.Tiff,
                _ => null,
            };
        }
    }
}