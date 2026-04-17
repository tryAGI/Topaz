
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Indicates which category of model is being used.<br/>
    /// Default Value: Enhance
    /// </summary>
    public enum EstimateGenRequestCategory
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
    public static class EstimateGenRequestCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimateGenRequestCategory value)
        {
            return value switch
            {
                EstimateGenRequestCategory.Denoise => "Denoise",
                EstimateGenRequestCategory.Enhance => "Enhance",
                EstimateGenRequestCategory.Lighting => "Lighting",
                EstimateGenRequestCategory.Matting => "Matting",
                EstimateGenRequestCategory.Restore => "Restore",
                EstimateGenRequestCategory.Sharpen => "Sharpen",
                EstimateGenRequestCategory.Tool => "Tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimateGenRequestCategory? ToEnum(string value)
        {
            return value switch
            {
                "Denoise" => EstimateGenRequestCategory.Denoise,
                "Enhance" => EstimateGenRequestCategory.Enhance,
                "Lighting" => EstimateGenRequestCategory.Lighting,
                "Matting" => EstimateGenRequestCategory.Matting,
                "Restore" => EstimateGenRequestCategory.Restore,
                "Sharpen" => EstimateGenRequestCategory.Sharpen,
                "Tool" => EstimateGenRequestCategory.Tool,
                _ => null,
            };
        }
    }
}