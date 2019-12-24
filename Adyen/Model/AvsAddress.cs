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
//  * Copyright (c) 2019 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Adyen.Model
{
    /// <summary>
    /// AvsAddress
    /// </summary>
    [DataContract]
    public partial class AvsAddress :  IEquatable<AvsAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvsAddress" /> class.
        /// </summary>
        [JsonConstructor]
        protected AvsAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AvsAddress" /> class.
        /// </summary>
        /// <param name="Zip">the zip or post code of the address.</param>
        /// <param name="StreetAddress">the street and house number of the address (required).</param>
        public AvsAddress(string Zip = default(string), string StreetAddress = default(string))
        {
            // to ensure "StreetAddress" is required (not null)
            if (StreetAddress == null)
            {
                throw new InvalidDataException("StreetAddress is a required property for AvsAddress and cannot be null");
            }
            else
            {
                this.StreetAddress = StreetAddress;
            }
            this.Zip = Zip;
        }
        
        /// <summary>
        /// the zip or post code of the address
        /// </summary>
        /// <value>the zip or post code of the address</value>
        [DataMember(Name="zip", EmitDefaultValue=false)]
        public string Zip { get; set; }

        /// <summary>
        /// the street and house number of the address
        /// </summary>
        /// <value>the street and house number of the address</value>
        [DataMember(Name="streetAddress", EmitDefaultValue=false)]
        public string StreetAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvsAddress {\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  StreetAddress: ").Append(StreetAddress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AvsAddress);
        }

        /// <summary>
        /// Returns true if AvsAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of AvsAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvsAddress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Zip == other.Zip ||
                    this.Zip != null &&
                    this.Zip.Equals(other.Zip)
                ) && 
                (
                    this.StreetAddress == other.StreetAddress ||
                    this.StreetAddress != null &&
                    this.StreetAddress.Equals(other.StreetAddress)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Zip != null)
                    hash = hash * 59 + this.Zip.GetHashCode();
                if (this.StreetAddress != null)
                    hash = hash * 59 + this.StreetAddress.GetHashCode();
                return hash;
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
