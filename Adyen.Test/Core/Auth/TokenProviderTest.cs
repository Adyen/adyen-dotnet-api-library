using Adyen.Core.Auth;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.Core.Auth
{
    [TestClass]
    public class TokenProviderTest
    {
        internal sealed class TestToken : TokenBase
        {
            public string Value { get; }

            internal TestToken(string value)
            {
                Value = value;
            }
        }

        [TestMethod]
        public void Given_TokenProviderWithToken_When_GetCalled_Then_SameInstanceAndValueAreReturned()
        {
            // Arrange
            var token = new TestToken("apikey");
            var provider = new TokenProvider<TestToken>(token);

            // Act
            var result = provider.Get();

            // Assert
            Assert.AreSame(token, result);
            Assert.AreEqual("apikey", result.Value);
        }

        [TestMethod]
        public void Given_TokenProvider_When_GetCalledMultipleTimes_Then_SameInstanceReturnedEachTime()
        {
            // Arrange
            var token = new TestToken("apikey");
            var provider = new TokenProvider<TestToken>(token);

            // Act
            var first = provider.Get();
            var second = provider.Get();

            // Assert
            Assert.AreSame(first, second);
        }
    }
}