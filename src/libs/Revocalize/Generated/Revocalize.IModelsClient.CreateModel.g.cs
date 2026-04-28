#nullable enable

namespace Revocalize
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Create a pending custom AI voice model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Revocalize.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Revocalize.CreateModelResponse> CreateModelAsync(

            global::Revocalize.CreateModelRequest request,
            global::Revocalize.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a pending custom AI voice model
        /// </summary>
        /// <param name="trainingAudioFiles">
        /// ZIP containing model.json and an audio folder.
        /// </param>
        /// <param name="trainingAudioFilesname">
        /// ZIP containing model.json and an audio folder.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Revocalize.CreateModelResponse> CreateModelAsync(
            byte[] trainingAudioFiles,
            string trainingAudioFilesname,
            global::Revocalize.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}