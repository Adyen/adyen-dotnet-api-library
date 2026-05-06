using System.Text.Json;
using Adyen.BalancePlatform.Client;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.AuthorizedCardUsers
{
    [TestClass]
    public class AuthorizedCardUsersTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public AuthorizedCardUsersTest()
        {
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureBalancePlatform((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });
                })
                .Build();

            _jsonSerializerOptionsProvider = host.Services.GetRequiredService<JsonSerializerOptionsProvider>();
        }

        [TestMethod]
        public void Given_AuthorisedCardUsers_Get_When_Deserialized_Then_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/AuthorisedCardUsers-get-success.json");

            // Act
            AuthorisedCardUsers result = JsonSerializer.Deserialize<AuthorisedCardUsers>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.LegalEntityIds);
            Assert.AreEqual(1, result.LegalEntityIds.Count);
            Assert.AreEqual("LE1234567890", result.LegalEntityIds[0]);
        }

        [TestMethod]
        public void Given_AuthorisedCardUsers_Create_When_Deserialized_Then_Result_Is_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/AuthorisedCardUsers-create-success.json");

            // Act
            AuthorisedCardUsers result = JsonSerializer.Deserialize<AuthorisedCardUsers>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.LegalEntityIds);
            Assert.AreEqual(1, result.LegalEntityIds.Count);
            Assert.AreEqual("LE1234567890", result.LegalEntityIds[0]);
        }
    }
}
