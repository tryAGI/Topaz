#nullable enable

namespace Topaz.JsonConverters
{
    /// <inheritdoc />
    public sealed class FrameInterpolationFilterModelJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Topaz.FrameInterpolationFilterModel>
    {
        /// <inheritdoc />
        public override global::Topaz.FrameInterpolationFilterModel Read(
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
                        return global::Topaz.FrameInterpolationFilterModelExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Topaz.FrameInterpolationFilterModel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Topaz.FrameInterpolationFilterModel);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Topaz.FrameInterpolationFilterModel value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Topaz.FrameInterpolationFilterModelExtensions.ToValueString(value));
        }
    }
}
