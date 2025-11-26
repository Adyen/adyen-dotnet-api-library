using System.Text;
using Adyen.Core.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.Core.Utilities
{
    [TestClass]
    public class HmacValidatorUtilityTest
    {
        private const string _targetPayload = "{\"test\":\"value\"}";
        private const string _hmacKey = "00112233445566778899AABBCCDDEEFF";

        /// <summary>
        /// Helper function that computes expected HMAC.
        /// </summary>
        private string ComputeExpectedHmac(string payload, string hexKey)
        {
            byte[] key = new byte[hexKey.Length / 2];
            for (int i = 0; i < hexKey.Length; i += 2)
            {
                key[i / 2] = Convert.ToByte(hexKey.Substring(i, 2), 16);
            }

            byte[] data = Encoding.UTF8.GetBytes(payload);
            using var hmac = new System.Security.Cryptography.HMACSHA256(key);
            var raw = hmac.ComputeHash(data);
            return Convert.ToBase64String(raw);
        }
        
        
        [TestMethod]
        public void Given_GenerateBase64Sha256HmacSignature_When_Hmac_Provided_Returns_Correct_Signature()
        {
            // Arrange
            string expected = ComputeExpectedHmac(_targetPayload, _hmacKey);

            // Act
            string actual = HmacValidatorUtility.GenerateBase64Sha256HmacSignature(_targetPayload, _hmacKey);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Given_GenerateBase64Sha256HmacSignature__When_Odd_Length_HmacKey_Returns_Correct_Signature()
        {
            // Arrange
            string paddedKey = "ABC0";   // Expected padded version
            string expected = ComputeExpectedHmac(_targetPayload, paddedKey);

            // Act
            string actual = HmacValidatorUtility.GenerateBase64Sha256HmacSignature(_targetPayload, "ABC"); // Will be padded to "ABC0"

            // Assert
            Assert.AreEqual(expected, actual);
        }
            
        
        [TestMethod]
        public void Given_IsHmacSignatureValid_When_Signature_Is_NotEqual_Returns_False()
        {
            // Arrange
            string invalidSignature = "InvalidSignature123==";

            // Act
            // Assert
            Assert.IsFalse(HmacValidatorUtility.IsHmacSignatureValid(invalidSignature, _hmacKey, _targetPayload));
        }
        
        
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

        [TestMethod]
        public void Given_GenerateBase64Sha256HmacSignature_When_BalancePlatform_Webhook_Returns_Correct_Signature()
        {
            // Arrange
            string notification =
                "{\"data\":{\"balancePlatform\":\"Integration_tools_test\",\"accountId\":\"BA32272223222H5HVKTBK4MLB\",\"sweep\":{\"id\":\"SWPC42272223222H5HVKV6H8C64DP5\",\"schedule\":{\"type\":\"balance\"},\"status\":\"active\",\"targetAmount\":{\"currency\":\"EUR\",\"value\":0},\"triggerAmount\":{\"currency\":\"EUR\",\"value\":0},\"type\":\"pull\",\"counterparty\":{\"balanceAccountId\":\"BA3227C223222H5HVKT3H9WLC\"},\"currency\":\"EUR\"}},\"environment\":\"test\",\"type\":\"balancePlatform.balanceAccountSweep.updated\"}";
            string hmacKey = "D7DD5BA6146493707BF0BE7496F6404EC7A63616B7158EC927B9F54BB436765F";
            string expectedHmacSignature = "9Qz9S/0xpar1klkniKdshxpAhRKbiSAewPpWoxKefQA=";

            // Act
            string generatedHmacSignature = HmacValidatorUtility.GenerateBase64Sha256HmacSignature(notification, hmacKey);

            // Assert
            Assert.AreEqual(expectedHmacSignature, generatedHmacSignature);
        }
    }
}