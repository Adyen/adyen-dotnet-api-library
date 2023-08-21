using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Adyen.Model.Notification;

namespace Adyen.Util
{
    public class HmacValidator
    {
        private const string HmacSignature = "hmacSignature";

        // Computes the Base64 encoded signature using the HMAC algorithm with the HMACSHA256 hashing function.
        public string CalculateHmac(string signingstring, string hmacKey)
        {
            byte[] key = PackH(hmacKey);
            byte[] data = Encoding.UTF8.GetBytes(signingstring);

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

        public string CalculateHmac(NotificationRequestItem notificationRequestItem, string hmacKey)
        {
            var notificationRequestItemData = GetDataToSign(notificationRequestItem);
            return CalculateHmac(notificationRequestItemData, hmacKey);
        }

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

        /// <summary>
        /// Validates a balance platform webhook with the given <paramref name="hmacKey"/> and <paramref name="hmacSignature"/>.
        /// </summary>
        /// <param name="hmacKey">The HMAC key, retrieved from the Adyen Customer Area.</param>
        /// <param name="hmacSignature">The HMAC signature, retrieved from the request header.</param>
        /// <param name="payload">The balance platform webhook payload.</param>
        /// <returns>A return value indicates the HMAC validation succeeded.</returns>
        public bool IsValidBalancePlatformHmac(string hmacKey, string hmacSignature, string payload)
        {
            var calculatedSign = CalculateHmac(payload, hmacSignature);
            return TimeSafeEquals(Encoding.UTF8.GetBytes(hmacKey), Encoding.UTF8.GetBytes(calculatedSign));
        }
        
        /// This method compares two bytestrings in constant time based on length of shortest bytestring to prevent timing attacks.
        private static bool TimeSafeEquals(byte[] a, byte[] b)
        {
            uint diff = (uint)a.Length ^ (uint)b.Length;
            for (int i = 0; i < a.Length && i < b.Length; i++) { diff |= (uint)(a[i] ^ b[i]); }
            return diff == 0;
        }
    }
}

