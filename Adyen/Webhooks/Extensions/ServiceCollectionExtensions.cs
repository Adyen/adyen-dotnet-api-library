using Microsoft.Extensions.DependencyInjection;
using Adyen.Util;

namespace Adyen.Webhooks.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Add <see cref="Adyen.Webhooks.Handlers.WebhooksHandler"/> as the implementation of <see cref="Adyen.Webhooks.Handlers.IWebhooksHandler"/>.
        /// </summary>
        /// <param name="services"><see cref="IServiceCollection"/>.</param>
        /// <param name="serviceLifetime"><see cref="ServiceLifetime"/>.</param>
        /// <returns><see cref="IServiceCollection"/>.</returns>
        public static IServiceCollection AddWebhooksHandler(this IServiceCollection services, ServiceLifetime serviceLifetime = ServiceLifetime.Singleton)
        {
            services.Add(new ServiceDescriptor(typeof(IHmacValidator), typeof(HmacValidator), serviceLifetime));
            services.Add(new ServiceDescriptor(typeof(Adyen.Webhooks.Handlers.IWebhooksHandler), typeof(Adyen.Webhooks.Handlers.WebhooksHandler), serviceLifetime));
            return services;
        }
    }
}
