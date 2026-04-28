#nullable enable

namespace Reverie
{
    public partial interface ISpeechToTextClient
    {
        /// <summary>
        /// Transcribe a single audio file<br/>
        /// Routed to `POST /` with `REV-APPNAME: stt_file`.
        /// </summary>
        /// <param name="srcLang"></param>
        /// <param name="domain">
        /// Default Value: generic
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reverie.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reverie.SpeechToTextResponse> TranscribeFileAsync(
            string srcLang,

            global::Reverie.TranscribeFileRequest request,
            string? domain = default,
            global::Reverie.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transcribe a single audio file<br/>
        /// Routed to `POST /` with `REV-APPNAME: stt_file`.
        /// </summary>
        /// <param name="srcLang"></param>
        /// <param name="domain">
        /// Default Value: generic
        /// </param>
        /// <param name="audio"></param>
        /// <param name="audioname"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reverie.SpeechToTextResponse> TranscribeFileAsync(
            string srcLang,
            byte[] audio,
            string audioname,
            string? domain = default,
            global::Reverie.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}