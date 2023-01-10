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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// BusinessDetails
    /// </summary>
    [DataContract(Name = "BusinessDetails")]
    public partial class BusinessDetails : IEquatable<BusinessDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessDetails" /> class.
        /// </summary>
        /// <param name="doingBusinessAs">The registered name of the company (if it differs from the legal name of the company)..</param>
        /// <param name="legalBusinessName">The legal name of the company..</param>
        /// <param name="listedUltimateParentCompany">Information about the parent public company. Required if the account holder is 100% owned by a publicly listed company..</param>
        /// <param name="registrationNumber">The registration number of the company..</param>
        /// <param name="shareholders">Array containing information about individuals associated with the account holder either through ownership or control. For details about how you can identify them, refer to [Identity check](https://docs.adyen.com/platforms/verification-checks/identity-check)..</param>
        /// <param name="signatories">Signatories associated with the company. Each array entry should represent one signatory..</param>
        /// <param name="taxId">The tax ID of the company..</param>
        public BusinessDetails(string doingBusinessAs = default(string), string legalBusinessName = default(string), List<UltimateParentCompany> listedUltimateParentCompany = default(List<UltimateParentCompany>), string registrationNumber = default(string), List<ShareholderContact> shareholders = default(List<ShareholderContact>), List<SignatoryContact> signatories = default(List<SignatoryContact>), string taxId = default(string))
        {
            this.DoingBusinessAs = doingBusinessAs;
            this.LegalBusinessName = legalBusinessName;
            this.ListedUltimateParentCompany = listedUltimateParentCompany;
            this.RegistrationNumber = registrationNumber;
            this.Shareholders = shareholders;
            this.Signatories = signatories;
            this.TaxId = taxId;
        }

        /// <summary>
        /// The registered name of the company (if it differs from the legal name of the company).
        /// </summary>
        /// <value>The registered name of the company (if it differs from the legal name of the company).</value>
        [DataMember(Name = "doingBusinessAs", EmitDefaultValue = false)]
        public string DoingBusinessAs { get; set; }

        /// <summary>
        /// The legal name of the company.
        /// </summary>
        /// <value>The legal name of the company.</value>
        [DataMember(Name = "legalBusinessName", EmitDefaultValue = false)]
        public string LegalBusinessName { get; set; }

        /// <summary>
        /// Information about the parent public company. Required if the account holder is 100% owned by a publicly listed company.
        /// </summary>
        /// <value>Information about the parent public company. Required if the account holder is 100% owned by a publicly listed company.</value>
        [DataMember(Name = "listedUltimateParentCompany", EmitDefaultValue = false)]
        public List<UltimateParentCompany> ListedUltimateParentCompany { get; set; }

        /// <summary>
        /// The registration number of the company.
        /// </summary>
        /// <value>The registration number of the company.</value>
        [DataMember(Name = "registrationNumber", EmitDefaultValue = false)]
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// Array containing information about individuals associated with the account holder either through ownership or control. For details about how you can identify them, refer to [Identity check](https://docs.adyen.com/platforms/verification-checks/identity-check).
        /// </summary>
        /// <value>Array containing information about individuals associated with the account holder either through ownership or control. For details about how you can identify them, refer to [Identity check](https://docs.adyen.com/platforms/verification-checks/identity-check).</value>
        [DataMember(Name = "shareholders", EmitDefaultValue = false)]
        public List<ShareholderContact> Shareholders { get; set; }

        /// <summary>
        /// Signatories associated with the company. Each array entry should represent one signatory.
        /// </summary>
        /// <value>Signatories associated with the company. Each array entry should represent one signatory.</value>
        [DataMember(Name = "signatories", EmitDefaultValue = false)]
        public List<SignatoryContact> Signatories { get; set; }

        /// <summary>
        /// The tax ID of the company.
        /// </summary>
        /// <value>The tax ID of the company.</value>
        [DataMember(Name = "taxId", EmitDefaultValue = false)]
        public string TaxId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BusinessDetails {\n");
            sb.Append("  DoingBusinessAs: ").Append(DoingBusinessAs).Append("\n");
            sb.Append("  LegalBusinessName: ").Append(LegalBusinessName).Append("\n");
            sb.Append("  ListedUltimateParentCompany: ").Append(ListedUltimateParentCompany).Append("\n");
            sb.Append("  RegistrationNumber: ").Append(RegistrationNumber).Append("\n");
            sb.Append("  Shareholders: ").Append(Shareholders).Append("\n");
            sb.Append("  Signatories: ").Append(Signatories).Append("\n");
            sb.Append("  TaxId: ").Append(TaxId).Append("\n");
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
            return this.Equals(input as BusinessDetails);
        }

        /// <summary>
        /// Returns true if BusinessDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    this.DoingBusinessAs == input.DoingBusinessAs ||
                    (this.DoingBusinessAs != null &&
                    this.DoingBusinessAs.Equals(input.DoingBusinessAs))
                ) &&
                (
                    this.LegalBusinessName == input.LegalBusinessName ||
                    (this.LegalBusinessName != null &&
                    this.LegalBusinessName.Equals(input.LegalBusinessName))
                ) &&
                (
                    this.ListedUltimateParentCompany == input.ListedUltimateParentCompany ||
                    this.ListedUltimateParentCompany != null &&
                    input.ListedUltimateParentCompany != null &&
                    this.ListedUltimateParentCompany.SequenceEqual(input.ListedUltimateParentCompany)
                ) &&
                (
                    this.RegistrationNumber == input.RegistrationNumber ||
                    (this.RegistrationNumber != null &&
                    this.RegistrationNumber.Equals(input.RegistrationNumber))
                ) &&
                (
                    this.Shareholders == input.Shareholders ||
                    this.Shareholders != null &&
                    input.Shareholders != null &&
                    this.Shareholders.SequenceEqual(input.Shareholders)
                ) &&
                (
                    this.Signatories == input.Signatories ||
                    this.Signatories != null &&
                    input.Signatories != null &&
                    this.Signatories.SequenceEqual(input.Signatories)
                ) &&
                (
                    this.TaxId == input.TaxId ||
                    (this.TaxId != null &&
                    this.TaxId.Equals(input.TaxId))
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
                if (this.DoingBusinessAs != null)
                    hashCode = hashCode * 59 + this.DoingBusinessAs.GetHashCode();
                if (this.LegalBusinessName != null)
                    hashCode = hashCode * 59 + this.LegalBusinessName.GetHashCode();
                if (this.ListedUltimateParentCompany != null)
                    hashCode = hashCode * 59 + this.ListedUltimateParentCompany.GetHashCode();
                if (this.RegistrationNumber != null)
                    hashCode = hashCode * 59 + this.RegistrationNumber.GetHashCode();
                if (this.Shareholders != null)
                    hashCode = hashCode * 59 + this.Shareholders.GetHashCode();
                if (this.Signatories != null)
                    hashCode = hashCode * 59 + this.Signatories.GetHashCode();
                if (this.TaxId != null)
                    hashCode = hashCode * 59 + this.TaxId.GetHashCode();
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
