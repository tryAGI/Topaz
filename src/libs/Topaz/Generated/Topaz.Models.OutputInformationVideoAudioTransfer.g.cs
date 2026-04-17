
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: Copy
    /// </summary>
    public enum OutputInformationVideoAudioTransfer
    {
        /// <summary>
        /// 
        /// </summary>
        Convert,
        /// <summary>
        /// 
        /// </summary>
        Copy,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputInformationVideoAudioTransferExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputInformationVideoAudioTransfer value)
        {
            return value switch
            {
                OutputInformationVideoAudioTransfer.Convert => "Convert",
                OutputInformationVideoAudioTransfer.Copy => "Copy",
                OutputInformationVideoAudioTransfer.None => "None",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputInformationVideoAudioTransfer? ToEnum(string value)
        {
            return value switch
            {
                "Convert" => OutputInformationVideoAudioTransfer.Convert,
                "Copy" => OutputInformationVideoAudioTransfer.Copy,
                "None" => OutputInformationVideoAudioTransfer.None,
                _ => null,
            };
        }
    }
}