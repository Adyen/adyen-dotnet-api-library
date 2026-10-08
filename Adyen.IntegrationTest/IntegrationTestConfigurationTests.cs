using System.Text.Json.Nodes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.IntegrationTest
{
    [TestClass]
    public class IntegrationTestConfigurationTests
    {
        private static JsonObject ValidConfiguration() => new JsonObject
        {
            ["company"] = "company",
            ["merchantAccount"] = "merchant",
            ["balancePlatform"] = "platform",
            ["apiKey"] = "psp-key",
            ["lemApiKey"] = "lem-key",
            ["bclApiKey"] = "bcl-key",
            ["givingCampaignId"] = "campaign",
            ["legalEntityId"] = "entity",
            ["businessLineId"] = "business",
            ["documentId"] = "document",
            ["accountHolderId"] = "holder",
            ["balanceAccountId"] = "balance"
        };

        [TestMethod]
        public void Given_ValidJson_When_Loaded_Then_ExposesTypedConfiguration()
        {
            IntegrationTestConfiguration configuration =
                IntegrationTestConfiguration.FromJson(ValidConfiguration().ToJsonString());

            Assert.AreEqual("company", configuration.Company);
            Assert.AreEqual("merchant", configuration.MerchantAccount);
            Assert.AreEqual("platform", configuration.BalancePlatform);
            Assert.AreEqual("psp-key", configuration.ApiKey);
            Assert.AreEqual("lem-key", configuration.LemApiKey);
            Assert.AreEqual("bcl-key", configuration.BclApiKey);
            Assert.AreEqual("campaign", configuration.GivingCampaignId);
            Assert.AreEqual("entity", configuration.LegalEntityId);
            Assert.AreEqual("business", configuration.BusinessLineId);
            Assert.AreEqual("document", configuration.DocumentId);
            Assert.AreEqual("holder", configuration.AccountHolderId);
            Assert.AreEqual("balance", configuration.BalanceAccountId);
        }

        [TestMethod]
        public void Given_ValidConfiguration_When_AccessedThroughBaseClass_Then_ExposesTypedFields()
        {
            IntegrationTestConfiguration configuration =
                IntegrationTestConfiguration.FromJson(ValidConfiguration().ToJsonString());
            var test = new ConfigurationAccessors(configuration);

            CollectionAssert.AreEqual(
                new[]
                {
                    "company", "merchant", "platform", "psp-key", "lem-key", "bcl-key",
                    "campaign", "entity", "business", "document", "holder", "balance"
                },
                test.Values,
                "The base class must expose every typed configuration field.");
        }

        private sealed class ConfigurationAccessors : BaseIntegrationTest
        {
            public ConfigurationAccessors(IntegrationTestConfiguration configuration) : base(configuration)
            {
            }

            public string[] Values => new[]
            {
                Company, MerchantAccount, BalancePlatformId, ApiKey, LemApiKey, BclApiKey,
                GivingCampaignId, LegalEntityId, BusinessLineId, DocumentId, AccountHolderId, BalanceAccountId
            };
        }

        [TestMethod]
        public void Given_EnvironmentJson_When_Loaded_Then_LocalFileIsNotRead()
        {
            IntegrationTestConfiguration configuration = IntegrationTestConfiguration.Load(
                ValidConfiguration().ToJsonString(),
                () => throw new AssertFailedException("The environment must take precedence over the local file."));

            Assert.AreEqual("merchant", configuration.MerchantAccount);
        }

        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow(" \n\t")]
        public void Given_AbsentOrBlankEnvironment_When_Loaded_Then_ReadsLocalFile(string environmentValue)
        {
            bool localFileRead = false;
            IntegrationTestConfiguration configuration = IntegrationTestConfiguration.Load(environmentValue, () =>
            {
                localFileRead = true;
                return ValidConfiguration().ToJsonString();
            });

            Assert.IsTrue(localFileRead, "The local file must be used when the environment is absent or blank.");
            Assert.AreEqual("merchant", configuration.MerchantAccount);
        }

        [TestMethod]
        public void Given_InvalidEnvironmentJson_When_Loaded_Then_DoesNotFallBack()
        {
            Assert.ThrowsExactly<InvalidOperationException>(() =>
                IntegrationTestConfiguration.Load("{",
                    () => throw new AssertFailedException("Invalid environment JSON must not fall back to the file.")));
        }

        [TestMethod]
        [DataRow("company")]
        [DataRow("merchantAccount")]
        [DataRow("balancePlatform")]
        [DataRow("apiKey")]
        [DataRow("lemApiKey")]
        [DataRow("bclApiKey")]
        [DataRow("givingCampaignId")]
        [DataRow("legalEntityId")]
        [DataRow("businessLineId")]
        [DataRow("documentId")]
        [DataRow("accountHolderId")]
        [DataRow("balanceAccountId")]
        public void Given_MissingField_When_Loaded_Then_ReportsFieldNameOnly(string field)
        {
            JsonObject json = ValidConfiguration();
            json.Remove(field);

            InvalidOperationException exception = Assert.ThrowsExactly<InvalidOperationException>(() =>
                IntegrationTestConfiguration.FromJson(json.ToJsonString()));

            StringAssert.Contains(exception.Message, field);
            Assert.IsFalse(exception.ToString().Contains("psp-key"),
                "Configuration failures must not expose credential values.");
        }

        [TestMethod]
        [DataRow("null")]
        [DataRow("\"\"")]
        [DataRow("\"  \"")]
        [DataRow("123")]
        [DataRow("true")]
        [DataRow("[]")]
        [DataRow("{}")]
        public void Given_InvalidField_When_Loaded_Then_RejectsConfiguration(string value)
        {
            JsonObject json = ValidConfiguration();
            json["apiKey"] = JsonNode.Parse(value);

            InvalidOperationException exception = Assert.ThrowsExactly<InvalidOperationException>(() =>
                IntegrationTestConfiguration.FromJson(json.ToJsonString()));

            StringAssert.Contains(exception.Message, "apiKey");
        }

        [TestMethod]
        [DataRow("null")]
        [DataRow("[]")]
        [DataRow("\"sensitive-value\"")]
        [DataRow("123")]
        [DataRow("{\"apiKey\":\"sensitive-value\", invalid}")]
        public void Given_InvalidDocument_When_Loaded_Then_DoesNotExposeValues(string json)
        {
            InvalidOperationException exception = Assert.ThrowsExactly<InvalidOperationException>(() =>
                IntegrationTestConfiguration.FromJson(json));

            Assert.IsFalse(exception.ToString().Contains("sensitive-value"),
                "Configuration failures must not expose document values.");
            Assert.IsNull(exception.InnerException, "Parser exceptions must not expose configuration values.");
        }

        [TestMethod]
        public void Given_WhitespaceAndUnknownFields_When_Loaded_Then_TrimsAndIgnores()
        {
            JsonObject json = ValidConfiguration();
            json["merchantAccount"] = " merchant \t";
            json["futureField"] = new JsonObject();

            IntegrationTestConfiguration configuration = IntegrationTestConfiguration.FromJson(json.ToJsonString());

            Assert.AreEqual("merchant", configuration.MerchantAccount);
        }

        [TestMethod]
        public void Given_EmptyObject_When_Loaded_Then_ReportsAllMissingFields()
        {
            InvalidOperationException exception = Assert.ThrowsExactly<InvalidOperationException>(() =>
                IntegrationTestConfiguration.FromJson("{}"));

            foreach (string field in ValidConfiguration().Select(pair => pair.Key))
                StringAssert.Contains(exception.Message, field);
        }
    }
}
