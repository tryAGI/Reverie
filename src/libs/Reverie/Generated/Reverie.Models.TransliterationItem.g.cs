
#nullable enable

namespace Reverie
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransliterationItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inString")]
        public string? InString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outString")]
        public global::System.Collections.Generic.IList<string>? OutString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiStatus")]
        public int? ApiStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransliterationItem" /> class.
        /// </summary>
        /// <param name="inString"></param>
        /// <param name="outString"></param>
        /// <param name="apiStatus"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransliterationItem(
            string? inString,
            global::System.Collections.Generic.IList<string>? outString,
            int? apiStatus,
            string? status)
        {
            this.InString = inString;
            this.OutString = outString;
            this.ApiStatus = apiStatus;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransliterationItem" /> class.
        /// </summary>
        public TransliterationItem()
        {
        }
    }
}