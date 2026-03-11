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

    [TestClass]
    public class SafeStringEnumConverterTest
    {
        [JsonConverter(typeof(Adyen.Util.SafeStringEnumConverter))]
        private enum SafeTestEnum
        {
            [EnumMember(Value = "Value1")]
            Value1 = 1,

            [EnumMember(Value = "Value2")]
            Value2 = 2
        }

        private class SafeTestModel : IEquatable<SafeTestModel>
        {
            [JsonProperty("enumField")]
            public SafeTestEnum? EnumField { get; set; }

            public bool Equals(SafeTestModel input)
            {
                if (input == null) return false;
                return this.EnumField == input.EnumField ||
                    (this.EnumField != null && this.EnumField.Equals(input.EnumField));
            }

            public override bool Equals(object obj) => Equals(obj as SafeTestModel);

            public override int GetHashCode()
            {
                int hashCode = 41;
                if (this.EnumField != null)
                {
                    hashCode = (hashCode * 59) + this.EnumField.GetHashCode();
                }
                return hashCode;
            }
        }

        [TestMethod]
        public void Given_SafeStringEnumConverter_When_UnknownValue_Returns_Null()
        {
            var json = @"{""enumField"": ""UnknownValue""}";
            var result = JsonConvert.DeserializeObject<SafeTestModel>(json);
            Assert.IsNotNull(result);
            Assert.IsNull(result.EnumField);
        }

        [TestMethod]
        public void Given_SafeStringEnumConverter_When_KnownValue_Returns_CorrectEnum()
        {
            var json = @"{""enumField"": ""Value1""}";
            var result = JsonConvert.DeserializeObject<SafeTestModel>(json);
            Assert.IsNotNull(result);
            Assert.AreEqual(SafeTestEnum.Value1, result.EnumField);
        }

        [TestMethod]
        public void Given_SafeStringEnumConverter_When_NullJson_Returns_Null()
        {
            var json = @"{""enumField"": null}";
            var result = JsonConvert.DeserializeObject<SafeTestModel>(json);
            Assert.IsNotNull(result);
            Assert.IsNull(result.EnumField);
        }

        [TestMethod]
        public void Given_SafeStringEnumConverter_When_UnknownValue_Equals_DoesNotThrow()
        {
            var json = @"{""enumField"": ""UnknownValue""}";
            var a = JsonConvert.DeserializeObject<SafeTestModel>(json);
            var b = JsonConvert.DeserializeObject<SafeTestModel>(json);
            Assert.IsNull(a.EnumField);
            Assert.IsTrue(a.Equals(b));
        }

        [TestMethod]
        public void Given_SafeStringEnumConverter_When_UnknownValue_GetHashCode_DoesNotThrow()
        {
            var json = @"{""enumField"": ""UnknownValue""}";
            var result = JsonConvert.DeserializeObject<SafeTestModel>(json);
            Assert.IsNull(result.EnumField);
            var hashCode = result.GetHashCode();
            Assert.AreEqual(41, hashCode);
        }

        [TestMethod]
        public void Given_RealModel_When_UnknownEnumValue_Equals_DoesNotThrow()
        {
            // Use a real model class (Modification) to verify null guards work
            var json = @"{""status"": ""someUnknownFutureStatus""}";
            var a = JsonConvert.DeserializeObject<Adyen.Model.TransferWebhooks.Modification>(json);
            var b = JsonConvert.DeserializeObject<Adyen.Model.TransferWebhooks.Modification>(json);
            
            Assert.IsNotNull(a);
            Assert.IsNull(a.Status, "Unknown enum value should deserialize to null");
            Assert.IsTrue(a.Equals(b), "Equals should not throw NRE when enum is null");
        }

        [TestMethod]
        public void Given_RealModel_When_UnknownEnumValue_GetHashCode_DoesNotThrow()
        {
            // Use a real model class (Modification) to verify null guards work
            var json = @"{""status"": ""someUnknownFutureStatus""}";
            var result = JsonConvert.DeserializeObject<Adyen.Model.TransferWebhooks.Modification>(json);
            
            Assert.IsNotNull(result);
            Assert.IsNull(result.Status, "Unknown enum value should deserialize to null");
            
            // Should not throw NullReferenceException
            var hashCode = result.GetHashCode();
            Assert.IsTrue(hashCode != 0, "GetHashCode should return a valid value");
        }
    }
}
