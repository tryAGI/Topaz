
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Indicates which category of model is being used.<br/>
    /// Default Value: Enhance
    /// </summary>
    public enum EstimateGANRequestCategory
    {
        /// <summary>
        /// 
        /// </summary>
        Denoise,
        /// <summary>
        /// 
        /// </summary>
        Enhance,
        /// <summary>
        /// 
        /// </summary>
        Lighting,
        /// <summary>
        /// 
        /// </summary>
        Matting,
        /// <summary>
        /// 
        /// </summary>
        Restore,
        /// <summary>
        /// 
        /// </summary>
        Sharpen,
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EstimateGANRequestCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimateGANRequestCategory value)
        {
            return value switch
            {
                EstimateGANRequestCategory.Denoise => "Denoise",
                EstimateGANRequestCategory.Enhance => "Enhance",
                EstimateGANRequestCategory.Lighting => "Lighting",
                EstimateGANRequestCategory.Matting => "Matting",
                EstimateGANRequestCategory.Restore => "Restore",
                EstimateGANRequestCategory.Sharpen => "Sharpen",
                EstimateGANRequestCategory.Tool => "Tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimateGANRequestCategory? ToEnum(string value)
        {
            return value switch
            {
                "Denoise" => EstimateGANRequestCategory.Denoise,
                "Enhance" => EstimateGANRequestCategory.Enhance,
                "Lighting" => EstimateGANRequestCategory.Lighting,
                "Matting" => EstimateGANRequestCategory.Matting,
                "Restore" => EstimateGANRequestCategory.Restore,
                "Sharpen" => EstimateGANRequestCategory.Sharpen,
                "Tool" => EstimateGANRequestCategory.Tool,
                _ => null,
            };
        }
    }
}