#nullable enable

namespace Revocalize.JsonConverters
{
    /// <inheritdoc />
    public sealed class TrainModelResponseStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Revocalize.TrainModelResponseStatus?>
    {
        /// <inheritdoc />
        public override global::Revocalize.TrainModelResponseStatus? Read(
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
                        return global::Revocalize.TrainModelResponseStatusExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Revocalize.TrainModelResponseStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Revocalize.TrainModelResponseStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Revocalize.TrainModelResponseStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Revocalize.TrainModelResponseStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
