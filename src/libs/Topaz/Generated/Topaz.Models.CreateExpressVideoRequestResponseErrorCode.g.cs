
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: INVALID_INPUT
    /// </summary>
    public enum CreateExpressVideoRequestResponseErrorCode
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
    public static class CreateExpressVideoRequestResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateExpressVideoRequestResponseErrorCode value)
        {
            return value switch
            {
                CreateExpressVideoRequestResponseErrorCode.Forbidden => "FORBIDDEN",
                CreateExpressVideoRequestResponseErrorCode.InsufficientCredits => "INSUFFICIENT_CREDITS",
                CreateExpressVideoRequestResponseErrorCode.InvalidInput => "INVALID_INPUT",
                CreateExpressVideoRequestResponseErrorCode.ServerError => "SERVER_ERROR",
                CreateExpressVideoRequestResponseErrorCode.ServerMaintenance => "SERVER_MAINTENANCE",
                CreateExpressVideoRequestResponseErrorCode.Unauthorized => "UNAUTHORIZED",
                CreateExpressVideoRequestResponseErrorCode.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateExpressVideoRequestResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => CreateExpressVideoRequestResponseErrorCode.Forbidden,
                "INSUFFICIENT_CREDITS" => CreateExpressVideoRequestResponseErrorCode.InsufficientCredits,
                "INVALID_INPUT" => CreateExpressVideoRequestResponseErrorCode.InvalidInput,
                "SERVER_ERROR" => CreateExpressVideoRequestResponseErrorCode.ServerError,
                "SERVER_MAINTENANCE" => CreateExpressVideoRequestResponseErrorCode.ServerMaintenance,
                "UNAUTHORIZED" => CreateExpressVideoRequestResponseErrorCode.Unauthorized,
                "UNKNOWN" => CreateExpressVideoRequestResponseErrorCode.Unknown,
                _ => null,
            };
        }
    }
}