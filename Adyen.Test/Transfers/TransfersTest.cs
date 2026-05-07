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
        private static IHost _host;
        private static JsonSerializerOptionsProvider _jsonSerializerOptionsProvider;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            _host = Host.CreateDefaultBuilder()
                .ConfigureTransfers((ctx, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });
                })
                .Build();

            _jsonSerializerOptionsProvider = _host.Services.GetRequiredService<JsonSerializerOptionsProvider>();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            _host?.Dispose();
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
        
        [TestMethod]
        public async Task Given_Deserialize_When_FindTransfersResponse_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/transfers/get-all-transfers.json");
            
            // Act
            var response = JsonSerializer.Deserialize<FindTransfersResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.IsNotNull(response.Data);
            Assert.AreEqual(2, response.Data.Count);
            Assert.AreEqual("1W1UG35QQEBJLHZ8", response.Data[0].Id);
            Assert.AreEqual(TransferData.CategoryEnum.Internal, response.Data[0].Category);
            Assert.IsNotNull(response.Links?.Next?.Href);
        }
        
        [TestMethod]
        public async Task Given_Deserialize_When_TransferInternalCategory_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/transfers/transfer-internal.json");
            
            // Act
            var response = JsonSerializer.Deserialize<Transfer>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(Transfer.StatusEnum.Authorised, response.Status);
            Assert.AreEqual(Transfer.CategoryEnum.Internal, response.Category);
            Assert.AreEqual("1W1UG35U8A9J5ZLG", response.Id);
        }
        
        [TestMethod]
        public async Task Given_Deserialize_When_TransferCardPayout_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/transfers/transfer-card-payout.json");
            
            // Act
            var response = JsonSerializer.Deserialize<Transfer>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(Transfer.StatusEnum.Authorised, response.Status);
            Assert.AreEqual(Transfer.CategoryEnum.Card, response.Category);
            Assert.AreEqual("48POP561F0ZWWLNW", response.Id);
        }
        
        [TestMethod]
        public async Task Given_Deserialize_When_ReturnTransferResponse_Returns_Not_Null()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/transfers/return-transfer.json");
            
            // Act
            var response = JsonSerializer.Deserialize<ReturnTransferResponse>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.AreEqual(ReturnTransferResponse.StatusEnum.Authorised, response.Status);
            Assert.AreEqual("1W1UG35QQEBJLHZ8", response.Id);
            Assert.AreEqual("1W1UG35U8A9J5ZLG", response.TransferId);
        }
        
        #region Tracking Discriminator
        
        [TestMethod]
        public void Given_Deserialize_When_TrackingTypeConfirmation_Returns_ConfirmationTrackingData()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/transfers/transfer-data-confirmation-tracking.json");
            
            // Act
            var response = JsonSerializer.Deserialize<TransferData>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.Tracking);
            Assert.IsNotNull(response.Tracking.ConfirmationTrackingData);
            Assert.IsNull(response.Tracking.EstimationTrackingData);
            Assert.IsNull(response.Tracking.InternalReviewTrackingData);
            Assert.AreEqual(ConfirmationTrackingData.TypeEnum.Confirmation, response.Tracking.ConfirmationTrackingData.Type);
            Assert.AreEqual(ConfirmationTrackingData.StatusEnum.Credited, response.Tracking.ConfirmationTrackingData.Status);
        }
        
        [TestMethod]
        public void Given_Deserialize_When_TrackingTypeEstimation_Returns_EstimationTrackingData()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/transfers/transfer-data-estimation-tracking.json");
            
            // Act
            var response = JsonSerializer.Deserialize<TransferData>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.Tracking);
            Assert.IsNull(response.Tracking.ConfirmationTrackingData);
            Assert.IsNotNull(response.Tracking.EstimationTrackingData);
            Assert.IsNull(response.Tracking.InternalReviewTrackingData);
            Assert.AreEqual(EstimationTrackingData.TypeEnum.Estimation, response.Tracking.EstimationTrackingData.Type);
            Assert.AreEqual(new DateTimeOffset(2023, 8, 20, 13, 7, 40, TimeSpan.Zero), response.Tracking.EstimationTrackingData.EstimatedArrivalTime);
        }
        
        [TestMethod]
        public void Given_Deserialize_When_TrackingTypeInternalReview_Returns_InternalReviewTrackingData()
        {
            // Arrange
            string json = TestUtilities.GetTestFileContent("mocks/transfers/transfer-data-internal-review-tracking.json");
            
            // Act
            var response = JsonSerializer.Deserialize<TransferData>(json, _jsonSerializerOptionsProvider.Options);
            
            // Assert
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.Tracking);
            Assert.IsNull(response.Tracking.ConfirmationTrackingData);
            Assert.IsNull(response.Tracking.EstimationTrackingData);
            Assert.IsNotNull(response.Tracking.InternalReviewTrackingData);
            Assert.AreEqual(InternalReviewTrackingData.TypeEnum.InternalReview, response.Tracking.InternalReviewTrackingData.Type);
            Assert.AreEqual(InternalReviewTrackingData.StatusEnum.Pending, response.Tracking.InternalReviewTrackingData.Status);
            Assert.AreEqual(InternalReviewTrackingData.ReasonEnum.RefusedForRegulatoryReasons, response.Tracking.InternalReviewTrackingData.Reason);
        }
        
        #endregion
        
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