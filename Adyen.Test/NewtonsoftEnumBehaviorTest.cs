using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class NewtonsoftEnumBehaviorTest
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TestEnum
        {
            [EnumMember(Value = "Value1")]
            Value1 = 1,
            
            [EnumMember(Value = "Value2")]
            Value2 = 2
        }

        public class TestModel
        {
            [JsonProperty("enumField")]
            public TestEnum? EnumField { get; set; }
        }

        [TestMethod]
        [ExpectedException(typeof(JsonSerializationException))]
        public void TestNewtonsoft_UnknownEnumValue_ThrowsException()
        {
            // Demonstrates that StringEnumConverter throws JsonSerializationException for unknown enum values.
            // This is why SafeStringEnumConverter is needed - to handle unknown values gracefully.
            var json = @"{""enumField"": ""UnknownValue""}";
            
            JsonConvert.DeserializeObject<TestModel>(json);
        }

        [TestMethod]
        public void TestNewtonsoft_KnownEnumValue_WithNullable()
        {
            var json = @"{""enumField"": ""Value1""}";
            var result = JsonConvert.DeserializeObject<TestModel>(json);
            
            Assert.IsNotNull(result);
            Assert.AreEqual(TestEnum.Value1, result.EnumField);
        }

        [TestMethod]
        public void TestNewtonsoft_NullEnumValue_WithNullable()
        {
            var json = @"{""enumField"": null}";
            var result = JsonConvert.DeserializeObject<TestModel>(json);
            
            Assert.IsNotNull(result);
            Assert.IsNull(result.EnumField);
        }
    }
}
