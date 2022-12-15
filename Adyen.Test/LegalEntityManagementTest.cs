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
 * Copyright (c) 2022 Adyen N.V.
 * This file is open source and available under the MIT license.
 * See the LICENSE file for more info.
 */

#endregion

using System;
using System.Text;
using Adyen.Model.LegalEntityManagement;
using Adyen.Service.LegalEntityManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class LegalEntityManagementTest : BaseTest
    {
        #region Document
        /// <summary>
        /// Test createDocument
        /// </summary>
        [TestMethod]
        public void LEMCreateDocumentTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/legalentitymanagement/Document.json");
            var service = new Documents(client);
            var document = new Document()
            {
                Attachment = new Attachment()
            };
            var response = service.create(document);
            Assert.AreEqual(Encoding.ASCII.GetString(response.Attachments[0].Content), "This is a string");
            Assert.AreEqual(response.Id, "SE322KT223222D5FJ7TJN2986");

        }
        
        /// <summary>
        /// Test deleteDocument
        /// </summary>
        [TestMethod]
        public void LEMDeleteDocumentTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/legalentitymanagement/Document.json");
            var service = new Documents(client);
            service.delete("SE322KT223222D5FJ7TJN2986");

        }
        #endregion
    }
}