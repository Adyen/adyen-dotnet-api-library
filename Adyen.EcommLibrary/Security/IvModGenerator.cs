using System;

namespace Adyen.EcommLibrary.Security
{
    internal class IvModGenerator
    {
        internal byte[] GenerateRandomMod()
        {
            var ivMod = new byte[EncryptionDerivedKey.IVLength];
            new Random().NextBytes(ivMod);

            return ivMod;
        }
    }
}
