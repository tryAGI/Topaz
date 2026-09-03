
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: INSUFFICIENT_CREDITS
    /// </summary>
    public enum AcceptVideoRequestResponseErrorCode3
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
    public static class AcceptVideoRequestResponseErrorCode3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AcceptVideoRequestResponseErrorCode3 value)
        {
            return value switch
            {
                AcceptVideoRequestResponseErrorCode3.Forbidden => "FORBIDDEN",
                AcceptVideoRequestResponseErrorCode3.InsufficientCredits => "INSUFFICIENT_CREDITS",
                AcceptVideoRequestResponseErrorCode3.InvalidInput => "INVALID_INPUT",
                AcceptVideoRequestResponseErrorCode3.ServerError => "SERVER_ERROR",
                AcceptVideoRequestResponseErrorCode3.ServerMaintenance => "SERVER_MAINTENANCE",
                AcceptVideoRequestResponseErrorCode3.Unauthorized => "UNAUTHORIZED",
                AcceptVideoRequestResponseErrorCode3.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AcceptVideoRequestResponseErrorCode3? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => AcceptVideoRequestResponseErrorCode3.Forbidden,
                "INSUFFICIENT_CREDITS" => AcceptVideoRequestResponseErrorCode3.InsufficientCredits,
                "INVALID_INPUT" => AcceptVideoRequestResponseErrorCode3.InvalidInput,
                "SERVER_ERROR" => AcceptVideoRequestResponseErrorCode3.ServerError,
                "SERVER_MAINTENANCE" => AcceptVideoRequestResponseErrorCode3.ServerMaintenance,
                "UNAUTHORIZED" => AcceptVideoRequestResponseErrorCode3.Unauthorized,
                "UNKNOWN" => AcceptVideoRequestResponseErrorCode3.Unknown,
                _ => null,
            };
        }
    }
}