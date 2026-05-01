using System.Net;
using System.Text;
using Adyen.Core.Options;
using Adyen.LegalEntityManagement.Client;
using Adyen.LegalEntityManagement.Extensions;
using Adyen.LegalEntityManagement.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.LegalEntityManagement.LegalEntities
{
    [TestClass]
    public class LegalEntitiesServiceTest
    {
        [TestMethod]
        public async Task GetLegalEntity()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/legalentitymanagement/LegalEntity.json");

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
                .ConfigureLegalEntityManagement((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    services.AddLegalEntitiesService(httpClientBuilderOptions: builder =>
                    {
                        builder.AddHttpMessageHandler(() => mockHandler);
                    });
                })
                .Build();

            var legalEntitiesService = testHost.Services.GetRequiredService<ILegalEntitiesService>();

            // Act
            IGetLegalEntityApiResponse response = await legalEntitiesService.GetLegalEntityAsync("LE322JV223222D5GG42KN6869");

            // Assert - response
            Assert.IsNotNull(response);
            Assert.IsTrue(response.IsOk);
            Assert.AreEqual("LE322JV223222D5GG42KN6869", response.Ok().Id);

            // Assert - HTTP verb and path
            Assert.IsNotNull(capturedRequest);
            Assert.AreEqual(HttpMethod.Get, capturedRequest.Method);
            Assert.AreEqual("/lem/v4/legalEntities/LE322JV223222D5GG42KN6869", capturedRequest.RequestUri?.AbsolutePath);
        }
    }
}
