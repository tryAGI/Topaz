#nullable enable

namespace Topaz.JsonConverters
{
    /// <inheritdoc />
    public sealed class OutputInformationVideoContainerNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Topaz.OutputInformationVideoContainer?>
    {
        /// <inheritdoc />
        public override global::Topaz.OutputInformationVideoContainer? Read(
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
                        return global::Topaz.OutputInformationVideoContainerExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Topaz.OutputInformationVideoContainer)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Topaz.OutputInformationVideoContainer?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Topaz.OutputInformationVideoContainer? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Topaz.OutputInformationVideoContainerExtensions.ToValueString(value.Value));
            }
        }
    }
}
