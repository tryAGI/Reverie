
#nullable enable

namespace Reverie
{
    /// <summary>
    /// Focused OpenAPI description for Reverie language AI APIs.<br/>
    /// Reverie exposes several products through shared endpoints and the<br/>
    /// `REV-APPNAME` header; this spec models typed SDK methods and a partial<br/>
    /// client hook routes them to the documented endpoints.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IReverieClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Reverie.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Reverie.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public SpeechToTextClient SpeechToText { get; }

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechClient TextToSpeech { get; }

        /// <summary>
        /// 
        /// </summary>
        public TranslationClient Translation { get; }

        /// <summary>
        /// 
        /// </summary>
        public TransliterationClient Transliteration { get; }

    }
}