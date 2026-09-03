
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: SERVER_MAINTENANCE
    /// </summary>
    public enum CreateVideoRequestResponseErrorCode4
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
    public static class CreateVideoRequestResponseErrorCode4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoRequestResponseErrorCode4 value)
        {
            return value switch
            {
                CreateVideoRequestResponseErrorCode4.Forbidden => "FORBIDDEN",
                CreateVideoRequestResponseErrorCode4.InsufficientCredits => "INSUFFICIENT_CREDITS",
                CreateVideoRequestResponseErrorCode4.InvalidInput => "INVALID_INPUT",
                CreateVideoRequestResponseErrorCode4.ServerError => "SERVER_ERROR",
                CreateVideoRequestResponseErrorCode4.ServerMaintenance => "SERVER_MAINTENANCE",
                CreateVideoRequestResponseErrorCode4.Unauthorized => "UNAUTHORIZED",
                CreateVideoRequestResponseErrorCode4.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoRequestResponseErrorCode4? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => CreateVideoRequestResponseErrorCode4.Forbidden,
                "INSUFFICIENT_CREDITS" => CreateVideoRequestResponseErrorCode4.InsufficientCredits,
                "INVALID_INPUT" => CreateVideoRequestResponseErrorCode4.InvalidInput,
                "SERVER_ERROR" => CreateVideoRequestResponseErrorCode4.ServerError,
                "SERVER_MAINTENANCE" => CreateVideoRequestResponseErrorCode4.ServerMaintenance,
                "UNAUTHORIZED" => CreateVideoRequestResponseErrorCode4.Unauthorized,
                "UNKNOWN" => CreateVideoRequestResponseErrorCode4.Unknown,
                _ => null,
            };
        }
    }
}