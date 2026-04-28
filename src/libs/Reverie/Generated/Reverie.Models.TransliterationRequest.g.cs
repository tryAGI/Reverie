
#nullable enable

namespace Reverie
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransliterationRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Src { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tgt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tgt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("noOfSuggestions")]
        public int? NoOfSuggestions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isBulk")]
        public bool? IsBulk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransliterationRequest" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="src"></param>
        /// <param name="tgt"></param>
        /// <param name="domain"></param>
        /// <param name="noOfSuggestions"></param>
        /// <param name="isBulk"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransliterationRequest(
            global::System.Collections.Generic.IList<string> data,
            string src,
            string tgt,
            string? domain,
            int? noOfSuggestions,
            bool? isBulk)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Src = src ?? throw new global::System.ArgumentNullException(nameof(src));
            this.Tgt = tgt ?? throw new global::System.ArgumentNullException(nameof(tgt));
            this.Domain = domain;
            this.NoOfSuggestions = noOfSuggestions;
            this.IsBulk = isBulk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransliterationRequest" /> class.
        /// </summary>
        public TransliterationRequest()
        {
        }
    }
}