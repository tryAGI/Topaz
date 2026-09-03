
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: SERVER_ERROR
    /// </summary>
    public enum GetHistoryResponseErrorCode4
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
    public static class GetHistoryResponseErrorCode4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetHistoryResponseErrorCode4 value)
        {
            return value switch
            {
                GetHistoryResponseErrorCode4.Forbidden => "FORBIDDEN",
                GetHistoryResponseErrorCode4.InsufficientCredits => "INSUFFICIENT_CREDITS",
                GetHistoryResponseErrorCode4.InvalidInput => "INVALID_INPUT",
                GetHistoryResponseErrorCode4.ServerError => "SERVER_ERROR",
                GetHistoryResponseErrorCode4.ServerMaintenance => "SERVER_MAINTENANCE",
                GetHistoryResponseErrorCode4.Unauthorized => "UNAUTHORIZED",
                GetHistoryResponseErrorCode4.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetHistoryResponseErrorCode4? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => GetHistoryResponseErrorCode4.Forbidden,
                "INSUFFICIENT_CREDITS" => GetHistoryResponseErrorCode4.InsufficientCredits,
                "INVALID_INPUT" => GetHistoryResponseErrorCode4.InvalidInput,
                "SERVER_ERROR" => GetHistoryResponseErrorCode4.ServerError,
                "SERVER_MAINTENANCE" => GetHistoryResponseErrorCode4.ServerMaintenance,
                "UNAUTHORIZED" => GetHistoryResponseErrorCode4.Unauthorized,
                "UNKNOWN" => GetHistoryResponseErrorCode4.Unknown,
                _ => null,
            };
        }
    }
}