using System.Text.Json.Serialization;

namespace MailChimpApi.Internal.Dto
{
    internal abstract class BaseRequest
    {
        /// <summary>
        ///   A valid api key.
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }
    }
}