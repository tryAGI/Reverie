#nullable enable

namespace Reverie
{
    public partial interface ITextToSpeechClient
    {
        /// <summary>
        /// Synthesize text to speech<br/>
        /// Routed to `POST /` with `REV-APPNAME: tts`.
        /// </summary>
        /// <param name="speaker"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reverie.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> TextToSpeechAsync(
            string speaker,

            global::Reverie.TextToSpeechRequest request,
            global::Reverie.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Synthesize text to speech<br/>
        /// Routed to `POST /` with `REV-APPNAME: tts`.
        /// </summary>
        /// <param name="speaker"></param>
        /// <param name="text"></param>
        /// <param name="ssml"></param>
        /// <param name="speed"></param>
        /// <param name="pitch"></param>
        /// <param name="sampleRate"></param>
        /// <param name="format"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> TextToSpeechAsync(
            string speaker,
            global::Reverie.OneOf<string, global::System.Collections.Generic.IList<string>>? text = default,
            global::Reverie.OneOf<string, global::System.Collections.Generic.IList<string>>? ssml = default,
            float? speed = default,
            float? pitch = default,
            int? sampleRate = default,
            global::Reverie.TextToSpeechRequestFormat? format = default,
            global::Reverie.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}