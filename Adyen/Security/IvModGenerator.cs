using System.Security.Cryptography;

namespace Adyen.Security
{
    internal class IvModGenerator
    {
        internal byte[] GenerateRandomMod()
        {
            var ivMod = new byte[EncryptionDerivedKey.IVLength];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetNonZeroBytes(ivMod);
            }

            return ivMod;
        }
    }
}
