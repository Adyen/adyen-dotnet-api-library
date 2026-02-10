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
    public class GrantsOffersServiceTests
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;
        private readonly IGrantOffersService _grantsOffersService;

        public GrantsOffersServiceTests()
        {
            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureCapital((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                })
                .Build();

            _jsonSerializerOptionsProvider = testHost.Services.GetRequiredService<JsonSerializerOptionsProvider>();
            _grantsOffersService = Substitute.For<IGrantOffersService>();
        }

        [TestMethod]
        public async Task GetAllGrantOffersAsync_Success()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/capital/grant-offers-success.json");

            var accountHolderId = "AH00000000000001";
            
            _grantsOffersService.GetAllGrantOffersAsync(
                    Arg.Any<Option<string>>(),
                    Arg.Any<RequestOptions?>(), 
                    Arg.Any<CancellationToken>())
                .Returns(
                    Task.FromResult<IGetAllGrantOffersApiResponse>(
                        new GrantOffersService.GetAllGrantOffersApiResponse(
                            Substitute.For<Microsoft.Extensions.Logging.ILogger<GrantOffersService.GetAllGrantOffersApiResponse>>(),
                            new HttpRequestMessage(),
                            new HttpResponseMessage { StatusCode = HttpStatusCode.OK },
                            json,
                            $"/grantOffers?accountHolderId={accountHolderId}",
                            DateTime.UtcNow,
                            _jsonSerializerOptionsProvider.Options)
                    ));

            // Act
            var response = await _grantsOffersService.GetAllGrantOffersAsync(accountHolderId);

            // Assert
            Assert.IsTrue(response.IsOk);
            Assert.IsNotNull(response.Ok());
            var grantOffers = response.Ok();
            Assert.AreEqual(1, grantOffers.VarGrantOffers.Count);
            Assert.AreEqual("GO00000000000000000000001", grantOffers.VarGrantOffers[0].Id);
            Assert.AreEqual("AH00000000000001", grantOffers.VarGrantOffers[0].AccountHolderId);
        }

    }
}
