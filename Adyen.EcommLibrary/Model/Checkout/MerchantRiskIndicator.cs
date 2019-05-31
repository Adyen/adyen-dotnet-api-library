using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.EcommLibrary.Model.Checkout
{
    /// <summary>
    /// MerchantRiskIndicator
    /// </summary>
    [DataContract]
    public partial class MerchantRiskIndicator : IEquatable<MerchantRiskIndicator>, IValidatableObject
    {
        /// <summary>
        /// Indicator regarding the delivery address.
        /// </summary>
        /// <value>Indicator regarding the delivery address.</value>
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
            [EnumMember(Value = "shipToStore")] ShipToStore = 4,

            /// <summary>
            /// Enum DigitalGoods for value: digitalGoods
            /// </summary>
            [EnumMember(Value = "digitalGoods")] DigitalGoods = 5,

            /// <summary>
            /// Enum GoodsNotShipped for value: goodsNotShipped
            /// </summary>
            [EnumMember(Value = "goodsNotShipped")]
            GoodsNotShipped = 6,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")] Other = 7
        }

        /// <summary>
        /// Indicator regarding the delivery address.
        /// </summary>
        /// <value>Indicator regarding the delivery address.</value>
        [DataMember(Name = "deliveryAddressIndicator", EmitDefaultValue = false)]
        public DeliveryAddressIndicatorEnum? DeliveryAddressIndicator { get; set; }

        /// <summary>
        /// The estimated delivery time for the shopper to receive the goods.
        /// </summary>
        /// <value>The estimated delivery time for the shopper to receive the goods.</value>
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
        /// The estimated delivery time for the shopper to receive the goods.
        /// </summary>
        /// <value>The estimated delivery time for the shopper to receive the goods.</value>
        [DataMember(Name = "deliveryTimeframe", EmitDefaultValue = false)]
        public DeliveryTimeframeEnum? DeliveryTimeframe { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantRiskIndicator" /> class.
        /// </summary>
        /// <param name="AddressMatch">Whether the chosen delivery address is identical to the billing address..</param>
        /// <param name="DeliveryAddressIndicator">Indicator regarding the delivery address..</param>
        /// <param name="DeliveryEmail">The delivery email address (for digital goods)..</param>
        /// <param name="DeliveryTimeframe">The estimated delivery time for the shopper to receive the goods..</param>
        /// <param name="GiftCardAmount">The amount of prepaid or gift cards used for this purchase..</param>
        /// <param name="GiftCardCount">Number of individual prepaid or gift cards used for this purchase..</param>
        /// <param name="PreOrderDate">For pre-order purchases, the expected date this product will be available to the shopper..</param>
        /// <param name="PreOrderPurchase">Whether this transaction is for pre-ordering a product..</param>
        /// <param name="ReorderItems">Whether the shopper has already purchased the same items in the past..</param>
        public MerchantRiskIndicator(bool? AddressMatch = default(bool?),
            DeliveryAddressIndicatorEnum? DeliveryAddressIndicator = default(DeliveryAddressIndicatorEnum?),
            string DeliveryEmail = default(string),
            DeliveryTimeframeEnum? DeliveryTimeframe = default(DeliveryTimeframeEnum?),
            Amount GiftCardAmount = default(Amount), int? GiftCardCount = default(int?),
            DateTime? PreOrderDate = default(DateTime?), bool? PreOrderPurchase = default(bool?),
            bool? ReorderItems = default(bool?))
        {
            this.AddressMatch = AddressMatch;
            this.DeliveryAddressIndicator = DeliveryAddressIndicator;
            this.DeliveryEmail = DeliveryEmail;
            this.DeliveryTimeframe = DeliveryTimeframe;
            this.GiftCardAmount = GiftCardAmount;
            this.GiftCardCount = GiftCardCount;
            this.PreOrderDate = PreOrderDate;
            this.PreOrderPurchase = PreOrderPurchase;
            this.ReorderItems = ReorderItems;
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
        /// The amount of prepaid or gift cards used for this purchase.
        /// </summary>
        /// <value>The amount of prepaid or gift cards used for this purchase.</value>
        [DataMember(Name = "giftCardAmount", EmitDefaultValue = false)]
        public Amount GiftCardAmount { get; set; }

        /// <summary>
        /// Number of individual prepaid or gift cards used for this purchase.
        /// </summary>
        /// <value>Number of individual prepaid or gift cards used for this purchase.</value>
        [DataMember(Name = "giftCardCount", EmitDefaultValue = false)]
        public int? GiftCardCount { get; set; }

        /// <summary>
        /// For pre-order purchases, the expected date this product will be available to the shopper.
        /// </summary>
        /// <value>For pre-order purchases, the expected date this product will be available to the shopper.</value>
        [DataMember(Name = "preOrderDate", EmitDefaultValue = false)]
        public DateTime? PreOrderDate { get; set; }

        /// <summary>
        /// Whether this transaction is for pre-ordering a product.
        /// </summary>
        /// <value>Whether this transaction is for pre-ordering a product.</value>
        [DataMember(Name = "preOrderPurchase", EmitDefaultValue = false)]
        public bool? PreOrderPurchase { get; set; }

        /// <summary>
        /// Whether the shopper has already purchased the same items in the past.
        /// </summary>
        /// <value>Whether the shopper has already purchased the same items in the past.</value>
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
        public string ToJson()
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
            return Equals(input as MerchantRiskIndicator);
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
                    AddressMatch == input.AddressMatch ||
                    AddressMatch != null &&
                    AddressMatch.Equals(input.AddressMatch)
                ) &&
                (
                    DeliveryAddressIndicator == input.DeliveryAddressIndicator ||
                    DeliveryAddressIndicator != null &&
                    DeliveryAddressIndicator.Equals(input.DeliveryAddressIndicator)
                ) &&
                (
                    DeliveryEmail == input.DeliveryEmail ||
                    DeliveryEmail != null &&
                    DeliveryEmail.Equals(input.DeliveryEmail)
                ) &&
                (
                    DeliveryTimeframe == input.DeliveryTimeframe ||
                    DeliveryTimeframe != null &&
                    DeliveryTimeframe.Equals(input.DeliveryTimeframe)
                ) &&
                (
                    GiftCardAmount == input.GiftCardAmount ||
                    GiftCardAmount != null &&
                    GiftCardAmount.Equals(input.GiftCardAmount)
                ) &&
                (
                    GiftCardCount == input.GiftCardCount ||
                    GiftCardCount != null &&
                    GiftCardCount.Equals(input.GiftCardCount)
                ) &&
                (
                    PreOrderDate == input.PreOrderDate ||
                    PreOrderDate != null &&
                    PreOrderDate.Equals(input.PreOrderDate)
                ) &&
                (
                    PreOrderPurchase == input.PreOrderPurchase ||
                    PreOrderPurchase != null &&
                    PreOrderPurchase.Equals(input.PreOrderPurchase)
                ) &&
                (
                    ReorderItems == input.ReorderItems ||
                    ReorderItems != null &&
                    ReorderItems.Equals(input.ReorderItems)
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
                var hashCode = 41;
                if (AddressMatch != null)
                    hashCode = hashCode * 59 + AddressMatch.GetHashCode();
                if (DeliveryAddressIndicator != null)
                    hashCode = hashCode * 59 + DeliveryAddressIndicator.GetHashCode();
                if (DeliveryEmail != null)
                    hashCode = hashCode * 59 + DeliveryEmail.GetHashCode();
                if (DeliveryTimeframe != null)
                    hashCode = hashCode * 59 + DeliveryTimeframe.GetHashCode();
                if (GiftCardAmount != null)
                    hashCode = hashCode * 59 + GiftCardAmount.GetHashCode();
                if (GiftCardCount != null)
                    hashCode = hashCode * 59 + GiftCardCount.GetHashCode();
                if (PreOrderDate != null)
                    hashCode = hashCode * 59 + PreOrderDate.GetHashCode();
                if (PreOrderPurchase != null)
                    hashCode = hashCode * 59 + PreOrderPurchase.GetHashCode();
                if (ReorderItems != null)
                    hashCode = hashCode * 59 + ReorderItems.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}