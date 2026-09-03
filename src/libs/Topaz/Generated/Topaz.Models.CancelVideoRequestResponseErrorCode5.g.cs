
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: SERVER_ERROR
    /// </summary>
    public enum CancelVideoRequestResponseErrorCode5
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
    public static class CancelVideoRequestResponseErrorCode5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelVideoRequestResponseErrorCode5 value)
        {
            return value switch
            {
                CancelVideoRequestResponseErrorCode5.Forbidden => "FORBIDDEN",
                CancelVideoRequestResponseErrorCode5.InsufficientCredits => "INSUFFICIENT_CREDITS",
                CancelVideoRequestResponseErrorCode5.InvalidInput => "INVALID_INPUT",
                CancelVideoRequestResponseErrorCode5.ServerError => "SERVER_ERROR",
                CancelVideoRequestResponseErrorCode5.ServerMaintenance => "SERVER_MAINTENANCE",
                CancelVideoRequestResponseErrorCode5.Unauthorized => "UNAUTHORIZED",
                CancelVideoRequestResponseErrorCode5.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelVideoRequestResponseErrorCode5? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => CancelVideoRequestResponseErrorCode5.Forbidden,
                "INSUFFICIENT_CREDITS" => CancelVideoRequestResponseErrorCode5.InsufficientCredits,
                "INVALID_INPUT" => CancelVideoRequestResponseErrorCode5.InvalidInput,
                "SERVER_ERROR" => CancelVideoRequestResponseErrorCode5.ServerError,
                "SERVER_MAINTENANCE" => CancelVideoRequestResponseErrorCode5.ServerMaintenance,
                "UNAUTHORIZED" => CancelVideoRequestResponseErrorCode5.Unauthorized,
                "UNKNOWN" => CancelVideoRequestResponseErrorCode5.Unknown,
                _ => null,
            };
        }
    }
}