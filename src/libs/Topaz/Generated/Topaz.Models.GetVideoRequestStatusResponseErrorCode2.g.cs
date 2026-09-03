
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: FORBIDDEN
    /// </summary>
    public enum GetVideoRequestStatusResponseErrorCode2
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
    public static class GetVideoRequestStatusResponseErrorCode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVideoRequestStatusResponseErrorCode2 value)
        {
            return value switch
            {
                GetVideoRequestStatusResponseErrorCode2.Forbidden => "FORBIDDEN",
                GetVideoRequestStatusResponseErrorCode2.InsufficientCredits => "INSUFFICIENT_CREDITS",
                GetVideoRequestStatusResponseErrorCode2.InvalidInput => "INVALID_INPUT",
                GetVideoRequestStatusResponseErrorCode2.ServerError => "SERVER_ERROR",
                GetVideoRequestStatusResponseErrorCode2.ServerMaintenance => "SERVER_MAINTENANCE",
                GetVideoRequestStatusResponseErrorCode2.Unauthorized => "UNAUTHORIZED",
                GetVideoRequestStatusResponseErrorCode2.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVideoRequestStatusResponseErrorCode2? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => GetVideoRequestStatusResponseErrorCode2.Forbidden,
                "INSUFFICIENT_CREDITS" => GetVideoRequestStatusResponseErrorCode2.InsufficientCredits,
                "INVALID_INPUT" => GetVideoRequestStatusResponseErrorCode2.InvalidInput,
                "SERVER_ERROR" => GetVideoRequestStatusResponseErrorCode2.ServerError,
                "SERVER_MAINTENANCE" => GetVideoRequestStatusResponseErrorCode2.ServerMaintenance,
                "UNAUTHORIZED" => GetVideoRequestStatusResponseErrorCode2.Unauthorized,
                "UNKNOWN" => GetVideoRequestStatusResponseErrorCode2.Unknown,
                _ => null,
            };
        }
    }
}