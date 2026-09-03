
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: UNAUTHORIZED
    /// </summary>
    public enum GetVideoRequestMetricsResponseErrorCode
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
    public static class GetVideoRequestMetricsResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVideoRequestMetricsResponseErrorCode value)
        {
            return value switch
            {
                GetVideoRequestMetricsResponseErrorCode.Forbidden => "FORBIDDEN",
                GetVideoRequestMetricsResponseErrorCode.InsufficientCredits => "INSUFFICIENT_CREDITS",
                GetVideoRequestMetricsResponseErrorCode.InvalidInput => "INVALID_INPUT",
                GetVideoRequestMetricsResponseErrorCode.ServerError => "SERVER_ERROR",
                GetVideoRequestMetricsResponseErrorCode.ServerMaintenance => "SERVER_MAINTENANCE",
                GetVideoRequestMetricsResponseErrorCode.Unauthorized => "UNAUTHORIZED",
                GetVideoRequestMetricsResponseErrorCode.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVideoRequestMetricsResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => GetVideoRequestMetricsResponseErrorCode.Forbidden,
                "INSUFFICIENT_CREDITS" => GetVideoRequestMetricsResponseErrorCode.InsufficientCredits,
                "INVALID_INPUT" => GetVideoRequestMetricsResponseErrorCode.InvalidInput,
                "SERVER_ERROR" => GetVideoRequestMetricsResponseErrorCode.ServerError,
                "SERVER_MAINTENANCE" => GetVideoRequestMetricsResponseErrorCode.ServerMaintenance,
                "UNAUTHORIZED" => GetVideoRequestMetricsResponseErrorCode.Unauthorized,
                "UNKNOWN" => GetVideoRequestMetricsResponseErrorCode.Unknown,
                _ => null,
            };
        }
    }
}