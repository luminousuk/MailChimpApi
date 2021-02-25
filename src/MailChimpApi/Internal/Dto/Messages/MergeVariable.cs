using System.Text.Json.Serialization;

namespace MailChimpApi.Internal.Dto.Messages
{
    internal class MergeVariable
    {
        /// <summary>
        ///     The global merge variable's name. Merge variable names are case-insensitive and may not start with _
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        ///     The global merge variable's content
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }
    }
}