
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public enum HistoryResponseStatus
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
    public static class HistoryResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HistoryResponseStatus value)
        {
            return value switch
            {
                HistoryResponseStatus.Accepted => "accepted",
                HistoryResponseStatus.Canceled => "canceled",
                HistoryResponseStatus.Canceling => "canceling",
                HistoryResponseStatus.Complete => "complete",
                HistoryResponseStatus.Failed => "failed",
                HistoryResponseStatus.Initializing => "initializing",
                HistoryResponseStatus.Postprocessing => "postprocessing",
                HistoryResponseStatus.Preprocessing => "preprocessing",
                HistoryResponseStatus.Processing => "processing",
                HistoryResponseStatus.Requested => "requested",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HistoryResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => HistoryResponseStatus.Accepted,
                "canceled" => HistoryResponseStatus.Canceled,
                "canceling" => HistoryResponseStatus.Canceling,
                "complete" => HistoryResponseStatus.Complete,
                "failed" => HistoryResponseStatus.Failed,
                "initializing" => HistoryResponseStatus.Initializing,
                "postprocessing" => HistoryResponseStatus.Postprocessing,
                "preprocessing" => HistoryResponseStatus.Preprocessing,
                "processing" => HistoryResponseStatus.Processing,
                "requested" => HistoryResponseStatus.Requested,
                _ => null,
            };
        }
    }
}