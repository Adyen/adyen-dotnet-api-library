using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// UltimateParentCompanyBusinessDetails
    /// </summary>
    [DataContract(Name = "UltimateParentCompanyBusinessDetails")]
    public class UltimateParentCompanyBusinessDetails : IEquatable<UltimateParentCompanyBusinessDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UltimateParentCompanyBusinessDetails" /> class.
        /// </summary>
        /// <param name="legalBusinessName">The legal name of the company..</param>
        /// <param name="registrationNumber">The registration number of the company..</param>
        /// <param name="stockExchange">Market Identifier Code (MIC)..</param>
        /// <param name="stockNumber">International Securities Identification Number (ISIN)..</param>
        /// <param name="stockTicker">Stock Ticker symbol..</param>
        public UltimateParentCompanyBusinessDetails(string legalBusinessName = default(string), string registrationNumber = default(string), string stockExchange = default(string), string stockNumber = default(string), string stockTicker = default(string))
        {
            LegalBusinessName = legalBusinessName;
            RegistrationNumber = registrationNumber;
            StockExchange = stockExchange;
            StockNumber = stockNumber;
            StockTicker = stockTicker;
        }

        /// <summary>
        /// The legal name of the company.
        /// </summary>
        /// <value>The legal name of the company.</value>
        [DataMember(Name = "legalBusinessName", EmitDefaultValue = false)]
        public string LegalBusinessName { get; set; }

        /// <summary>
        /// The registration number of the company.
        /// </summary>
        /// <value>The registration number of the company.</value>
        [DataMember(Name = "registrationNumber", EmitDefaultValue = false)]
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// Market Identifier Code (MIC).
        /// </summary>
        /// <value>Market Identifier Code (MIC).</value>
        [DataMember(Name = "stockExchange", EmitDefaultValue = false)]
        public string StockExchange { get; set; }

        /// <summary>
        /// International Securities Identification Number (ISIN).
        /// </summary>
        /// <value>International Securities Identification Number (ISIN).</value>
        [DataMember(Name = "stockNumber", EmitDefaultValue = false)]
        public string StockNumber { get; set; }

        /// <summary>
        /// Stock Ticker symbol.
        /// </summary>
        /// <value>Stock Ticker symbol.</value>
        [DataMember(Name = "stockTicker", EmitDefaultValue = false)]
        public string StockTicker { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UltimateParentCompanyBusinessDetails {\n");
            sb.Append("  LegalBusinessName: ").Append(LegalBusinessName).Append("\n");
            sb.Append("  RegistrationNumber: ").Append(RegistrationNumber).Append("\n");
            sb.Append("  StockExchange: ").Append(StockExchange).Append("\n");
            sb.Append("  StockNumber: ").Append(StockNumber).Append("\n");
            sb.Append("  StockTicker: ").Append(StockTicker).Append("\n");
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
            return Equals(input as UltimateParentCompanyBusinessDetails);
        }

        /// <summary>
        /// Returns true if UltimateParentCompanyBusinessDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of UltimateParentCompanyBusinessDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UltimateParentCompanyBusinessDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    LegalBusinessName == input.LegalBusinessName ||
                    (LegalBusinessName != null &&
                    LegalBusinessName.Equals(input.LegalBusinessName))
                ) &&
                (
                    RegistrationNumber == input.RegistrationNumber ||
                    (RegistrationNumber != null &&
                    RegistrationNumber.Equals(input.RegistrationNumber))
                ) &&
                (
                    StockExchange == input.StockExchange ||
                    (StockExchange != null &&
                    StockExchange.Equals(input.StockExchange))
                ) &&
                (
                    StockNumber == input.StockNumber ||
                    (StockNumber != null &&
                    StockNumber.Equals(input.StockNumber))
                ) &&
                (
                    StockTicker == input.StockTicker ||
                    (StockTicker != null &&
                    StockTicker.Equals(input.StockTicker))
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
                if (LegalBusinessName != null)
                    hashCode = hashCode * 59 + LegalBusinessName.GetHashCode();
                if (RegistrationNumber != null)
                    hashCode = hashCode * 59 + RegistrationNumber.GetHashCode();
                if (StockExchange != null)
                    hashCode = hashCode * 59 + StockExchange.GetHashCode();
                if (StockNumber != null)
                    hashCode = hashCode * 59 + StockNumber.GetHashCode();
                if (StockTicker != null)
                    hashCode = hashCode * 59 + StockTicker.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
