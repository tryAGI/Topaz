
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: processing
    /// </summary>
    public enum VideoStatusResponseStatus
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
    public static class VideoStatusResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoStatusResponseStatus value)
        {
            return value switch
            {
                VideoStatusResponseStatus.Accepted => "accepted",
                VideoStatusResponseStatus.Canceled => "canceled",
                VideoStatusResponseStatus.Canceling => "canceling",
                VideoStatusResponseStatus.Complete => "complete",
                VideoStatusResponseStatus.Failed => "failed",
                VideoStatusResponseStatus.Initializing => "initializing",
                VideoStatusResponseStatus.Postprocessing => "postprocessing",
                VideoStatusResponseStatus.Preprocessing => "preprocessing",
                VideoStatusResponseStatus.Processing => "processing",
                VideoStatusResponseStatus.Requested => "requested",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoStatusResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => VideoStatusResponseStatus.Accepted,
                "canceled" => VideoStatusResponseStatus.Canceled,
                "canceling" => VideoStatusResponseStatus.Canceling,
                "complete" => VideoStatusResponseStatus.Complete,
                "failed" => VideoStatusResponseStatus.Failed,
                "initializing" => VideoStatusResponseStatus.Initializing,
                "postprocessing" => VideoStatusResponseStatus.Postprocessing,
                "preprocessing" => VideoStatusResponseStatus.Preprocessing,
                "processing" => VideoStatusResponseStatus.Processing,
                "requested" => VideoStatusResponseStatus.Requested,
                _ => null,
            };
        }
    }
}