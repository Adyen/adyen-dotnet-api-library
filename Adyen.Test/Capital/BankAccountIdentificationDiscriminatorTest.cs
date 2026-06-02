using System.Text.Json;
using Adyen.Capital.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.Capital
{
    /// <summary>
    /// Regression tests for issue #1717: verifies that <see cref="BankAccountIdentificationJsonConverter"/>
    /// (Capital namespace) matches discriminator against API wire values (e.g. "iban", "usLocal")
    /// rather than C# class names (e.g. "IbanAccountIdentification").
    /// </summary>
    [TestClass]
    public class BankAccountIdentificationDiscriminatorTest
    {
        // ── Deserialization ──────────────────────────────────────────────────────────

        [TestMethod]
        public void Given_IbanJson_When_DeserializeAsBankAccountIdentification_Then_Returns_IbanAccountIdentification()
        {
            string json = "{\"type\":\"iban\",\"iban\":\"NL91ABNA0417164300\"}";

            var result = JsonSerializer.Deserialize<BankAccountIdentification>(json);

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(IbanAccountIdentification),
                "Expected IbanAccountIdentification but got: " + result.GetType().Name);
            Assert.AreEqual("NL91ABNA0417164300", ((IbanAccountIdentification)result).Iban);
        }

        [TestMethod]
        public void Given_UsLocalJson_When_DeserializeAsBankAccountIdentification_Then_Returns_USLocalAccountIdentification()
        {
            string json = "{\"type\":\"usLocal\",\"accountNumber\":\"123456789\",\"routingNumber\":\"011000015\"}";

            var result = JsonSerializer.Deserialize<BankAccountIdentification>(json);

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(USLocalAccountIdentification),
                "Expected USLocalAccountIdentification but got: " + result.GetType().Name);
            var us = (USLocalAccountIdentification)result;
            Assert.AreEqual("123456789", us.AccountNumber);
            Assert.AreEqual("011000015", us.RoutingNumber);
        }

        [TestMethod]
        public void Given_UkLocalJson_When_DeserializeAsBankAccountIdentification_Then_Returns_UKLocalAccountIdentification()
        {
            string json = "{\"type\":\"ukLocal\",\"accountNumber\":\"12345678\",\"sortCode\":\"123456\"}";

            var result = JsonSerializer.Deserialize<BankAccountIdentification>(json);

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(UKLocalAccountIdentification),
                "Expected UKLocalAccountIdentification but got: " + result.GetType().Name);
        }

        // ── Serialization ────────────────────────────────────────────────────────────

        [TestMethod]
        public void Given_IbanAccountIdentification_When_Serialize_Then_TypeIsApiWireValue()
        {
            var iban = new IbanAccountIdentification { Iban = "NL91ABNA0417164300" };

            string json = JsonSerializer.Serialize<BankAccountIdentification>(iban);

            Assert.IsTrue(json.Contains("\"type\":\"iban\""),
                "Expected wire value 'iban' but got: " + json);
        }

        [TestMethod]
        public void Given_USLocalAccountIdentification_When_Serialize_Then_TypeIsApiWireValue()
        {
            var us = new USLocalAccountIdentification
            {
                AccountNumber = "123456789",
                RoutingNumber = "011000015"
            };

            string json = JsonSerializer.Serialize<BankAccountIdentification>(us);

            Assert.IsTrue(json.Contains("\"type\":\"usLocal\""),
                "Expected wire value 'usLocal' but got: " + json);
        }

        // ── Round-trip ───────────────────────────────────────────────────────────────

        [TestMethod]
        public void Given_IbanAccountIdentification_When_RoundTrip_Then_DeserializesCorrectly()
        {
            var original = new IbanAccountIdentification { Iban = "GB29NWBK60161331926819" };

            string json = JsonSerializer.Serialize<BankAccountIdentification>(original);
            var result = JsonSerializer.Deserialize<BankAccountIdentification>(json);

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(IbanAccountIdentification));
            Assert.AreEqual(original.Iban, ((IbanAccountIdentification)result).Iban);
        }
    }
}
