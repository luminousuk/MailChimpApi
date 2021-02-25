using System;
using MailChimpApi.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace MailChimpApi
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMailChimpApi(this IServiceCollection services, Action<MailChimpApiOptions> setupAction)
        {
            if (services is null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (setupAction is null)
            {
                throw new ArgumentNullException(nameof(setupAction));
            }

            services.AddOptions();
            services.Configure(setupAction);

            services.AddHttpClient<MailChimpMessagesService>();

            // TODO: Add services
            services.Add(ServiceDescriptor.Singleton<IMailChimpMessagesApi, MailChimpMessagesApi>());
            services.TryAdd(ServiceDescriptor.Singleton<IMailChimpMessagesService, MailChimpMessagesService>());


            return services;
        }
    }
}