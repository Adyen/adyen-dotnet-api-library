// #region License
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
//  * Copyright (c) 2022 Adyen N.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
// #endregion

using System.Net.Security;
using Adyen.Model.Nexo;
using Adyen.Security;

namespace Adyen.Service
{
    public interface IPosPaymentLocalApi
    {
        /// <summary>
        /// Terminal Api https call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <param name="encryptionCredentialDetails"></param>
        /// <returns></returns>
        SaleToPOIResponse TerminalApiLocal(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails);

        /// <summary>
        /// Terminal Api https call
        /// </summary>
        /// <param name="saleToPoiRequest"></param>
        /// <param name="encryptionCredentialDetails"></param>
        /// <param name="remoteCertificateValidationCallback"></param>
        /// <returns></returns>
        SaleToPOIResponse TerminalApiLocal(SaleToPOIMessage saleToPoiRequest, EncryptionCredentialDetails encryptionCredentialDetails, RemoteCertificateValidationCallback remoteCertificateValidationCallback);

        /// <summary>
        /// Used to decrypt the notification received
        /// </summary>
        /// <param name="notification"></param>
        /// <param name="encryptionCredentialDetails"></param>
        /// <returns></returns>
        string DecryptNotification(string notification, EncryptionCredentialDetails encryptionCredentialDetails);
    }
}