using System;
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
        public void TestNewtonsoft_UnknownEnumValue_WithNullable()
        {
            // Test if Newtonsoft.Json handles unknown enum values gracefully with nullable enums
            var json = @"{""enumField"": ""UnknownValue""}";
            
            // This will tell us if we need a custom converter or not
            Exception exception = null;
            try
            {
                JsonConvert.DeserializeObject<TestModel>(json);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            
            if (exception == null)
            {
                var result = JsonConvert.DeserializeObject<TestModel>(json);
                Assert.IsNull(result.EnumField);
            }
            else
            {
                // If this throws, we need a custom converter
                Assert.IsInstanceOfType(exception, typeof(JsonSerializationException));
            }
        }

        [TestMethod]
        public void TestNewtonsoft_KnownEnumValue_WithNullable()
        {
            var json = @"{""enumField"": ""Value1""}";
            var result = JsonConvert.DeserializeObject<TestModel>(json);
            
            Assert.IsNotNull(result);
            Assert.AreEqual(TestEnum.Value1, result.EnumField);
        }
    }
}
