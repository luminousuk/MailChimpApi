using System.Threading.Tasks;

namespace MailChimpApi
{
    public interface IMailChimpMessagesApi
    {
        // TODO: Implement friendly request/response objects
        public Task<object> Send();
    }
}