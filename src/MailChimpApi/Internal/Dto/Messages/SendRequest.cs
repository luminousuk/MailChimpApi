using System.Text.Json.Serialization;

namespace MailChimpApi.Internal.Dto.Messages
{
    internal class SendRequest : BaseRequest
    {
        /// <summary>
        ///     The information on the message to send.
        /// </summary>
        [JsonPropertyName("message")]
        public Message Message { get; set; }

        /// <summary>
        ///     Enable a background sending mode that is optimized for bulk sending. In async mode, messages/send will immediately
        ///     return a status of "queued" for every recipient.
        ///     To handle rejections when sending in async mode, set up a webhook for the 'reject' event. Defaults to false for
        ///     messages with no more than 10 recipients;
        ///     messages with more than 10 recipients are always sent asynchronously, regardless of the value of async.
        /// </summary>
        [JsonPropertyName("async")]
        public bool Async { get; set; }

        /// <summary>
        ///     The name of the dedicated ip pool that should be used to send the message. If you do not have any dedicated IPs,
        ///     this
        ///     parameter has no effect.
        ///     If you specify a pool that does not exist, your default pool will be used instead.
        /// </summary>
        [JsonPropertyName("ip_pool")]
        public string IpPool { get; set; }

        /// <summary>
        ///     When this message should be sent as a UTC timestamp in YYYY-MM-DD HH:MM:SS format. If you specify a time in the
        ///     past,
        ///     the message will be sent immediately.
        /// </summary>
        [JsonPropertyName("send_at")]
        public string SendAt { get; set; }
    }
}