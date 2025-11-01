using System.Text.Json;
using Adyen.BalancePlatform.Client;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.TransactionRules
{
    [TestClass]
    public class TransactionRuleTest : BaseTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public TransactionRuleTest()
        {
            IHost host = Host.CreateDefaultBuilder()
            .ConfigureBalancePlatform((context, services, config) =>
            {
                config.ConfigureAdyenOptions(options =>
                {
                    options.AdyenApiKey = context.Configuration["ADYEN_API_KEY"];
                    options.Environment = AdyenEnvironment.Test;
                });
            })
            .Build();

            _jsonSerializerOptionsProvider = host.Services.GetRequiredService<JsonSerializerOptionsProvider>();
        }
        
        [TestMethod]
        public async Task Given_TransactionRule_Serialize_Correctly()
        {
            // Arrange
            var target = new TransactionRule(
                description: "Allow only point-of-sale transactions",
                reference: "YOUR_REFERENCE_4F7346",
                entityKey: new TransactionRuleEntityKey(entityType: "paymentInstrument", entityReference: "PI3227C223222B5BPCMFXD2XG"),
                status: TransactionRule.StatusEnum.Active,
                interval: new TransactionRuleInterval("perTransaction"),
                ruleRestrictions: new TransactionRuleRestrictions(
                    processingTypes: new ProcessingTypesRestriction(
                        operation: "noneMatch",
                        value: new List<ProcessingTypesRestriction.ValueEnum>
                        {
                            ProcessingTypesRestriction.ValueEnum.Pos, 
                            ProcessingTypesRestriction.ValueEnum.Ecommerce
                        })
                    ),
                type: "blockList"
            );
            
            // Act
            string result = JsonSerializer.Serialize(target, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            JsonDocument jsonDoc = JsonDocument.Parse(result);
            JsonElement root = jsonDoc.RootElement;
            
            Assert.AreEqual("Allow only point-of-sale transactions", root.GetProperty("description").GetString());
            Assert.AreEqual("YOUR_REFERENCE_4F7346", root.GetProperty("reference").GetString());

            JsonElement entityKey = root.GetProperty("entityKey");
            Assert.AreEqual("paymentInstrument", entityKey.GetProperty("entityType").GetString());
            Assert.AreEqual("PI3227C223222B5BPCMFXD2XG", entityKey.GetProperty("entityReference").GetString());
            Assert.AreEqual("active", root.GetProperty("status").GetString());

            JsonElement interval = root.GetProperty("interval");
            Assert.AreEqual("perTransaction", interval.GetProperty("type").GetString());

            JsonElement processingTypes = root.GetProperty("ruleRestrictions").GetProperty("processingTypes");
            Assert.AreEqual("noneMatch", processingTypes.GetProperty("operation").GetString());
            
            JsonElement.ArrayEnumerator values = processingTypes.GetProperty("value").EnumerateArray();
            Assert.IsTrue(values.Any(v => v.GetString() == "pos") && values.Any(v => v.GetString() == "ecommerce"));
            Assert.AreEqual("blockList", root.GetProperty("type").GetString());
        }
        
        [TestMethod]
        public async Task Given_TransactionRule_Deserialize_Correctly()
        {
            // Arrange
            string json =  TestUtilities.GetTestFileContent("mocks/balanceplatform/TransactionRule.json");
            
            // Act
            var response = JsonSerializer.Deserialize<TransactionRule>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(response.EntityKey.EntityReference, "PI3227C223222B5BPCMFXD2XG");
            Assert.AreEqual(response.EntityKey.EntityType, "paymentInstrument");
            Assert.AreEqual(response.Interval.Type, TransactionRuleInterval.TypeEnum.PerTransaction);
            Assert.AreEqual(response.RuleRestrictions.ProcessingTypes.Operation, "noneMatch");
        }
        
        [TestMethod]
        public async Task Given_TransactionRuleResponse_Deserialize_Correctly()
        {
            // Arrange
            string json =  TestUtilities.GetTestFileContent("mocks/balanceplatform/TransactionRuleResponse.json");
            
            // Act
            var response = JsonSerializer.Deserialize<TransactionRuleResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(response.TransactionRule.Id, "TR32272223222B5GFSGFLFCHM");
            Assert.AreEqual(response.TransactionRule.Interval.Type, TransactionRuleInterval.TypeEnum.PerTransaction);
            Assert.AreEqual(response.TransactionRule.RuleRestrictions.ProcessingTypes.Operation, "noneMatch");
        }
    }
}