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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// MerchantRiskIndicator
    /// </summary>
    [DataContract]
    public partial class MerchantRiskIndicator : IEquatable<MerchantRiskIndicator>, IValidatableObject
    {
        /// <summary>
        /// Indicator regarding the delivery address. Allowed values: * &#x60;shipToBillingAddress&#x60; * &#x60;shipToVerifiedAddress&#x60; * &#x60;shipToNewAddress&#x60; * &#x60;shipToStore&#x60; * &#x60;digitalGoods&#x60; * &#x60;goodsNotShipped&#x60; * &#x60;other&#x60;
        /// </summary>
        /// <value>Indicator regarding the delivery address. Allowed values: * &#x60;shipToBillingAddress&#x60; * &#x60;shipToVerifiedAddress&#x60; * &#x60;shipToNewAddress&#x60; * &#x60;shipToStore&#x60; * &#x60;digitalGoods&#x60; * &#x60;goodsNotShipped&#x60; * &#x60;other&#x60;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeliveryAddressIndicatorEnum
        {
            /// <summary>
            /// Enum ShipToBillingAddress for value: shipToBillingAddress
            /// </summary>
            [EnumMember(Value = "shipToBillingAddress")] ShipToBillingAddress = 1,

            /// <summary>
            /// Enum ShipToVerifiedAddress for value: shipToVerifiedAddress
            /// </summary>
            [EnumMember(Value = "shipToVerifiedAddress")] ShipToVerifiedAddress = 2,

            /// <summary>
            /// Enum ShipToNewAddress for value: shipToNewAddress
            /// </summary>
            [EnumMember(Value = "shipToNewAddress")] ShipToNewAddress = 3,

            /// <summary>
            /// Enum ShipToStore for value: shipToStore
            /// </summary>
            [EnumMember(Value = "shipToStore")] ShipToStore = 4,

            /// <summary>
            /// Enum DigitalGoods for value: digitalGoods
            /// </summary>
            [EnumMember(Value = "digitalGoods")] DigitalGoods = 5,

            /// <summary>
            /// Enum GoodsNotShipped for value: goodsNotShipped
            /// </summary>
            [EnumMember(Value = "goodsNotShipped")] GoodsNotShipped = 6,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")] Other = 7
        }

        /// <summary>
        /// Indicator regarding the delivery address. Allowed values: * &#x60;shipToBillingAddress&#x60; * &#x60;shipToVerifiedAddress&#x60; * &#x60;shipToNewAddress&#x60; * &#x60;shipToStore&#x60; * &#x60;digitalGoods&#x60; * &#x60;goodsNotShipped&#x60; * &#x60;other&#x60;
        /// </summary>
        /// <value>Indicator regarding the delivery address. Allowed values: * &#x60;shipToBillingAddress&#x60; * &#x60;shipToVerifiedAddress&#x60; * &#x60;shipToNewAddress&#x60; * &#x60;shipToStore&#x60; * &#x60;digitalGoods&#x60; * &#x60;goodsNotShipped&#x60; * &#x60;other&#x60;</value>
        [DataMember(Name = "deliveryAddressIndicator", EmitDefaultValue = false)]
        public DeliveryAddressIndicatorEnum? DeliveryAddressIndicator { get; set; }

        /// <summary>
        /// The estimated delivery time for the shopper to receive the goods. Allowed values: * &#x60;electronicDelivery&#x60; * &#x60;sameDayShipping&#x60; * &#x60;overnightShipping&#x60; * &#x60;twoOrMoreDaysShipping&#x60;
        /// </summary>
        /// <value>The estimated delivery time for the shopper to receive the goods. Allowed values: * &#x60;electronicDelivery&#x60; * &#x60;sameDayShipping&#x60; * &#x60;overnightShipping&#x60; * &#x60;twoOrMoreDaysShipping&#x60;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeliveryTimeframeEnum
        {
            /// <summary>
            /// Enum ElectronicDelivery for value: electronicDelivery
            /// </summary>
            [EnumMember(Value = "electronicDelivery")] ElectronicDelivery = 1,

            /// <summary>
            /// Enum SameDayShipping for value: sameDayShipping
            /// </summary>
            [EnumMember(Value = "sameDayShipping")] SameDayShipping = 2,

            /// <summary>
            /// Enum OvernightShipping for value: overnightShipping
            /// </summary>
            [EnumMember(Value = "overnightShipping")] OvernightShipping = 3,

            /// <summary>
            /// Enum TwoOrMoreDaysShipping for value: twoOrMoreDaysShipping
            /// </summary>
            [EnumMember(Value = "twoOrMoreDaysShipping")] TwoOrMoreDaysShipping = 4
        }

        /// <summary>
        /// The estimated delivery time for the shopper to receive the goods. Allowed values: * &#x60;electronicDelivery&#x60; * &#x60;sameDayShipping&#x60; * &#x60;overnightShipping&#x60; * &#x60;twoOrMoreDaysShipping&#x60;
        /// </summary>
        /// <value>The estimated delivery time for the shopper to receive the goods. Allowed values: * &#x60;electronicDelivery&#x60; * &#x60;sameDayShipping&#x60; * &#x60;overnightShipping&#x60; * &#x60;twoOrMoreDaysShipping&#x60;</value>
        [DataMember(Name = "deliveryTimeframe", EmitDefaultValue = false)]
        public DeliveryTimeframeEnum? DeliveryTimeframe { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantRiskIndicator" /> class.
        /// </summary>
        /// <param name="addressMatch">Whether the chosen delivery address is identical to the billing address..</param>
        /// <param name="deliveryAddressIndicator">Indicator regarding the delivery address. Allowed values: * &#x60;shipToBillingAddress&#x60; * &#x60;shipToVerifiedAddress&#x60; * &#x60;shipToNewAddress&#x60; * &#x60;shipToStore&#x60; * &#x60;digitalGoods&#x60; * &#x60;goodsNotShipped&#x60; * &#x60;other&#x60;.</param>
        /// <param name="deliveryEmail">The delivery email address (for digital goods)..</param>
        /// <param name="deliveryTimeframe">The estimated delivery time for the shopper to receive the goods. Allowed values: * &#x60;electronicDelivery&#x60; * &#x60;sameDayShipping&#x60; * &#x60;overnightShipping&#x60; * &#x60;twoOrMoreDaysShipping&#x60;.</param>
        /// <param name="giftCardAmount">giftCardAmount.</param>
        /// <param name="giftCardCount">For prepaid or gift card purchase, total count of individual prepaid or gift cards/codes purchased..</param>
        /// <param name="preOrderDate">For pre-order purchases, the expected date this product will be available to the shopper..</param>
        /// <param name="preOrderPurchase">Indicator for whether this transaction is for pre-ordering a product..</param>
        /// <param name="reorderItems">Indicator for whether the shopper has already purchased the same items in the past..</param>
        public MerchantRiskIndicator(bool? addressMatch = default(bool?),
            DeliveryAddressIndicatorEnum? deliveryAddressIndicator = default(DeliveryAddressIndicatorEnum?),
            string deliveryEmail = default(string),
            DeliveryTimeframeEnum? deliveryTimeframe = default(DeliveryTimeframeEnum?),
            Amount giftCardAmount = default(Amount), int? giftCardCount = default(int?),
            DateTime? preOrderDate = default(DateTime?), bool? preOrderPurchase = default(bool?),
            bool? reorderItems = default(bool?))
        {
            this.AddressMatch = addressMatch;
            this.DeliveryAddressIndicator = deliveryAddressIndicator;
            this.DeliveryEmail = deliveryEmail;
            this.DeliveryTimeframe = deliveryTimeframe;
            this.GiftCardAmount = giftCardAmount;
            this.GiftCardCount = giftCardCount;
            this.PreOrderDate = preOrderDate;
            this.PreOrderPurchase = preOrderPurchase;
            this.ReorderItems = reorderItems;
        }

        /// <summary>
        /// Whether the chosen delivery address is identical to the billing address.
        /// </summary>
        /// <value>Whether the chosen delivery address is identical to the billing address.</value>
        [DataMember(Name = "addressMatch", EmitDefaultValue = false)]
        public bool? AddressMatch { get; set; }


        /// <summary>
        /// The delivery email address (for digital goods).
        /// </summary>
        /// <value>The delivery email address (for digital goods).</value>
        [DataMember(Name = "deliveryEmail", EmitDefaultValue = false)]
        public string DeliveryEmail { get; set; }


        /// <summary>
        /// Gets or Sets GiftCardAmount
        /// </summary>
        [DataMember(Name = "giftCardAmount", EmitDefaultValue = false)]
        public Amount GiftCardAmount { get; set; }

        /// <summary>
        /// For prepaid or gift card purchase, total count of individual prepaid or gift cards/codes purchased.
        /// </summary>
        /// <value>For prepaid or gift card purchase, total count of individual prepaid or gift cards/codes purchased.</value>
        [DataMember(Name = "giftCardCount", EmitDefaultValue = false)]
        public int? GiftCardCount { get; set; }

        /// <summary>
        /// For pre-order purchases, the expected date this product will be available to the shopper.
        /// </summary>
        /// <value>For pre-order purchases, the expected date this product will be available to the shopper.</value>
        [DataMember(Name = "preOrderDate", EmitDefaultValue = false)]
        public DateTime? PreOrderDate { get; set; }

        /// <summary>
        /// Indicator for whether this transaction is for pre-ordering a product.
        /// </summary>
        /// <value>Indicator for whether this transaction is for pre-ordering a product.</value>
        [DataMember(Name = "preOrderPurchase", EmitDefaultValue = false)]
        public bool? PreOrderPurchase { get; set; }

        /// <summary>
        /// Indicator for whether the shopper has already purchased the same items in the past.
        /// </summary>
        /// <value>Indicator for whether the shopper has already purchased the same items in the past.</value>
        [DataMember(Name = "reorderItems", EmitDefaultValue = false)]
        public bool? ReorderItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantRiskIndicator {\n");
            sb.Append("  AddressMatch: ").Append(AddressMatch).Append("\n");
            sb.Append("  DeliveryAddressIndicator: ").Append(DeliveryAddressIndicator).Append("\n");
            sb.Append("  DeliveryEmail: ").Append(DeliveryEmail).Append("\n");
            sb.Append("  DeliveryTimeframe: ").Append(DeliveryTimeframe).Append("\n");
            sb.Append("  GiftCardAmount: ").Append(GiftCardAmount).Append("\n");
            sb.Append("  GiftCardCount: ").Append(GiftCardCount).Append("\n");
            sb.Append("  PreOrderDate: ").Append(PreOrderDate).Append("\n");
            sb.Append("  PreOrderPurchase: ").Append(PreOrderPurchase).Append("\n");
            sb.Append("  ReorderItems: ").Append(ReorderItems).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MerchantRiskIndicator);
        }

        /// <summary>
        /// Returns true if MerchantRiskIndicator instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantRiskIndicator to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantRiskIndicator input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AddressMatch == input.AddressMatch ||
                    this.AddressMatch != null &&
                    this.AddressMatch.Equals(input.AddressMatch)
                ) &&
                (
                    this.DeliveryAddressIndicator == input.DeliveryAddressIndicator ||
                    this.DeliveryAddressIndicator != null &&
                    this.DeliveryAddressIndicator.Equals(input.DeliveryAddressIndicator)
                ) &&
                (
                    this.DeliveryEmail == input.DeliveryEmail ||
                    this.DeliveryEmail != null &&
                    this.DeliveryEmail.Equals(input.DeliveryEmail)
                ) &&
                (
                    this.DeliveryTimeframe == input.DeliveryTimeframe ||
                    this.DeliveryTimeframe != null &&
                    this.DeliveryTimeframe.Equals(input.DeliveryTimeframe)
                ) &&
                (
                    this.GiftCardAmount == input.GiftCardAmount ||
                    this.GiftCardAmount != null &&
                    this.GiftCardAmount.Equals(input.GiftCardAmount)
                ) &&
                (
                    this.GiftCardCount == input.GiftCardCount ||
                    this.GiftCardCount != null &&
                    this.GiftCardCount.Equals(input.GiftCardCount)
                ) &&
                (
                    this.PreOrderDate == input.PreOrderDate ||
                    this.PreOrderDate != null &&
                    this.PreOrderDate.Equals(input.PreOrderDate)
                ) &&
                (
                    this.PreOrderPurchase == input.PreOrderPurchase ||
                    this.PreOrderPurchase != null &&
                    this.PreOrderPurchase.Equals(input.PreOrderPurchase)
                ) &&
                (
                    this.ReorderItems == input.ReorderItems ||
                    this.ReorderItems != null &&
                    this.ReorderItems.Equals(input.ReorderItems)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AddressMatch != null)
                    hashCode = hashCode * 59 + this.AddressMatch.GetHashCode();
                if (this.DeliveryAddressIndicator != null)
                    hashCode = hashCode * 59 + this.DeliveryAddressIndicator.GetHashCode();
                if (this.DeliveryEmail != null)
                    hashCode = hashCode * 59 + this.DeliveryEmail.GetHashCode();
                if (this.DeliveryTimeframe != null)
                    hashCode = hashCode * 59 + this.DeliveryTimeframe.GetHashCode();
                if (this.GiftCardAmount != null)
                    hashCode = hashCode * 59 + this.GiftCardAmount.GetHashCode();
                if (this.GiftCardCount != null)
                    hashCode = hashCode * 59 + this.GiftCardCount.GetHashCode();
                if (this.PreOrderDate != null)
                    hashCode = hashCode * 59 + this.PreOrderDate.GetHashCode();
                if (this.PreOrderPurchase != null)
                    hashCode = hashCode * 59 + this.PreOrderPurchase.GetHashCode();
                if (this.ReorderItems != null)
                    hashCode = hashCode * 59 + this.ReorderItems.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext)
        {
            yield break;
        }
    }
}