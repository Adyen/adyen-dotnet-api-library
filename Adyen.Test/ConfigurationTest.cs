#region License
/*
 *                       ######
 *                       ######
 * ############    ####( ######  #####. ######  ############   ############
 * #############  #####( ######  #####. ######  #############  #############
 *        ######  #####( ######  #####. ######  #####  ######  #####  ######
 * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
 * ###### ######  #####( ######  #####. ######  #####          #####  ######
 * #############  #############  #############  #############  #####  ######
 *  ############   ############  #############   ############  #####  ######
 *                                      ######
 *                               #############
 *                               ############
 *
 * Adyen Dotnet API Library
 *
 * Copyright (c) 2021 Adyen B.V.
 * This file is open source and available under the MIT license.
 * See the LICENSE file for more info.
 */
#endregion
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adyen.Test
{
    [TestClass]
    public class ConfigurationTest
    {
        [TestMethod]
        public void TestRetrieveApiCredential()
        {
            var config = new Config();
            var client = new Client(config);
            client.SetEnvironment(Model.Enum.Environment.Test, "companyUrl");
            var configuration = new Configuration(client);
            var endpoint = configuration.RetrieveApiCredential(5,5);
            Assert.AreEqual(endpoint, @"https://configuration-test.adyen.com/v1/companies/5/apiCredentials/5");
        }
    }
}
