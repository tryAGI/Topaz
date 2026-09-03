
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: INVALID_INPUT
    /// </summary>
    public enum GetCancelEstimateResponseErrorCode4
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
    public static class GetCancelEstimateResponseErrorCode4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCancelEstimateResponseErrorCode4 value)
        {
            return value switch
            {
                GetCancelEstimateResponseErrorCode4.Forbidden => "FORBIDDEN",
                GetCancelEstimateResponseErrorCode4.InsufficientCredits => "INSUFFICIENT_CREDITS",
                GetCancelEstimateResponseErrorCode4.InvalidInput => "INVALID_INPUT",
                GetCancelEstimateResponseErrorCode4.ServerError => "SERVER_ERROR",
                GetCancelEstimateResponseErrorCode4.ServerMaintenance => "SERVER_MAINTENANCE",
                GetCancelEstimateResponseErrorCode4.Unauthorized => "UNAUTHORIZED",
                GetCancelEstimateResponseErrorCode4.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCancelEstimateResponseErrorCode4? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => GetCancelEstimateResponseErrorCode4.Forbidden,
                "INSUFFICIENT_CREDITS" => GetCancelEstimateResponseErrorCode4.InsufficientCredits,
                "INVALID_INPUT" => GetCancelEstimateResponseErrorCode4.InvalidInput,
                "SERVER_ERROR" => GetCancelEstimateResponseErrorCode4.ServerError,
                "SERVER_MAINTENANCE" => GetCancelEstimateResponseErrorCode4.ServerMaintenance,
                "UNAUTHORIZED" => GetCancelEstimateResponseErrorCode4.Unauthorized,
                "UNKNOWN" => GetCancelEstimateResponseErrorCode4.Unknown,
                _ => null,
            };
        }
    }
}