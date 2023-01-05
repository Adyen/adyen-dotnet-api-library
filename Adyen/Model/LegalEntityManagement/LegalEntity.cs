/*
* Legal Entity Management API
*
*
* The version of the OpenAPI document: 2
* Contact: developer-experience@adyen.com
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Adyen.Model.LegalEntityManagement
{
    /// <summary>
    /// LegalEntity
    /// </summary>
    [DataContract]
    public partial class LegalEntity :  IEquatable<LegalEntity>, IValidatableObject
    {
        /// <summary>
        /// The type of legal entity.   Possible values: **individual**, **organization**, or **soleProprietorship**.
        /// </summary>
        /// <value>The type of legal entity.   Possible values: **individual**, **organization**, or **soleProprietorship**.</value>
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
        /// The type of legal entity.   Possible values: **individual**, **organization**, or **soleProprietorship**.
        /// </summary>
        /// <value>The type of legal entity.   Possible values: **individual**, **organization**, or **soleProprietorship**.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum Type { get; set; }
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
        /// <param name="reference">Your reference for the legal entity, maximum 150 characters..</param>
        /// <param name="soleProprietorship">soleProprietorship.</param>
        /// <param name="transferInstruments">List of transfer instruments owned by the legal entity..</param>
        /// <param name="type">The type of legal entity.   Possible values: **individual**, **organization**, or **soleProprietorship**. (required).</param>
        public LegalEntity(List<DocumentReference> documentDetails = default(List<DocumentReference>), List<EntityReference> documents = default(List<EntityReference>), List<LegalEntityAssociation> entityAssociations = default(List<LegalEntityAssociation>), Individual individual = default(Individual), Organization organization = default(Organization), string reference = default(string), SoleProprietorship soleProprietorship = default(SoleProprietorship), List<EntityReference> transferInstruments = default(List<EntityReference>), TypeEnum type = default(TypeEnum))
        {
            this.DocumentDetails = documentDetails;
            this.Documents = documents;
            this.EntityAssociations = entityAssociations;
            this.Individual = individual;
            this.Organization = organization;
            this.Reference = reference;
            this.SoleProprietorship = soleProprietorship;
            this.TransferInstruments = transferInstruments;
            this.Type = type;
        }

        /// <summary>
        /// List of documents uploaded for the legal entity.
        /// </summary>
        /// <value>List of documents uploaded for the legal entity.</value>
        [DataMember(Name="documentDetails", EmitDefaultValue=false)]
        public List<DocumentReference> DocumentDetails { get; set; }

        /// <summary>
        /// List of documents uploaded for the legal entity.
        /// </summary>
        /// <value>List of documents uploaded for the legal entity.</value>
        [DataMember(Name="documents", EmitDefaultValue=false)]
        [Obsolete]
        public List<EntityReference> Documents { get; set; }

        /// <summary>
        /// List of legal entities associated with the current legal entity. For example, ultimate beneficial owners associated with an organization through ownership or control, or as signatories.
        /// </summary>
        /// <value>List of legal entities associated with the current legal entity. For example, ultimate beneficial owners associated with an organization through ownership or control, or as signatories.</value>
        [DataMember(Name="entityAssociations", EmitDefaultValue=false)]
        public List<LegalEntityAssociation> EntityAssociations { get; set; }

        /// <summary>
        /// The unique identifier of the legal entity.
        /// </summary>
        /// <value>The unique identifier of the legal entity.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or Sets Individual
        /// </summary>
        [DataMember(Name="individual", EmitDefaultValue=false)]
        public Individual Individual { get; set; }

        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name="organization", EmitDefaultValue=false)]
        public Organization Organization { get; set; }

        /// <summary>
        /// Your reference for the legal entity, maximum 150 characters.
        /// </summary>
        /// <value>Your reference for the legal entity, maximum 150 characters.</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets SoleProprietorship
        /// </summary>
        [DataMember(Name="soleProprietorship", EmitDefaultValue=false)]
        public SoleProprietorship SoleProprietorship { get; set; }

        /// <summary>
        /// List of transfer instruments owned by the legal entity.
        /// </summary>
        /// <value>List of transfer instruments owned by the legal entity.</value>
        [DataMember(Name="transferInstruments", EmitDefaultValue=false)]
        public List<EntityReference> TransferInstruments { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LegalEntity {\n");
            sb.Append("  DocumentDetails: ").Append(DocumentDetails).Append("\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
            sb.Append("  EntityAssociations: ").Append(EntityAssociations).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Individual: ").Append(Individual).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  SoleProprietorship: ").Append(SoleProprietorship).Append("\n");
            sb.Append("  TransferInstruments: ").Append(TransferInstruments).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
                return false;

            return 
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.DocumentDetails != null)
                    hashCode = hashCode * 59 + this.DocumentDetails.GetHashCode();
                if (this.Documents != null)
                    hashCode = hashCode * 59 + this.Documents.GetHashCode();
                if (this.EntityAssociations != null)
                    hashCode = hashCode * 59 + this.EntityAssociations.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Individual != null)
                    hashCode = hashCode * 59 + this.Individual.GetHashCode();
                if (this.Organization != null)
                    hashCode = hashCode * 59 + this.Organization.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.SoleProprietorship != null)
                    hashCode = hashCode * 59 + this.SoleProprietorship.GetHashCode();
                if (this.TransferInstruments != null)
                    hashCode = hashCode * 59 + this.TransferInstruments.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
            // Reference (string) maxLength
            if(this.Reference != null && this.Reference.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Reference, length must be less than 150.", new [] { "Reference" });
            }


            yield break;
        }
    }

}
