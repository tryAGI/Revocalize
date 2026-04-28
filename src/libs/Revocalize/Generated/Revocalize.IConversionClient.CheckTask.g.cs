#nullable enable

namespace Revocalize
{
    public partial interface IConversionClient
    {
        /// <summary>
        /// Check conversion task status
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Revocalize.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Revocalize.TaskStatusResponse> CheckTaskAsync(
            string taskId,
            global::Revocalize.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}