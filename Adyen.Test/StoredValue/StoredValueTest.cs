using Adyen.Core.Options;
using Adyen.StoredValue.Client;
using Adyen.StoredValue.Models;
using Adyen.StoredValue.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;

namespace Adyen.Test.StoredValue
{
    [TestClass]
    public class StoredValueTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public StoredValueTest()
        { 
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureStoredValue((context, services, config) =>
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
        public async Task Given_Deserialize_When_StoredValueIssue_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/storedvalue/issue-success.json");
  
            // Act
            var response = JsonSerializer.Deserialize<StoredValueIssueResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(response.ResultCode, StoredValueIssueResponse.ResultCodeEnum.Success);
            Assert.AreEqual(response.AuthCode, "authCode");
        }
        
        [TestMethod]
        public async Task Given_Deserialize_When_ChangeStatus_StoredValueStatusChange_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/storedvalue/changeStatus-success.json");
  
            // Act
            var response = JsonSerializer.Deserialize<StoredValueStatusChangeResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(response.ResultCode, StoredValueStatusChangeResponse.ResultCodeEnum.Refused);
            Assert.AreEqual(response.AuthCode, "authCode");
        }
        
        [TestMethod]
        public async Task Given_Deserialize_When_StoredValueLoad_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/storedvalue/load-success.json");
  
            // Act
            var response = JsonSerializer.Deserialize<StoredValueLoadResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(response.ResultCode, StoredValueLoadResponse.ResultCodeEnum.Success);
            Assert.AreEqual(response.AuthCode, "authCode");
        }
        
        [TestMethod]
        public async Task Given_Deserialize_When_StoredValueBalanceCheck_Returns_Not_Null()
        {   
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/storedvalue/checkBalance-success.json");
  
            // Act
            var response = JsonSerializer.Deserialize<StoredValueBalanceCheckResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(response.ResultCode, StoredValueBalanceCheckResponse.ResultCodeEnum.Success);
            Assert.AreEqual(response.CurrentBalance.Value, 0);
        }
        
        [TestMethod]
        public async Task Given_Deserialize_When_StoredValueBalanceMerge_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/storedvalue/mergeBalance-success.json");
  
            // Act
            var response = JsonSerializer.Deserialize<StoredValueBalanceMergeResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(response.ResultCode, StoredValueBalanceMergeResponse.ResultCodeEnum.Success);
            Assert.AreEqual(response.CurrentBalance.Value, 0);
        }
        
        [TestMethod]
        public async Task Given_Deserialize_When_StoredValueVoid_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/storedvalue/mergeBalance-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<StoredValueVoidResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(response.ResultCode, StoredValueVoidResponse.ResultCodeEnum.Success);
            Assert.AreEqual(response.CurrentBalance.Value, 0);
        }
    }
}