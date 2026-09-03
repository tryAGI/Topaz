
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: SERVER_ERROR
    /// </summary>
    public enum GetVideoRequestMetricsResponseErrorCode4
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
    public static class GetVideoRequestMetricsResponseErrorCode4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVideoRequestMetricsResponseErrorCode4 value)
        {
            return value switch
            {
                GetVideoRequestMetricsResponseErrorCode4.Forbidden => "FORBIDDEN",
                GetVideoRequestMetricsResponseErrorCode4.InsufficientCredits => "INSUFFICIENT_CREDITS",
                GetVideoRequestMetricsResponseErrorCode4.InvalidInput => "INVALID_INPUT",
                GetVideoRequestMetricsResponseErrorCode4.ServerError => "SERVER_ERROR",
                GetVideoRequestMetricsResponseErrorCode4.ServerMaintenance => "SERVER_MAINTENANCE",
                GetVideoRequestMetricsResponseErrorCode4.Unauthorized => "UNAUTHORIZED",
                GetVideoRequestMetricsResponseErrorCode4.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVideoRequestMetricsResponseErrorCode4? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => GetVideoRequestMetricsResponseErrorCode4.Forbidden,
                "INSUFFICIENT_CREDITS" => GetVideoRequestMetricsResponseErrorCode4.InsufficientCredits,
                "INVALID_INPUT" => GetVideoRequestMetricsResponseErrorCode4.InvalidInput,
                "SERVER_ERROR" => GetVideoRequestMetricsResponseErrorCode4.ServerError,
                "SERVER_MAINTENANCE" => GetVideoRequestMetricsResponseErrorCode4.ServerMaintenance,
                "UNAUTHORIZED" => GetVideoRequestMetricsResponseErrorCode4.Unauthorized,
                "UNKNOWN" => GetVideoRequestMetricsResponseErrorCode4.Unknown,
                _ => null,
            };
        }
    }
}