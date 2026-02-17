using System.Net;
using Adyen.Core.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Hosting;
using Adyen.Core.Options;
using Adyen.Management.Extensions;
using Adyen.Management.Services;
using Microsoft.Extensions.Logging;

namespace Adyen.IntegrationTest.Management
{
    [TestClass]
    public class ManagementServiceIntegrationTest
    {
        private readonly IUsersMerchantLevelService _usersMerchantLevelService;
        private readonly IHost _host;
        private readonly string _merchantAccount;
        private readonly ILogger _logger;
        
        public ManagementServiceIntegrationTest()
        {
            _host = Host.CreateDefaultBuilder()
                .ConfigureManagement(
                    (context, services, config) =>
                    {
                        config.ConfigureAdyenOptions(options =>
                        {
                            options.AdyenApiKey = context.Configuration["ADYEN_API_KEY"];
                            options.Environment = AdyenEnvironment.Test;
                        });
                        services.AddAllManagementServices();
                    })
                .Build();
            
            _merchantAccount = Environment.GetEnvironmentVariable("ADYEN_MERCHANT_ACCOUNT") ?? "HeapUnderflowECOM";
            
            _usersMerchantLevelService = _host.Services.GetRequiredService<IUsersMerchantLevelService>();
            
            _logger = _host.Services.GetRequiredService<ILogger<IUsersMerchantLevelService>>();

            UsersMerchantLevelServiceEvents events = _host.Services.GetRequiredService<UsersMerchantLevelServiceEvents>();            
            // On /payments
            events.OnListUsers += (sender, eventArgs) =>
            {
                ApiResponse apiResponse = eventArgs.ApiResponse;
                _logger.LogInformation("{TotalSeconds,-9} | {Path} | {StatusCode} |", (apiResponse.DownloadedAt - apiResponse.RequestedAt).TotalSeconds, apiResponse.Path, apiResponse.StatusCode);
            };
            
            // OnError /payments.
            events.OnErrorListUsers += (sender, eventArgs) =>
            {
                _logger.LogError(eventArgs.Exception, "An error occurred after sending the request to the server.");
            };
        }

        [TestMethod]
        public async Task Given_MerchantAccount_When_ListUsers_Returns_OK()
        {
            
            IListUsersApiResponse response = await _usersMerchantLevelService.ListUsersAsync(_merchantAccount);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            
            response.TryDeserializeOkResponse(out var result);
            Assert.IsNotNull(result?.Data);
        }

    }
}