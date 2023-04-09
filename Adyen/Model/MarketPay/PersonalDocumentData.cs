using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// PersonalDocumentData
    /// </summary>
    [DataContract]
        public class PersonalDocumentData :  IEquatable<PersonalDocumentData>, IValidatableObject
    {
        /// <summary>
        /// The type of the document. More then one item pert type does not allowed. Valid values: ID, PASSPORT, VISA, DRIVINGLICENSE
        /// </summary>
        /// <value>The type of the document. More then one item pert type does not allowed. Valid values: ID, PASSPORT, VISA, DRIVINGLICENSE</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum DRIVINGLICENSE for value: DRIVINGLICENSE
            /// </summary>
            [EnumMember(Value = "DRIVINGLICENSE")]
            DRIVINGLICENSE = 1,
            /// <summary>
            /// Enum ID for value: ID
            /// </summary>
            [EnumMember(Value = "ID")]
            ID = 2,
            /// <summary>
            /// Enum PASSPORT for value: PASSPORT
            /// </summary>
            [EnumMember(Value = "PASSPORT")]
            PASSPORT = 3,
            /// <summary>
            /// Enum SOCIALSECURITY for value: SOCIALSECURITY
            /// </summary>
            [EnumMember(Value = "SOCIALSECURITY")]
            SOCIALSECURITY = 4,
            /// <summary>
            /// Enum VISA for value: VISA
            /// </summary>
            [EnumMember(Value = "VISA")]
            VISA = 5        }
        /// <summary>
        /// The type of the document. More then one item pert type does not allowed. Valid values: ID, PASSPORT, VISA, DRIVINGLICENSE
        /// </summary>
        /// <value>The type of the document. More then one item pert type does not allowed. Valid values: ID, PASSPORT, VISA, DRIVINGLICENSE</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalDocumentData" /> class.
        /// </summary>
        /// <param name="expirationDate">The expiration date of the document. The date should be in ISO-8601 format yyyy-mm-dd (e.g. 2000-01-31)..</param>
        /// <param name="issuerCountry">The two-character country code of the issuer. &gt;The permitted country codes are defined in ISO-3166-1 alpha-2 (e.g. &#x27;NL&#x27;)..</param>
        /// <param name="issuerState">The state issued the document (if applicable).</param>
        /// <param name="number">The number of the document. Delete the given type if the value empty. (required).</param>
        /// <param name="type">The type of the document. More then one item pert type does not allowed. Valid values: ID, PASSPORT, VISA, DRIVINGLICENSE (required).</param>
        public PersonalDocumentData(string expirationDate = default(string), string issuerCountry = default(string), string issuerState = default(string), string number = default(string), TypeEnum type = default(TypeEnum))
        {
            // to ensure "number" is required (not null)
            if (number == null)
            {
                throw new InvalidDataException("number is a required property for PersonalDocumentData and cannot be null");
            }

            Number = number;

            Type = type;
            ExpirationDate = expirationDate;
            IssuerCountry = issuerCountry;
            IssuerState = issuerState;
        }
        
        /// <summary>
        /// The expiration date of the document. The date should be in ISO-8601 format yyyy-mm-dd (e.g. 2000-01-31).
        /// </summary>
        /// <value>The expiration date of the document. The date should be in ISO-8601 format yyyy-mm-dd (e.g. 2000-01-31).</value>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// The two-character country code of the issuer. &gt;The permitted country codes are defined in ISO-3166-1 alpha-2 (e.g. &#x27;NL&#x27;).
        /// </summary>
        /// <value>The two-character country code of the issuer. &gt;The permitted country codes are defined in ISO-3166-1 alpha-2 (e.g. &#x27;NL&#x27;).</value>
        [DataMember(Name="issuerCountry", EmitDefaultValue=false)]
        public string IssuerCountry { get; set; }

        /// <summary>
        /// The state issued the document (if applicable)
        /// </summary>
        /// <value>The state issued the document (if applicable)</value>
        [DataMember(Name="issuerState", EmitDefaultValue=false)]
        public string IssuerState { get; set; }

        /// <summary>
        /// The number of the document. Delete the given type if the value empty.
        /// </summary>
        /// <value>The number of the document. Delete the given type if the value empty.</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PersonalDocumentData {\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  IssuerCountry: ").Append(IssuerCountry).Append("\n");
            sb.Append("  IssuerState: ").Append(IssuerState).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as PersonalDocumentData);
        }

        /// <summary>
        /// Returns true if PersonalDocumentData instances are equal
        /// </summary>
        /// <param name="input">Instance of PersonalDocumentData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PersonalDocumentData input)
        {
            if (input == null)
                return false;

            return 
                (
                    ExpirationDate == input.ExpirationDate ||
                    (ExpirationDate != null &&
                    ExpirationDate.Equals(input.ExpirationDate))
                ) && 
                (
                    IssuerCountry == input.IssuerCountry ||
                    (IssuerCountry != null &&
                    IssuerCountry.Equals(input.IssuerCountry))
                ) && 
                (
                    IssuerState == input.IssuerState ||
                    (IssuerState != null &&
                    IssuerState.Equals(input.IssuerState))
                ) && 
                (
                    Number == input.Number ||
                    (Number != null &&
                    Number.Equals(input.Number))
                ) && 
                (
                    Type == input.Type ||
                    Type.Equals(input.Type)
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
                if (ExpirationDate != null)
                    hashCode = hashCode * 59 + ExpirationDate.GetHashCode();
                if (IssuerCountry != null)
                    hashCode = hashCode * 59 + IssuerCountry.GetHashCode();
                if (IssuerState != null)
                    hashCode = hashCode * 59 + IssuerState.GetHashCode();
                if (Number != null)
                    hashCode = hashCode * 59 + Number.GetHashCode();
                hashCode = hashCode * 59 + Type.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
