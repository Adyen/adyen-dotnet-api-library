using System.Text;
using System.Text.Json;
using Adyen.Core.Converters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.Core.Converters
{
    [TestClass]
    public class ByteArrayTest
    {
        private readonly ByteArrayConverter _converter = new ByteArrayConverter();
        
        [TestMethod]
        public void Given_ByteArray_When_Write_Then_Result_Should_Write_UTF8_String()
        {
            // Arrange
            byte[] bytes = Encoding.UTF8.GetBytes("adyen");
            using var stream = new MemoryStream();
            using var writer = new Utf8JsonWriter(stream);

            // Act
            _converter.Write(writer, bytes, new JsonSerializerOptions());
            writer.Flush();
            string target = Encoding.UTF8.GetString(stream.ToArray());

            // Assert
            Assert.AreEqual("\"adyen\"", target);
        }

        [TestMethod]
        public void Given_ByteArray_Null_When_Write_Then_Result_Returns_Null()
        {
            // Arrange
            using var stream = new MemoryStream();
            using var writer = new Utf8JsonWriter(stream);

            // Act
            _converter.Write(writer, null, new JsonSerializerOptions());
            writer.Flush();
            string json = Encoding.UTF8.GetString(stream.ToArray());

            // Assert
            Assert.AreEqual("null", json);
        }

        [TestMethod]
        public void Given_Json_When_Read_And_Decoded_Then_Should_Return_ByteArray()
        {
            // Arrange
            string json = "\"adyen\"";
            var reader = new Utf8JsonReader(Encoding.UTF8.GetBytes(json));
            reader.Read();

            // Act
            byte[] result = _converter.Read(ref reader, typeof(byte[]), new JsonSerializerOptions());
            string decoded = Encoding.UTF8.GetString(result);

            // Assert
            Assert.AreEqual("adyen", decoded);
        }

        [TestMethod]
        public void Given_Json_Null_When_Read_Then_Returns_Null()
        {
            // Arrange
            string json = "null";
            var reader = new Utf8JsonReader(Encoding.UTF8.GetBytes(json));
            reader.Read();

            // Act
            byte[] result = _converter.Read(ref reader, typeof(byte[]), new JsonSerializerOptions());

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void Given_ByteArray_When_Write_And_Read_Then_Result_Returns_Original_Bytes()
        {
            // Arrange
            byte[] original = Encoding.UTF8.GetBytes("adyen");
            using var stream = new MemoryStream();
            using var writer = new Utf8JsonWriter(stream);

            _converter.Write(writer, original, new JsonSerializerOptions());
            writer.Flush();
            string json = Encoding.UTF8.GetString(stream.ToArray());

            var reader = new Utf8JsonReader(Encoding.UTF8.GetBytes(json));
            reader.Read();

            // Act
            byte[] result = _converter.Read(ref reader, typeof(byte[]), new JsonSerializerOptions());

            // Assert
            CollectionAssert.AreEqual(original, result);
        }

        [TestMethod]
        public void Given_EmptyString_When_Read_Then_ShouldReturnEmptyByteArray()
        {
            // Arrange
            string json = "\"\"";
            Utf8JsonReader reader = new Utf8JsonReader(Encoding.UTF8.GetBytes(json));
            reader.Read();

            // Act
            byte[] result = _converter.Read(ref reader, typeof(byte[]), new JsonSerializerOptions());

            // Assert
            Assert.AreEqual(Array.Empty<byte>(), result);
        }
    }
}