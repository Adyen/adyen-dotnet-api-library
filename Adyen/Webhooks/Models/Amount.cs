using System.Text.Json.Serialization;

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
        [JsonPropertyName("currency")]
        [Newtonsoft.Json.JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The amount of the transaction, in [minor units](https://docs.adyen.com/development-resources/currency-codes#minor-units).
        /// </summary>
        [JsonPropertyName("value")]
        [Newtonsoft.Json.JsonProperty("value")]
        public long? Value { get; set; }

        public Amount() { }

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