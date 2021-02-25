using System.Text.Json.Serialization;

namespace MailChimpApi.Internal.Dto.Messages
{
    internal class Recipient
    {
        /// <summary>
        ///     The email address of the recipient
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        ///     The optional display name to use for the recipient
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        ///     The header type to use for the recipient, defaults to "to" if not provided Possible values: "to", "cc", or "bcc".
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}