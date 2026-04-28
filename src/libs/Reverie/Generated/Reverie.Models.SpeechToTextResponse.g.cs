
#nullable enable

namespace Reverie
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeechToTextResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_text")]
        public string? DisplayText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cause")]
        public string? Cause { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public float? Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="text"></param>
        /// <param name="transcript"></param>
        /// <param name="displayText"></param>
        /// <param name="cause"></param>
        /// <param name="confidence"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechToTextResponse(
            bool? success,
            string? text,
            string? transcript,
            string? displayText,
            string? cause,
            float? confidence)
        {
            this.Success = success;
            this.Text = text;
            this.Transcript = transcript;
            this.DisplayText = displayText;
            this.Cause = cause;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextResponse" /> class.
        /// </summary>
        public SpeechToTextResponse()
        {
        }
    }
}