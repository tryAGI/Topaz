
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: SERVER_ERROR
    /// </summary>
    public enum CompleteVideoUploadResponseErrorCode5
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
    public static class CompleteVideoUploadResponseErrorCode5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompleteVideoUploadResponseErrorCode5 value)
        {
            return value switch
            {
                CompleteVideoUploadResponseErrorCode5.Forbidden => "FORBIDDEN",
                CompleteVideoUploadResponseErrorCode5.InsufficientCredits => "INSUFFICIENT_CREDITS",
                CompleteVideoUploadResponseErrorCode5.InvalidInput => "INVALID_INPUT",
                CompleteVideoUploadResponseErrorCode5.ServerError => "SERVER_ERROR",
                CompleteVideoUploadResponseErrorCode5.ServerMaintenance => "SERVER_MAINTENANCE",
                CompleteVideoUploadResponseErrorCode5.Unauthorized => "UNAUTHORIZED",
                CompleteVideoUploadResponseErrorCode5.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompleteVideoUploadResponseErrorCode5? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => CompleteVideoUploadResponseErrorCode5.Forbidden,
                "INSUFFICIENT_CREDITS" => CompleteVideoUploadResponseErrorCode5.InsufficientCredits,
                "INVALID_INPUT" => CompleteVideoUploadResponseErrorCode5.InvalidInput,
                "SERVER_ERROR" => CompleteVideoUploadResponseErrorCode5.ServerError,
                "SERVER_MAINTENANCE" => CompleteVideoUploadResponseErrorCode5.ServerMaintenance,
                "UNAUTHORIZED" => CompleteVideoUploadResponseErrorCode5.Unauthorized,
                "UNKNOWN" => CompleteVideoUploadResponseErrorCode5.Unknown,
                _ => null,
            };
        }
    }
}