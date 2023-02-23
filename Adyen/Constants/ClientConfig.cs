#region License
/*
 *                       ######
 *                       ######
 * ############    ####( ######  #####. ######  ############   ############
 * #############  #####( ######  #####. ######  #############  #############
 *        ######  #####( ######  #####. ######  #####  ######  #####  ######
 * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
 * ###### ######  #####( ######  #####. ######  #####          #####  ######
 * #############  #############  #############  #############  #####  ######
 *  ############   ############  #############   ############  #####  ######
 *                                      ######
 *                               #############
 *                               ############
 *
 * Adyen Dotnet API Library
 *
 * Copyright (c) 2021 Adyen B.V.
 * This file is open source and available under the MIT license.
 * See the LICENSE file for more info.
 */
#endregion

namespace Adyen.Constants
{
    public class ClientConfig
    {
        public static string EndpointTest = "https://pal-test.adyen.com";
        public static string EndpointLive = "https://pal-live.adyen.com";
        public static string EndpointLiveSuffix = "-pal-live.adyenpayments.com";
        public static string CheckoutEndpointTest = "https://checkout-test.adyen.com";
        public static string CheckoutEndpointLiveSuffix = "-checkout-live.adyenpayments.com/checkout";
        //Test cloud api endpoints
        public static string CloudApiEndPointTest = "https://terminal-api-test.adyen.com";
        //Live cloud api endpoints
        public static string CloudApiEndPointEULive = "https://terminal-api-live.adyen.com";
        public static string CloudApiEndPointAULive = "https://terminal-api-live-au.adyen.com";
        public static string CloudApiEndPointUSLive = "https://terminal-api-live-us.adyen.com";

        public static string MarketpayEndPointTest = "https://cal-test.adyen.com/cal/services";
        public static string MarketpayEndPointLive = "https://cal-live.adyen.com/cal/services";
        public static string PosTerminalManagementEndpointTest = "https://postfmapi-test.adyen.com/postfmapi/terminal";
        public static string PosTerminalManagementEndpointLive = "https://postfmapi-live.adyen.com/postfmapi/terminal";
        public static string MarketPayFundApiVersion = "v5";
        public static string MarketPayAccountApiVersion = "v5";
        public static string HopApiVersion = "v1";
        public static string RecurringApiVersion = "v68";
        public static string ApiVersion = "v68";
        public static string PayoutApiVersion = "v68";
        public static string CheckoutApiVersion = "v70";
        public static string PosTerminalManagementVersion = "v1";
        public static string UserAgentSuffix = "adyen-dotnet-api-library/";
        public static string EndpointProtocol = "https://";
        public static string NexoProtocolVersion = "3.0";
        public static string BinLookupPalSuffix = "/pal/servlet/BinLookup/";
        public static string BinLookupApiVersion = "v54";
        public static string LegalEntityManagementEndpointTest = "https://kyc-test.adyen.com/lem/";
        public static string LegalEntityManagementEndpointLive = "https://kyc-live.adyen.com/lem/";
        public static string LegalEntityManagementVersion = "v2";
        public static string StoredValueEndpointTest = "https://pal-test.adyen.com/pal/servlet/StoredValue";
        public static string StoredValueEndpointLive = "https://pal-live.adyen.com/pal/servlet/StoredValue";
        public static string StoredValueVersion = "v46";
        public static string ManagementEndpointTest = "https://management-test.adyen.com";
        public static string ManagementEndpointLive = "https://management-live.adyen.com";
        public static string ManagementVersion = "v1";

        public static string LibName = "adyen-dotnet-api-library";
        public static string LibVersion = "9.1.0";
    }
}
