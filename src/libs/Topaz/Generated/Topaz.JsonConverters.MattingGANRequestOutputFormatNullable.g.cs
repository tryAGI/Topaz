#nullable enable

namespace Topaz.JsonConverters
{
    /// <inheritdoc />
    public sealed class MattingGANRequestOutputFormatNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Topaz.MattingGANRequestOutputFormat?>
    {
        /// <inheritdoc />
        public override global::Topaz.MattingGANRequestOutputFormat? Read(
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
                        return global::Topaz.MattingGANRequestOutputFormatExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Topaz.MattingGANRequestOutputFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Topaz.MattingGANRequestOutputFormat?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Topaz.MattingGANRequestOutputFormat? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Topaz.MattingGANRequestOutputFormatExtensions.ToValueString(value.Value));
            }
        }
    }
}
