#nullable enable

namespace Topaz.JsonConverters
{
    /// <inheritdoc />
    public sealed class OutputInformationVideoDynamicCompressionLevelJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Topaz.OutputInformationVideoDynamicCompressionLevel>
    {
        /// <inheritdoc />
        public override global::Topaz.OutputInformationVideoDynamicCompressionLevel Read(
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
                        return global::Topaz.OutputInformationVideoDynamicCompressionLevelExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Topaz.OutputInformationVideoDynamicCompressionLevel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Topaz.OutputInformationVideoDynamicCompressionLevel);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Topaz.OutputInformationVideoDynamicCompressionLevel value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Topaz.OutputInformationVideoDynamicCompressionLevelExtensions.ToValueString(value));
        }
    }
}
