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
    public class Certificate
    {
        public static void AddCertificateFromPath(string certificatePath, StoreName storeName = StoreName.Root,
            StoreLocation storeLocation = StoreLocation.CurrentUser)
        {
            using (var store = new X509Store(storeName, storeLocation))
            {
                var x509Certificate2 = new X509Certificate2(certificatePath);
                if (!store.Certificates.Contains(x509Certificate2))
                {
                    store.Open(OpenFlags.ReadWrite);
                    store.Add(x509Certificate2);
                }
            }
        }
    }
}