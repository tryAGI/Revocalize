
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Revocalize
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Revocalize.JsonConverters.TaskStatusResponseStatusJsonConverter),

            typeof(global::Revocalize.JsonConverters.TaskStatusResponseStatusNullableJsonConverter),

            typeof(global::Revocalize.JsonConverters.TrainModelResponseStatusJsonConverter),

            typeof(global::Revocalize.JsonConverters.TrainModelResponseStatusNullableJsonConverter),

            typeof(global::Revocalize.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Revocalize.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Revocalize.ConvertAudioRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Revocalize.TaskCreatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Revocalize.TaskStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Revocalize.TaskStatusResponseStatus), TypeInfoPropertyName = "TaskStatusResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Revocalize.ListModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Revocalize.VoiceModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Revocalize.VoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Revocalize.VocalRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Revocalize.CreateModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Revocalize.CreateModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Revocalize.TrainModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Revocalize.TrainModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Revocalize.TrainModelResponseStatus), TypeInfoPropertyName = "TrainModelResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Revocalize.VoiceModel>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}