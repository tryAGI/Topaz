
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: INVALID_INPUT
    /// </summary>
    public enum GetVideoRequestResponseErrorCode3
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
    public static class GetVideoRequestResponseErrorCode3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVideoRequestResponseErrorCode3 value)
        {
            return value switch
            {
                GetVideoRequestResponseErrorCode3.Forbidden => "FORBIDDEN",
                GetVideoRequestResponseErrorCode3.InsufficientCredits => "INSUFFICIENT_CREDITS",
                GetVideoRequestResponseErrorCode3.InvalidInput => "INVALID_INPUT",
                GetVideoRequestResponseErrorCode3.ServerError => "SERVER_ERROR",
                GetVideoRequestResponseErrorCode3.ServerMaintenance => "SERVER_MAINTENANCE",
                GetVideoRequestResponseErrorCode3.Unauthorized => "UNAUTHORIZED",
                GetVideoRequestResponseErrorCode3.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVideoRequestResponseErrorCode3? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => GetVideoRequestResponseErrorCode3.Forbidden,
                "INSUFFICIENT_CREDITS" => GetVideoRequestResponseErrorCode3.InsufficientCredits,
                "INVALID_INPUT" => GetVideoRequestResponseErrorCode3.InvalidInput,
                "SERVER_ERROR" => GetVideoRequestResponseErrorCode3.ServerError,
                "SERVER_MAINTENANCE" => GetVideoRequestResponseErrorCode3.ServerMaintenance,
                "UNAUTHORIZED" => GetVideoRequestResponseErrorCode3.Unauthorized,
                "UNKNOWN" => GetVideoRequestResponseErrorCode3.Unknown,
                _ => null,
            };
        }
    }
}