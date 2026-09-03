
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: INVALID_INPUT
    /// </summary>
    public enum CancelVideoRequestResponseErrorCode
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
    public static class CancelVideoRequestResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelVideoRequestResponseErrorCode value)
        {
            return value switch
            {
                CancelVideoRequestResponseErrorCode.Forbidden => "FORBIDDEN",
                CancelVideoRequestResponseErrorCode.InsufficientCredits => "INSUFFICIENT_CREDITS",
                CancelVideoRequestResponseErrorCode.InvalidInput => "INVALID_INPUT",
                CancelVideoRequestResponseErrorCode.ServerError => "SERVER_ERROR",
                CancelVideoRequestResponseErrorCode.ServerMaintenance => "SERVER_MAINTENANCE",
                CancelVideoRequestResponseErrorCode.Unauthorized => "UNAUTHORIZED",
                CancelVideoRequestResponseErrorCode.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelVideoRequestResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => CancelVideoRequestResponseErrorCode.Forbidden,
                "INSUFFICIENT_CREDITS" => CancelVideoRequestResponseErrorCode.InsufficientCredits,
                "INVALID_INPUT" => CancelVideoRequestResponseErrorCode.InvalidInput,
                "SERVER_ERROR" => CancelVideoRequestResponseErrorCode.ServerError,
                "SERVER_MAINTENANCE" => CancelVideoRequestResponseErrorCode.ServerMaintenance,
                "UNAUTHORIZED" => CancelVideoRequestResponseErrorCode.Unauthorized,
                "UNKNOWN" => CancelVideoRequestResponseErrorCode.Unknown,
                _ => null,
            };
        }
    }
}