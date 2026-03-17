using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Adyen.Webhooks.Client;

namespace Adyen.Webhooks.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="IHostBuilder"/>.
    /// </summary>
    public static class HostBuilderExtensions
    {
        /// <summary>
        /// Initializes the <see cref="HostConfiguration"/> without adding Webhooks service defaults.
        /// Use <see cref="ServiceCollectionExtensions"/> to add handler services.
        /// </summary>
        /// <param name="hostBuilder"><see cref="IHostBuilder"/>.</param>
        /// <param name="hostConfigurationOptions">Configures the <see cref="HostBuilderContext"/>, <see cref="IServiceCollection"/>, and <see cref="HostConfiguration"/>.</param>
        public static IHostBuilder ConfigureWebhooks(this IHostBuilder hostBuilder, Action<HostBuilderContext, IServiceCollection, HostConfiguration> hostConfigurationOptions)
        {
            hostBuilder.ConfigureServices((context, services) =>
            {
                HostConfiguration hostConfiguration = new HostConfiguration(services);
                hostConfigurationOptions(context, services, hostConfiguration);
            });

            return hostBuilder;
        }

        /// <summary>
        /// Initializes the <see cref="HostConfiguration"/> and adds Webhooks service defaults.
        /// </summary>
        /// <param name="hostBuilder"><see cref="IHostBuilder"/>.</param>
        /// <param name="hostConfigurationOptions">Configures the <see cref="HostBuilderContext"/>, <see cref="IServiceCollection"/>, and <see cref="HostConfiguration"/>.</param>
        /// <param name="serviceLifetime"><see cref="ServiceLifetime"/>.</param>
        public static IHostBuilder ConfigureWebhooksDefaults(this IHostBuilder hostBuilder, Action<HostBuilderContext, IServiceCollection, HostConfiguration> hostConfigurationOptions, ServiceLifetime serviceLifetime = ServiceLifetime.Singleton)
        {
            hostBuilder.ConfigureServices((context, services) =>
            {
                HostConfiguration hostConfiguration = new HostConfiguration(services);
                hostConfigurationOptions(context, services, hostConfiguration);
                services.AddWebhooksHandler(serviceLifetime);
            });

            return hostBuilder;
        }
    }
}
