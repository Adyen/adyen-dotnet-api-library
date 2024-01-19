/*
* Adyen Terminal API
*
*
* The version of the OpenAPI document: 1
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

namespace Adyen.Model.Terminal
{
    /// <summary>
    /// TotalFilter
    /// </summary>
    [DataContract(Name = "TotalFilter")]
    public partial class TotalFilter : IEquatable<TotalFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TotalFilter" /> class.
        /// </summary>
        /// <param name="pOIID">pOIID.</param>
        /// <param name="saleID">saleID.</param>
        /// <param name="operatorID">operatorID.</param>
        /// <param name="shiftNumber">shiftNumber.</param>
        /// <param name="totalsGroupID">totalsGroupID.</param>
        public TotalFilter(string pOIID = default(string), string saleID = default(string), string operatorID = default(string), string shiftNumber = default(string), string totalsGroupID = default(string))
        {
            this.POIID = pOIID;
            this.SaleID = saleID;
            this.OperatorID = operatorID;
            this.ShiftNumber = shiftNumber;
            this.TotalsGroupID = totalsGroupID;
        }

        /// <summary>
        /// Gets or Sets POIID
        /// </summary>
        [DataMember(Name = "POIID", EmitDefaultValue = false)]
        public string POIID { get; set; }

        /// <summary>
        /// Gets or Sets SaleID
        /// </summary>
        [DataMember(Name = "SaleID", EmitDefaultValue = false)]
        public string SaleID { get; set; }

        /// <summary>
        /// Gets or Sets OperatorID
        /// </summary>
        [DataMember(Name = "OperatorID", EmitDefaultValue = false)]
        public string OperatorID { get; set; }

        /// <summary>
        /// Gets or Sets ShiftNumber
        /// </summary>
        [DataMember(Name = "ShiftNumber", EmitDefaultValue = false)]
        public string ShiftNumber { get; set; }

        /// <summary>
        /// Gets or Sets TotalsGroupID
        /// </summary>
        [DataMember(Name = "TotalsGroupID", EmitDefaultValue = false)]
        public string TotalsGroupID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TotalFilter {\n");
            sb.Append("  POIID: ").Append(POIID).Append("\n");
            sb.Append("  SaleID: ").Append(SaleID).Append("\n");
            sb.Append("  OperatorID: ").Append(OperatorID).Append("\n");
            sb.Append("  ShiftNumber: ").Append(ShiftNumber).Append("\n");
            sb.Append("  TotalsGroupID: ").Append(TotalsGroupID).Append("\n");
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
            return this.Equals(input as TotalFilter);
        }

        /// <summary>
        /// Returns true if TotalFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of TotalFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TotalFilter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.POIID == input.POIID ||
                    (this.POIID != null &&
                    this.POIID.Equals(input.POIID))
                ) && 
                (
                    this.SaleID == input.SaleID ||
                    (this.SaleID != null &&
                    this.SaleID.Equals(input.SaleID))
                ) && 
                (
                    this.OperatorID == input.OperatorID ||
                    (this.OperatorID != null &&
                    this.OperatorID.Equals(input.OperatorID))
                ) && 
                (
                    this.ShiftNumber == input.ShiftNumber ||
                    (this.ShiftNumber != null &&
                    this.ShiftNumber.Equals(input.ShiftNumber))
                ) && 
                (
                    this.TotalsGroupID == input.TotalsGroupID ||
                    (this.TotalsGroupID != null &&
                    this.TotalsGroupID.Equals(input.TotalsGroupID))
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
                if (this.POIID != null)
                {
                    hashCode = (hashCode * 59) + this.POIID.GetHashCode();
                }
                if (this.SaleID != null)
                {
                    hashCode = (hashCode * 59) + this.SaleID.GetHashCode();
                }
                if (this.OperatorID != null)
                {
                    hashCode = (hashCode * 59) + this.OperatorID.GetHashCode();
                }
                if (this.ShiftNumber != null)
                {
                    hashCode = (hashCode * 59) + this.ShiftNumber.GetHashCode();
                }
                if (this.TotalsGroupID != null)
                {
                    hashCode = (hashCode * 59) + this.TotalsGroupID.GetHashCode();
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
            // POIID (string) pattern
            Regex regexPOIID = new Regex(@"^.+$", RegexOptions.CultureInvariant);
            if (false == regexPOIID.Match(this.POIID).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for POIID, must match a pattern of " + regexPOIID, new [] { "POIID" });
            }

            // SaleID (string) pattern
            Regex regexSaleID = new Regex(@"^.+$", RegexOptions.CultureInvariant);
            if (false == regexSaleID.Match(this.SaleID).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SaleID, must match a pattern of " + regexSaleID, new [] { "SaleID" });
            }

            // OperatorID (string) pattern
            Regex regexOperatorID = new Regex(@"^.+$", RegexOptions.CultureInvariant);
            if (false == regexOperatorID.Match(this.OperatorID).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OperatorID, must match a pattern of " + regexOperatorID, new [] { "OperatorID" });
            }

            // ShiftNumber (string) pattern
            Regex regexShiftNumber = new Regex(@"^.+$", RegexOptions.CultureInvariant);
            if (false == regexShiftNumber.Match(this.ShiftNumber).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShiftNumber, must match a pattern of " + regexShiftNumber, new [] { "ShiftNumber" });
            }

            // TotalsGroupID (string) pattern
            Regex regexTotalsGroupID = new Regex(@"^.{1,16}$", RegexOptions.CultureInvariant);
            if (false == regexTotalsGroupID.Match(this.TotalsGroupID).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TotalsGroupID, must match a pattern of " + regexTotalsGroupID, new [] { "TotalsGroupID" });
            }

            yield break;
        }
    }

}
