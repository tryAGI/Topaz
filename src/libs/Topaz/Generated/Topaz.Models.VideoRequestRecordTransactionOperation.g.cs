
#nullable enable

namespace Topaz
{
    /// <summary>
    ///
    /// </summary>
    public enum VideoRequestRecordTransactionOperation
    {
        /// <summary>
        ///
        /// </summary>
        Commit,
        /// <summary>
        ///
        /// </summary>
        Reserve,
        /// <summary>
        ///
        /// </summary>
        Rollback,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoRequestRecordTransactionOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoRequestRecordTransactionOperation value)
        {
            return value switch
            {
                VideoRequestRecordTransactionOperation.Commit => "commit",
                VideoRequestRecordTransactionOperation.Reserve => "reserve",
                VideoRequestRecordTransactionOperation.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoRequestRecordTransactionOperation? ToEnum(string value)
        {
            return value switch
            {
                "commit" => VideoRequestRecordTransactionOperation.Commit,
                "reserve" => VideoRequestRecordTransactionOperation.Reserve,
                "rollback" => VideoRequestRecordTransactionOperation.Rollback,
                _ => null,
            };
        }
    }
}