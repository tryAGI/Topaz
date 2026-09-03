
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: INVALID_INPUT
    /// </summary>
    public enum AcceptVideoRequestResponseErrorCode5
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
    public static class AcceptVideoRequestResponseErrorCode5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AcceptVideoRequestResponseErrorCode5 value)
        {
            return value switch
            {
                AcceptVideoRequestResponseErrorCode5.Forbidden => "FORBIDDEN",
                AcceptVideoRequestResponseErrorCode5.InsufficientCredits => "INSUFFICIENT_CREDITS",
                AcceptVideoRequestResponseErrorCode5.InvalidInput => "INVALID_INPUT",
                AcceptVideoRequestResponseErrorCode5.ServerError => "SERVER_ERROR",
                AcceptVideoRequestResponseErrorCode5.ServerMaintenance => "SERVER_MAINTENANCE",
                AcceptVideoRequestResponseErrorCode5.Unauthorized => "UNAUTHORIZED",
                AcceptVideoRequestResponseErrorCode5.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AcceptVideoRequestResponseErrorCode5? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => AcceptVideoRequestResponseErrorCode5.Forbidden,
                "INSUFFICIENT_CREDITS" => AcceptVideoRequestResponseErrorCode5.InsufficientCredits,
                "INVALID_INPUT" => AcceptVideoRequestResponseErrorCode5.InvalidInput,
                "SERVER_ERROR" => AcceptVideoRequestResponseErrorCode5.ServerError,
                "SERVER_MAINTENANCE" => AcceptVideoRequestResponseErrorCode5.ServerMaintenance,
                "UNAUTHORIZED" => AcceptVideoRequestResponseErrorCode5.Unauthorized,
                "UNKNOWN" => AcceptVideoRequestResponseErrorCode5.Unknown,
                _ => null,
            };
        }
    }
}