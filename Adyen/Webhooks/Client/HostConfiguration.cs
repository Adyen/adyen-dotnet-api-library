using System;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using Adyen.Core.Auth;
using Adyen.Core.Client;
using Adyen.Core.Options;

namespace Adyen.Webhooks.Client
{
    /// <summary>
    /// Provides hosting configuration for Webhooks.
    /// </summary>
    public class HostConfiguration
    {
        private readonly IServiceCollection _services;
        private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        private readonly AdyenOptions _adyenOptions = new AdyenOptions();

        /// <summary>
        /// Instantiates the HostConfiguration with the necessary dependencies to deserialize webhooks.
        /// </summary>
        /// <param name="services"><see cref="IServiceCollection"/></param>
        public HostConfiguration(IServiceCollection services)
        {
            _services = services;
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

        /// <summary>
        /// Configures the <see cref="AdyenOptions"/> (e.g. <see cref="AdyenOptions.AdyenHmacKey"/>).
        /// </summary>
        /// <param name="adyenOptions">Configures the <see cref="AdyenOptions"/>.</param>
        /// <returns><see cref="HostConfiguration"/>.</returns>
        public HostConfiguration ConfigureAdyenOptions(Action<AdyenOptions> adyenOptions)
        {
            adyenOptions(_adyenOptions);
            _services.AddSingleton<ITokenProvider<HmacKeyToken>>(new TokenProvider<HmacKeyToken>(new HmacKeyToken(_adyenOptions.AdyenHmacKey)));
            return this;
        }
    }
}
