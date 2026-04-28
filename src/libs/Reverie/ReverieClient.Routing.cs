namespace Reverie;

#pragma warning disable CA1822

internal static class ReverieRequestRouting
{
    public static void RouteToRoot(global::System.Net.Http.HttpRequestMessage request, string appName)
    {
        request.RequestUri = new global::System.Uri("/", global::System.UriKind.Relative);
        AddAppName(request, appName);
    }

    public static void AddAppName(global::System.Net.Http.HttpRequestMessage request, string appName)
    {
        request.Headers.Remove("REV-APPNAME");
        request.Headers.TryAddWithoutValidation("REV-APPNAME", appName);
    }
}

public partial class TextToSpeechClient
{
    partial void PrepareTextToSpeechRequest(
        global::System.Net.Http.HttpClient httpClient,
        global::System.Net.Http.HttpRequestMessage httpRequestMessage,
        string speaker,
        global::Reverie.TextToSpeechRequest request)
    {
        ReverieRequestRouting.RouteToRoot(httpRequestMessage, "tts");
    }
}

public partial class TranslationClient
{
    partial void PrepareTranslateRequest(
        global::System.Net.Http.HttpClient httpClient,
        global::System.Net.Http.HttpRequestMessage httpRequestMessage,
        global::Reverie.TranslationRequest request)
    {
        ReverieRequestRouting.RouteToRoot(httpRequestMessage, "localization");
    }
}

public partial class TransliterationClient
{
    partial void PrepareTransliterateRequest(
        global::System.Net.Http.HttpClient httpClient,
        global::System.Net.Http.HttpRequestMessage httpRequestMessage,
        global::Reverie.TransliterationRequest request)
    {
        ReverieRequestRouting.RouteToRoot(httpRequestMessage, "transliteration");
    }
}

public partial class SpeechToTextClient
{
    partial void PrepareTranscribeFileRequest(
        global::System.Net.Http.HttpClient httpClient,
        global::System.Net.Http.HttpRequestMessage httpRequestMessage,
        string srcLang,
        string? domain,
        global::Reverie.TranscribeFileRequest request)
    {
        ReverieRequestRouting.RouteToRoot(httpRequestMessage, "stt_file");
    }

    partial void PrepareUploadBatchAudioRequest(
        global::System.Net.Http.HttpClient httpClient,
        global::System.Net.Http.HttpRequestMessage httpRequestMessage,
        string srcLang,
        string? domain,
        global::Reverie.TranscribeFileRequest request)
    {
        ReverieRequestRouting.AddAppName(httpRequestMessage, "stt_batch");
    }

    partial void PrepareGetBatchStatusRequest(
        global::System.Net.Http.HttpClient httpClient,
        global::System.Net.Http.HttpRequestMessage httpRequestMessage,
        string jobId)
    {
        ReverieRequestRouting.AddAppName(httpRequestMessage, "stt_batch");
    }

    partial void PrepareGetBatchTranscriptRequest(
        global::System.Net.Http.HttpClient httpClient,
        global::System.Net.Http.HttpRequestMessage httpRequestMessage,
        string jobId)
    {
        ReverieRequestRouting.AddAppName(httpRequestMessage, "stt_batch");
    }
}

#pragma warning restore CA1822
