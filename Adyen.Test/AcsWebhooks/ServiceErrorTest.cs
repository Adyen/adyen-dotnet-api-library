using Adyen.AcsWebhooks.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;

namespace Adyen.Test.AcsWebhooks
{
    [TestClass]
    public class ServiceErrorTest
    {
        /// <summary>
        /// Regression test for GitHub issue #1474 applied to a non-Checkout namespace.
        /// Verifies that <see cref="ServiceError"/>, which has all-optional
        /// fields, can be deserialized using default <see cref="JsonSerializerOptions"/> without throwing.
        /// The <c>[JsonConstructor]</c> regression affected every generated model across all namespaces.
        /// </summary>
        [TestMethod]
        public void Given_ServiceError_When_Deserialized_With_Default_Options_Then_Does_Not_Throw()
        {
            // Arrange
            string json = "{\"errorCode\":\"000\",\"message\":\"test error\",\"status\":422}";

            // Act
            ServiceError result = JsonSerializer.Deserialize<ServiceError>(json);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("000", result.ErrorCode);
            Assert.AreEqual("test error", result.Message);
            Assert.AreEqual(422, result.Status);
        }
    }
}
