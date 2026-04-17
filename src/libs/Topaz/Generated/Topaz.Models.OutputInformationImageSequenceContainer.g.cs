
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Desired output container, defaults to the input container<br/>
    /// Example: TIFF
    /// </summary>
    public enum OutputInformationImageSequenceContainer
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
    public static class OutputInformationImageSequenceContainerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputInformationImageSequenceContainer value)
        {
            return value switch
            {
                OutputInformationImageSequenceContainer.Dpx => "DPX",
                OutputInformationImageSequenceContainer.Exr => "EXR",
                OutputInformationImageSequenceContainer.Jpeg => "JPEG",
                OutputInformationImageSequenceContainer.Png => "PNG",
                OutputInformationImageSequenceContainer.Tiff => "TIFF",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputInformationImageSequenceContainer? ToEnum(string value)
        {
            return value switch
            {
                "DPX" => OutputInformationImageSequenceContainer.Dpx,
                "EXR" => OutputInformationImageSequenceContainer.Exr,
                "JPEG" => OutputInformationImageSequenceContainer.Jpeg,
                "PNG" => OutputInformationImageSequenceContainer.Png,
                "TIFF" => OutputInformationImageSequenceContainer.Tiff,
                _ => null,
            };
        }
    }
}