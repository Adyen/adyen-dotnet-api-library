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
    public class InstallAndroidAppDetailsTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public InstallAndroidAppDetailsTest()
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
        public void Given_Serialize_When_TypeNotProvided_Then_DefaultTypeIsIncluded()
        {
            var details = new InstallAndroidAppDetails { AppId = "app-1" };

            string json = JsonSerializer.Serialize(details, _jsonSerializerOptionsProvider.Options);

            Assert.IsTrue(json.Contains("\"type\":\"InstallAndroidApp\""), $"Expected type in JSON but got: {json}");
            Assert.IsTrue(json.Contains("\"appId\":\"app-1\""), $"Expected appId in JSON but got: {json}");
        }

        [TestMethod]
        public void Given_Serialize_When_TypeExplicitlySet_Then_ExplicitTypeIsUsed()
        {
            var details = new InstallAndroidAppDetails
            {
                AppId = "app-1",
                Type = InstallAndroidAppDetails.TypeEnum.InstallAndroidApp
            };

            string json = JsonSerializer.Serialize(details, _jsonSerializerOptionsProvider.Options);

            Assert.IsTrue(json.Contains("\"type\":\"InstallAndroidApp\""), $"Expected type in JSON but got: {json}");
        }

        [TestMethod]
        public void Given_Serialize_When_TypeExplicitlyNull_Then_TypeOmitted()
        {
            var details = new InstallAndroidAppDetails
            {
                AppId = "app-1",
                Type = null
            };

            string json = JsonSerializer.Serialize(details, _jsonSerializerOptionsProvider.Options);

            Assert.IsFalse(json.Contains("\"type\""), $"Expected no type in JSON but got: {json}");
        }

        [TestMethod]
        public void Given_Deserialize_When_TypePresent_Then_TypeIsParsed()
        {
            const string json = "{\"appId\":\"app-1\",\"type\":\"InstallAndroidApp\"}";

            var details = JsonSerializer.Deserialize<InstallAndroidAppDetails>(json, _jsonSerializerOptionsProvider.Options);

            Assert.IsNotNull(details);
            Assert.AreEqual("app-1", details!.AppId);
            Assert.AreEqual(InstallAndroidAppDetails.TypeEnum.InstallAndroidApp, details.Type);
        }

        [TestMethod]
        public void Given_DefaultConstructor_Then_TypeIsInstallAndroidApp()
        {
            var details = new InstallAndroidAppDetails();

            Assert.AreEqual(InstallAndroidAppDetails.TypeEnum.InstallAndroidApp, details.Type);
        }
    }
}
