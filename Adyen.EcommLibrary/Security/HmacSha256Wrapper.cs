using System.Security.Cryptography;

namespace Adyen.EcommLibrary.Security
{
    internal class HmacSha256Wrapper
    {
        internal byte[] HMac(byte[] bytesToHMac, byte[] hmacKey)
        {
            var hmacSha256 = new HMACSHA256(hmacKey);

            return hmacSha256.ComputeHash(bytesToHMac);
        }
    }
}
