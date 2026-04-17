
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Example: processing
    /// </summary>
    public enum ProcessingStatIntermediateItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
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
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProcessingStatIntermediateItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProcessingStatIntermediateItemStatus value)
        {
            return value switch
            {
                ProcessingStatIntermediateItemStatus.Canceled => "canceled",
                ProcessingStatIntermediateItemStatus.Complete => "complete",
                ProcessingStatIntermediateItemStatus.Failed => "failed",
                ProcessingStatIntermediateItemStatus.Processing => "processing",
                ProcessingStatIntermediateItemStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProcessingStatIntermediateItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => ProcessingStatIntermediateItemStatus.Canceled,
                "complete" => ProcessingStatIntermediateItemStatus.Complete,
                "failed" => ProcessingStatIntermediateItemStatus.Failed,
                "processing" => ProcessingStatIntermediateItemStatus.Processing,
                "queued" => ProcessingStatIntermediateItemStatus.Queued,
                _ => null,
            };
        }
    }
}