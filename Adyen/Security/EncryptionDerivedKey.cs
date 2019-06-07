namespace Adyen.EcommLibrary.Security
{
    internal class EncryptionDerivedKey
    {
        internal const int HmacKeyLength = 32;
        internal const int CipherKeyLength = 32;
        internal const int IVLength = 16;

        internal byte[] HmacKey;
        internal byte[] CipherKey;
        internal byte[] IV;
    }
}
