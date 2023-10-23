/*
* Management API
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

namespace Adyen.Model.Management
{
    /// <summary>
    /// UpdatePaymentMethodInfo
    /// </summary>
    [DataContract(Name = "UpdatePaymentMethodInfo")]
    public partial class UpdatePaymentMethodInfo : IEquatable<UpdatePaymentMethodInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePaymentMethodInfo" /> class.
        /// </summary>
        /// <param name="bcmc">bcmc.</param>
        /// <param name="cartesBancaires">cartesBancaires.</param>
        /// <param name="countries">The list of countries where a payment method is available. By default, all countries supported by the payment method..</param>
        /// <param name="cup">cup.</param>
        /// <param name="currencies">The list of currencies that a payment method supports. By default, all currencies supported by the payment method..</param>
        /// <param name="diners">diners.</param>
        /// <param name="discover">discover.</param>
        /// <param name="eftposAustralia">eftposAustralia.</param>
        /// <param name="enabled">Indicates whether the payment method is enabled (**true**) or disabled (**false**)..</param>
        /// <param name="girocard">girocard.</param>
        /// <param name="ideal">ideal.</param>
        /// <param name="interacCard">interacCard.</param>
        /// <param name="jcb">jcb.</param>
        /// <param name="maestro">maestro.</param>
        /// <param name="mc">mc.</param>
        /// <param name="storeIds">The list of stores for this payment method.</param>
        /// <param name="visa">visa.</param>
        public UpdatePaymentMethodInfo(BcmcInfo bcmc = default(BcmcInfo), CartesBancairesInfo cartesBancaires = default(CartesBancairesInfo), List<string> countries = default(List<string>), GenericPmWithTdiInfo cup = default(GenericPmWithTdiInfo), List<string> currencies = default(List<string>), GenericPmWithTdiInfo diners = default(GenericPmWithTdiInfo), GenericPmWithTdiInfo discover = default(GenericPmWithTdiInfo), GenericPmWithTdiInfo eftposAustralia = default(GenericPmWithTdiInfo), bool? enabled = default(bool?), GenericPmWithTdiInfo girocard = default(GenericPmWithTdiInfo), GenericPmWithTdiInfo ideal = default(GenericPmWithTdiInfo), GenericPmWithTdiInfo interacCard = default(GenericPmWithTdiInfo), GenericPmWithTdiInfo jcb = default(GenericPmWithTdiInfo), GenericPmWithTdiInfo maestro = default(GenericPmWithTdiInfo), GenericPmWithTdiInfo mc = default(GenericPmWithTdiInfo), List<string> storeIds = default(List<string>), GenericPmWithTdiInfo visa = default(GenericPmWithTdiInfo))
        {
            this.Bcmc = bcmc;
            this.CartesBancaires = cartesBancaires;
            this.Countries = countries;
            this.Cup = cup;
            this.Currencies = currencies;
            this.Diners = diners;
            this.Discover = discover;
            this.EftposAustralia = eftposAustralia;
            this.Enabled = enabled;
            this.Girocard = girocard;
            this.Ideal = ideal;
            this.InteracCard = interacCard;
            this.Jcb = jcb;
            this.Maestro = maestro;
            this.Mc = mc;
            this.StoreIds = storeIds;
            this.Visa = visa;
        }

        /// <summary>
        /// Gets or Sets Bcmc
        /// </summary>
        [DataMember(Name = "bcmc", EmitDefaultValue = false)]
        public BcmcInfo Bcmc { get; set; }

        /// <summary>
        /// Gets or Sets CartesBancaires
        /// </summary>
        [DataMember(Name = "cartesBancaires", EmitDefaultValue = false)]
        public CartesBancairesInfo CartesBancaires { get; set; }

        /// <summary>
        /// The list of countries where a payment method is available. By default, all countries supported by the payment method.
        /// </summary>
        /// <value>The list of countries where a payment method is available. By default, all countries supported by the payment method.</value>
        [DataMember(Name = "countries", EmitDefaultValue = false)]
        public List<string> Countries { get; set; }

        /// <summary>
        /// Gets or Sets Cup
        /// </summary>
        [DataMember(Name = "cup", EmitDefaultValue = false)]
        public GenericPmWithTdiInfo Cup { get; set; }

        /// <summary>
        /// The list of currencies that a payment method supports. By default, all currencies supported by the payment method.
        /// </summary>
        /// <value>The list of currencies that a payment method supports. By default, all currencies supported by the payment method.</value>
        [DataMember(Name = "currencies", EmitDefaultValue = false)]
        public List<string> Currencies { get; set; }

        /// <summary>
        /// Gets or Sets Diners
        /// </summary>
        [DataMember(Name = "diners", EmitDefaultValue = false)]
        public GenericPmWithTdiInfo Diners { get; set; }

        /// <summary>
        /// Gets or Sets Discover
        /// </summary>
        [DataMember(Name = "discover", EmitDefaultValue = false)]
        public GenericPmWithTdiInfo Discover { get; set; }

        /// <summary>
        /// Gets or Sets EftposAustralia
        /// </summary>
        [DataMember(Name = "eftpos_australia", EmitDefaultValue = false)]
        public GenericPmWithTdiInfo EftposAustralia { get; set; }

        /// <summary>
        /// Indicates whether the payment method is enabled (**true**) or disabled (**false**).
        /// </summary>
        /// <value>Indicates whether the payment method is enabled (**true**) or disabled (**false**).</value>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Girocard
        /// </summary>
        [DataMember(Name = "girocard", EmitDefaultValue = false)]
        public GenericPmWithTdiInfo Girocard { get; set; }

        /// <summary>
        /// Gets or Sets Ideal
        /// </summary>
        [DataMember(Name = "ideal", EmitDefaultValue = false)]
        public GenericPmWithTdiInfo Ideal { get; set; }

        /// <summary>
        /// Gets or Sets InteracCard
        /// </summary>
        [DataMember(Name = "interac_card", EmitDefaultValue = false)]
        public GenericPmWithTdiInfo InteracCard { get; set; }

        /// <summary>
        /// Gets or Sets Jcb
        /// </summary>
        [DataMember(Name = "jcb", EmitDefaultValue = false)]
        public GenericPmWithTdiInfo Jcb { get; set; }

        /// <summary>
        /// Gets or Sets Maestro
        /// </summary>
        [DataMember(Name = "maestro", EmitDefaultValue = false)]
        public GenericPmWithTdiInfo Maestro { get; set; }

        /// <summary>
        /// Gets or Sets Mc
        /// </summary>
        [DataMember(Name = "mc", EmitDefaultValue = false)]
        public GenericPmWithTdiInfo Mc { get; set; }

        /// <summary>
        /// The list of stores for this payment method
        /// </summary>
        /// <value>The list of stores for this payment method</value>
        [DataMember(Name = "storeIds", EmitDefaultValue = false)]
        public List<string> StoreIds { get; set; }

        /// <summary>
        /// Gets or Sets Visa
        /// </summary>
        [DataMember(Name = "visa", EmitDefaultValue = false)]
        public GenericPmWithTdiInfo Visa { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdatePaymentMethodInfo {\n");
            sb.Append("  Bcmc: ").Append(Bcmc).Append("\n");
            sb.Append("  CartesBancaires: ").Append(CartesBancaires).Append("\n");
            sb.Append("  Countries: ").Append(Countries).Append("\n");
            sb.Append("  Cup: ").Append(Cup).Append("\n");
            sb.Append("  Currencies: ").Append(Currencies).Append("\n");
            sb.Append("  Diners: ").Append(Diners).Append("\n");
            sb.Append("  Discover: ").Append(Discover).Append("\n");
            sb.Append("  EftposAustralia: ").Append(EftposAustralia).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Girocard: ").Append(Girocard).Append("\n");
            sb.Append("  Ideal: ").Append(Ideal).Append("\n");
            sb.Append("  InteracCard: ").Append(InteracCard).Append("\n");
            sb.Append("  Jcb: ").Append(Jcb).Append("\n");
            sb.Append("  Maestro: ").Append(Maestro).Append("\n");
            sb.Append("  Mc: ").Append(Mc).Append("\n");
            sb.Append("  StoreIds: ").Append(StoreIds).Append("\n");
            sb.Append("  Visa: ").Append(Visa).Append("\n");
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
            return this.Equals(input as UpdatePaymentMethodInfo);
        }

        /// <summary>
        /// Returns true if UpdatePaymentMethodInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdatePaymentMethodInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdatePaymentMethodInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Bcmc == input.Bcmc ||
                    (this.Bcmc != null &&
                    this.Bcmc.Equals(input.Bcmc))
                ) && 
                (
                    this.CartesBancaires == input.CartesBancaires ||
                    (this.CartesBancaires != null &&
                    this.CartesBancaires.Equals(input.CartesBancaires))
                ) && 
                (
                    this.Countries == input.Countries ||
                    this.Countries != null &&
                    input.Countries != null &&
                    this.Countries.SequenceEqual(input.Countries)
                ) && 
                (
                    this.Cup == input.Cup ||
                    (this.Cup != null &&
                    this.Cup.Equals(input.Cup))
                ) && 
                (
                    this.Currencies == input.Currencies ||
                    this.Currencies != null &&
                    input.Currencies != null &&
                    this.Currencies.SequenceEqual(input.Currencies)
                ) && 
                (
                    this.Diners == input.Diners ||
                    (this.Diners != null &&
                    this.Diners.Equals(input.Diners))
                ) && 
                (
                    this.Discover == input.Discover ||
                    (this.Discover != null &&
                    this.Discover.Equals(input.Discover))
                ) && 
                (
                    this.EftposAustralia == input.EftposAustralia ||
                    (this.EftposAustralia != null &&
                    this.EftposAustralia.Equals(input.EftposAustralia))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.Girocard == input.Girocard ||
                    (this.Girocard != null &&
                    this.Girocard.Equals(input.Girocard))
                ) && 
                (
                    this.Ideal == input.Ideal ||
                    (this.Ideal != null &&
                    this.Ideal.Equals(input.Ideal))
                ) && 
                (
                    this.InteracCard == input.InteracCard ||
                    (this.InteracCard != null &&
                    this.InteracCard.Equals(input.InteracCard))
                ) && 
                (
                    this.Jcb == input.Jcb ||
                    (this.Jcb != null &&
                    this.Jcb.Equals(input.Jcb))
                ) && 
                (
                    this.Maestro == input.Maestro ||
                    (this.Maestro != null &&
                    this.Maestro.Equals(input.Maestro))
                ) && 
                (
                    this.Mc == input.Mc ||
                    (this.Mc != null &&
                    this.Mc.Equals(input.Mc))
                ) && 
                (
                    this.StoreIds == input.StoreIds ||
                    this.StoreIds != null &&
                    input.StoreIds != null &&
                    this.StoreIds.SequenceEqual(input.StoreIds)
                ) && 
                (
                    this.Visa == input.Visa ||
                    (this.Visa != null &&
                    this.Visa.Equals(input.Visa))
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
                if (this.Bcmc != null)
                {
                    hashCode = (hashCode * 59) + this.Bcmc.GetHashCode();
                }
                if (this.CartesBancaires != null)
                {
                    hashCode = (hashCode * 59) + this.CartesBancaires.GetHashCode();
                }
                if (this.Countries != null)
                {
                    hashCode = (hashCode * 59) + this.Countries.GetHashCode();
                }
                if (this.Cup != null)
                {
                    hashCode = (hashCode * 59) + this.Cup.GetHashCode();
                }
                if (this.Currencies != null)
                {
                    hashCode = (hashCode * 59) + this.Currencies.GetHashCode();
                }
                if (this.Diners != null)
                {
                    hashCode = (hashCode * 59) + this.Diners.GetHashCode();
                }
                if (this.Discover != null)
                {
                    hashCode = (hashCode * 59) + this.Discover.GetHashCode();
                }
                if (this.EftposAustralia != null)
                {
                    hashCode = (hashCode * 59) + this.EftposAustralia.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                if (this.Girocard != null)
                {
                    hashCode = (hashCode * 59) + this.Girocard.GetHashCode();
                }
                if (this.Ideal != null)
                {
                    hashCode = (hashCode * 59) + this.Ideal.GetHashCode();
                }
                if (this.InteracCard != null)
                {
                    hashCode = (hashCode * 59) + this.InteracCard.GetHashCode();
                }
                if (this.Jcb != null)
                {
                    hashCode = (hashCode * 59) + this.Jcb.GetHashCode();
                }
                if (this.Maestro != null)
                {
                    hashCode = (hashCode * 59) + this.Maestro.GetHashCode();
                }
                if (this.Mc != null)
                {
                    hashCode = (hashCode * 59) + this.Mc.GetHashCode();
                }
                if (this.StoreIds != null)
                {
                    hashCode = (hashCode * 59) + this.StoreIds.GetHashCode();
                }
                if (this.Visa != null)
                {
                    hashCode = (hashCode * 59) + this.Visa.GetHashCode();
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
