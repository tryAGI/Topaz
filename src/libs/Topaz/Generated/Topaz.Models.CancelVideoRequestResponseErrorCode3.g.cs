
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: FORBIDDEN
    /// </summary>
    public enum CancelVideoRequestResponseErrorCode3
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
    public static class CancelVideoRequestResponseErrorCode3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelVideoRequestResponseErrorCode3 value)
        {
            return value switch
            {
                CancelVideoRequestResponseErrorCode3.Forbidden => "FORBIDDEN",
                CancelVideoRequestResponseErrorCode3.InsufficientCredits => "INSUFFICIENT_CREDITS",
                CancelVideoRequestResponseErrorCode3.InvalidInput => "INVALID_INPUT",
                CancelVideoRequestResponseErrorCode3.ServerError => "SERVER_ERROR",
                CancelVideoRequestResponseErrorCode3.ServerMaintenance => "SERVER_MAINTENANCE",
                CancelVideoRequestResponseErrorCode3.Unauthorized => "UNAUTHORIZED",
                CancelVideoRequestResponseErrorCode3.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelVideoRequestResponseErrorCode3? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => CancelVideoRequestResponseErrorCode3.Forbidden,
                "INSUFFICIENT_CREDITS" => CancelVideoRequestResponseErrorCode3.InsufficientCredits,
                "INVALID_INPUT" => CancelVideoRequestResponseErrorCode3.InvalidInput,
                "SERVER_ERROR" => CancelVideoRequestResponseErrorCode3.ServerError,
                "SERVER_MAINTENANCE" => CancelVideoRequestResponseErrorCode3.ServerMaintenance,
                "UNAUTHORIZED" => CancelVideoRequestResponseErrorCode3.Unauthorized,
                "UNKNOWN" => CancelVideoRequestResponseErrorCode3.Unknown,
                _ => null,
            };
        }
    }
}