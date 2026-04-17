#nullable enable

namespace Topaz.JsonConverters
{
    /// <inheritdoc />
    public sealed class ToolGANRequestOutputFormatNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Topaz.ToolGANRequestOutputFormat?>
    {
        /// <inheritdoc />
        public override global::Topaz.ToolGANRequestOutputFormat? Read(
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
                        return global::Topaz.ToolGANRequestOutputFormatExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Topaz.ToolGANRequestOutputFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Topaz.ToolGANRequestOutputFormat?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Topaz.ToolGANRequestOutputFormat? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Topaz.ToolGANRequestOutputFormatExtensions.ToValueString(value.Value));
            }
        }
    }
}
