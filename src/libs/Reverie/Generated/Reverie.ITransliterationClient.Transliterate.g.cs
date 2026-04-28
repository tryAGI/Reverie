#nullable enable

namespace Reverie
{
    public partial interface ITransliterationClient
    {
        /// <summary>
        /// Transliterate text<br/>
        /// Routed to `POST /` with `REV-APPNAME: transliteration`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reverie.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reverie.TransliterationResponse> TransliterateAsync(

            global::Reverie.TransliterationRequest request,
            global::Reverie.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transliterate text<br/>
        /// Routed to `POST /` with `REV-APPNAME: transliteration`.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="src"></param>
        /// <param name="tgt"></param>
        /// <param name="domain"></param>
        /// <param name="noOfSuggestions"></param>
        /// <param name="isBulk"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reverie.TransliterationResponse> TransliterateAsync(
            global::System.Collections.Generic.IList<string> data,
            string src,
            string tgt,
            string? domain = default,
            int? noOfSuggestions = default,
            bool? isBulk = default,
            global::Reverie.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}