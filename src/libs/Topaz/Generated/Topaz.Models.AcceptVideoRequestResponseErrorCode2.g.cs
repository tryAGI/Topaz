
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: UNAUTHORIZED
    /// </summary>
    public enum AcceptVideoRequestResponseErrorCode2
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
    public static class AcceptVideoRequestResponseErrorCode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AcceptVideoRequestResponseErrorCode2 value)
        {
            return value switch
            {
                AcceptVideoRequestResponseErrorCode2.Forbidden => "FORBIDDEN",
                AcceptVideoRequestResponseErrorCode2.InsufficientCredits => "INSUFFICIENT_CREDITS",
                AcceptVideoRequestResponseErrorCode2.InvalidInput => "INVALID_INPUT",
                AcceptVideoRequestResponseErrorCode2.ServerError => "SERVER_ERROR",
                AcceptVideoRequestResponseErrorCode2.ServerMaintenance => "SERVER_MAINTENANCE",
                AcceptVideoRequestResponseErrorCode2.Unauthorized => "UNAUTHORIZED",
                AcceptVideoRequestResponseErrorCode2.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AcceptVideoRequestResponseErrorCode2? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => AcceptVideoRequestResponseErrorCode2.Forbidden,
                "INSUFFICIENT_CREDITS" => AcceptVideoRequestResponseErrorCode2.InsufficientCredits,
                "INVALID_INPUT" => AcceptVideoRequestResponseErrorCode2.InvalidInput,
                "SERVER_ERROR" => AcceptVideoRequestResponseErrorCode2.ServerError,
                "SERVER_MAINTENANCE" => AcceptVideoRequestResponseErrorCode2.ServerMaintenance,
                "UNAUTHORIZED" => AcceptVideoRequestResponseErrorCode2.Unauthorized,
                "UNKNOWN" => AcceptVideoRequestResponseErrorCode2.Unknown,
                _ => null,
            };
        }
    }
}