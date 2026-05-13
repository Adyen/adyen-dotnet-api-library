using System;

namespace Adyen.Core.Utilities
{
    /// <summary>
    /// Utility class to help with currency minor units conversion.
    /// </summary>
    public static class AmountUtil
    {
        /// <summary>
        /// Converts a decimal amount to minor units (long) for the given currency code.
        /// </summary>
        /// <param name="amount">The decimal amount (e.g., 10.50).</param>
        /// <param name="currencyCode">The currency code (e.g., "EUR").</param>
        /// <returns>The amount in minor units (e.g., 1050).</returns>
        public static long? AmountToMinorUnits(decimal? amount, string currencyCode)
        {
            if (amount == null)
            {
                return null;
            }

            if (string.IsNullOrWhiteSpace(currencyCode))
            {
                throw new ArgumentException("Currency code cannot be null or empty.", nameof(currencyCode));
            }
            
            int decimals = GetDecimals(currencyCode);
            decimal multiplier = GetPowerOfTen(decimals);
            return (long)Math.Round(amount.Value * multiplier, MidpointRounding.ToEven);
        }

        /// <summary>
        /// Converts an amount in minor units (long) to a decimal amount for the given currency code.
        /// </summary>
        /// <param name="minorUnits">The amount in minor units (e.g., 1050).</param>
        /// <param name="currencyCode">The currency code (e.g., "EUR").</param>
        /// <returns>The decimal amount (e.g., 10.50).</returns>
        public static decimal? MinorUnitsToAmount(long? minorUnits, string currencyCode)
        {
            if (minorUnits == null)
            {
                return null;
            }

            if (string.IsNullOrWhiteSpace(currencyCode))
            {
                throw new ArgumentException("Currency code cannot be null or empty.", nameof(currencyCode));
            }
            
            int decimals = GetDecimals(currencyCode);
            decimal divisor = GetPowerOfTen(decimals);
            return minorUnits.Value / divisor;
        }

        /// <summary>
        /// Returns 10^decimals using pure decimal arithmetic.
        /// </summary>
        private static decimal GetPowerOfTen(int decimals)
        {
            decimal result = 1m;
            for (int i = 0; i < decimals; i++)
            {
                result *= 10m;
            }
            return result;
        }

        /// <summary>
        /// Returns the number of decimals for a given currency code based on Adyen's specific decimal rules.
        /// </summary>
        /// <param name="currencyCode">The currency code.</param>
        /// <returns>The number of decimals.</returns>
        private static int GetDecimals(string currencyCode)
        {
            switch (currencyCode)
            {
                case "CVE":
                case "DJF":
                case "GNF":
                case "IDR":
                case "JPY":
                case "KMF":
                case "KRW":
                case "PYG":
                case "RWF":
                case "UGX":
                case "VND":
                case "VUV":
                case "XAF":
                case "XOF":
                case "XPF":
                    return 0;
                case "BHD":
                case "IQD":
                case "JOD":
                case "KWD":
                case "LYD":
                case "OMR":
                case "TND":
                    return 3;
                default:
                    return 2;
            }
        }
    }
}
