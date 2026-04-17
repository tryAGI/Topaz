
#nullable enable

namespace Topaz
{
    /// <summary>
    /// The desired format of the output image.<br/>
    /// Default Value: jpeg
    /// </summary>
    public enum EnhanceGANRequestOutputFormat
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
    public static class EnhanceGANRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnhanceGANRequestOutputFormat value)
        {
            return value switch
            {
                EnhanceGANRequestOutputFormat.Jpeg => "jpeg",
                EnhanceGANRequestOutputFormat.Jpg => "jpg",
                EnhanceGANRequestOutputFormat.Png => "png",
                EnhanceGANRequestOutputFormat.Tif => "tif",
                EnhanceGANRequestOutputFormat.Tiff => "tiff",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnhanceGANRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => EnhanceGANRequestOutputFormat.Jpeg,
                "jpg" => EnhanceGANRequestOutputFormat.Jpg,
                "png" => EnhanceGANRequestOutputFormat.Png,
                "tif" => EnhanceGANRequestOutputFormat.Tif,
                "tiff" => EnhanceGANRequestOutputFormat.Tiff,
                _ => null,
            };
        }
    }
}