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
    /// Avs
    /// </summary>
    [DataContract]
    public partial class Avs :  IEquatable<Avs>, IValidatableObject
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
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public EnabledEnum? Enabled { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Avs" /> class.
        /// </summary>
        /// <param name="AddressEditable">Indicates whether the shopper is allowed to modify the billing address for the current payment request..</param>
        /// <param name="Enabled">Specifies whether the shopper should enter their billing address during checkout.  Allowed values: * yes — Perform AVS checks for every card payment. * automatic — Perform AVS checks only when required to optimize the conversion rate. * no — Do not perform AVS checks..</param>
        public Avs(bool? AddressEditable = default(bool?), EnabledEnum? Enabled = default(EnabledEnum?))
        {
            this.AddressEditable = AddressEditable;
            this.Enabled = Enabled;
        }
        
        /// <summary>
        /// Indicates whether the shopper is allowed to modify the billing address for the current payment request.
        /// </summary>
        /// <value>Indicates whether the shopper is allowed to modify the billing address for the current payment request.</value>
        [DataMember(Name="addressEditable", EmitDefaultValue=false)]
        public bool? AddressEditable { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
                return false;

            return 
                (
                    this.AddressEditable == input.AddressEditable ||
                    (this.AddressEditable != null &&
                    this.AddressEditable.Equals(input.AddressEditable))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
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
                if (this.AddressEditable != null)
                    hashCode = hashCode * 59 + this.AddressEditable.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
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
