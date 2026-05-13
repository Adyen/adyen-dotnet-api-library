using Adyen.Core.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test.Core.Utilities
{
    [TestClass]
    public class AmountUtilTest
    {
        [TestMethod]
        public void AmountToMinorUnitsTest()
        {
            // Regular currencies (2 decimals)
            Assert.AreEqual(1234L, AmountUtil.AmountToMinorUnits(12.34m, "EUR"));
            Assert.AreEqual(1234L, AmountUtil.AmountToMinorUnits(12.34m, "GBP"));
            Assert.AreEqual(1234L, AmountUtil.AmountToMinorUnits(12.34m, "USD"));
            
            // 0-decimal currencies
            Assert.AreEqual(1234L, AmountUtil.AmountToMinorUnits(1234m, "JPY"));
            Assert.AreEqual(1234L, AmountUtil.AmountToMinorUnits(1234m, "IDR"));
            Assert.AreEqual(1234L, AmountUtil.AmountToMinorUnits(1234m, "CVE"));
            
            // 3-decimal currencies
            Assert.AreEqual(12345L, AmountUtil.AmountToMinorUnits(12.345m, "BHD"));
            
            // Adyen deviations (CLP and ISK are 2 decimals in Adyen)
            Assert.AreEqual(1234L, AmountUtil.AmountToMinorUnits(12.34m, "CLP"));
            Assert.AreEqual(1234L, AmountUtil.AmountToMinorUnits(12.34m, "ISK"));
            
            // Zero amounts
            Assert.AreEqual(0L, AmountUtil.AmountToMinorUnits(0m, "EUR"));
            Assert.AreEqual(0L, AmountUtil.AmountToMinorUnits(0m, "JPY"));
            
            // Unknown currency code (should default to 2 decimals)
            Assert.AreEqual(1234L, AmountUtil.AmountToMinorUnits(12.34m, "XXX"));

            // Case-insensitivity and trimming
            Assert.AreEqual(1234L, AmountUtil.AmountToMinorUnits(12.34m, "eur"));
            Assert.AreEqual(1234L, AmountUtil.AmountToMinorUnits(12.34m, " EUR "));

            // Large magnitudes
            Assert.AreEqual(100000000000L, AmountUtil.AmountToMinorUnits(1000000000.00m, "EUR"));
            Assert.AreEqual(-100000000000L, AmountUtil.AmountToMinorUnits(-1000000000.00m, "EUR"));

            // Null input
            Assert.IsNull(AmountUtil.AmountToMinorUnits(null, "EUR"));
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void AmountToMinorUnitsNullCurrencyTest()
        {
            AmountUtil.AmountToMinorUnits(10.00m, null);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void AmountToMinorUnitsEmptyCurrencyTest()
        {
            AmountUtil.AmountToMinorUnits(10.00m, "");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void AmountToMinorUnitsWhitespaceCurrencyTest()
        {
            AmountUtil.AmountToMinorUnits(10.00m, " ");
        }

        [TestMethod]
        public void MinorUnitsToAmountTest()
        {
            // Regular currencies (2 decimals)
            Assert.AreEqual(12.34m, AmountUtil.MinorUnitsToAmount(1234L, "EUR"));
            Assert.AreEqual(12.34m, AmountUtil.MinorUnitsToAmount(1234L, "GBP"));
            Assert.AreEqual(12.34m, AmountUtil.MinorUnitsToAmount(1234L, "USD"));
            
            // 0-decimal currencies
            Assert.AreEqual(1234m, AmountUtil.MinorUnitsToAmount(1234L, "JPY"));
            Assert.AreEqual(1234m, AmountUtil.MinorUnitsToAmount(1234L, "IDR"));
            Assert.AreEqual(1234m, AmountUtil.MinorUnitsToAmount(1234L, "CVE"));
            
            // 3-decimal currencies
            Assert.AreEqual(12.345m, AmountUtil.MinorUnitsToAmount(12345L, "BHD"));
            
            // Adyen deviations
            Assert.AreEqual(12.34m, AmountUtil.MinorUnitsToAmount(1234L, "CLP"));
            Assert.AreEqual(12.34m, AmountUtil.MinorUnitsToAmount(1234L, "ISK"));

            // Case-insensitivity
            Assert.AreEqual(12.34m, AmountUtil.MinorUnitsToAmount(1234L, "eur"));
            
            // Zero amounts
            Assert.AreEqual(0m, AmountUtil.MinorUnitsToAmount(0L, "EUR"));

            // Large magnitudes
            Assert.AreEqual(1000000000.00m, AmountUtil.MinorUnitsToAmount(100000000000L, "EUR"));

            // Null input
            Assert.IsNull(AmountUtil.MinorUnitsToAmount(null, "EUR"));
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void MinorUnitsToAmountNullCurrencyTest()
        {
            AmountUtil.MinorUnitsToAmount(1000L, null);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void MinorUnitsToAmountEmptyCurrencyTest()
        {
            AmountUtil.MinorUnitsToAmount(1000L, "");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void MinorUnitsToAmountWhitespaceCurrencyTest()
        {
            AmountUtil.MinorUnitsToAmount(1000L, " ");
        }
        
        [TestMethod]
        public void RoundingTest()
        {
            // banker's rounding (MidpointRounding.ToEven)
            Assert.AreEqual(1234L, AmountUtil.AmountToMinorUnits(12.345m, "EUR"));
            Assert.AreEqual(1234L, AmountUtil.AmountToMinorUnits(12.335m, "EUR"));
            Assert.AreEqual(1234L, AmountUtil.AmountToMinorUnits(12.344m, "EUR"));
            
            Assert.AreEqual(-1234L, AmountUtil.AmountToMinorUnits(-12.345m, "EUR"));
            Assert.AreEqual(-1234L, AmountUtil.AmountToMinorUnits(-12.335m, "EUR"));
            Assert.AreEqual(-1234L, AmountUtil.AmountToMinorUnits(-12.344m, "EUR"));

            // Edge cases for rounding
            Assert.AreEqual(0L, AmountUtil.AmountToMinorUnits(0.005m, "EUR"));
            Assert.AreEqual(0L, AmountUtil.AmountToMinorUnits(0.004m, "EUR"));
            Assert.AreEqual(0L, AmountUtil.AmountToMinorUnits(-0.005m, "EUR"));
            Assert.AreEqual(0L, AmountUtil.AmountToMinorUnits(-0.004m, "EUR"));
        }
    }
}
