
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: FORBIDDEN
    /// </summary>
    public enum GetCancelEstimateResponseErrorCode3
    {
        /// <summary>
        ///
        /// </summary>
        Forbidden,
        /// <summary>
        ///
        /// </summary>
        InsufficientCredits,
        /// <summary>
        ///
        /// </summary>
        InvalidInput,
        /// <summary>
        ///
        /// </summary>
        ServerError,
        /// <summary>
        ///
        /// </summary>
        ServerMaintenance,
        /// <summary>
        ///
        /// </summary>
        Unauthorized,
        /// <summary>
        ///
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCancelEstimateResponseErrorCode3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCancelEstimateResponseErrorCode3 value)
        {
            return value switch
            {
                GetCancelEstimateResponseErrorCode3.Forbidden => "FORBIDDEN",
                GetCancelEstimateResponseErrorCode3.InsufficientCredits => "INSUFFICIENT_CREDITS",
                GetCancelEstimateResponseErrorCode3.InvalidInput => "INVALID_INPUT",
                GetCancelEstimateResponseErrorCode3.ServerError => "SERVER_ERROR",
                GetCancelEstimateResponseErrorCode3.ServerMaintenance => "SERVER_MAINTENANCE",
                GetCancelEstimateResponseErrorCode3.Unauthorized => "UNAUTHORIZED",
                GetCancelEstimateResponseErrorCode3.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCancelEstimateResponseErrorCode3? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => GetCancelEstimateResponseErrorCode3.Forbidden,
                "INSUFFICIENT_CREDITS" => GetCancelEstimateResponseErrorCode3.InsufficientCredits,
                "INVALID_INPUT" => GetCancelEstimateResponseErrorCode3.InvalidInput,
                "SERVER_ERROR" => GetCancelEstimateResponseErrorCode3.ServerError,
                "SERVER_MAINTENANCE" => GetCancelEstimateResponseErrorCode3.ServerMaintenance,
                "UNAUTHORIZED" => GetCancelEstimateResponseErrorCode3.Unauthorized,
                "UNKNOWN" => GetCancelEstimateResponseErrorCode3.Unknown,
                _ => null,
            };
        }
    }
}