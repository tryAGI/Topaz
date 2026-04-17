
#nullable enable

namespace Topaz
{
    /// <summary>
    /// The model to use for processing the image.<br/>
    /// Default Value: Dust-Scratch
    /// </summary>
    public enum RestoreGenRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        DustScratch,
        /// <summary>
        /// 
        /// </summary>
        DustScratchV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RestoreGenRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RestoreGenRequestModel value)
        {
            return value switch
            {
                RestoreGenRequestModel.DustScratch => "Dust-Scratch",
                RestoreGenRequestModel.DustScratchV2 => "Dust-Scratch V2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RestoreGenRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "Dust-Scratch" => RestoreGenRequestModel.DustScratch,
                "Dust-Scratch V2" => RestoreGenRequestModel.DustScratchV2,
                _ => null,
            };
        }
    }
}