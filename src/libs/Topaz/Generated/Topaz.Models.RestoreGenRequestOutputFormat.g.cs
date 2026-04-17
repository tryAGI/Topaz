
#nullable enable

namespace Topaz
{
    /// <summary>
    /// The desired format of the output image.<br/>
    /// Default Value: jpeg
    /// </summary>
    public enum RestoreGenRequestOutputFormat
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
    public static class RestoreGenRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RestoreGenRequestOutputFormat value)
        {
            return value switch
            {
                RestoreGenRequestOutputFormat.Jpeg => "jpeg",
                RestoreGenRequestOutputFormat.Jpg => "jpg",
                RestoreGenRequestOutputFormat.Png => "png",
                RestoreGenRequestOutputFormat.Tif => "tif",
                RestoreGenRequestOutputFormat.Tiff => "tiff",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RestoreGenRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => RestoreGenRequestOutputFormat.Jpeg,
                "jpg" => RestoreGenRequestOutputFormat.Jpg,
                "png" => RestoreGenRequestOutputFormat.Png,
                "tif" => RestoreGenRequestOutputFormat.Tif,
                "tiff" => RestoreGenRequestOutputFormat.Tiff,
                _ => null,
            };
        }
    }
}