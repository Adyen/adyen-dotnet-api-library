#region Licence
// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2020 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.
#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Adyen.Model.Checkout;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
   public class PaymentMethodsTest
    {
        [TestMethod]
        public void TestAchPaymentMethod()
        {
            var ach = new AchDetails();
            Assert.AreEqual(ach.Type,"ach");
        }

        [TestMethod]
        public void TestAmazonPaymentMethod()
        {
            var amazonPayDetails = new AmazonPayDetails();
            Assert.AreEqual(amazonPayDetails.Type, "amazonpay");
        }
    }
}
