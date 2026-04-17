
#nullable enable

namespace Topaz
{
    /// <summary>
    /// 
    /// </summary>
    public enum HistoryResponseTransactionOperation
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
    public static class HistoryResponseTransactionOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HistoryResponseTransactionOperation value)
        {
            return value switch
            {
                HistoryResponseTransactionOperation.Commit => "commit",
                HistoryResponseTransactionOperation.Reserve => "reserve",
                HistoryResponseTransactionOperation.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HistoryResponseTransactionOperation? ToEnum(string value)
        {
            return value switch
            {
                "commit" => HistoryResponseTransactionOperation.Commit,
                "reserve" => HistoryResponseTransactionOperation.Reserve,
                "rollback" => HistoryResponseTransactionOperation.Rollback,
                _ => null,
            };
        }
    }
}