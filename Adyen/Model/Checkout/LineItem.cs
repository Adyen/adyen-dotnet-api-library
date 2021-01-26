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
    /// LineItem
    /// </summary>
    [DataContract]
    public partial class LineItem :  IEquatable<LineItem>, IValidatableObject
    {
        /// <summary>
        /// Tax category: High, Low, None, Zero
        /// </summary>
        /// <value>Tax category: High, Low, None, Zero</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TaxCategoryEnum
        {
            
            /// <summary>
            /// Enum High for value: High
            /// </summary>
            [EnumMember(Value = "High")]
            High = 1,
            
            /// <summary>
            /// Enum Low for value: Low
            /// </summary>
            [EnumMember(Value = "Low")]
            Low = 2,
            
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 3,
            
            /// <summary>
            /// Enum Zero for value: Zero
            /// </summary>
            [EnumMember(Value = "Zero")]
            Zero = 4
        }

        /// <summary>
        /// Tax category: High, Low, None, Zero
        /// </summary>
        /// <value>Tax category: High, Low, None, Zero</value>
        [DataMember(Name="taxCategory", EmitDefaultValue=false)]
        public TaxCategoryEnum? TaxCategory { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItem" /> class.
        /// </summary>
        /// <param name="AmountExcludingTax">Item amount excluding the tax, in minor units..</param>
        /// <param name="AmountIncludingTax">Item amount including the tax, in minor units..</param>
        /// <param name="Description">Description of the line item..</param>
        /// <param name="Id">ID of the line item..</param>
        /// <param name="Quantity">Number of items..</param>
        /// <param name="TaxAmount">Tax amount, in minor units..</param>
        /// <param name="TaxCategory">Tax category: High, Low, None, Zero.</param>
        /// <param name="TaxPercentage">Tax percentage, in minor units..</param>
        /// <param name="ProductUrl">Url to the item productpage.</param>
        /// <param name="ImageUrl">Url to an image of the item.</param>
        public LineItem(long? AmountExcludingTax = default(long?), long? AmountIncludingTax = default(long?), string Description = default(string), string Id = default(string), long? Quantity = default(long?), long? TaxAmount = default(long?), TaxCategoryEnum? TaxCategory = default(TaxCategoryEnum?), long? TaxPercentage = default(long?), string ProductUrl = default(string), string ImageUrl = default(string))
        {
            this.AmountExcludingTax = AmountExcludingTax;
            this.AmountIncludingTax = AmountIncludingTax;
            this.Description = Description;
            this.Id = Id;
            this.Quantity = Quantity;
            this.TaxAmount = TaxAmount;
            this.TaxCategory = TaxCategory;
            this.TaxPercentage = TaxPercentage;
            this.ProductUrl = ProductUrl;
            this.ImageUrl = ImageUrl;
        }
        
        /// <summary>
        /// Item amount excluding the tax, in minor units.
        /// </summary>
        /// <value>Item amount excluding the tax, in minor units.</value>
        [DataMember(Name="amountExcludingTax", EmitDefaultValue=false)]
        public long? AmountExcludingTax { get; set; }

        /// <summary>
        /// Item amount including the tax, in minor units.
        /// </summary>
        /// <value>Item amount including the tax, in minor units.</value>
        [DataMember(Name="amountIncludingTax", EmitDefaultValue=false)]
        public long? AmountIncludingTax { get; set; }

        /// <summary>
        /// Description of the line item.
        /// </summary>
        /// <value>Description of the line item.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// ID of the line item.
        /// </summary>
        /// <value>ID of the line item.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Number of items.
        /// </summary>
        /// <value>Number of items.</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public long? Quantity { get; set; }

        /// <summary>
        /// Tax amount, in minor units.
        /// </summary>
        /// <value>Tax amount, in minor units.</value>
        [DataMember(Name="taxAmount", EmitDefaultValue=false)]
        public long? TaxAmount { get; set; }


        /// <summary>
        /// Tax percentage, in minor units.
        /// </summary>
        /// <value>Tax percentage, in minor units.</value>
        [DataMember(Name="taxPercentage", EmitDefaultValue=false)]
        public long? TaxPercentage { get; set; }

        /// <summary>
        /// Url to the productpage.
        /// </summary>
        /// <value>Description of the line item.</value>
        [DataMember(Name = "productUrl", EmitDefaultValue = false)]
        public string ProductUrl { get; set; }

        /// <summary>
        /// Url to an image of the item.
        /// </summary>
        /// <value>Description of the line item.</value>
        [DataMember(Name = "imageUrl", EmitDefaultValue = false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineItem {\n");
            sb.Append("  AmountExcludingTax: ").Append(AmountExcludingTax).Append("\n");
            sb.Append("  AmountIncludingTax: ").Append(AmountIncludingTax).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  TaxCategory: ").Append(TaxCategory).Append("\n");
            sb.Append("  TaxPercentage: ").Append(TaxPercentage).Append("\n");
            sb.Append("  ProductUrl: ").Append(ProductUrl).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
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
            return this.Equals(input as LineItem);
        }

        /// <summary>
        /// Returns true if LineItem instances are equal
        /// </summary>
        /// <param name="input">Instance of LineItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AmountExcludingTax == input.AmountExcludingTax ||
                    (this.AmountExcludingTax != null &&
                    this.AmountExcludingTax.Equals(input.AmountExcludingTax))
                ) && 
                (
                    this.AmountIncludingTax == input.AmountIncludingTax ||
                    (this.AmountIncludingTax != null &&
                    this.AmountIncludingTax.Equals(input.AmountIncludingTax))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.TaxAmount == input.TaxAmount ||
                    (this.TaxAmount != null &&
                    this.TaxAmount.Equals(input.TaxAmount))
                ) && 
                (
                    this.TaxCategory == input.TaxCategory ||
                    (this.TaxCategory != null &&
                    this.TaxCategory.Equals(input.TaxCategory))
                ) && 
                (
                    this.TaxPercentage == input.TaxPercentage ||
                    (this.TaxPercentage != null &&
                    this.TaxPercentage.Equals(input.TaxPercentage))
                ) &&
                (
                    this.ProductUrl == input.ProductUrl ||
                    (this.ProductUrl != null &&
                    this.ProductUrl.Equals(input.ProductUrl))
                ) &&
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
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
                if (this.AmountExcludingTax != null)
                    hashCode = hashCode * 59 + this.AmountExcludingTax.GetHashCode();
                if (this.AmountIncludingTax != null)
                    hashCode = hashCode * 59 + this.AmountIncludingTax.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.TaxAmount != null)
                    hashCode = hashCode * 59 + this.TaxAmount.GetHashCode();
                if (this.TaxCategory != null)
                    hashCode = hashCode * 59 + this.TaxCategory.GetHashCode();
                if (this.TaxPercentage != null)
                    hashCode = hashCode * 59 + this.TaxPercentage.GetHashCode();
                if (this.ProductUrl != null)
                    hashCode = hashCode * 59 + this.ProductUrl.GetHashCode();
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
