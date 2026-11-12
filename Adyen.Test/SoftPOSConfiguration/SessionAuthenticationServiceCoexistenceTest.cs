using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PlatformSessionAuthentication = Adyen.SessionAuthentication;
using SoftPOS = Adyen.SoftPOSConfiguration;

namespace Adyen.Test.SoftPOSConfiguration
{
    /// <summary>
    /// Both Adyen.SessionAuthentication and Adyen.SoftPOSConfiguration generate a SessionAuthenticationService,
    /// an ISessionAuthenticationService and an AddSessionAuthenticationService() extension method.
    /// The extension methods are called with their full names here, because importing both Extensions namespaces makes the call ambiguous.
    /// </summary>
    [TestClass]
    public class SessionAuthenticationServiceCoexistenceTest
    {
        [TestMethod]
        public void Given_BothSessionAuthenticationServicesRegistered_When_Resolved_Then_EachUsesItsOwnBaseAddress()
        {
            // Arrange
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    new PlatformSessionAuthentication.Client.HostConfiguration(services)
                        .ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });
                    new SoftPOS.Client.HostConfiguration(services)
                        .ConfigureAdyenOptions(options => { options.Environment = AdyenEnvironment.Test; });

                    PlatformSessionAuthentication.Extensions.ServiceCollectionExtensions.AddSessionAuthenticationService(services);
                    SoftPOS.Extensions.ServiceCollectionExtensions.AddSessionAuthenticationService(services);
                })
                .Build();

            // Act
            var platformService = host.Services.GetRequiredService<PlatformSessionAuthentication.Services.ISessionAuthenticationService>();
            var softPosService = host.Services.GetRequiredService<SoftPOS.Services.ISessionAuthenticationService>();

            // Assert
            Assert.IsInstanceOfType(platformService, typeof(PlatformSessionAuthentication.Services.SessionAuthenticationService));
            Assert.IsInstanceOfType(softPosService, typeof(SoftPOS.Services.SessionAuthenticationService));
            StringAssert.StartsWith(platformService.HttpClient.BaseAddress!.ToString(), "https://test.adyen.com/authe/api/");
            Assert.AreEqual("https://softposconfig-test.adyen.com/softposconfig/v3", softPosService.HttpClient.BaseAddress!.ToString());
        }
    }
}
