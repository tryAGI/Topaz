#nullable enable

namespace Topaz.JsonConverters
{
    /// <inheritdoc />
    public sealed class HistoryResponseTransactionOperationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Topaz.HistoryResponseTransactionOperation>
    {
        /// <inheritdoc />
        public override global::Topaz.HistoryResponseTransactionOperation Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Topaz.HistoryResponseTransactionOperationExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Topaz.HistoryResponseTransactionOperation)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Topaz.HistoryResponseTransactionOperation);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Topaz.HistoryResponseTransactionOperation value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Topaz.HistoryResponseTransactionOperationExtensions.ToValueString(value));
        }
    }
}
