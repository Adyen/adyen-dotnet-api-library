using Adyen.Model.DataProtection;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class DataProtectionTest : BaseTest
    {
        [TestMethod]
        public void TestRequestSubjectErasure()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/data-protection-response.json");
            var service = new DataProtectionService(client);
            var response = service.RequestSubjectErasure(new SubjectErasureByPspReferenceRequest());
            Assert.AreEqual(response.Result, SubjectErasureResponse.ResultEnum.ACTIVERECURRINGTOKENEXISTS);
        }
    }
}