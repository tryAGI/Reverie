
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Reverie
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Reverie.JsonConverters.TextToSpeechRequestFormatJsonConverter),

            typeof(global::Reverie.JsonConverters.TextToSpeechRequestFormatNullableJsonConverter),

            typeof(global::Reverie.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Reverie.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Reverie.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reverie.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reverie.TextToSpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reverie.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reverie.TextToSpeechRequestFormat), TypeInfoPropertyName = "TextToSpeechRequestFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reverie.TranslationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reverie.TranslationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reverie.TranslationItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reverie.TranslationItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reverie.TransliterationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reverie.TransliterationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reverie.TransliterationItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reverie.TransliterationItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reverie.TranscribeFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reverie.SpeechToTextResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reverie.BatchUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reverie.BatchStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reverie.BatchTranscriptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reverie.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reverie.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reverie.TranslationItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reverie.TransliterationItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}