
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: SERVER_ERROR
    /// </summary>
    public enum GetCancelEstimateResponseErrorCode5
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
    public static class GetCancelEstimateResponseErrorCode5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCancelEstimateResponseErrorCode5 value)
        {
            return value switch
            {
                GetCancelEstimateResponseErrorCode5.Forbidden => "FORBIDDEN",
                GetCancelEstimateResponseErrorCode5.InsufficientCredits => "INSUFFICIENT_CREDITS",
                GetCancelEstimateResponseErrorCode5.InvalidInput => "INVALID_INPUT",
                GetCancelEstimateResponseErrorCode5.ServerError => "SERVER_ERROR",
                GetCancelEstimateResponseErrorCode5.ServerMaintenance => "SERVER_MAINTENANCE",
                GetCancelEstimateResponseErrorCode5.Unauthorized => "UNAUTHORIZED",
                GetCancelEstimateResponseErrorCode5.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCancelEstimateResponseErrorCode5? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => GetCancelEstimateResponseErrorCode5.Forbidden,
                "INSUFFICIENT_CREDITS" => GetCancelEstimateResponseErrorCode5.InsufficientCredits,
                "INVALID_INPUT" => GetCancelEstimateResponseErrorCode5.InvalidInput,
                "SERVER_ERROR" => GetCancelEstimateResponseErrorCode5.ServerError,
                "SERVER_MAINTENANCE" => GetCancelEstimateResponseErrorCode5.ServerMaintenance,
                "UNAUTHORIZED" => GetCancelEstimateResponseErrorCode5.Unauthorized,
                "UNKNOWN" => GetCancelEstimateResponseErrorCode5.Unknown,
                _ => null,
            };
        }
    }
}