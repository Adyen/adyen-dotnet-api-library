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
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

namespace Adyen.Constants.HPPConstants
{
    public class Response
    {
        public string AuthResult = "authResult";
        public string MerchantReference = "merchantReference";
        public string MerchantSig = "merchantSig";
        public string PaymentMethod = "paymentMethod";
        public string PspReference = "pspReference";
        public string ShopperLocale = "shopperLocale";
        public string SkinCode = "skinCode";

        /*
         authResult Returns the outcome of the payment.
         It can take one of the following values:
         AUTHORISED: the payment authorisation was successfully completed
         REFUSED: the payment was refused. Payment authorisation was unsuccessful.
         CANCELLED: the payment was cancelled by the shopper before completion, or the shopper returned to the merchant's site before completing the transaction.
         PENDING: it is not possible to obtain the final status of the payment.
         This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment.
         ERROR: an error occurred during the payment processing.
         */
        public string AuthResultAuthorised = "AUTHORISED";
        public string AuthResultRefused = "REFUSED";
        public string AuthResultCancelled = "CANCELLED";
        public string AuthResultPending = "PENDING";
        public string AuthResultError = "ERROR";
    }
}