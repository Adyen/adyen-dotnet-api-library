/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 69
* Contact: developer-experience@adyen.com
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

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// Avs
    /// </summary>
    [DataContract(Name = "Avs")]
    public partial class Avs : IEquatable<Avs>, IValidatableObject
    {
        /// <summary>
        /// Specifies whether the shopper should enter their billing address during checkout.  Allowed values: * yes — Perform AVS checks for every card payment. * automatic — Perform AVS checks only when required to optimize the conversion rate. * no — Do not perform AVS checks.
        /// </summary>
        /// <value>Specifies whether the shopper should enter their billing address during checkout.  Allowed values: * yes — Perform AVS checks for every card payment. * automatic — Perform AVS checks only when required to optimize the conversion rate. * no — Do not perform AVS checks.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EnabledEnum
        {
            /// <summary>
            /// Enum Yes for value: yes
            /// </summary>
            [EnumMember(Value = "yes")]
            Yes = 1,

            /// <summary>
            /// Enum No for value: no
            /// </summary>
            [EnumMember(Value = "no")]
            No = 2,

            /// <summary>
            /// Enum Automatic for value: automatic
            /// </summary>
            [EnumMember(Value = "automatic")]
            Automatic = 3

        }


        /// <summary>
        /// Specifies whether the shopper should enter their billing address during checkout.  Allowed values: * yes — Perform AVS checks for every card payment. * automatic — Perform AVS checks only when required to optimize the conversion rate. * no — Do not perform AVS checks.
        /// </summary>
        /// <value>Specifies whether the shopper should enter their billing address during checkout.  Allowed values: * yes — Perform AVS checks for every card payment. * automatic — Perform AVS checks only when required to optimize the conversion rate. * no — Do not perform AVS checks.</value>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        public EnabledEnum? Enabled { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Avs" /> class.
        /// </summary>
        /// <param name="addressEditable">Indicates whether the shopper is allowed to modify the billing address for the current payment request..</param>
        /// <param name="enabled">Specifies whether the shopper should enter their billing address during checkout.  Allowed values: * yes — Perform AVS checks for every card payment. * automatic — Perform AVS checks only when required to optimize the conversion rate. * no — Do not perform AVS checks..</param>
        public Avs(bool addressEditable = default(bool), EnabledEnum? enabled = default(EnabledEnum?))
        {
            this.AddressEditable = addressEditable;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Indicates whether the shopper is allowed to modify the billing address for the current payment request.
        /// </summary>
        /// <value>Indicates whether the shopper is allowed to modify the billing address for the current payment request.</value>
        [DataMember(Name = "addressEditable", EmitDefaultValue = false)]
        public bool AddressEditable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Avs {\n");
            sb.Append("  AddressEditable: ").Append(AddressEditable).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(input as Avs);
        }

        /// <summary>
        /// Returns true if Avs instances are equal
        /// </summary>
        /// <param name="input">Instance of Avs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Avs input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AddressEditable == input.AddressEditable ||
                    this.AddressEditable.Equals(input.AddressEditable)
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
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
                hashCode = (hashCode * 59) + this.AddressEditable.GetHashCode();
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
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
