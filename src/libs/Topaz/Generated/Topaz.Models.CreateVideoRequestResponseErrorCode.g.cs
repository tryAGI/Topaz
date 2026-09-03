
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: INVALID_INPUT
    /// </summary>
    public enum CreateVideoRequestResponseErrorCode
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
    public static class CreateVideoRequestResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoRequestResponseErrorCode value)
        {
            return value switch
            {
                CreateVideoRequestResponseErrorCode.Forbidden => "FORBIDDEN",
                CreateVideoRequestResponseErrorCode.InsufficientCredits => "INSUFFICIENT_CREDITS",
                CreateVideoRequestResponseErrorCode.InvalidInput => "INVALID_INPUT",
                CreateVideoRequestResponseErrorCode.ServerError => "SERVER_ERROR",
                CreateVideoRequestResponseErrorCode.ServerMaintenance => "SERVER_MAINTENANCE",
                CreateVideoRequestResponseErrorCode.Unauthorized => "UNAUTHORIZED",
                CreateVideoRequestResponseErrorCode.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoRequestResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => CreateVideoRequestResponseErrorCode.Forbidden,
                "INSUFFICIENT_CREDITS" => CreateVideoRequestResponseErrorCode.InsufficientCredits,
                "INVALID_INPUT" => CreateVideoRequestResponseErrorCode.InvalidInput,
                "SERVER_ERROR" => CreateVideoRequestResponseErrorCode.ServerError,
                "SERVER_MAINTENANCE" => CreateVideoRequestResponseErrorCode.ServerMaintenance,
                "UNAUTHORIZED" => CreateVideoRequestResponseErrorCode.Unauthorized,
                "UNKNOWN" => CreateVideoRequestResponseErrorCode.Unknown,
                _ => null,
            };
        }
    }
}