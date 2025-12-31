using System.Net;
using Adyen.Core;
using Adyen.Core.Client;
using Adyen.Core.Options;
using Adyen.LegalEntityManagement.Client;
using Adyen.LegalEntityManagement.Extensions;
using Adyen.LegalEntityManagement.Models;
using Adyen.LegalEntityManagement.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace Adyen.Test.LegalEntityManagement.TransferInstruments
{
    [TestClass]
    public class TransferInstrumentsTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;
        private readonly ITransferInstrumentsService _transferInstrumentsService;

        public TransferInstrumentsTest()
        {
            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureLegalEntityManagement((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });
                })
                .Build();
            _jsonSerializerOptionsProvider = testHost.Services.GetRequiredService<JsonSerializerOptionsProvider>();
            _transferInstrumentsService = Substitute.For<ITransferInstrumentsService>();
        }

        [TestMethod]
        public async Task CreateTransferInstrumentAsyncTest()
        {
            // Arrange
            var json = TestUtilities.GetTestFileContent("mocks/legalentitymanagement/TransferInstrument.json");
            var transferInstrumentInfo = new TransferInstrumentInfo();

            _transferInstrumentsService.CreateTransferInstrumentAsync(
                    Arg.Any<TransferInstrumentInfo>(),
                    Arg.Any<RequestOptions>(),
                    Arg.Any<CancellationToken>())
                .Returns(
                    Task.FromResult<ICreateTransferInstrumentApiResponse>(
                        new TransferInstrumentsService.CreateTransferInstrumentApiResponse(
                            Substitute.For<Microsoft.Extensions.Logging.ILogger<TransferInstrumentsService.CreateTransferInstrumentApiResponse>>(),
                            new HttpRequestMessage(),
                            new HttpResponseMessage { StatusCode = HttpStatusCode.OK },
                            json,
                            "/transferInstruments",
                            DateTime.UtcNow,
                            _jsonSerializerOptionsProvider.Options)
                    ));

            // Act
            var response = await _transferInstrumentsService.CreateTransferInstrumentAsync(new Option<TransferInstrumentInfo>(transferInstrumentInfo), new RequestOptions().AddxRequestedVerificationCodeHeader("x-requested-verification-code"), CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            var transferInstrument = response.Ok();
            Assert.IsNotNull(transferInstrument);
            Assert.AreEqual("SE576BH223222F5GJVKHH6BDT", transferInstrument.Id);
            Assert.AreEqual("LE322KH223222D5GG4C9J83RN", transferInstrument.LegalEntityId);
        }

        [TestMethod]
        public async Task GetTransferInstrumentAsyncTest()
        {
            // Arrange
            var json = TestUtilities.GetTestFileContent("mocks/legalentitymanagement/TransferInstrument.json");
            var transferInstrumentId = "SE576BH223222F5GJVKHH6BDT";

            _transferInstrumentsService.GetTransferInstrumentAsync(
                    Arg.Any<string>(),
                    Arg.Any<RequestOptions>(),
                    Arg.Any<CancellationToken>())
                .Returns(
                    Task.FromResult<IGetTransferInstrumentApiResponse>(
                        new TransferInstrumentsService.GetTransferInstrumentApiResponse(
                            Substitute.For<Microsoft.Extensions.Logging.ILogger<TransferInstrumentsService.GetTransferInstrumentApiResponse>>(),
                            new HttpRequestMessage(),
                            new HttpResponseMessage { StatusCode = HttpStatusCode.OK },
                            json,
                            $"/transferInstruments/{transferInstrumentId}",
                            DateTime.UtcNow,
                            _jsonSerializerOptionsProvider.Options)
                    ));

            // Act
            var response = await _transferInstrumentsService.GetTransferInstrumentAsync(transferInstrumentId, new RequestOptions(), CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            var transferInstrument = response.Ok();
            Assert.IsNotNull(transferInstrument);
            Assert.AreEqual(transferInstrumentId, transferInstrument.Id);
        }

        [TestMethod]
        public async Task UpdateTransferInstrumentAsyncTest()
        {
            // Arrange
            var json = TestUtilities.GetTestFileContent("mocks/legalentitymanagement/TransferInstrument.json");
            var transferInstrumentId = "SE576BH223222F5GJVKHH6BDT";
            var transferInstrumentInfo = new TransferInstrumentInfo();

            _transferInstrumentsService.UpdateTransferInstrumentAsync(
                    Arg.Any<string>(),
                    Arg.Any<TransferInstrumentInfo>(),
                    Arg.Any<RequestOptions>(),
                    Arg.Any<CancellationToken>())
                .Returns(
                    Task.FromResult<IUpdateTransferInstrumentApiResponse>(
                        new TransferInstrumentsService.UpdateTransferInstrumentApiResponse(
                            Substitute.For<Microsoft.Extensions.Logging.ILogger<TransferInstrumentsService.UpdateTransferInstrumentApiResponse>>(),
                            new HttpRequestMessage(),
                            new HttpResponseMessage { StatusCode = HttpStatusCode.OK },
                            json,
                            $"/transferInstruments/{transferInstrumentId}",
                            DateTime.UtcNow,
                            _jsonSerializerOptionsProvider.Options)
                    ));

            // Act
            var response = await _transferInstrumentsService.UpdateTransferInstrumentAsync(transferInstrumentId, new Option<TransferInstrumentInfo>(transferInstrumentInfo), new RequestOptions().AddxRequestedVerificationCodeHeader("x-requested-verification-code"), CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            var transferInstrument = response.Ok();
            Assert.IsNotNull(transferInstrument);
            Assert.AreEqual(transferInstrumentId, transferInstrument.Id);
        }

        [TestMethod]
        public async Task DeleteTransferInstrumentAsyncTest()
        {
            // Arrange
            var transferInstrumentId = "SE576BH223222F5GJVKHH6BDT";

            _transferInstrumentsService.DeleteTransferInstrumentAsync(
                    Arg.Any<string>(),
                    Arg.Any<RequestOptions>(),
                    Arg.Any<CancellationToken>())
                .Returns(
                    Task.FromResult<IDeleteTransferInstrumentApiResponse>(
                        new TransferInstrumentsService.DeleteTransferInstrumentApiResponse(
                            Substitute.For<Microsoft.Extensions.Logging.ILogger<TransferInstrumentsService.DeleteTransferInstrumentApiResponse>>(),
                            new HttpRequestMessage(),
                            new HttpResponseMessage { StatusCode = HttpStatusCode.NoContent },
                            "",
                            $"/transferInstruments/{transferInstrumentId}",
                            DateTime.UtcNow,
                            _jsonSerializerOptionsProvider.Options)
                    ));

            // Act
            var response = await _transferInstrumentsService.DeleteTransferInstrumentAsync(transferInstrumentId);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.NoContent, response.StatusCode);
            Assert.IsTrue(response.IsNoContent);
        }
    }
}
