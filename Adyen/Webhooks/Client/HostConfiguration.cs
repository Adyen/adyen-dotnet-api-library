using System;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;

namespace Adyen.Webhooks.Client
{
    /// <summary>
    /// Provides hosting configuration for Webhooks.
    /// </summary>
    public class HostConfiguration
    {
        private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        /// <summary>
        /// Instantiates the HostConfiguration with the necessary dependencies to deserialize webhooks.
        /// </summary>
        /// <param name="services"><see cref="IServiceCollection"/></param>
        public HostConfiguration(IServiceCollection services)
        {
            JsonSerializerOptionsProvider jsonSerializerOptionsProvider = new(_jsonOptions);
            services.AddSingleton(jsonSerializerOptionsProvider);
        }

        /// <summary>
        /// Configures the <see cref="JsonSerializerOptions"/>.
        /// </summary>
        /// <param name="jsonSerializerOptions">Configures the <see cref="JsonSerializerOptions"/>.</param>
        /// <returns><see cref="HostConfiguration"/>.</returns>
        public HostConfiguration ConfigureJsonOptions(Action<JsonSerializerOptions> jsonSerializerOptions)
        {
            jsonSerializerOptions(_jsonOptions);
            return this;
        }
    }
}
