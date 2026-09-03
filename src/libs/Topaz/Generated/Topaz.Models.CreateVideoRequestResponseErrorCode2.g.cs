
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: UNAUTHORIZED
    /// </summary>
    public enum CreateVideoRequestResponseErrorCode2
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
    public static class CreateVideoRequestResponseErrorCode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoRequestResponseErrorCode2 value)
        {
            return value switch
            {
                CreateVideoRequestResponseErrorCode2.Forbidden => "FORBIDDEN",
                CreateVideoRequestResponseErrorCode2.InsufficientCredits => "INSUFFICIENT_CREDITS",
                CreateVideoRequestResponseErrorCode2.InvalidInput => "INVALID_INPUT",
                CreateVideoRequestResponseErrorCode2.ServerError => "SERVER_ERROR",
                CreateVideoRequestResponseErrorCode2.ServerMaintenance => "SERVER_MAINTENANCE",
                CreateVideoRequestResponseErrorCode2.Unauthorized => "UNAUTHORIZED",
                CreateVideoRequestResponseErrorCode2.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoRequestResponseErrorCode2? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => CreateVideoRequestResponseErrorCode2.Forbidden,
                "INSUFFICIENT_CREDITS" => CreateVideoRequestResponseErrorCode2.InsufficientCredits,
                "INVALID_INPUT" => CreateVideoRequestResponseErrorCode2.InvalidInput,
                "SERVER_ERROR" => CreateVideoRequestResponseErrorCode2.ServerError,
                "SERVER_MAINTENANCE" => CreateVideoRequestResponseErrorCode2.ServerMaintenance,
                "UNAUTHORIZED" => CreateVideoRequestResponseErrorCode2.Unauthorized,
                "UNKNOWN" => CreateVideoRequestResponseErrorCode2.Unknown,
                _ => null,
            };
        }
    }
}