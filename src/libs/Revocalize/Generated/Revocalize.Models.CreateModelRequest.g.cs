
#nullable enable

namespace Revocalize
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateModelRequest
    {
        /// <summary>
        /// ZIP containing model.json and an audio folder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_audio_files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] TrainingAudioFiles { get; set; }

        /// <summary>
        /// ZIP containing model.json and an audio folder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_audio_filesname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrainingAudioFilesname { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelRequest" /> class.
        /// </summary>
        /// <param name="trainingAudioFiles">
        /// ZIP containing model.json and an audio folder.
        /// </param>
        /// <param name="trainingAudioFilesname">
        /// ZIP containing model.json and an audio folder.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateModelRequest(
            byte[] trainingAudioFiles,
            string trainingAudioFilesname)
        {
            this.TrainingAudioFiles = trainingAudioFiles ?? throw new global::System.ArgumentNullException(nameof(trainingAudioFiles));
            this.TrainingAudioFilesname = trainingAudioFilesname ?? throw new global::System.ArgumentNullException(nameof(trainingAudioFilesname));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelRequest" /> class.
        /// </summary>
        public CreateModelRequest()
        {
        }

    }
}