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
using Adyen.Model.PosTerminalManagement;
using Adyen.Service;
using Adyen.Service.Resource.PosTerminalManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class PosTerminalManagementTest : BaseTest
    {
        /// <summary>
        /// Test post /findTerminals
        /// </summary>
        [TestMethod]
        public void FindTerminalSuccess()
        {
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/pos-terminal-management/find-terminals-success.json");
            var posTerminalManagement = new PosTerminalManagement(client);
            var findTerminalRequest = new FindTerminalRequest
            {
                Terminal = "V400m-123456789"
            };
            var findTerminalResponse = posTerminalManagement.FindTerminal(findTerminalRequest);
            Assert.AreEqual(findTerminalResponse.Terminal, "V400m-123456789");
            Assert.AreEqual(findTerminalResponse.CompanyAccount, "TestCompany");
            Assert.AreEqual(findTerminalResponse.MerchantAccount, "TestMerchant");
            Assert.AreEqual(findTerminalResponse.Store, "MyStore");
            Assert.AreEqual(findTerminalResponse.MerchantInventory, false);
        }
        /// <summary>
        /// Test post /assignTerminals
        /// </summary>
        [TestMethod]
        public void AssignTerminalsSuccess()
        {
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/pos-terminal-management/assing-terminals-success.json");
            var posTerminalManagement = new PosTerminalManagement(client);
            var assignTerminalsRequest = new AssignTerminalsRequest
            {
                MerchantAccount = "TestMerchant",
                CompanyAccount = "TestMerchantAccount",
                MerchantInventory = true,
                Terminals = new List<string> { "P400Plus-123456789" }
            };
            var assignTerminalsResponse = posTerminalManagement.AssignTerminals(assignTerminalsRequest);
            Assert.AreEqual(assignTerminalsResponse.Results["V400m-123456789"], "ActionScheduled");
            Assert.AreEqual(assignTerminalsResponse.Results["P400Plus-123456789"], "Done");
        }

        /// <summary>
        /// Test post /getTerminalsUnderAccountResponse 
        /// </summary>
        [TestMethod]
        public void GetTerminalsUnderAccountSuccess()
        {
            var client = CreateMockTestClientApiKeyBasedRequest("Mocks/pos-terminal-management/get-terminals-under-account-success.json");
            var posTerminalManagement = new PosTerminalManagement(client);
            var getTerminalsUnderAccountRequest = new GetTerminalsUnderAccountRequest
            {
                CompanyAccount = "TestCompany",
            };
            var getTerminalsUnderAccountResponse = posTerminalManagement.GetTerminalsUnderAccount(getTerminalsUnderAccountRequest);
            Assert.AreEqual(getTerminalsUnderAccountResponse.CompanyAccount, "TestCompany");
            Assert.AreEqual(getTerminalsUnderAccountResponse.MerchantAccounts[0].MerchantAccountPos, "TestMerchantPOS_EU");
            Assert.AreEqual(getTerminalsUnderAccountResponse.MerchantAccounts[1].MerchantAccountPos, "TestMerchantPOS_US");
            Assert.AreEqual(getTerminalsUnderAccountResponse.InventoryTerminals[0], "V400m-123456789");
            Assert.AreEqual(getTerminalsUnderAccountResponse.InventoryTerminals[1], "P400Plus-123456789");
            Assert.AreEqual(getTerminalsUnderAccountResponse.MerchantAccounts[0].MerchantAccountPos, "TestMerchantPOS_EU");
            Assert.AreEqual(getTerminalsUnderAccountResponse.MerchantAccounts[0].InventoryTerminals[0], "M400-123456789");
            Assert.AreEqual(getTerminalsUnderAccountResponse.MerchantAccounts[0].InventoryTerminals[1], "VX820-123456789");
            Assert.AreEqual(getTerminalsUnderAccountResponse.MerchantAccounts[0].InStoreTerminals[0], "E355-123456789");
            Assert.AreEqual(getTerminalsUnderAccountResponse.MerchantAccounts[0].InStoreTerminals[1], "V240mPlus-123456789");
            Assert.AreEqual(getTerminalsUnderAccountResponse.MerchantAccounts[0].Stores[0].StorePos, "TestStore");
            Assert.AreEqual(getTerminalsUnderAccountResponse.MerchantAccounts[0].Stores[0].InStoreTerminals[0], "MX925-123456789");
            Assert.AreEqual(getTerminalsUnderAccountResponse.MerchantAccounts[1].InStoreTerminals[0], "VX820-123456789");
            Assert.AreEqual(getTerminalsUnderAccountResponse.MerchantAccounts[1].InStoreTerminals[1], "VX690-123456789");
        }
        
        /// <summary>
        /// Test post /getTerminalDetails
        /// </summary>
        [TestMethod]
        public void GetTerminalDetailsSuccess()
        {
            var client =
                CreateMockTestClientApiKeyBasedRequest(
                    "Mocks/pos-terminal-management/get-terminals-details-success.json");
            var posTerminalManagement = new PosTerminalManagement(client);
            var getTerminalDetailsRequest = new GetTerminalDetailsRequest
            {
                Terminal = "P400Plus-275479597",
            };
            var getTerminalDetailsResponse =
                posTerminalManagement.GetTerminalDetails(getTerminalDetailsRequest);
            Assert.AreEqual(getTerminalDetailsResponse.CompanyAccount, "YOUR_COMPANY_ACCOUNT");
            Assert.AreEqual(getTerminalDetailsResponse.MerchantAccount, "YOUR_MERCHANT_ACCOUNT");
            Assert.AreEqual(getTerminalDetailsResponse.MerchantInventory, false);
            Assert.AreEqual(getTerminalDetailsResponse.Terminal, "P400Plus-275479597");
            Assert.AreEqual(getTerminalDetailsResponse.DeviceModel, "P400Plus");
            Assert.AreEqual(getTerminalDetailsResponse.SerialNumber, "275-479-597");
            Assert.AreEqual(getTerminalDetailsResponse.PermanentTerminalId, "12000000");
            Assert.AreEqual(getTerminalDetailsResponse.FirmwareVersion, "Verifone_VOS 1.50.7");
            Assert.AreEqual(getTerminalDetailsResponse.TerminalStatus, "ReAssignToInventoryPending");
            Assert.AreEqual(getTerminalDetailsResponse.Country, "NETHERLANDS");
            Assert.AreEqual(getTerminalDetailsResponse.DhcpEnabled, false);
        }
    }
}
