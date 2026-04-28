
#nullable enable

namespace Reverie
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseList")]
        public global::System.Collections.Generic.IList<global::Reverie.TranslationItem>? ResponseList { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationResponse" /> class.
        /// </summary>
        /// <param name="responseList"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationResponse(
            global::System.Collections.Generic.IList<global::Reverie.TranslationItem>? responseList)
        {
            this.ResponseList = responseList;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationResponse" /> class.
        /// </summary>
        public TranslationResponse()
        {
        }
    }
}