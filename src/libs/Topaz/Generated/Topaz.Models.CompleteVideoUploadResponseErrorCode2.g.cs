
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: UNAUTHORIZED
    /// </summary>
    public enum CompleteVideoUploadResponseErrorCode2
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
    public static class CompleteVideoUploadResponseErrorCode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompleteVideoUploadResponseErrorCode2 value)
        {
            return value switch
            {
                CompleteVideoUploadResponseErrorCode2.Forbidden => "FORBIDDEN",
                CompleteVideoUploadResponseErrorCode2.InsufficientCredits => "INSUFFICIENT_CREDITS",
                CompleteVideoUploadResponseErrorCode2.InvalidInput => "INVALID_INPUT",
                CompleteVideoUploadResponseErrorCode2.ServerError => "SERVER_ERROR",
                CompleteVideoUploadResponseErrorCode2.ServerMaintenance => "SERVER_MAINTENANCE",
                CompleteVideoUploadResponseErrorCode2.Unauthorized => "UNAUTHORIZED",
                CompleteVideoUploadResponseErrorCode2.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompleteVideoUploadResponseErrorCode2? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => CompleteVideoUploadResponseErrorCode2.Forbidden,
                "INSUFFICIENT_CREDITS" => CompleteVideoUploadResponseErrorCode2.InsufficientCredits,
                "INVALID_INPUT" => CompleteVideoUploadResponseErrorCode2.InvalidInput,
                "SERVER_ERROR" => CompleteVideoUploadResponseErrorCode2.ServerError,
                "SERVER_MAINTENANCE" => CompleteVideoUploadResponseErrorCode2.ServerMaintenance,
                "UNAUTHORIZED" => CompleteVideoUploadResponseErrorCode2.Unauthorized,
                "UNKNOWN" => CompleteVideoUploadResponseErrorCode2.Unknown,
                _ => null,
            };
        }
    }
}