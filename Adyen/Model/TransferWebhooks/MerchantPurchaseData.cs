/*
* Transfer webhooks
*
*
* The version of the OpenAPI document: 4
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

namespace Adyen.Model.TransferWebhooks
{
    /// <summary>
    /// MerchantPurchaseData
    /// </summary>
    [DataContract(Name = "MerchantPurchaseData")]
    public partial class MerchantPurchaseData : IEquatable<MerchantPurchaseData>, IValidatableObject
    {
        /// <summary>
        /// The type of events data.   Possible values:    - **merchantPurchaseData**: merchant purchase data
        /// </summary>
        /// <value>The type of events data.   Possible values:    - **merchantPurchaseData**: merchant purchase data</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum MerchantPurchaseData for value: merchantPurchaseData
            /// </summary>
            [EnumMember(Value = "merchantPurchaseData")]
            MerchantPurchaseData = 1

        }


        /// <summary>
        /// The type of events data.   Possible values:    - **merchantPurchaseData**: merchant purchase data
        /// </summary>
        /// <value>The type of events data.   Possible values:    - **merchantPurchaseData**: merchant purchase data</value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantPurchaseData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MerchantPurchaseData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantPurchaseData" /> class.
        /// </summary>
        /// <param name="airline">airline.</param>
        /// <param name="lodging">Lodging information..</param>
        /// <param name="type">The type of events data.   Possible values:    - **merchantPurchaseData**: merchant purchase data (required) (default to TypeEnum.MerchantPurchaseData).</param>
        public MerchantPurchaseData(Airline airline = default(Airline), List<Lodging> lodging = default(List<Lodging>), TypeEnum type = TypeEnum.MerchantPurchaseData)
        {
            this.Type = type;
            this.Airline = airline;
            this.Lodging = lodging;
        }

        /// <summary>
        /// Gets or Sets Airline
        /// </summary>
        [DataMember(Name = "airline", EmitDefaultValue = false)]
        public Airline Airline { get; set; }

        /// <summary>
        /// Lodging information.
        /// </summary>
        /// <value>Lodging information.</value>
        [DataMember(Name = "lodging", EmitDefaultValue = false)]
        public List<Lodging> Lodging { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MerchantPurchaseData {\n");
            sb.Append("  Airline: ").Append(Airline).Append("\n");
            sb.Append("  Lodging: ").Append(Lodging).Append("\n");
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
            return this.Equals(input as MerchantPurchaseData);
        }

        /// <summary>
        /// Returns true if MerchantPurchaseData instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantPurchaseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantPurchaseData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Airline == input.Airline ||
                    (this.Airline != null &&
                    this.Airline.Equals(input.Airline))
                ) && 
                (
                    this.Lodging == input.Lodging ||
                    this.Lodging != null &&
                    input.Lodging != null &&
                    this.Lodging.SequenceEqual(input.Lodging)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.Airline != null)
                {
                    hashCode = (hashCode * 59) + this.Airline.GetHashCode();
                }
                if (this.Lodging != null)
                {
                    hashCode = (hashCode * 59) + this.Lodging.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
