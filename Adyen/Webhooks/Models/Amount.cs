namespace Adyen.Webhooks.Models
{
    /// <summary>
    /// The Amount, used for webhooks
    /// </summary>
    public class Amount
    {
        /// <summary>
        /// The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes#currency-codes).
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// The amount of the transaction, in [minor units](https://docs.adyen.com/development-resources/currency-codes#minor-units).
        /// </summary>
        public long? Value { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Amount"/> class for webhooks.
        /// </summary>
        /// <param name="currency">The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes#currency-codes).</param>
        /// <param name="value">The amount of the transaction, in [minor units](https://docs.adyen.com/development-resources/currency-codes#minor-units).</param>
        public Amount(string currency = default(string), long? value = default(long?))
        {
            this.Currency = currency;
            this.Value = value;
        }
    }
}