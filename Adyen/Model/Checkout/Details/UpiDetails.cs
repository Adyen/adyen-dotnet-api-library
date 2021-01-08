#region Licence
// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2020 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.
#endregion
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout.Details
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class UpiDetails : IPaymentMethodDetails
    {
        //Possible types
        public const string Upi = "upi";
        /// <summary>
        /// shopperNotificationReference
        /// </summary>
        /// <value>shopperNotificationReference</value>
        [DataMember(Name = "shopperNotificationReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shopperNotificationReference")]
        public string ShopperNotificationReference { get; set; }

        /// <summary>
        ///storedPaymentMethodId
        /// </summary>
        /// <value>storedPaymentMethodId</value>
        [DataMember(Name = "storedPaymentMethodId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "storedPaymentMethodId")]
        public string StoredPaymentMethodId { get; set; }

        /// <summary>
        /// subscriptionDetails
        /// </summary>
        /// <value>subscriptionDetails</value>
        [DataMember(Name = "subscriptionDetails", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "subscriptionDetails")]
        public string SubscriptionDetails { get; set; }

        /// <summary>
        /// virtualPaymentAddress
        /// </summary>
        /// <value>virtualPaymentAddress</value>
        [DataMember(Name = "virtualPaymentAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "virtualPaymentAddress")]
        public string VirtualPaymentAddress { get; set; }


        /// <summary>
        /// **UPIpay**
        /// </summary>
        /// <value>**UPIpay**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; } = Upi;

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpiDetails {\n");
            sb.Append("  ShopperNotificationReference: ").Append(ShopperNotificationReference).Append("\n");
            sb.Append("  StoredPaymentMethodId: ").Append(StoredPaymentMethodId).Append("\n");
            sb.Append("  SubscriptionDetails: ").Append(SubscriptionDetails).Append("\n");
            sb.Append("  VirtualPaymentAddress: ").Append(VirtualPaymentAddress).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

    }
}
