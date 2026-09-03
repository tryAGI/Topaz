
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: SERVER_MAINTENANCE
    /// </summary>
    public enum CreateExpressVideoRequestResponseErrorCode4
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
    public static class CreateExpressVideoRequestResponseErrorCode4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateExpressVideoRequestResponseErrorCode4 value)
        {
            return value switch
            {
                CreateExpressVideoRequestResponseErrorCode4.Forbidden => "FORBIDDEN",
                CreateExpressVideoRequestResponseErrorCode4.InsufficientCredits => "INSUFFICIENT_CREDITS",
                CreateExpressVideoRequestResponseErrorCode4.InvalidInput => "INVALID_INPUT",
                CreateExpressVideoRequestResponseErrorCode4.ServerError => "SERVER_ERROR",
                CreateExpressVideoRequestResponseErrorCode4.ServerMaintenance => "SERVER_MAINTENANCE",
                CreateExpressVideoRequestResponseErrorCode4.Unauthorized => "UNAUTHORIZED",
                CreateExpressVideoRequestResponseErrorCode4.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateExpressVideoRequestResponseErrorCode4? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => CreateExpressVideoRequestResponseErrorCode4.Forbidden,
                "INSUFFICIENT_CREDITS" => CreateExpressVideoRequestResponseErrorCode4.InsufficientCredits,
                "INVALID_INPUT" => CreateExpressVideoRequestResponseErrorCode4.InvalidInput,
                "SERVER_ERROR" => CreateExpressVideoRequestResponseErrorCode4.ServerError,
                "SERVER_MAINTENANCE" => CreateExpressVideoRequestResponseErrorCode4.ServerMaintenance,
                "UNAUTHORIZED" => CreateExpressVideoRequestResponseErrorCode4.Unauthorized,
                "UNKNOWN" => CreateExpressVideoRequestResponseErrorCode4.Unknown,
                _ => null,
            };
        }
    }
}