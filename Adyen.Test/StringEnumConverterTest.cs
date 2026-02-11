using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class StringEnumConverterTest
    {
        [JsonConverter(typeof(StringEnumConverter))]
        private enum TestEnum
        {
            [EnumMember(Value = "Value1")]
            Value1 = 1,
            
            [EnumMember(Value = "Value2")]
            Value2 = 2
        }

        private class TestModel
        {
            [JsonProperty("enumField")]
            public TestEnum? EnumField { get; set; }
        }

        [TestMethod]
        [ExpectedException(typeof(JsonSerializationException))]
        public void Given_StringEnumConverter_When_UnknownValue_Throws_JsonSerializationException()
        {
            var json = @"{""enumField"": ""UnknownValue""}";
            JsonConvert.DeserializeObject<TestModel>(json);
        }

        [TestMethod]
        public void Given_StringEnumConverter_When_Null_Result_TestModel_EnumField_Is_Null()
        {
            var json = @"{""enumField"": null}";
            
            var result = JsonConvert.DeserializeObject<TestModel>(json);
            Assert.IsNull(result.EnumField);
        }

        [TestMethod]
        public void Given_StringEnumConverter_When_Value1_Returns_Value1_As_Enum()
        {
            var json = @"{""enumField"": ""Value1""}";
            var result = JsonConvert.DeserializeObject<TestModel>(json);
            
            Assert.IsNotNull(result);
            Assert.AreEqual(TestEnum.Value1, result.EnumField);
        }
    }
}
