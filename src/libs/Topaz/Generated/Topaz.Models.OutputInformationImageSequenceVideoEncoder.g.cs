
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: TIFF
    /// </summary>
    public enum OutputInformationImageSequenceVideoEncoder
    {
        /// <summary>
        /// 
        /// </summary>
        Dpx,
        /// <summary>
        /// 
        /// </summary>
        Exr,
        /// <summary>
        /// 
        /// </summary>
        Jpeg,
        /// <summary>
        /// 
        /// </summary>
        Png,
        /// <summary>
        /// 
        /// </summary>
        Tiff,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputInformationImageSequenceVideoEncoderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputInformationImageSequenceVideoEncoder value)
        {
            return value switch
            {
                OutputInformationImageSequenceVideoEncoder.Dpx => "DPX",
                OutputInformationImageSequenceVideoEncoder.Exr => "EXR",
                OutputInformationImageSequenceVideoEncoder.Jpeg => "JPEG",
                OutputInformationImageSequenceVideoEncoder.Png => "PNG",
                OutputInformationImageSequenceVideoEncoder.Tiff => "TIFF",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputInformationImageSequenceVideoEncoder? ToEnum(string value)
        {
            return value switch
            {
                "DPX" => OutputInformationImageSequenceVideoEncoder.Dpx,
                "EXR" => OutputInformationImageSequenceVideoEncoder.Exr,
                "JPEG" => OutputInformationImageSequenceVideoEncoder.Jpeg,
                "PNG" => OutputInformationImageSequenceVideoEncoder.Png,
                "TIFF" => OutputInformationImageSequenceVideoEncoder.Tiff,
                _ => null,
            };
        }
    }
}