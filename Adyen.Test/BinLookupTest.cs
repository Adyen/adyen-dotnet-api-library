#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using Adyen.Model.BinLookup;
using Adyen.Model.Enum;
using Adyen.Service;
using Adyen.Service.Resource.BinLookup;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace Adyen.Test
{
    [TestClass]
    public class BinLookupTest : BaseTest
    {
        [TestMethod]
        public void Get3dsAvailabilitySuccessMockedTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/binlookup/get3dsavailability-success.json");
            var binLookup = new BinLookup(client);
            var threeDsAvailabilityRequest = new ThreeDSAvailabilityRequest
            {
                MerchantAccount = "merchantAccount",
                CardNumber = "4111111111111111"
            };
            var threeDsAvailabilityResponse = binLookup.ThreeDsAvailability(threeDsAvailabilityRequest);
            Assert.AreEqual("F013371337", threeDsAvailabilityResponse.DsPublicKeys[0].DirectoryServerId);
            Assert.AreEqual("visa", threeDsAvailabilityResponse.DsPublicKeys[0].Brand);
            Assert.AreEqual("411111111111", threeDsAvailabilityResponse.ThreeDS2CardRangeDetails[0].StartRange);
            Assert.AreEqual("411111111111", threeDsAvailabilityResponse.ThreeDS2CardRangeDetails[0].EndRange);
            Assert.AreEqual("2.1.0", threeDsAvailabilityResponse.ThreeDS2CardRangeDetails[0].ThreeDS2Version);
            Assert.AreEqual("https://pal-test.adyen.com/threeds2simulator/acs/startMethod.shtml", threeDsAvailabilityResponse.ThreeDS2CardRangeDetails[0].ThreeDSMethodURL);
            Assert.AreEqual(true, threeDsAvailabilityResponse.ThreeDS1Supported);
            Assert.AreEqual(true, threeDsAvailabilityResponse.ThreeDS2supported);
        }

        [TestMethod]
        public void GetCostEstimateSuccessMockedTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/binlookup/getcostestimate-success.json");
            var binLookup = new BinLookup(client);
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
            costEstimateRequest.ShopperInteraction = ShopperInteraction.Ecommerce;
            var costEstimateResponse = binLookup.CostEstimate(costEstimateRequest);
            Assert.AreEqual("1111", costEstimateResponse.CardBin.Summary);
            Assert.AreEqual("Unsupported", costEstimateResponse.ResultCode);
            Assert.AreEqual("ZERO", costEstimateResponse.SurchargeType);
        }

        [TestMethod]
        public void GetCostEstimateSuccessGenerateShopperInteractionFromEnum()
        {
            var ecommerce = Util.JsonOperation.SerializeRequest(ShopperInteraction.Ecommerce);
            var contAuth = Util.JsonOperation.SerializeRequest(ShopperInteraction.ContAuth);
            var moto = Util.JsonOperation.SerializeRequest(ShopperInteraction.Moto);
            Assert.AreEqual("\"Ecommerce\"", ecommerce);
            Assert.AreEqual("\"ContAuth\"", contAuth);
            Assert.AreEqual("\"Moto\"", moto);
        }
    }
}
