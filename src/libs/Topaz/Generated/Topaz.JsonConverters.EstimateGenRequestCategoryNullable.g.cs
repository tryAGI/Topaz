#nullable enable

namespace Topaz.JsonConverters
{
    /// <inheritdoc />
    public sealed class EstimateGenRequestCategoryNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Topaz.EstimateGenRequestCategory?>
    {
        /// <inheritdoc />
        public override global::Topaz.EstimateGenRequestCategory? Read(
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
                        return global::Topaz.EstimateGenRequestCategoryExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Topaz.EstimateGenRequestCategory)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Topaz.EstimateGenRequestCategory?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Topaz.EstimateGenRequestCategory? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Topaz.EstimateGenRequestCategoryExtensions.ToValueString(value.Value));
            }
        }
    }
}
