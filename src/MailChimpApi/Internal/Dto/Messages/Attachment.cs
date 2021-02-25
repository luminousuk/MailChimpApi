using System.Text.Json.Serialization;

namespace MailChimpApi.Internal.Dto.Messages
{
    internal class Attachment
    {
        /// <summary>
        ///     The MIME type of the attachment
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        ///     The file name of the attachment
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        ///     The content of the attachment as a base64-encoded string
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }
    }
}