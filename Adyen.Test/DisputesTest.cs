using Adyen.Model.Disputes;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class DisputesTest: BaseTest
    {
        [TestMethod]
        public void AcceptDisputesSuccess()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/disputes/accept-disputes.json");
            var disputes = new DisputesService(client);
            var response = disputes.AcceptDispute(new AcceptDisputeRequest());
            Assert.IsTrue(response.DisputeServiceResult.Success);
        }
        
        [TestMethod]
        public void DefendDisputesSuccess()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/disputes/defend-dispute.json");
            var disputes = new DisputesService(client);
            var response = disputes.DefendDispute(new DefendDisputeRequest());
            Assert.IsTrue(response.DisputeServiceResult.Success);
        }

        [TestMethod]
        public void DeleteDisputesSuccess()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/disputes/delete-dispute.json");
            var disputes = new DisputesService(client);
            var response = disputes.DeleteDisputeDefenseDocument(new DeleteDefenseDocumentRequest());
            Assert.IsTrue(response.DisputeServiceResult.Success);
        }

        [TestMethod]
        public void DownloadDisputesDefenceDocumentSuccess()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/disputes/download-defense-document.json");
            var disputes = new DisputesService(client);
            var response = disputes.DownloadDisputeDefenseDocument(new DownloadDefenseDocumentRequest());
            Assert.IsTrue(response.DisputeServiceResult.Success);
        }
        
        [TestMethod]
        public void RetrieveApplicableDefenseReasonsSuccess()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/disputes/retrieve-appicable-defense-reasons.json");
            var disputes = new DisputesService(client);
            var response = disputes.RetrieveApplicableDefenseReasons(new DefenseReasonsRequest());
            Assert.IsTrue(response.DisputeServiceResult.Success);
            Assert.IsTrue(response.DefenseReasons.Count!=0);
            Assert.AreEqual(response.DefenseReasons[0].DefenseDocumentTypes[0].DefenseDocumentTypeCode, "TIDorInvoice");
            Assert.IsFalse(response.DefenseReasons[0].DefenseDocumentTypes[0].Available);
            Assert.AreEqual(response.DefenseReasons[0].DefenseDocumentTypes[0].RequirementLevel, "Optional");
            Assert.AreEqual(response.DefenseReasons[0].DefenseDocumentTypes[1].DefenseDocumentTypeCode, "GoodsNotReturned");
            Assert.IsFalse(response.DefenseReasons[0].DefenseDocumentTypes[1].Available);
            Assert.AreEqual(response.DefenseReasons[0].DefenseDocumentTypes[1].RequirementLevel, "Required");
            Assert.AreEqual(response.DefenseReasons[0].DefenseReasonCode, "GoodsNotReturned");
            Assert.IsFalse(response.DefenseReasons[0].Satisfied);
        }
        
        [TestMethod]
        public void SupplyDisputesDefenceDocumentSuccess()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/disputes/supply-dispute-defense-document.json");
            var disputes = new DisputesService(client);
            var response = disputes.SupplyDefenseDocument(new SupplyDefenseDocumentRequest());
            Assert.IsTrue(response.DisputeServiceResult.Success);
        }
    }
}