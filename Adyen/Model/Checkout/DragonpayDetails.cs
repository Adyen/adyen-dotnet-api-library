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
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// DragonpayDetails
    /// </summary>
    [DataContract]
    public partial class DragonpayDetails : IEquatable<DragonpayDetails>, IValidatableObject
    {
        /// <summary>
        /// **dragonpay**
        /// </summary>
        /// <value>**dragonpay**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Ebanking for value: dragonpay_ebanking
            /// </summary>
            [EnumMember(Value = "dragonpay_ebanking")] Ebanking = 1,

            /// <summary>
            /// Enum Otcbanking for value: dragonpay_otc_banking
            /// </summary>
            [EnumMember(Value = "dragonpay_otc_banking")] Otcbanking = 2,

            /// <summary>
            /// Enum Otcnonbanking for value: dragonpay_otc_non_banking
            /// </summary>
            [EnumMember(Value = "dragonpay_otc_non_banking")] Otcnonbanking = 3,

            /// <summary>
            /// Enum Otcphilippines for value: dragonpay_otc_philippines
            /// </summary>
            [EnumMember(Value = "dragonpay_otc_philippines")] Otcphilippines = 4
        }

        /// <summary>
        /// **dragonpay**
        /// </summary>
        /// <value>**dragonpay**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DragonpayDetails" /> class.
        /// </summary>
        /// <param name="issuer">The Dragonpay issuer value of the shopper&#x27;s selected bank. Set this to an **id** of a Dragonpay issuer to preselect it. (required).</param>
        /// <param name="shopperEmail">The shopper’s email address..</param>
        /// <param name="type">**dragonpay** (required).</param>
        public DragonpayDetails(string issuer = default(string), string shopperEmail = default(string),
            TypeEnum type = default(TypeEnum))
        {
            // to ensure "issuer" is required (not null)
            if (issuer == null)
            {
                throw new InvalidDataException("issuer is a required property for DragonpayDetails and cannot be null");
            }
            else
            {
                this.Issuer = issuer;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for DragonpayDetails and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.ShopperEmail = shopperEmail;
        }

        /// <summary>
        /// The Dragonpay issuer value of the shopper&#x27;s selected bank. Set this to an **id** of a Dragonpay issuer to preselect it.
        /// </summary>
        /// <value>The Dragonpay issuer value of the shopper&#x27;s selected bank. Set this to an **id** of a Dragonpay issuer to preselect it.</value>
        [DataMember(Name = "issuer", EmitDefaultValue = false)]
        public string Issuer { get; set; }

        /// <summary>
        /// The shopper’s email address.
        /// </summary>
        /// <value>The shopper’s email address.</value>
        [DataMember(Name = "shopperEmail", EmitDefaultValue = false)]
        public string ShopperEmail { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DragonpayDetails {\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  ShopperEmail: ").Append(ShopperEmail).Append("\n");
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
            return this.Equals(input as DragonpayDetails);
        }

        /// <summary>
        /// Returns true if DragonpayDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of DragonpayDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DragonpayDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Issuer == input.Issuer ||
                    this.Issuer != null &&
                    this.Issuer.Equals(input.Issuer)
                ) &&
                (
                    this.ShopperEmail == input.ShopperEmail ||
                    this.ShopperEmail != null &&
                    this.ShopperEmail.Equals(input.ShopperEmail)
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
                if (this.Issuer != null)
                    hashCode = hashCode * 59 + this.Issuer.GetHashCode();
                if (this.ShopperEmail != null)
                    hashCode = hashCode * 59 + this.ShopperEmail.GetHashCode();
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