
#nullable enable

namespace Reverie
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchTranscriptResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utterances")]
        public global::System.Collections.Generic.IList<object>? Utterances { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cause")]
        public string? Cause { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchTranscriptResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="jobId"></param>
        /// <param name="transcript"></param>
        /// <param name="utterances"></param>
        /// <param name="cause"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchTranscriptResponse(
            bool? success,
            string? jobId,
            string? transcript,
            global::System.Collections.Generic.IList<object>? utterances,
            string? cause)
        {
            this.Success = success;
            this.JobId = jobId;
            this.Transcript = transcript;
            this.Utterances = utterances;
            this.Cause = cause;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchTranscriptResponse" /> class.
        /// </summary>
        public BatchTranscriptResponse()
        {
        }
    }
}