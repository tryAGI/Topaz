
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: UNAUTHORIZED
    /// </summary>
    public enum CreateExpressVideoRequestResponseErrorCode2
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
    public static class CreateExpressVideoRequestResponseErrorCode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateExpressVideoRequestResponseErrorCode2 value)
        {
            return value switch
            {
                CreateExpressVideoRequestResponseErrorCode2.Forbidden => "FORBIDDEN",
                CreateExpressVideoRequestResponseErrorCode2.InsufficientCredits => "INSUFFICIENT_CREDITS",
                CreateExpressVideoRequestResponseErrorCode2.InvalidInput => "INVALID_INPUT",
                CreateExpressVideoRequestResponseErrorCode2.ServerError => "SERVER_ERROR",
                CreateExpressVideoRequestResponseErrorCode2.ServerMaintenance => "SERVER_MAINTENANCE",
                CreateExpressVideoRequestResponseErrorCode2.Unauthorized => "UNAUTHORIZED",
                CreateExpressVideoRequestResponseErrorCode2.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateExpressVideoRequestResponseErrorCode2? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => CreateExpressVideoRequestResponseErrorCode2.Forbidden,
                "INSUFFICIENT_CREDITS" => CreateExpressVideoRequestResponseErrorCode2.InsufficientCredits,
                "INVALID_INPUT" => CreateExpressVideoRequestResponseErrorCode2.InvalidInput,
                "SERVER_ERROR" => CreateExpressVideoRequestResponseErrorCode2.ServerError,
                "SERVER_MAINTENANCE" => CreateExpressVideoRequestResponseErrorCode2.ServerMaintenance,
                "UNAUTHORIZED" => CreateExpressVideoRequestResponseErrorCode2.Unauthorized,
                "UNKNOWN" => CreateExpressVideoRequestResponseErrorCode2.Unknown,
                _ => null,
            };
        }
    }
}