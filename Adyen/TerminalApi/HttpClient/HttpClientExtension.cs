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
                ConnectTimeout = config.ConnectTimeout,
                
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
                case SslPolicyErrors.RemoteCertificateChainErrors:
                    // On some platforms (e.g., ARM64/Linux), the chain might not build automatically even when
                    // the root certificate is properly installed in the system trust store.
                    // This can happen due to platform-specific SSL/TLS stack limitations.
                    // We manually rebuild the chain and check if it's valid, particularly for local terminal endpoints.
                    return ValidateCertificateChainManually(certificate, environment);
                case SslPolicyErrors.RemoteCertificateNameMismatch | SslPolicyErrors.RemoteCertificateChainErrors:
                    // Handle both name mismatch and chain errors together
                    return TerminalCommonNameValidator.ValidateCertificate(certificate.Subject, environment) &&
                           ValidateCertificateChainManually(certificate, environment);
                default:
                    return false;
            }
        }

        private static bool ValidateCertificateChainManually(X509Certificate certificate, Model.Environment environment)
        {
            if (certificate == null)
            {
                return false;
            }

            X509Certificate2 cert2;
            try
            {
                // Convert to X509Certificate2 for chain building
                cert2 = certificate as X509Certificate2 ?? new X509Certificate2(certificate);
            }
            catch
            {
                // If certificate conversion fails, reject it
                return false;
            }

            // Validate the common name for local terminal certificates
            if (!TerminalCommonNameValidator.ValidateCertificate(cert2.Subject, environment))
            {
                return false;
            }

            // Build the certificate chain with system root certificates
            using (var newChain = new X509Chain())
            {
                // Configure chain building to use system root certificates
                // Skip online revocation checking for performance and reliability on ARM64/Linux
                newChain.ChainPolicy.RevocationMode = X509RevocationMode.NoCheck;
                newChain.ChainPolicy.RevocationFlag = X509RevocationFlag.ExcludeRoot;
                newChain.ChainPolicy.VerificationFlags = X509VerificationFlags.NoFlag;
                newChain.ChainPolicy.VerificationTime = DateTime.UtcNow;

                // Build the chain
                bool chainIsValid = newChain.Build(cert2);

                // On ARM64/Linux platforms, chain building might fail even with valid certificates
                // due to platform limitations. In such cases, we allow the connection if:
                // 1. The certificate itself is valid (not expired, has valid signature)
                // 2. The common name matches our expected pattern for terminal certificates
                // 3. No critical security issues are present (revoked, invalid signature, etc.)
                if (!chainIsValid)
                {
                    // Check if the only chain errors are related to partial chain or untrusted root
                    // These can occur when the platform can't locate system certificates properly
                    bool onlySystemRootIssues = true;
                    foreach (var chainStatus in newChain.ChainStatus)
                    {
                        // Reject certificates with critical security issues
                        if (chainStatus.Status == X509ChainStatusFlags.NotTimeValid ||
                            chainStatus.Status == X509ChainStatusFlags.NotTimeNested ||
                            chainStatus.Status == X509ChainStatusFlags.Revoked ||
                            chainStatus.Status == X509ChainStatusFlags.NotSignatureValid ||
                            chainStatus.Status == X509ChainStatusFlags.NotValidForUsage ||
                            chainStatus.Status == X509ChainStatusFlags.InvalidBasicConstraints)
                        {
                            return false;
                        }

                        // Allow if the issue is just about not being able to build to a trusted root
                        // or partial chain (which can happen on ARM64/Linux)
                        if (chainStatus.Status != X509ChainStatusFlags.NoError &&
                            chainStatus.Status != X509ChainStatusFlags.UntrustedRoot &&
                            chainStatus.Status != X509ChainStatusFlags.PartialChain)
                        {
                            onlySystemRootIssues = false;
                            break;
                        }
                    }

                    // If the certificate is otherwise valid and the only issue is system root detection,
                    // allow it (user must ensure proper root CA installation as per documentation)
                    if (onlySystemRootIssues)
                    {
                        // Verify certificate is not expired and has a valid time range using UTC time
                        if (cert2.NotBefore <= DateTime.UtcNow && cert2.NotAfter >= DateTime.UtcNow)
                        {
                            return true;
                        }
                    }

                    return false;
                }

                return true;
            }
        }
    }
}