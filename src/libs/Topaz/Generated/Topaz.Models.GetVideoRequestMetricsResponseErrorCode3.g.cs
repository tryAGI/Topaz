
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: INVALID_INPUT
    /// </summary>
    public enum GetVideoRequestMetricsResponseErrorCode3
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
    public static class GetVideoRequestMetricsResponseErrorCode3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVideoRequestMetricsResponseErrorCode3 value)
        {
            return value switch
            {
                GetVideoRequestMetricsResponseErrorCode3.Forbidden => "FORBIDDEN",
                GetVideoRequestMetricsResponseErrorCode3.InsufficientCredits => "INSUFFICIENT_CREDITS",
                GetVideoRequestMetricsResponseErrorCode3.InvalidInput => "INVALID_INPUT",
                GetVideoRequestMetricsResponseErrorCode3.ServerError => "SERVER_ERROR",
                GetVideoRequestMetricsResponseErrorCode3.ServerMaintenance => "SERVER_MAINTENANCE",
                GetVideoRequestMetricsResponseErrorCode3.Unauthorized => "UNAUTHORIZED",
                GetVideoRequestMetricsResponseErrorCode3.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVideoRequestMetricsResponseErrorCode3? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => GetVideoRequestMetricsResponseErrorCode3.Forbidden,
                "INSUFFICIENT_CREDITS" => GetVideoRequestMetricsResponseErrorCode3.InsufficientCredits,
                "INVALID_INPUT" => GetVideoRequestMetricsResponseErrorCode3.InvalidInput,
                "SERVER_ERROR" => GetVideoRequestMetricsResponseErrorCode3.ServerError,
                "SERVER_MAINTENANCE" => GetVideoRequestMetricsResponseErrorCode3.ServerMaintenance,
                "UNAUTHORIZED" => GetVideoRequestMetricsResponseErrorCode3.Unauthorized,
                "UNKNOWN" => GetVideoRequestMetricsResponseErrorCode3.Unknown,
                _ => null,
            };
        }
    }
}