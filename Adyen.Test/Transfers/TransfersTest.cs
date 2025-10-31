using Adyen.Core.Options;
using Adyen.Transfers.Models;
using Adyen.Transfers.Client;
using Adyen.Transfers.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;

namespace Adyen.Test.Transfers
{
    [TestClass]
    public class TransfersTest
    {
        private readonly JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        public TransfersTest()
        {
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureTransfers((context, services, config) =>
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
        public async Task Given_Deserialize_When_TransactionSearchResponse_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/transfers/get-all-transactions.json");
            
            // Act
            var response = JsonSerializer.Deserialize<TransactionSearchResponse>(json, _jsonSerializerOptionsProvider.Options);

            // Assert
            Assert.AreEqual(response.Links.Next.Href, "https://balanceplatform-api-test.adyen.com/btl/v4/transactions?balancePlatform=TestBalancePlatform&createdUntil=2023-08-20T13%3A07%3A40Z&createdSince=2023-08-10T10%3A50%3A40Z&cursor=S2B-c0p1N0tdN0l6RGhYK1YpM0lgOTUyMDlLXElyKE9LMCtyaFEuMj1NMHgidCsrJi1ZNnhqXCtqVi5JPGpRK1F2fCFqWzU33JTojSVNJc1J1VXhncS10QDd6JX9FQFl5Zn0uNyUvSXJNQTo");
        }
        
        [TestMethod]
        public async Task Given_Deserialize_When_TransferTransaction_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/transfers/get-transaction.json");

            // Act
            var response = JsonSerializer.Deserialize<Transaction>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(response.Status, Transaction.StatusEnum.Booked);
            Assert.AreEqual(response.Transfer.Id, "48TYZO5ZVURJ2FCW");
        }
        
        [TestMethod]
        public async Task Given_Deserialize_When_Transfer_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/transfers/transfer-funds.json");
            
            // Act
            var response = JsonSerializer.Deserialize<Transfer>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(response.Status, Transfer.StatusEnum.Authorised);
            Assert.AreEqual(response.Category, Transfer.CategoryEnum.Bank);
        }
        
        #region Grants
        
        [TestMethod]
        public async Task Given_Deserialize_When_CapitalGrant_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/grants/post-grants-success.json");
            
            // Act
            var response = JsonSerializer.Deserialize<CapitalGrant>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(response.Id, "GR00000000000000000000001");
            Assert.AreEqual(response.GrantAccountId, "CG00000000000000000000001");
            Assert.AreEqual(response.Status, CapitalGrant.StatusEnum.Pending);
            Assert.IsNotNull(response.Balances);
        }
        
        #endregion
    }
}