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
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// KYCUltimateParentCompanyCheckResult
    /// </summary>
    [DataContract]
        public partial class KYCUltimateParentCompanyCheckResult :  IEquatable<KYCUltimateParentCompanyCheckResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KYCUltimateParentCompanyCheckResult" /> class.
        /// </summary>
        /// <param name="checks">A list of the checks and their statuses..</param>
        /// <param name="ultimateParentCompanyCode">The code of the Ultimate Parent Company to which the check applies..</param>
        public KYCUltimateParentCompanyCheckResult(List<KYCCheckStatusData> checks = default(List<KYCCheckStatusData>), string ultimateParentCompanyCode = default(string))
        {
            this.Checks = checks;
            this.UltimateParentCompanyCode = ultimateParentCompanyCode;
        }
        
        /// <summary>
        /// A list of the checks and their statuses.
        /// </summary>
        /// <value>A list of the checks and their statuses.</value>
        [DataMember(Name="checks", EmitDefaultValue=false)]
        public List<KYCCheckStatusData> Checks { get; set; }

        /// <summary>
        /// The code of the Ultimate Parent Company to which the check applies.
        /// </summary>
        /// <value>The code of the Ultimate Parent Company to which the check applies.</value>
        [DataMember(Name="ultimateParentCompanyCode", EmitDefaultValue=false)]
        public string UltimateParentCompanyCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KYCUltimateParentCompanyCheckResult {\n");
            sb.Append("  Checks: ").Append(Checks).Append("\n");
            sb.Append("  UltimateParentCompanyCode: ").Append(UltimateParentCompanyCode).Append("\n");
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
            return this.Equals(input as KYCUltimateParentCompanyCheckResult);
        }

        /// <summary>
        /// Returns true if KYCUltimateParentCompanyCheckResult instances are equal
        /// </summary>
        /// <param name="input">Instance of KYCUltimateParentCompanyCheckResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KYCUltimateParentCompanyCheckResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Checks == input.Checks ||
                    this.Checks != null &&
                    input.Checks != null &&
                    this.Checks.SequenceEqual(input.Checks)
                ) && 
                (
                    this.UltimateParentCompanyCode == input.UltimateParentCompanyCode ||
                    (this.UltimateParentCompanyCode != null &&
                    this.UltimateParentCompanyCode.Equals(input.UltimateParentCompanyCode))
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
                if (this.Checks != null)
                    hashCode = hashCode * 59 + this.Checks.GetHashCode();
                if (this.UltimateParentCompanyCode != null)
                    hashCode = hashCode * 59 + this.UltimateParentCompanyCode.GetHashCode();
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