#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2019 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System.Security.Cryptography;

namespace Adyen.Security
{
    internal class AesEncryptor
    {
        private readonly AesManaged _aesManaged;

        internal AesEncryptor()
        {
            _aesManaged = new AesManaged()
            {
                KeySize = 256,
                BlockSize = 128,
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7
            };
        }

        internal byte[] Encrypt(byte[] byteArrayToEncrypt,  EncryptionDerivedKey encryptionDerivedKey, byte[] ivMod)
        {
            _aesManaged.Key = encryptionDerivedKey.CipherKey;
            _aesManaged.IV = TransformIV(encryptionDerivedKey.IV, ivMod);
            var encryptTransform = _aesManaged.CreateEncryptor();
            var byteArrayEncrypted = encryptTransform.TransformFinalBlock(byteArrayToEncrypt, 0, byteArrayToEncrypt.Length);

            return byteArrayEncrypted;
        }

        private byte[] TransformIV(byte[] originalIV, byte[] ivMod)
        {
            var updatedIV = new byte[EncryptionDerivedKey.IVLength];
            for (int i = 0; i < EncryptionDerivedKey.IVLength; i++)
            {
                updatedIV[i] = (byte)(originalIV[i] ^ ivMod[i]);
            }
            return updatedIV;
        }

        internal byte[] Decrypt(byte[] byteArrayToDecrypt, EncryptionDerivedKey encryptionDerivedKey, byte[] ivMod)
        {
            _aesManaged.Key = encryptionDerivedKey.CipherKey;
            _aesManaged.IV = TransformIV(encryptionDerivedKey.IV, ivMod);
            var aesDecryptor = _aesManaged.CreateDecryptor();

            return aesDecryptor.TransformFinalBlock(byteArrayToDecrypt, 0, byteArrayToDecrypt.Length);
        }
    }
}
