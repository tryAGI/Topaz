
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: UNAUTHORIZED
    /// </summary>
    public enum GetCancelEstimateResponseErrorCode2
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
    public static class GetCancelEstimateResponseErrorCode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCancelEstimateResponseErrorCode2 value)
        {
            return value switch
            {
                GetCancelEstimateResponseErrorCode2.Forbidden => "FORBIDDEN",
                GetCancelEstimateResponseErrorCode2.InsufficientCredits => "INSUFFICIENT_CREDITS",
                GetCancelEstimateResponseErrorCode2.InvalidInput => "INVALID_INPUT",
                GetCancelEstimateResponseErrorCode2.ServerError => "SERVER_ERROR",
                GetCancelEstimateResponseErrorCode2.ServerMaintenance => "SERVER_MAINTENANCE",
                GetCancelEstimateResponseErrorCode2.Unauthorized => "UNAUTHORIZED",
                GetCancelEstimateResponseErrorCode2.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCancelEstimateResponseErrorCode2? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => GetCancelEstimateResponseErrorCode2.Forbidden,
                "INSUFFICIENT_CREDITS" => GetCancelEstimateResponseErrorCode2.InsufficientCredits,
                "INVALID_INPUT" => GetCancelEstimateResponseErrorCode2.InvalidInput,
                "SERVER_ERROR" => GetCancelEstimateResponseErrorCode2.ServerError,
                "SERVER_MAINTENANCE" => GetCancelEstimateResponseErrorCode2.ServerMaintenance,
                "UNAUTHORIZED" => GetCancelEstimateResponseErrorCode2.Unauthorized,
                "UNKNOWN" => GetCancelEstimateResponseErrorCode2.Unknown,
                _ => null,
            };
        }
    }
}