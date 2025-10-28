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
            public void Given_ImplicitConversion_When_Initialized_Then_Returns_Correct_Values()
            {
                ExampleEnum? resultA = "a";
                ExampleEnum? resultB = "b";
                Assert.AreEqual(ExampleEnum.A, resultA);
                Assert.AreEqual(ExampleEnum.B, resultB);
            }

            [TestMethod]
            public void Given_ImplicitConversion_When_Null_Then_Returns_Null()
            {
                ExampleEnum? input = null;
                string? result = input;
                Assert.IsNull(result);
            }

            [TestMethod]
            public void Given_ToString_When_Called_Then_Returns_Correct_Value()
            {
                Assert.AreEqual("a", ExampleEnum.A.ToString());
                Assert.AreEqual("b", ExampleEnum.B.ToString());
            }

            [TestMethod]
            public void Given_ToString_When_Null_Then_Returns_Empty_String()
            {
                ExampleEnum result = new ExampleEnum(null);
                Assert.AreEqual(string.Empty, result.ToString());
            }

            [TestMethod]
            public void Given_Equals_When_ComparingCaseInsensitive_Then_Returns_True()
            {
                ExampleEnum result = new ExampleEnum("A");
                Assert.IsTrue(result.Equals(ExampleEnum.A));
                Assert.IsFalse(result.Equals(ExampleEnum.B));
            }

            [TestMethod]
            public void Given_GetHashCode_When_Set_Then_Result_Matches_HashCodes()
            {
                ExampleEnum result = new ExampleEnum("a");
                Assert.AreEqual("a".GetHashCode(), result.GetHashCode());
                ExampleEnum nullEnum = new ExampleEnum(null);
                Assert.AreEqual(0, nullEnum.GetHashCode());
            }

            [TestMethod]
            public void Given_EqualityOperator_When_ComparingValues_Then_Returns_Correct_Values()
            {
                ExampleEnum target = new ExampleEnum("a");
                ExampleEnum otherA = ExampleEnum.A;
                ExampleEnum otherB = ExampleEnum.B;

                Assert.IsTrue(target == otherA);
                Assert.IsFalse(target == otherB);
                Assert.IsTrue(target != otherB);
                Assert.IsFalse(target != otherA);
            }

            [TestMethod]
            public void Given_FromStringOrDefault_When_ValidStrings_Then_Returns_Correct_Enum()
            {
                Assert.AreEqual(ExampleEnum.A, ExampleEnum.FromStringOrDefault("a"));
                Assert.AreEqual(ExampleEnum.B, ExampleEnum.FromStringOrDefault("b"));
            }

            [TestMethod]
            public void Given_FromStringOrDefault_When_InvalidString_Then_Returns_Null()
            {
                Assert.IsNull(ExampleEnum.FromStringOrDefault("c"));
            }

            [TestMethod]
            public void Given_ToJsonValue_When_KnownEnum_Then_Returns_String()
            {
                Assert.AreEqual("a", ExampleEnum.ToJsonValue(ExampleEnum.A));
                Assert.AreEqual("b", ExampleEnum.ToJsonValue(ExampleEnum.B));
            }

            [TestMethod]
            public void Given_ToJsonValue_When_Null_Then_Returns_Null()
            {
                Assert.IsNull(ExampleEnum.ToJsonValue(null));
            }

            [TestMethod]
            public void Given_ToJsonValue_When_CustomEnum_Then_Returns_Null()
            {
                var custom = new ExampleEnum("custom");
                Assert.IsNull(ExampleEnum.ToJsonValue(custom));
            }

            [TestMethod]
            public void Given_JsonSerialization_When_KnownEnum_Then_Serialize_and_Deserialize_Correctly()
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
            public void Given_JsonSerialization_When_EnumNotInList_Then_Returns_Null()
            {
                var options = new JsonSerializerOptions();
                options.Converters.Add(new ExampleEnum.ExampleJsonConverter());

                ExampleEnum? value = new ExampleEnum("not-in-list");
                string serialized = JsonSerializer.Serialize(value, options);
                Assert.AreEqual("null", serialized);

                ExampleEnum? deserialized = JsonSerializer.Deserialize<ExampleEnum>(serialized, options);
                Assert.AreEqual(null, deserialized);
            }

            [TestMethod]
            public void Given_JsonSerialization_When_Null_Value_Then_Serialize_And_Deserialize_Correctly()
            {
                var options = new JsonSerializerOptions();
                options.Converters.Add(new ExampleEnum.ExampleJsonConverter());

                ExampleEnum? value = null;
                string serialized = JsonSerializer.Serialize(value, options);
                Assert.AreEqual("null", serialized);

                ExampleEnum? deserialized = JsonSerializer.Deserialize<ExampleEnum>("null", options);
                Assert.IsNull(deserialized);
            }
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

        internal ExampleEnum(string? value)
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