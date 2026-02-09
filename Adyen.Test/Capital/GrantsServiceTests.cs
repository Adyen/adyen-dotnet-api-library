using System.Net;
using Adyen.Core.Options;

using Microsoft.Extensions.Hosting;

using Adyen.Capital.Client;
using Adyen.Capital.Extensions;
using Adyen.Capital.Models;
using Adyen.Capital.Services;
using Adyen.Core.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace Adyen.Test.Capital
{
    [TestClass]
    public class GrantsServiceTests
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;
        private readonly IGrantsService _grantsService;

        public GrantsServiceTests()
        {
            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureCapital((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                })
                .Build();

            _jsonSerializerOptionsProvider = testHost.Services.GetRequiredService<JsonSerializerOptionsProvider>();
            _grantsService = Substitute.For<IGrantsService>();
        }

        [TestMethod]
        public async Task GetGrantAsync_Success()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/capital/get-grant-success.json");

            var grantId = "GR00000000000000000000001";
            
            _grantsService.GetGrantAsync(
                    Arg.Any<string>(),
                    Arg.Any<RequestOptions>(), 
                    Arg.Any<CancellationToken>())
                .Returns(
                    Task.FromResult<IGetGrantApiResponse>(
                        new GrantsService.GetGrantApiResponse(
                            Substitute.For<Microsoft.Extensions.Logging.ILogger<GrantsService.GetGrantApiResponse>>(),
                            new HttpRequestMessage(),
                            new HttpResponseMessage { StatusCode = HttpStatusCode.OK },
                            json,
                            $"/grants/{grantId}",
                            DateTime.UtcNow,
                            _jsonSerializerOptionsProvider.Options)
                    ));

            // Act
            var response = await _grantsService.GetGrantAsync(grantId);

            // Assert
            Assert.IsTrue(response.IsOk);
            Assert.IsNotNull(response.Ok());
            var grant = response.Ok();
            Assert.AreEqual(grantId, grant.Id);
            Assert.AreEqual("CG00000000000000000000001", grant.GrantAccountId);
            Assert.AreEqual("GO00000000000000000000001", grant.GrantOfferId);
            Assert.AreEqual(Status.CodeEnum.Active, grant.Status.Code);
            Assert.AreEqual("EUR", grant.Balances.Currency);
            Assert.AreEqual(10000, grant.Balances.Principal);
            Assert.AreEqual(1000, grant.Balances.Fee);
            Assert.AreEqual(11000, grant.Balances.Total);
            Assert.AreEqual("AH00000000000000000000001", grant.Counterparty.AccountHolderId);
            Assert.AreEqual("BA00000000000000000000001", grant.Counterparty.BalanceAccountId);
        }

        [TestMethod]
        public async Task GetAllGrantsAsync_Success()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/capital/grants-success.json");

            var counterpartyAccountHolderId = "AH00000000000000000000001";

            _grantsService.GetAllGrantsAsync(
                    Arg.Any<string>(),
                    Arg.Any<RequestOptions>(),
                    Arg.Any<CancellationToken>())
                .Returns(
                    Task.FromResult<IGetAllGrantsApiResponse>(
                        new GrantsService.GetAllGrantsApiResponse(
                            Substitute.For<Microsoft.Extensions.Logging.ILogger<GrantsService.GetAllGrantsApiResponse>>(),
                            new HttpRequestMessage(),
                            new HttpResponseMessage { StatusCode = HttpStatusCode.OK },
                            json,
                            $"/grants?counterpartyAccountHolderId={counterpartyAccountHolderId}",
                            DateTime.UtcNow,
                            _jsonSerializerOptionsProvider.Options)
                    ));

            // Act
            var response = await _grantsService.GetAllGrantsAsync(counterpartyAccountHolderId);

            // Assert
            Assert.IsTrue(response.IsOk);
            Assert.IsNotNull(response.Ok());
            var grants = response.Ok();
            Assert.IsNotNull(grants);
            Assert.AreEqual(1, grants.VarGrants.Count);

            var grant = grants.VarGrants.First();
            Assert.AreEqual("GR00000000000000000000001", grant.Id);
            Assert.AreEqual("CG00000000000000000000001", grant.GrantAccountId);
            Assert.AreEqual("GO00000000000000000000001", grant.GrantOfferId);
            Assert.AreEqual(Status.CodeEnum.Active, grant.Status.Code);
            Assert.AreEqual("EUR", grant.Balances.Currency);
            Assert.AreEqual(10000, grant.Balances.Principal);
            Assert.AreEqual(1000, grant.Balances.Fee);
            Assert.AreEqual(11000, grant.Balances.Total);
            Assert.AreEqual("AH00000000000000000000001", grant.Counterparty.AccountHolderId);
            Assert.AreEqual("BA00000000000000000000001", grant.Counterparty.BalanceAccountId);
        }

        [TestMethod]
        public async Task RequestGrantAsync_Success()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/capital/request-grant.json");

            var grantInfo = new GrantInfo
            {
                GrantAccountId = "0000000000000001",
                GrantOfferId = "0000000000000001"
            };

            _grantsService.RequestGrantAsync(
                    Arg.Any<GrantInfo>(),
                    Arg.Any<RequestOptions>(),
                    Arg.Any<CancellationToken>())
                .Returns(
                    Task.FromResult<IRequestGrantApiResponse>(
                        new GrantsService.RequestGrantApiResponse(
                            Substitute.For<Microsoft.Extensions.Logging.ILogger<GrantsService.RequestGrantApiResponse>>(),
                            new HttpRequestMessage(),
                            new HttpResponseMessage { StatusCode = HttpStatusCode.OK },
                            json,
                            $"/grants",
                            DateTime.UtcNow,
                            _jsonSerializerOptionsProvider.Options)
                    ));

            // Act
            var response = await _grantsService.RequestGrantAsync(grantInfo);

            // Assert
            Assert.IsTrue(response.IsOk);
            Assert.IsNotNull(response.Ok());
            var grant = response.Ok();
            Assert.AreEqual("GR00000000000000000000001", grant.Id);
            Assert.AreEqual("CG00000000000000000000001", grant.GrantAccountId);
            Assert.AreEqual("0000000000000001", grant.GrantOfferId);
            Assert.AreEqual(Status.CodeEnum.Pending, grant.Status.Code);
            Assert.AreEqual("EUR", grant.Balances.Currency);
            Assert.AreEqual(1000000, grant.Balances.Principal);
            Assert.AreEqual(120000, grant.Balances.Fee);
            Assert.AreEqual(1120000, grant.Balances.Total);
            Assert.AreEqual("AH00000000000000000000001", grant.Counterparty.AccountHolderId);
            Assert.AreEqual("BA00000000000000000000001", grant.Counterparty.BalanceAccountId);
        }

        [TestMethod]
        public async Task GetGrantDisbursementAsync_Success()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/capital/get-grant-disbursement-success.json");

            var grantId = "GR00000000000000000000001";
            var disbursementId = "DI00000000000000000000001";

            _grantsService.GetGrantDisbursementAsync(
                    Arg.Any<string>(),
                    Arg.Any<string>(),
                    Arg.Any<RequestOptions>(),
                    Arg.Any<CancellationToken>())
                .Returns(
                    Task.FromResult<IGetGrantDisbursementApiResponse>(
                        new GrantsService.GetGrantDisbursementApiResponse(
                            Substitute.For<Microsoft.Extensions.Logging.ILogger<GrantsService.GetGrantDisbursementApiResponse>>(),
                            new HttpRequestMessage(),
                            new HttpResponseMessage { StatusCode = HttpStatusCode.OK },
                            json,
                            $"/grants/{grantId}/disbursements/{disbursementId}",
                            DateTime.UtcNow,
                            _jsonSerializerOptionsProvider.Options)
                    ));

            // Act
            var response = await _grantsService.GetGrantDisbursementAsync(grantId, disbursementId);

            // Assert
            Assert.IsTrue(response.IsOk);
            Assert.IsNotNull(response.Ok());
            var disbursement = response.Ok();
            Assert.AreEqual("DI00000000000000000000001", disbursement.Id);
            Assert.AreEqual("GR00000000000000000000001", disbursement.GrantId);
            Assert.AreEqual("AH00000000000000000000001", disbursement.AccountHolderId);
            Assert.AreEqual("BA00000000000000000000001", disbursement.BalanceAccountId);
            Assert.AreEqual("EUR", disbursement.Amount.Currency);
            Assert.AreEqual(10000, disbursement.Amount.Value);
            Assert.AreEqual("EUR", disbursement.Fee.Amount.Currency);
            Assert.AreEqual(1000, disbursement.Fee.Amount.Value);
            Assert.AreEqual("EUR", disbursement.Balances.Currency);
            Assert.AreEqual(10000, disbursement.Balances.Principal);
            Assert.AreEqual(1000, disbursement.Balances.Fee);
            Assert.AreEqual(11000, disbursement.Balances.Total);
            Assert.AreEqual(1000, disbursement.Repayment.BasisPoints);
            Assert.AreEqual("string", disbursement.Repayment.UpdateDescription);
        }
    }
}
