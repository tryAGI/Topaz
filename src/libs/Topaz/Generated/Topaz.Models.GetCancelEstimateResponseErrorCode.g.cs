
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: INVALID_INPUT
    /// </summary>
    public enum GetCancelEstimateResponseErrorCode
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
    public static class GetCancelEstimateResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCancelEstimateResponseErrorCode value)
        {
            return value switch
            {
                GetCancelEstimateResponseErrorCode.Forbidden => "FORBIDDEN",
                GetCancelEstimateResponseErrorCode.InsufficientCredits => "INSUFFICIENT_CREDITS",
                GetCancelEstimateResponseErrorCode.InvalidInput => "INVALID_INPUT",
                GetCancelEstimateResponseErrorCode.ServerError => "SERVER_ERROR",
                GetCancelEstimateResponseErrorCode.ServerMaintenance => "SERVER_MAINTENANCE",
                GetCancelEstimateResponseErrorCode.Unauthorized => "UNAUTHORIZED",
                GetCancelEstimateResponseErrorCode.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCancelEstimateResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => GetCancelEstimateResponseErrorCode.Forbidden,
                "INSUFFICIENT_CREDITS" => GetCancelEstimateResponseErrorCode.InsufficientCredits,
                "INVALID_INPUT" => GetCancelEstimateResponseErrorCode.InvalidInput,
                "SERVER_ERROR" => GetCancelEstimateResponseErrorCode.ServerError,
                "SERVER_MAINTENANCE" => GetCancelEstimateResponseErrorCode.ServerMaintenance,
                "UNAUTHORIZED" => GetCancelEstimateResponseErrorCode.Unauthorized,
                "UNKNOWN" => GetCancelEstimateResponseErrorCode.Unknown,
                _ => null,
            };
        }
    }
}