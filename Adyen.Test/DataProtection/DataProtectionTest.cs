using Adyen.Core.Options;
using Adyen.DataProtection.Client;
using Adyen.DataProtection.Models;
using Adyen.DataProtection.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;

namespace Adyen.Test.DataProtection
{
    [TestClass]
    public class DataProtectionTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public DataProtectionTest()
        {
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureDataProtection((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });
                })
                .Build();
            
            _jsonSerializerOptionsProvider = host.Services.GetRequiredService<JsonSerializerOptionsProvider>();
        }
        
        [TestMethod]
        public async Task Given_Deserialize_When_SubjectErasureResponse_Returns_Not_Null_And_Correct_Enum()
        {
            string json = TestUtilities.GetTestFileContent("mocks/data-protection-response.json");
            
            var response = JsonSerializer.Deserialize<SubjectErasureResponse>(json, _jsonSerializerOptionsProvider.Options);
            Assert.AreEqual(response.Result, SubjectErasureResponse.ResultEnum.ACTIVERECURRINGTOKENEXISTS);
        }
    }
}