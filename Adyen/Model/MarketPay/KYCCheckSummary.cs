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

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// KYCCheckSummary
    /// </summary>
    [DataContract]
        public partial class KYCCheckSummary :  IEquatable<KYCCheckSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KYCCheckSummary" /> class.
        /// </summary>
        /// <param name="kycCheckCode">The code of the check..</param>
        /// <param name="kycCheckDescription">A description of the check..</param>
        public KYCCheckSummary(int? kycCheckCode = default(int?), string kycCheckDescription = default(string))
        {
            this.KycCheckCode = kycCheckCode;
            this.KycCheckDescription = kycCheckDescription;
        }
        
        /// <summary>
        /// The code of the check.
        /// </summary>
        /// <value>The code of the check.</value>
        [DataMember(Name="kycCheckCode", EmitDefaultValue=false)]
        public int? KycCheckCode { get; set; }

        /// <summary>
        /// A description of the check.
        /// </summary>
        /// <value>A description of the check.</value>
        [DataMember(Name="kycCheckDescription", EmitDefaultValue=false)]
        public string KycCheckDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KYCCheckSummary {\n");
            sb.Append("  KycCheckCode: ").Append(KycCheckCode).Append("\n");
            sb.Append("  KycCheckDescription: ").Append(KycCheckDescription).Append("\n");
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
            return this.Equals(input as KYCCheckSummary);
        }

        /// <summary>
        /// Returns true if KYCCheckSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of KYCCheckSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KYCCheckSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KycCheckCode == input.KycCheckCode ||
                    (this.KycCheckCode != null &&
                    this.KycCheckCode.Equals(input.KycCheckCode))
                ) && 
                (
                    this.KycCheckDescription == input.KycCheckDescription ||
                    (this.KycCheckDescription != null &&
                    this.KycCheckDescription.Equals(input.KycCheckDescription))
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
                if (this.KycCheckCode != null)
                    hashCode = hashCode * 59 + this.KycCheckCode.GetHashCode();
                if (this.KycCheckDescription != null)
                    hashCode = hashCode * 59 + this.KycCheckDescription.GetHashCode();
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
