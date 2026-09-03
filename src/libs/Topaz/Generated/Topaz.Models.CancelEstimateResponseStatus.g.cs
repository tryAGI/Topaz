
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: processing
    /// </summary>
    public enum CancelEstimateResponseStatus
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
    public static class CancelEstimateResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelEstimateResponseStatus value)
        {
            return value switch
            {
                CancelEstimateResponseStatus.Accepted => "accepted",
                CancelEstimateResponseStatus.Canceled => "canceled",
                CancelEstimateResponseStatus.Canceling => "canceling",
                CancelEstimateResponseStatus.Complete => "complete",
                CancelEstimateResponseStatus.Failed => "failed",
                CancelEstimateResponseStatus.Initializing => "initializing",
                CancelEstimateResponseStatus.Postprocessing => "postprocessing",
                CancelEstimateResponseStatus.Preprocessing => "preprocessing",
                CancelEstimateResponseStatus.Processing => "processing",
                CancelEstimateResponseStatus.Requested => "requested",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelEstimateResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => CancelEstimateResponseStatus.Accepted,
                "canceled" => CancelEstimateResponseStatus.Canceled,
                "canceling" => CancelEstimateResponseStatus.Canceling,
                "complete" => CancelEstimateResponseStatus.Complete,
                "failed" => CancelEstimateResponseStatus.Failed,
                "initializing" => CancelEstimateResponseStatus.Initializing,
                "postprocessing" => CancelEstimateResponseStatus.Postprocessing,
                "preprocessing" => CancelEstimateResponseStatus.Preprocessing,
                "processing" => CancelEstimateResponseStatus.Processing,
                "requested" => CancelEstimateResponseStatus.Requested,
                _ => null,
            };
        }
    }
}