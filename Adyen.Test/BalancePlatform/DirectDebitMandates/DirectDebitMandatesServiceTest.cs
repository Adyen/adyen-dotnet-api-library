using System.Net;
using System.Text;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.DirectDebitMandates
{
    [TestClass]
    public class DirectDebitMandatesServiceTest
    {
        public DirectDebitMandatesServiceTest() { }

        [TestMethod]
        public async Task GetListOfMandatesAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/ListMandatesResponse.json");

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
                .ConfigureBalancePlatform((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddDirectDebitMandatesService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var directDebitMandatesService = testHost.Services.GetRequiredService<IDirectDebitMandatesService>();

            // Act
            IGetListOfMandatesApiResponse response = await directDebitMandatesService.GetListOfMandatesAsync(
                new Adyen.Core.Option<string>("BA43EKD334339T6N8X655DW77"));

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            ListMandatesResponse? result = response.Ok();
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Mandates.Count);
            Assert.AreEqual("MNDT7QXPLKT9R333640TX334709E", result.Mandates[0].Id);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/mandates", capturedRequest.RequestUri?.AbsolutePath);
        }

        [TestMethod]
        public async Task GetMandateByIdAsync_Returns200Ok_WithCorrectVerbAndPath()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/Mandate.json");

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
                .ConfigureBalancePlatform((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddDirectDebitMandatesService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var directDebitMandatesService = testHost.Services.GetRequiredService<IDirectDebitMandatesService>();

            // Act
            IGetMandateByIdApiResponse response = await directDebitMandatesService.GetMandateByIdAsync("MNDT7QXPLKT9R333640TX334709E");

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Mandate? mandate = response.Ok();
            Assert.IsNotNull(mandate);
            Assert.AreEqual("MNDT7QXPLKT9R333640TX334709E", mandate.Id);
            Assert.AreEqual(MandateType.Bacs, mandate.Type);
            Assert.AreEqual(MandateStatus.Approved, mandate.Status);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/mandates/MNDT7QXPLKT9R333640TX334709E", capturedRequest.RequestUri?.AbsolutePath);
        }

        [TestMethod]
        public async Task UpdateMandateAsync_Returns202Accepted_WithCorrectVerbAndPath()
        {
            // Arrange
            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.Accepted);
            });

            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureBalancePlatform((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddDirectDebitMandatesService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var directDebitMandatesService = testHost.Services.GetRequiredService<IDirectDebitMandatesService>();
            var mandateUpdate = new MandateUpdate { PaymentInstrumentId = "PI43EKK334339T6N8X65688CS" };

            // Act
            IUpdateMandateApiResponse response = await directDebitMandatesService.UpdateMandateAsync(
                "MNDT7QXPLKT9R333640TX334709E", mandateUpdate);

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsAccepted);
            Assert.AreEqual(HttpStatusCode.Accepted, response.StatusCode);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Patch, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/mandates/MNDT7QXPLKT9R333640TX334709E", capturedRequest.RequestUri?.AbsolutePath);
        }

        [TestMethod]
        public async Task CancelMandateAsync_Returns202Accepted_WithCorrectVerbAndPath()
        {
            // Arrange
            HttpRequestMessage? capturedRequest = null;
            var mockHandler = new MockDelegatingHandler(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.Accepted);
            });

            IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureBalancePlatform((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddDirectDebitMandatesService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var directDebitMandatesService = testHost.Services.GetRequiredService<IDirectDebitMandatesService>();

            // Act
            ICancelMandateApiResponse response = await directDebitMandatesService.CancelMandateAsync("MNDT7QXPLKT9R333640TX334709E");

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsAccepted);
            Assert.AreEqual(HttpStatusCode.Accepted, response.StatusCode);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Post, capturedRequest.Method);
            Assert.AreEqual("/bcl/v2/mandates/MNDT7QXPLKT9R333640TX334709E/cancel", capturedRequest.RequestUri?.AbsolutePath);
        }
    }
}
