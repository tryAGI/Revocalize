
#nullable enable

namespace Revocalize
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskStatusResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Revocalize.JsonConverters.TaskStatusResponseStatusJsonConverter))]
        public global::Revocalize.TaskStatusResponseStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_url")]
        public string? InputAudioUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_audio_urls")]
        public global::System.Collections.Generic.IList<string>? OutputAudioUrls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_settings")]
        public object? OutputSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskStatusResponse" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="inputAudioUrl"></param>
        /// <param name="outputAudioUrls"></param>
        /// <param name="outputSettings"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskStatusResponse(
            global::Revocalize.TaskStatusResponseStatus? status,
            string? inputAudioUrl,
            global::System.Collections.Generic.IList<string>? outputAudioUrls,
            object? outputSettings,
            string? error)
        {
            this.Status = status;
            this.InputAudioUrl = inputAudioUrl;
            this.OutputAudioUrls = outputAudioUrls;
            this.OutputSettings = outputSettings;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskStatusResponse" /> class.
        /// </summary>
        public TaskStatusResponse()
        {
        }

    }
}