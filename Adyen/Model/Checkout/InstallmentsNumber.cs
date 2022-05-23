// #region License
// 
//                         ######
//                         ######
//   ############    ####( ######  #####. ######  ############   ############
//   #############  #####( ######  #####. ######  #############  #############
//          ######  #####( ######  #####. ######  #####  ######  #####  ######
//   ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//   ###### ######  #####( ######  #####. ######  #####          #####  ######
//   #############  #############  #############  #############  #####  ######
//    ############   ############  #############   ############  #####  ######
//                                        ######
//                                 #############
//                                 ############
// 
//   Adyen Dotnet API Library
// 
//   Copyright (c) 2021 Adyen B.V.
//   This file is open source and available under the MIT license.
//   See the LICENSE file for more info.
// 
// #endregion

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
    /// InstallmentsNumber
    /// </summary>
    [DataContract]
        public partial class InstallmentsNumber :  IEquatable<InstallmentsNumber>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstallmentsNumber" /> class.
        /// </summary>
        /// <param name="maxNumberOfInstallments">Maximum number of installments (required).</param>
        public InstallmentsNumber(int? maxNumberOfInstallments = default(int?))
        {
            // to ensure "maxNumberOfInstallments" is required (not null)
            if (maxNumberOfInstallments == null)
            {
                throw new InvalidDataException("maxNumberOfInstallments is a required property for InstallmentsNumber and cannot be null");
            }
            else
            {
                this.MaxNumberOfInstallments = maxNumberOfInstallments;
            }
        }
        
        /// <summary>
        /// Maximum number of installments
        /// </summary>
        /// <value>Maximum number of installments</value>
        [DataMember(Name="maxNumberOfInstallments", EmitDefaultValue=false)]
        public int? MaxNumberOfInstallments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstallmentsNumber {\n");
            sb.Append("  MaxNumberOfInstallments: ").Append(MaxNumberOfInstallments).Append("\n");
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
            return this.Equals(input as InstallmentsNumber);
        }

        /// <summary>
        /// Returns true if InstallmentsNumber instances are equal
        /// </summary>
        /// <param name="input">Instance of InstallmentsNumber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstallmentsNumber input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxNumberOfInstallments == input.MaxNumberOfInstallments ||
                    (this.MaxNumberOfInstallments != null &&
                    this.MaxNumberOfInstallments.Equals(input.MaxNumberOfInstallments))
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
                if (this.MaxNumberOfInstallments != null)
                    hashCode = hashCode * 59 + this.MaxNumberOfInstallments.GetHashCode();
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