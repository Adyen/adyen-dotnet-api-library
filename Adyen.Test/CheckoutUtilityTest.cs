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

using Adyen.Model.Checkout;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Adyen.Test
{
    [TestClass]
    public class CheckoutUtilityTest : BaseTest
    {
        /// <summary>
        /// Test success flow for
        ///POST /originKeys
        /// </summary>
        [TestMethod]
        public void OriginKeysSuccessTest()
        {
            var checkoutUtilityRequest = new CheckoutUtilityRequest(originDomains: new List<string> { "www.test.com", "https://www.your-domain2.com" });
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/checkoututility/originkeys-success.json");
            var _checkout = new CheckoutUtility(client);
            var originKeysResponse = _checkout.OriginKeys(checkoutUtilityRequest);
            Assert.AreEqual("pub.v2.7814286629520534.aHR0cHM6Ly93d3cueW91ci1kb21haW4xLmNvbQ.UEwIBmW9-c_uXo5wSEr2w8Hz8hVIpujXPHjpcEse3xI", originKeysResponse.OriginKeys["https://www.your-domain1.com"]);
        }
    }
}
