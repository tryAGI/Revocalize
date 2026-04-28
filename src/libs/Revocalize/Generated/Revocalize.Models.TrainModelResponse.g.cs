
#nullable enable

namespace Revocalize
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrainModelResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Revocalize.JsonConverters.TrainModelResponseStatusJsonConverter))]
        public global::Revocalize.TrainModelResponseStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_epoch")]
        public int? CurrentEpoch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainModelResponse" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="modelId"></param>
        /// <param name="currentEpoch"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainModelResponse(
            global::Revocalize.TrainModelResponseStatus? status,
            string? modelId,
            int? currentEpoch)
        {
            this.Status = status;
            this.ModelId = modelId;
            this.CurrentEpoch = currentEpoch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainModelResponse" /> class.
        /// </summary>
        public TrainModelResponse()
        {
        }
    }
}