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

namespace Adyen.Test.BalancePlatform.AccountHolders
{
    [TestClass]
    public class AccountHoldersServiceTest
    {
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
                    services.AddAccountHoldersService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();
        }

        [TestMethod]
        public async Task CreateAccountHolderAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/AccountHolder.json");

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<IAccountHoldersService>();

            var accountHolderInfo = new AccountHolderInfo { LegalEntityId = "LE322JV223222D5GG42KN6869" };

            // Act
            ICreateAccountHolderApiResponse response = await service.CreateAccountHolderAsync(accountHolderInfo);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            AccountHolder? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual("AH32272223222B5CM4MWJ892H", result.Id);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/accountHolders", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }

        [TestMethod]
        public async Task GetAccountHolderAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/AccountHolder.json");
            const string accountHolderId = "AH32272223222B5CM4MWJ892H";

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<IAccountHoldersService>();

            // Act
            IGetAccountHolderApiResponse response = await service.GetAccountHolderAsync(accountHolderId);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            AccountHolder? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual(accountHolderId, result.Id);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual($"/bcl/v2/accountHolders/{accountHolderId}", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }

        [TestMethod]
        public async Task GetAllBalanceAccountsOfAccountHolderAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/PaginatedBalanceAccountsResponse.json");
            const string accountHolderId = "AH32272223222B5CTBMZT6W2V";

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<IAccountHoldersService>();

            // Act
            IGetAllBalanceAccountsOfAccountHolderApiResponse response =
                await service.GetAllBalanceAccountsOfAccountHolderAsync(accountHolderId);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            PaginatedBalanceAccountsResponse? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.BalanceAccounts.Count);
            Assert.AreEqual("BA32272223222B5CTDNB66W2Z", result.BalanceAccounts[0].Id);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual($"/bcl/v2/accountHolders/{accountHolderId}/balanceAccounts", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }

        [TestMethod]
        public async Task GetAllTransactionRulesForAccountHolderAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/TransactionRulesResponse.json");
            const string accountHolderId = "AH32272223222B5CM4MWJ892H";

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<IAccountHoldersService>();

            // Act
            IGetAllTransactionRulesForAccountHolderApiResponse response =
                await service.GetAllTransactionRulesForAccountHolderAsync(accountHolderId);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            TransactionRulesResponse? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.TransactionRules.Count);
            Assert.AreEqual("TR3227C223222C5GXR3XP596N", result.TransactionRules[0].Id);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual($"/bcl/v2/accountHolders/{accountHolderId}/transactionRules", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }

        [TestMethod]
        public async Task GetTaxFormAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/GetTaxFormResponse.json");
            const string accountHolderId = "AH32272223222B5CM4MWJ892H";
            const string formType = "US1099k";
            const int year = 2024;

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<IAccountHoldersService>();

            // Act
            IGetTaxFormApiResponse response = await service.GetTaxFormAsync(accountHolderId, formType, year);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            GetTaxFormResponse? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Content);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual($"/bcl/v2/accountHolders/{accountHolderId}/taxForms", capturedRequest.RequestUri?.AbsolutePath);
            string query = capturedRequest.RequestUri!.Query;
            Assert.IsTrue(query.Contains($"formType={formType}"),
                $"Expected 'formType={formType}' in query, but was: {query}");
            Assert.IsTrue(query.Contains($"year={year}"),
                $"Expected 'year={year}' in query, but was: {query}");
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }

        [TestMethod]
        public async Task GetTaxFormSummaryAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/TaxFormSummaryResponse.json");
            const string accountHolderId = "AH32272223222B5CM4MWJ892H";
            const string formType = "US1099k";

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<IAccountHoldersService>();

            // Act
            IGetTaxFormSummaryApiResponse response = await service.GetTaxFormSummaryAsync(accountHolderId, formType);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            TaxFormSummaryResponse? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Data.Count);
            Assert.AreEqual("LE123", result.Data[0].LegalEntityId);
            Assert.AreEqual("LE987", result.Data[1].LegalEntityId);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual($"/bcl/v2/accountHolders/{accountHolderId}/taxFormSummary", capturedRequest.RequestUri?.AbsolutePath);
            string query = capturedRequest.RequestUri!.Query;
            Assert.IsTrue(query.Contains($"formType={formType}"),
                $"Expected 'formType={formType}' in query, but was: {query}");
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }

        [TestMethod]
        public async Task UpdateAccountHolderAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/AccountHolder.json");
            const string accountHolderId = "AH32272223222B5CM4MWJ892H";

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            var service = BuildTestHost(mockHandler).Services.GetRequiredService<IAccountHoldersService>();

            var updateRequest = new AccountHolderUpdateRequest();

            // Act
            IUpdateAccountHolderApiResponse response = await service.UpdateAccountHolderAsync(accountHolderId, updateRequest);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            AccountHolder? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual(accountHolderId, result.Id);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Patch, capturedRequest.Method);
            Assert.AreEqual($"/bcl/v2/accountHolders/{accountHolderId}", capturedRequest.RequestUri?.AbsolutePath);
            Assert.IsTrue(capturedRequest.Headers.TryGetValues("X-API-Key", out var apiKeyValues));
            Assert.AreEqual("test-api-key", apiKeyValues.First());
        }
    }
}
