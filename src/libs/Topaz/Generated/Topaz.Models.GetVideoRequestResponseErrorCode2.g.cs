
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: FORBIDDEN
    /// </summary>
    public enum GetVideoRequestResponseErrorCode2
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
    public static class GetVideoRequestResponseErrorCode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVideoRequestResponseErrorCode2 value)
        {
            return value switch
            {
                GetVideoRequestResponseErrorCode2.Forbidden => "FORBIDDEN",
                GetVideoRequestResponseErrorCode2.InsufficientCredits => "INSUFFICIENT_CREDITS",
                GetVideoRequestResponseErrorCode2.InvalidInput => "INVALID_INPUT",
                GetVideoRequestResponseErrorCode2.ServerError => "SERVER_ERROR",
                GetVideoRequestResponseErrorCode2.ServerMaintenance => "SERVER_MAINTENANCE",
                GetVideoRequestResponseErrorCode2.Unauthorized => "UNAUTHORIZED",
                GetVideoRequestResponseErrorCode2.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVideoRequestResponseErrorCode2? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => GetVideoRequestResponseErrorCode2.Forbidden,
                "INSUFFICIENT_CREDITS" => GetVideoRequestResponseErrorCode2.InsufficientCredits,
                "INVALID_INPUT" => GetVideoRequestResponseErrorCode2.InvalidInput,
                "SERVER_ERROR" => GetVideoRequestResponseErrorCode2.ServerError,
                "SERVER_MAINTENANCE" => GetVideoRequestResponseErrorCode2.ServerMaintenance,
                "UNAUTHORIZED" => GetVideoRequestResponseErrorCode2.Unauthorized,
                "UNKNOWN" => GetVideoRequestResponseErrorCode2.Unknown,
                _ => null,
            };
        }
    }
}