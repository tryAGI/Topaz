
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: UNAUTHORIZED
    /// </summary>
    public enum DeleteVideoFilesResponseErrorCode2
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
    public static class DeleteVideoFilesResponseErrorCode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteVideoFilesResponseErrorCode2 value)
        {
            return value switch
            {
                DeleteVideoFilesResponseErrorCode2.Forbidden => "FORBIDDEN",
                DeleteVideoFilesResponseErrorCode2.InsufficientCredits => "INSUFFICIENT_CREDITS",
                DeleteVideoFilesResponseErrorCode2.InvalidInput => "INVALID_INPUT",
                DeleteVideoFilesResponseErrorCode2.ServerError => "SERVER_ERROR",
                DeleteVideoFilesResponseErrorCode2.ServerMaintenance => "SERVER_MAINTENANCE",
                DeleteVideoFilesResponseErrorCode2.Unauthorized => "UNAUTHORIZED",
                DeleteVideoFilesResponseErrorCode2.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteVideoFilesResponseErrorCode2? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => DeleteVideoFilesResponseErrorCode2.Forbidden,
                "INSUFFICIENT_CREDITS" => DeleteVideoFilesResponseErrorCode2.InsufficientCredits,
                "INVALID_INPUT" => DeleteVideoFilesResponseErrorCode2.InvalidInput,
                "SERVER_ERROR" => DeleteVideoFilesResponseErrorCode2.ServerError,
                "SERVER_MAINTENANCE" => DeleteVideoFilesResponseErrorCode2.ServerMaintenance,
                "UNAUTHORIZED" => DeleteVideoFilesResponseErrorCode2.Unauthorized,
                "UNKNOWN" => DeleteVideoFilesResponseErrorCode2.Unknown,
                _ => null,
            };
        }
    }
}