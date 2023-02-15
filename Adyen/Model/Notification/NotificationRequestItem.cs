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

using System.Collections.Generic;
using Adyen.Model.Checkout;

namespace Adyen.Model.Notification
{
    public class NotificationRequestItem
    {
        public Amount Amount { get; set; }
        public string EventCode { get; set; }
        public string EventDate { get; set; }
        public string MerchantAccountCode  { get; set; }
        public string MerchantReference { get; set; }
        public string OriginalReference { get; set; }
        public string PspReference { get; set; }
        public string Reason { get; set; }
        public string Success { get; set; }
        public string PaymentMethod { get; set; }
        public List<string> Operations { get; set; }
        public Dictionary<string, string> AdditionalData { get; set; }
    }
}