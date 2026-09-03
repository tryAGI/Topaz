
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: INVALID_INPUT
    /// </summary>
    public enum CompleteVideoUploadResponseErrorCode4
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
    public static class CompleteVideoUploadResponseErrorCode4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompleteVideoUploadResponseErrorCode4 value)
        {
            return value switch
            {
                CompleteVideoUploadResponseErrorCode4.Forbidden => "FORBIDDEN",
                CompleteVideoUploadResponseErrorCode4.InsufficientCredits => "INSUFFICIENT_CREDITS",
                CompleteVideoUploadResponseErrorCode4.InvalidInput => "INVALID_INPUT",
                CompleteVideoUploadResponseErrorCode4.ServerError => "SERVER_ERROR",
                CompleteVideoUploadResponseErrorCode4.ServerMaintenance => "SERVER_MAINTENANCE",
                CompleteVideoUploadResponseErrorCode4.Unauthorized => "UNAUTHORIZED",
                CompleteVideoUploadResponseErrorCode4.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompleteVideoUploadResponseErrorCode4? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => CompleteVideoUploadResponseErrorCode4.Forbidden,
                "INSUFFICIENT_CREDITS" => CompleteVideoUploadResponseErrorCode4.InsufficientCredits,
                "INVALID_INPUT" => CompleteVideoUploadResponseErrorCode4.InvalidInput,
                "SERVER_ERROR" => CompleteVideoUploadResponseErrorCode4.ServerError,
                "SERVER_MAINTENANCE" => CompleteVideoUploadResponseErrorCode4.ServerMaintenance,
                "UNAUTHORIZED" => CompleteVideoUploadResponseErrorCode4.Unauthorized,
                "UNKNOWN" => CompleteVideoUploadResponseErrorCode4.Unknown,
                _ => null,
            };
        }
    }
}