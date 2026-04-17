
#nullable enable

namespace Topaz
{
    /// <summary>
    /// __Required if audioTransfer is Copy or Convert.__<br/>
    /// Example: AAC
    /// </summary>
    public enum OutputInformationVideoAudioCodec
    {
        /// <summary>
        /// 
        /// </summary>
        Aac,
        /// <summary>
        /// 
        /// </summary>
        Ac3,
        /// <summary>
        /// 
        /// </summary>
        Pcm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputInformationVideoAudioCodecExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputInformationVideoAudioCodec value)
        {
            return value switch
            {
                OutputInformationVideoAudioCodec.Aac => "AAC",
                OutputInformationVideoAudioCodec.Ac3 => "AC3",
                OutputInformationVideoAudioCodec.Pcm => "PCM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputInformationVideoAudioCodec? ToEnum(string value)
        {
            return value switch
            {
                "AAC" => OutputInformationVideoAudioCodec.Aac,
                "AC3" => OutputInformationVideoAudioCodec.Ac3,
                "PCM" => OutputInformationVideoAudioCodec.Pcm,
                _ => null,
            };
        }
    }
}