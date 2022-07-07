// #region License
// 
//                         ######
//                         ######
//   ############    ####( ######  #####. ######  ############   ############
//   #############  #####( ######  #####. ######  #############  #############
//          ######  #####( ######  #####. ######  #####  ######  #####  ######
//   ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//   ###### ######  #####( ######  #####. ######  #####          #####  ######
//   #############  #############  #############  #############  #####  ######
//    ############   ############  #############   ############  #####  ######
//                                        ######
//                                 #############
//                                 ############
// 
//   Adyen Dotnet API Library
// 
//   Copyright (c) 2022 Adyen N.V.
//   This file is open source and available under the MIT license.
//   See the LICENSE file for more info.
// 
// #endregion

using System.Security.Cryptography.X509Certificates;

namespace Adyen.Util
{
    public static class Certificate
    {
        /// <summary>
        /// This method creates a CA store and adding the certificate provided by the path. 
        /// </summary>
        /// <param name="certificatePath">Path for the certificate .crt, .cer</param>
        /// <param name="storeName">Specifies the name of the X.509 certificate store to open. Default is root</param>
        /// <param name="storeLocation">Specifies the location of the X.509 certificate store. Default is current user</param>
        public static void AddCertificateFromPath(string certificatePath, StoreName storeName = StoreName.Root,
            StoreLocation storeLocation = StoreLocation.CurrentUser)
        {
            using (var store = new X509Store(storeName, storeLocation))
            {
                var x509Certificate2 = new X509Certificate2(certificatePath);
                store.Open(OpenFlags.ReadWrite);
                store.Add(x509Certificate2);
            }
        }
    }
}