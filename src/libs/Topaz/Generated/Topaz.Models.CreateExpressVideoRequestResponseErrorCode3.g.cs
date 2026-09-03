
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: SERVER_ERROR
    /// </summary>
    public enum CreateExpressVideoRequestResponseErrorCode3
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
    public static class CreateExpressVideoRequestResponseErrorCode3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateExpressVideoRequestResponseErrorCode3 value)
        {
            return value switch
            {
                CreateExpressVideoRequestResponseErrorCode3.Forbidden => "FORBIDDEN",
                CreateExpressVideoRequestResponseErrorCode3.InsufficientCredits => "INSUFFICIENT_CREDITS",
                CreateExpressVideoRequestResponseErrorCode3.InvalidInput => "INVALID_INPUT",
                CreateExpressVideoRequestResponseErrorCode3.ServerError => "SERVER_ERROR",
                CreateExpressVideoRequestResponseErrorCode3.ServerMaintenance => "SERVER_MAINTENANCE",
                CreateExpressVideoRequestResponseErrorCode3.Unauthorized => "UNAUTHORIZED",
                CreateExpressVideoRequestResponseErrorCode3.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateExpressVideoRequestResponseErrorCode3? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => CreateExpressVideoRequestResponseErrorCode3.Forbidden,
                "INSUFFICIENT_CREDITS" => CreateExpressVideoRequestResponseErrorCode3.InsufficientCredits,
                "INVALID_INPUT" => CreateExpressVideoRequestResponseErrorCode3.InvalidInput,
                "SERVER_ERROR" => CreateExpressVideoRequestResponseErrorCode3.ServerError,
                "SERVER_MAINTENANCE" => CreateExpressVideoRequestResponseErrorCode3.ServerMaintenance,
                "UNAUTHORIZED" => CreateExpressVideoRequestResponseErrorCode3.Unauthorized,
                "UNKNOWN" => CreateExpressVideoRequestResponseErrorCode3.Unknown,
                _ => null,
            };
        }
    }
}