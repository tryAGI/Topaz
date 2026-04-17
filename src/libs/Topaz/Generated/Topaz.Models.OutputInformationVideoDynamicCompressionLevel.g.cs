
#nullable enable

namespace Topaz
{
    /// <summary>
    /// __Required if videoBitrate is not provided.__ Automatic CQP selection.<br/>
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