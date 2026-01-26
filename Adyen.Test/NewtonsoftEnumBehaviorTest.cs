using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using Xunit;

namespace Adyen.Test
{
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

        [Fact]
        public void TestNewtonsoft_UnknownEnumValue_WithNullable()
        {
            // Test if Newtonsoft.Json handles unknown enum values gracefully with nullable enums
            var json = @"{""enumField"": ""UnknownValue""}";
            
            // This will tell us if we need a custom converter or not
            var exception = Record.Exception(() => JsonConvert.DeserializeObject<TestModel>(json));
            
            if (exception == null)
            {
                var result = JsonConvert.DeserializeObject<TestModel>(json);
                Assert.Null(result.EnumField);
            }
            else
            {
                // If this throws, we need a custom converter
                Assert.IsType<JsonSerializationException>(exception);
            }
        }

        [Fact]
        public void TestNewtonsoft_KnownEnumValue_WithNullable()
        {
            var json = @"{""enumField"": ""Value1""}";
            var result = JsonConvert.DeserializeObject<TestModel>(json);
            
            Assert.NotNull(result);
            Assert.Equal(TestEnum.Value1, result.EnumField);
        }
    }
}
