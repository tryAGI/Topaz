
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: SERVER_ERROR
    /// </summary>
    public enum CreateVideoRequestResponseErrorCode3
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
    public static class CreateVideoRequestResponseErrorCode3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoRequestResponseErrorCode3 value)
        {
            return value switch
            {
                CreateVideoRequestResponseErrorCode3.Forbidden => "FORBIDDEN",
                CreateVideoRequestResponseErrorCode3.InsufficientCredits => "INSUFFICIENT_CREDITS",
                CreateVideoRequestResponseErrorCode3.InvalidInput => "INVALID_INPUT",
                CreateVideoRequestResponseErrorCode3.ServerError => "SERVER_ERROR",
                CreateVideoRequestResponseErrorCode3.ServerMaintenance => "SERVER_MAINTENANCE",
                CreateVideoRequestResponseErrorCode3.Unauthorized => "UNAUTHORIZED",
                CreateVideoRequestResponseErrorCode3.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoRequestResponseErrorCode3? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => CreateVideoRequestResponseErrorCode3.Forbidden,
                "INSUFFICIENT_CREDITS" => CreateVideoRequestResponseErrorCode3.InsufficientCredits,
                "INVALID_INPUT" => CreateVideoRequestResponseErrorCode3.InvalidInput,
                "SERVER_ERROR" => CreateVideoRequestResponseErrorCode3.ServerError,
                "SERVER_MAINTENANCE" => CreateVideoRequestResponseErrorCode3.ServerMaintenance,
                "UNAUTHORIZED" => CreateVideoRequestResponseErrorCode3.Unauthorized,
                "UNKNOWN" => CreateVideoRequestResponseErrorCode3.Unknown,
                _ => null,
            };
        }
    }
}