#nullable enable

namespace Revocalize
{
    public partial interface ITrainingClient
    {
        /// <summary>
        /// Train a custom AI voice model
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Revocalize.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Revocalize.TrainModelResponse> TrainModelAsync(
            string modelId,

            global::Revocalize.TrainModelRequest request,
            global::Revocalize.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Train a custom AI voice model
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="epochs"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Revocalize.TrainModelResponse> TrainModelAsync(
            string modelId,
            int epochs,
            global::Revocalize.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}