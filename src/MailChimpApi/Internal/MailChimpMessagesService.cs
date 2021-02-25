using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimpApi.Internal.Dto.Messages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace MailChimpApi.Internal
{
    internal interface IMailChimpMessagesService
    {
        Task<IEnumerable<SendResponse>> Send(SendRequest request);
    }

    internal class MailChimpMessagesService : BaseMailChimpService, IMailChimpMessagesService
    {
        public MailChimpMessagesService(HttpClient client, IOptions<MailChimpApiOptions> options, ILogger<MailChimpMessagesService> logger)
            : base(client, options, logger)
        {
        }

        public Task<IEnumerable<SendResponse>> Send(SendRequest request)
        {
            const string UriPath = "messages/send";

            return PostAsync<IEnumerable<SendResponse>>(UriPath, request);
        }
    }
}