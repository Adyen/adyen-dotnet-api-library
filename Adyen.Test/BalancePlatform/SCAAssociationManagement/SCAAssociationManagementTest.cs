using System.Text.Json;
using Adyen.BalancePlatform.Client;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Models;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.BalancePlatform.SCAAssociationManagement
{
    [TestClass]
    public class SCAAssociationManagementTest : BaseTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public SCAAssociationManagementTest()
        {
            IHost host = Host.CreateDefaultBuilder()
            .ConfigureBalancePlatform((context, services, config) =>
            {
                config.ConfigureAdyenOptions(options =>
                {
                    options.AdyenApiKey = context.Configuration["ADYEN_API_KEY"];
                    options.Environment = AdyenEnvironment.Test;
                });
            })
            .Build();

            _jsonSerializerOptionsProvider = host.Services.GetRequiredService<JsonSerializerOptionsProvider>();
        }
        
        [TestMethod]
        public async Task Given_ApproveAssociationRequest_Deserialize_Correctly()
        {
            // Arrange
            string json =  TestUtilities.GetTestFileContent("mocks/balanceplatform/ApproveAssociationRequest.json");
        
            // Act
            var response = JsonSerializer.Deserialize<ApproveAssociationRequest>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(response.Status, AssociationStatus.Active);
            Assert.AreEqual(response.EntityType, ScaEntityType.AccountHolder);
            Assert.AreEqual(response.EntityId, "AH00000000000000000000001");
            Assert.AreEqual(response.ScaDeviceIds.Count, 1);
            Assert.AreEqual(response.ScaDeviceIds[0], "BSDR42XV3223223S5N6CDQDGH53M8H");
        }
        
        [TestMethod]
        public async Task Given_ApproveAssociationResponse_Deserialize_Correctly()
        {
            // Arrange
            string json =  TestUtilities.GetTestFileContent("mocks/balanceplatform/ApproveAssociationResponse.json");
        
            // Act
            var response = JsonSerializer.Deserialize<ApproveAssociationResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(response.ScaAssociations.Count, 1);
            var association = response.ScaAssociations[0];
            Assert.AreEqual(association.Status, AssociationStatus.Active);
            Assert.AreEqual(association.EntityType, ScaEntityType.AccountHolder);
            Assert.AreEqual(association.EntityId, "AH00000000000000000000001");
            Assert.AreEqual(association.ScaDeviceId, "BSDR42XV3223223S5N6CDQDGH53M8H");
        }

        [TestMethod]
        public async Task Given_ListAssociationsResponse_Deserialize_Correctly()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/ListAssociationsResponse.json");

            // Act
            var response = JsonSerializer.Deserialize<ListAssociationsResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.Links);
            Assert.IsNotNull(response.Links.Self);
            Assert.AreEqual("https://exampledomain.com/bcl/api/v2/scaAssociations?pageNumber=0&entityType=accountHolder&pageSize=10&entityId=AH3227J223222D5HHM4779X6X", response.Links.Self.VarHref);
            Assert.AreEqual(2, response.ItemsTotal);
            Assert.AreEqual(1, response.PagesTotal);
            Assert.IsNotNull(response.Data);
            Assert.AreEqual(2, response.Data.Count);

            // Assert first association
            var association1 = response.Data[0];
            Assert.AreEqual("BSDR11111111111A1AAA1AAAAA1AA1", association1.ScaDeviceId);
            Assert.AreEqual("Device 1", association1.ScaDeviceName);
            Assert.AreEqual(ScaDeviceType.Ios, association1.ScaDeviceType);
            Assert.AreEqual(ScaEntityType.AccountHolder, association1.EntityType);
            Assert.AreEqual("AH00000000000000000000001", association1.EntityId);
            Assert.AreEqual(AssociationStatus.Active, association1.Status);
            Assert.AreEqual(DateTimeOffset.Parse("2025-09-02T14:39:17.232Z"), association1.CreatedAt);

            // Assert second association
            var association2 = response.Data[1];
            Assert.AreEqual("BSDR22222222222B2BBB2BBBBB2BB2", association2.ScaDeviceId);
            Assert.AreEqual("Device 2", association2.ScaDeviceName);
            Assert.AreEqual(ScaDeviceType.Ios, association2.ScaDeviceType);
            Assert.AreEqual(ScaEntityType.AccountHolder, association2.EntityType);
            Assert.AreEqual("AH00000000000000000000001", association2.EntityId);
            Assert.AreEqual(AssociationStatus.PendingApproval, association2.Status);
            Assert.AreEqual(DateTimeOffset.Parse("2025-09-02T14:39:17.232Z"), association2.CreatedAt);
        }

        [TestMethod]
        public async Task Given_RemoveAssociationRequest_Deserialize_Correctly()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/balanceplatform/RemoveAssociationRequest.json");

            // Act
            var response = JsonSerializer.Deserialize<RemoveAssociationRequest>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("AH00000000000000000000001", response.EntityId);
            Assert.AreEqual(ScaEntityType.AccountHolder, response.EntityType);
            Assert.IsNotNull(response.ScaDeviceIds);
            Assert.AreEqual(2, response.ScaDeviceIds.Count);
            Assert.AreEqual("BSDR42XV3223223S5N6CDQDGH53M8H", response.ScaDeviceIds[0]);
            Assert.AreEqual("BSDR1234567890123456789012345678", response.ScaDeviceIds[1]);
        }
    }
}