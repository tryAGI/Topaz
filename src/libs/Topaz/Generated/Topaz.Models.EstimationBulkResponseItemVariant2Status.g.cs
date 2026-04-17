
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Indicates that an error occurred while processing this item in the bulk request.
    /// </summary>
    public enum EstimationBulkResponseItemVariant2Status
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EstimationBulkResponseItemVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimationBulkResponseItemVariant2Status value)
        {
            return value switch
            {
                EstimationBulkResponseItemVariant2Status.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimationBulkResponseItemVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "error" => EstimationBulkResponseItemVariant2Status.Error,
                _ => null,
            };
        }
    }
}