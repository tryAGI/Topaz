
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: FORBIDDEN
    /// </summary>
    public enum GetHistoryResponseErrorCode3
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
    public static class GetHistoryResponseErrorCode3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetHistoryResponseErrorCode3 value)
        {
            return value switch
            {
                GetHistoryResponseErrorCode3.Forbidden => "FORBIDDEN",
                GetHistoryResponseErrorCode3.InsufficientCredits => "INSUFFICIENT_CREDITS",
                GetHistoryResponseErrorCode3.InvalidInput => "INVALID_INPUT",
                GetHistoryResponseErrorCode3.ServerError => "SERVER_ERROR",
                GetHistoryResponseErrorCode3.ServerMaintenance => "SERVER_MAINTENANCE",
                GetHistoryResponseErrorCode3.Unauthorized => "UNAUTHORIZED",
                GetHistoryResponseErrorCode3.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetHistoryResponseErrorCode3? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => GetHistoryResponseErrorCode3.Forbidden,
                "INSUFFICIENT_CREDITS" => GetHistoryResponseErrorCode3.InsufficientCredits,
                "INVALID_INPUT" => GetHistoryResponseErrorCode3.InvalidInput,
                "SERVER_ERROR" => GetHistoryResponseErrorCode3.ServerError,
                "SERVER_MAINTENANCE" => GetHistoryResponseErrorCode3.ServerMaintenance,
                "UNAUTHORIZED" => GetHistoryResponseErrorCode3.Unauthorized,
                "UNKNOWN" => GetHistoryResponseErrorCode3.Unknown,
                _ => null,
            };
        }
    }
}