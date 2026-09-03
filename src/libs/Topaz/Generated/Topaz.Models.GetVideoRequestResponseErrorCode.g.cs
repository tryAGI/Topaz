
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: UNAUTHORIZED
    /// </summary>
    public enum GetVideoRequestResponseErrorCode
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
    public static class GetVideoRequestResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVideoRequestResponseErrorCode value)
        {
            return value switch
            {
                GetVideoRequestResponseErrorCode.Forbidden => "FORBIDDEN",
                GetVideoRequestResponseErrorCode.InsufficientCredits => "INSUFFICIENT_CREDITS",
                GetVideoRequestResponseErrorCode.InvalidInput => "INVALID_INPUT",
                GetVideoRequestResponseErrorCode.ServerError => "SERVER_ERROR",
                GetVideoRequestResponseErrorCode.ServerMaintenance => "SERVER_MAINTENANCE",
                GetVideoRequestResponseErrorCode.Unauthorized => "UNAUTHORIZED",
                GetVideoRequestResponseErrorCode.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVideoRequestResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => GetVideoRequestResponseErrorCode.Forbidden,
                "INSUFFICIENT_CREDITS" => GetVideoRequestResponseErrorCode.InsufficientCredits,
                "INVALID_INPUT" => GetVideoRequestResponseErrorCode.InvalidInput,
                "SERVER_ERROR" => GetVideoRequestResponseErrorCode.ServerError,
                "SERVER_MAINTENANCE" => GetVideoRequestResponseErrorCode.ServerMaintenance,
                "UNAUTHORIZED" => GetVideoRequestResponseErrorCode.Unauthorized,
                "UNKNOWN" => GetVideoRequestResponseErrorCode.Unknown,
                _ => null,
            };
        }
    }
}