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
    /// It conveys Information related to the target POI for which the diagnosis is requested. Content of the Diagnosis Request message.
    /// </summary>
    [DataContract(Name = "DiagnosisRequest")]
    public partial class DiagnosisRequest : IEquatable<DiagnosisRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosisRequest" /> class.
        /// </summary>
        /// <param name="pOIID">MessageHeader.POIID..</param>
        /// <param name="hostDiagnosisFlag">Indicates if Host Diagnosis are required. (default to false).</param>
        /// <param name="acquirerID">acquirerID.</param>
        public DiagnosisRequest(string pOIID = default(string), bool? hostDiagnosisFlag = false, List<int> acquirerID = default(List<int>))
        {
            this.POIID = pOIID;
            this.HostDiagnosisFlag = hostDiagnosisFlag;
            this.AcquirerID = acquirerID;
        }

        /// <summary>
        /// MessageHeader.POIID.
        /// </summary>
        /// <value>MessageHeader.POIID.</value>
        [DataMember(Name = "POIID", EmitDefaultValue = false)]
        public string POIID { get; set; }

        /// <summary>
        /// Indicates if Host Diagnosis are required.
        /// </summary>
        /// <value>Indicates if Host Diagnosis are required.</value>
        [DataMember(Name = "HostDiagnosisFlag", EmitDefaultValue = false)]
        public bool? HostDiagnosisFlag { get; set; }

        /// <summary>
        /// Gets or Sets AcquirerID
        /// </summary>
        [DataMember(Name = "AcquirerID", EmitDefaultValue = false)]
        public List<int> AcquirerID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DiagnosisRequest {\n");
            sb.Append("  POIID: ").Append(POIID).Append("\n");
            sb.Append("  HostDiagnosisFlag: ").Append(HostDiagnosisFlag).Append("\n");
            sb.Append("  AcquirerID: ").Append(AcquirerID).Append("\n");
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
            return this.Equals(input as DiagnosisRequest);
        }

        /// <summary>
        /// Returns true if DiagnosisRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DiagnosisRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiagnosisRequest input)
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
                    this.HostDiagnosisFlag == input.HostDiagnosisFlag ||
                    this.HostDiagnosisFlag.Equals(input.HostDiagnosisFlag)
                ) && 
                (
                    this.AcquirerID == input.AcquirerID ||
                    this.AcquirerID != null &&
                    input.AcquirerID != null &&
                    this.AcquirerID.SequenceEqual(input.AcquirerID)
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
                hashCode = (hashCode * 59) + this.HostDiagnosisFlag.GetHashCode();
                if (this.AcquirerID != null)
                {
                    hashCode = (hashCode * 59) + this.AcquirerID.GetHashCode();
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

            yield break;
        }
    }

}
