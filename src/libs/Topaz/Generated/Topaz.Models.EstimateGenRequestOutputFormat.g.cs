
#nullable enable

namespace Topaz
{
    /// <summary>
    /// The desired format of the output image.<br/>
    /// Default Value: jpeg
    /// </summary>
    public enum EstimateGenRequestOutputFormat
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
    public static class EstimateGenRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimateGenRequestOutputFormat value)
        {
            return value switch
            {
                EstimateGenRequestOutputFormat.Jpeg => "jpeg",
                EstimateGenRequestOutputFormat.Jpg => "jpg",
                EstimateGenRequestOutputFormat.Png => "png",
                EstimateGenRequestOutputFormat.Tif => "tif",
                EstimateGenRequestOutputFormat.Tiff => "tiff",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimateGenRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => EstimateGenRequestOutputFormat.Jpeg,
                "jpg" => EstimateGenRequestOutputFormat.Jpg,
                "png" => EstimateGenRequestOutputFormat.Png,
                "tif" => EstimateGenRequestOutputFormat.Tif,
                "tiff" => EstimateGenRequestOutputFormat.Tiff,
                _ => null,
            };
        }
    }
}