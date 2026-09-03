
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: INVALID_INPUT
    /// </summary>
    public enum AcceptVideoRequestResponseErrorCode
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
    public static class AcceptVideoRequestResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AcceptVideoRequestResponseErrorCode value)
        {
            return value switch
            {
                AcceptVideoRequestResponseErrorCode.Forbidden => "FORBIDDEN",
                AcceptVideoRequestResponseErrorCode.InsufficientCredits => "INSUFFICIENT_CREDITS",
                AcceptVideoRequestResponseErrorCode.InvalidInput => "INVALID_INPUT",
                AcceptVideoRequestResponseErrorCode.ServerError => "SERVER_ERROR",
                AcceptVideoRequestResponseErrorCode.ServerMaintenance => "SERVER_MAINTENANCE",
                AcceptVideoRequestResponseErrorCode.Unauthorized => "UNAUTHORIZED",
                AcceptVideoRequestResponseErrorCode.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AcceptVideoRequestResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => AcceptVideoRequestResponseErrorCode.Forbidden,
                "INSUFFICIENT_CREDITS" => AcceptVideoRequestResponseErrorCode.InsufficientCredits,
                "INVALID_INPUT" => AcceptVideoRequestResponseErrorCode.InvalidInput,
                "SERVER_ERROR" => AcceptVideoRequestResponseErrorCode.ServerError,
                "SERVER_MAINTENANCE" => AcceptVideoRequestResponseErrorCode.ServerMaintenance,
                "UNAUTHORIZED" => AcceptVideoRequestResponseErrorCode.Unauthorized,
                "UNKNOWN" => AcceptVideoRequestResponseErrorCode.Unknown,
                _ => null,
            };
        }
    }
}