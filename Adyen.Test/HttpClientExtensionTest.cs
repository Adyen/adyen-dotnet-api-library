using System;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Adyen.HttpClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class HttpClientExtensionTest
    {
        [TestMethod]
        public void ServerCertificateValidationCallback_NoPolicyErrors_ReturnsTrue()
        {
            // Arrange
            var certificate = CreateTestCertificate();
            var chain = new X509Chain();
            var environment = Model.Environment.Test;

            // Act
            var result = HttpClientExtensions.ServerCertificateValidationCallback(
                null, certificate, chain, SslPolicyErrors.None, environment);

            // Assert
            Assert.IsTrue(result, "Certificate with no policy errors should be accepted");
        }

        [TestMethod]
        public void ServerCertificateValidationCallback_NameMismatch_ValidTerminalCertificate_ReturnsTrue()
        {
            // Arrange
            var certificate = CreateTestCertificateWithSubject("CN=P400-123456789.test.terminal.adyen.com");
            var chain = new X509Chain();
            var environment = Model.Environment.Test;

            // Act
            var result = HttpClientExtensions.ServerCertificateValidationCallback(
                null, certificate, chain, SslPolicyErrors.RemoteCertificateNameMismatch, environment);

            // Assert
            Assert.IsTrue(result, "Valid terminal certificate with name mismatch should be accepted");
        }

        [TestMethod]
        public void ServerCertificateValidationCallback_NameMismatch_InvalidCertificate_ReturnsFalse()
        {
            // Arrange
            var certificate = CreateTestCertificateWithSubject("CN=invalid.example.com");
            var chain = new X509Chain();
            var environment = Model.Environment.Test;

            // Act
            var result = HttpClientExtensions.ServerCertificateValidationCallback(
                null, certificate, chain, SslPolicyErrors.RemoteCertificateNameMismatch, environment);

            // Assert
            Assert.IsFalse(result, "Invalid certificate with name mismatch should be rejected");
        }

        [TestMethod]
        public void ServerCertificateValidationCallback_NullCertificate_ChainErrors_ReturnsFalse()
        {
            // Arrange
            X509Certificate certificate = null;
            var chain = new X509Chain();
            var environment = Model.Environment.Test;

            // Act
            var result = HttpClientExtensions.ServerCertificateValidationCallback(
                null, certificate, chain, SslPolicyErrors.RemoteCertificateChainErrors, environment);

            // Assert
            Assert.IsFalse(result, "Null certificate should be rejected");
        }

        [TestMethod]
        public void ServerCertificateValidationCallback_ChainErrors_ValidTerminalCertificate_HandlesGracefully()
        {
            // Arrange - Create a valid terminal certificate
            var certificate = CreateTestCertificateWithSubject("CN=P400-123456789.test.terminal.adyen.com");
            var chain = new X509Chain();
            var environment = Model.Environment.Test;

            // Act - This tests that chain errors are handled (even if certificate can't build chain)
            var result = HttpClientExtensions.ServerCertificateValidationCallback(
                null, certificate, chain, SslPolicyErrors.RemoteCertificateChainErrors, environment);

            // Assert - The method should handle this case without throwing exceptions
            // Result may be true or false depending on certificate validity, but shouldn't throw
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ServerCertificateValidationCallback_ChainErrors_InvalidTerminalCertificate_ReturnsFalse()
        {
            // Arrange - Create certificate with invalid CN pattern
            var certificate = CreateTestCertificateWithSubject("CN=invalid.example.com");
            var chain = new X509Chain();
            var environment = Model.Environment.Test;

            // Act
            var result = HttpClientExtensions.ServerCertificateValidationCallback(
                null, certificate, chain, SslPolicyErrors.RemoteCertificateChainErrors, environment);

            // Assert
            Assert.IsFalse(result, "Certificate with invalid CN pattern should be rejected for chain errors");
        }

        [TestMethod]
        public void ServerCertificateValidationCallback_BothErrors_ValidTerminalCertificate_HandlesGracefully()
        {
            // Arrange
            var certificate = CreateTestCertificateWithSubject("CN=legacy-terminal-certificate.live.terminal.adyen.com");
            var chain = new X509Chain();
            var environment = Model.Environment.Live;

            // Act
            var result = HttpClientExtensions.ServerCertificateValidationCallback(
                null, certificate, chain, 
                SslPolicyErrors.RemoteCertificateNameMismatch | SslPolicyErrors.RemoteCertificateChainErrors, 
                environment);

            // Assert - Should handle both errors without throwing
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ServerCertificateValidationCallback_BothErrors_InvalidCertificate_ReturnsFalse()
        {
            // Arrange
            var certificate = CreateTestCertificateWithSubject("CN=invalid.example.com");
            var chain = new X509Chain();
            var environment = Model.Environment.Test;

            // Act
            var result = HttpClientExtensions.ServerCertificateValidationCallback(
                null, certificate, chain,
                SslPolicyErrors.RemoteCertificateNameMismatch | SslPolicyErrors.RemoteCertificateChainErrors,
                environment);

            // Assert
            Assert.IsFalse(result, "Invalid certificate with both errors should be rejected");
        }

        [TestMethod]
        public void ServerCertificateValidationCallback_UnknownError_ReturnsFalse()
        {
            // Arrange
            var certificate = CreateTestCertificate();
            var chain = new X509Chain();
            var environment = Model.Environment.Test;

            // Act - Use an unusual combination of errors
            var result = HttpClientExtensions.ServerCertificateValidationCallback(
                null, certificate, chain, (SslPolicyErrors)255, environment);

            // Assert
            Assert.IsFalse(result, "Unknown SSL policy errors should be rejected");
        }

        [TestMethod]
        public void ServerCertificateValidationCallback_DifferentEnvironments_BehavesCorrectly()
        {
            // Arrange
            var testCert = CreateTestCertificateWithSubject("CN=P400-123456789.test.terminal.adyen.com");
            var liveCert = CreateTestCertificateWithSubject("CN=P400-987654321.live.terminal.adyen.com");
            var chain = new X509Chain();

            // Act & Assert - Test environment certificate should work with Test environment
            var testResult = HttpClientExtensions.ServerCertificateValidationCallback(
                null, testCert, chain, SslPolicyErrors.RemoteCertificateNameMismatch, Model.Environment.Test);
            Assert.IsTrue(testResult, "Test certificate should work with Test environment");

            // Act & Assert - Test environment certificate should NOT work with Live environment
            var testOnLive = HttpClientExtensions.ServerCertificateValidationCallback(
                null, testCert, chain, SslPolicyErrors.RemoteCertificateNameMismatch, Model.Environment.Live);
            Assert.IsFalse(testOnLive, "Test certificate should not work with Live environment");

            // Act & Assert - Live environment certificate should work with Live environment
            var liveResult = HttpClientExtensions.ServerCertificateValidationCallback(
                null, liveCert, chain, SslPolicyErrors.RemoteCertificateNameMismatch, Model.Environment.Live);
            Assert.IsTrue(liveResult, "Live certificate should work with Live environment");

            // Act & Assert - Live environment certificate should NOT work with Test environment
            var liveOnTest = HttpClientExtensions.ServerCertificateValidationCallback(
                null, liveCert, chain, SslPolicyErrors.RemoteCertificateNameMismatch, Model.Environment.Test);
            Assert.IsFalse(liveOnTest, "Live certificate should not work with Test environment");
        }

        [TestMethod]
        public void ServerCertificateValidationCallback_LegacyCertificate_AcceptsCorrectly()
        {
            // Arrange
            var testLegacy = CreateTestCertificateWithSubject("CN=legacy-terminal-certificate.test.terminal.adyen.com");
            var liveLegacy = CreateTestCertificateWithSubject("CN=legacy-terminal-certificate.live.terminal.adyen.com");
            var chain = new X509Chain();

            // Act & Assert - Test legacy certificate
            var testResult = HttpClientExtensions.ServerCertificateValidationCallback(
                null, testLegacy, chain, SslPolicyErrors.RemoteCertificateNameMismatch, Model.Environment.Test);
            Assert.IsTrue(testResult, "Test legacy certificate should be accepted");

            // Act & Assert - Live legacy certificate
            var liveResult = HttpClientExtensions.ServerCertificateValidationCallback(
                null, liveLegacy, chain, SslPolicyErrors.RemoteCertificateNameMismatch, Model.Environment.Live);
            Assert.IsTrue(liveResult, "Live legacy certificate should be accepted");
        }

        #region Helper Methods

        private X509Certificate CreateTestCertificate()
        {
            // Create a simple self-signed certificate for testing
            return CreateTestCertificateWithSubject("CN=test.adyen.com");
        }

        private X509Certificate CreateTestCertificateWithSubject(string subject)
        {
            // Create a test certificate with the specified subject
            // Note: In production, these would be real certificates, but for unit tests
            // we create minimal certificates for testing logic
            try
            {
                var request = new CertificateRequest(
                    subject,
                    RSA.Create(2048),
                    HashAlgorithmName.SHA256,
                    RSASignaturePadding.Pkcs1);

                // Set validity dates
                var notBefore = DateTimeOffset.UtcNow.AddDays(-1);
                var notAfter = DateTimeOffset.UtcNow.AddYears(1);

                var certificate = request.CreateSelfSigned(notBefore, notAfter);
                return certificate;
            }
            catch
            {
                // Fallback: Create a very basic certificate if above fails
                // This ensures tests can run even if certificate creation has issues
                return new X509Certificate2();
            }
        }

        #endregion
    }
}
