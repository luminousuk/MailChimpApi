using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MailChimpApi.Console
{
    public class MailChimpHostedService : IHostedService
    {
        private readonly IMailChimpMessagesApi _messagesApi;
        private readonly ILogger<MailChimpHostedService> _logger;

        public MailChimpHostedService(IMailChimpMessagesApi messagesApi, ILogger<MailChimpHostedService> logger)
        {
            _messagesApi = messagesApi;
            _logger = logger;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            await _messagesApi.Send();
        }

        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
    }
}