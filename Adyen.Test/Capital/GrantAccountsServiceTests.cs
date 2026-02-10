using System.Net;
using Adyen.Core;
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
    public class GrantsAccountsServiceTests
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;
        private readonly IGrantAccountsService _grantAccountsService;

        public GrantsAccountsServiceTests()
        {
            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureCapital((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                })
                .Build();

            _jsonSerializerOptionsProvider = testHost.Services.GetRequiredService<JsonSerializerOptionsProvider>();
            _grantAccountsService = Substitute.For<IGrantAccountsService>();
        }

        [TestMethod]
        public async Task GetGrantAccountInformationAsync_Success()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/capital/get-grant-account-success.json");

            var id = "GA000000011111";
            
            _grantAccountsService.GetGrantAccountInformationAsync(
                    Arg.Any<string>(),
                    Arg.Any<RequestOptions?>(), 
                    Arg.Any<CancellationToken>())
                .Returns(
                    Task.FromResult<IGetGrantAccountInformationApiResponse>(
                        new GrantAccountsService.GetGrantAccountInformationApiResponse(
                            Substitute.For<Microsoft.Extensions.Logging.ILogger<GrantAccountsService.GetGrantAccountInformationApiResponse>>(),
                            new HttpRequestMessage(),
                            new HttpResponseMessage { StatusCode = HttpStatusCode.OK },
                            json,
                            $"/grantAccounts/{id}",
                            DateTime.UtcNow,
                            _jsonSerializerOptionsProvider.Options)
                    ));

            // Act
            var response = await _grantAccountsService.GetGrantAccountInformationAsync(id);

            // Assert
            Assert.IsTrue(response.IsOk);
            Assert.IsNotNull(response.Ok());
            var grantOffers = response.Ok();
            //Assert.AreEqual(1, grantOffers.VarGrantOffers.Count);
            //Assert.AreEqual("GO00000000000000000000001", grantOffers.VarGrantOffers[0].Id);
            //Assert.AreEqual("AH00000000000001", grantOffers.VarGrantOffers[0].AccountHolderId);
        }

    }
}
