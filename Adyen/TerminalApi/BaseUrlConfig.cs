namespace Adyen
{
    public class BaseUrlConfig
    {
        /// <summary>
        /// Url to use for Checkout actions. Ensure no trailing slashes.
        /// </summary>
        public string CheckoutUrl { get; set; }
        
        /// <summary>
        /// Url to use for Payment actions. Ensure no trailing slashes.
        /// </summary>
        public string PaymentUrl { get; set; }
        
        /// <summary>
        /// Url to use for all other actions. Ensure no trailing slashes.
        /// </summary>
        public string BaseUrl { get; set; }
    }
}