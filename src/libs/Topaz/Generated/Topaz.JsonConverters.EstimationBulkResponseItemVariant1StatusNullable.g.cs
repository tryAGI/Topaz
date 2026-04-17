#nullable enable

namespace Topaz.JsonConverters
{
    /// <inheritdoc />
    public sealed class EstimationBulkResponseItemVariant1StatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Topaz.EstimationBulkResponseItemVariant1Status?>
    {
        /// <inheritdoc />
        public override global::Topaz.EstimationBulkResponseItemVariant1Status? Read(
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
                        return global::Topaz.EstimationBulkResponseItemVariant1StatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Topaz.EstimationBulkResponseItemVariant1Status)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Topaz.EstimationBulkResponseItemVariant1Status?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Topaz.EstimationBulkResponseItemVariant1Status? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Topaz.EstimationBulkResponseItemVariant1StatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
