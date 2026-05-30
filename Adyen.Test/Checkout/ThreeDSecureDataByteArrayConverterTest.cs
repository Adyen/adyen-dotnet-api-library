using System.Text;
using System.Text.Json;
using Adyen.Checkout.Client;
using Adyen.Checkout.Extensions;
using Adyen.Checkout.Models;
using Adyen.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.Checkout
{
    [TestClass]
    public class ThreeDSecureDataByteArrayConverterTest
    {
        private readonly JsonSerializerOptions _jsonSerializerOptions;

        public ThreeDSecureDataByteArrayConverterTest()
        {
            using IHost testHost = Host.CreateDefaultBuilder()
                .ConfigureCheckout((context, services, config) =>
                {
                    config.ConfigureAdyenOptions(options =>
                    {
                        options.Environment = AdyenEnvironment.Test;
                    });
                })
                .Build();

            _jsonSerializerOptions = testHost.Services.GetRequiredService<JsonSerializerOptionsProvider>().Options;
        }

        [TestMethod]
        public void Given_ThreeDSecureData_With_ByteArray_Fields_When_Serialized_Then_Roundtrip_Preserves_Values()
        {
            byte[] cavv = Encoding.UTF8.GetBytes("cavv-value");
            byte[] tavv = Encoding.UTF8.GetBytes("tavv-value");
            byte[] xid = Encoding.UTF8.GetBytes("xid-value");

            var original = new ThreeDSecureData
            {
                Cavv = cavv,
                TokenAuthenticationVerificationValue = tavv,
                Xid = xid,
            };

            string json = JsonSerializer.Serialize(original, _jsonSerializerOptions);
            var deserialized = JsonSerializer.Deserialize<ThreeDSecureData>(json, _jsonSerializerOptions);

            Assert.IsNotNull(deserialized);
            CollectionAssert.AreEqual(cavv, deserialized.Cavv);
            CollectionAssert.AreEqual(tavv, deserialized.TokenAuthenticationVerificationValue);
            CollectionAssert.AreEqual(xid, deserialized.Xid);
        }

        [TestMethod]
        public void Given_ThreeDSecureData_With_Null_ByteArray_Fields_When_Serialized_Then_Roundtrip_Preserves_Null()
        {
            var original = new ThreeDSecureData
            {
                Cavv = null,
            };

            string json = JsonSerializer.Serialize(original, _jsonSerializerOptions);
            var deserialized = JsonSerializer.Deserialize<ThreeDSecureData>(json, _jsonSerializerOptions);

            Assert.IsNotNull(deserialized);
            Assert.IsNull(deserialized.Cavv);
        }

        [TestMethod]
        public void Given_Json_With_ByteArray_Fields_When_Deserialized_Then_Returns_Expected_Bytes()
        {
            string cavvText = "adyen-cavv";
            string json = $"{{\"cavv\":\"{cavvText}\"}}";

            var result = JsonSerializer.Deserialize<ThreeDSecureData>(json, _jsonSerializerOptions);

            Assert.IsNotNull(result);
            CollectionAssert.AreEqual(Encoding.UTF8.GetBytes(cavvText), result.Cavv);
        }
    }
}
