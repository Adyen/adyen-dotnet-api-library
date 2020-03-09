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

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// AccountProcessingState
    /// </summary>
    [DataContract]
        public partial class AccountProcessingState :  IEquatable<AccountProcessingState>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountProcessingState" /> class.
        /// </summary>
        /// <param name="disableReason">The reason why processing has been disabled. (required).</param>
        /// <param name="disabled">Indicates whether the processing of payments is allowed. (required).</param>
        /// <param name="processedFrom">processedFrom (required).</param>
        /// <param name="processedTo">processedTo (required).</param>
        /// <param name="tierNumber">The processing tier that the account holder occupies. (required).</param>
        public AccountProcessingState(string disableReason = default(string), bool? disabled = default(bool?), Amount processedFrom = default(Amount), Amount processedTo = default(Amount), int? tierNumber = default(int?))
        {
            this.TierNumber = tierNumber;
            this.ProcessedTo = processedTo;
            this.DisableReason = disableReason;
            this.Disabled = disabled;
            this.ProcessedFrom = processedFrom;
        }

        /// <summary>
        /// The reason why processing has been disabled.
        /// </summary>
        /// <value>The reason why processing has been disabled.</value>
        [DataMember(Name="disableReason", EmitDefaultValue=false)]
        public string DisableReason { get; set; }

        /// <summary>
        /// Indicates whether the processing of payments is allowed.
        /// </summary>
        /// <value>Indicates whether the processing of payments is allowed.</value>
        [DataMember(Name="disabled", EmitDefaultValue=false)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Gets or Sets ProcessedFrom
        /// </summary>
        [DataMember(Name="processedFrom", EmitDefaultValue=false)]
        public Amount ProcessedFrom { get; set; }

        /// <summary>
        /// Gets or Sets ProcessedTo
        /// </summary>
        [DataMember(Name="processedTo", EmitDefaultValue=false)]
        public Amount ProcessedTo { get; set; }

        /// <summary>
        /// The processing tier that the account holder occupies.
        /// </summary>
        /// <value>The processing tier that the account holder occupies.</value>
        [DataMember(Name="tierNumber", EmitDefaultValue=false)]
        public int? TierNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountProcessingState {\n");
            sb.Append("  DisableReason: ").Append(DisableReason).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  ProcessedFrom: ").Append(ProcessedFrom).Append("\n");
            sb.Append("  ProcessedTo: ").Append(ProcessedTo).Append("\n");
            sb.Append("  TierNumber: ").Append(TierNumber).Append("\n");
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
            return this.Equals(input as AccountProcessingState);
        }

        /// <summary>
        /// Returns true if AccountProcessingState instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountProcessingState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountProcessingState input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisableReason == input.DisableReason ||
                    (this.DisableReason != null &&
                    this.DisableReason.Equals(input.DisableReason))
                ) && 
                (
                    this.Disabled == input.Disabled ||
                    (this.Disabled != null &&
                    this.Disabled.Equals(input.Disabled))
                ) && 
                (
                    this.ProcessedFrom == input.ProcessedFrom ||
                    (this.ProcessedFrom != null &&
                    ((Object) this.ProcessedFrom).Equals(input.ProcessedFrom))
                ) && 
                (
                    this.ProcessedTo == input.ProcessedTo ||
                    (this.ProcessedTo != null &&
                    ((Object) this.ProcessedTo).Equals(input.ProcessedTo))
                ) && 
                (
                    this.TierNumber == input.TierNumber ||
                    (this.TierNumber != null &&
                    this.TierNumber.Equals(input.TierNumber))
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
                if (this.DisableReason != null)
                    hashCode = hashCode * 59 + this.DisableReason.GetHashCode();
                if (this.Disabled != null)
                    hashCode = hashCode * 59 + this.Disabled.GetHashCode();
                if (this.ProcessedFrom != null)
                    hashCode = hashCode * 59 + this.ProcessedFrom.GetHashCode();
                if (this.ProcessedTo != null)
                    hashCode = hashCode * 59 + this.ProcessedTo.GetHashCode();
                if (this.TierNumber != null)
                    hashCode = hashCode * 59 + this.TierNumber.GetHashCode();
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
