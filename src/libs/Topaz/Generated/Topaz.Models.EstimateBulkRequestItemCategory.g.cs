
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Indicates which category of model is being used.<br/>
    /// Default Value: Enhance
    /// </summary>
    public enum EstimateBulkRequestItemCategory
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
        Restore,
        /// <summary>
        /// 
        /// </summary>
        Sharpen,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EstimateBulkRequestItemCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimateBulkRequestItemCategory value)
        {
            return value switch
            {
                EstimateBulkRequestItemCategory.Denoise => "Denoise",
                EstimateBulkRequestItemCategory.Enhance => "Enhance",
                EstimateBulkRequestItemCategory.Lighting => "Lighting",
                EstimateBulkRequestItemCategory.Restore => "Restore",
                EstimateBulkRequestItemCategory.Sharpen => "Sharpen",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimateBulkRequestItemCategory? ToEnum(string value)
        {
            return value switch
            {
                "Denoise" => EstimateBulkRequestItemCategory.Denoise,
                "Enhance" => EstimateBulkRequestItemCategory.Enhance,
                "Lighting" => EstimateBulkRequestItemCategory.Lighting,
                "Restore" => EstimateBulkRequestItemCategory.Restore,
                "Sharpen" => EstimateBulkRequestItemCategory.Sharpen,
                _ => null,
            };
        }
    }
}