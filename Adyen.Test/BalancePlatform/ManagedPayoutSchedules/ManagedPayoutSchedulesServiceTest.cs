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

namespace Adyen.Test.BalancePlatform.ManagedPayoutSchedules
{
    [TestClass]
    public class ManagedPayoutSchedulesServiceTest
    {
        private const string BalanceAccountId = "BA000000000000000000001";
        private const string ScheduleId = "PSAC00000000000000000000000001";
        private const string BalancePlatformId = "YOUR_BALANCE_PLATFORM";

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
                    services.AddManagedPayoutSchedulesService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();
        }

        [TestMethod]
        public async Task GetBalanceAccountManagedSchedulesAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/BalanceAccountConfigurations.json");

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<IManagedPayoutSchedulesService>();

            // Act
            IGetBalanceAccountManagedSchedulesApiResponse response =
                await service.GetBalanceAccountManagedSchedulesAsync(BalanceAccountId);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            BalanceAccountConfigurations? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.BalanceAccountPayoutSchedules.Count);
            Assert.AreEqual(ScheduleId, result.BalanceAccountPayoutSchedules[0].Id);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual($"/bcl/v2/balanceAccounts/{BalanceAccountId}/payoutSchedules", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }

        [TestMethod]
        public async Task ApplyManagedScheduleAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/BalanceAccountConfiguration.json");

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<IManagedPayoutSchedulesService>();
            var request = new BalanceAccountConfigurationRequest
            {
                BalancePlatformPayoutScheduleId = "PSPC00000000000000000000000001",
                TransferInstrumentId = "SE00000000000000000000001",
                Frequency = BalanceAccountConfigurationRequest.FrequencyEnum.Monthly
            };

            // Act
            IApplyManagedScheduleApiResponse response =
                await service.ApplyManagedScheduleAsync(BalanceAccountId, request);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            BalanceAccountConfiguration? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual(ScheduleId, result.Id);
            Assert.AreEqual(BalanceAccountId, result.BalanceAccountId);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.AreEqual($"/bcl/v2/balanceAccounts/{BalanceAccountId}/payoutSchedules", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }

        [TestMethod]
        public async Task GetBalanceAccountManagedScheduleByIdAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/BalanceAccountConfiguration.json");

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<IManagedPayoutSchedulesService>();

            // Act
            IGetBalanceAccountManagedScheduleByIdApiResponse response =
                await service.GetBalanceAccountManagedScheduleByIdAsync(BalanceAccountId, ScheduleId);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            BalanceAccountConfiguration? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual(ScheduleId, result.Id);
            Assert.AreEqual("EUR", result.Currency);
            Assert.AreEqual("Monthly payout", result.Reference);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual($"/bcl/v2/balanceAccounts/{BalanceAccountId}/payoutSchedules/{ScheduleId}", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }

        [TestMethod]
        public async Task DeleteBalanceAccountManagedScheduleAsync_Returns204NoContent_WithCorrectVerbAndPath()
        {
            // Arrange
            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.NoContent);
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<IManagedPayoutSchedulesService>();

            // Act
            IDeleteBalanceAccountManagedScheduleApiResponse response =
                await service.DeleteBalanceAccountManagedScheduleAsync(BalanceAccountId, ScheduleId);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsNoContent);
            Assert.AreEqual(HttpStatusCode.NoContent, response.StatusCode);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Delete, capturedRequest.Method);
            Assert.AreEqual($"/bcl/v2/balanceAccounts/{BalanceAccountId}/payoutSchedules/{ScheduleId}", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }

        [TestMethod]
        public async Task UpdateBalanceAccountManagedScheduleAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/BalanceAccountConfigurationUpdated.json");

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<IManagedPayoutSchedulesService>();
            var update = new BalanceAccountConfigurationUpdate
            {
                Description = "Updated payout description",
                Enabled = false,
                RetainedAmount = 20000
            };

            // Act
            IUpdateBalanceAccountManagedScheduleApiResponse response =
                await service.UpdateBalanceAccountManagedScheduleAsync(BalanceAccountId, ScheduleId, update);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            BalanceAccountConfiguration? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual(ScheduleId, result.Id);
            Assert.AreEqual("Updated payout description", result.Description);
            Assert.AreEqual(false, result.Enabled);
            Assert.AreEqual(20000, result.RetainedAmount);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Patch, capturedRequest.Method);
            Assert.AreEqual($"/bcl/v2/balanceAccounts/{BalanceAccountId}/payoutSchedules/{ScheduleId}", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }

        [TestMethod]
        public async Task GetPayoutScheduleExecutionsAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/PayoutScheduleExecutions.json");

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<IManagedPayoutSchedulesService>();

            // Act
            IGetPayoutScheduleExecutionsApiResponse response =
                await service.GetPayoutScheduleExecutionsAsync(BalanceAccountId, ScheduleId, offset: 1);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            PayoutScheduleExecutions? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.VarPayoutScheduleExecutions.Count);
            Assert.AreEqual("PS0000000000001", result.VarPayoutScheduleExecutions[0].Id);
            Assert.AreEqual(ExecutionResult.Skipped, result.VarPayoutScheduleExecutions[0].Result);
            Assert.AreEqual("PS0000000000002", result.VarPayoutScheduleExecutions[1].Id);
            Assert.AreEqual(ExecutionResult.Succeeded, result.VarPayoutScheduleExecutions[1].Result);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual($"/bcl/v2/balanceAccounts/{BalanceAccountId}/payoutSchedules/{ScheduleId}/executions", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }

        [TestMethod]
        public async Task GetBalancePlatformManagedSchedulesAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent("{}", Encoding.UTF8, "application/json")
                };
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<IManagedPayoutSchedulesService>();

            // Act
            IGetBalancePlatformManagedSchedulesApiResponse response =
                await service.GetBalancePlatformManagedSchedulesAsync(BalancePlatformId);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual($"/bcl/v2/balancePlatforms/{BalancePlatformId}/payoutSchedules", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }

        [TestMethod]
        public async Task GetBalancePlatformManagedScheduleByIdAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent("{}", Encoding.UTF8, "application/json")
                };
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<IManagedPayoutSchedulesService>();

            // Act
            IGetBalancePlatformManagedScheduleByIdApiResponse response =
                await service.GetBalancePlatformManagedScheduleByIdAsync(BalancePlatformId, "PSPC00000000000000000000000001");

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual($"/bcl/v2/balancePlatforms/{BalancePlatformId}/payoutSchedules/PSPC00000000000000000000000001", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }
    }
}
