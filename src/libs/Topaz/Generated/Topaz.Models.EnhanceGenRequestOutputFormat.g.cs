
#nullable enable

namespace Topaz
{
    /// <summary>
    /// The desired format of the output image.<br/>
    /// Default Value: jpeg
    /// </summary>
    public enum EnhanceGenRequestOutputFormat
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
    public static class EnhanceGenRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnhanceGenRequestOutputFormat value)
        {
            return value switch
            {
                EnhanceGenRequestOutputFormat.Jpeg => "jpeg",
                EnhanceGenRequestOutputFormat.Jpg => "jpg",
                EnhanceGenRequestOutputFormat.Png => "png",
                EnhanceGenRequestOutputFormat.Tif => "tif",
                EnhanceGenRequestOutputFormat.Tiff => "tiff",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnhanceGenRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => EnhanceGenRequestOutputFormat.Jpeg,
                "jpg" => EnhanceGenRequestOutputFormat.Jpg,
                "png" => EnhanceGenRequestOutputFormat.Png,
                "tif" => EnhanceGenRequestOutputFormat.Tif,
                "tiff" => EnhanceGenRequestOutputFormat.Tiff,
                _ => null,
            };
        }
    }
}