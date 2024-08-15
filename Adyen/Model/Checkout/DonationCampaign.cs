/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 71
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

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// DonationCampaign
    /// </summary>
    [DataContract(Name = "DonationCampaign")]
    public partial class DonationCampaign : IEquatable<DonationCampaign>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DonationCampaign" /> class.
        /// </summary>
        /// <param name="amounts">amounts.</param>
        /// <param name="bannerUrl">The URL for the banner of the nonprofit or campaign..</param>
        /// <param name="campaignName">The name of the donation campaign...</param>
        /// <param name="causeName">The cause of the nonprofit..</param>
        /// <param name="donation">donation.</param>
        /// <param name="id">The unique campaign ID of the donation campaign..</param>
        /// <param name="logoUrl">The URL for the logo of the nonprofit..</param>
        /// <param name="nonprofitDescription">The description of the nonprofit..</param>
        /// <param name="nonprofitName">The name of the nonprofit organization that receives the donation..</param>
        /// <param name="nonprofitUrl">The website URL of the nonprofit..</param>
        /// <param name="termsAndConditionsUrl">The URL of the terms and conditions page of the nonprofit and the campaign..</param>
        public DonationCampaign(Amounts amounts = default(Amounts), string bannerUrl = default(string), string campaignName = default(string), string causeName = default(string), Donation donation = default(Donation), string id = default(string), string logoUrl = default(string), string nonprofitDescription = default(string), string nonprofitName = default(string), string nonprofitUrl = default(string), string termsAndConditionsUrl = default(string))
        {
            this.Amounts = amounts;
            this.BannerUrl = bannerUrl;
            this.CampaignName = campaignName;
            this.CauseName = causeName;
            this.Donation = donation;
            this.Id = id;
            this.LogoUrl = logoUrl;
            this.NonprofitDescription = nonprofitDescription;
            this.NonprofitName = nonprofitName;
            this.NonprofitUrl = nonprofitUrl;
            this.TermsAndConditionsUrl = termsAndConditionsUrl;
        }

        /// <summary>
        /// Gets or Sets Amounts
        /// </summary>
        [DataMember(Name = "amounts", EmitDefaultValue = false)]
        public Amounts Amounts { get; set; }

        /// <summary>
        /// The URL for the banner of the nonprofit or campaign.
        /// </summary>
        /// <value>The URL for the banner of the nonprofit or campaign.</value>
        [DataMember(Name = "bannerUrl", EmitDefaultValue = false)]
        public string BannerUrl { get; set; }

        /// <summary>
        /// The name of the donation campaign..
        /// </summary>
        /// <value>The name of the donation campaign..</value>
        [DataMember(Name = "campaignName", EmitDefaultValue = false)]
        public string CampaignName { get; set; }

        /// <summary>
        /// The cause of the nonprofit.
        /// </summary>
        /// <value>The cause of the nonprofit.</value>
        [DataMember(Name = "causeName", EmitDefaultValue = false)]
        public string CauseName { get; set; }

        /// <summary>
        /// Gets or Sets Donation
        /// </summary>
        [DataMember(Name = "donation", EmitDefaultValue = false)]
        public Donation Donation { get; set; }

        /// <summary>
        /// The unique campaign ID of the donation campaign.
        /// </summary>
        /// <value>The unique campaign ID of the donation campaign.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The URL for the logo of the nonprofit.
        /// </summary>
        /// <value>The URL for the logo of the nonprofit.</value>
        [DataMember(Name = "logoUrl", EmitDefaultValue = false)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// The description of the nonprofit.
        /// </summary>
        /// <value>The description of the nonprofit.</value>
        [DataMember(Name = "nonprofitDescription", EmitDefaultValue = false)]
        public string NonprofitDescription { get; set; }

        /// <summary>
        /// The name of the nonprofit organization that receives the donation.
        /// </summary>
        /// <value>The name of the nonprofit organization that receives the donation.</value>
        [DataMember(Name = "nonprofitName", EmitDefaultValue = false)]
        public string NonprofitName { get; set; }

        /// <summary>
        /// The website URL of the nonprofit.
        /// </summary>
        /// <value>The website URL of the nonprofit.</value>
        [DataMember(Name = "nonprofitUrl", EmitDefaultValue = false)]
        public string NonprofitUrl { get; set; }

        /// <summary>
        /// The URL of the terms and conditions page of the nonprofit and the campaign.
        /// </summary>
        /// <value>The URL of the terms and conditions page of the nonprofit and the campaign.</value>
        [DataMember(Name = "termsAndConditionsUrl", EmitDefaultValue = false)]
        public string TermsAndConditionsUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DonationCampaign {\n");
            sb.Append("  Amounts: ").Append(Amounts).Append("\n");
            sb.Append("  BannerUrl: ").Append(BannerUrl).Append("\n");
            sb.Append("  CampaignName: ").Append(CampaignName).Append("\n");
            sb.Append("  CauseName: ").Append(CauseName).Append("\n");
            sb.Append("  Donation: ").Append(Donation).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LogoUrl: ").Append(LogoUrl).Append("\n");
            sb.Append("  NonprofitDescription: ").Append(NonprofitDescription).Append("\n");
            sb.Append("  NonprofitName: ").Append(NonprofitName).Append("\n");
            sb.Append("  NonprofitUrl: ").Append(NonprofitUrl).Append("\n");
            sb.Append("  TermsAndConditionsUrl: ").Append(TermsAndConditionsUrl).Append("\n");
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
            return this.Equals(input as DonationCampaign);
        }

        /// <summary>
        /// Returns true if DonationCampaign instances are equal
        /// </summary>
        /// <param name="input">Instance of DonationCampaign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DonationCampaign input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amounts == input.Amounts ||
                    (this.Amounts != null &&
                    this.Amounts.Equals(input.Amounts))
                ) && 
                (
                    this.BannerUrl == input.BannerUrl ||
                    (this.BannerUrl != null &&
                    this.BannerUrl.Equals(input.BannerUrl))
                ) && 
                (
                    this.CampaignName == input.CampaignName ||
                    (this.CampaignName != null &&
                    this.CampaignName.Equals(input.CampaignName))
                ) && 
                (
                    this.CauseName == input.CauseName ||
                    (this.CauseName != null &&
                    this.CauseName.Equals(input.CauseName))
                ) && 
                (
                    this.Donation == input.Donation ||
                    (this.Donation != null &&
                    this.Donation.Equals(input.Donation))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LogoUrl == input.LogoUrl ||
                    (this.LogoUrl != null &&
                    this.LogoUrl.Equals(input.LogoUrl))
                ) && 
                (
                    this.NonprofitDescription == input.NonprofitDescription ||
                    (this.NonprofitDescription != null &&
                    this.NonprofitDescription.Equals(input.NonprofitDescription))
                ) && 
                (
                    this.NonprofitName == input.NonprofitName ||
                    (this.NonprofitName != null &&
                    this.NonprofitName.Equals(input.NonprofitName))
                ) && 
                (
                    this.NonprofitUrl == input.NonprofitUrl ||
                    (this.NonprofitUrl != null &&
                    this.NonprofitUrl.Equals(input.NonprofitUrl))
                ) && 
                (
                    this.TermsAndConditionsUrl == input.TermsAndConditionsUrl ||
                    (this.TermsAndConditionsUrl != null &&
                    this.TermsAndConditionsUrl.Equals(input.TermsAndConditionsUrl))
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
                if (this.Amounts != null)
                {
                    hashCode = (hashCode * 59) + this.Amounts.GetHashCode();
                }
                if (this.BannerUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BannerUrl.GetHashCode();
                }
                if (this.CampaignName != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignName.GetHashCode();
                }
                if (this.CauseName != null)
                {
                    hashCode = (hashCode * 59) + this.CauseName.GetHashCode();
                }
                if (this.Donation != null)
                {
                    hashCode = (hashCode * 59) + this.Donation.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.LogoUrl != null)
                {
                    hashCode = (hashCode * 59) + this.LogoUrl.GetHashCode();
                }
                if (this.NonprofitDescription != null)
                {
                    hashCode = (hashCode * 59) + this.NonprofitDescription.GetHashCode();
                }
                if (this.NonprofitName != null)
                {
                    hashCode = (hashCode * 59) + this.NonprofitName.GetHashCode();
                }
                if (this.NonprofitUrl != null)
                {
                    hashCode = (hashCode * 59) + this.NonprofitUrl.GetHashCode();
                }
                if (this.TermsAndConditionsUrl != null)
                {
                    hashCode = (hashCode * 59) + this.TermsAndConditionsUrl.GetHashCode();
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
            yield break;
        }
    }

}
