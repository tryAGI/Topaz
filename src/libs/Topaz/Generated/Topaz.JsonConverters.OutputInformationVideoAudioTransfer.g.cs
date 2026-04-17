#nullable enable

namespace Topaz.JsonConverters
{
    /// <inheritdoc />
    public sealed class OutputInformationVideoAudioTransferJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Topaz.OutputInformationVideoAudioTransfer>
    {
        /// <inheritdoc />
        public override global::Topaz.OutputInformationVideoAudioTransfer Read(
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
                        return global::Topaz.OutputInformationVideoAudioTransferExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Topaz.OutputInformationVideoAudioTransfer)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Topaz.OutputInformationVideoAudioTransfer);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Topaz.OutputInformationVideoAudioTransfer value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Topaz.OutputInformationVideoAudioTransferExtensions.ToValueString(value));
        }
    }
}
