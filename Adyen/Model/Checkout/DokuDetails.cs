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
    /// DokuDetails
    /// </summary>
    [DataContract]
    public partial class DokuDetails : IEquatable<DokuDetails>, IValidatableObject
    {
        /// <summary>
        /// **doku**
        /// </summary>
        /// <value>**doku**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Mandiriva for value: doku_mandiri_va
            /// </summary>
            [EnumMember(Value = "doku_mandiri_va")] Mandiriva = 1,

            /// <summary>
            /// Enum Cimbva for value: doku_cimb_va
            /// </summary>
            [EnumMember(Value = "doku_cimb_va")] Cimbva = 2,

            /// <summary>
            /// Enum Danamonva for value: doku_danamon_va
            /// </summary>
            [EnumMember(Value = "doku_danamon_va")] Danamonva = 3,

            /// <summary>
            /// Enum Bniva for value: doku_bni_va
            /// </summary>
            [EnumMember(Value = "doku_bni_va")] Bniva = 4,

            /// <summary>
            /// Enum Permataliteatm for value: doku_permata_lite_atm
            /// </summary>
            [EnumMember(Value = "doku_permata_lite_atm")] Permataliteatm = 5,

            /// <summary>
            /// Enum Briva for value: doku_bri_va
            /// </summary>
            [EnumMember(Value = "doku_bri_va")] Briva = 6,

            /// <summary>
            /// Enum Bcava for value: doku_bca_va
            /// </summary>
            [EnumMember(Value = "doku_bca_va")] Bcava = 7,

            /// <summary>
            /// Enum Alfamart for value: doku_alfamart
            /// </summary>
            [EnumMember(Value = "doku_alfamart")] Alfamart = 8,

            /// <summary>
            /// Enum Indomaret for value: doku_indomaret
            /// </summary>
            [EnumMember(Value = "doku_indomaret")] Indomaret = 9
        }

        /// <summary>
        /// **doku**
        /// </summary>
        /// <value>**doku**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DokuDetails" /> class.
        /// </summary>
        /// <param name="firstName">The shopper&#x27;s first name. (required).</param>
        /// <param name="infix">infix.</param>
        /// <param name="lastName">The shopper&#x27;s last name. (required).</param>
        /// <param name="ovoId">ovoId.</param>
        /// <param name="shopperEmail">The shopper&#x27;s email. (required).</param>
        /// <param name="type">**doku** (required).</param>
        public DokuDetails(string firstName = default(string), string infix = default(string),
            string lastName = default(string), string ovoId = default(string), string shopperEmail = default(string),
            TypeEnum type = default(TypeEnum))
        {
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new InvalidDataException("firstName is a required property for DokuDetails and cannot be null");
            }
            else
            {
                this.FirstName = firstName;
            }
            // to ensure "lastName" is required (not null)
            if (lastName == null)
            {
                throw new InvalidDataException("lastName is a required property for DokuDetails and cannot be null");
            }
            else
            {
                this.LastName = lastName;
            }
            // to ensure "shopperEmail" is required (not null)
            if (shopperEmail == null)
            {
                throw new InvalidDataException(
                    "shopperEmail is a required property for DokuDetails and cannot be null");
            }
            else
            {
                this.ShopperEmail = shopperEmail;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for DokuDetails and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.Infix = infix;
            this.OvoId = ovoId;
        }

        /// <summary>
        /// The shopper&#x27;s first name.
        /// </summary>
        /// <value>The shopper&#x27;s first name.</value>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets Infix
        /// </summary>
        [DataMember(Name = "infix", EmitDefaultValue = false)]
        public string Infix { get; set; }

        /// <summary>
        /// The shopper&#x27;s last name.
        /// </summary>
        /// <value>The shopper&#x27;s last name.</value>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets OvoId
        /// </summary>
        [DataMember(Name = "ovoId", EmitDefaultValue = false)]
        public string OvoId { get; set; }

        /// <summary>
        /// The shopper&#x27;s email.
        /// </summary>
        /// <value>The shopper&#x27;s email.</value>
        [DataMember(Name = "shopperEmail", EmitDefaultValue = false)]
        public string ShopperEmail { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DokuDetails {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  Infix: ").Append(Infix).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  OvoId: ").Append(OvoId).Append("\n");
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
            return this.Equals(input as DokuDetails);
        }

        /// <summary>
        /// Returns true if DokuDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of DokuDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DokuDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    this.FirstName == input.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName)
                ) &&
                (
                    this.Infix == input.Infix ||
                    this.Infix != null &&
                    this.Infix.Equals(input.Infix)
                ) &&
                (
                    this.LastName == input.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(input.LastName)
                ) &&
                (
                    this.OvoId == input.OvoId ||
                    this.OvoId != null &&
                    this.OvoId.Equals(input.OvoId)
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
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.Infix != null)
                    hashCode = hashCode * 59 + this.Infix.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.OvoId != null)
                    hashCode = hashCode * 59 + this.OvoId.GetHashCode();
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