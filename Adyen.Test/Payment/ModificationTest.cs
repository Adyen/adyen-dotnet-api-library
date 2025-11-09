using Adyen.Core.Options;
using Adyen.Payment.Extensions;
using Adyen.Payment.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Hosting;
using System.Text.Json;
using Adyen.Constants;
using Adyen.Core;
using Adyen.Payment.Models;

namespace Adyen.Test.Payment
{
    /// <summary>
    /// ClassicPayments - Modification.
    /// </summary>
    [TestClass]
    public class ModificationTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public ModificationTest()
        {
            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigurePayment((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });
                })
                .Build();
            
            _jsonSerializerOptionsProvider = testHost.Services.GetRequiredService<JsonSerializerOptionsProvider>();
        }

        [TestMethod]
        public void Given_Deserialize_When_ModificationResult_Result_Is_CaptureReceived()
        {
            //Assert.AreEqual(json.Contains(AdditionalData["authorisationType"],"PreAuth");
            
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/capture-success.json");
            
            // Act
            var captureResult = JsonSerializer.Deserialize<ModificationResult>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(captureResult.Response, ModificationResult.ResponseEnum.CaptureReceived);
        }

        [TestMethod]
        public void Given_Deserialize_When_ModificationResult_Result_Is_CancelOrRefundReceived()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/cancelOrRefund-received.json");
            
            // Act
            var cancelOrRefundResult = JsonSerializer.Deserialize<ModificationResult>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(cancelOrRefundResult.Response, ModificationResult.ResponseEnum.CancelOrRefundReceived);
        }

        [TestMethod]
        public void Given_Deserialize_When_ModificationResult_Result_Is_RefundReceived()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/refund-received.json");
            
            // Act
            var refundResult = JsonSerializer.Deserialize<ModificationResult>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(refundResult.Response, ModificationResult.ResponseEnum.RefundReceived);
        }

        [TestMethod]
        public void Given_Deserialize_When_ModificationResult_Result_Is_CancelReceived()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/cancel-received.json");
            
            // Act
            var cancelResult = JsonSerializer.Deserialize<ModificationResult>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(cancelResult.Response, ModificationResult.ResponseEnum.CancelReceived);
        }

        [TestMethod]
        public void Given_Deserialize_When_ModificationResult_Result_Is_AdjustAuthorisationReceived()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/adjustAuthorisation-received.json");
            
            // Act
            var adjustAuthorisationResult = JsonSerializer.Deserialize<ModificationResult>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(adjustAuthorisationResult.Response, ModificationResult.ResponseEnum.AdjustAuthorisationReceived);
            Assert.AreEqual(adjustAuthorisationResult.PspReference, "853569123456789D");
            Assert.AreEqual(adjustAuthorisationResult.AdditionalData["merchantReference"], "payment - 20190901");
        }

        [TestMethod]
        public void Given_Deserialize_When_ModificationResult_Result_Is_VoidPendingRefundReceived()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/voidPendingRefund-received.json");
            
            // Act
            var modificationResult = JsonSerializer.Deserialize<ModificationResult>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(modificationResult.Response, ModificationResult.ResponseEnum.VoidPendingRefundReceived);
        }
    }
}
