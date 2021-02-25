using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MailChimpApi.Internal.Dto.Messages
{
    internal class RecipientMergeVariables
    {
        /// <summary>
        ///     The email address of the recipient that the merge variables should apply to
        /// </summary>
        [JsonPropertyName("rcpt")]
        public string Rcpt { get; set; }


        /// <summary>
        ///     The recipient's merge variables
        /// </summary>
        [JsonPropertyName("vars")]
        public IEnumerable<MergeVariable> Vars { get; set; }
    }
}