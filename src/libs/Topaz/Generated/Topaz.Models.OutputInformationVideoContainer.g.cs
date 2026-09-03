
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Desired output container. Defaults to `mp4`. Ignored and replaced with `mov` when `videoEncoder` is `ProRes`, and with `mp4` when it is `AV1` or `VP9`.<br/>
    /// Example: mp4
    /// </summary>
    public enum OutputInformationVideoContainer
    {
        /// <summary>
        ///
        /// </summary>
        Avi,
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
        /// <summary>
        ///
        /// </summary>
        Webm,
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
                OutputInformationVideoContainer.Avi => "avi",
                OutputInformationVideoContainer.Mkv => "mkv",
                OutputInformationVideoContainer.Mov => "mov",
                OutputInformationVideoContainer.Mp4 => "mp4",
                OutputInformationVideoContainer.Webm => "webm",
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
                "avi" => OutputInformationVideoContainer.Avi,
                "mkv" => OutputInformationVideoContainer.Mkv,
                "mov" => OutputInformationVideoContainer.Mov,
                "mp4" => OutputInformationVideoContainer.Mp4,
                "webm" => OutputInformationVideoContainer.Webm,
                _ => null,
            };
        }
    }
}