#nullable enable

namespace Topaz.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateVideoRequestRequestSourceContainerNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Topaz.CreateVideoRequestRequestSourceContainer?>
    {
        /// <inheritdoc />
        public override global::Topaz.CreateVideoRequestRequestSourceContainer? Read(
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
                        return global::Topaz.CreateVideoRequestRequestSourceContainerExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Topaz.CreateVideoRequestRequestSourceContainer)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Topaz.CreateVideoRequestRequestSourceContainer?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Topaz.CreateVideoRequestRequestSourceContainer? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Topaz.CreateVideoRequestRequestSourceContainerExtensions.ToValueString(value.Value));
            }
        }
    }
}
