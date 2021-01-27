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
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// InstallmentOption
    /// </summary>
    [DataContract]
    public partial class InstallmentOption : IEquatable<InstallmentOption>, IValidatableObject
    {
        /// <summary>
        /// Defines Plans
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PlansEnum
        {
            /// <summary>
            /// Enum Regular for value: regular
            /// </summary>
            [EnumMember(Value = "regular")] Regular = 1,

            /// <summary>
            /// Enum Revolving for value: revolving
            /// </summary>
            [EnumMember(Value = "revolving")] Revolving = 2
        }

        /// <summary>
        /// Defines the type of installment plan. If not set, defaults to **regular**.  Possible values: * **regular** * **revolving**
        /// </summary>
        /// <value>Defines the type of installment plan. If not set, defaults to **regular**.  Possible values: * **regular** * **revolving**</value>
        [DataMember(Name = "plans", EmitDefaultValue = false)]
        public List<PlansEnum> Plans { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstallmentOption" /> class.
        /// </summary>
        /// <param name="maxValue">The maximum number of installments offered for this payment method..</param>
        /// <param name="plans">Defines the type of installment plan. If not set, defaults to **regular**.  Possible values: * **regular** * **revolving**.</param>
        public InstallmentOption(int? maxValue = default(int?), List<PlansEnum> plans = default(List<PlansEnum>))
        {
            this.MaxValue = maxValue;
            this.Plans = plans;
        }

        /// <summary>
        /// The maximum number of installments offered for this payment method.
        /// </summary>
        /// <value>The maximum number of installments offered for this payment method.</value>
        [DataMember(Name = "maxValue", EmitDefaultValue = false)]
        public int? MaxValue { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstallmentOption {\n");
            sb.Append("  MaxValue: ").Append(MaxValue).Append("\n");
            sb.Append("  Plans: ").Append(Plans.ObjectListToString()).Append("\n");
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
            return this.Equals(input as InstallmentOption);
        }

        /// <summary>
        /// Returns true if InstallmentOption instances are equal
        /// </summary>
        /// <param name="input">Instance of InstallmentOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstallmentOption input)
        {
            if (input == null)
                return false;

            return
                (
                    this.MaxValue == input.MaxValue ||
                    this.MaxValue != null &&
                    this.MaxValue.Equals(input.MaxValue)
                ) &&
                (
                    this.Plans == input.Plans ||
                    this.Plans != null &&
                    input.Plans != null &&
                    this.Plans.SequenceEqual(input.Plans)
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
                if (this.MaxValue != null)
                    hashCode = hashCode * 59 + this.MaxValue.GetHashCode();
                if (this.Plans != null)
                    hashCode = hashCode * 59 + this.Plans.GetHashCode();
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