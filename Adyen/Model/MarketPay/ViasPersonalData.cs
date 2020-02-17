#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// ViasPersonalData
    /// </summary>
    [DataContract]
        public partial class ViasPersonalData :  IEquatable<ViasPersonalData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViasPersonalData" /> class.
        /// </summary>
        /// <param name="dateOfBirth">The date of birth of the person. The date should be in ISO-8601 format yyyy-mm-dd (e.g. 2000-01-31)..</param>
        /// <param name="documentData">Key value pairs of document type and identify numbers.</param>
        /// <param name="nationality">The nationality of the person represented by a two-character country code. &gt;The permitted country codes are defined in ISO-3166-1 alpha-2 (e.g. &#x27;NL&#x27;)..</param>
        public ViasPersonalData(string dateOfBirth = default(string), List<PersonalDocumentData> documentData = default(List<PersonalDocumentData>), string nationality = default(string))
        {
            this.DateOfBirth = dateOfBirth;
            this.DocumentData = documentData;
            this.Nationality = nationality;
        }
        
        /// <summary>
        /// The date of birth of the person. The date should be in ISO-8601 format yyyy-mm-dd (e.g. 2000-01-31).
        /// </summary>
        /// <value>The date of birth of the person. The date should be in ISO-8601 format yyyy-mm-dd (e.g. 2000-01-31).</value>
        [DataMember(Name="dateOfBirth", EmitDefaultValue=false)]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Key value pairs of document type and identify numbers
        /// </summary>
        /// <value>Key value pairs of document type and identify numbers</value>
        [DataMember(Name="documentData", EmitDefaultValue=false)]
        public List<PersonalDocumentData> DocumentData { get; set; }

        /// <summary>
        /// The nationality of the person represented by a two-character country code. &gt;The permitted country codes are defined in ISO-3166-1 alpha-2 (e.g. &#x27;NL&#x27;).
        /// </summary>
        /// <value>The nationality of the person represented by a two-character country code. &gt;The permitted country codes are defined in ISO-3166-1 alpha-2 (e.g. &#x27;NL&#x27;).</value>
        [DataMember(Name="nationality", EmitDefaultValue=false)]
        public string Nationality { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ViasPersonalData {\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  DocumentData: ").Append(DocumentData).Append("\n");
            sb.Append("  Nationality: ").Append(Nationality).Append("\n");
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
            return this.Equals(input as ViasPersonalData);
        }

        /// <summary>
        /// Returns true if ViasPersonalData instances are equal
        /// </summary>
        /// <param name="input">Instance of ViasPersonalData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViasPersonalData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DateOfBirth == input.DateOfBirth ||
                    (this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(input.DateOfBirth))
                ) && 
                (
                    this.DocumentData == input.DocumentData ||
                    this.DocumentData != null &&
                    input.DocumentData != null &&
                    this.DocumentData.SequenceEqual(input.DocumentData)
                ) && 
                (
                    this.Nationality == input.Nationality ||
                    (this.Nationality != null &&
                    this.Nationality.Equals(input.Nationality))
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
                if (this.DateOfBirth != null)
                    hashCode = hashCode * 59 + this.DateOfBirth.GetHashCode();
                if (this.DocumentData != null)
                    hashCode = hashCode * 59 + this.DocumentData.GetHashCode();
                if (this.Nationality != null)
                    hashCode = hashCode * 59 + this.Nationality.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
