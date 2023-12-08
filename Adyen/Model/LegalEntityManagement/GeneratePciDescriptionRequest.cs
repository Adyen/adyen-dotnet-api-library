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
    /// GeneratePciDescriptionRequest
    /// </summary>
    [DataContract(Name = "GeneratePciDescriptionRequest")]
    public partial class GeneratePciDescriptionRequest : IEquatable<GeneratePciDescriptionRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines AdditionalSalesChannels
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AdditionalSalesChannelsEnum
        {
            /// <summary>
            /// Enum ECommerce for value: eCommerce
            /// </summary>
            [EnumMember(Value = "eCommerce")]
            ECommerce = 1,

            /// <summary>
            /// Enum EcomMoto for value: ecomMoto
            /// </summary>
            [EnumMember(Value = "ecomMoto")]
            EcomMoto = 2,

            /// <summary>
            /// Enum Pos for value: pos
            /// </summary>
            [EnumMember(Value = "pos")]
            Pos = 3,

            /// <summary>
            /// Enum PosMoto for value: posMoto
            /// </summary>
            [EnumMember(Value = "posMoto")]
            PosMoto = 4

        }



        /// <summary>
        /// An array of additional sales channels to generate PCI questionnaires. Include the relevant sales channels if you need your user to sign PCI questionnaires. Not required if you [create stores](https://docs.adyen.com/marketplaces-and-platforms/additional-for-platform-setup/create-stores/) and [add payment methods](https://docs.adyen.com/marketplaces-and-platforms/payment-methods/) before you generate the questionnaires.  Possible values: *  **eCommerce** *  **pos** *  **ecomMoto** *  **posMoto**  
        /// </summary>
        /// <value>An array of additional sales channels to generate PCI questionnaires. Include the relevant sales channels if you need your user to sign PCI questionnaires. Not required if you [create stores](https://docs.adyen.com/marketplaces-and-platforms/additional-for-platform-setup/create-stores/) and [add payment methods](https://docs.adyen.com/marketplaces-and-platforms/payment-methods/) before you generate the questionnaires.  Possible values: *  **eCommerce** *  **pos** *  **ecomMoto** *  **posMoto**  </value>
        [DataMember(Name = "additionalSalesChannels", EmitDefaultValue = false)]
        public List<AdditionalSalesChannelsEnum> AdditionalSalesChannels { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratePciDescriptionRequest" /> class.
        /// </summary>
        /// <param name="additionalSalesChannels">An array of additional sales channels to generate PCI questionnaires. Include the relevant sales channels if you need your user to sign PCI questionnaires. Not required if you [create stores](https://docs.adyen.com/marketplaces-and-platforms/additional-for-platform-setup/create-stores/) and [add payment methods](https://docs.adyen.com/marketplaces-and-platforms/payment-methods/) before you generate the questionnaires.  Possible values: *  **eCommerce** *  **pos** *  **ecomMoto** *  **posMoto**  .</param>
        /// <param name="language">Sets the language of the PCI questionnaire. Its value is a two-character [ISO 639-1](https://en.wikipedia.org/wiki/ISO_639-1) language code, for example, **en**..</param>
        public GeneratePciDescriptionRequest(List<AdditionalSalesChannelsEnum> additionalSalesChannels = default(List<AdditionalSalesChannelsEnum>), string language = default(string))
        {
            this.AdditionalSalesChannels = additionalSalesChannels;
            this.Language = language;
        }

        /// <summary>
        /// Sets the language of the PCI questionnaire. Its value is a two-character [ISO 639-1](https://en.wikipedia.org/wiki/ISO_639-1) language code, for example, **en**.
        /// </summary>
        /// <value>Sets the language of the PCI questionnaire. Its value is a two-character [ISO 639-1](https://en.wikipedia.org/wiki/ISO_639-1) language code, for example, **en**.</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string Language { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GeneratePciDescriptionRequest {\n");
            sb.Append("  AdditionalSalesChannels: ").Append(AdditionalSalesChannels).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
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
            return this.Equals(input as GeneratePciDescriptionRequest);
        }

        /// <summary>
        /// Returns true if GeneratePciDescriptionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GeneratePciDescriptionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeneratePciDescriptionRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AdditionalSalesChannels == input.AdditionalSalesChannels ||
                    this.AdditionalSalesChannels.SequenceEqual(input.AdditionalSalesChannels)
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
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
                hashCode = (hashCode * 59) + this.AdditionalSalesChannels.GetHashCode();
                if (this.Language != null)
                {
                    hashCode = (hashCode * 59) + this.Language.GetHashCode();
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
