
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: UNAUTHORIZED
    /// </summary>
    public enum GetVideoRequestStatusResponseErrorCode
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
    public static class GetVideoRequestStatusResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVideoRequestStatusResponseErrorCode value)
        {
            return value switch
            {
                GetVideoRequestStatusResponseErrorCode.Forbidden => "FORBIDDEN",
                GetVideoRequestStatusResponseErrorCode.InsufficientCredits => "INSUFFICIENT_CREDITS",
                GetVideoRequestStatusResponseErrorCode.InvalidInput => "INVALID_INPUT",
                GetVideoRequestStatusResponseErrorCode.ServerError => "SERVER_ERROR",
                GetVideoRequestStatusResponseErrorCode.ServerMaintenance => "SERVER_MAINTENANCE",
                GetVideoRequestStatusResponseErrorCode.Unauthorized => "UNAUTHORIZED",
                GetVideoRequestStatusResponseErrorCode.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVideoRequestStatusResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => GetVideoRequestStatusResponseErrorCode.Forbidden,
                "INSUFFICIENT_CREDITS" => GetVideoRequestStatusResponseErrorCode.InsufficientCredits,
                "INVALID_INPUT" => GetVideoRequestStatusResponseErrorCode.InvalidInput,
                "SERVER_ERROR" => GetVideoRequestStatusResponseErrorCode.ServerError,
                "SERVER_MAINTENANCE" => GetVideoRequestStatusResponseErrorCode.ServerMaintenance,
                "UNAUTHORIZED" => GetVideoRequestStatusResponseErrorCode.Unauthorized,
                "UNKNOWN" => GetVideoRequestStatusResponseErrorCode.Unknown,
                _ => null,
            };
        }
    }
}