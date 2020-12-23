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
    /// EcontextVoucherDetails
    /// </summary>
    [DataContract]
    public partial class EcontextVoucherDetails : IEquatable<EcontextVoucherDetails>, IValidatableObject
    {
        /// <summary>
        /// **econtextvoucher**
        /// </summary>
        /// <value>**econtextvoucher**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Seveneleven for value: econtext_seveneleven
            /// </summary>
            [EnumMember(Value = "econtext_seveneleven")] Seveneleven = 1,

            /// <summary>
            /// Enum Stores for value: econtext_stores
            /// </summary>
            [EnumMember(Value = "econtext_stores")] Stores = 2
        }

        /// <summary>
        /// **econtextvoucher**
        /// </summary>
        /// <value>**econtextvoucher**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EcontextVoucherDetails" /> class.
        /// </summary>
        /// <param name="firstName">The shopper&#x27;s first name. (required).</param>
        /// <param name="lastName">The shopper&#x27;s last name. (required).</param>
        /// <param name="shopperEmail">The shopper&#x27;s email. (required).</param>
        /// <param name="telephoneNumber">The shopper&#x27;s contact number. (required).</param>
        /// <param name="type">**econtextvoucher** (required).</param>
        public EcontextVoucherDetails(string firstName = default(string), string lastName = default(string),
            string shopperEmail = default(string), string telephoneNumber = default(string),
            TypeEnum type = default(TypeEnum))
        {
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new InvalidDataException(
                    "firstName is a required property for EcontextVoucherDetails and cannot be null");
            }
            else
            {
                this.FirstName = firstName;
            }
            // to ensure "lastName" is required (not null)
            if (lastName == null)
            {
                throw new InvalidDataException(
                    "lastName is a required property for EcontextVoucherDetails and cannot be null");
            }
            else
            {
                this.LastName = lastName;
            }
            // to ensure "shopperEmail" is required (not null)
            if (shopperEmail == null)
            {
                throw new InvalidDataException(
                    "shopperEmail is a required property for EcontextVoucherDetails and cannot be null");
            }
            else
            {
                this.ShopperEmail = shopperEmail;
            }
            // to ensure "telephoneNumber" is required (not null)
            if (telephoneNumber == null)
            {
                throw new InvalidDataException(
                    "telephoneNumber is a required property for EcontextVoucherDetails and cannot be null");
            }
            else
            {
                this.TelephoneNumber = telephoneNumber;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException(
                    "type is a required property for EcontextVoucherDetails and cannot be null");
            }
            else
            {
                this.Type = type;
            }
        }

        /// <summary>
        /// The shopper&#x27;s first name.
        /// </summary>
        /// <value>The shopper&#x27;s first name.</value>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The shopper&#x27;s last name.
        /// </summary>
        /// <value>The shopper&#x27;s last name.</value>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// The shopper&#x27;s email.
        /// </summary>
        /// <value>The shopper&#x27;s email.</value>
        [DataMember(Name = "shopperEmail", EmitDefaultValue = false)]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// The shopper&#x27;s contact number.
        /// </summary>
        /// <value>The shopper&#x27;s contact number.</value>
        [DataMember(Name = "telephoneNumber", EmitDefaultValue = false)]
        public string TelephoneNumber { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EcontextVoucherDetails {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  ShopperEmail: ").Append(ShopperEmail).Append("\n");
            sb.Append("  TelephoneNumber: ").Append(TelephoneNumber).Append("\n");
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
            return this.Equals(input as EcontextVoucherDetails);
        }

        /// <summary>
        /// Returns true if EcontextVoucherDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of EcontextVoucherDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EcontextVoucherDetails input)
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
                    this.LastName == input.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(input.LastName)
                ) &&
                (
                    this.ShopperEmail == input.ShopperEmail ||
                    this.ShopperEmail != null &&
                    this.ShopperEmail.Equals(input.ShopperEmail)
                ) &&
                (
                    this.TelephoneNumber == input.TelephoneNumber ||
                    this.TelephoneNumber != null &&
                    this.TelephoneNumber.Equals(input.TelephoneNumber)
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
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.ShopperEmail != null)
                    hashCode = hashCode * 59 + this.ShopperEmail.GetHashCode();
                if (this.TelephoneNumber != null)
                    hashCode = hashCode * 59 + this.TelephoneNumber.GetHashCode();
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