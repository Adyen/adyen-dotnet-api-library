using System.Text.Json;
using Adyen.Core.Converters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.Core.Converters
{
    [TestClass]
    public class DateOnlyJsonConverterTests
    {
        private readonly DateOnlyJsonConverter _converter = new DateOnlyJsonConverter();

        [TestMethod]
        public void Given_DateWithDashes_yyyy_MM_dd_When_Read_Then_ReturnsCorrectDate()
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
        public void Given_Date_yyyyMMdd_When_Read_Then_ReturnsCorrectDate()
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
        public void Given_WrongFormatDateOnlyString_When_Read_Then_ThrowsNotSupportedException()
        {
            // Arrange
            string json = "\"25-12-2025\""; // Incorrect format dd-MM-yyyy
            
            // Act
            // Assert
            Assert.ThrowsException<NotSupportedException>(() =>
            {
                var reader = new Utf8JsonReader(System.Text.Encoding.UTF8.GetBytes(json));
                reader.Read();
                _converter.Read(ref reader, typeof(DateOnly), new JsonSerializerOptions());
            });
        }
        [TestMethod]
        public void Given_InvalidDateOnlyString_When_Read_Then_ThrowsJsonException()
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
            // Assert
            Assert.ThrowsException<NotSupportedException>(() => { 
                Utf8JsonReader reader = new Utf8JsonReader(System.Text.Encoding.UTF8.GetBytes(json));
                reader.Read();
                _converter.Read(ref reader, typeof(DateOnly), new JsonSerializerOptions());
            });
        }

        [TestMethod]
        public void Given_DateOnlyValue_When_Write_Then_WritesCorrectDateOnlyValue()
        {
            // Arrange
            var date = new DateOnly(2025, 12, 25);
            using var stream = new MemoryStream();
            using var writer = new Utf8JsonWriter(stream);

            // Act
            _converter.Write(writer, date, new JsonSerializerOptions());
            writer.Flush();
            string json = System.Text.Encoding.UTF8.GetString(stream.ToArray());

            // Assert
            Assert.AreEqual("\"2025-12-25\"", json);
        }
    }
}