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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// FraudCheckResult
    /// </summary>
    [DataContract]
    public partial class FraudCheckResult : IEquatable<FraudCheckResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FraudCheckResult" /> class.
        /// </summary>
        /// <param name="AccountScore">The fraud score generated by the risk check. (required).</param>
        /// <param name="CheckId">The ID of the risk check. (required).</param>
        /// <param name="Name">The name of the risk check. (required).</param>
        public FraudCheckResult(int? AccountScore = default(int?), int? CheckId = default(int?), string Name = default(string))
        {
            // to ensure "AccountScore" is required (not null)
            if (AccountScore == null)
            {
                throw new InvalidDataException("AccountScore is a required property for FraudCheckResult and cannot be null");
            }
            else
            {
                this.AccountScore = AccountScore;
            }
            // to ensure "CheckId" is required (not null)
            if (CheckId == null)
            {
                throw new InvalidDataException("CheckId is a required property for FraudCheckResult and cannot be null");
            }
            else
            {
                this.CheckId = CheckId;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for FraudCheckResult and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
        }

        /// <summary>
        /// The fraud score generated by the risk check.
        /// </summary>
        /// <value>The fraud score generated by the risk check.</value>
        [DataMember(Name = "accountScore", EmitDefaultValue = false)]
        public int? AccountScore { get; set; }

        /// <summary>
        /// The ID of the risk check.
        /// </summary>
        /// <value>The ID of the risk check.</value>
        [DataMember(Name = "checkId", EmitDefaultValue = false)]
        public int? CheckId { get; set; }

        /// <summary>
        /// The name of the risk check.
        /// </summary>
        /// <value>The name of the risk check.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FraudCheckResult {\n");
            sb.Append("  AccountScore: ").Append(AccountScore).Append("\n");
            sb.Append("  CheckId: ").Append(CheckId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as FraudCheckResult);
        }

        /// <summary>
        /// Returns true if FraudCheckResult instances are equal
        /// </summary>
        /// <param name="input">Instance of FraudCheckResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FraudCheckResult input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AccountScore == input.AccountScore ||
                    (this.AccountScore != null &&
                    this.AccountScore.Equals(input.AccountScore))
                ) &&
                (
                    this.CheckId == input.CheckId ||
                    (this.CheckId != null &&
                    this.CheckId.Equals(input.CheckId))
                ) &&
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.AccountScore != null)
                    hashCode = hashCode * 59 + this.AccountScore.GetHashCode();
                if (this.CheckId != null)
                    hashCode = hashCode * 59 + this.CheckId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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