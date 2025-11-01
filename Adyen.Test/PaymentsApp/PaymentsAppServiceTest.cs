using Adyen.Core.Options;
using Adyen.PaymentsApp.Client;
using Adyen.PaymentsApp.Models;
using Adyen.PaymentsApp.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Adyen.PaymentsApp.Services;

namespace Adyen.Test.PaymentsApp
{
    [TestClass]
    public class PaymentsAppTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;
        private readonly IPaymentsAppService _paymentsAppService;

        public PaymentsAppTest()
        {
            IHost host = Host.CreateDefaultBuilder()
                .ConfigurePaymentsApp((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });
                })
                .Build();

            _jsonSerializerOptionsProvider = host.Services.GetRequiredService<JsonSerializerOptionsProvider>();
            _paymentsAppService = host.Services.GetRequiredService<IPaymentsAppService>();
        }
        [TestMethod]
        public async Task PaymentsAppServiceTESTUrlTest()
        {
            _paymentsAppService.RevokePaymentsAppAsync("{merchantId}", "{installationId}")
            
            var client = CreateMockForAdyenClientTest(new Config());
            client.SetEnvironment(Environment.Test, "companyUrl");
            var checkout = new PaymentsAppService(client);
            checkout.RevokePaymentsAppAsync().GetAwaiter();

            ClientInterfaceSubstitute.Received().RequestAsync("https://management-test.adyen.com/v1/merchants/{merchantId}/paymentsApps/{installationId}/revoke",
                Arg.Any<string>(), null, new HttpMethod("POST"), default);
        }
        
        [TestMethod]
        public void PaymentsAppServiceLIVEUrlTest()
        {
            var client = CreateMockForAdyenClientTest(new Config());
            client.SetEnvironment(Environment.Live, "companyUrl");
            var checkout = new PaymentsAppService(client);
            checkout.RevokePaymentsAppAsync("{merchantId}", "{installationId}").GetAwaiter();

            ClientInterfaceSubstitute.Received().RequestAsync("https://management-live.adyen.com/v1/merchants/{merchantId}/paymentsApps/{installationId}/revoke",
                Arg.Any<string>(), null, new HttpMethod("POST"), default);
        }
    }
}