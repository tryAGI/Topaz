
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Desired output container<br/>
    /// Example: mp4
    /// </summary>
    public enum OutputInformationVideoContainer
    {
        /// <summary>
        /// 
        /// </summary>
        Mkv,
        /// <summary>
        /// 
        /// </summary>
        Mov,
        /// <summary>
        /// 
        /// </summary>
        Mp4,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputInformationVideoContainerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputInformationVideoContainer value)
        {
            return value switch
            {
                OutputInformationVideoContainer.Mkv => "mkv",
                OutputInformationVideoContainer.Mov => "mov",
                OutputInformationVideoContainer.Mp4 => "mp4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputInformationVideoContainer? ToEnum(string value)
        {
            return value switch
            {
                "mkv" => OutputInformationVideoContainer.Mkv,
                "mov" => OutputInformationVideoContainer.Mov,
                "mp4" => OutputInformationVideoContainer.Mp4,
                _ => null,
            };
        }
    }
}