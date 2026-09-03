#nullable enable

namespace Topaz.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetVideoRequestResponseErrorCodeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Topaz.GetVideoRequestResponseErrorCode?>
    {
        /// <inheritdoc />
        public override global::Topaz.GetVideoRequestResponseErrorCode? Read(
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
                        return global::Topaz.GetVideoRequestResponseErrorCodeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Topaz.GetVideoRequestResponseErrorCode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Topaz.GetVideoRequestResponseErrorCode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Topaz.GetVideoRequestResponseErrorCode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Topaz.GetVideoRequestResponseErrorCodeExtensions.ToValueString(value.Value));
            }
        }
    }
}
