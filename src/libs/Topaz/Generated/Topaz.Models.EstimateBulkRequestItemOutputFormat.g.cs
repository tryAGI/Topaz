
#nullable enable

namespace Topaz
{
    /// <summary>
    /// The desired format of the output image.<br/>
    /// Default Value: jpeg
    /// </summary>
    public enum EstimateBulkRequestItemOutputFormat
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
    public static class EstimateBulkRequestItemOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimateBulkRequestItemOutputFormat value)
        {
            return value switch
            {
                EstimateBulkRequestItemOutputFormat.Jpeg => "jpeg",
                EstimateBulkRequestItemOutputFormat.Jpg => "jpg",
                EstimateBulkRequestItemOutputFormat.Png => "png",
                EstimateBulkRequestItemOutputFormat.Tif => "tif",
                EstimateBulkRequestItemOutputFormat.Tiff => "tiff",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimateBulkRequestItemOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => EstimateBulkRequestItemOutputFormat.Jpeg,
                "jpg" => EstimateBulkRequestItemOutputFormat.Jpg,
                "png" => EstimateBulkRequestItemOutputFormat.Png,
                "tif" => EstimateBulkRequestItemOutputFormat.Tif,
                "tiff" => EstimateBulkRequestItemOutputFormat.Tiff,
                _ => null,
            };
        }
    }
}