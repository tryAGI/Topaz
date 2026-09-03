
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: INVALID_INPUT
    /// </summary>
    public enum GetHistoryResponseErrorCode
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
    public static class GetHistoryResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetHistoryResponseErrorCode value)
        {
            return value switch
            {
                GetHistoryResponseErrorCode.Forbidden => "FORBIDDEN",
                GetHistoryResponseErrorCode.InsufficientCredits => "INSUFFICIENT_CREDITS",
                GetHistoryResponseErrorCode.InvalidInput => "INVALID_INPUT",
                GetHistoryResponseErrorCode.ServerError => "SERVER_ERROR",
                GetHistoryResponseErrorCode.ServerMaintenance => "SERVER_MAINTENANCE",
                GetHistoryResponseErrorCode.Unauthorized => "UNAUTHORIZED",
                GetHistoryResponseErrorCode.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetHistoryResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => GetHistoryResponseErrorCode.Forbidden,
                "INSUFFICIENT_CREDITS" => GetHistoryResponseErrorCode.InsufficientCredits,
                "INVALID_INPUT" => GetHistoryResponseErrorCode.InvalidInput,
                "SERVER_ERROR" => GetHistoryResponseErrorCode.ServerError,
                "SERVER_MAINTENANCE" => GetHistoryResponseErrorCode.ServerMaintenance,
                "UNAUTHORIZED" => GetHistoryResponseErrorCode.Unauthorized,
                "UNKNOWN" => GetHistoryResponseErrorCode.Unknown,
                _ => null,
            };
        }
    }
}