
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Indicates that the estimation for this item in the bulk request was successful.
    /// </summary>
    public enum EstimationBulkResponseItemVariant1Status
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EstimationBulkResponseItemVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimationBulkResponseItemVariant1Status value)
        {
            return value switch
            {
                EstimationBulkResponseItemVariant1Status.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimationBulkResponseItemVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "success" => EstimationBulkResponseItemVariant1Status.Success,
                _ => null,
            };
        }
    }
}