using System.Threading.Tasks;
using MailChimpApi.Internal.Dto.Messages;

namespace MailChimpApi.Internal
{
    internal class MailChimpMessagesApi : IMailChimpMessagesApi
    {
        private readonly MailChimpMessagesService _service;

        public MailChimpMessagesApi(MailChimpMessagesService service)
        {
            _service = service;
        }

        public async Task<object> Send()
        {
            return await _service.Send(new SendRequest
            {
                Message = new Message
                {
                    Text = "Test text!",
                    To = new[]
                    {
                        new Recipient
                        {
                            Email = "chris@luminousuk.com",
                            Name = "Chris Pickford",
                            Type = "to"
                        }
                    },
                    Subject = "Testing",
                    FromEmail = "chris@luminousuk.com"
                }
            });
        }
    }
}