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
    public class AccountHoldersServiceIntegrationTest : BaseIntegrationTest
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
                        config.ConfigureAdyenOptions(options =>
                        {
                            options.AdyenApiKey = BclApiKey;
                            options.Environment = AdyenEnvironment.Test;
                        });
                        services.AddAccountHoldersService();
                    })
                .Build();

            _accountHoldersService = _host.Services.GetRequiredService<IAccountHoldersService>();

            _logger = _host.Services.GetRequiredService<ILogger<IAccountHoldersService>>();
            _accountHolderId = AccountHolderId;
        }

        [TestMethod]
        public async Task Given_AccountHoldersService_When_CreateAccountHolder_Returns_OK()
        {
            var legalEntityId = LegalEntityId;

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
        [Ignore("The configured account holder's US1099k tax-form summary returns HTTP 404.")]
        public async Task Given_AccountHoldersService_When_GetTaxFormSummary_Returns_OK()
        {
            IGetTaxFormSummaryApiResponse response =
                await _accountHoldersService.GetTaxFormSummaryAsync(_accountHolderId, "US1099k");

            _logger.LogInformation(response.RawContent);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
