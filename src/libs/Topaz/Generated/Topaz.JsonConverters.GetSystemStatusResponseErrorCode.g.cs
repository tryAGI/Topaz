#nullable enable

namespace Topaz.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetSystemStatusResponseErrorCodeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Topaz.GetSystemStatusResponseErrorCode>
    {
        /// <inheritdoc />
        public override global::Topaz.GetSystemStatusResponseErrorCode Read(
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
                        return global::Topaz.GetSystemStatusResponseErrorCodeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Topaz.GetSystemStatusResponseErrorCode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Topaz.GetSystemStatusResponseErrorCode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Topaz.GetSystemStatusResponseErrorCode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Topaz.GetSystemStatusResponseErrorCodeExtensions.ToValueString(value));
        }
    }
}
