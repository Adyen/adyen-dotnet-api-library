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
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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
        public void CreateDocument()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/legalentitymanagement/Document.json");
            var service = new Documents(client);
            var document = new Document()
            {
                Attachment = new Attachment()
            };
            var response = service.Create(document);
            Assert.AreEqual(Encoding.ASCII.GetString(response.Attachments[0].Content), "This is a string");
            Assert.AreEqual(response.Id, "SE322KT223222D5FJ7TJN2986");
        }
        
        /// <summary>
        /// Test createDocument
        /// </summary>
        [TestMethod]
        public void UpdateDocument()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/legalentitymanagement/Document.json");
            var service = new Documents(client);
            var document = new Document()
            {
                Attachment = new Attachment()
            };
            var response = service.Update("SE322KT223222D5FJ7TJN2986",document);
            Assert.AreEqual(Encoding.ASCII.GetString(response.Attachments[0].Content), "This is a string");
            Assert.AreEqual(response.Id, "SE322KT223222D5FJ7TJN2986");

        }
        
        /// <summary>
        /// Test deleteDocument
        /// </summary>
        [TestMethod]
        public void DeleteDocumentTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/legalentitymanagement/Document.json");
            var service = new Documents(client);
            service.Delete("SE322KT223222D5FJ7TJN2986");

        }
        #endregion
        #region TransferInstruments
        /// <summary>
        /// Test createTransferInstruments
        /// </summary>
        [TestMethod]
        public void CreateTransferInstrumentsTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/legalentitymanagement/TransferInstrument.json");
            var service = new TransferInstruments(client);
            var transferInstrumentInfo = new TransferInstrumentInfo()
            {
                LegalEntityId = "",
                Type = TransferInstrumentInfo.TypeEnum.BankAccount
            };
            var response = service.Create(transferInstrumentInfo);
            Assert.AreEqual(response.LegalEntityId, "LE322KH223222D5GG4C9J83RN");
            Assert.AreEqual(response.Id, "SE576BH223222F5GJVKHH6BDT");
        }
        /// <summary>
        /// Test updateTransferInstruments
        /// </summary>
        [TestMethod]
        public void UpdateTransferInstrumentsTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/legalentitymanagement/TransferInstrument.json");
            var service = new TransferInstruments(client);
            var transferInstrumentInfo = new TransferInstrumentInfo()
            {
                LegalEntityId = "",
                Type = TransferInstrumentInfo.TypeEnum.BankAccount
            };
            var task = service.UpdateAsync("SE576BH223222F5GJVKHH6BDT", transferInstrumentInfo);
            var response = task.Result;
            Assert.AreEqual(response.LegalEntityId, "LE322KH223222D5GG4C9J83RN");
            Assert.AreEqual(response.Id, "SE576BH223222F5GJVKHH6BDT");
        }
        #endregion

        #region HostedOnboarding
        /// <summary>
        /// Test hostedOnboarding
        /// </summary>
        [TestMethod]
        public void ListThemesTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/legalentitymanagement/OnboardingThemes.json");
            var service = new HostedOnboarding(client);
            var task = service.ListThemesAsync();
            var response = task.Result;
            Assert.AreEqual(response.Themes[0].Id, "SE322KT223222D5FJ7TJN2986");
            Assert.AreEqual(response.Themes[0].CreatedAt, DateTime.Parse("2022-10-31T01:30:00+01:00"));
        }
        #endregion
        
        #region LegalEntities
        /// <summary>
        /// Test update LegalEntities
        /// </summary>
        [TestMethod]
        public void UpdateLegalEntitiesTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/legalentitymanagement/LegalEntity.json");
            var service = new LegalEntities(client);
            var legalEntityInfo = new LegalEntityInfo()
            {
                Organization = new Organization(),
                Type = LegalEntityInfo.TypeEnum.Individual,
                EntityAssociations = new List<LegalEntityAssociation>(),
                SoleProprietorship = new SoleProprietorship()
            };
            var response = service.Update("LE322JV223222D5GG42KN6869", legalEntityInfo);
            Assert.AreEqual(response.Id, "LE322JV223222D5GG42KN6869");
            Assert.AreEqual(response.Type, LegalEntity.TypeEnum.Individual);
        }
        #endregion
        
        #region LegalEntities
        /// <summary>
        /// Test update BusinessLines
        /// </summary>
        [TestMethod]
        public void UpdateBusinessLinesTest()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/legalentitymanagement/BusinessLine.json");
            var service = new BusinessLineService(client);
            var businessLine = new BusinessLineInfo()
            {
                IndustryCode = "124rrdfer",
                SourceOfFunds = new SourceOfFunds()
            };
            var response = service.Update("SE322KT223222D5FJ7TJN2986", businessLine);
            Assert.AreEqual(response.Id, "SE322KT223222D5FJ7TJN2986");
            Assert.AreEqual(response.IndustryCode, "55");
        }
        #endregion
    }
}