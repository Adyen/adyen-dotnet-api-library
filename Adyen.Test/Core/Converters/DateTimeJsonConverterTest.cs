using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.Json;
using Adyen.Core.Converters;

namespace Adyen.Test.Core.Converters
{
    [TestClass]
    public class DateTimeJsonConverterTest
    {
        private readonly DateTimeJsonConverter _converter = new DateTimeJsonConverter();

        [TestMethod]
        public void Given_ValidDateTimeWithFraction_When_Read_Then_ReturnsCorrectDateTime()
        {
            // Arrange
            string json = "\"2025-12-25T14:30:15.1234567Z\"";
            var reader = new Utf8JsonReader(System.Text.Encoding.UTF8.GetBytes(json));

            // Act
            reader.Read();
            var result = _converter.Read(ref reader, typeof(DateTime), new JsonSerializerOptions());

            // Assert
            Assert.AreEqual(DateTime.Parse("2025-12-25T14:30:15.1234567Z").ToUniversalTime(), result);
        }

        [TestMethod]
        public void Given_ValidDateTimeWithoutFraction_When_Read_Then_ReturnsCorrectDateTime()
        {
            // Arrange
            string json = "\"2025-12-25T14:30:15Z\"";
            var reader = new Utf8JsonReader(System.Text.Encoding.UTF8.GetBytes(json));

            // Act
            reader.Read();
            var result = _converter.Read(ref reader, typeof(DateTime), new JsonSerializerOptions());

            // Assert
            Assert.AreEqual(DateTime.Parse("2025-12-25T14:30:15Z").ToUniversalTime(), result);
        }

        [TestMethod]
        public void Given_InvalidDateTime_When_Read_Then_ThrowsNotSupportedException()
        {
            // Arrange
            string json = "\"invalid-datetime\"";
            
            // Act
            // Assert
            Assert.ThrowsException<NotSupportedException>(() =>
            {
                var reader = new Utf8JsonReader(System.Text.Encoding.UTF8.GetBytes(json));
                reader.Read();
                _converter.Read(ref reader, typeof(DateTime), new JsonSerializerOptions());
            });
        }

        [TestMethod]
        public void Given_DateTimeValue_When_Write_Then_WritesCorrectJson()
        {
            // Arrange
            var dateTime = new DateTime(2025, 12, 25, 14, 30, 15, 123, DateTimeKind.Utc).AddTicks(4567);
            
            // Act
            using var stream = new MemoryStream();
            using var writer = new Utf8JsonWriter(stream);
            _converter.Write(writer, dateTime, new JsonSerializerOptions());
            writer.Flush();
            string json = System.Text.Encoding.UTF8.GetString(stream.ToArray());

            // Assert
            Assert.AreEqual($"\"{dateTime.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK", System.Globalization.CultureInfo.InvariantCulture)}\"", json);
        }
    }
}
