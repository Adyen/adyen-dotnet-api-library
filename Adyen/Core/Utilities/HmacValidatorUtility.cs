using System.Security.Cryptography;
using System.Text;

namespace Adyen.Core.Utilities
{
    /// <summary>
    /// Utility class to help verify hmac signatures from incoming webhooks.
    /// </summary>
    public static class HmacValidatorUtility
    {
        /// <summary>
        /// Generates the Base64 encoded signature using the HMAC algorithm with the SHA256 hashing function.
        /// </summary>
        /// <param name="payload">The JSON payload.</param>
        /// <param name="hmacKey">The secret ADYEN_HMAC_KEY, retrieved from the Adyen Customer Area.</param>
        /// <returns>The HMAC string for the payload.</returns>
        /// <exception cref="Exception"></exception>
        public static string GenerateBase64Sha256HmacSignature(string payload, string hmacKey)
        {
            byte[] key = ConvertHexadecimalToBytes(hmacKey);
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
                throw new Exception("Failed to generate HMAC signature: " + e.Message, e);
            }
        }

        /// <summary>
        /// Converts a hexadecimal into a byte array. 
        /// </summary>
        /// <param name="hexadecimalString">The hexadecimal string.</param>
        /// <returns>An array of bytes that repesents the hexadecimalString.</returns>
        private static byte[] ConvertHexadecimalToBytes(string hexadecimalString)
        {
            if ((hexadecimalString.Length % 2) == 1)
            {
                hexadecimalString += '0';
            }

            byte[] bytes = new byte[hexadecimalString.Length / 2];
            for (int i = 0; i < hexadecimalString.Length; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hexadecimalString.Substring(i, 2), 16);
            }

            return bytes;
        }
        
        /// <summary>
        /// Validates a balance platform and management webhook payload with the given <paramref name="hmacSignature"/> and <paramref name="hmacKey"/>.
        /// </summary>
        /// <param name="hmacSignature">The HMAC signature, retrieved from the request header.</param>
        /// <param name="hmacKey">The HMAC key, retrieved from the Adyen Customer Area.</param>
        /// <param name="payload">The webhook JSON payload.</param>
        /// <returns>A return value indicates the HMAC validation succeeded.</returns>
        public static bool IsHmacSignatureValid(string hmacSignature, string hmacKey, string payload)
        {
            string signature = GenerateBase64Sha256HmacSignature(payload, hmacKey);
            return TimeSafeEquals(Encoding.UTF8.GetBytes(hmacSignature), Encoding.UTF8.GetBytes(signature));
        }

        /// <summary>
        /// This method compares two bytestrings in constant time based on length of shortest bytestring to prevent timing attacks.
        /// </summary>
        /// <returns>True if there's a difference.</returns>
        private static bool TimeSafeEquals(byte[] a, byte[] b)
        {
            uint diff = (uint)a.Length ^ (uint)b.Length;
            for (int i = 0; i < a.Length && i < b.Length; i++) { diff |= (uint)(a[i] ^ b[i]); }
            return diff == 0;
        }
    }
}

