using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Test
{
    // Base class 
    public abstract class StringEnumBase : IEquatable<StringEnumBase>, IValidatableObject
    {
        private readonly string _value;
        
        protected StringEnumBase(string value)
        {
            _value = value;
        }
        
        public abstract StringEnumBase FromString(string value);
        
        public override string ToString()
        {
            return _value;
        }

        public override bool Equals(object obj)
        {
            if (obj is StringEnumBase otherEnum) 
                return _value.Equals(otherEnum._value);
            return false;
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }
        
        public static bool operator ==(StringEnumBase a, StringEnumBase b)
        {
            if (a is null) 
                return b is null;
            return a.Equals(b);
        }

        public static bool operator !=(StringEnumBase a, StringEnumBase b)
        {
            return !(a == b);
        }
        
        public bool Equals(StringEnumBase other)
        {
            if (other is null)
                return false;
            return _value == other._value;
        }
        
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
    
    // Converter that can take a json string and match it to the correct class
    public class StringEnumBaseConverter<T> : JsonConverter where T : StringEnumBase, new()
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(T).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var value = reader.Value.ToString();
            return new T().FromString(value);
        }
        
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var stringEnum = (StringEnumBase)value;
            writer.WriteValue(stringEnum.ToString());
        }
    }
    
    /// Example class to deserialize
    [DataContract(Name = "AuthenticationInfo")]
    public class AuthenticationInfo : IEquatable<AuthenticationInfo>, IValidatableObject
    {
        [JsonConverter(typeof(StringEnumBaseConverter<ChallengeIndicatorEnum>))]
        public class ChallengeIndicatorEnum : StringEnumBase
        {
            public ChallengeIndicatorEnum() : base(null)
            {
            }

            private ChallengeIndicatorEnum(string value = null) : base(value)
            {
            }

            public static ChallengeIndicatorEnum _01 = new ChallengeIndicatorEnum("01");
            public static ChallengeIndicatorEnum _02 = new ChallengeIndicatorEnum("02");
            public static ChallengeIndicatorEnum _03 = new ChallengeIndicatorEnum("03");
            public static ChallengeIndicatorEnum _04 = new ChallengeIndicatorEnum("04");

            public override StringEnumBase FromString(string value)
            {
                switch(value)
                {
                    case null:
                        return null;
                    case "01":
                        return _01;
                    case "02":
                        return _02;
                    case "03":
                        return _03;
                    case "04":
                        return _04;
                    default:
                        throw new ArgumentException($"Unhandled value: {value}");
                };
            }
        }
        
        [DataMember(Name = "challengeIndicator", IsRequired = false, EmitDefaultValue = false)]
        public ChallengeIndicatorEnum ChallengeIndicator { get; set; }
        
        // This is the original
        // [JsonConverter(typeof(StringEnumConverter))]
        // public enum ChallengeIndicatorEnum
        // {
        //     /// <summary>
        //     /// Enum _01 for value: 01
        //     /// </summary>
        //     [EnumMember(Value = "01")]
        //     _01 = 1,
        //
        //     /// <summary>
        //     /// Enum _02 for value: 02
        //     /// </summary>
        //     [EnumMember(Value = "02")]
        //     _02 = 2,
        //
        //     /// <summary>
        //     /// Enum _03 for value: 03
        //     /// </summary>
        //     [EnumMember(Value = "03")]
        //     _03 = 3,
        //
        //     /// <summary>
        //     /// Enum _04 for value: 04
        //     /// </summary>
        //     [EnumMember(Value = "04")]
        //     _04 = 4,
        //
        //     /// <summary>
        //     /// Enum _05 for value: 05
        //     /// </summary>
        //     [EnumMember(Value = "05")]
        //     _05 = 5,
        //
        //     /// <summary>
        //     /// Enum _07 for value: 07
        //     /// </summary>
        //     [EnumMember(Value = "07")]
        //     _07 = 6,
        //
        //     /// <summary>
        //     /// Enum _08 for value: 08
        //     /// </summary>
        //     [EnumMember(Value = "08")]
        //     _08 = 7,
        //
        //     /// <summary>
        //     /// Enum _09 for value: 09
        //     /// </summary>
        //     [EnumMember(Value = "09")]
        //     _09 = 8,
        //
        //     /// <summary>
        //     /// Enum _80 for value: 80
        //     /// </summary>
        //     [EnumMember(Value = "80")]
        //     _80 = 9,
        //
        //     /// <summary>
        //     /// Enum _82 for value: 82
        //     /// </summary>
        //     [EnumMember(Value = "82")]
        //     _82 = 10
        //
        // }
        //
        // /// <summary>
        // /// Specifies a preference for receiving a challenge. Possible values:  * **01**: No preference * **02**: No challenge requested * **03**: Challenge requested (preference) * **04**: Challenge requested (mandate) * **05**: No challenge requested (transactional risk analysis is already performed) * **07**: No challenge requested (SCA is already performed) * **08**: No challenge requested (trusted beneficiaries exemption of no challenge required) * **09**: Challenge requested (trusted beneficiaries prompt requested if challenge required) * **80**: No challenge requested (secure corporate payment with Mastercard) * **82**: No challenge requested (secure corporate payment with Visa) 
        // /// </summary>
        // /// <value>Specifies a preference for receiving a challenge. Possible values:  * **01**: No preference * **02**: No challenge requested * **03**: Challenge requested (preference) * **04**: Challenge requested (mandate) * **05**: No challenge requested (transactional risk analysis is already performed) * **07**: No challenge requested (SCA is already performed) * **08**: No challenge requested (trusted beneficiaries exemption of no challenge required) * **09**: Challenge requested (trusted beneficiaries prompt requested if challenge required) * **80**: No challenge requested (secure corporate payment with Mastercard) * **82**: No challenge requested (secure corporate payment with Visa) </value>
        // [DataMember(Name = "challengeIndicator", IsRequired = true, EmitDefaultValue = false)]
        // public ChallengeIndicatorEnum ChallengeIndicator { get; set; }

  
        /// <summary>
        /// Returns true if AuthenticationInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthenticationInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticationInfo input)
        {
            if (input == null)
            {
                return false;
            }

            return
                (
                    this.ChallengeIndicator == input.ChallengeIndicator ||
                    this.ChallengeIndicator.Equals(input.ChallengeIndicator)
                );
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
        
        // Test -> random string
        [DataMember(Name = "test", IsRequired = false, EmitDefaultValue = false)]
        public string Test { get; set; }
    }
    
    [TestClass]
    public class BaseEnumTest : BaseTest
    {
        private readonly JsonSerializerSettings _jsonSettings;
        
        public BaseEnumTest()
        {
            _jsonSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Include,
            };
            _jsonSettings.Converters.Add(new StringEnumConverter());
        }
        
        [DataTestMethod]
        [DataRow(@"{""Test"": ""Aaa""}")]
        [DataRow(@"{""challengeIndicator"": null, ""Test"": ""Aaa""}")]
        public void When_No_ChallengeIndicator_Is_Provided_ResultShouldBe_Null(string json)
        {
            AuthenticationInfo info = JsonConvert.DeserializeObject<AuthenticationInfo>(json, _jsonSettings);
            Assert.AreEqual(null, info.ChallengeIndicator);
        }

        [DataTestMethod]
        [DataRow(@"{""challengeIndicator"": ""null"", ""Test"": ""Aaa""}")]
        [DataRow(@"{""challengeIndicator"": 0, ""Test"": ""Aaa""}")]
        [DataRow(@"{""challengeIndicator"": ""invalidEnum"", ""Test"": ""Aaa""}")]
        public void When_Value_Is_Not_In_List_ResultShouldThrow_ArugmentException(string json)
        {
            Assert.ThrowsException<ArgumentException>(() => JsonConvert.DeserializeObject<AuthenticationInfo>(json, _jsonSettings));
        }
        

        [DataTestMethod]
        [DataRow(@"{""challengeIndicator"": ""03"", ""Test"": ""Aaa""}")]
        [DataRow(@"{""ChallengeIndicator"": ""03"", ""Test"": ""Aaa""}")]
        public void When_Value_Is_In_List_ResultShouldBe__03(string json)
        {
            AuthenticationInfo info = JsonConvert.DeserializeObject<AuthenticationInfo>(json, _jsonSettings);
            Assert.AreEqual(AuthenticationInfo.ChallengeIndicatorEnum._03, info.ChallengeIndicator);
        }

        [TestMethod]
        public void WhenEqualOperatorOrEqualsFunction_Is_Called_ResultShouldBe_Expected()
        {
            var a = AuthenticationInfo.ChallengeIndicatorEnum._01;
            var aa = AuthenticationInfo.ChallengeIndicatorEnum._01;
            
            var b = AuthenticationInfo.ChallengeIndicatorEnum._02;
            var c = AuthenticationInfo.ChallengeIndicatorEnum._03;
            var d = AuthenticationInfo.ChallengeIndicatorEnum._04;

            Assert.AreEqual(a, a); Assert.IsTrue(a == a);
            Assert.AreEqual(a, aa); Assert.IsTrue(a == aa);
            Assert.AreNotEqual(a, b); Assert.IsTrue(a != b);
            Assert.AreNotEqual(a, c); Assert.IsTrue(a != c);
            Assert.AreNotEqual(a, d); Assert.IsTrue(a != d);
            Assert.AreNotEqual(a, null); Assert.IsTrue(a != null);
        }
    }
}