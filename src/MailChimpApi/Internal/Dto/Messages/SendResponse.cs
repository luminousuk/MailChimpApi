using System.Text.Json.Serialization;

namespace MailChimpApi.Internal.Dto.Messages
{
    internal class SendResponse
    {
        [JsonPropertyName("email")] public string Email { get; set; }

        [JsonPropertyName("status")] public string Status { get; set; }

        [JsonPropertyName("reject_reason")] public string RejectReason { get; set; }

        [JsonPropertyName("_id")] public string Id { get; set; }
    }
}