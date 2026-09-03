
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: INVALID_INPUT
    /// </summary>
    public enum CancelVideoRequestResponseErrorCode4
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
    public static class CancelVideoRequestResponseErrorCode4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelVideoRequestResponseErrorCode4 value)
        {
            return value switch
            {
                CancelVideoRequestResponseErrorCode4.Forbidden => "FORBIDDEN",
                CancelVideoRequestResponseErrorCode4.InsufficientCredits => "INSUFFICIENT_CREDITS",
                CancelVideoRequestResponseErrorCode4.InvalidInput => "INVALID_INPUT",
                CancelVideoRequestResponseErrorCode4.ServerError => "SERVER_ERROR",
                CancelVideoRequestResponseErrorCode4.ServerMaintenance => "SERVER_MAINTENANCE",
                CancelVideoRequestResponseErrorCode4.Unauthorized => "UNAUTHORIZED",
                CancelVideoRequestResponseErrorCode4.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelVideoRequestResponseErrorCode4? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => CancelVideoRequestResponseErrorCode4.Forbidden,
                "INSUFFICIENT_CREDITS" => CancelVideoRequestResponseErrorCode4.InsufficientCredits,
                "INVALID_INPUT" => CancelVideoRequestResponseErrorCode4.InvalidInput,
                "SERVER_ERROR" => CancelVideoRequestResponseErrorCode4.ServerError,
                "SERVER_MAINTENANCE" => CancelVideoRequestResponseErrorCode4.ServerMaintenance,
                "UNAUTHORIZED" => CancelVideoRequestResponseErrorCode4.Unauthorized,
                "UNKNOWN" => CancelVideoRequestResponseErrorCode4.Unknown,
                _ => null,
            };
        }
    }
}