
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: INVALID_INPUT
    /// </summary>
    public enum DeleteVideoFilesResponseErrorCode4
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
    public static class DeleteVideoFilesResponseErrorCode4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteVideoFilesResponseErrorCode4 value)
        {
            return value switch
            {
                DeleteVideoFilesResponseErrorCode4.Forbidden => "FORBIDDEN",
                DeleteVideoFilesResponseErrorCode4.InsufficientCredits => "INSUFFICIENT_CREDITS",
                DeleteVideoFilesResponseErrorCode4.InvalidInput => "INVALID_INPUT",
                DeleteVideoFilesResponseErrorCode4.ServerError => "SERVER_ERROR",
                DeleteVideoFilesResponseErrorCode4.ServerMaintenance => "SERVER_MAINTENANCE",
                DeleteVideoFilesResponseErrorCode4.Unauthorized => "UNAUTHORIZED",
                DeleteVideoFilesResponseErrorCode4.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteVideoFilesResponseErrorCode4? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => DeleteVideoFilesResponseErrorCode4.Forbidden,
                "INSUFFICIENT_CREDITS" => DeleteVideoFilesResponseErrorCode4.InsufficientCredits,
                "INVALID_INPUT" => DeleteVideoFilesResponseErrorCode4.InvalidInput,
                "SERVER_ERROR" => DeleteVideoFilesResponseErrorCode4.ServerError,
                "SERVER_MAINTENANCE" => DeleteVideoFilesResponseErrorCode4.ServerMaintenance,
                "UNAUTHORIZED" => DeleteVideoFilesResponseErrorCode4.Unauthorized,
                "UNKNOWN" => DeleteVideoFilesResponseErrorCode4.Unknown,
                _ => null,
            };
        }
    }
}