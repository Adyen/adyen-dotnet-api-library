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
//  * Copyright (c) 2019 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// Installments
    /// </summary>
    [DataContract]
    public partial class Installments :  IEquatable<Installments>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Installments" /> class.
        /// </summary>
        [JsonConstructor]
        protected Installments() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Installments" /> class.
        /// </summary>
        /// <param name="Value">Defines the number of installments. Its value needs to be greater than zero.  Usually, the maximum allowed number of installments is capped. For example, it may not be possible to split a payment in more than 24 installments. The acquirer sets this upper limit, so its value may vary. (required).</param>
        public Installments(int? Value = default(int?))
        {
            // to ensure "Value" is required (not null)
            if (Value == null)
            {
                throw new InvalidDataException("Value is a required property for Installments and cannot be null");
            }
            else
            {
                this.Value = Value;
            }
        }
        
        /// <summary>
        /// Defines the number of installments. Its value needs to be greater than zero.  Usually, the maximum allowed number of installments is capped. For example, it may not be possible to split a payment in more than 24 installments. The acquirer sets this upper limit, so its value may vary.
        /// </summary>
        /// <value>Defines the number of installments. Its value needs to be greater than zero.  Usually, the maximum allowed number of installments is capped. For example, it may not be possible to split a payment in more than 24 installments. The acquirer sets this upper limit, so its value may vary.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public int? Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Installments {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
