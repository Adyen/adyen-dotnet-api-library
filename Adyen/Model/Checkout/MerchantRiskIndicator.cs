/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 70
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// MerchantRiskIndicator
    /// </summary>
    [DataContract(Name = "MerchantRiskIndicator")]
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
            [EnumMember(Value = "shipToBillingAddress")]
            ShipToBillingAddress = 1,

            /// <summary>
            /// Enum ShipToVerifiedAddress for value: shipToVerifiedAddress
            /// </summary>
            [EnumMember(Value = "shipToVerifiedAddress")]
            ShipToVerifiedAddress = 2,

            /// <summary>
            /// Enum ShipToNewAddress for value: shipToNewAddress
            /// </summary>
            [EnumMember(Value = "shipToNewAddress")]
            ShipToNewAddress = 3,

            /// <summary>
            /// Enum ShipToStore for value: shipToStore
            /// </summary>
            [EnumMember(Value = "shipToStore")]
            ShipToStore = 4,

            /// <summary>
            /// Enum DigitalGoods for value: digitalGoods
            /// </summary>
            [EnumMember(Value = "digitalGoods")]
            DigitalGoods = 5,

            /// <summary>
            /// Enum GoodsNotShipped for value: goodsNotShipped
            /// </summary>
            [EnumMember(Value = "goodsNotShipped")]
            GoodsNotShipped = 6,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 7

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
            [EnumMember(Value = "electronicDelivery")]
            ElectronicDelivery = 1,

            /// <summary>
            /// Enum SameDayShipping for value: sameDayShipping
            /// </summary>
            [EnumMember(Value = "sameDayShipping")]
            SameDayShipping = 2,

            /// <summary>
            /// Enum OvernightShipping for value: overnightShipping
            /// </summary>
            [EnumMember(Value = "overnightShipping")]
            OvernightShipping = 3,

            /// <summary>
            /// Enum TwoOrMoreDaysShipping for value: twoOrMoreDaysShipping
            /// </summary>
            [EnumMember(Value = "twoOrMoreDaysShipping")]
            TwoOrMoreDaysShipping = 4

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
        /// <param name="deliveryEmailAddress">For Electronic delivery, the email address to which the merchandise was delivered. Maximum length: 254 characters..</param>
        /// <param name="deliveryTimeframe">The estimated delivery time for the shopper to receive the goods. Allowed values: * &#x60;electronicDelivery&#x60; * &#x60;sameDayShipping&#x60; * &#x60;overnightShipping&#x60; * &#x60;twoOrMoreDaysShipping&#x60;.</param>
        /// <param name="giftCardAmount">giftCardAmount.</param>
        /// <param name="giftCardCount">For prepaid or gift card purchase, total count of individual prepaid or gift cards/codes purchased..</param>
        /// <param name="giftCardCurr">For prepaid or gift card purchase, [ISO 4217](https://www.iso.org/iso-4217-currency-codes.html) three-digit currency code of the gift card, other than those listed in Table A.5 of the EMVCo 3D Secure Protocol and Core Functions Specification..</param>
        /// <param name="preOrderDate">For pre-order purchases, the expected date this product will be available to the shopper..</param>
        /// <param name="preOrderPurchase">Indicator for whether this transaction is for pre-ordering a product..</param>
        /// <param name="preOrderPurchaseInd">Indicates whether Cardholder is placing an order for merchandise with a future availability or release date..</param>
        /// <param name="reorderItems">Indicator for whether the shopper has already purchased the same items in the past..</param>
        /// <param name="reorderItemsInd">Indicates whether the cardholder is reordering previously purchased merchandise..</param>
        /// <param name="shipIndicator">Indicates shipping method chosen for the transaction..</param>
        public MerchantRiskIndicator(bool? addressMatch = default(bool?), DeliveryAddressIndicatorEnum? deliveryAddressIndicator = default(DeliveryAddressIndicatorEnum?), string deliveryEmail = default(string), string deliveryEmailAddress = default(string), DeliveryTimeframeEnum? deliveryTimeframe = default(DeliveryTimeframeEnum?), Amount giftCardAmount = default(Amount), int? giftCardCount = default(int?), string giftCardCurr = default(string), DateTime preOrderDate = default(DateTime), bool? preOrderPurchase = default(bool?), string preOrderPurchaseInd = default(string), bool? reorderItems = default(bool?), string reorderItemsInd = default(string), string shipIndicator = default(string))
        {
            this.AddressMatch = addressMatch;
            this.DeliveryAddressIndicator = deliveryAddressIndicator;
            this.DeliveryEmail = deliveryEmail;
            this.DeliveryEmailAddress = deliveryEmailAddress;
            this.DeliveryTimeframe = deliveryTimeframe;
            this.GiftCardAmount = giftCardAmount;
            this.GiftCardCount = giftCardCount;
            this.GiftCardCurr = giftCardCurr;
            this.PreOrderDate = preOrderDate;
            this.PreOrderPurchase = preOrderPurchase;
            this.PreOrderPurchaseInd = preOrderPurchaseInd;
            this.ReorderItems = reorderItems;
            this.ReorderItemsInd = reorderItemsInd;
            this.ShipIndicator = shipIndicator;
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
        [Obsolete]
        public string DeliveryEmail { get; set; }

        /// <summary>
        /// For Electronic delivery, the email address to which the merchandise was delivered. Maximum length: 254 characters.
        /// </summary>
        /// <value>For Electronic delivery, the email address to which the merchandise was delivered. Maximum length: 254 characters.</value>
        [DataMember(Name = "deliveryEmailAddress", EmitDefaultValue = false)]
        public string DeliveryEmailAddress { get; set; }

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
        /// For prepaid or gift card purchase, [ISO 4217](https://www.iso.org/iso-4217-currency-codes.html) three-digit currency code of the gift card, other than those listed in Table A.5 of the EMVCo 3D Secure Protocol and Core Functions Specification.
        /// </summary>
        /// <value>For prepaid or gift card purchase, [ISO 4217](https://www.iso.org/iso-4217-currency-codes.html) three-digit currency code of the gift card, other than those listed in Table A.5 of the EMVCo 3D Secure Protocol and Core Functions Specification.</value>
        [DataMember(Name = "giftCardCurr", EmitDefaultValue = false)]
        public string GiftCardCurr { get; set; }

        /// <summary>
        /// For pre-order purchases, the expected date this product will be available to the shopper.
        /// </summary>
        /// <value>For pre-order purchases, the expected date this product will be available to the shopper.</value>
        [DataMember(Name = "preOrderDate", EmitDefaultValue = false)]
        public DateTime PreOrderDate { get; set; }

        /// <summary>
        /// Indicator for whether this transaction is for pre-ordering a product.
        /// </summary>
        /// <value>Indicator for whether this transaction is for pre-ordering a product.</value>
        [DataMember(Name = "preOrderPurchase", EmitDefaultValue = false)]
        public bool? PreOrderPurchase { get; set; }

        /// <summary>
        /// Indicates whether Cardholder is placing an order for merchandise with a future availability or release date.
        /// </summary>
        /// <value>Indicates whether Cardholder is placing an order for merchandise with a future availability or release date.</value>
        [DataMember(Name = "preOrderPurchaseInd", EmitDefaultValue = false)]
        public string PreOrderPurchaseInd { get; set; }

        /// <summary>
        /// Indicator for whether the shopper has already purchased the same items in the past.
        /// </summary>
        /// <value>Indicator for whether the shopper has already purchased the same items in the past.</value>
        [DataMember(Name = "reorderItems", EmitDefaultValue = false)]
        public bool? ReorderItems { get; set; }

        /// <summary>
        /// Indicates whether the cardholder is reordering previously purchased merchandise.
        /// </summary>
        /// <value>Indicates whether the cardholder is reordering previously purchased merchandise.</value>
        [DataMember(Name = "reorderItemsInd", EmitDefaultValue = false)]
        public string ReorderItemsInd { get; set; }

        /// <summary>
        /// Indicates shipping method chosen for the transaction.
        /// </summary>
        /// <value>Indicates shipping method chosen for the transaction.</value>
        [DataMember(Name = "shipIndicator", EmitDefaultValue = false)]
        public string ShipIndicator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MerchantRiskIndicator {\n");
            sb.Append("  AddressMatch: ").Append(AddressMatch).Append("\n");
            sb.Append("  DeliveryAddressIndicator: ").Append(DeliveryAddressIndicator).Append("\n");
            sb.Append("  DeliveryEmail: ").Append(DeliveryEmail).Append("\n");
            sb.Append("  DeliveryEmailAddress: ").Append(DeliveryEmailAddress).Append("\n");
            sb.Append("  DeliveryTimeframe: ").Append(DeliveryTimeframe).Append("\n");
            sb.Append("  GiftCardAmount: ").Append(GiftCardAmount).Append("\n");
            sb.Append("  GiftCardCount: ").Append(GiftCardCount).Append("\n");
            sb.Append("  GiftCardCurr: ").Append(GiftCardCurr).Append("\n");
            sb.Append("  PreOrderDate: ").Append(PreOrderDate).Append("\n");
            sb.Append("  PreOrderPurchase: ").Append(PreOrderPurchase).Append("\n");
            sb.Append("  PreOrderPurchaseInd: ").Append(PreOrderPurchaseInd).Append("\n");
            sb.Append("  ReorderItems: ").Append(ReorderItems).Append("\n");
            sb.Append("  ReorderItemsInd: ").Append(ReorderItemsInd).Append("\n");
            sb.Append("  ShipIndicator: ").Append(ShipIndicator).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
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
            {
                return false;
            }
            return 
                (
                    this.AddressMatch == input.AddressMatch ||
                    this.AddressMatch.Equals(input.AddressMatch)
                ) && 
                (
                    this.DeliveryAddressIndicator == input.DeliveryAddressIndicator ||
                    this.DeliveryAddressIndicator.Equals(input.DeliveryAddressIndicator)
                ) && 
                (
                    this.DeliveryEmail == input.DeliveryEmail ||
                    (this.DeliveryEmail != null &&
                    this.DeliveryEmail.Equals(input.DeliveryEmail))
                ) && 
                (
                    this.DeliveryEmailAddress == input.DeliveryEmailAddress ||
                    (this.DeliveryEmailAddress != null &&
                    this.DeliveryEmailAddress.Equals(input.DeliveryEmailAddress))
                ) && 
                (
                    this.DeliveryTimeframe == input.DeliveryTimeframe ||
                    this.DeliveryTimeframe.Equals(input.DeliveryTimeframe)
                ) && 
                (
                    this.GiftCardAmount == input.GiftCardAmount ||
                    (this.GiftCardAmount != null &&
                    this.GiftCardAmount.Equals(input.GiftCardAmount))
                ) && 
                (
                    this.GiftCardCount == input.GiftCardCount ||
                    this.GiftCardCount.Equals(input.GiftCardCount)
                ) && 
                (
                    this.GiftCardCurr == input.GiftCardCurr ||
                    (this.GiftCardCurr != null &&
                    this.GiftCardCurr.Equals(input.GiftCardCurr))
                ) && 
                (
                    this.PreOrderDate == input.PreOrderDate ||
                    (this.PreOrderDate != null &&
                    this.PreOrderDate.Equals(input.PreOrderDate))
                ) && 
                (
                    this.PreOrderPurchase == input.PreOrderPurchase ||
                    this.PreOrderPurchase.Equals(input.PreOrderPurchase)
                ) && 
                (
                    this.PreOrderPurchaseInd == input.PreOrderPurchaseInd ||
                    (this.PreOrderPurchaseInd != null &&
                    this.PreOrderPurchaseInd.Equals(input.PreOrderPurchaseInd))
                ) && 
                (
                    this.ReorderItems == input.ReorderItems ||
                    this.ReorderItems.Equals(input.ReorderItems)
                ) && 
                (
                    this.ReorderItemsInd == input.ReorderItemsInd ||
                    (this.ReorderItemsInd != null &&
                    this.ReorderItemsInd.Equals(input.ReorderItemsInd))
                ) && 
                (
                    this.ShipIndicator == input.ShipIndicator ||
                    (this.ShipIndicator != null &&
                    this.ShipIndicator.Equals(input.ShipIndicator))
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
                hashCode = (hashCode * 59) + this.AddressMatch.GetHashCode();
                hashCode = (hashCode * 59) + this.DeliveryAddressIndicator.GetHashCode();
                if (this.DeliveryEmail != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryEmail.GetHashCode();
                }
                if (this.DeliveryEmailAddress != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryEmailAddress.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DeliveryTimeframe.GetHashCode();
                if (this.GiftCardAmount != null)
                {
                    hashCode = (hashCode * 59) + this.GiftCardAmount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.GiftCardCount.GetHashCode();
                if (this.GiftCardCurr != null)
                {
                    hashCode = (hashCode * 59) + this.GiftCardCurr.GetHashCode();
                }
                if (this.PreOrderDate != null)
                {
                    hashCode = (hashCode * 59) + this.PreOrderDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PreOrderPurchase.GetHashCode();
                if (this.PreOrderPurchaseInd != null)
                {
                    hashCode = (hashCode * 59) + this.PreOrderPurchaseInd.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReorderItems.GetHashCode();
                if (this.ReorderItemsInd != null)
                {
                    hashCode = (hashCode * 59) + this.ReorderItemsInd.GetHashCode();
                }
                if (this.ShipIndicator != null)
                {
                    hashCode = (hashCode * 59) + this.ShipIndicator.GetHashCode();
                }
                return hashCode;
            }
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // DeliveryEmailAddress (string) maxLength
            if (this.DeliveryEmailAddress != null && this.DeliveryEmailAddress.Length > 254)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DeliveryEmailAddress, length must be less than 254.", new [] { "DeliveryEmailAddress" });
            }

            yield break;
        }
    }

}
