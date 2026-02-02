using System.Runtime.Serialization;
using Adyen.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Adyen.Test
{
    [TestClass]
    public class SafeStringEnumConverterTest
    {
        public enum TestEnum
        {
            [EnumMember(Value = "Value1")]
            Value1 = 1,
            
            [EnumMember(Value = "Value2")]
            Value2 = 2
        }

        public class NullableEnumModel
        {
            [JsonProperty("enumField")]
            public TestEnum? EnumField { get; set; }
        }

        public class NonNullableEnumModel
        {
            [JsonProperty("enumField")]
            public TestEnum EnumField { get; set; }
        }

        private static JsonSerializerSettings GetSettings()
        {
            var settings = new JsonSerializerSettings();
            settings.Converters.Add(new SafeStringEnumConverter());
            return settings;
        }

        [TestMethod]
        public void SafeStringEnumConverter_UnknownValue_NullableEnum_ReturnsNull()
        {
            var json = @"{""enumField"": ""UnknownValue""}";
            
            var result = JsonConvert.DeserializeObject<NullableEnumModel>(json, GetSettings());
            
            Assert.IsNotNull(result);
            Assert.IsNull(result.EnumField);
        }

        [TestMethod]
        public void SafeStringEnumConverter_KnownValue_NullableEnum_ReturnsValue()
        {
            var json = @"{""enumField"": ""Value1""}";
            
            var result = JsonConvert.DeserializeObject<NullableEnumModel>(json, GetSettings());
            
            Assert.IsNotNull(result);
            Assert.AreEqual(TestEnum.Value1, result.EnumField);
        }

        [TestMethod]
        public void SafeStringEnumConverter_NullValue_NullableEnum_ReturnsNull()
        {
            var json = @"{""enumField"": null}";
            
            var result = JsonConvert.DeserializeObject<NullableEnumModel>(json, GetSettings());
            
            Assert.IsNotNull(result);
            Assert.IsNull(result.EnumField);
        }

        [TestMethod]
        public void SafeStringEnumConverter_MissingField_NullableEnum_ReturnsNull()
        {
            var json = @"{}";
            
            var result = JsonConvert.DeserializeObject<NullableEnumModel>(json, GetSettings());
            
            Assert.IsNotNull(result);
            Assert.IsNull(result.EnumField);
        }

        [TestMethod]
        [ExpectedException(typeof(JsonSerializationException))]
        public void SafeStringEnumConverter_UnknownValue_NonNullableEnum_ThrowsException()
        {
            // Non-nullable enums should still throw to maintain backward compatibility
            var json = @"{""enumField"": ""UnknownValue""}";
            
            JsonConvert.DeserializeObject<NonNullableEnumModel>(json, GetSettings());
        }

        [TestMethod]
        public void SafeStringEnumConverter_KnownValue_NonNullableEnum_ReturnsValue()
        {
            var json = @"{""enumField"": ""Value2""}";
            
            var result = JsonConvert.DeserializeObject<NonNullableEnumModel>(json, GetSettings());
            
            Assert.IsNotNull(result);
            Assert.AreEqual(TestEnum.Value2, result.EnumField);
        }
    }
}
