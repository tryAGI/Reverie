#nullable enable

namespace Reverie
{
    public partial interface ITranslationClient
    {
        /// <summary>
        /// Translate text<br/>
        /// Routed to `POST /` with `REV-APPNAME: localization`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reverie.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reverie.TranslationResponse> TranslateAsync(

            global::Reverie.TranslationRequest request,
            global::Reverie.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Translate text<br/>
        /// Routed to `POST /` with `REV-APPNAME: localization`.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="src"></param>
        /// <param name="tgt"></param>
        /// <param name="domain"></param>
        /// <param name="enableTransliteration"></param>
        /// <param name="enableNmt"></param>
        /// <param name="nmtMask"></param>
        /// <param name="nmtMaskTerms"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reverie.TranslationResponse> TranslateAsync(
            global::System.Collections.Generic.IList<string> data,
            string src,
            string tgt,
            string? domain = default,
            bool? enableTransliteration = default,
            bool? enableNmt = default,
            bool? nmtMask = default,
            global::System.Collections.Generic.IList<string>? nmtMaskTerms = default,
            global::Reverie.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}