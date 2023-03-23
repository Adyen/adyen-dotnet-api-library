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
//  * Copyright (c) 2022 Adyen N.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using System.Net;
using Environment = Adyen.Model.Environment;

namespace Adyen
{
    public class Config
    {
        //Merchant details
        public string Username { get; set; }
        public string Password { get; set; }
        public string MerchantAccount { get; set; }
        public Environment Environment { get; set; }
        public string LiveEndpointUrlPrefix { get; set; }
        public string Endpoint { get; set; }
        public string MarketPayEndpoint { get; set; }
        public string ApplicationName { get; set; }
        public IWebProxy Proxy { get; set; }
        public string HmacKey { get; set; }
        public string CheckoutEndpoint { get;set; }
        public string StoredValueEndpoint { get;set; }
        public string LegalEntityManagementEndpoint { get;set; }
        public string ManagementEndpoint { get;set; }
        public string TransfersEndpoint { get;set; }
        public string BalancePlatformEndpoint { get;set; }
        public string DataProtectionEndpoint { get;set; }
        //Terminal cloud api
        public string XApiKey { get; set; }
        // Timeout in milliseconds
        public int Timeout { get; set; }
        public string CloudApiEndPoint { get; set; }
        //POS Terminal Management 
        public string PosTerminalManagementEndpoint { get; set; }
        public bool HasPassword => !string.IsNullOrEmpty(Password);
        public bool HasApiKey => !string.IsNullOrEmpty(XApiKey);
    }
}