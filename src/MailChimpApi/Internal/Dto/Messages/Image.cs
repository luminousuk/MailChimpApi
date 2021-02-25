using System.Text.Json.Serialization;

namespace MailChimpApi.Internal.Dto.Messages
{
    internal class Image
    {
        /// <summary>
        ///     The MIME type of the image - must start with "image/"
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        ///     The Content ID of the image - use to reference the image in your HTML content
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        ///     The content of the image as a base64-encoded string
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }
    }
}