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
//  Copyright (c) 2021 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

#endregion

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// PaymentMethodIssuer
    /// </summary>
    [DataContract]
    public partial class PaymentMethodIssuer : IEquatable<PaymentMethodIssuer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodIssuer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentMethodIssuer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodIssuer" /> class.
        /// </summary>
        /// <param name="disabled">A boolean value indicating whether this issuer is unavailable. Can be &#x60;true&#x60; whenever the issuer is offline. (default to false).</param>
        /// <param name="id">The unique identifier of this issuer, to submit in requests to /payments. (required).</param>
        /// <param name="name">A localized name of the issuer. (required).</param>
        public PaymentMethodIssuer(bool disabled = false, string id = default(string), string name = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for PaymentMethodIssuer and cannot be null");
            }
            else
            {
                this.id = id;
            }

            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for PaymentMethodIssuer and cannot be null");
            }
            else
            {
                this.name = name;
            }

            // use default value if no "disabled" provided
            if (disabled == null)
            {
                this.disabled = false;
            }
            else
            {
                this.disabled = disabled;
            }
        }

        /// <summary>
        /// A boolean value indicating whether this issuer is unavailable. Can be &#x60;true&#x60; whenever the issuer is offline.
        /// </summary>
        /// <value>A boolean value indicating whether this issuer is unavailable. Can be &#x60;true&#x60; whenever the issuer is offline.</value>
        [DataMember(Name = "disabled", EmitDefaultValue = false)]
        public bool disabled { get; set; }

        /// <summary>
        /// The unique identifier of this issuer, to submit in requests to /payments.
        /// </summary>
        /// <value>The unique identifier of this issuer, to submit in requests to /payments.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string id { get; set; }

        /// <summary>
        /// A localized name of the issuer.
        /// </summary>
        /// <value>A localized name of the issuer.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentMethodIssuer {\n");
            sb.Append("  disabled: ").Append(disabled).Append("\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  name: ").Append(name).Append("\n");
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
            return this.Equals(input as PaymentMethodIssuer);
        }

        /// <summary>
        /// Returns true if PaymentMethodIssuer instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodIssuer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodIssuer input)
        {
            if (input == null)
                return false;

            return
                (
                    this.disabled == input.disabled ||
                    (this.disabled != null &&
                    this.disabled.Equals(input.disabled))
                ) &&
                (
                    this.id == input.id ||
                    (this.id != null &&
                    this.id.Equals(input.id))
                ) &&
                (
                    this.name == input.name ||
                    (this.name != null &&
                    this.name.Equals(input.name))
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
                if (this.disabled != null)
                    hashCode = hashCode * 59 + this.disabled.GetHashCode();
                if (this.id != null)
                    hashCode = hashCode * 59 + this.id.GetHashCode();
                if (this.name != null)
                    hashCode = hashCode * 59 + this.name.GetHashCode();
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
