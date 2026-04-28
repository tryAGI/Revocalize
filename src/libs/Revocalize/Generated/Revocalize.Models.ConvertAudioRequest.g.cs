
#nullable enable

namespace Revocalize
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConvertAudioRequest
    {
        /// <summary>
        /// Input vocal audio file, preferably WAV.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Audio { get; set; }

        /// <summary>
        /// Input vocal audio file, preferably WAV.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audioname { get; set; }

        /// <summary>
        /// Target model ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transpose")]
        public int? Transpose { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generations_count")]
        public int? GenerationsCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertAudioRequest" /> class.
        /// </summary>
        /// <param name="audio">
        /// Input vocal audio file, preferably WAV.
        /// </param>
        /// <param name="audioname">
        /// Input vocal audio file, preferably WAV.
        /// </param>
        /// <param name="model">
        /// Target model ID.
        /// </param>
        /// <param name="transpose">
        /// Default Value: 0
        /// </param>
        /// <param name="generationsCount">
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConvertAudioRequest(
            byte[] audio,
            string audioname,
            string model,
            int? transpose,
            int? generationsCount)
        {
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Audioname = audioname ?? throw new global::System.ArgumentNullException(nameof(audioname));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Transpose = transpose;
            this.GenerationsCount = generationsCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertAudioRequest" /> class.
        /// </summary>
        public ConvertAudioRequest()
        {
        }
    }
}