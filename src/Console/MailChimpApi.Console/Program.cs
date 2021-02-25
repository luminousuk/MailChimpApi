using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MailChimpApi.Console
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            await Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services
                        .AddHostedService<MailChimpHostedService>()
                        .AddMailChimpApi(config => { config.ApiKey = "_Tafh4bVJPNIwXuGiHpS0A"; });
                })
                .RunConsoleAsync();
        }
    }
}