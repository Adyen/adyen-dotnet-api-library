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

namespace Adyen.Test.LegalEntityManagement.HostedOnboarding
{
    [TestClass]
    public class HostedOnboardingTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;
        private readonly IHostedOnboardingService _hostedOnboardingService;

        public HostedOnboardingTest()
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
            _hostedOnboardingService = Substitute.For<IHostedOnboardingService>();
        }

        [TestMethod]
        public async Task GetLinkToAdyenHostedOnboardingPageAsyncTest()
        {
            // Arrange
            var json = "{\"url\":\"https://test.adyen.com/checkout/123\",\"expiresAt\":\"2025-12-31T23:59:59Z\"}";
            var legalEntityId = "LE12345";
            var onboardingLinkInfo = new OnboardingLinkInfo();

            _hostedOnboardingService.GetLinkToAdyenhostedOnboardingPageAsync(
                    Arg.Any<string>(),
                    Arg.Any<Option<OnboardingLinkInfo>>(),
                    Arg.Any<RequestOptions>(),
                    Arg.Any<CancellationToken>())
                .Returns(
                    Task.FromResult<IGetLinkToAdyenhostedOnboardingPageApiResponse>(
                        new HostedOnboardingService.GetLinkToAdyenhostedOnboardingPageApiResponse(
                            Substitute.For<Microsoft.Extensions.Logging.ILogger<HostedOnboardingService.GetLinkToAdyenhostedOnboardingPageApiResponse>>(),
                            new HttpRequestMessage(),
                            new HttpResponseMessage { StatusCode = HttpStatusCode.OK },
                            json,
                            $"/legalEntities/{legalEntityId}/onboardingLinks",
                            DateTime.UtcNow,
                            _jsonSerializerOptionsProvider.Options)
                    ));

            // Act
            var response = await  _hostedOnboardingService.GetLinkToAdyenhostedOnboardingPageAsync(legalEntityId, new Option<OnboardingLinkInfo>(onboardingLinkInfo), null, CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            var onboardingLink = response.Ok();
            Assert.IsNotNull(onboardingLink);
            Assert.AreEqual("https://test.adyen.com/checkout/123", onboardingLink.Url);
        }

        [TestMethod]
        public async Task GetOnboardingLinkThemeAsyncTest()
        {
            // Arrange
            var json = "{\"createdAt\":\"2022-10-31T01:30:00+01:00\",\"description\":\"string\",\"id\":\"SE322KT223222D5FJ7TJN2986\",\"properties\":{\"sample\":\"string\"},\"updatedAt\":\"2022-10-31T01:30:00+01:00\"}";
            var themeId = "SE322KT223222D5FJ7TJN2986";

            _hostedOnboardingService.GetOnboardingLinkThemeAsync(
                    Arg.Any<string>(),
                    Arg.Any<RequestOptions>(),
                    Arg.Any<CancellationToken>())
                .Returns(
                    Task.FromResult<IGetOnboardingLinkThemeApiResponse>(
                        new HostedOnboardingService.GetOnboardingLinkThemeApiResponse(
                            Substitute.For<Microsoft.Extensions.Logging.ILogger<HostedOnboardingService.GetOnboardingLinkThemeApiResponse>>(),
                            new HttpRequestMessage(),
                            new HttpResponseMessage { StatusCode = HttpStatusCode.OK },
                            json,
                            $"/themes/{themeId}",
                            DateTime.UtcNow,
                            _jsonSerializerOptionsProvider.Options)
                    ));

            // Act
            var response = await  _hostedOnboardingService.GetOnboardingLinkThemeAsync(themeId);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            var onboardingTheme = response.Ok();
            Assert.IsNotNull(onboardingTheme);
            Assert.AreEqual(themeId, onboardingTheme.Id);
        }

        [TestMethod]
        public async Task ListHostedOnboardingPageThemesAsyncTest()
        {
            // Arrange
            var json = TestUtilities.GetTestFileContent("mocks/legalentitymanagement/OnboardingThemes.json");

            _hostedOnboardingService.ListHostedOnboardingPageThemesAsync(
                    Arg.Any<RequestOptions>(), 
                    Arg.Any<CancellationToken>())
                .Returns(
                    Task.FromResult<IListHostedOnboardingPageThemesApiResponse>(
                        new HostedOnboardingService.ListHostedOnboardingPageThemesApiResponse(
                            Substitute.For<Microsoft.Extensions.Logging.ILogger<HostedOnboardingService.ListHostedOnboardingPageThemesApiResponse>>(),
                            new HttpRequestMessage(),
                            new HttpResponseMessage { StatusCode = HttpStatusCode.OK },
                            json,
                            "/themes",
                            DateTime.UtcNow,
                            _jsonSerializerOptionsProvider.Options)
                    ));

            // Act
            var response =  await  _hostedOnboardingService.ListHostedOnboardingPageThemesAsync();

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            var onboardingThemes = response.Ok();
            Assert.IsNotNull(onboardingThemes);
            Assert.AreEqual(1, onboardingThemes.Themes.Count);
            Assert.AreEqual("SE322KT223222D5FJ7TJN2986", onboardingThemes.Themes[0].Id);
        }
    }
}