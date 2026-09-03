
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: INVALID_INPUT
    /// </summary>
    public enum CompleteVideoUploadResponseErrorCode
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
    public static class CompleteVideoUploadResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompleteVideoUploadResponseErrorCode value)
        {
            return value switch
            {
                CompleteVideoUploadResponseErrorCode.Forbidden => "FORBIDDEN",
                CompleteVideoUploadResponseErrorCode.InsufficientCredits => "INSUFFICIENT_CREDITS",
                CompleteVideoUploadResponseErrorCode.InvalidInput => "INVALID_INPUT",
                CompleteVideoUploadResponseErrorCode.ServerError => "SERVER_ERROR",
                CompleteVideoUploadResponseErrorCode.ServerMaintenance => "SERVER_MAINTENANCE",
                CompleteVideoUploadResponseErrorCode.Unauthorized => "UNAUTHORIZED",
                CompleteVideoUploadResponseErrorCode.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompleteVideoUploadResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "FORBIDDEN" => CompleteVideoUploadResponseErrorCode.Forbidden,
                "INSUFFICIENT_CREDITS" => CompleteVideoUploadResponseErrorCode.InsufficientCredits,
                "INVALID_INPUT" => CompleteVideoUploadResponseErrorCode.InvalidInput,
                "SERVER_ERROR" => CompleteVideoUploadResponseErrorCode.ServerError,
                "SERVER_MAINTENANCE" => CompleteVideoUploadResponseErrorCode.ServerMaintenance,
                "UNAUTHORIZED" => CompleteVideoUploadResponseErrorCode.Unauthorized,
                "UNKNOWN" => CompleteVideoUploadResponseErrorCode.Unknown,
                _ => null,
            };
        }
    }
}