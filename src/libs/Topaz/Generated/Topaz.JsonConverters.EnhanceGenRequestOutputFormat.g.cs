#nullable enable

namespace Topaz.JsonConverters
{
    /// <inheritdoc />
    public sealed class EnhanceGenRequestOutputFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Topaz.EnhanceGenRequestOutputFormat>
    {
        /// <inheritdoc />
        public override global::Topaz.EnhanceGenRequestOutputFormat Read(
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
                        return global::Topaz.EnhanceGenRequestOutputFormatExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Topaz.EnhanceGenRequestOutputFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Topaz.EnhanceGenRequestOutputFormat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Topaz.EnhanceGenRequestOutputFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Topaz.EnhanceGenRequestOutputFormatExtensions.ToValueString(value));
        }
    }
}
