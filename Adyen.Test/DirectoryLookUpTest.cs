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

using Adyen.Constants;
using Adyen.Constants.HPPConstants;
using Adyen.Model.Hpp;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Adyen.Test
{
    [TestClass]
    public class DirectoryLookupTest : BaseTest
    {
        [TestMethod]
        public void TestGetPostParameters()
        {
            Client client = base.CreateMockTestClientRequest("");
            HostedPaymentPages hostedPaymentPages = new HostedPaymentPages(client);
            DirectoryLookupRequest directoryLookupRequest = CreateDirectoryLookupRequest();
            Dictionary<string, string> postParameters = hostedPaymentPages.GetPostParametersFromDlRequest(directoryLookupRequest);

            Assert.AreEqual("EUR", postParameters[Fields.CurrencyCode]);
            Assert.AreEqual(44, postParameters[Fields.MerchantSig].Length);

        }

        [TestMethod]
        public void TestGetPaymentMethods()
        {
            Client client = base.CreateMockTestClientPost("Mocks/hpp/directoryLookup-success.json");
            HostedPaymentPages hostedPaymentPages = new HostedPaymentPages(client);
            DirectoryLookupRequest directoryLookupRequest = CreateDirectoryLookupRequest();
            List<PaymentMethod> paymentMethods = hostedPaymentPages.GetPaymentMethods(directoryLookupRequest);

            Assert.AreEqual(8, paymentMethods.Count);
            //Get payment method by name
            PaymentMethod ideal = paymentMethods.FirstOrDefault(x => x.Name == "iDEAL");
            //  Assert.IsFalse(ideal.IsCard());

            Assert.AreEqual(BrandCodes.Ideal, ideal.BrandCode);
            Assert.AreEqual("iDEAL", ideal.Name);
            Assert.AreEqual(3, ideal.Issuers.Count);
            Issuer issuerIdeal = ideal.Issuers.FirstOrDefault();

            Assert.AreEqual("1121", issuerIdeal.IssuerId);
            Assert.AreEqual("Test Issuer", issuerIdeal.Name);

            //Get payment method by name
            PaymentMethod visa = paymentMethods.FirstOrDefault(x => x.Name == "VISA");
            Assert.AreEqual(BrandCodes.Visa, visa.BrandCode);
        }

        [TestMethod]
        public void TestGetPaymentMethodsError()
        {
            try
            {
                Client client = base.CreateMockTestClientPost("Mocks/hpp/directoryLookup-error.htm");
                HostedPaymentPages hostedPaymentPages = new HostedPaymentPages(client);
                DirectoryLookupRequest directoryLookupRequest = CreateDirectoryLookupRequest();
                Assert.Fail("Expected exception");
            }
            catch (Exception)
            {
                
            }
        }
        
        private DirectoryLookupRequest CreateDirectoryLookupRequest()
        {
            DirectoryLookupRequest directoryLookupRequest = new DirectoryLookupRequest()
            {
                CountryCode = "NL",
                MerchantReference = "test:\\'test",
                PaymentAmount = "1000",
                CurrencyCode = "EUR"
            };
            return directoryLookupRequest;
        }
    }
}
