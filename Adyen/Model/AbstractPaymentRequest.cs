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

using Adyen.Model.Enum;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model
{
    [DataContract]
    public abstract class AbstractPaymentRequest
    {
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Amount Amount { get; set; }
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        public Address BillingAddress { get; set; }
        [DataMember(Name = "shopperIP", EmitDefaultValue = false)]
        public string ShopperIP { get; set; }
        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        public string MerchantAccount { get; set; }
        [DataMember(Name = "browserInfo", EmitDefaultValue = false)]
        public BrowserInfo BrowserInfo { get; set; }
        [DataMember(Name = "shopperInteraction", EmitDefaultValue = false)]
        [JsonConverter(typeof(StringEnumConverter))]
        public ShopperInteraction ShopperInteraction { get; set; }
        [DataMember(Name = "shopperEmail", EmitDefaultValue = false)]
        public string ShopperEmail { get; set; }
        [DataMember(Name = "shopperReference", EmitDefaultValue = false)]
        public string ShopperReference { get; set; }
        [DataMember(Name = "recurring", EmitDefaultValue = false)]
        public Recurring.Recurring Recurring { get; set; }
        [DataMember(Name = "shopperStatement", EmitDefaultValue = false)]
        public string ShopperStatement { get; set; }
        [DataMember(Name = "fraudOffset", EmitDefaultValue = false)]
        public int FraudOffset { get; set; }
        [DataMember(Name = "sessionId", EmitDefaultValue = false)]
        public string SessionId { get; set; }
        [DataMember(Name = "additionalAmount", EmitDefaultValue = false)]
        public Amount AdditionalAmount { get; set; }
        [DataMember(Name = "selectedRecurringDetailReference", EmitDefaultValue = false)]
        public string SelectedRecurringDetailReference { get; set; }
        [DataMember(Name = "orderReference", EmitDefaultValue = false)]
        public string OrderReference { get; set; }
        [DataMember(Name = "merchantOrderReference", EmitDefaultValue = false)]
        public string MerchantOrderReference { get; set; }
        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        public Dictionary<string, string> AdditionalData { get; set; }
        [DataMember(Name = "shopperName", EmitDefaultValue = false)]
        public Name ShopperName { get; set; }
        [DataMember(Name = "shopperLocale", EmitDefaultValue = false)]
        public string ShopperLocale { get; set; }
        [DataMember(Name = "selectedBrand", EmitDefaultValue = false)]
        public string SelectedBrand { get; set; }
        [DataMember(Name = "deliveryAddress", EmitDefaultValue = false)]
        public Address DeliveryAddress { get; set; }
        [DataMember(Name = "deliveryDate", EmitDefaultValue = false)]
        public DateTime DeliveryDate { get; set; }
        [DataMember(Name = "deviceFingerprint", EmitDefaultValue = false)]
        public string DeviceFingerprint { get; set; }
        [DataMember(Name = "installments", EmitDefaultValue = false)]
        public Installments Installments { get; set; }
        [DataMember(Name = "socialSecurityNumber", EmitDefaultValue = false)]
        public string SocialSecurityNumber { get; set; }
        [DataMember(Name = "captureDelayHours", EmitDefaultValue = false)]
        public int CaptureDelayHours { get; set; }
        [DataMember(Name = "dateOfBirth", EmitDefaultValue = false)]
        public DateTime DateOfBirth { get; set; }
        [DataMember(Name = "telephoneNumber", EmitDefaultValue = false)]
        public string TelephoneNumber { get; set; }
        [DataMember(Name="mcc", EmitDefaultValue = false)]
        public string Mcc { get; set; }

        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        [DataMember(Name = "applicationInfo", EmitDefaultValue = false)]
        public ApplicationInformation.ApplicationInfo ApplicationInfo { get;set; }

        [DataMember(Name = "enableRealTimeUpdate", EmitDefaultValue = false)]
        public bool EnableRealTimeUpdate { get; set; }

        [DataMember(Name = "threeDSAuthenticationOnly", EmitDefaultValue = false)]
        public bool ThreeDSAuthenticationOnly { get; set; }
    }
}
