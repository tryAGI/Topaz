
#nullable enable

namespace Topaz
{
    /// <summary>
    /// The desired format of the output image.<br/>
    /// Default Value: jpeg
    /// </summary>
    public enum EstimateGANRequestOutputFormat
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
    public static class EstimateGANRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimateGANRequestOutputFormat value)
        {
            return value switch
            {
                EstimateGANRequestOutputFormat.Jpeg => "jpeg",
                EstimateGANRequestOutputFormat.Jpg => "jpg",
                EstimateGANRequestOutputFormat.Png => "png",
                EstimateGANRequestOutputFormat.Tif => "tif",
                EstimateGANRequestOutputFormat.Tiff => "tiff",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimateGANRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => EstimateGANRequestOutputFormat.Jpeg,
                "jpg" => EstimateGANRequestOutputFormat.Jpg,
                "png" => EstimateGANRequestOutputFormat.Png,
                "tif" => EstimateGANRequestOutputFormat.Tif,
                "tiff" => EstimateGANRequestOutputFormat.Tiff,
                _ => null,
            };
        }
    }
}