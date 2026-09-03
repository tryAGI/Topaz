
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: SERVER_ERROR
    /// </summary>
    public enum GetSystemStatusResponseErrorCode
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
    public static class GetSystemStatusResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSystemStatusResponseErrorCode value)
        {
            return value switch
            {
                GetSystemStatusResponseErrorCode.Forbidden => "FORBIDDEN",
                GetSystemStatusResponseErrorCode.InsufficientCredits => "INSUFFICIENT_CREDITS",
                GetSystemStatusResponseErrorCode.InvalidInput => "INVALID_INPUT",
                GetSystemStatusResponseErrorCode.ServerError => "SERVER_ERROR",
                GetSystemStatusResponseErrorCode.ServerMaintenance => "SERVER_MAINTENANCE",
                GetSystemStatusResponseErrorCode.Unauthorized => "UNAUTHORIZED",
                GetSystemStatusResponseErrorCode.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSystemStatusResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => GetSystemStatusResponseErrorCode.Forbidden,
                "INSUFFICIENT_CREDITS" => GetSystemStatusResponseErrorCode.InsufficientCredits,
                "INVALID_INPUT" => GetSystemStatusResponseErrorCode.InvalidInput,
                "SERVER_ERROR" => GetSystemStatusResponseErrorCode.ServerError,
                "SERVER_MAINTENANCE" => GetSystemStatusResponseErrorCode.ServerMaintenance,
                "UNAUTHORIZED" => GetSystemStatusResponseErrorCode.Unauthorized,
                "UNKNOWN" => GetSystemStatusResponseErrorCode.Unknown,
                _ => null,
            };
        }
    }
}