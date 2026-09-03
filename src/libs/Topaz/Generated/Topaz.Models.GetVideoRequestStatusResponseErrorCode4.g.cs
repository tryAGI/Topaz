
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: SERVER_ERROR
    /// </summary>
    public enum GetVideoRequestStatusResponseErrorCode4
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
    public static class GetVideoRequestStatusResponseErrorCode4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVideoRequestStatusResponseErrorCode4 value)
        {
            return value switch
            {
                GetVideoRequestStatusResponseErrorCode4.Forbidden => "FORBIDDEN",
                GetVideoRequestStatusResponseErrorCode4.InsufficientCredits => "INSUFFICIENT_CREDITS",
                GetVideoRequestStatusResponseErrorCode4.InvalidInput => "INVALID_INPUT",
                GetVideoRequestStatusResponseErrorCode4.ServerError => "SERVER_ERROR",
                GetVideoRequestStatusResponseErrorCode4.ServerMaintenance => "SERVER_MAINTENANCE",
                GetVideoRequestStatusResponseErrorCode4.Unauthorized => "UNAUTHORIZED",
                GetVideoRequestStatusResponseErrorCode4.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVideoRequestStatusResponseErrorCode4? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => GetVideoRequestStatusResponseErrorCode4.Forbidden,
                "INSUFFICIENT_CREDITS" => GetVideoRequestStatusResponseErrorCode4.InsufficientCredits,
                "INVALID_INPUT" => GetVideoRequestStatusResponseErrorCode4.InvalidInput,
                "SERVER_ERROR" => GetVideoRequestStatusResponseErrorCode4.ServerError,
                "SERVER_MAINTENANCE" => GetVideoRequestStatusResponseErrorCode4.ServerMaintenance,
                "UNAUTHORIZED" => GetVideoRequestStatusResponseErrorCode4.Unauthorized,
                "UNKNOWN" => GetVideoRequestStatusResponseErrorCode4.Unknown,
                _ => null,
            };
        }
    }
}