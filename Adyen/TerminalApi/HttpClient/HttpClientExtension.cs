using System;
using System.Net.Http;
using System.Net.Security;
using System.Runtime.InteropServices;
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
                    // On ARM64 Linux, .NET may fail to build chains even with properly installed root CAs
                    // due to OpenSSL integration issues. We need to manually verify the chain.
                    return ValidateCertificateChainManually(certificate, chain, environment);
                case SslPolicyErrors.RemoteCertificateNameMismatch | SslPolicyErrors.RemoteCertificateChainErrors:
                    // Handle both name mismatch and chain errors together
                    return TerminalCommonNameValidator.ValidateCertificate(certificate.Subject, environment) &&
                           ValidateCertificateChainManually(certificate, chain, environment);
                default:
                    return false;
            }
        }

        private static bool ValidateCertificateChainManually(X509Certificate certificate, X509Chain providedChain, Model.Environment environment)
        {
            if (certificate == null)
            {
                return false;
            }

            // Only apply special handling for terminal certificates (local API endpoints)
            // For other certificates, follow standard validation
            if (!TerminalCommonNameValidator.ValidateCertificate(certificate.Subject, environment))
            {
                return false;
            }

            X509Certificate2 cert2;
            try
            {
                cert2 = certificate as X509Certificate2 ?? new X509Certificate2(certificate);
            }
            catch
            {
                return false;
            }

            // Check if we're on ARM64 Linux
            bool isArm64Linux = RuntimeInformation.ProcessArchitecture == Architecture.Arm64 && 
                                RuntimeInformation.IsOSPlatform(OSPlatform.Linux);

            // First, check the provided chain for critical errors
            // These should ALWAYS be rejected, regardless of platform
            if (providedChain != null && providedChain.ChainStatus != null)
            {
                foreach (var status in providedChain.ChainStatus)
                {
                    // Always reject certificates with critical security issues
                    if (status.Status == X509ChainStatusFlags.NotTimeValid ||
                        status.Status == X509ChainStatusFlags.NotTimeNested ||
                        status.Status == X509ChainStatusFlags.Revoked ||
                        status.Status == X509ChainStatusFlags.NotSignatureValid ||
                        status.Status == X509ChainStatusFlags.NotValidForUsage ||
                        status.Status == X509ChainStatusFlags.InvalidBasicConstraints ||
                        status.Status == X509ChainStatusFlags.Cyclic ||
                        status.Status == X509ChainStatusFlags.InvalidExtension ||
                        status.Status == X509ChainStatusFlags.InvalidPolicyConstraints ||
                        status.Status == X509ChainStatusFlags.InvalidNameConstraints ||
                        status.Status == X509ChainStatusFlags.HasNotSupportedNameConstraint ||
                        status.Status == X509ChainStatusFlags.HasNotDefinedNameConstraint ||
                        status.Status == X509ChainStatusFlags.HasNotPermittedNameConstraint ||
                        status.Status == X509ChainStatusFlags.HasExcludedNameConstraint)
                    {
                        return false;
                    }
                }
            }

            // On ARM64 Linux ONLY, and ONLY for terminal certificates, try to rebuild the chain
            // to work around .NET/OpenSSL integration issues
            if (isArm64Linux)
            {
                using (var newChain = new X509Chain())
                {
                    // Configure chain policy to use system certificates
                    newChain.ChainPolicy.RevocationMode = X509RevocationMode.NoCheck;
                    newChain.ChainPolicy.RevocationFlag = X509RevocationFlag.ExcludeRoot;
                    newChain.ChainPolicy.VerificationFlags = X509VerificationFlags.NoFlag;
                    newChain.ChainPolicy.VerificationTime = DateTime.UtcNow;

                    // Try to build the chain
                    bool chainBuilt = newChain.Build(cert2);

                    // Even on ARM64 Linux, check for critical errors first
                    foreach (var status in newChain.ChainStatus)
                    {
                        if (status.Status == X509ChainStatusFlags.NotTimeValid ||
                            status.Status == X509ChainStatusFlags.NotTimeNested ||
                            status.Status == X509ChainStatusFlags.Revoked ||
                            status.Status == X509ChainStatusFlags.NotSignatureValid ||
                            status.Status == X509ChainStatusFlags.NotValidForUsage ||
                            status.Status == X509ChainStatusFlags.InvalidBasicConstraints ||
                            status.Status == X509ChainStatusFlags.Cyclic ||
                            status.Status == X509ChainStatusFlags.InvalidExtension ||
                            status.Status == X509ChainStatusFlags.InvalidPolicyConstraints ||
                            status.Status == X509ChainStatusFlags.InvalidNameConstraints ||
                            status.Status == X509ChainStatusFlags.HasNotSupportedNameConstraint ||
                            status.Status == X509ChainStatusFlags.HasNotDefinedNameConstraint ||
                            status.Status == X509ChainStatusFlags.HasNotPermittedNameConstraint ||
                            status.Status == X509ChainStatusFlags.HasExcludedNameConstraint)
                        {
                            return false;
                        }
                    }

                    // If chain built successfully, accept it
                    if (chainBuilt)
                    {
                        return true;
                    }

                    // On ARM64 Linux, if chain building failed, check if it's ONLY due to
                    // UntrustedRoot or PartialChain (OpenSSL integration issues)
                    bool onlyRootIssues = true;
                    foreach (var status in newChain.ChainStatus)
                    {
                        if (status.Status != X509ChainStatusFlags.NoError &&
                            status.Status != X509ChainStatusFlags.UntrustedRoot &&
                            status.Status != X509ChainStatusFlags.PartialChain)
                        {
                            onlyRootIssues = false;
                            break;
                        }
                    }

                    // Only on ARM64 Linux, accept if only root trust issues exist
                    if (onlyRootIssues && cert2.NotBefore <= DateTime.UtcNow && cert2.NotAfter >= DateTime.UtcNow)
                    {
                        return true;
                    }
                }
            }

            // On non-ARM64-Linux platforms, reject chain errors
            // This ensures Windows correctly rejects missing root CAs
            return false;
        }
    }
}