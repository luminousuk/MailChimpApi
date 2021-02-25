using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MailChimpApi.Internal.Dto.Messages
{
    internal class RecipientMetadata
    {
        /// <summary>
        ///     The email address of the recipient that the metadata is associated with
        /// </summary>
        [JsonPropertyName("rcpt")]
        public string Recipient { get; set; }

        /// <summary>
        ///     An associated array containing the recipient's unique metadata. If a key exists in both the per-recipient metadata
        ///     and the global metadata, the per-recipient metadata will be used.
        /// </summary>
        [JsonPropertyName("values")]
        public IDictionary<string, string> Values { get; set; }
    }
}