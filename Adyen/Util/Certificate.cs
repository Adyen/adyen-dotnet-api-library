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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="certificatePath"></param>
        /// <param name="storeName"></param>
        /// <param name="storeLocation"></param>
        public static void AddCertificateFromPath(string certificatePath, StoreName storeName = StoreName.My,
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