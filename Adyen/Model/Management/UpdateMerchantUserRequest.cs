/*
* Management API
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

namespace Adyen.Model.Management
{
    /// <summary>
    /// UpdateMerchantUserRequest
    /// </summary>
    [DataContract(Name = "UpdateMerchantUserRequest")]
    public partial class UpdateMerchantUserRequest : IEquatable<UpdateMerchantUserRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMerchantUserRequest" /> class.
        /// </summary>
        /// <param name="accountGroups">The list of [account groups](https://docs.adyen.com/account/account-structure#account-groups) associated with this user..</param>
        /// <param name="active">Sets the status of the user to active (**true**) or inactive (**false**)..</param>
        /// <param name="email">The email address of the user..</param>
        /// <param name="name">name.</param>
        /// <param name="roles">The list of [roles](https://docs.adyen.com/account/user-roles) for this user..</param>
        /// <param name="timeZoneCode">The [tz database name](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones) of the time zone of the user. For example, **Europe/Amsterdam**..</param>
        public UpdateMerchantUserRequest(List<string> accountGroups = default(List<string>), bool? active = default(bool?), string email = default(string), Name2 name = default(Name2), List<string> roles = default(List<string>), string timeZoneCode = default(string))
        {
            this.AccountGroups = accountGroups;
            this.Active = active;
            this.Email = email;
            this.Name = name;
            this.Roles = roles;
            this.TimeZoneCode = timeZoneCode;
        }

        /// <summary>
        /// The list of [account groups](https://docs.adyen.com/account/account-structure#account-groups) associated with this user.
        /// </summary>
        /// <value>The list of [account groups](https://docs.adyen.com/account/account-structure#account-groups) associated with this user.</value>
        [DataMember(Name = "accountGroups", EmitDefaultValue = false)]
        public List<string> AccountGroups { get; set; }

        /// <summary>
        /// Sets the status of the user to active (**true**) or inactive (**false**).
        /// </summary>
        /// <value>Sets the status of the user to active (**true**) or inactive (**false**).</value>
        [DataMember(Name = "active", EmitDefaultValue = false)]
        public bool? Active { get; set; }

        /// <summary>
        /// The email address of the user.
        /// </summary>
        /// <value>The email address of the user.</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public Name2 Name { get; set; }

        /// <summary>
        /// The list of [roles](https://docs.adyen.com/account/user-roles) for this user.
        /// </summary>
        /// <value>The list of [roles](https://docs.adyen.com/account/user-roles) for this user.</value>
        [DataMember(Name = "roles", EmitDefaultValue = false)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// The [tz database name](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones) of the time zone of the user. For example, **Europe/Amsterdam**.
        /// </summary>
        /// <value>The [tz database name](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones) of the time zone of the user. For example, **Europe/Amsterdam**.</value>
        [DataMember(Name = "timeZoneCode", EmitDefaultValue = false)]
        public string TimeZoneCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateMerchantUserRequest {\n");
            sb.Append("  AccountGroups: ").Append(AccountGroups).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  TimeZoneCode: ").Append(TimeZoneCode).Append("\n");
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
            return this.Equals(input as UpdateMerchantUserRequest);
        }

        /// <summary>
        /// Returns true if UpdateMerchantUserRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateMerchantUserRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateMerchantUserRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountGroups == input.AccountGroups ||
                    this.AccountGroups != null &&
                    input.AccountGroups != null &&
                    this.AccountGroups.SequenceEqual(input.AccountGroups)
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.TimeZoneCode == input.TimeZoneCode ||
                    (this.TimeZoneCode != null &&
                    this.TimeZoneCode.Equals(input.TimeZoneCode))
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
                if (this.AccountGroups != null)
                {
                    hashCode = (hashCode * 59) + this.AccountGroups.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Roles != null)
                {
                    hashCode = (hashCode * 59) + this.Roles.GetHashCode();
                }
                if (this.TimeZoneCode != null)
                {
                    hashCode = (hashCode * 59) + this.TimeZoneCode.GetHashCode();
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
