
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: FORBIDDEN
    /// </summary>
    public enum GetVideoRequestMetricsResponseErrorCode2
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
    public static class GetVideoRequestMetricsResponseErrorCode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVideoRequestMetricsResponseErrorCode2 value)
        {
            return value switch
            {
                GetVideoRequestMetricsResponseErrorCode2.Forbidden => "FORBIDDEN",
                GetVideoRequestMetricsResponseErrorCode2.InsufficientCredits => "INSUFFICIENT_CREDITS",
                GetVideoRequestMetricsResponseErrorCode2.InvalidInput => "INVALID_INPUT",
                GetVideoRequestMetricsResponseErrorCode2.ServerError => "SERVER_ERROR",
                GetVideoRequestMetricsResponseErrorCode2.ServerMaintenance => "SERVER_MAINTENANCE",
                GetVideoRequestMetricsResponseErrorCode2.Unauthorized => "UNAUTHORIZED",
                GetVideoRequestMetricsResponseErrorCode2.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVideoRequestMetricsResponseErrorCode2? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => GetVideoRequestMetricsResponseErrorCode2.Forbidden,
                "INSUFFICIENT_CREDITS" => GetVideoRequestMetricsResponseErrorCode2.InsufficientCredits,
                "INVALID_INPUT" => GetVideoRequestMetricsResponseErrorCode2.InvalidInput,
                "SERVER_ERROR" => GetVideoRequestMetricsResponseErrorCode2.ServerError,
                "SERVER_MAINTENANCE" => GetVideoRequestMetricsResponseErrorCode2.ServerMaintenance,
                "UNAUTHORIZED" => GetVideoRequestMetricsResponseErrorCode2.Unauthorized,
                "UNKNOWN" => GetVideoRequestMetricsResponseErrorCode2.Unknown,
                _ => null,
            };
        }
    }
}