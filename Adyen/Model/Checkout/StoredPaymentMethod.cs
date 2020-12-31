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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Adyen.Util;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// StoredPaymentMethod
    /// </summary>
    [DataContract]
    public partial class StoredPaymentMethod : IEquatable<StoredPaymentMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoredPaymentMethod" /> class.
        /// </summary>
        /// <param name="brand">The brand of the card..</param>
        /// <param name="expiryMonth">The month the card expires..</param>
        /// <param name="expiryYear">The year the card expires..</param>
        /// <param name="holderName">The unique payment method code..</param>
        /// <param name="id">A unique identifier of this stored payment method..</param>
        /// <param name="lastFour">The last four digits of the PAN..</param>
        /// <param name="name">The display name of the stored payment method..</param>
        /// <param name="shopperEmail">The shopper’s email address..</param>
        /// <param name="supportedShopperInteractions">The supported shopper interactions for this stored payment method..</param>
        /// <param name="type">The type of payment method..</param>
        public StoredPaymentMethod(string brand = default(string), string expiryMonth = default(string),
            string expiryYear = default(string), string holderName = default(string), string id = default(string),
            string lastFour = default(string), string name = default(string), string shopperEmail = default(string),
            List<string> supportedShopperInteractions = default(List<string>), string type = default(string))
        {
            this.Brand = brand;
            this.ExpiryMonth = expiryMonth;
            this.ExpiryYear = expiryYear;
            this.HolderName = holderName;
            this.Id = id;
            this.LastFour = lastFour;
            this.Name = name;
            this.ShopperEmail = shopperEmail;
            this.SupportedShopperInteractions = supportedShopperInteractions;
            this.Type = type;
        }

        /// <summary>
        /// The brand of the card.
        /// </summary>
        /// <value>The brand of the card.</value>
        [DataMember(Name = "brand", EmitDefaultValue = false)]
        public string Brand { get; set; }

        /// <summary>
        /// The month the card expires.
        /// </summary>
        /// <value>The month the card expires.</value>
        [DataMember(Name = "expiryMonth", EmitDefaultValue = false)]
        public string ExpiryMonth { get; set; }

        /// <summary>
        /// The year the card expires.
        /// </summary>
        /// <value>The year the card expires.</value>
        [DataMember(Name = "expiryYear", EmitDefaultValue = false)]
        public string ExpiryYear { get; set; }

        /// <summary>
        /// The unique payment method code.
        /// </summary>
        /// <value>The unique payment method code.</value>
        [DataMember(Name = "holderName", EmitDefaultValue = false)]
        public string HolderName { get; set; }

        /// <summary>
        /// A unique identifier of this stored payment method.
        /// </summary>
        /// <value>A unique identifier of this stored payment method.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The last four digits of the PAN.
        /// </summary>
        /// <value>The last four digits of the PAN.</value>
        [DataMember(Name = "lastFour", EmitDefaultValue = false)]
        public string LastFour { get; set; }

        /// <summary>
        /// The display name of the stored payment method.
        /// </summary>
        /// <value>The display name of the stored payment method.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The shopper’s email address.
        /// </summary>
        /// <value>The shopper’s email address.</value>
        [DataMember(Name = "shopperEmail", EmitDefaultValue = false)]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// The supported shopper interactions for this stored payment method.
        /// </summary>
        /// <value>The supported shopper interactions for this stored payment method.</value>
        [DataMember(Name = "supportedShopperInteractions", EmitDefaultValue = false)]
        public List<string> SupportedShopperInteractions { get; set; }

        /// <summary>
        /// The type of payment method.
        /// </summary>
        /// <value>The type of payment method.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoredPaymentMethod {\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  ExpiryMonth: ").Append(ExpiryMonth).Append("\n");
            sb.Append("  ExpiryYear: ").Append(ExpiryYear).Append("\n");
            sb.Append("  HolderName: ").Append(HolderName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastFour: ").Append(LastFour).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ShopperEmail: ").Append(ShopperEmail).Append("\n");
            sb.Append("  SupportedShopperInteractions: ").Append(SupportedShopperInteractions.ToListString()).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as StoredPaymentMethod);
        }

        /// <summary>
        /// Returns true if StoredPaymentMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of StoredPaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoredPaymentMethod input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Brand == input.Brand ||
                    this.Brand != null &&
                    this.Brand.Equals(input.Brand)
                ) &&
                (
                    this.ExpiryMonth == input.ExpiryMonth ||
                    this.ExpiryMonth != null &&
                    this.ExpiryMonth.Equals(input.ExpiryMonth)
                ) &&
                (
                    this.ExpiryYear == input.ExpiryYear ||
                    this.ExpiryYear != null &&
                    this.ExpiryYear.Equals(input.ExpiryYear)
                ) &&
                (
                    this.HolderName == input.HolderName ||
                    this.HolderName != null &&
                    this.HolderName.Equals(input.HolderName)
                ) &&
                (
                    this.Id == input.Id ||
                    this.Id != null &&
                    this.Id.Equals(input.Id)
                ) &&
                (
                    this.LastFour == input.LastFour ||
                    this.LastFour != null &&
                    this.LastFour.Equals(input.LastFour)
                ) &&
                (
                    this.Name == input.Name ||
                    this.Name != null &&
                    this.Name.Equals(input.Name)
                ) &&
                (
                    this.ShopperEmail == input.ShopperEmail ||
                    this.ShopperEmail != null &&
                    this.ShopperEmail.Equals(input.ShopperEmail)
                ) &&
                (
                    this.SupportedShopperInteractions == input.SupportedShopperInteractions ||
                    this.SupportedShopperInteractions != null &&
                    input.SupportedShopperInteractions != null &&
                    this.SupportedShopperInteractions.SequenceEqual(input.SupportedShopperInteractions)
                ) &&
                (
                    this.Type == input.Type ||
                    this.Type != null &&
                    this.Type.Equals(input.Type)
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
                if (this.Brand != null)
                    hashCode = hashCode * 59 + this.Brand.GetHashCode();
                if (this.ExpiryMonth != null)
                    hashCode = hashCode * 59 + this.ExpiryMonth.GetHashCode();
                if (this.ExpiryYear != null)
                    hashCode = hashCode * 59 + this.ExpiryYear.GetHashCode();
                if (this.HolderName != null)
                    hashCode = hashCode * 59 + this.HolderName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LastFour != null)
                    hashCode = hashCode * 59 + this.LastFour.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ShopperEmail != null)
                    hashCode = hashCode * 59 + this.ShopperEmail.GetHashCode();
                if (this.SupportedShopperInteractions != null)
                    hashCode = hashCode * 59 + this.SupportedShopperInteractions.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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