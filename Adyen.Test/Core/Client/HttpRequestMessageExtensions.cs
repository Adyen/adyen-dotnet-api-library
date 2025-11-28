using Adyen.Core.Client.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.Core.Client
{
    [TestClass]
    public class HttpRequestMessageExtensionsTest
    {
        [TestMethod]
        public void Given_AddUserAgentToHeaders_When_ApplicationName_Is_Null_Returns_adyen_dotnet_api_library_And_AdyenLibraryVersion()
        {
            // Arrange
            HttpRequestMessageExtensions.ApplicationName = null;
            var request = new HttpRequestMessage();

            // Act
            request.AddUserAgentToHeaders();
            
            // Assert
            string target = request.Headers.GetValues("UserAgent").First();
            Assert.AreEqual($"adyen-dotnet-api-library/{HttpRequestMessageExtensions.AdyenLibraryVersion}", target);
        }

        [TestMethod]
        public void Given_AddUserAgentToHeaders_When_ApplicationName_Is_Set_Returns_MyApp_adyen_dotnet_api_library_And_AdyenLibraryVersion()
        {
            // Arrange
            var request = new HttpRequestMessage();
            HttpRequestMessageExtensions.ApplicationName = "MyApp";

            // Act
            request.AddUserAgentToHeaders();

            // Assert
            string target = request.Headers.GetValues("UserAgent").First();
            Assert.AreEqual($"MyApp adyen-dotnet-api-library/{HttpRequestMessageExtensions.AdyenLibraryVersion}", target);
        }

        [TestMethod]
        public void Given_AddLibraryNameToHeader_When_Provided_Returns_adyen_dotnet_api_library()
        {
            // Arrange
            HttpRequestMessageExtensions.ApplicationName = null;
            var request = new HttpRequestMessage();

            // Act
            request.AddLibraryNameToHeader();

            // Assert
            string target = request.Headers.GetValues("adyen-library-name").First();
            Assert.AreEqual("adyen-dotnet-api-library", target);
        }

        [TestMethod]
        public void Given_AddLibraryNameToHeader_When_Provided_Returns_AdyenLibraryVersion()
        {
            // Arrange
            HttpRequestMessageExtensions.ApplicationName = null;
            var request = new HttpRequestMessage();

            // Act
            request.AddLibraryVersionToHeader();

            // Assert
            string target = request.Headers.GetValues("adyen-library-version").First();
            Assert.AreEqual(HttpRequestMessageExtensions.AdyenLibraryVersion, target);
        }

        [TestMethod]
        public void Given_AddUserAgentToHeaders_When_Called_MultipleTimes_Should_Not_Throw_Any_Exceptions()
        {
            // Arrange
            HttpRequestMessageExtensions.ApplicationName = null;
            var request = new HttpRequestMessage();

            // Act
            // Assert
            try
            {
                request.AddUserAgentToHeaders();
                request.AddUserAgentToHeaders();
                
                request.AddLibraryNameToHeader();
                request.AddLibraryNameToHeader();
                
                request.AddLibraryVersionToHeader();
                request.AddLibraryVersionToHeader();
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }
    }
}