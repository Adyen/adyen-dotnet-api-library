using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Adyen.Model.LegalEntityManagement;
using Adyen.Service.LegalEntityManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

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
            var service = new DocumentsService(client);
            var document = new Document
            {
                Attachment = new Attachment()
            };
            var response = service.UploadDocumentForVerificationChecks(document);
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
            var service = new DocumentsService(client);
            var document = new Document
            {
                Attachment = new Attachment()
            };
            var response = service.UpdateDocument("SE322KT223222D5FJ7TJN2986",document);
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
            var service = new DocumentsService(client);
            service.DeleteDocument("SE322KT223222D5FJ7TJN2986");

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
            var service = new TransferInstrumentsService(client);
            var transferInstrumentInfo = new TransferInstrumentInfo
            {
                LegalEntityId = "",
                Type = TransferInstrumentInfo.TypeEnum.BankAccount
            };
            var response = service.CreateTransferInstrument(transferInstrumentInfo);
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
            var service = new TransferInstrumentsService(client);
            var transferInstrumentInfo = new TransferInstrumentInfo
            {
                LegalEntityId = "",
                Type = TransferInstrumentInfo.TypeEnum.BankAccount
            };
            var task = service.UpdateTransferInstrumentAsync("SE576BH223222F5GJVKHH6BDT", transferInstrumentInfo);
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
            var service = new HostedOnboardingService(client);
            var task = service.ListHostedOnboardingPageThemesAsync();
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
            var service = new LegalEntitiesService(client);
            var legalEntityInfo = new LegalEntityInfo
            {
                Organization = new Organization(),
                Type = LegalEntityInfo.TypeEnum.Individual,
                EntityAssociations = new List<LegalEntityAssociation>(),
                SoleProprietorship = new SoleProprietorship()
            };
            var response = service.UpdateLegalEntity("LE322JV223222D5GG42KN6869", legalEntityInfo);
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
            var service = new BusinessLinesService(client);
            var businessLine = new BusinessLineInfoUpdate
            {
                IndustryCode = "124rrdfer",
                SourceOfFunds = new SourceOfFunds()
            };
            var response = service.UpdateBusinessLine("SE322KT223222D5FJ7TJN2986", businessLine);
            Assert.AreEqual(response.Id, "SE322KT223222D5FJ7TJN2986");
            Assert.AreEqual(response.IndustryCode, "55");
        }
        #endregion
        
        #region TermsOfService
        /// <summary>
        /// Test get TermsOfService Status
        /// </summary>
        [TestMethod]
        public void GetTermsOfServiceStatus()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/legalentitymanagement/TermsOfServiceStatus.json");
            var service = new TermsOfServiceService(client);
            var response = service.GetTermsOfServiceInformationForLegalEntity("id123");
            ClientInterfaceMock.Verify(mock =>
                mock.RequestAsync(
                    "https://kyc-test.adyen.com/lem/v3/legalEntities/id123/termsOfServiceAcceptanceInfos",
                    null,
                    null,
                    new HttpMethod("GET"), default));
            Assert.AreEqual(response.Data[0].Type, TermsOfServiceAcceptanceInfo.TypeEnum.AdyenIssuing);
        }
        #endregion
    }
}
