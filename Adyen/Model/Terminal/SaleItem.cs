/*
* Adyen Terminal API
*
*
* The version of the OpenAPI document: 1
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

namespace Adyen.Model.Terminal
{
    /// <summary>
    /// In loyalty or value added payment card transaction, the items of the sale are entering in the processing of the transaction. Sale items of a transaction.
    /// </summary>
    [DataContract(Name = "SaleItem")]
    public partial class SaleItem : IEquatable<SaleItem>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets UnitOfMeasure
        /// </summary>
        [DataMember(Name = "UnitOfMeasure", EmitDefaultValue = false)]
        public UnitOfMeasure? UnitOfMeasure { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SaleItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SaleItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SaleItem" /> class.
        /// </summary>
        /// <param name="itemID">Item identification inside a transaction (0 to n). (required).</param>
        /// <param name="productCode">Product code of item purchased with the transaction. (required).</param>
        /// <param name="eanUpc">If data sent, POI has to store it and send it if the host protocol allows it..</param>
        /// <param name="unitOfMeasure">unitOfMeasure.</param>
        /// <param name="quantity">If data sent, POI has to store it and send it if the host protocol allows it..</param>
        /// <param name="unitPrice">if Quantity present..</param>
        /// <param name="itemAmount">Total amount of the item line. (required).</param>
        /// <param name="taxCode">If data sent, POI has to store it and send it if the host protocol allows it..</param>
        /// <param name="saleChannel">If data sent, POI has to store it and send it if the host protocol allows it..</param>
        /// <param name="productLabel">productLabel.</param>
        /// <param name="additionalProductInfo">If data sent, POI has to store it and send it if the host protocol allows it..</param>
        public SaleItem(int? itemID = default(int?), int? productCode = default(int?), int? eanUpc = default(int?), UnitOfMeasure? unitOfMeasure = default(UnitOfMeasure?), string quantity = default(string), decimal? unitPrice = default(decimal?), decimal? itemAmount = default(decimal?), int? taxCode = default(int?), int? saleChannel = default(int?), string productLabel = default(string), string additionalProductInfo = default(string))
        {
            this.ItemID = itemID;
            this.ProductCode = productCode;
            this.ItemAmount = itemAmount;
            this.EanUpc = eanUpc;
            this.UnitOfMeasure = unitOfMeasure;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
            this.TaxCode = taxCode;
            this.SaleChannel = saleChannel;
            this.ProductLabel = productLabel;
            this.AdditionalProductInfo = additionalProductInfo;
        }

        /// <summary>
        /// Item identification inside a transaction (0 to n).
        /// </summary>
        /// <value>Item identification inside a transaction (0 to n).</value>
        [DataMember(Name = "ItemID", IsRequired = false, EmitDefaultValue = false)]
        public int? ItemID { get; set; }

        /// <summary>
        /// Product code of item purchased with the transaction.
        /// </summary>
        /// <value>Product code of item purchased with the transaction.</value>
        [DataMember(Name = "ProductCode", IsRequired = false, EmitDefaultValue = false)]
        public int? ProductCode { get; set; }

        /// <summary>
        /// If data sent, POI has to store it and send it if the host protocol allows it.
        /// </summary>
        /// <value>If data sent, POI has to store it and send it if the host protocol allows it.</value>
        [DataMember(Name = "EanUpc", EmitDefaultValue = false)]
        public int? EanUpc { get; set; }

        /// <summary>
        /// If data sent, POI has to store it and send it if the host protocol allows it.
        /// </summary>
        /// <value>If data sent, POI has to store it and send it if the host protocol allows it.</value>
        [DataMember(Name = "Quantity", EmitDefaultValue = false)]
        public string Quantity { get; set; }

        /// <summary>
        /// if Quantity present.
        /// </summary>
        /// <value>if Quantity present.</value>
        [DataMember(Name = "UnitPrice", EmitDefaultValue = false)]
        public decimal? UnitPrice { get; set; }

        /// <summary>
        /// Total amount of the item line.
        /// </summary>
        /// <value>Total amount of the item line.</value>
        [DataMember(Name = "ItemAmount", IsRequired = false, EmitDefaultValue = false)]
        public decimal? ItemAmount { get; set; }

        /// <summary>
        /// If data sent, POI has to store it and send it if the host protocol allows it.
        /// </summary>
        /// <value>If data sent, POI has to store it and send it if the host protocol allows it.</value>
        [DataMember(Name = "TaxCode", EmitDefaultValue = false)]
        public int? TaxCode { get; set; }

        /// <summary>
        /// If data sent, POI has to store it and send it if the host protocol allows it.
        /// </summary>
        /// <value>If data sent, POI has to store it and send it if the host protocol allows it.</value>
        [DataMember(Name = "SaleChannel", EmitDefaultValue = false)]
        public int? SaleChannel { get; set; }

        /// <summary>
        /// Gets or Sets ProductLabel
        /// </summary>
        [DataMember(Name = "ProductLabel", EmitDefaultValue = false)]
        public string ProductLabel { get; set; }

        /// <summary>
        /// If data sent, POI has to store it and send it if the host protocol allows it.
        /// </summary>
        /// <value>If data sent, POI has to store it and send it if the host protocol allows it.</value>
        [DataMember(Name = "AdditionalProductInfo", EmitDefaultValue = false)]
        public string AdditionalProductInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SaleItem {\n");
            sb.Append("  ItemID: ").Append(ItemID).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  EanUpc: ").Append(EanUpc).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  ItemAmount: ").Append(ItemAmount).Append("\n");
            sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
            sb.Append("  SaleChannel: ").Append(SaleChannel).Append("\n");
            sb.Append("  ProductLabel: ").Append(ProductLabel).Append("\n");
            sb.Append("  AdditionalProductInfo: ").Append(AdditionalProductInfo).Append("\n");
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
            return this.Equals(input as SaleItem);
        }

        /// <summary>
        /// Returns true if SaleItem instances are equal
        /// </summary>
        /// <param name="input">Instance of SaleItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SaleItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ItemID == input.ItemID ||
                    this.ItemID.Equals(input.ItemID)
                ) && 
                (
                    this.ProductCode == input.ProductCode ||
                    this.ProductCode.Equals(input.ProductCode)
                ) && 
                (
                    this.EanUpc == input.EanUpc ||
                    this.EanUpc.Equals(input.EanUpc)
                ) && 
                (
                    this.UnitOfMeasure == input.UnitOfMeasure ||
                    this.UnitOfMeasure.Equals(input.UnitOfMeasure)
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.UnitPrice == input.UnitPrice ||
                    this.UnitPrice.Equals(input.UnitPrice)
                ) && 
                (
                    this.ItemAmount == input.ItemAmount ||
                    this.ItemAmount.Equals(input.ItemAmount)
                ) && 
                (
                    this.TaxCode == input.TaxCode ||
                    this.TaxCode.Equals(input.TaxCode)
                ) && 
                (
                    this.SaleChannel == input.SaleChannel ||
                    this.SaleChannel.Equals(input.SaleChannel)
                ) && 
                (
                    this.ProductLabel == input.ProductLabel ||
                    (this.ProductLabel != null &&
                    this.ProductLabel.Equals(input.ProductLabel))
                ) && 
                (
                    this.AdditionalProductInfo == input.AdditionalProductInfo ||
                    (this.AdditionalProductInfo != null &&
                    this.AdditionalProductInfo.Equals(input.AdditionalProductInfo))
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
                hashCode = (hashCode * 59) + this.ItemID.GetHashCode();
                hashCode = (hashCode * 59) + this.ProductCode.GetHashCode();
                hashCode = (hashCode * 59) + this.EanUpc.GetHashCode();
                hashCode = (hashCode * 59) + this.UnitOfMeasure.GetHashCode();
                if (this.Quantity != null)
                {
                    hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UnitPrice.GetHashCode();
                hashCode = (hashCode * 59) + this.ItemAmount.GetHashCode();
                hashCode = (hashCode * 59) + this.TaxCode.GetHashCode();
                hashCode = (hashCode * 59) + this.SaleChannel.GetHashCode();
                if (this.ProductLabel != null)
                {
                    hashCode = (hashCode * 59) + this.ProductLabel.GetHashCode();
                }
                if (this.AdditionalProductInfo != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProductInfo.GetHashCode();
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
            // ProductCode (int) maximum
            if (this.ProductCode > (int)20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProductCode, must be a value less than or equal to 20.", new [] { "ProductCode" });
            }

            // ProductCode (int) minimum
            if (this.ProductCode < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProductCode, must be a value greater than or equal to 1.", new [] { "ProductCode" });
            }

            // UnitPrice (decimal) maximum
            if (this.UnitPrice > (decimal)99999999.999999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UnitPrice, must be a value less than or equal to 99999999.999999.", new [] { "UnitPrice" });
            }

            // UnitPrice (decimal) minimum
            if (this.UnitPrice < (decimal)0.0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UnitPrice, must be a value greater than or equal to 0.0.", new [] { "UnitPrice" });
            }

            // ItemAmount (decimal) maximum
            if (this.ItemAmount > (decimal)99999999.999999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ItemAmount, must be a value less than or equal to 99999999.999999.", new [] { "ItemAmount" });
            }

            // ItemAmount (decimal) minimum
            if (this.ItemAmount < (decimal)0.0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ItemAmount, must be a value greater than or equal to 0.0.", new [] { "ItemAmount" });
            }

            // ProductLabel (string) pattern
            Regex regexProductLabel = new Regex(@"^.+$", RegexOptions.CultureInvariant);
            if (false == regexProductLabel.Match(this.ProductLabel).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProductLabel, must match a pattern of " + regexProductLabel, new [] { "ProductLabel" });
            }

            // AdditionalProductInfo (string) pattern
            Regex regexAdditionalProductInfo = new Regex(@"^.+$", RegexOptions.CultureInvariant);
            if (false == regexAdditionalProductInfo.Match(this.AdditionalProductInfo).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AdditionalProductInfo, must match a pattern of " + regexAdditionalProductInfo, new [] { "AdditionalProductInfo" });
            }

            yield break;
        }
    }

}
