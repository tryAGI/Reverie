
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Reverie
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::Reverie.TextToSpeechRequest? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reverie.OneOf<string, global::System.Collections.Generic.IList<string>>? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public float? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reverie.TextToSpeechRequestFormat? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reverie.TranslationRequest? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reverie.TranslationResponse? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reverie.TranslationItem>? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reverie.TranslationItem? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reverie.TransliterationRequest? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reverie.TransliterationResponse? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reverie.TransliterationItem>? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reverie.TransliterationItem? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reverie.TranscribeFileRequest? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reverie.SpeechToTextResponse? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reverie.BatchUploadResponse? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reverie.BatchStatusResponse? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reverie.BatchTranscriptResponse? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reverie.ErrorResponse? Type24 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::Reverie.OneOf<string, global::System.Collections.Generic.List<string>>? ListType0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Reverie.TranslationItem>? ListType2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Reverie.TransliterationItem>? ListType3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType4 { get; set; }
    }
}