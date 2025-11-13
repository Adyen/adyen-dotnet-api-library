using Adyen.Core.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.Core.Utilities
{
    public class HmacValidatorUtilityTest
    {
        [TestMethod]
        public void TestBalancePlatformHmac()
        {
            // Arrange
            string notification =
                "{\"data\":{\"balancePlatform\":\"Integration_tools_test\",\"accountId\":\"BA32272223222H5HVKTBK4MLB\",\"sweep\":{\"id\":\"SWPC42272223222H5HVKV6H8C64DP5\",\"schedule\":{\"type\":\"balance\"},\"status\":\"active\",\"targetAmount\":{\"currency\":\"EUR\",\"value\":0},\"triggerAmount\":{\"currency\":\"EUR\",\"value\":0},\"type\":\"pull\",\"counterparty\":{\"balanceAccountId\":\"BA3227C223222H5HVKT3H9WLC\"},\"currency\":\"EUR\"}},\"environment\":\"test\",\"type\":\"balancePlatform.balanceAccountSweep.updated\"}";
            string hmacKey = "D7DD5BA6146493707BF0BE7496F6404EC7A63616B7158EC927B9F54BB436765F";
            string hmacSignature = "9Qz9S/0xpar1klkniKdshxpAhRKbiSAewPpWoxKefQA=";
            
            // Act
            bool isValidSignature = HmacValidatorUtility.IsHmacSignatureValid(hmacSignature, hmacKey, notification);
            
            // Assert
            Assert.IsTrue(isValidSignature);
        }
    }
}