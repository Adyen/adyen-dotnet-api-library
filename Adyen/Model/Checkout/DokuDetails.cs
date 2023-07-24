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
    /// DokuDetails
    /// </summary>
    [DataContract(Name = "DokuDetails")]
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
            /// Enum MandiriVa for value: doku_mandiri_va
            /// </summary>
            [EnumMember(Value = "doku_mandiri_va")]
            MandiriVa = 1,

            /// <summary>
            /// Enum CimbVa for value: doku_cimb_va
            /// </summary>
            [EnumMember(Value = "doku_cimb_va")]
            CimbVa = 2,

            /// <summary>
            /// Enum DanamonVa for value: doku_danamon_va
            /// </summary>
            [EnumMember(Value = "doku_danamon_va")]
            DanamonVa = 3,

            /// <summary>
            /// Enum BniVa for value: doku_bni_va
            /// </summary>
            [EnumMember(Value = "doku_bni_va")]
            BniVa = 4,

            /// <summary>
            /// Enum PermataLiteAtm for value: doku_permata_lite_atm
            /// </summary>
            [EnumMember(Value = "doku_permata_lite_atm")]
            PermataLiteAtm = 5,

            /// <summary>
            /// Enum BriVa for value: doku_bri_va
            /// </summary>
            [EnumMember(Value = "doku_bri_va")]
            BriVa = 6,

            /// <summary>
            /// Enum BcaVa for value: doku_bca_va
            /// </summary>
            [EnumMember(Value = "doku_bca_va")]
            BcaVa = 7,

            /// <summary>
            /// Enum Alfamart for value: doku_alfamart
            /// </summary>
            [EnumMember(Value = "doku_alfamart")]
            Alfamart = 8,

            /// <summary>
            /// Enum Indomaret for value: doku_indomaret
            /// </summary>
            [EnumMember(Value = "doku_indomaret")]
            Indomaret = 9

        }


        /// <summary>
        /// **doku**
        /// </summary>
        /// <value>**doku**</value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DokuDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DokuDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DokuDetails" /> class.
        /// </summary>
        /// <param name="checkoutAttemptId">The checkout attempt identifier..</param>
        /// <param name="firstName">The shopper&#39;s first name. (required).</param>
        /// <param name="lastName">The shopper&#39;s last name. (required).</param>
        /// <param name="shopperEmail">The shopper&#39;s email. (required).</param>
        /// <param name="type">**doku** (required).</param>
        public DokuDetails(string checkoutAttemptId = default(string), string firstName = default(string), string lastName = default(string), string shopperEmail = default(string), TypeEnum type = default(TypeEnum))
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ShopperEmail = shopperEmail;
            this.Type = type;
            this.CheckoutAttemptId = checkoutAttemptId;
        }

        /// <summary>
        /// The checkout attempt identifier.
        /// </summary>
        /// <value>The checkout attempt identifier.</value>
        [DataMember(Name = "checkoutAttemptId", EmitDefaultValue = false)]
        public string CheckoutAttemptId { get; set; }

        /// <summary>
        /// The shopper&#39;s first name.
        /// </summary>
        /// <value>The shopper&#39;s first name.</value>
        [DataMember(Name = "firstName", IsRequired = false, EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The shopper&#39;s last name.
        /// </summary>
        /// <value>The shopper&#39;s last name.</value>
        [DataMember(Name = "lastName", IsRequired = false, EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// The shopper&#39;s email.
        /// </summary>
        /// <value>The shopper&#39;s email.</value>
        [DataMember(Name = "shopperEmail", IsRequired = false, EmitDefaultValue = false)]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DokuDetails {\n");
            sb.Append("  CheckoutAttemptId: ").Append(CheckoutAttemptId).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
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
            {
                return false;
            }
            return 
                (
                    this.CheckoutAttemptId == input.CheckoutAttemptId ||
                    (this.CheckoutAttemptId != null &&
                    this.CheckoutAttemptId.Equals(input.CheckoutAttemptId))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.ShopperEmail == input.ShopperEmail ||
                    (this.ShopperEmail != null &&
                    this.ShopperEmail.Equals(input.ShopperEmail))
                ) && 
                (
                    this.Type == input.Type ||
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
                if (this.CheckoutAttemptId != null)
                {
                    hashCode = (hashCode * 59) + this.CheckoutAttemptId.GetHashCode();
                }
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.ShopperEmail != null)
                {
                    hashCode = (hashCode * 59) + this.ShopperEmail.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
            yield break;
        }
    }

}
