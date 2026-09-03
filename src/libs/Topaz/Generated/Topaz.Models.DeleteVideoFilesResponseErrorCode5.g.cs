
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: SERVER_ERROR
    /// </summary>
    public enum DeleteVideoFilesResponseErrorCode5
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
    public static class DeleteVideoFilesResponseErrorCode5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteVideoFilesResponseErrorCode5 value)
        {
            return value switch
            {
                DeleteVideoFilesResponseErrorCode5.Forbidden => "FORBIDDEN",
                DeleteVideoFilesResponseErrorCode5.InsufficientCredits => "INSUFFICIENT_CREDITS",
                DeleteVideoFilesResponseErrorCode5.InvalidInput => "INVALID_INPUT",
                DeleteVideoFilesResponseErrorCode5.ServerError => "SERVER_ERROR",
                DeleteVideoFilesResponseErrorCode5.ServerMaintenance => "SERVER_MAINTENANCE",
                DeleteVideoFilesResponseErrorCode5.Unauthorized => "UNAUTHORIZED",
                DeleteVideoFilesResponseErrorCode5.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteVideoFilesResponseErrorCode5? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => DeleteVideoFilesResponseErrorCode5.Forbidden,
                "INSUFFICIENT_CREDITS" => DeleteVideoFilesResponseErrorCode5.InsufficientCredits,
                "INVALID_INPUT" => DeleteVideoFilesResponseErrorCode5.InvalidInput,
                "SERVER_ERROR" => DeleteVideoFilesResponseErrorCode5.ServerError,
                "SERVER_MAINTENANCE" => DeleteVideoFilesResponseErrorCode5.ServerMaintenance,
                "UNAUTHORIZED" => DeleteVideoFilesResponseErrorCode5.Unauthorized,
                "UNKNOWN" => DeleteVideoFilesResponseErrorCode5.Unknown,
                _ => null,
            };
        }
    }
}