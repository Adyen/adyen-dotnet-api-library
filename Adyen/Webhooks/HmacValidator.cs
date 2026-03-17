using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Adyen.Webhooks.Models;

namespace Adyen.Util
{
    public class HmacValidator
    {
        private const string HmacSignature = "hmacSignature";

        /// <summary>
        /// Computes the Base64-encoded HMAC signature for a payload using the provided hexadecimal HMAC key.
        /// </summary>
        /// <param name="payload">The payload to sign.</param>
        /// <param name="hmacKey">The hexadecimal HMAC key from the Adyen Customer Area.</param>
        /// <returns>The Base64-encoded HMAC signature.</returns>
        /// <exception cref="Exception">Thrown when the HMAC cannot be generated.</exception>
        public string CalculateHmac(string payload, string hmacKey)
        {
            byte[] key = PackH(hmacKey);
            byte[] data = Encoding.UTF8.GetBytes(payload);

            try
            {
                using (HMACSHA256 hmac = new HMACSHA256(key))
                {
                    // Compute the hmac on input data bytes
                    byte[] rawHmac = hmac.ComputeHash(data);

                    // Base64-encode the hmac
                    return Convert.ToBase64String(rawHmac);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Failed to generate HMAC : " + e.Message);
            }
        }

        /// <summary>
        /// Computes the Base64-encoded HMAC signature for a webhook notification item.
        /// </summary>
        /// <param name="notificationRequestItem"><see cref="NotificationRequestItem"/> to sign.</param>
        /// <param name="hmacKey">The hexadecimal HMAC key from the Adyen Customer Area.</param>
        /// <returns>The Base64-encoded HMAC signature.</returns>
        public string CalculateHmac(NotificationRequestItem notificationRequestItem, string hmacKey)
        {
            var notificationRequestItemData = GetDataToSign(notificationRequestItem);
            return CalculateHmac(notificationRequestItemData, hmacKey);
        }

        /// <summary>
        /// Converts a hexadecimal string into a byte array.
        /// </summary>
        /// <param name="hex">Hexadecimal string representation.</param>
        /// <returns>Byte array converted from the hexadecimal string.</returns>
        private byte[] PackH(string hex)
        {
            if ((hex.Length % 2) == 1)
            {
                hex += '0';
            }

            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < hex.Length; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }

            return bytes;
        }

        /// <summary>
        /// Builds the canonical string used for HMAC signature generation from a notification item.
        /// </summary>
        /// <param name="notificationRequestItem"><see cref="NotificationRequestItem"/> containing the values to sign.</param>
        /// <returns>The colon-separated string to sign.</returns>
        public string GetDataToSign(NotificationRequestItem notificationRequestItem)
        {
            var amount = notificationRequestItem.Amount;
            var signedDataList = new List<string>
            {
                notificationRequestItem.PspReference,
                notificationRequestItem.OriginalReference,
                notificationRequestItem.MerchantAccountCode,
                notificationRequestItem.MerchantReference,
                Convert.ToString(amount.Value),
                amount.Currency,
                notificationRequestItem.EventCode,
                notificationRequestItem.Success.ToString().ToLower()
            };
            return String.Join(":", signedDataList);
        }

        /// <summary>
        /// Validates a regular webhook with the given <paramref name="hmacKey"/>.
        /// </summary>
        /// <param name="notificationRequestItem"><see cref="NotificationRequestItem"/>.</param>
        /// <param name="hmacKey">The HMAC key, retrieved from the Adyen Customer Area.</param>
        /// <returns>A return value indicates the HMAC validation succeeded.</returns>
        public bool IsValidHmac(NotificationRequestItem notificationRequestItem, string hmacKey)
        {
            if (notificationRequestItem.AdditionalData == null)
            {
                return false;
            }

            if (!notificationRequestItem.AdditionalData.ContainsKey(HmacSignature))
            {
                return false;
            }
            var expectedSign = CalculateHmac(notificationRequestItem, hmacKey);
            var merchantSign = notificationRequestItem.AdditionalData[HmacSignature];
            return string.Equals(expectedSign, merchantSign);
        }
    }
}
