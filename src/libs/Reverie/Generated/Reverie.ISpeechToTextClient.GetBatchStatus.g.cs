#nullable enable

namespace Reverie
{
    public partial interface ISpeechToTextClient
    {
        /// <summary>
        /// Get batch transcription status
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reverie.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reverie.BatchStatusResponse> GetBatchStatusAsync(
            string jobId,
            global::Reverie.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get batch transcription status
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reverie.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reverie.AutoSDKHttpResponse<global::Reverie.BatchStatusResponse>> GetBatchStatusAsResponseAsync(
            string jobId,
            global::Reverie.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}