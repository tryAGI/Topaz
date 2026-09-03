
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: SERVER_ERROR
    /// </summary>
    public enum AcceptVideoRequestResponseErrorCode6
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
    public static class AcceptVideoRequestResponseErrorCode6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AcceptVideoRequestResponseErrorCode6 value)
        {
            return value switch
            {
                AcceptVideoRequestResponseErrorCode6.Forbidden => "FORBIDDEN",
                AcceptVideoRequestResponseErrorCode6.InsufficientCredits => "INSUFFICIENT_CREDITS",
                AcceptVideoRequestResponseErrorCode6.InvalidInput => "INVALID_INPUT",
                AcceptVideoRequestResponseErrorCode6.ServerError => "SERVER_ERROR",
                AcceptVideoRequestResponseErrorCode6.ServerMaintenance => "SERVER_MAINTENANCE",
                AcceptVideoRequestResponseErrorCode6.Unauthorized => "UNAUTHORIZED",
                AcceptVideoRequestResponseErrorCode6.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AcceptVideoRequestResponseErrorCode6? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => AcceptVideoRequestResponseErrorCode6.Forbidden,
                "INSUFFICIENT_CREDITS" => AcceptVideoRequestResponseErrorCode6.InsufficientCredits,
                "INVALID_INPUT" => AcceptVideoRequestResponseErrorCode6.InvalidInput,
                "SERVER_ERROR" => AcceptVideoRequestResponseErrorCode6.ServerError,
                "SERVER_MAINTENANCE" => AcceptVideoRequestResponseErrorCode6.ServerMaintenance,
                "UNAUTHORIZED" => AcceptVideoRequestResponseErrorCode6.Unauthorized,
                "UNKNOWN" => AcceptVideoRequestResponseErrorCode6.Unknown,
                _ => null,
            };
        }
    }
}