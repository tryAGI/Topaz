
#nullable enable

namespace Topaz
{
    /// <summary>
    /// Status of the job.
    /// </summary>
    public enum StatusResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StatusResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StatusResponseStatus value)
        {
            return value switch
            {
                StatusResponseStatus.Cancelled => "Cancelled",
                StatusResponseStatus.Completed => "Completed",
                StatusResponseStatus.Failed => "Failed",
                StatusResponseStatus.Pending => "Pending",
                StatusResponseStatus.Processing => "Processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StatusResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "Cancelled" => StatusResponseStatus.Cancelled,
                "Completed" => StatusResponseStatus.Completed,
                "Failed" => StatusResponseStatus.Failed,
                "Pending" => StatusResponseStatus.Pending,
                "Processing" => StatusResponseStatus.Processing,
                _ => null,
            };
        }
    }
}