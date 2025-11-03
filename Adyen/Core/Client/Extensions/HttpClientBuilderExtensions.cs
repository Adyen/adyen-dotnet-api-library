#nullable enable

using System;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Polly.Timeout;
using Polly.Extensions.Http;
using Polly;

namespace Adyen.Core.Client.Extensions
{
    /// <summary>
    /// Extension methods for IHttpClientBuilder
    /// </summary>
    public static class HttpClientBuilderExtensions
    {
        /// <summary>
        /// Adds a Polly retry policy to your clients.
        /// </summary>
        /// <param name="httpClient"><see cref="System.Net.Http.HttpClient"/>.</param>
        /// <param name="numberOfRetries">The number of retries.</param>
        /// <returns><see cref="IHttpClientBuilder"/>.</returns>
        public static IHttpClientBuilder AddRetryPolicy(this IHttpClientBuilder httpClient, int numberOfRetries)
        {
            httpClient.AddPolicyHandler(RetryPolicy(numberOfRetries));
            return httpClient;
        }

        private static Polly.Retry.AsyncRetryPolicy<HttpResponseMessage> RetryPolicy(int numberOfRetries)
            => HttpPolicyExtensions
                .HandleTransientHttpError()
                .Or<TimeoutRejectedException>()
                .RetryAsync(numberOfRetries);

        /// <summary>
        /// Adds a Polly timeout policy to your clients.
        /// Use this when you need resilient policies (using the <see cref="IHttpClientFactory"/>) and want to combine this with a retry & circuit breaker.
        /// </summary>
        /// <param name="httpClient"><see cref="System.Net.Http.HttpClient"/>.</param>
        /// <param name="timeout"><see cref="TimeSpan"/>.</param>
        /// <returns><see cref="IHttpClientBuilder"/>.</returns>
        public static IHttpClientBuilder AddTimeoutPolicy(this IHttpClientBuilder httpClient, TimeSpan timeout)
        {
            httpClient.AddPolicyHandler(TimeoutPolicy(timeout));
            return httpClient;
        }
        
        private static AsyncTimeoutPolicy<HttpResponseMessage> TimeoutPolicy(TimeSpan timeout)
            => Policy.TimeoutAsync<HttpResponseMessage>(timeout);
        
        /// <summary>
        /// Adds a Polly circuit breaker to your clients.
        /// </summary>
        /// <param name="httpClient"><see cref="System.Net.Http.HttpClient"/>.</param>
        /// <param name="numberOfEventsAllowedBeforeBreaking">Example: if set to 3 - if 3 consecutive request fail, Polly will open the circuit for the duration of <see cref="TimeSpan"/>.</param>
        /// <param name="durationOfBreak"><see cref="TimeSpan"/>.</param>
        /// <returns><see cref="IHttpClientBuilder"/>.</returns>
        public static IHttpClientBuilder AddCircuitBreakerPolicy(this IHttpClientBuilder httpClient, int numberOfEventsAllowedBeforeBreaking, TimeSpan durationOfBreak)
        {
            httpClient.AddTransientHttpErrorPolicy(policyBuilder => CircuitBreakerPolicy(policyBuilder, numberOfEventsAllowedBeforeBreaking, durationOfBreak));
            return httpClient;
        }

        private static Polly.CircuitBreaker.AsyncCircuitBreakerPolicy<HttpResponseMessage> CircuitBreakerPolicy(
            PolicyBuilder<HttpResponseMessage> policyBuilder, int numberOfEventsAllowedBeforeBreaking, TimeSpan durationOfBreak)
                => policyBuilder.CircuitBreakerAsync(numberOfEventsAllowedBeforeBreaking, durationOfBreak);
    }
}
