
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: FORBIDDEN
    /// </summary>
    public enum CompleteVideoUploadResponseErrorCode3
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
    public static class CompleteVideoUploadResponseErrorCode3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompleteVideoUploadResponseErrorCode3 value)
        {
            return value switch
            {
                CompleteVideoUploadResponseErrorCode3.Forbidden => "FORBIDDEN",
                CompleteVideoUploadResponseErrorCode3.InsufficientCredits => "INSUFFICIENT_CREDITS",
                CompleteVideoUploadResponseErrorCode3.InvalidInput => "INVALID_INPUT",
                CompleteVideoUploadResponseErrorCode3.ServerError => "SERVER_ERROR",
                CompleteVideoUploadResponseErrorCode3.ServerMaintenance => "SERVER_MAINTENANCE",
                CompleteVideoUploadResponseErrorCode3.Unauthorized => "UNAUTHORIZED",
                CompleteVideoUploadResponseErrorCode3.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompleteVideoUploadResponseErrorCode3? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => CompleteVideoUploadResponseErrorCode3.Forbidden,
                "INSUFFICIENT_CREDITS" => CompleteVideoUploadResponseErrorCode3.InsufficientCredits,
                "INVALID_INPUT" => CompleteVideoUploadResponseErrorCode3.InvalidInput,
                "SERVER_ERROR" => CompleteVideoUploadResponseErrorCode3.ServerError,
                "SERVER_MAINTENANCE" => CompleteVideoUploadResponseErrorCode3.ServerMaintenance,
                "UNAUTHORIZED" => CompleteVideoUploadResponseErrorCode3.Unauthorized,
                "UNKNOWN" => CompleteVideoUploadResponseErrorCode3.Unknown,
                _ => null,
            };
        }
    }
}