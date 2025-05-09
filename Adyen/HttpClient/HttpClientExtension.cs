using System;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Adyen.Security;

namespace Adyen.HttpClient
{
    public static class HttpClientExtensions
    {
        /// <summary>
        /// If no HttpClient is provided, we instantiate a default one based on the .NET version.
        /// </summary>
        /// <param name="config"><see cref="Config"/>.</param>
        /// <returns><see cref="HttpMessageHandler"/>.</returns>
        public static HttpMessageHandler ConfigureHttpMessageHandler(Config config)
        {        
#if NET462 || NETSTANDARD2_0
            // .NET Framework 4.6.2 or .NET Standard 2.0 - Use the HttpClientHandler class
            return new HttpClientHandler
            {
                // Use a Proxy. 
                Proxy = config.Proxy,
                UseProxy = config.Proxy != null,

                // Validate SSL certificates based on environment.
                ServerCertificateCustomValidationCallback = 
                    (message, certificate, chain, policy) 
                        => ServerCertificateValidationCallback(message, certificate, chain, policy, config.Environment),

                // If the config does not have an API key, but has a password, UseCredentials is set to true.
                UseDefaultCredentials = !config.HasApiKey && config.HasPassword
            };
#else
            // .NET 6+ - Use the SocketsHttpHandler for better performance.
            return new SocketsHttpHandler
            {
                // Use a Proxy. 
                Proxy = config.Proxy,
                UseProxy = config.Proxy != null,
                
                // Sets the TCP connect timeout (max time for creating the TCP connection).
                ConnectTimeout = TimeSpan.FromMilliseconds(config.Timeout),
                
                // Force reconnection to refresh DNS and avoid stale connections.
                PooledConnectionLifetime = config.PooledConnectionLifetime,
                
                // Close idle connections after a certain amount of time.
                PooledConnectionIdleTimeout = config.PooledConnectionIdleTimeout,
                
                // Max nr of concurrent TCP connections per server.
                MaxConnectionsPerServer = config.MaxConnectionsPerServer,
                
                // Validate SSL certificates based on environment.
                SslOptions = { 
                    RemoteCertificateValidationCallback = 
                        (sender, certificate, chain, policyErrors) => 
                            ServerCertificateValidationCallback(null, certificate, chain, policyErrors, config.Environment)
                }
            };
#endif
        }

        public static bool ServerCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors, Model.Environment environment)
        {
            switch (sslPolicyErrors)
            {
                case SslPolicyErrors.None:
                    return true;
                case SslPolicyErrors.RemoteCertificateNameMismatch:
                    return TerminalCommonNameValidator.ValidateCertificate(certificate.Subject, environment);
                default:
                    return false;
            }
        }
    }
}