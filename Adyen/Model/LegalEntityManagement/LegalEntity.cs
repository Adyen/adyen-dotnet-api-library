/*
* Legal Entity Management API
*
*
* The version of the OpenAPI document: 3
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.LegalEntityManagement
{
    /// <summary>
    /// LegalEntity
    /// </summary>
    [DataContract(Name = "LegalEntity")]
    public partial class LegalEntity : IEquatable<LegalEntity>, IValidatableObject
    {
        /// <summary>
        /// The type of legal entity.  Possible values: **individual**, **organization**, **soleProprietorship**, or **trust**.
        /// </summary>
        /// <value>The type of legal entity.  Possible values: **individual**, **organization**, **soleProprietorship**, or **trust**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Individual for value: individual
            /// </summary>
            [EnumMember(Value = "individual")]
            Individual = 1,

            /// <summary>
            /// Enum Organization for value: organization
            /// </summary>
            [EnumMember(Value = "organization")]
            Organization = 2,

            /// <summary>
            /// Enum SoleProprietorship for value: soleProprietorship
            /// </summary>
            [EnumMember(Value = "soleProprietorship")]
            SoleProprietorship = 3,

            /// <summary>
            /// Enum Trust for value: trust
            /// </summary>
            [EnumMember(Value = "trust")]
            Trust = 4,

            /// <summary>
            /// Enum UnincorporatedPartnership for value: unincorporatedPartnership
            /// </summary>
            [EnumMember(Value = "unincorporatedPartnership")]
            UnincorporatedPartnership = 5

        }


        /// <summary>
        /// The type of legal entity.  Possible values: **individual**, **organization**, **soleProprietorship**, or **trust**.
        /// </summary>
        /// <value>The type of legal entity.  Possible values: **individual**, **organization**, **soleProprietorship**, or **trust**.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LegalEntity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LegalEntity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LegalEntity" /> class.
        /// </summary>
        /// <param name="documentDetails">List of documents uploaded for the legal entity..</param>
        /// <param name="documents">List of documents uploaded for the legal entity..</param>
        /// <param name="entityAssociations">List of legal entities associated with the current legal entity. For example, ultimate beneficial owners associated with an organization through ownership or control, or as signatories..</param>
        /// <param name="individual">individual.</param>
        /// <param name="organization">organization.</param>
        /// <param name="problems">List of verification errors related to capabilities for the legal entity..</param>
        /// <param name="reference">Your reference for the legal entity, maximum 150 characters..</param>
        /// <param name="soleProprietorship">soleProprietorship.</param>
        /// <param name="trust">trust.</param>
        /// <param name="type">The type of legal entity.  Possible values: **individual**, **organization**, **soleProprietorship**, or **trust**..</param>
        /// <param name="verificationPlan">A key-value pair that specifies the verification process for a legal entity. Set to **upfront** for upfront verification for [marketplaces](https://docs.adyen.com/marketplaces/onboard-users#upfront)..</param>
        public LegalEntity(List<DocumentReference> documentDetails = default(List<DocumentReference>), List<EntityReference> documents = default(List<EntityReference>), List<LegalEntityAssociation> entityAssociations = default(List<LegalEntityAssociation>), Individual individual = default(Individual), Organization organization = default(Organization), List<CapabilityProblem> problems = default(List<CapabilityProblem>), string reference = default(string), SoleProprietorship soleProprietorship = default(SoleProprietorship), Trust trust = default(Trust), TypeEnum? type = default(TypeEnum?), string verificationPlan = default(string))
        {
            this.DocumentDetails = documentDetails;
            this.Documents = documents;
            this.EntityAssociations = entityAssociations;
            this.Individual = individual;
            this.Organization = organization;
            this.Problems = problems;
            this.Reference = reference;
            this.SoleProprietorship = soleProprietorship;
            this.Trust = trust;
            this.Type = type;
            this.VerificationPlan = verificationPlan;
        }

        /// <summary>
        /// Contains key-value pairs that specify the actions that the legal entity can do in your platform.The key is a capability required for your integration. For example, **issueCard** for Issuing.The value is an object containing the settings for the capability.
        /// </summary>
        /// <value>Contains key-value pairs that specify the actions that the legal entity can do in your platform.The key is a capability required for your integration. For example, **issueCard** for Issuing.The value is an object containing the settings for the capability.</value>
        [DataMember(Name = "capabilities", EmitDefaultValue = false)]
        public Dictionary<string, LegalEntityCapability> Capabilities { get; private set; }

        /// <summary>
        /// List of documents uploaded for the legal entity.
        /// </summary>
        /// <value>List of documents uploaded for the legal entity.</value>
        [DataMember(Name = "documentDetails", EmitDefaultValue = false)]
        public List<DocumentReference> DocumentDetails { get; set; }

        /// <summary>
        /// List of documents uploaded for the legal entity.
        /// </summary>
        /// <value>List of documents uploaded for the legal entity.</value>
        [DataMember(Name = "documents", EmitDefaultValue = false)]
        [Obsolete]
        public List<EntityReference> Documents { get; set; }

        /// <summary>
        /// List of legal entities associated with the current legal entity. For example, ultimate beneficial owners associated with an organization through ownership or control, or as signatories.
        /// </summary>
        /// <value>List of legal entities associated with the current legal entity. For example, ultimate beneficial owners associated with an organization through ownership or control, or as signatories.</value>
        [DataMember(Name = "entityAssociations", EmitDefaultValue = false)]
        public List<LegalEntityAssociation> EntityAssociations { get; set; }

        /// <summary>
        /// The unique identifier of the legal entity.
        /// </summary>
        /// <value>The unique identifier of the legal entity.</value>
        [DataMember(Name = "id", IsRequired = false, EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or Sets Individual
        /// </summary>
        [DataMember(Name = "individual", EmitDefaultValue = false)]
        public Individual Individual { get; set; }

        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name = "organization", EmitDefaultValue = false)]
        public Organization Organization { get; set; }

        /// <summary>
        /// List of verification errors related to capabilities for the legal entity.
        /// </summary>
        /// <value>List of verification errors related to capabilities for the legal entity.</value>
        [DataMember(Name = "problems", EmitDefaultValue = false)]
        public List<CapabilityProblem> Problems { get; set; }

        /// <summary>
        /// Your reference for the legal entity, maximum 150 characters.
        /// </summary>
        /// <value>Your reference for the legal entity, maximum 150 characters.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets SoleProprietorship
        /// </summary>
        [DataMember(Name = "soleProprietorship", EmitDefaultValue = false)]
        public SoleProprietorship SoleProprietorship { get; set; }

        /// <summary>
        /// List of transfer instruments that the legal entity owns.
        /// </summary>
        /// <value>List of transfer instruments that the legal entity owns.</value>
        [DataMember(Name = "transferInstruments", EmitDefaultValue = false)]
        public List<TransferInstrumentReference> TransferInstruments { get; private set; }

        /// <summary>
        /// Gets or Sets Trust
        /// </summary>
        [DataMember(Name = "trust", EmitDefaultValue = false)]
        public Trust Trust { get; set; }

        /// <summary>
        /// List of verification deadlines and the capabilities that will be disallowed if verification errors are not resolved.
        /// </summary>
        /// <value>List of verification deadlines and the capabilities that will be disallowed if verification errors are not resolved.</value>
        [DataMember(Name = "verificationDeadlines", EmitDefaultValue = false)]
        public List<VerificationDeadline> VerificationDeadlines { get; private set; }

        /// <summary>
        /// A key-value pair that specifies the verification process for a legal entity. Set to **upfront** for upfront verification for [marketplaces](https://docs.adyen.com/marketplaces/onboard-users#upfront).
        /// </summary>
        /// <value>A key-value pair that specifies the verification process for a legal entity. Set to **upfront** for upfront verification for [marketplaces](https://docs.adyen.com/marketplaces/onboard-users#upfront).</value>
        [DataMember(Name = "verificationPlan", EmitDefaultValue = false)]
        public string VerificationPlan { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LegalEntity {\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            sb.Append("  DocumentDetails: ").Append(DocumentDetails).Append("\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
            sb.Append("  EntityAssociations: ").Append(EntityAssociations).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Individual: ").Append(Individual).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  Problems: ").Append(Problems).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  SoleProprietorship: ").Append(SoleProprietorship).Append("\n");
            sb.Append("  TransferInstruments: ").Append(TransferInstruments).Append("\n");
            sb.Append("  Trust: ").Append(Trust).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  VerificationDeadlines: ").Append(VerificationDeadlines).Append("\n");
            sb.Append("  VerificationPlan: ").Append(VerificationPlan).Append("\n");
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
            return this.Equals(input as LegalEntity);
        }

        /// <summary>
        /// Returns true if LegalEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of LegalEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LegalEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Capabilities == input.Capabilities ||
                    this.Capabilities != null &&
                    input.Capabilities != null &&
                    this.Capabilities.SequenceEqual(input.Capabilities)
                ) && 
                (
                    this.DocumentDetails == input.DocumentDetails ||
                    this.DocumentDetails != null &&
                    input.DocumentDetails != null &&
                    this.DocumentDetails.SequenceEqual(input.DocumentDetails)
                ) && 
                (
                    this.Documents == input.Documents ||
                    this.Documents != null &&
                    input.Documents != null &&
                    this.Documents.SequenceEqual(input.Documents)
                ) && 
                (
                    this.EntityAssociations == input.EntityAssociations ||
                    this.EntityAssociations != null &&
                    input.EntityAssociations != null &&
                    this.EntityAssociations.SequenceEqual(input.EntityAssociations)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Individual == input.Individual ||
                    (this.Individual != null &&
                    this.Individual.Equals(input.Individual))
                ) && 
                (
                    this.Organization == input.Organization ||
                    (this.Organization != null &&
                    this.Organization.Equals(input.Organization))
                ) && 
                (
                    this.Problems == input.Problems ||
                    this.Problems != null &&
                    input.Problems != null &&
                    this.Problems.SequenceEqual(input.Problems)
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.SoleProprietorship == input.SoleProprietorship ||
                    (this.SoleProprietorship != null &&
                    this.SoleProprietorship.Equals(input.SoleProprietorship))
                ) && 
                (
                    this.TransferInstruments == input.TransferInstruments ||
                    this.TransferInstruments != null &&
                    input.TransferInstruments != null &&
                    this.TransferInstruments.SequenceEqual(input.TransferInstruments)
                ) && 
                (
                    this.Trust == input.Trust ||
                    (this.Trust != null &&
                    this.Trust.Equals(input.Trust))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.VerificationDeadlines == input.VerificationDeadlines ||
                    this.VerificationDeadlines != null &&
                    input.VerificationDeadlines != null &&
                    this.VerificationDeadlines.SequenceEqual(input.VerificationDeadlines)
                ) && 
                (
                    this.VerificationPlan == input.VerificationPlan ||
                    (this.VerificationPlan != null &&
                    this.VerificationPlan.Equals(input.VerificationPlan))
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
                if (this.Capabilities != null)
                {
                    hashCode = (hashCode * 59) + this.Capabilities.GetHashCode();
                }
                if (this.DocumentDetails != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentDetails.GetHashCode();
                }
                if (this.Documents != null)
                {
                    hashCode = (hashCode * 59) + this.Documents.GetHashCode();
                }
                if (this.EntityAssociations != null)
                {
                    hashCode = (hashCode * 59) + this.EntityAssociations.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Individual != null)
                {
                    hashCode = (hashCode * 59) + this.Individual.GetHashCode();
                }
                if (this.Organization != null)
                {
                    hashCode = (hashCode * 59) + this.Organization.GetHashCode();
                }
                if (this.Problems != null)
                {
                    hashCode = (hashCode * 59) + this.Problems.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.SoleProprietorship != null)
                {
                    hashCode = (hashCode * 59) + this.SoleProprietorship.GetHashCode();
                }
                if (this.TransferInstruments != null)
                {
                    hashCode = (hashCode * 59) + this.TransferInstruments.GetHashCode();
                }
                if (this.Trust != null)
                {
                    hashCode = (hashCode * 59) + this.Trust.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.VerificationDeadlines != null)
                {
                    hashCode = (hashCode * 59) + this.VerificationDeadlines.GetHashCode();
                }
                if (this.VerificationPlan != null)
                {
                    hashCode = (hashCode * 59) + this.VerificationPlan.GetHashCode();
                }
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
            // Reference (string) maxLength
            if (this.Reference != null && this.Reference.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Reference, length must be less than 150.", new [] { "Reference" });
            }

            yield break;
        }
    }

}
