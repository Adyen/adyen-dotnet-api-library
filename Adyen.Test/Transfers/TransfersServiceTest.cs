using System.Net;
using System.Text;
using Adyen.Core.Options;
using Adyen.Transfers.Client;
using Adyen.Transfers.Extensions;
using Adyen.Transfers.Models;
using Adyen.Transfers.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.Transfers
{
    [TestClass]
    public class TransfersServiceTest
    {
        [TestMethod]
        public async Task TransferFundsAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/transfers/transfer-funds.json");

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureTransfers((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddTransfersService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var transfersService = testHost.Services.GetRequiredService<ITransfersService>();
            var transferInfo = new TransferInfo
            {
                Amount = new Amount { Currency = "EUR", Value = 110000 },
                Category = TransferInfo.CategoryEnum.Bank,
                Counterparty = new CounterpartyInfoV3()
            };

            // Act
            var response = await transfersService.TransferFundsAsync(transferInfo);

            // Assert - response
            Assert.IsTrue(response.TryDeserializeOkResponse(out var transfer));
            Assert.IsFalse(response.IsAccepted);
            Assert.IsNotNull(transfer);
            Assert.AreEqual("1W1UG35U8A9J5ZLG", transfer.Id);
            Assert.AreEqual(Transfer.StatusEnum.Authorised, transfer.Status);
            Assert.AreEqual(Transfer.CategoryEnum.Bank, transfer.Category);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.IsNotNull(capturedRequest.RequestUri);
            Assert.AreEqual("/btl/v4/transfers", capturedRequest.RequestUri.AbsolutePath);
        }

        [TestMethod]
        public async Task TransferFundsAsync_Returns202Accepted_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/transfers/transfer-funds.json");

            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.Accepted)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            });

            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureTransfers((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddTransfersService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var transfersService = testHost.Services.GetRequiredService<ITransfersService>();
            var transferInfo = new TransferInfo
            {
                Amount = new Amount { Currency = "EUR", Value = 110000 },
                Category = TransferInfo.CategoryEnum.Bank,
                Counterparty = new CounterpartyInfoV3()
            };

            // Act
            var response = await transfersService.TransferFundsAsync(transferInfo);

            // Assert - response
            Assert.IsFalse(response.IsOk);
            Assert.IsTrue(response.TryDeserializeAcceptedResponse(out var transfer));
            Assert.IsNotNull(transfer);
            Assert.AreEqual("1W1UG35U8A9J5ZLG", transfer.Id);
            Assert.AreEqual(Transfer.StatusEnum.Authorised, transfer.Status);
            Assert.AreEqual(Transfer.CategoryEnum.Bank, transfer.Category);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.IsNotNull(capturedRequest.RequestUri);
            Assert.AreEqual("/btl/v4/transfers", capturedRequest.RequestUri.AbsolutePath);
        }

    }
}
