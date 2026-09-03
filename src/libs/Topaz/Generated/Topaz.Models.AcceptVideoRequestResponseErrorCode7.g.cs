
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: SERVER_MAINTENANCE
    /// </summary>
    public enum AcceptVideoRequestResponseErrorCode7
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
    public static class AcceptVideoRequestResponseErrorCode7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AcceptVideoRequestResponseErrorCode7 value)
        {
            return value switch
            {
                AcceptVideoRequestResponseErrorCode7.Forbidden => "FORBIDDEN",
                AcceptVideoRequestResponseErrorCode7.InsufficientCredits => "INSUFFICIENT_CREDITS",
                AcceptVideoRequestResponseErrorCode7.InvalidInput => "INVALID_INPUT",
                AcceptVideoRequestResponseErrorCode7.ServerError => "SERVER_ERROR",
                AcceptVideoRequestResponseErrorCode7.ServerMaintenance => "SERVER_MAINTENANCE",
                AcceptVideoRequestResponseErrorCode7.Unauthorized => "UNAUTHORIZED",
                AcceptVideoRequestResponseErrorCode7.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AcceptVideoRequestResponseErrorCode7? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => AcceptVideoRequestResponseErrorCode7.Forbidden,
                "INSUFFICIENT_CREDITS" => AcceptVideoRequestResponseErrorCode7.InsufficientCredits,
                "INVALID_INPUT" => AcceptVideoRequestResponseErrorCode7.InvalidInput,
                "SERVER_ERROR" => AcceptVideoRequestResponseErrorCode7.ServerError,
                "SERVER_MAINTENANCE" => AcceptVideoRequestResponseErrorCode7.ServerMaintenance,
                "UNAUTHORIZED" => AcceptVideoRequestResponseErrorCode7.Unauthorized,
                "UNKNOWN" => AcceptVideoRequestResponseErrorCode7.Unknown,
                _ => null,
            };
        }
    }
}