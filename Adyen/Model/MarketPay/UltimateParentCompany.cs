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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// UltimateParentCompany
    /// </summary>
    [DataContract(Name = "UltimateParentCompany")]
    public partial class UltimateParentCompany : IEquatable<UltimateParentCompany>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UltimateParentCompany" /> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="businessDetails">businessDetails.</param>
        /// <param name="ultimateParentCompanyCode">Adyen-generated unique alphanumeric identifier (UUID) for the entry, returned in the response when you create an ultimate parent company. Required when updating an existing entry in an &#x60;/updateAccountHolder&#x60; request..</param>
        public UltimateParentCompany(ViasAddress address = default(ViasAddress), UltimateParentCompanyBusinessDetails businessDetails = default(UltimateParentCompanyBusinessDetails), string ultimateParentCompanyCode = default(string))
        {
            this.Address = address;
            this.BusinessDetails = businessDetails;
            this.UltimateParentCompanyCode = ultimateParentCompanyCode;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public ViasAddress Address { get; set; }

        /// <summary>
        /// Gets or Sets BusinessDetails
        /// </summary>
        [DataMember(Name = "businessDetails", EmitDefaultValue = false)]
        public UltimateParentCompanyBusinessDetails BusinessDetails { get; set; }

        /// <summary>
        /// Adyen-generated unique alphanumeric identifier (UUID) for the entry, returned in the response when you create an ultimate parent company. Required when updating an existing entry in an &#x60;/updateAccountHolder&#x60; request.
        /// </summary>
        /// <value>Adyen-generated unique alphanumeric identifier (UUID) for the entry, returned in the response when you create an ultimate parent company. Required when updating an existing entry in an &#x60;/updateAccountHolder&#x60; request.</value>
        [DataMember(Name = "ultimateParentCompanyCode", EmitDefaultValue = false)]
        public string UltimateParentCompanyCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UltimateParentCompany {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  BusinessDetails: ").Append(BusinessDetails).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UltimateParentCompany);
        }

        /// <summary>
        /// Returns true if UltimateParentCompany instances are equal
        /// </summary>
        /// <param name="input">Instance of UltimateParentCompany to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UltimateParentCompany input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) &&
                (
                    this.BusinessDetails == input.BusinessDetails ||
                    (this.BusinessDetails != null &&
                    this.BusinessDetails.Equals(input.BusinessDetails))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.BusinessDetails != null)
                    hashCode = hashCode * 59 + this.BusinessDetails.GetHashCode();
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
