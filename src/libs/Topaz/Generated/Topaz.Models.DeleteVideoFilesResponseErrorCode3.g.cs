
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: FORBIDDEN
    /// </summary>
    public enum DeleteVideoFilesResponseErrorCode3
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
    public static class DeleteVideoFilesResponseErrorCode3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteVideoFilesResponseErrorCode3 value)
        {
            return value switch
            {
                DeleteVideoFilesResponseErrorCode3.Forbidden => "FORBIDDEN",
                DeleteVideoFilesResponseErrorCode3.InsufficientCredits => "INSUFFICIENT_CREDITS",
                DeleteVideoFilesResponseErrorCode3.InvalidInput => "INVALID_INPUT",
                DeleteVideoFilesResponseErrorCode3.ServerError => "SERVER_ERROR",
                DeleteVideoFilesResponseErrorCode3.ServerMaintenance => "SERVER_MAINTENANCE",
                DeleteVideoFilesResponseErrorCode3.Unauthorized => "UNAUTHORIZED",
                DeleteVideoFilesResponseErrorCode3.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteVideoFilesResponseErrorCode3? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => DeleteVideoFilesResponseErrorCode3.Forbidden,
                "INSUFFICIENT_CREDITS" => DeleteVideoFilesResponseErrorCode3.InsufficientCredits,
                "INVALID_INPUT" => DeleteVideoFilesResponseErrorCode3.InvalidInput,
                "SERVER_ERROR" => DeleteVideoFilesResponseErrorCode3.ServerError,
                "SERVER_MAINTENANCE" => DeleteVideoFilesResponseErrorCode3.ServerMaintenance,
                "UNAUTHORIZED" => DeleteVideoFilesResponseErrorCode3.Unauthorized,
                "UNKNOWN" => DeleteVideoFilesResponseErrorCode3.Unknown,
                _ => null,
            };
        }
    }
}