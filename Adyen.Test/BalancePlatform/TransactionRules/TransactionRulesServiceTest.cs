using System.Linq;
using System.Net;
using System.Text;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.TransactionRules
{
    [TestClass]
    public class TransactionRulesServiceTest
    {
        private const string TransactionRuleId = "TR3227C223222H5J4D9ML9V4D";

        private static IHost BuildTestHost(MockDelegatingHandler mockHandler)
        {
            return Host.CreateDefaultBuilder()
                .ConfigureBalancePlatform((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                        options.AdyenApiKey = "test-api-key";
                    });
                    services.AddTransactionRulesService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();
        }

        private static TransactionRuleInfo BuildTransactionRuleInfo() => new()
        {
            Description = "Allow only point-of-sale transactions",
            Reference = "YOUR_REFERENCE_4F7346",
            EntityKey = new TransactionRuleEntityKey { EntityType = "paymentInstrument", EntityReference = "PI3227C223222B5FG88SB8BHR" },
            Interval = new TransactionRuleInterval { Type = TransactionRuleInterval.TypeEnum.PerTransaction },
            RuleRestrictions = new TransactionRuleRestrictions
            {
                ProcessingTypes = new ProcessingTypesRestriction { Operation = "noneMatch" }
            },
            Type = TransactionRuleInfo.TypeEnum.BlockList
        };

        [TestMethod]
        public async Task CreateTransactionRuleAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/TransactionRuleWithId.json");

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<ITransactionRulesService>();

            // Act
            ICreateTransactionRuleApiResponse response =
                await service.CreateTransactionRuleAsync(BuildTransactionRuleInfo());

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            TransactionRule? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual(TransactionRuleId, result.Id);
            Assert.AreEqual("Allow only point-of-sale transactions", result.Description);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/transactionRules", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }

        [TestMethod]
        public async Task GetTransactionRuleAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/TransactionRuleResponse.json");

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<ITransactionRulesService>();

            // Act
            IGetTransactionRuleApiResponse response =
                await service.GetTransactionRuleAsync("TR32272223222B5GFSGFLFCHM");

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            TransactionRuleResponse? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual("TR32272223222B5GFSGFLFCHM", result.TransactionRule.Id);
            Assert.AreEqual(TransactionRuleInterval.TypeEnum.PerTransaction, result.TransactionRule.Interval.Type);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/transactionRules/TR32272223222B5GFSGFLFCHM", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }

        [TestMethod]
        public async Task UpdateTransactionRuleAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/TransactionRuleWithId.json");

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<ITransactionRulesService>();

            // Act
            IUpdateTransactionRuleApiResponse response =
                await service.UpdateTransactionRuleAsync(TransactionRuleId, BuildTransactionRuleInfo());

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            TransactionRule? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual(TransactionRuleId, result.Id);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Patch, capturedRequest.Method);
            Assert.AreEqual($"/bcl/v2/transactionRules/{TransactionRuleId}", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }

        [TestMethod]
        public async Task DeleteTransactionRuleAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/TransactionRuleWithId.json");

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<ITransactionRulesService>();

            // Act
            IDeleteTransactionRuleApiResponse response =
                await service.DeleteTransactionRuleAsync(TransactionRuleId);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            TransactionRule? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual(TransactionRuleId, result.Id);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Delete, capturedRequest.Method);
            Assert.AreEqual($"/bcl/v2/transactionRules/{TransactionRuleId}", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }
    }
}
