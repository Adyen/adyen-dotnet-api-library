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
    /// Installments
    /// </summary>
    [DataContract]
    public partial class Installments : IEquatable<Installments>, IValidatableObject
    {
        /// <summary>
        /// Defines the type of installment plan. If not set, defaults to **regular**.  Possible values: * **regular** * **revolving**
        /// </summary>
        /// <value>Defines the type of installment plan. If not set, defaults to **regular**.  Possible values: * **regular** * **revolving**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PlanEnum
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
        [DataMember(Name = "plan", EmitDefaultValue = false)]
        public PlanEnum? Plan { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Installments" /> class.
        /// </summary>
        /// <param name="plan">Defines the type of installment plan. If not set, defaults to **regular**.  Possible values: * **regular** * **revolving**.</param>
        /// <param name="value">Defines the number of installments. Its value needs to be greater than zero.  Usually, the maximum allowed number of installments is capped. For example, it may not be possible to split a payment in more than 24 installments. The acquirer sets this upper limit, so its value may vary. (required).</param>
        public Installments(PlanEnum? plan = default(PlanEnum?), int? value = default(int?))
        {
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new InvalidDataException("value is a required property for Installments and cannot be null");
            }
            else
            {
                this.Value = value;
            }
            this.Plan = plan;
        }


        /// <summary>
        /// Defines the number of installments. Its value needs to be greater than zero.  Usually, the maximum allowed number of installments is capped. For example, it may not be possible to split a payment in more than 24 installments. The acquirer sets this upper limit, so its value may vary.
        /// </summary>
        /// <value>Defines the number of installments. Its value needs to be greater than zero.  Usually, the maximum allowed number of installments is capped. For example, it may not be possible to split a payment in more than 24 installments. The acquirer sets this upper limit, so its value may vary.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public int? Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Installments {\n");
            sb.Append("  Plan: ").Append(Plan).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as Installments);
        }

        /// <summary>
        /// Returns true if Installments instances are equal
        /// </summary>
        /// <param name="input">Instance of Installments to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Installments input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Plan == input.Plan ||
                    this.Plan != null &&
                    this.Plan.Equals(input.Plan)
                ) &&
                (
                    this.Value == input.Value ||
                    this.Value != null &&
                    this.Value.Equals(input.Value)
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
                if (this.Plan != null)
                    hashCode = hashCode * 59 + this.Plan.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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