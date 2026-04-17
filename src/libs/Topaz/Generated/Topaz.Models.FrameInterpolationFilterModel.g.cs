
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Short code name for the AI model<br/>
    /// Example: apo-8
    /// </summary>
    public enum FrameInterpolationFilterModel
    {
        /// <summary>
        /// 
        /// </summary>
        Apf2,
        /// <summary>
        /// 
        /// </summary>
        Apo8,
        /// <summary>
        /// 
        /// </summary>
        Chf3,
        /// <summary>
        /// 
        /// </summary>
        Chr2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FrameInterpolationFilterModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FrameInterpolationFilterModel value)
        {
            return value switch
            {
                FrameInterpolationFilterModel.Apf2 => "apf-2",
                FrameInterpolationFilterModel.Apo8 => "apo-8",
                FrameInterpolationFilterModel.Chf3 => "chf-3",
                FrameInterpolationFilterModel.Chr2 => "chr-2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FrameInterpolationFilterModel? ToEnum(string value)
        {
            return value switch
            {
                "apf-2" => FrameInterpolationFilterModel.Apf2,
                "apo-8" => FrameInterpolationFilterModel.Apo8,
                "chf-3" => FrameInterpolationFilterModel.Chf3,
                "chr-2" => FrameInterpolationFilterModel.Chr2,
                _ => null,
            };
        }
    }
}