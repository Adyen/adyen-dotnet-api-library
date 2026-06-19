using Adyen.Core.Options;
using Adyen.Management.Client;
using Adyen.Management.Extensions;
using Adyen.Management.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;

namespace Adyen.Test.Management
{
    [TestClass]
    public class ManagementTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;
        
        public ManagementTest()
        {
            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureManagement((context, services, config) =>
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
        public async Task Given_Deserialize_When_MeApiCredential_Result_Return_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/management/me.json");
         
            // Act
            var response = JsonSerializer.Deserialize<MeApiCredential>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual("S2-6262224667", response.Id);
            Assert.IsTrue(response.Active);
            Assert.AreEqual("Management API - Users read and write", response.Roles[0]);
        }

        [TestMethod]
        public async Task Given_Deserialize_When_ListMerchantResponse_Returns_Correct_Data()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/management/list-merchant-accounts.json");

            // Act
            var response = JsonSerializer.Deserialize<ListMerchantResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(22, response.ItemsTotal);
            Assert.AreEqual("YOUR_MERCHANT_ACCOUNT_1", response.Data[0].Id);
        }

        [TestMethod]
        public async Task Given_Deserialize_When_UpdateResource_Returns_Data_String()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/management/logo.json");
            
            // Act
            var response = JsonSerializer.Deserialize<Logo>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual("BASE-64_ENCODED_STRING_FROM_THE_REQUEST", response.Data);
        }

        [TestMethod]
        public async Task Given_Deserialize_When_ListTerminalsResponse_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/management/list-terminals.json");
            
            // Act
            var response = JsonSerializer.Deserialize<ListTerminalsResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(2, response.Data?.Count);
            Assert.IsNotNull(response);
            Assert.AreEqual("Castles_Android 1.79.4", response.Data?.First(o => o.Id == "S1F2-000150183300032").FirmwareVersion);
            Assert.AreEqual("pck1", response.Data?.First(o => o.Id == "S1F2-000150183300032").InstalledAPKs?[0].PackageName);
        }
        
        /// <summary>
        /// Reproduces the customer-reported issue: the Adyen API can return payment method details
        /// where payment-method-specific objects (e.g. "klarna": {}) have no properties populated.
        /// KlarnaResponseInfo has only optional fields, so deserialization should succeed.
        /// </summary>
        [TestMethod]
        public void Given_Deserialize_When_PaymentMethod_KlarnaWithEmptyBody_Should_Succeed()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/management/get-payment-method-klarna-empty-body.json");

            // Act
            var result = JsonSerializer.Deserialize<PaymentMethod>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("PM3224Q22322225G9BLD5DJ3B", result.Id);
            Assert.AreEqual("klarna_US", result.Type);
            Assert.IsTrue(result.Enabled);
            Assert.IsNotNull(result.Klarna);
        }

        [TestMethod]
        public void Given_Deserialize_When_PaymentMethod_PayPalWithEmptyBody_Should_Succeed_With_Null_Properties()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/management/get-payment-method-paypal-empty-body.json");

            // Act
            var result = JsonSerializer.Deserialize<PaymentMethod>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("PM3293722322655L83TSBC3C6", result.Id);
            Assert.AreEqual("paypal", result.Type);
            Assert.IsNotNull(result.Paypal);
            Assert.IsNull(result.Paypal.PayerId);
            Assert.IsNull(result.Paypal.Subject);
        }

        [TestMethod]
        public void Given_Deserialize_When_PaymentMethod_AccelWithEmptyBody_Should_Succeed_With_Null_Properties()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/management/get-payment-method-accel-empty-body.json");

            // Act
            var result = JsonSerializer.Deserialize<PaymentMethod>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("PM329C322322855PJFHWPF45T", result.Id);
            Assert.AreEqual("accel", result.Type);
            Assert.IsNotNull(result.Accel);
            Assert.IsNull(result.Accel.ProcessingType);
        }

        [TestMethod]
        public void Given_Serialize_When_TerminalSettings_Includes_Null_Surcharge()
        {
            // Arrange
            TerminalSettings terminalSettings = new TerminalSettings
            {
                Localization = new Localization { Language = "it" },
                Surcharge = null
            };
            
            // Act
            string target = JsonSerializer.Serialize(terminalSettings, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            using var jsonDoc = JsonDocument.Parse(target);
            JsonElement root = jsonDoc.RootElement;
            
            Assert.IsNotNull(terminalSettings.Localization);                                                                                                                                                               
            JsonElement localizationElement = root.GetProperty("localization");
            Assert.AreEqual("it", localizationElement.GetProperty("language").GetString());
            
            // must include surcharge as null
            Assert.IsTrue(target.Contains("\"surcharge\":null"));
            // must not include gratuities
            Assert.IsFalse(target.Contains("gratuities"));
        }        
    }
}