
#nullable enable

namespace Revocalize
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VoiceModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        public string? Gender { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("age")]
        public string? Age { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_language")]
        public string? BaseLanguage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traits")]
        public global::System.Collections.Generic.IList<string>? Traits { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("genre")]
        public string? Genre { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_type")]
        public string? VoiceType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vocal_range")]
        public global::Revocalize.VocalRange? VocalRange { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="age"></param>
        /// <param name="description"></param>
        /// <param name="baseLanguage"></param>
        /// <param name="traits"></param>
        /// <param name="genre"></param>
        /// <param name="voiceType"></param>
        /// <param name="vocalRange"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceModel(
            string? id,
            string? name,
            string? gender,
            string? age,
            string? description,
            string? baseLanguage,
            global::System.Collections.Generic.IList<string>? traits,
            string? genre,
            string? voiceType,
            global::Revocalize.VocalRange? vocalRange)
        {
            this.Id = id;
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.Description = description;
            this.BaseLanguage = baseLanguage;
            this.Traits = traits;
            this.Genre = genre;
            this.VoiceType = voiceType;
            this.VocalRange = vocalRange;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceModel" /> class.
        /// </summary>
        public VoiceModel()
        {
        }

    }
}