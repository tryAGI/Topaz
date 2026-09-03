
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: UNAUTHORIZED
    /// </summary>
    public enum CancelVideoRequestResponseErrorCode2
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
    public static class CancelVideoRequestResponseErrorCode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelVideoRequestResponseErrorCode2 value)
        {
            return value switch
            {
                CancelVideoRequestResponseErrorCode2.Forbidden => "FORBIDDEN",
                CancelVideoRequestResponseErrorCode2.InsufficientCredits => "INSUFFICIENT_CREDITS",
                CancelVideoRequestResponseErrorCode2.InvalidInput => "INVALID_INPUT",
                CancelVideoRequestResponseErrorCode2.ServerError => "SERVER_ERROR",
                CancelVideoRequestResponseErrorCode2.ServerMaintenance => "SERVER_MAINTENANCE",
                CancelVideoRequestResponseErrorCode2.Unauthorized => "UNAUTHORIZED",
                CancelVideoRequestResponseErrorCode2.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelVideoRequestResponseErrorCode2? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => CancelVideoRequestResponseErrorCode2.Forbidden,
                "INSUFFICIENT_CREDITS" => CancelVideoRequestResponseErrorCode2.InsufficientCredits,
                "INVALID_INPUT" => CancelVideoRequestResponseErrorCode2.InvalidInput,
                "SERVER_ERROR" => CancelVideoRequestResponseErrorCode2.ServerError,
                "SERVER_MAINTENANCE" => CancelVideoRequestResponseErrorCode2.ServerMaintenance,
                "UNAUTHORIZED" => CancelVideoRequestResponseErrorCode2.Unauthorized,
                "UNKNOWN" => CancelVideoRequestResponseErrorCode2.Unknown,
                _ => null,
            };
        }
    }
}