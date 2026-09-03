
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: FORBIDDEN
    /// </summary>
    public enum AcceptVideoRequestResponseErrorCode4
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
    public static class AcceptVideoRequestResponseErrorCode4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AcceptVideoRequestResponseErrorCode4 value)
        {
            return value switch
            {
                AcceptVideoRequestResponseErrorCode4.Forbidden => "FORBIDDEN",
                AcceptVideoRequestResponseErrorCode4.InsufficientCredits => "INSUFFICIENT_CREDITS",
                AcceptVideoRequestResponseErrorCode4.InvalidInput => "INVALID_INPUT",
                AcceptVideoRequestResponseErrorCode4.ServerError => "SERVER_ERROR",
                AcceptVideoRequestResponseErrorCode4.ServerMaintenance => "SERVER_MAINTENANCE",
                AcceptVideoRequestResponseErrorCode4.Unauthorized => "UNAUTHORIZED",
                AcceptVideoRequestResponseErrorCode4.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AcceptVideoRequestResponseErrorCode4? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => AcceptVideoRequestResponseErrorCode4.Forbidden,
                "INSUFFICIENT_CREDITS" => AcceptVideoRequestResponseErrorCode4.InsufficientCredits,
                "INVALID_INPUT" => AcceptVideoRequestResponseErrorCode4.InvalidInput,
                "SERVER_ERROR" => AcceptVideoRequestResponseErrorCode4.ServerError,
                "SERVER_MAINTENANCE" => AcceptVideoRequestResponseErrorCode4.ServerMaintenance,
                "UNAUTHORIZED" => AcceptVideoRequestResponseErrorCode4.Unauthorized,
                "UNKNOWN" => AcceptVideoRequestResponseErrorCode4.Unknown,
                _ => null,
            };
        }
    }
}