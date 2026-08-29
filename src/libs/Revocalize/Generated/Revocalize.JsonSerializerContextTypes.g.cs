
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Revocalize
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Revocalize.ConvertAudioRequest? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Revocalize.TaskCreatedResponse? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Revocalize.TaskStatusResponse? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Revocalize.TaskStatusResponseStatus? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Revocalize.ListModelsResponse? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Revocalize.VoiceModel>? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Revocalize.VoiceModel? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Revocalize.VocalRange? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Revocalize.CreateModelRequest? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Revocalize.CreateModelResponse? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Revocalize.TrainModelRequest? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Revocalize.TrainModelResponse? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Revocalize.TrainModelResponseStatus? Type17 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Revocalize.VoiceModel>? ListType1 { get; set; }
    }
}