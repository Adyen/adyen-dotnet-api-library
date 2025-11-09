using Adyen.Core.Options;
using Adyen.Checkout.Extensions;
using Adyen.Checkout.Models;
using Adyen.Checkout.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Hosting;
using System.Text.Json;

namespace Adyen.Test.Checkout
{
    [TestClass]
    public class ModificationTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public ModificationTest()
        {
            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureCheckout((context, services, config) =>
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
        public void Given_Deserialize_When_PaymentCaptureResponse_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/captures-success.json");

            // Act
            var response = JsonSerializer.Deserialize<PaymentCaptureResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(PaymentCaptureResponse.StatusEnum.Received, response.Status);
            Assert.AreEqual("my_reference", response.Reference);
        }

        [TestMethod]
        public void Given_Deserialize_When_PaymentCancelResponse_Result_Is_Not_Null()
        {    
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/cancels-success.json");

            // Act
            var response = JsonSerializer.Deserialize<PaymentCancelResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(PaymentCancelResponse.StatusEnum.Received, response.Status);
            Assert.AreEqual("my_reference", response.Reference);
        }
        
        [TestMethod]
        public void Given_Deserialize_When_StandalonePaymentCancelResponse_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/standalone-cancels-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<StandalonePaymentCancelResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(StandalonePaymentCancelResponse.StatusEnum.Received, response.Status);
            Assert.AreEqual("861633338418518C", response.PspReference);
        }

        [TestMethod]
        public void Given_Deserialize_When_PaymentRefundResponse_Result_Is_Not_Null()
        { 
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/refunds-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<PaymentRefundResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(PaymentRefundResponse.StatusEnum.Received, response.Status);
            Assert.AreEqual("my_reference", response.Reference);
        }

        [TestMethod]
        public void Given_Deserialize_When_PaymentReversalResponse_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/reversals-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<PaymentReversalResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(PaymentReversalResponse.StatusEnum.Received, response.Status);
            Assert.AreEqual("my_reference", response.Reference);
        }
        
        [TestMethod]
        public void Given_Deserialize_When_PaymentAmountUpdateResponse_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/checkout/reversals-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<PaymentAmountUpdateResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(PaymentAmountUpdateResponse.StatusEnum.Received, response.Status);
            Assert.AreEqual("my_reference", response.Reference);
        }
    }
}