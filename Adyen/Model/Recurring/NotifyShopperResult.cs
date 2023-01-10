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
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Adyen.Model.Recurring
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class NotifyShopperResult
    {
        /// <summary>
        /// Reference of Pre-debit notification that is displayed to the shopper
        /// </summary>
        /// <value>Reference of Pre-debit notification that is displayed to the shopper</value>
        [DataMember(Name = "displayedReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "displayedReference")]
        public string DisplayedReference { get; set; }

        /// <summary>
        /// A simple description of the `resultCode`.
        /// </summary>
        /// <value>A simple description of the `resultCode`.</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// The unique reference that is associated with the request.
        /// </summary>
        /// <value>The unique reference that is associated with the request.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pspReference")]
        public string PspReference { get; set; }

        /// <summary>
        /// Reference of Pre-debit notification sent in my the merchant
        /// </summary>
        /// <value>Reference of Pre-debit notification sent in my the merchant</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reference")]
        public string Reference { get; set; }

        /// <summary>
        /// The code indicating the status of notification.
        /// </summary>
        /// <value>The code indicating the status of notification.</value>
        [DataMember(Name = "resultCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "resultCode")]
        public string ResultCode { get; set; }

        /// <summary>
        /// The unique reference for the request sent downstream.
        /// </summary>
        /// <value>The unique reference for the request sent downstream.</value>
        [DataMember(Name = "shopperNotificationReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shopperNotificationReference")]
        public string ShopperNotificationReference { get; set; }

        /// <summary>
        /// This is the recurringDetailReference returned in the response when token was created
        /// </summary>
        /// <value>This is the recurringDetailReference returned in the response when token was created</value>
        [DataMember(Name = "storedPaymentMethodId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "storedPaymentMethodId")]
        public string StoredPaymentMethodId { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NotifyShopperResult {\n");
            sb.Append("  DisplayedReference: ").Append(DisplayedReference).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
            sb.Append("  ShopperNotificationReference: ").Append(ShopperNotificationReference).Append("\n");
            sb.Append("  StoredPaymentMethodId: ").Append(StoredPaymentMethodId).Append("\n");
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
