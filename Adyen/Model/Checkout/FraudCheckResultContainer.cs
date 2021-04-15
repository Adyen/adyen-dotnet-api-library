#region License
/*
 *                       ######
 *                       ######
 * ############    ####( ######  #####. ######  ############   ############
 * #############  #####( ######  #####. ######  #############  #############
 *        ######  #####( ######  #####. ######  #####  ######  #####  ######
 * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
 * ###### ######  #####( ######  #####. ######  #####          #####  ######
 * #############  #############  #############  #############  #####  ######
 *  ############   ############  #############   ############  #####  ######
 *                                      ######
 *                               #############
 *                               ############
 *
 * Adyen Dotnet API Library
 *
 * Copyright (c) 2021 Adyen B.V.
 * This file is open source and available under the MIT license.
 * See the LICENSE file for more info.
 */
#endregion

using System.Runtime.Serialization;
using System.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// Result
    /// This class is not part of the Adyen open api specs. The reason that is manualy added is to create 
    /// the middle layer that is needed to deserialize the FraudCheckResult. The paymentResponse contains
    /// a list of FraudCheckResult but it has the root element which cause the deserialization to fail. With this class
    /// deserialization of FraudCheckResult works properly
    /// </summary>
    [DataContract]
    public class FraudCheckResultContainer : IEquatable<FraudCheckResultContainer>, IValidatableObject
    {
        [DataMember(Name = "fraudCheckResult", EmitDefaultValue = false)]

        public FraudCheckResult FraudCheckResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FraudResults {\n");
            sb.Append("  FraudCheckResult: ").Append(FraudCheckResult).Append("\n");
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
            return this.Equals(input as FraudCheckResultContainer);
        }

        /// <summary>
        /// Returns true if FraudCheckResultContainer instances are equal
        /// </summary>
        /// <param name="input">Instance of FraudCheckResultContainer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FraudCheckResultContainer input)
        {
            if (input == null)
                return false;

            return
                (
                    this.FraudCheckResult == input.FraudCheckResult ||
                    this.FraudCheckResult != null &&
                    input.FraudCheckResult != null &&
                    this.FraudCheckResult.Equals(input.FraudCheckResult)
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
                if (this.FraudCheckResult != null)
                    hashCode = hashCode * 59 + this.FraudCheckResult.GetHashCode();
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
