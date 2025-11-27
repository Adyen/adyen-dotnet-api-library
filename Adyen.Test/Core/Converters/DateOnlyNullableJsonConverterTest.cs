using System.Text.Json;
using Adyen.Core.Converters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.Core.Converters
{
    [TestClass]
    public class DateOnlyNullableJsonConverterTest
    {
        private readonly DateOnlyNullableJsonConverter _converter = new DateOnlyNullableJsonConverter();

        [TestMethod]
        public void Given_DateWithDashes_yyyy_MM_dd_When_Read_Then_Returns_Correct_DateOnly()
        {
            // Arrange
            string json = "\"2025-12-25\"";
            var reader = new Utf8JsonReader(System.Text.Encoding.UTF8.GetBytes(json));
            
            // Act
            reader.Read();
            var result = _converter.Read(ref reader, typeof(DateOnly), new JsonSerializerOptions());

            // Assert
            Assert.AreEqual(new DateOnly(2025, 12, 25), result);
        }
        
        [TestMethod]
        public void Given_DateOnly_yyyyMMdd_When_Read_Then_Returns_Correct_DateOnly()
        {
            // Arrange
            string json = "\"20251225\"";
            var reader = new Utf8JsonReader(System.Text.Encoding.UTF8.GetBytes(json));
            
            // Act
            reader.Read();
            var result = _converter.Read(ref reader, typeof(DateOnly), new JsonSerializerOptions());

            // Assert
            Assert.AreEqual(new DateOnly(2025, 12, 25), result);
        }
        
        [TestMethod]
        public void Given_InvalidFormat_DateOnlyString_When_Read_Then_Returns_Null()
        {
            // Arrange
            string json = "\"25-12-2025\""; // Invalid format "yyyy'-'MM'-'dd" or "yyyyMMdd"
            
            // Act
            Utf8JsonReader reader = new Utf8JsonReader(System.Text.Encoding.UTF8.GetBytes(json));
            reader.Read();
            var result = _converter.Read(ref reader, typeof(DateOnly), new JsonSerializerOptions());
            
            // Assert
            Assert.IsNull(result);
        }
                
        [TestMethod]
        public void Given_Invalid_DateOnlyString_When_Read_Then_ThrowsJsonException()
        {
            // Arrange
            string json = "invalid-date";
            
            // Act
            // Assert
            Assert.Throws<JsonException>(() =>
            {
                var reader = new Utf8JsonReader(System.Text.Encoding.UTF8.GetBytes(json));
                reader.Read();
                _converter.Read(ref reader, typeof(DateOnly), new JsonSerializerOptions());
            });
        }

        [TestMethod]
        public void Given_NullToken_When_Read_Then_ThrowsNotSupportedException()
        {
            // Arrange
            string json = "null";
            
            // Act
            Utf8JsonReader reader = new Utf8JsonReader(System.Text.Encoding.UTF8.GetBytes(json));
            reader.Read();
            var result = _converter.Read(ref reader, typeof(DateOnly), new JsonSerializerOptions());
            
            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void Given_DateOnlyValue_When_Write_Then_WritesCorrectDateOnlyValue()
        {
            // Arrange
            DateOnly? dateOnly = null;
            using var stream = new MemoryStream();
            using var writer = new Utf8JsonWriter(stream);

            // Act
            _converter.Write(writer, dateOnly, new JsonSerializerOptions());
            writer.Flush();
            string json = System.Text.Encoding.UTF8.GetString(stream.ToArray());

            // Assert
            Assert.AreEqual("null", json);
        }
    }
}