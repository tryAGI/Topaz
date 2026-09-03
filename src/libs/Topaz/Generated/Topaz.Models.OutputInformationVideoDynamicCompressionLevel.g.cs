
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Automatic CQP selection. Mutually exclusive with `videoBitrate`. If neither is provided, this defaults to `High`. Applies to the `AV1`, `H264`, and `H265` encoders only.<br/>
    /// Example: Mid
    /// </summary>
    public enum OutputInformationVideoDynamicCompressionLevel
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Mid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputInformationVideoDynamicCompressionLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputInformationVideoDynamicCompressionLevel value)
        {
            return value switch
            {
                OutputInformationVideoDynamicCompressionLevel.High => "High",
                OutputInformationVideoDynamicCompressionLevel.Low => "Low",
                OutputInformationVideoDynamicCompressionLevel.Mid => "Mid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputInformationVideoDynamicCompressionLevel? ToEnum(string value)
        {
            return value switch
            {
                "High" => OutputInformationVideoDynamicCompressionLevel.High,
                "Low" => OutputInformationVideoDynamicCompressionLevel.Low,
                "Mid" => OutputInformationVideoDynamicCompressionLevel.Mid,
                _ => null,
            };
        }
    }
}