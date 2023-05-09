/*
* Configuration API
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

namespace Adyen.Model.BalancePlatform
{
    /// <summary>
    /// TransactionRuleRestrictions
    /// </summary>
    [DataContract(Name = "TransactionRuleRestrictions")]
    public partial class TransactionRuleRestrictions : IEquatable<TransactionRuleRestrictions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionRuleRestrictions" /> class.
        /// </summary>
        /// <param name="activeNetworkTokens">activeNetworkTokens.</param>
        /// <param name="brandVariants">brandVariants.</param>
        /// <param name="countries">countries.</param>
        /// <param name="dayOfWeek">dayOfWeek.</param>
        /// <param name="differentCurrencies">differentCurrencies.</param>
        /// <param name="entryModes">entryModes.</param>
        /// <param name="internationalTransaction">internationalTransaction.</param>
        /// <param name="matchingTransactions">matchingTransactions.</param>
        /// <param name="mccs">mccs.</param>
        /// <param name="merchantNames">merchantNames.</param>
        /// <param name="merchants">merchants.</param>
        /// <param name="processingTypes">processingTypes.</param>
        /// <param name="timeOfDay">timeOfDay.</param>
        /// <param name="totalAmount">totalAmount.</param>
        public TransactionRuleRestrictions(ActiveNetworkTokensRestriction activeNetworkTokens = default(ActiveNetworkTokensRestriction), BrandVariantsRestriction brandVariants = default(BrandVariantsRestriction), CountriesRestriction countries = default(CountriesRestriction), DayOfWeekRestriction dayOfWeek = default(DayOfWeekRestriction), DifferentCurrenciesRestriction differentCurrencies = default(DifferentCurrenciesRestriction), EntryModesRestriction entryModes = default(EntryModesRestriction), InternationalTransactionRestriction internationalTransaction = default(InternationalTransactionRestriction), MatchingTransactionsRestriction matchingTransactions = default(MatchingTransactionsRestriction), MccsRestriction mccs = default(MccsRestriction), MerchantNamesRestriction merchantNames = default(MerchantNamesRestriction), MerchantsRestriction merchants = default(MerchantsRestriction), ProcessingTypesRestriction processingTypes = default(ProcessingTypesRestriction), TimeOfDayRestriction timeOfDay = default(TimeOfDayRestriction), TotalAmountRestriction totalAmount = default(TotalAmountRestriction))
        {
            this.ActiveNetworkTokens = activeNetworkTokens;
            this.BrandVariants = brandVariants;
            this.Countries = countries;
            this.DayOfWeek = dayOfWeek;
            this.DifferentCurrencies = differentCurrencies;
            this.EntryModes = entryModes;
            this.InternationalTransaction = internationalTransaction;
            this.MatchingTransactions = matchingTransactions;
            this.Mccs = mccs;
            this.MerchantNames = merchantNames;
            this.Merchants = merchants;
            this.ProcessingTypes = processingTypes;
            this.TimeOfDay = timeOfDay;
            this.TotalAmount = totalAmount;
        }

        /// <summary>
        /// Gets or Sets ActiveNetworkTokens
        /// </summary>
        [DataMember(Name = "activeNetworkTokens", EmitDefaultValue = false)]
        public ActiveNetworkTokensRestriction ActiveNetworkTokens { get; set; }

        /// <summary>
        /// Gets or Sets BrandVariants
        /// </summary>
        [DataMember(Name = "brandVariants", EmitDefaultValue = false)]
        public BrandVariantsRestriction BrandVariants { get; set; }

        /// <summary>
        /// Gets or Sets Countries
        /// </summary>
        [DataMember(Name = "countries", EmitDefaultValue = false)]
        public CountriesRestriction Countries { get; set; }

        /// <summary>
        /// Gets or Sets DayOfWeek
        /// </summary>
        [DataMember(Name = "dayOfWeek", EmitDefaultValue = false)]
        public DayOfWeekRestriction DayOfWeek { get; set; }

        /// <summary>
        /// Gets or Sets DifferentCurrencies
        /// </summary>
        [DataMember(Name = "differentCurrencies", EmitDefaultValue = false)]
        public DifferentCurrenciesRestriction DifferentCurrencies { get; set; }

        /// <summary>
        /// Gets or Sets EntryModes
        /// </summary>
        [DataMember(Name = "entryModes", EmitDefaultValue = false)]
        public EntryModesRestriction EntryModes { get; set; }

        /// <summary>
        /// Gets or Sets InternationalTransaction
        /// </summary>
        [DataMember(Name = "internationalTransaction", EmitDefaultValue = false)]
        public InternationalTransactionRestriction InternationalTransaction { get; set; }

        /// <summary>
        /// Gets or Sets MatchingTransactions
        /// </summary>
        [DataMember(Name = "matchingTransactions", EmitDefaultValue = false)]
        public MatchingTransactionsRestriction MatchingTransactions { get; set; }

        /// <summary>
        /// Gets or Sets Mccs
        /// </summary>
        [DataMember(Name = "mccs", EmitDefaultValue = false)]
        public MccsRestriction Mccs { get; set; }

        /// <summary>
        /// Gets or Sets MerchantNames
        /// </summary>
        [DataMember(Name = "merchantNames", EmitDefaultValue = false)]
        public MerchantNamesRestriction MerchantNames { get; set; }

        /// <summary>
        /// Gets or Sets Merchants
        /// </summary>
        [DataMember(Name = "merchants", EmitDefaultValue = false)]
        public MerchantsRestriction Merchants { get; set; }

        /// <summary>
        /// Gets or Sets ProcessingTypes
        /// </summary>
        [DataMember(Name = "processingTypes", EmitDefaultValue = false)]
        public ProcessingTypesRestriction ProcessingTypes { get; set; }

        /// <summary>
        /// Gets or Sets TimeOfDay
        /// </summary>
        [DataMember(Name = "timeOfDay", EmitDefaultValue = false)]
        public TimeOfDayRestriction TimeOfDay { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmount
        /// </summary>
        [DataMember(Name = "totalAmount", EmitDefaultValue = false)]
        public TotalAmountRestriction TotalAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionRuleRestrictions {\n");
            sb.Append("  ActiveNetworkTokens: ").Append(ActiveNetworkTokens).Append("\n");
            sb.Append("  BrandVariants: ").Append(BrandVariants).Append("\n");
            sb.Append("  Countries: ").Append(Countries).Append("\n");
            sb.Append("  DayOfWeek: ").Append(DayOfWeek).Append("\n");
            sb.Append("  DifferentCurrencies: ").Append(DifferentCurrencies).Append("\n");
            sb.Append("  EntryModes: ").Append(EntryModes).Append("\n");
            sb.Append("  InternationalTransaction: ").Append(InternationalTransaction).Append("\n");
            sb.Append("  MatchingTransactions: ").Append(MatchingTransactions).Append("\n");
            sb.Append("  Mccs: ").Append(Mccs).Append("\n");
            sb.Append("  MerchantNames: ").Append(MerchantNames).Append("\n");
            sb.Append("  Merchants: ").Append(Merchants).Append("\n");
            sb.Append("  ProcessingTypes: ").Append(ProcessingTypes).Append("\n");
            sb.Append("  TimeOfDay: ").Append(TimeOfDay).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
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
            return this.Equals(input as TransactionRuleRestrictions);
        }

        /// <summary>
        /// Returns true if TransactionRuleRestrictions instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionRuleRestrictions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionRuleRestrictions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActiveNetworkTokens == input.ActiveNetworkTokens ||
                    (this.ActiveNetworkTokens != null &&
                    this.ActiveNetworkTokens.Equals(input.ActiveNetworkTokens))
                ) && 
                (
                    this.BrandVariants == input.BrandVariants ||
                    (this.BrandVariants != null &&
                    this.BrandVariants.Equals(input.BrandVariants))
                ) && 
                (
                    this.Countries == input.Countries ||
                    (this.Countries != null &&
                    this.Countries.Equals(input.Countries))
                ) && 
                (
                    this.DayOfWeek == input.DayOfWeek ||
                    (this.DayOfWeek != null &&
                    this.DayOfWeek.Equals(input.DayOfWeek))
                ) && 
                (
                    this.DifferentCurrencies == input.DifferentCurrencies ||
                    (this.DifferentCurrencies != null &&
                    this.DifferentCurrencies.Equals(input.DifferentCurrencies))
                ) && 
                (
                    this.EntryModes == input.EntryModes ||
                    (this.EntryModes != null &&
                    this.EntryModes.Equals(input.EntryModes))
                ) && 
                (
                    this.InternationalTransaction == input.InternationalTransaction ||
                    (this.InternationalTransaction != null &&
                    this.InternationalTransaction.Equals(input.InternationalTransaction))
                ) && 
                (
                    this.MatchingTransactions == input.MatchingTransactions ||
                    (this.MatchingTransactions != null &&
                    this.MatchingTransactions.Equals(input.MatchingTransactions))
                ) && 
                (
                    this.Mccs == input.Mccs ||
                    (this.Mccs != null &&
                    this.Mccs.Equals(input.Mccs))
                ) && 
                (
                    this.MerchantNames == input.MerchantNames ||
                    (this.MerchantNames != null &&
                    this.MerchantNames.Equals(input.MerchantNames))
                ) && 
                (
                    this.Merchants == input.Merchants ||
                    (this.Merchants != null &&
                    this.Merchants.Equals(input.Merchants))
                ) && 
                (
                    this.ProcessingTypes == input.ProcessingTypes ||
                    (this.ProcessingTypes != null &&
                    this.ProcessingTypes.Equals(input.ProcessingTypes))
                ) && 
                (
                    this.TimeOfDay == input.TimeOfDay ||
                    (this.TimeOfDay != null &&
                    this.TimeOfDay.Equals(input.TimeOfDay))
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
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
                if (this.ActiveNetworkTokens != null)
                {
                    hashCode = (hashCode * 59) + this.ActiveNetworkTokens.GetHashCode();
                }
                if (this.BrandVariants != null)
                {
                    hashCode = (hashCode * 59) + this.BrandVariants.GetHashCode();
                }
                if (this.Countries != null)
                {
                    hashCode = (hashCode * 59) + this.Countries.GetHashCode();
                }
                if (this.DayOfWeek != null)
                {
                    hashCode = (hashCode * 59) + this.DayOfWeek.GetHashCode();
                }
                if (this.DifferentCurrencies != null)
                {
                    hashCode = (hashCode * 59) + this.DifferentCurrencies.GetHashCode();
                }
                if (this.EntryModes != null)
                {
                    hashCode = (hashCode * 59) + this.EntryModes.GetHashCode();
                }
                if (this.InternationalTransaction != null)
                {
                    hashCode = (hashCode * 59) + this.InternationalTransaction.GetHashCode();
                }
                if (this.MatchingTransactions != null)
                {
                    hashCode = (hashCode * 59) + this.MatchingTransactions.GetHashCode();
                }
                if (this.Mccs != null)
                {
                    hashCode = (hashCode * 59) + this.Mccs.GetHashCode();
                }
                if (this.MerchantNames != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantNames.GetHashCode();
                }
                if (this.Merchants != null)
                {
                    hashCode = (hashCode * 59) + this.Merchants.GetHashCode();
                }
                if (this.ProcessingTypes != null)
                {
                    hashCode = (hashCode * 59) + this.ProcessingTypes.GetHashCode();
                }
                if (this.TimeOfDay != null)
                {
                    hashCode = (hashCode * 59) + this.TimeOfDay.GetHashCode();
                }
                if (this.TotalAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalAmount.GetHashCode();
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