using Adyen.Core.Auth;
using Adyen.Core.Client;

namespace Adyen.Webhooks.Client
{
    /// <summary>
    /// The `ADYEN_HMAC_KEY` is used to verify incoming webhook signatures.
    /// </summary>
    public class HmacKeyToken : TokenBase
    {
        /// <summary>
        /// The `ADYEN_HMAC_KEY`, configured in <see cref="Adyen.Core.Options.AdyenOptions"/>.
        /// </summary>
        public string AdyenHmacKey { get; }

        /// <summary>
        /// Constructs the HmacKeyToken object with the ADYEN_HMAC_KEY value provided.
        /// </summary>
        /// <param name="hmacKey">Your `ADYEN_HMAC_KEY`, configured in <see cref="Adyen.Core.Options.AdyenOptions"/>.</param>
        public HmacKeyToken(string hmacKey) : base()
        {
            AdyenHmacKey = hmacKey;
        }
    }
}
