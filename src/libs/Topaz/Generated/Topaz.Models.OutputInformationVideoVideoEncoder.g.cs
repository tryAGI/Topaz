
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: H265
    /// </summary>
    public enum OutputInformationVideoVideoEncoder
    {
        /// <summary>
        /// 
        /// </summary>
        Av1,
        /// <summary>
        /// 
        /// </summary>
        H264,
        /// <summary>
        /// 
        /// </summary>
        H265,
        /// <summary>
        /// 
        /// </summary>
        Vp9,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputInformationVideoVideoEncoderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputInformationVideoVideoEncoder value)
        {
            return value switch
            {
                OutputInformationVideoVideoEncoder.Av1 => "AV1",
                OutputInformationVideoVideoEncoder.H264 => "H264",
                OutputInformationVideoVideoEncoder.H265 => "H265",
                OutputInformationVideoVideoEncoder.Vp9 => "VP9",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputInformationVideoVideoEncoder? ToEnum(string value)
        {
            return value switch
            {
                "AV1" => OutputInformationVideoVideoEncoder.Av1,
                "H264" => OutputInformationVideoVideoEncoder.H264,
                "H265" => OutputInformationVideoVideoEncoder.H265,
                "VP9" => OutputInformationVideoVideoEncoder.Vp9,
                _ => null,
            };
        }
    }
}