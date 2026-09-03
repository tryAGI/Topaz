
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: UNAUTHORIZED
    /// </summary>
    public enum GetHistoryResponseErrorCode2
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
    public static class GetHistoryResponseErrorCode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetHistoryResponseErrorCode2 value)
        {
            return value switch
            {
                GetHistoryResponseErrorCode2.Forbidden => "FORBIDDEN",
                GetHistoryResponseErrorCode2.InsufficientCredits => "INSUFFICIENT_CREDITS",
                GetHistoryResponseErrorCode2.InvalidInput => "INVALID_INPUT",
                GetHistoryResponseErrorCode2.ServerError => "SERVER_ERROR",
                GetHistoryResponseErrorCode2.ServerMaintenance => "SERVER_MAINTENANCE",
                GetHistoryResponseErrorCode2.Unauthorized => "UNAUTHORIZED",
                GetHistoryResponseErrorCode2.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetHistoryResponseErrorCode2? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => GetHistoryResponseErrorCode2.Forbidden,
                "INSUFFICIENT_CREDITS" => GetHistoryResponseErrorCode2.InsufficientCredits,
                "INVALID_INPUT" => GetHistoryResponseErrorCode2.InvalidInput,
                "SERVER_ERROR" => GetHistoryResponseErrorCode2.ServerError,
                "SERVER_MAINTENANCE" => GetHistoryResponseErrorCode2.ServerMaintenance,
                "UNAUTHORIZED" => GetHistoryResponseErrorCode2.Unauthorized,
                "UNKNOWN" => GetHistoryResponseErrorCode2.Unknown,
                _ => null,
            };
        }
    }
}