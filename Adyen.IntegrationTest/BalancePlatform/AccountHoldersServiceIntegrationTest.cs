using System.Net;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Hosting;
using Adyen.Core.Options;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;
using Microsoft.Extensions.Logging;

namespace Adyen.IntegrationTest.BalancePlatform
{
    [TestClass]
    public class AccountHoldersServiceIntegrationTest
    {
        private readonly IAccountHoldersService _accountHoldersService;
        private readonly IHost _host;
        private readonly ILogger _logger;
        private readonly string _accountHolderId;

        public AccountHoldersServiceIntegrationTest()
        {
            _host = Host.CreateDefaultBuilder()
                .ConfigureBalancePlatform(
                    (context, services, config) =>
                    {
                        Assert.IsNotNull(context.Configuration["BCL_API_KEY"], "env var BCL_API_KEY is undefined");
                        
                        config.ConfigureAdyenOptions(options =>
                        {
                            options.AdyenApiKey = context.Configuration["BCL_API_KEY"];
                            options.Environment = AdyenEnvironment.Test;
                        });
                        services.AddAccountHoldersService();
                    })
                .Build();

            _accountHoldersService = _host.Services.GetRequiredService<IAccountHoldersService>();

            _logger = _host.Services.GetRequiredService<ILogger<IAccountHoldersService>>();
            _accountHolderId = Environment.GetEnvironmentVariable("ACCOUNT_HOLDER_ID") ?? "AH00000001";
        }

        [TestMethod]
        public async Task Given_AccountHoldersService_When_CreateAccountHolder_Returns_OK()
        {
            var legalEntityId = Environment.GetEnvironmentVariable("LEGAL_ENTITY_ID");
            Assert.IsNotNull(legalEntityId, "env var LEGAL_ENTITY_ID is null");

            var request = new AccountHolderInfo
            {
                LegalEntityId = legalEntityId
            };

            ICreateAccountHolderApiResponse response =
                await _accountHoldersService.CreateAccountHolderAsync(request);

            _logger.LogInformation(response.RawContent);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            response.TryDeserializeOkResponse(out var result);
            Assert.IsNotNull(result?.Id);
        }

        [TestMethod]
        public async Task Given_AccountHoldersService_When_GetAccountHolder_Returns_OK()
        {
            IGetAccountHolderApiResponse response =
                await _accountHoldersService.GetAccountHolderAsync(_accountHolderId);

            _logger.LogInformation(response.RawContent);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            response.TryDeserializeOkResponse(out var result);
            Assert.IsNotNull(result?.Id);
        }

        [TestMethod]
        public async Task Given_AccountHoldersService_When_GetAllBalanceAccountsOfAccountHolder_Returns_OK()
        {
            IGetAllBalanceAccountsOfAccountHolderApiResponse response =
                await _accountHoldersService.GetAllBalanceAccountsOfAccountHolderAsync(_accountHolderId);

            _logger.LogInformation(response.RawContent);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            response.TryDeserializeOkResponse(out var result);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task Given_AccountHoldersService_When_GetAllTransactionRulesForAccountHolder_Returns_OK()
        {
            IGetAllTransactionRulesForAccountHolderApiResponse response =
                await _accountHoldersService.GetAllTransactionRulesForAccountHolderAsync(_accountHolderId);

            _logger.LogInformation(response.RawContent);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            response.TryDeserializeOkResponse(out var result);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task Given_AccountHoldersService_When_UpdateAccountHolder_Returns_OK()
        {
            var request = new AccountHolderUpdateRequest
            {
                Description = "Updated via integration test"
            };

            IUpdateAccountHolderApiResponse response =
                await _accountHoldersService.UpdateAccountHolderAsync(_accountHolderId, request);

            _logger.LogInformation(response.RawContent);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            response.TryDeserializeOkResponse(out var result);
            Assert.IsNotNull(result?.Id);
        }

        [TestMethod]
        public async Task Given_AccountHoldersService_When_GetTaxFormSummary_Returns_OK()
        {
            IGetTaxFormSummaryApiResponse response =
                await _accountHoldersService.GetTaxFormSummaryAsync(_accountHolderId, "US1099k");

            _logger.LogInformation(response.RawContent);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
