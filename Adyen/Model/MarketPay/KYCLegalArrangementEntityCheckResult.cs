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
using Adyen.Util;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// KYCLegalArrangementEntityCheckResult
    /// </summary>
    [DataContract]
        public partial class KYCLegalArrangementEntityCheckResult :  IEquatable<KYCLegalArrangementEntityCheckResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KYCLegalArrangementEntityCheckResult" /> class.
        /// </summary>
        /// <param name="checks">A list of the checks and their statuses..</param>
        /// <param name="legalArrangementCode">The unique ID of the legal arrangement to which the entity belongs..</param>
        /// <param name="legalArrangementEntityCode">The unique ID of the legal arrangement entity to which the check applies..</param>
        public KYCLegalArrangementEntityCheckResult(List<KYCCheckStatusData> checks = default(List<KYCCheckStatusData>), string legalArrangementCode = default(string), string legalArrangementEntityCode = default(string))
        {
            this.Checks = checks;
            this.LegalArrangementCode = legalArrangementCode;
            this.LegalArrangementEntityCode = legalArrangementEntityCode;
        }
        
        /// <summary>
        /// A list of the checks and their statuses.
        /// </summary>
        /// <value>A list of the checks and their statuses.</value>
        [DataMember(Name="checks", EmitDefaultValue=false)]
        public List<KYCCheckStatusData> Checks { get; set; }

        /// <summary>
        /// The unique ID of the legal arrangement to which the entity belongs.
        /// </summary>
        /// <value>The unique ID of the legal arrangement to which the entity belongs.</value>
        [DataMember(Name="legalArrangementCode", EmitDefaultValue=false)]
        public string LegalArrangementCode { get; set; }

        /// <summary>
        /// The unique ID of the legal arrangement entity to which the check applies.
        /// </summary>
        /// <value>The unique ID of the legal arrangement entity to which the check applies.</value>
        [DataMember(Name="legalArrangementEntityCode", EmitDefaultValue=false)]
        public string LegalArrangementEntityCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KYCLegalArrangementEntityCheckResult {\n");
            sb.Append("  Checks: ").Append(Checks.ObjectListToString()).Append("\n");
            sb.Append("  LegalArrangementCode: ").Append(LegalArrangementCode).Append("\n");
            sb.Append("  LegalArrangementEntityCode: ").Append(LegalArrangementEntityCode).Append("\n");
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
            return this.Equals(input as KYCLegalArrangementEntityCheckResult);
        }

        /// <summary>
        /// Returns true if KYCLegalArrangementEntityCheckResult instances are equal
        /// </summary>
        /// <param name="input">Instance of KYCLegalArrangementEntityCheckResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KYCLegalArrangementEntityCheckResult input)
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
                    this.LegalArrangementCode == input.LegalArrangementCode ||
                    (this.LegalArrangementCode != null &&
                    this.LegalArrangementCode.Equals(input.LegalArrangementCode))
                ) && 
                (
                    this.LegalArrangementEntityCode == input.LegalArrangementEntityCode ||
                    (this.LegalArrangementEntityCode != null &&
                    this.LegalArrangementEntityCode.Equals(input.LegalArrangementEntityCode))
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
                if (this.LegalArrangementCode != null)
                    hashCode = hashCode * 59 + this.LegalArrangementCode.GetHashCode();
                if (this.LegalArrangementEntityCode != null)
                    hashCode = hashCode * 59 + this.LegalArrangementEntityCode.GetHashCode();
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