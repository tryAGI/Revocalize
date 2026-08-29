
#nullable enable

namespace Revocalize
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrainModelRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("epochs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Epochs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainModelRequest" /> class.
        /// </summary>
        /// <param name="epochs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainModelRequest(
            int epochs)
        {
            this.Epochs = epochs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainModelRequest" /> class.
        /// </summary>
        public TrainModelRequest()
        {
        }

    }
}