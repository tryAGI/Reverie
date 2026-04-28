
#nullable enable

namespace Reverie
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToSpeechRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reverie.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Reverie.OneOf<string, global::System.Collections.Generic.IList<string>>? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssml")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reverie.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Reverie.OneOf<string, global::System.Collections.Generic.IList<string>>? Ssml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public float? Speed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pitch")]
        public float? Pitch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reverie.JsonConverters.TextToSpeechRequestFormatJsonConverter))]
        public global::Reverie.TextToSpeechRequestFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToSpeechRequest" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="ssml"></param>
        /// <param name="speed"></param>
        /// <param name="pitch"></param>
        /// <param name="sampleRate"></param>
        /// <param name="format"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToSpeechRequest(
            global::Reverie.OneOf<string, global::System.Collections.Generic.IList<string>>? text,
            global::Reverie.OneOf<string, global::System.Collections.Generic.IList<string>>? ssml,
            float? speed,
            float? pitch,
            int? sampleRate,
            global::Reverie.TextToSpeechRequestFormat? format)
        {
            this.Text = text;
            this.Ssml = ssml;
            this.Speed = speed;
            this.Pitch = pitch;
            this.SampleRate = sampleRate;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToSpeechRequest" /> class.
        /// </summary>
        public TextToSpeechRequest()
        {
        }
    }
}