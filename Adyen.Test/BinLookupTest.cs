﻿using System.Linq;
using Adyen.Model.BinLookup;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class BinLookupTest : BaseTest
    {
        [TestMethod]
        public void Get3dsAvailabilitySuccessMockedTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/binlookup/get3dsavailability-success.json");
            var binLookup = new BinLookupService(client);
            var threeDsAvailabilityRequest = new ThreeDSAvailabilityRequest
            {
                MerchantAccount = "merchantAccount",
                CardNumber = "4111111111111111"
            };
            var threeDsAvailabilityResponse = binLookup.Get3dsAvailability(threeDsAvailabilityRequest);
            Assert.AreEqual("F013371337", threeDsAvailabilityResponse.DsPublicKeys[0].DirectoryServerId);
            Assert.AreEqual("visa", threeDsAvailabilityResponse.DsPublicKeys[0].Brand);
            Assert.AreEqual("411111111111", threeDsAvailabilityResponse.ThreeDS2CardRangeDetails[0].StartRange);
            Assert.AreEqual("411111111111", threeDsAvailabilityResponse.ThreeDS2CardRangeDetails[0].EndRange);
            Assert.AreEqual("2.1.0", threeDsAvailabilityResponse.ThreeDS2CardRangeDetails[0].ThreeDS2Versions.FirstOrDefault());
            Assert.AreEqual("https://pal-test.adyen.com/threeds2simulator/acs/startMethod.shtml", threeDsAvailabilityResponse.ThreeDS2CardRangeDetails[0].ThreeDSMethodURL);
            Assert.AreEqual(true, threeDsAvailabilityResponse.ThreeDS1Supported);
            Assert.AreEqual(true, threeDsAvailabilityResponse.ThreeDS2supported);
        }

        [TestMethod]
        public void GetCostEstimateSuccessMockedTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/binlookup/getcostestimate-success.json");
            var binLookup = new BinLookupService(client);
            var costEstimateRequest = new CostEstimateRequest();
            var amount = new Amount
            {
                Currency = "EUR",
                Value = 1000
            };
            costEstimateRequest.Amount = amount;
            var costEstimateAssumptions = new CostEstimateAssumptions
            {
                AssumeLevel3Data = true,
                Assume3DSecureAuthenticated = true
            };
            costEstimateRequest.Assumptions = costEstimateAssumptions;
            costEstimateRequest.CardNumber = "4111111111111111";
            costEstimateRequest.MerchantAccount = "merchantAccount";
            var merchantDetails = new MerchantDetails
            {
                CountryCode = "NL",
                Mcc = "7411",
                EnrolledIn3DSecure = true
            };
            costEstimateRequest.MerchantDetails = (merchantDetails);
            costEstimateRequest.ShopperInteraction = CostEstimateRequest.ShopperInteractionEnum.Ecommerce;
            var costEstimateResponse = binLookup.GetCostEstimate(costEstimateRequest);
            Assert.AreEqual("1111", costEstimateResponse.CardBin.Summary);
            Assert.AreEqual("Unsupported", costEstimateResponse.ResultCode);
        }

        [TestMethod]
        public void GetCostEstimateSuccessGenerateShopperInteractionFromEnum()
        {
            var ecommerce = Util.JsonOperation.SerializeRequest(CostEstimateRequest.ShopperInteractionEnum.Ecommerce);
            var contAuth = Util.JsonOperation.SerializeRequest(CostEstimateRequest.ShopperInteractionEnum.ContAuth);
            var moto = Util.JsonOperation.SerializeRequest(CostEstimateRequest.ShopperInteractionEnum.Moto);
            Assert.AreEqual("\"Ecommerce\"", ecommerce);
            Assert.AreEqual("\"ContAuth\"", contAuth);
            Assert.AreEqual("\"Moto\"", moto);
        }
    }
}
