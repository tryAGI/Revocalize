#nullable enable

namespace Revocalize
{
    public partial interface IConversionClient
    {
        /// <summary>
        /// Convert a vocal audio file to a target voice model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Revocalize.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Revocalize.TaskCreatedResponse> ConvertAudioAsync(

            global::Revocalize.ConvertAudioRequest request,
            global::Revocalize.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Convert a vocal audio file to a target voice model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Revocalize.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Revocalize.AutoSDKHttpResponse<global::Revocalize.TaskCreatedResponse>> ConvertAudioAsResponseAsync(

            global::Revocalize.ConvertAudioRequest request,
            global::Revocalize.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Convert a vocal audio file to a target voice model
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Revocalize.TaskCreatedResponse> ConvertAudioAsync(
            byte[] audio,
            string audioname,
            string model,
            int? transpose = default,
            int? generationsCount = default,
            global::Revocalize.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Convert a vocal audio file to a target voice model
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Revocalize.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Revocalize.TaskCreatedResponse> ConvertAudioAsync(
            global::System.IO.Stream audio,
            string audioname,
            string model,
            int? transpose = default,
            int? generationsCount = default,
            global::Revocalize.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Convert a vocal audio file to a target voice model
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Revocalize.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Revocalize.AutoSDKHttpResponse<global::Revocalize.TaskCreatedResponse>> ConvertAudioAsResponseAsync(
            global::System.IO.Stream audio,
            string audioname,
            string model,
            int? transpose = default,
            int? generationsCount = default,
            global::Revocalize.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}