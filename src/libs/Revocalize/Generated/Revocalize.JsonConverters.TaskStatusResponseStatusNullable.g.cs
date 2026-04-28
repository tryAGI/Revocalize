#nullable enable

namespace Revocalize.JsonConverters
{
    /// <inheritdoc />
    public sealed class TaskStatusResponseStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Revocalize.TaskStatusResponseStatus?>
    {
        /// <inheritdoc />
        public override global::Revocalize.TaskStatusResponseStatus? Read(
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
                        return global::Revocalize.TaskStatusResponseStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Revocalize.TaskStatusResponseStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Revocalize.TaskStatusResponseStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Revocalize.TaskStatusResponseStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Revocalize.TaskStatusResponseStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
