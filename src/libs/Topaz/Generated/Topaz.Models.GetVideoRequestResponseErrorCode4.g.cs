
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: SERVER_ERROR
    /// </summary>
    public enum GetVideoRequestResponseErrorCode4
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
    public static class GetVideoRequestResponseErrorCode4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVideoRequestResponseErrorCode4 value)
        {
            return value switch
            {
                GetVideoRequestResponseErrorCode4.Forbidden => "FORBIDDEN",
                GetVideoRequestResponseErrorCode4.InsufficientCredits => "INSUFFICIENT_CREDITS",
                GetVideoRequestResponseErrorCode4.InvalidInput => "INVALID_INPUT",
                GetVideoRequestResponseErrorCode4.ServerError => "SERVER_ERROR",
                GetVideoRequestResponseErrorCode4.ServerMaintenance => "SERVER_MAINTENANCE",
                GetVideoRequestResponseErrorCode4.Unauthorized => "UNAUTHORIZED",
                GetVideoRequestResponseErrorCode4.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVideoRequestResponseErrorCode4? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => GetVideoRequestResponseErrorCode4.Forbidden,
                "INSUFFICIENT_CREDITS" => GetVideoRequestResponseErrorCode4.InsufficientCredits,
                "INVALID_INPUT" => GetVideoRequestResponseErrorCode4.InvalidInput,
                "SERVER_ERROR" => GetVideoRequestResponseErrorCode4.ServerError,
                "SERVER_MAINTENANCE" => GetVideoRequestResponseErrorCode4.ServerMaintenance,
                "UNAUTHORIZED" => GetVideoRequestResponseErrorCode4.Unauthorized,
                "UNKNOWN" => GetVideoRequestResponseErrorCode4.Unknown,
                _ => null,
            };
        }
    }
}