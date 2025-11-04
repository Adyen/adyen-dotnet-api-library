using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.Core
{
    public class IEnumTest
    {
        [TestClass]
        public class IEnumTestTests
        {
            [TestMethod]
            public async Task Given_Enums_When_Equal_Returns_Correct_True()
            {
                ExampleEnum? nullEnum = null;
                
                Assert.AreEqual(nullEnum, nullEnum);
                Assert.AreEqual(ExampleEnum.A, ExampleEnum.A);
                Assert.AreEqual(ExampleEnum.B, ExampleEnum.B);
            }
            
            [TestMethod]
            public async Task Given_Enums_When_NotEqual_Returns_Correct_False()
            {
                ExampleEnum? nullEnum = null;
                
                Assert.AreNotEqual(ExampleEnum.A, ExampleEnum.B);
                Assert.AreNotEqual(ExampleEnum.B, nullEnum);
                Assert.AreNotEqual(ExampleEnum.A, nullEnum);
            }
            
            [TestMethod]
            public async Task Given_ImplicitConversion_When_Initialized_Then_Returns_Correct_Values()
            {
                ExampleEnum? resultA = "a";
                ExampleEnum? resultB = "b";
                
                Assert.AreEqual(ExampleEnum.A, resultA);
                Assert.AreEqual(ExampleEnum.B, resultB);
            }

            [TestMethod]
            public async Task Given_ImplicitConversion_When_Null_Then_Returns_Null()
            {
                ExampleEnum? input = null;
                string? result = input;
                
                Assert.IsNull(result);
            }

            [TestMethod]
            public async Task Given_ToString_When_Called_Then_Returns_Correct_Value()
            {
                Assert.AreEqual("a", ExampleEnum.A.ToString());
                Assert.AreEqual("b", ExampleEnum.B.ToString());
            }

            [TestMethod]
            public async Task Given_ToString_When_Null_Then_Returns_Empty_String()
            {
                ExampleEnum result = ExampleEnum.FromStringOrDefault("this-is-not-a-valid-enum");
                
                Assert.IsNull(result);
            }

            [TestMethod]
            public async Task Given_Equals_When_ComparingCaseInsensitive_Then_Returns_True()
            {
                ExampleEnum result = ExampleEnum.A;
                
                Assert.IsTrue(result.Equals(ExampleEnum.A));
                Assert.IsFalse(result.Equals(ExampleEnum.B));
            }

            [TestMethod]
            public async Task Given_FromStringOrDefault_When_InvalidString_Then_Returns_Null()
            {
                Assert.IsNull(ExampleEnum.FromStringOrDefault("this-is-not-a-valid-enum"));
            }

            [TestMethod]
            public async Task Given_EqualityOperator_When_ComparingValues_Then_Returns_Correct_Values()
            {
                ExampleEnum target = ExampleEnum.A;
                ExampleEnum otherA = ExampleEnum.A;
                ExampleEnum otherB = ExampleEnum.B;

                Assert.IsTrue(target == otherA);
                Assert.IsFalse(target == otherB);
                Assert.IsTrue(target != otherB);
                Assert.IsFalse(target != otherA);
            }

            [TestMethod]
            public async Task Given_FromStringOrDefault_When_ValidStrings_Then_Returns_Correct_Enum()
            {
                Assert.AreEqual(ExampleEnum.A, ExampleEnum.FromStringOrDefault("a"));
                Assert.AreEqual(ExampleEnum.B, ExampleEnum.FromStringOrDefault("b"));
            }

            #region ToJsonValue
            [TestMethod]
            public async Task Given_ToJsonValue_When_KnownEnum_Then_Returns_String()
            {
                Assert.AreEqual("a", ExampleEnum.ToJsonValue(ExampleEnum.A));
                Assert.AreEqual("b", ExampleEnum.ToJsonValue(ExampleEnum.B));
            }

            [TestMethod]
            public async Task Given_ToJsonValue_When_Null_Then_Returns_Null()
            {
                Assert.IsNull(ExampleEnum.ToJsonValue(null));
            }

            [TestMethod]
            public async Task Given_ToJsonValue_When_CustomEnum_Then_Returns_Null()
            {
                ExampleEnum custom = ExampleEnum.FromStringOrDefault("this-is-not-a-valid-enum");
                Assert.IsNull(ExampleEnum.ToJsonValue(custom));
            }
            #endregion
            
            
            #region JsonSerialization and JsonDeserialization
            [TestMethod]
            public async Task Given_JsonSerialization_When_KnownEnum_Then_Serialize_and_Deserialize_Correctly()
            {
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.Converters.Add(new ExampleEnum.ExampleJsonConverter());

                string serializedA = JsonSerializer.Serialize(ExampleEnum.A, options);
                string serializedB = JsonSerializer.Serialize(ExampleEnum.B, options);

                Assert.AreEqual("\"a\"", serializedA);
                Assert.AreEqual("\"b\"", serializedB);

                ExampleEnum? deserializedA = JsonSerializer.Deserialize<ExampleEnum>(serializedA, options);
                ExampleEnum? deserializedB = JsonSerializer.Deserialize<ExampleEnum>(serializedB, options);

                Assert.AreEqual(ExampleEnum.A, deserializedA);
                Assert.AreEqual(ExampleEnum.B, deserializedB);
            }

            [TestMethod]
            public async Task Given_JsonSerialization_When_EnumNotInList_Then_Returns_Null()
            {
                var options = new JsonSerializerOptions();
                options.Converters.Add(new ExampleEnum.ExampleJsonConverter());

                ExampleEnum? value = ExampleEnum.FromStringOrDefault("not-in-list");
                string serialized = JsonSerializer.Serialize(value, options);
                Assert.AreEqual("null", serialized);

                ExampleEnum? deserialized = JsonSerializer.Deserialize<ExampleEnum>(serialized, options);
                Assert.AreEqual(null, deserialized);
            }

            [TestMethod]
            public async Task Given_JsonSerialization_When_Null_Value_Then_Serialize_And_Deserialize_Correctly()
            {
                var options = new JsonSerializerOptions();
                options.Converters.Add(new ExampleEnum.ExampleJsonConverter());

                ExampleEnum? value = null;
                string serialized = JsonSerializer.Serialize(value, options);
                Assert.AreEqual("null", serialized);

                ExampleEnum? deserialized = JsonSerializer.Deserialize<ExampleEnum>("null", options);
                Assert.IsNull(deserialized);
            }

            [TestMethod]
            public async Task Given_JsonDeserialization_When_ExampleEnum_Is_Null_Then_Deserialize_Correctly_And_Not_Throw_Exception()
            {
                // Arrange
                string json = @"
{
    ""exampleEnum"": null
}";
                var options = new JsonSerializerOptions();
                options.Converters.Add(new ExampleEnum.ExampleJsonConverter());
                options.Converters.Add(new ExampleModelResponse.ExampleModelResponseJsonConverter());
                
                // Act
                ExampleModelResponse result = JsonSerializer.Deserialize<ExampleModelResponse>(json, options);

                // Assert
                Assert.IsNull(result.ExampleEnum);
            }
            
            [TestMethod]
            public async Task Given_JsonDeserialization_When_ExampleEnum_Is_A_Then_Deserialize_Correctly_To_A()
            {
                // Arrange
                string json = @"
{
    ""exampleEnum"": ""a""
}";
                var options = new JsonSerializerOptions();
                options.Converters.Add(new ExampleEnum.ExampleJsonConverter());
                options.Converters.Add(new ExampleModelResponse.ExampleModelResponseJsonConverter());
                
                // Act
                ExampleModelResponse result = JsonSerializer.Deserialize<ExampleModelResponse>(json, options);

                // Assert
                Assert.AreEqual(ExampleEnum.A, result.ExampleEnum);
            }

            
            internal class ExampleModelResponse
            {
                /// <summary>
                /// The optional enum to test.
                /// </summary>
                [JsonPropertyName("exampleEnum")]
                public ExampleEnum? ExampleEnum { get { return this._ExampleEnumOption; } set { this._ExampleEnumOption = new(value); } }

                /// <summary>
                /// Used to track if an optional field is set. If so, set the <see cref="ExampleEnum"/>.
                /// </summary>
                [JsonIgnore]
                public Option<ExampleEnum?> _ExampleEnumOption { get; private set; }

                [JsonConstructor]
                public ExampleModelResponse(Option<ExampleEnum?> exampleEnum)
                {
                    this._ExampleEnumOption = exampleEnum;
                }

                internal class ExampleModelResponseJsonConverter : JsonConverter<ExampleModelResponse>
                {
                    public override ExampleModelResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
                    {
                        int currentDepth = utf8JsonReader.CurrentDepth;

                        if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                            throw new JsonException();

                        JsonTokenType startingTokenType = utf8JsonReader.TokenType;

                        Option<ExampleEnum?> exampleEnum = default;

                        while (utf8JsonReader.Read())
                        {
                            if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                                break;

                            if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                                break;

                            if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                            {
                                string? jsonPropertyName = utf8JsonReader.GetString();
                                utf8JsonReader.Read();

                                switch (jsonPropertyName)
                                {
                                    case "exampleEnum":
                                        exampleEnum = new Option<ExampleEnum?>(JsonSerializer.Deserialize<ExampleEnum?>(ref utf8JsonReader, jsonSerializerOptions));
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }

                        return new ExampleModelResponse(exampleEnum);
                    }

                    public override void Write(Utf8JsonWriter writer, ExampleModelResponse response, JsonSerializerOptions jsonSerializerOptions)
                    {
                        writer.WritePropertyName("exampleEnum");
                        JsonSerializer.Serialize(writer, response.ExampleEnum, jsonSerializerOptions);
                    }
                }
            } 
            #endregion
            
        }
    }

    [JsonConverter(typeof(ExampleJsonConverter))]
    internal class ExampleEnum : IEnum
    {
        public string? Value { get; set; }

        /// <summary>
        /// ExampleEnum.A: a
        /// </summary>
        public static readonly ExampleEnum A = new("a");

        /// <summary>
        /// ExampleEnum.B: b
        /// </summary>
        public static readonly ExampleEnum B = new("b");

        private ExampleEnum(string? value)
        {
            Value = value;
        }

        public static implicit operator ExampleEnum?(string? value) => value == null ? null : new ExampleEnum(value);

        public static implicit operator string?(ExampleEnum? option) => option?.Value;

        public override string ToString() => Value ?? string.Empty;

        public override bool Equals(object? obj) => obj is ExampleEnum other && string.Equals(Value, other.Value, StringComparison.OrdinalIgnoreCase);

        public override int GetHashCode() => Value?.GetHashCode() ?? 0;

        public static bool operator ==(ExampleEnum? left, ExampleEnum? right) =>
            string.Equals(left?.Value, right?.Value, StringComparison.OrdinalIgnoreCase);

        public static bool operator !=(ExampleEnum? left, ExampleEnum? right) =>
            !string.Equals(left?.Value, right?.Value, StringComparison.OrdinalIgnoreCase);

        public static ExampleEnum? FromStringOrDefault(string value)
        {
            return value switch {
                "a" => ExampleEnum.A,
                "b" => ExampleEnum.B,
                _ => null,
                };
        }

        public static string? ToJsonValue(ExampleEnum? value)
        {
            if (value == null)
                return null;

            if (value == ExampleEnum.A)
                return "a";

            if (value == ExampleEnum.B)
                return "b";

            return null;
        }

        public class ExampleJsonConverter : JsonConverter<ExampleEnum>
        {
            public override ExampleEnum? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions jsonOptions)
            {
                string str = reader.GetString();
                return str == null ? null : ExampleEnum.FromStringOrDefault(str) ?? new ExampleEnum(str);
            }

            public override void Write(Utf8JsonWriter writer, ExampleEnum value, JsonSerializerOptions jsonOptions)
            {
                writer.WriteStringValue(ExampleEnum.ToJsonValue(value));
            }
        }
    }
}