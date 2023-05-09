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
    /// ContactDetails
    /// </summary>
    [DataContract(Name = "ContactDetails")]
    public partial class ContactDetails : IEquatable<ContactDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContactDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactDetails" /> class.
        /// </summary>
        /// <param name="address">address (required).</param>
        /// <param name="email">The email address of the account holder. (required).</param>
        /// <param name="phone">phone (required).</param>
        /// <param name="webAddress">The URL of the account holder&#39;s website..</param>
        public ContactDetails(Address address = default(Address), string email = default(string), Phone phone = default(Phone), string webAddress = default(string))
        {
            this.Address = address;
            this.Email = email;
            this.Phone = phone;
            this.WebAddress = webAddress;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", IsRequired = false, EmitDefaultValue = false)]
        public Address Address { get; set; }

        /// <summary>
        /// The email address of the account holder.
        /// </summary>
        /// <value>The email address of the account holder.</value>
        [DataMember(Name = "email", IsRequired = false, EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name = "phone", IsRequired = false, EmitDefaultValue = false)]
        public Phone Phone { get; set; }

        /// <summary>
        /// The URL of the account holder&#39;s website.
        /// </summary>
        /// <value>The URL of the account holder&#39;s website.</value>
        [DataMember(Name = "webAddress", EmitDefaultValue = false)]
        public string WebAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContactDetails {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  WebAddress: ").Append(WebAddress).Append("\n");
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
            return this.Equals(input as ContactDetails);
        }

        /// <summary>
        /// Returns true if ContactDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.WebAddress == input.WebAddress ||
                    (this.WebAddress != null &&
                    this.WebAddress.Equals(input.WebAddress))
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                }
                if (this.WebAddress != null)
                {
                    hashCode = (hashCode * 59) + this.WebAddress.GetHashCode();
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