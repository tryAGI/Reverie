namespace Reverie;

public sealed partial class ReverieClient
{
    /// <summary>
    /// Creates a new <see cref="ReverieClient"/> using Reverie's API key and app ID headers.
    /// </summary>
    /// <param name="apiKey">Value for the <c>REV-API-KEY</c> header.</param>
    /// <param name="appId">Value for the <c>REV-APP-ID</c> header.</param>
    /// <param name="httpClient">Optional HTTP client.</param>
    /// <param name="baseUri">Optional base URI override.</param>
    /// <param name="disposeHttpClient">Whether to dispose the HTTP client with this client.</param>
    public ReverieClient(
        string apiKey,
        string appId,
        global::System.Net.Http.HttpClient? httpClient = null,
        global::System.Uri? baseUri = null,
        bool disposeHttpClient = true) : this(
            httpClient,
            baseUri,
            authorizations: null,
            disposeHttpClient: disposeHttpClient)
    {
        apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
        appId = appId ?? throw new global::System.ArgumentNullException(nameof(appId));

        AuthorizeUsingApiKeyAuth(apiKey);
        AuthorizeUsingAppIdAuth(appId);
    }
}
