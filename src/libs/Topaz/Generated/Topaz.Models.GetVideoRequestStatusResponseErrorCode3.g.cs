
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: INVALID_INPUT
    /// </summary>
    public enum GetVideoRequestStatusResponseErrorCode3
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
    public static class GetVideoRequestStatusResponseErrorCode3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVideoRequestStatusResponseErrorCode3 value)
        {
            return value switch
            {
                GetVideoRequestStatusResponseErrorCode3.Forbidden => "FORBIDDEN",
                GetVideoRequestStatusResponseErrorCode3.InsufficientCredits => "INSUFFICIENT_CREDITS",
                GetVideoRequestStatusResponseErrorCode3.InvalidInput => "INVALID_INPUT",
                GetVideoRequestStatusResponseErrorCode3.ServerError => "SERVER_ERROR",
                GetVideoRequestStatusResponseErrorCode3.ServerMaintenance => "SERVER_MAINTENANCE",
                GetVideoRequestStatusResponseErrorCode3.Unauthorized => "UNAUTHORIZED",
                GetVideoRequestStatusResponseErrorCode3.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVideoRequestStatusResponseErrorCode3? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => GetVideoRequestStatusResponseErrorCode3.Forbidden,
                "INSUFFICIENT_CREDITS" => GetVideoRequestStatusResponseErrorCode3.InsufficientCredits,
                "INVALID_INPUT" => GetVideoRequestStatusResponseErrorCode3.InvalidInput,
                "SERVER_ERROR" => GetVideoRequestStatusResponseErrorCode3.ServerError,
                "SERVER_MAINTENANCE" => GetVideoRequestStatusResponseErrorCode3.ServerMaintenance,
                "UNAUTHORIZED" => GetVideoRequestStatusResponseErrorCode3.Unauthorized,
                "UNKNOWN" => GetVideoRequestStatusResponseErrorCode3.Unknown,
                _ => null,
            };
        }
    }
}