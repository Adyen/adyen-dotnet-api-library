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
    /// OnboardingLinkSettings
    /// </summary>
    [DataContract(Name = "OnboardingLinkSettings")]
    public partial class OnboardingLinkSettings : IEquatable<OnboardingLinkSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnboardingLinkSettings" /> class.
        /// </summary>
        /// <param name="acceptedCountries">acceptedCountries.</param>
        /// <param name="allowBankAccountFormatSelection">allowBankAccountFormatSelection.</param>
        /// <param name="allowIntraRegionCrossBorderPayout">allowIntraRegionCrossBorderPayout.</param>
        /// <param name="changeLegalEntityType">changeLegalEntityType.</param>
        /// <param name="editPrefilledCountry">editPrefilledCountry.</param>
        /// <param name="hideOnboardingIntroductionIndividual">hideOnboardingIntroductionIndividual.</param>
        /// <param name="hideOnboardingIntroductionOrganization">hideOnboardingIntroductionOrganization.</param>
        /// <param name="hideOnboardingIntroductionSoleProprietor">hideOnboardingIntroductionSoleProprietor.</param>
        /// <param name="hideOnboardingIntroductionTrust">hideOnboardingIntroductionTrust.</param>
        /// <param name="instantBankVerification">instantBankVerification.</param>
        /// <param name="requirePciSignEcomMoto">requirePciSignEcomMoto.</param>
        /// <param name="requirePciSignEcommerce">requirePciSignEcommerce.</param>
        /// <param name="requirePciSignPos">requirePciSignPos.</param>
        /// <param name="requirePciSignPosMoto">requirePciSignPosMoto.</param>
        /// <param name="transferInstrumentLimit">transferInstrumentLimit.</param>
        public OnboardingLinkSettings(List<string> acceptedCountries = default(List<string>), bool? allowBankAccountFormatSelection = default(bool?), bool? allowIntraRegionCrossBorderPayout = default(bool?), bool? changeLegalEntityType = default(bool?), bool? editPrefilledCountry = default(bool?), bool? hideOnboardingIntroductionIndividual = default(bool?), bool? hideOnboardingIntroductionOrganization = default(bool?), bool? hideOnboardingIntroductionSoleProprietor = default(bool?), bool? hideOnboardingIntroductionTrust = default(bool?), bool? instantBankVerification = default(bool?), bool? requirePciSignEcomMoto = default(bool?), bool? requirePciSignEcommerce = default(bool?), bool? requirePciSignPos = default(bool?), bool? requirePciSignPosMoto = default(bool?), int? transferInstrumentLimit = default(int?))
        {
            this.AcceptedCountries = acceptedCountries;
            this.AllowBankAccountFormatSelection = allowBankAccountFormatSelection;
            this.AllowIntraRegionCrossBorderPayout = allowIntraRegionCrossBorderPayout;
            this.ChangeLegalEntityType = changeLegalEntityType;
            this.EditPrefilledCountry = editPrefilledCountry;
            this.HideOnboardingIntroductionIndividual = hideOnboardingIntroductionIndividual;
            this.HideOnboardingIntroductionOrganization = hideOnboardingIntroductionOrganization;
            this.HideOnboardingIntroductionSoleProprietor = hideOnboardingIntroductionSoleProprietor;
            this.HideOnboardingIntroductionTrust = hideOnboardingIntroductionTrust;
            this.InstantBankVerification = instantBankVerification;
            this.RequirePciSignEcomMoto = requirePciSignEcomMoto;
            this.RequirePciSignEcommerce = requirePciSignEcommerce;
            this.RequirePciSignPos = requirePciSignPos;
            this.RequirePciSignPosMoto = requirePciSignPosMoto;
            this.TransferInstrumentLimit = transferInstrumentLimit;
        }

        /// <summary>
        /// Gets or Sets AcceptedCountries
        /// </summary>
        [DataMember(Name = "acceptedCountries", EmitDefaultValue = false)]
        public List<string> AcceptedCountries { get; set; }

        /// <summary>
        /// Gets or Sets AllowBankAccountFormatSelection
        /// </summary>
        [DataMember(Name = "allowBankAccountFormatSelection", EmitDefaultValue = false)]
        public bool? AllowBankAccountFormatSelection { get; set; }

        /// <summary>
        /// Gets or Sets AllowIntraRegionCrossBorderPayout
        /// </summary>
        [DataMember(Name = "allowIntraRegionCrossBorderPayout", EmitDefaultValue = false)]
        public bool? AllowIntraRegionCrossBorderPayout { get; set; }

        /// <summary>
        /// Gets or Sets ChangeLegalEntityType
        /// </summary>
        [DataMember(Name = "changeLegalEntityType", EmitDefaultValue = false)]
        public bool? ChangeLegalEntityType { get; set; }

        /// <summary>
        /// Gets or Sets EditPrefilledCountry
        /// </summary>
        [DataMember(Name = "editPrefilledCountry", EmitDefaultValue = false)]
        public bool? EditPrefilledCountry { get; set; }

        /// <summary>
        /// Gets or Sets HideOnboardingIntroductionIndividual
        /// </summary>
        [DataMember(Name = "hideOnboardingIntroductionIndividual", EmitDefaultValue = false)]
        public bool? HideOnboardingIntroductionIndividual { get; set; }

        /// <summary>
        /// Gets or Sets HideOnboardingIntroductionOrganization
        /// </summary>
        [DataMember(Name = "hideOnboardingIntroductionOrganization", EmitDefaultValue = false)]
        public bool? HideOnboardingIntroductionOrganization { get; set; }

        /// <summary>
        /// Gets or Sets HideOnboardingIntroductionSoleProprietor
        /// </summary>
        [DataMember(Name = "hideOnboardingIntroductionSoleProprietor", EmitDefaultValue = false)]
        public bool? HideOnboardingIntroductionSoleProprietor { get; set; }

        /// <summary>
        /// Gets or Sets HideOnboardingIntroductionTrust
        /// </summary>
        [DataMember(Name = "hideOnboardingIntroductionTrust", EmitDefaultValue = false)]
        public bool? HideOnboardingIntroductionTrust { get; set; }

        /// <summary>
        /// Gets or Sets InstantBankVerification
        /// </summary>
        [DataMember(Name = "instantBankVerification", EmitDefaultValue = false)]
        public bool? InstantBankVerification { get; set; }

        /// <summary>
        /// Gets or Sets RequirePciSignEcomMoto
        /// </summary>
        [DataMember(Name = "requirePciSignEcomMoto", EmitDefaultValue = false)]
        public bool? RequirePciSignEcomMoto { get; set; }

        /// <summary>
        /// Gets or Sets RequirePciSignEcommerce
        /// </summary>
        [DataMember(Name = "requirePciSignEcommerce", EmitDefaultValue = false)]
        public bool? RequirePciSignEcommerce { get; set; }

        /// <summary>
        /// Gets or Sets RequirePciSignPos
        /// </summary>
        [DataMember(Name = "requirePciSignPos", EmitDefaultValue = false)]
        public bool? RequirePciSignPos { get; set; }

        /// <summary>
        /// Gets or Sets RequirePciSignPosMoto
        /// </summary>
        [DataMember(Name = "requirePciSignPosMoto", EmitDefaultValue = false)]
        public bool? RequirePciSignPosMoto { get; set; }

        /// <summary>
        /// Gets or Sets TransferInstrumentLimit
        /// </summary>
        [DataMember(Name = "transferInstrumentLimit", EmitDefaultValue = false)]
        public int? TransferInstrumentLimit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OnboardingLinkSettings {\n");
            sb.Append("  AcceptedCountries: ").Append(AcceptedCountries).Append("\n");
            sb.Append("  AllowBankAccountFormatSelection: ").Append(AllowBankAccountFormatSelection).Append("\n");
            sb.Append("  AllowIntraRegionCrossBorderPayout: ").Append(AllowIntraRegionCrossBorderPayout).Append("\n");
            sb.Append("  ChangeLegalEntityType: ").Append(ChangeLegalEntityType).Append("\n");
            sb.Append("  EditPrefilledCountry: ").Append(EditPrefilledCountry).Append("\n");
            sb.Append("  HideOnboardingIntroductionIndividual: ").Append(HideOnboardingIntroductionIndividual).Append("\n");
            sb.Append("  HideOnboardingIntroductionOrganization: ").Append(HideOnboardingIntroductionOrganization).Append("\n");
            sb.Append("  HideOnboardingIntroductionSoleProprietor: ").Append(HideOnboardingIntroductionSoleProprietor).Append("\n");
            sb.Append("  HideOnboardingIntroductionTrust: ").Append(HideOnboardingIntroductionTrust).Append("\n");
            sb.Append("  InstantBankVerification: ").Append(InstantBankVerification).Append("\n");
            sb.Append("  RequirePciSignEcomMoto: ").Append(RequirePciSignEcomMoto).Append("\n");
            sb.Append("  RequirePciSignEcommerce: ").Append(RequirePciSignEcommerce).Append("\n");
            sb.Append("  RequirePciSignPos: ").Append(RequirePciSignPos).Append("\n");
            sb.Append("  RequirePciSignPosMoto: ").Append(RequirePciSignPosMoto).Append("\n");
            sb.Append("  TransferInstrumentLimit: ").Append(TransferInstrumentLimit).Append("\n");
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
            return this.Equals(input as OnboardingLinkSettings);
        }

        /// <summary>
        /// Returns true if OnboardingLinkSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of OnboardingLinkSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OnboardingLinkSettings input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AcceptedCountries == input.AcceptedCountries ||
                    this.AcceptedCountries != null &&
                    input.AcceptedCountries != null &&
                    this.AcceptedCountries.SequenceEqual(input.AcceptedCountries)
                ) && 
                (
                    this.AllowBankAccountFormatSelection == input.AllowBankAccountFormatSelection ||
                    this.AllowBankAccountFormatSelection.Equals(input.AllowBankAccountFormatSelection)
                ) && 
                (
                    this.AllowIntraRegionCrossBorderPayout == input.AllowIntraRegionCrossBorderPayout ||
                    this.AllowIntraRegionCrossBorderPayout.Equals(input.AllowIntraRegionCrossBorderPayout)
                ) && 
                (
                    this.ChangeLegalEntityType == input.ChangeLegalEntityType ||
                    this.ChangeLegalEntityType.Equals(input.ChangeLegalEntityType)
                ) && 
                (
                    this.EditPrefilledCountry == input.EditPrefilledCountry ||
                    this.EditPrefilledCountry.Equals(input.EditPrefilledCountry)
                ) && 
                (
                    this.HideOnboardingIntroductionIndividual == input.HideOnboardingIntroductionIndividual ||
                    this.HideOnboardingIntroductionIndividual.Equals(input.HideOnboardingIntroductionIndividual)
                ) && 
                (
                    this.HideOnboardingIntroductionOrganization == input.HideOnboardingIntroductionOrganization ||
                    this.HideOnboardingIntroductionOrganization.Equals(input.HideOnboardingIntroductionOrganization)
                ) && 
                (
                    this.HideOnboardingIntroductionSoleProprietor == input.HideOnboardingIntroductionSoleProprietor ||
                    this.HideOnboardingIntroductionSoleProprietor.Equals(input.HideOnboardingIntroductionSoleProprietor)
                ) && 
                (
                    this.HideOnboardingIntroductionTrust == input.HideOnboardingIntroductionTrust ||
                    this.HideOnboardingIntroductionTrust.Equals(input.HideOnboardingIntroductionTrust)
                ) && 
                (
                    this.InstantBankVerification == input.InstantBankVerification ||
                    this.InstantBankVerification.Equals(input.InstantBankVerification)
                ) && 
                (
                    this.RequirePciSignEcomMoto == input.RequirePciSignEcomMoto ||
                    this.RequirePciSignEcomMoto.Equals(input.RequirePciSignEcomMoto)
                ) && 
                (
                    this.RequirePciSignEcommerce == input.RequirePciSignEcommerce ||
                    this.RequirePciSignEcommerce.Equals(input.RequirePciSignEcommerce)
                ) && 
                (
                    this.RequirePciSignPos == input.RequirePciSignPos ||
                    this.RequirePciSignPos.Equals(input.RequirePciSignPos)
                ) && 
                (
                    this.RequirePciSignPosMoto == input.RequirePciSignPosMoto ||
                    this.RequirePciSignPosMoto.Equals(input.RequirePciSignPosMoto)
                ) && 
                (
                    this.TransferInstrumentLimit == input.TransferInstrumentLimit ||
                    this.TransferInstrumentLimit.Equals(input.TransferInstrumentLimit)
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
                if (this.AcceptedCountries != null)
                {
                    hashCode = (hashCode * 59) + this.AcceptedCountries.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AllowBankAccountFormatSelection.GetHashCode();
                hashCode = (hashCode * 59) + this.AllowIntraRegionCrossBorderPayout.GetHashCode();
                hashCode = (hashCode * 59) + this.ChangeLegalEntityType.GetHashCode();
                hashCode = (hashCode * 59) + this.EditPrefilledCountry.GetHashCode();
                hashCode = (hashCode * 59) + this.HideOnboardingIntroductionIndividual.GetHashCode();
                hashCode = (hashCode * 59) + this.HideOnboardingIntroductionOrganization.GetHashCode();
                hashCode = (hashCode * 59) + this.HideOnboardingIntroductionSoleProprietor.GetHashCode();
                hashCode = (hashCode * 59) + this.HideOnboardingIntroductionTrust.GetHashCode();
                hashCode = (hashCode * 59) + this.InstantBankVerification.GetHashCode();
                hashCode = (hashCode * 59) + this.RequirePciSignEcomMoto.GetHashCode();
                hashCode = (hashCode * 59) + this.RequirePciSignEcommerce.GetHashCode();
                hashCode = (hashCode * 59) + this.RequirePciSignPos.GetHashCode();
                hashCode = (hashCode * 59) + this.RequirePciSignPosMoto.GetHashCode();
                hashCode = (hashCode * 59) + this.TransferInstrumentLimit.GetHashCode();
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