
#nullable enable

namespace Topaz
{
    /// <summary>
    ///
    /// </summary>
    public enum VideoRequestRecordStatus
    {
        /// <summary>
        ///
        /// </summary>
        Accepted,
        /// <summary>
        ///
        /// </summary>
        Canceled,
        /// <summary>
        ///
        /// </summary>
        Canceling,
        /// <summary>
        ///
        /// </summary>
        Complete,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Initializing,
        /// <summary>
        ///
        /// </summary>
        Postprocessing,
        /// <summary>
        ///
        /// </summary>
        Preprocessing,
        /// <summary>
        ///
        /// </summary>
        Processing,
        /// <summary>
        ///
        /// </summary>
        Requested,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoRequestRecordStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoRequestRecordStatus value)
        {
            return value switch
            {
                VideoRequestRecordStatus.Accepted => "accepted",
                VideoRequestRecordStatus.Canceled => "canceled",
                VideoRequestRecordStatus.Canceling => "canceling",
                VideoRequestRecordStatus.Complete => "complete",
                VideoRequestRecordStatus.Failed => "failed",
                VideoRequestRecordStatus.Initializing => "initializing",
                VideoRequestRecordStatus.Postprocessing => "postprocessing",
                VideoRequestRecordStatus.Preprocessing => "preprocessing",
                VideoRequestRecordStatus.Processing => "processing",
                VideoRequestRecordStatus.Requested => "requested",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoRequestRecordStatus? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => VideoRequestRecordStatus.Accepted,
                "canceled" => VideoRequestRecordStatus.Canceled,
                "canceling" => VideoRequestRecordStatus.Canceling,
                "complete" => VideoRequestRecordStatus.Complete,
                "failed" => VideoRequestRecordStatus.Failed,
                "initializing" => VideoRequestRecordStatus.Initializing,
                "postprocessing" => VideoRequestRecordStatus.Postprocessing,
                "preprocessing" => VideoRequestRecordStatus.Preprocessing,
                "processing" => VideoRequestRecordStatus.Processing,
                "requested" => VideoRequestRecordStatus.Requested,
                _ => null,
            };
        }
    }
}