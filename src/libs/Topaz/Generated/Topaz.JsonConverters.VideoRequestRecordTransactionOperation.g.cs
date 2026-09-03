#nullable enable

namespace Topaz.JsonConverters
{
    /// <inheritdoc />
    public sealed class VideoRequestRecordTransactionOperationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Topaz.VideoRequestRecordTransactionOperation>
    {
        /// <inheritdoc />
        public override global::Topaz.VideoRequestRecordTransactionOperation Read(
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
                        return global::Topaz.VideoRequestRecordTransactionOperationExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Topaz.VideoRequestRecordTransactionOperation)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Topaz.VideoRequestRecordTransactionOperation);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Topaz.VideoRequestRecordTransactionOperation value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Topaz.VideoRequestRecordTransactionOperationExtensions.ToValueString(value));
        }
    }
}
