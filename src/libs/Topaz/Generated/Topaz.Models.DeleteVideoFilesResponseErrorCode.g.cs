
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: INVALID_INPUT
    /// </summary>
    public enum DeleteVideoFilesResponseErrorCode
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
    public static class DeleteVideoFilesResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteVideoFilesResponseErrorCode value)
        {
            return value switch
            {
                DeleteVideoFilesResponseErrorCode.Forbidden => "FORBIDDEN",
                DeleteVideoFilesResponseErrorCode.InsufficientCredits => "INSUFFICIENT_CREDITS",
                DeleteVideoFilesResponseErrorCode.InvalidInput => "INVALID_INPUT",
                DeleteVideoFilesResponseErrorCode.ServerError => "SERVER_ERROR",
                DeleteVideoFilesResponseErrorCode.ServerMaintenance => "SERVER_MAINTENANCE",
                DeleteVideoFilesResponseErrorCode.Unauthorized => "UNAUTHORIZED",
                DeleteVideoFilesResponseErrorCode.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteVideoFilesResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => DeleteVideoFilesResponseErrorCode.Forbidden,
                "INSUFFICIENT_CREDITS" => DeleteVideoFilesResponseErrorCode.InsufficientCredits,
                "INVALID_INPUT" => DeleteVideoFilesResponseErrorCode.InvalidInput,
                "SERVER_ERROR" => DeleteVideoFilesResponseErrorCode.ServerError,
                "SERVER_MAINTENANCE" => DeleteVideoFilesResponseErrorCode.ServerMaintenance,
                "UNAUTHORIZED" => DeleteVideoFilesResponseErrorCode.Unauthorized,
                "UNKNOWN" => DeleteVideoFilesResponseErrorCode.Unknown,
                _ => null,
            };
        }
    }
}