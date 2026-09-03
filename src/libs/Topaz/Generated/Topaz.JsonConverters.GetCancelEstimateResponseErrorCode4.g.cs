#nullable enable

namespace Topaz.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetCancelEstimateResponseErrorCode4JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Topaz.GetCancelEstimateResponseErrorCode4>
    {
        /// <inheritdoc />
        public override global::Topaz.GetCancelEstimateResponseErrorCode4 Read(
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
                        return global::Topaz.GetCancelEstimateResponseErrorCode4Extensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Topaz.GetCancelEstimateResponseErrorCode4)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Topaz.GetCancelEstimateResponseErrorCode4);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Topaz.GetCancelEstimateResponseErrorCode4 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Topaz.GetCancelEstimateResponseErrorCode4Extensions.ToValueString(value));
        }
    }
}
