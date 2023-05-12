using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// ShareholderContact
    /// </summary>
    [DataContract]
    public class ShareholderContact : IEquatable<ShareholderContact>, IValidatableObject
    {
        /// <summary>
        /// Specifies how the person is associated with the account holder.   Possible values:   * **Owner**: Individuals who directly or indirectly own 25% or more of a company.  * **Controller**: Individuals who are members of senior management staff responsible for managing a company or organization.
        /// </summary>
        /// <value>Specifies how the person is associated with the account holder.   Possible values:   * **Owner**: Individuals who directly or indirectly own 25% or more of a company.  * **Controller**: Individuals who are members of senior management staff responsible for managing a company or organization.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShareholderTypeEnum
        {
            /// <summary>
            /// Enum Controller for value: Controller
            /// </summary>
            [EnumMember(Value = "Controller")] Controller = 1,

            /// <summary>
            /// Enum Owner for value: Owner
            /// </summary>
            [EnumMember(Value = "Owner")] Owner = 2,

            /// <summary>
            /// Enum Signatory for value: Signatory
            /// </summary>
            [EnumMember(Value = "Signatory")] Signatory = 3
        }

        /// <summary>
        /// Specifies how the person is associated with the account holder.   Possible values:   * **Owner**: Individuals who directly or indirectly own 25% or more of a company.  * **Controller**: Individuals who are members of senior management staff responsible for managing a company or organization.
        /// </summary>
        /// <value>Specifies how the person is associated with the account holder.   Possible values:   * **Owner**: Individuals who directly or indirectly own 25% or more of a company.  * **Controller**: Individuals who are members of senior management staff responsible for managing a company or organization.</value>
        [DataMember(Name = "shareholderType", EmitDefaultValue = false)]
        public ShareholderTypeEnum? ShareholderType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareholderContact" /> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="email">The e-mail address of the person..</param>
        /// <param name="fullPhoneNumber">The phone number of the person provided as a single string.  It will be handled as a landline phone. Examples: \&quot;0031 6 11 22 33 44\&quot;, \&quot;+316/1122-3344\&quot;, \&quot;(0031) 611223344\&quot;.</param>
        /// <param name="jobTitle">Job title of the person. Required when the &#x60;shareholderType&#x60; is **Controller**.  Example values: **Chief Executive Officer**, **Chief Financial Officer**, **Chief Operating Officer**, **President**, **Vice President**, **Executive President**, **Managing Member**, **Partner**, **Treasurer**, **Director**, or **Other**..</param>
        /// <param name="name">name.</param>
        /// <param name="personalData">personalData.</param>
        /// <param name="shareholderCode">The unique identifier (UUID) of the shareholder entry. &gt;**If, during an Account Holder create or update request, this field is left blank (but other fields provided), a new Shareholder will be created with a procedurally-generated UUID.**  &gt;**If, during an Account Holder create request, a UUID is provided, the creation of the Shareholder will fail while the creation of the Account Holder will continue.**  &gt;**If, during an Account Holder update request, a UUID that is not correlated with an existing Shareholder is provided, the update of the Shareholder will fail.**  &gt;**If, during an Account Holder update request, a UUID that is correlated with an existing Shareholder is provided, the existing Shareholder will be updated.** .</param>
        /// <param name="shareholderReference">Your reference for the shareholder entry..</param>
        /// <param name="shareholderType">Specifies how the person is associated with the account holder.   Possible values:   * **Owner**: Individuals who directly or indirectly own 25% or more of a company.  * **Controller**: Individuals who are members of senior management staff responsible for managing a company or organization..</param>
        /// <param name="webAddress">The URL of the person&#x27;s website..</param>
        public ShareholderContact(ViasAddress address = default(ViasAddress), string email = default(string),
            string fullPhoneNumber = default(string), string jobTitle = default(string),
            ViasName name = default(ViasName), ViasPersonalData personalData = default(ViasPersonalData),
            string shareholderCode = default(string), string shareholderReference = default(string),
            ShareholderTypeEnum? shareholderType = default(ShareholderTypeEnum?), string webAddress = default(string))
        {
            Address = address;
            Email = email;
            FullPhoneNumber = fullPhoneNumber;
            JobTitle = jobTitle;
            Name = name;
            PersonalData = personalData;
            ShareholderCode = shareholderCode;
            ShareholderReference = shareholderReference;
            ShareholderType = shareholderType;
            WebAddress = webAddress;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public ViasAddress Address { get; set; }

        /// <summary>
        /// The e-mail address of the person.
        /// </summary>
        /// <value>The e-mail address of the person.</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// The phone number of the person provided as a single string.  It will be handled as a landline phone. Examples: \&quot;0031 6 11 22 33 44\&quot;, \&quot;+316/1122-3344\&quot;, \&quot;(0031) 611223344\&quot;
        /// </summary>
        /// <value>The phone number of the person provided as a single string.  It will be handled as a landline phone. Examples: \&quot;0031 6 11 22 33 44\&quot;, \&quot;+316/1122-3344\&quot;, \&quot;(0031) 611223344\&quot;</value>
        [DataMember(Name = "fullPhoneNumber", EmitDefaultValue = false)]
        public string FullPhoneNumber { get; set; }

        /// <summary>
        /// Job title of the person. Required when the &#x60;shareholderType&#x60; is **Controller**.  Example values: **Chief Executive Officer**, **Chief Financial Officer**, **Chief Operating Officer**, **President**, **Vice President**, **Executive President**, **Managing Member**, **Partner**, **Treasurer**, **Director**, or **Other**.
        /// </summary>
        /// <value>Job title of the person. Required when the &#x60;shareholderType&#x60; is **Controller**.  Example values: **Chief Executive Officer**, **Chief Financial Officer**, **Chief Operating Officer**, **President**, **Vice President**, **Executive President**, **Managing Member**, **Partner**, **Treasurer**, **Director**, or **Other**.</value>
        [DataMember(Name = "jobTitle", EmitDefaultValue = false)]
        public string JobTitle { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public ViasName Name { get; set; }

        /// <summary>
        /// Gets or Sets PersonalData
        /// </summary>
        [DataMember(Name = "personalData", EmitDefaultValue = false)]
        public ViasPersonalData PersonalData { get; set; }

        /// <summary>
        /// The unique identifier (UUID) of the shareholder entry. &gt;**If, during an Account Holder create or update request, this field is left blank (but other fields provided), a new Shareholder will be created with a procedurally-generated UUID.**  &gt;**If, during an Account Holder create request, a UUID is provided, the creation of the Shareholder will fail while the creation of the Account Holder will continue.**  &gt;**If, during an Account Holder update request, a UUID that is not correlated with an existing Shareholder is provided, the update of the Shareholder will fail.**  &gt;**If, during an Account Holder update request, a UUID that is correlated with an existing Shareholder is provided, the existing Shareholder will be updated.** 
        /// </summary>
        /// <value>The unique identifier (UUID) of the shareholder entry. &gt;**If, during an Account Holder create or update request, this field is left blank (but other fields provided), a new Shareholder will be created with a procedurally-generated UUID.**  &gt;**If, during an Account Holder create request, a UUID is provided, the creation of the Shareholder will fail while the creation of the Account Holder will continue.**  &gt;**If, during an Account Holder update request, a UUID that is not correlated with an existing Shareholder is provided, the update of the Shareholder will fail.**  &gt;**If, during an Account Holder update request, a UUID that is correlated with an existing Shareholder is provided, the existing Shareholder will be updated.** </value>
        [DataMember(Name = "shareholderCode", EmitDefaultValue = false)]
        public string ShareholderCode { get; set; }

        /// <summary>
        /// Your reference for the shareholder entry.
        /// </summary>
        /// <value>Your reference for the shareholder entry.</value>
        [DataMember(Name = "shareholderReference", EmitDefaultValue = false)]
        public string ShareholderReference { get; set; }


        /// <summary>
        /// The URL of the person&#x27;s website.
        /// </summary>
        /// <value>The URL of the person&#x27;s website.</value>
        [DataMember(Name = "webAddress", EmitDefaultValue = false)]
        public string WebAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShareholderContact {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FullPhoneNumber: ").Append(FullPhoneNumber).Append("\n");
            sb.Append("  JobTitle: ").Append(JobTitle).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PersonalData: ").Append(PersonalData).Append("\n");
            sb.Append("  ShareholderCode: ").Append(ShareholderCode).Append("\n");
            sb.Append("  ShareholderReference: ").Append(ShareholderReference).Append("\n");
            sb.Append("  ShareholderType: ").Append(ShareholderType).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as ShareholderContact);
        }

        /// <summary>
        /// Returns true if ShareholderContact instances are equal
        /// </summary>
        /// <param name="input">Instance of ShareholderContact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShareholderContact input)
        {
            if (input == null)
                return false;

            return
                (
                    Address == input.Address ||
                    (Address != null &&
                     Address.Equals(input.Address))
                ) &&
                (
                    Email == input.Email ||
                    (Email != null &&
                     Email.Equals(input.Email))
                ) &&
                (
                    FullPhoneNumber == input.FullPhoneNumber ||
                    (FullPhoneNumber != null &&
                     FullPhoneNumber.Equals(input.FullPhoneNumber))
                ) &&
                (
                    JobTitle == input.JobTitle ||
                    (JobTitle != null &&
                     JobTitle.Equals(input.JobTitle))
                ) &&
                (
                    Name == input.Name ||
                    (Name != null &&
                     Name.Equals(input.Name))
                ) &&
                (
                    PersonalData == input.PersonalData ||
                    (PersonalData != null &&
                     PersonalData.Equals(input.PersonalData))
                ) &&
                (
                    ShareholderCode == input.ShareholderCode ||
                    (ShareholderCode != null &&
                     ShareholderCode.Equals(input.ShareholderCode))
                ) &&
                (
                    ShareholderReference == input.ShareholderReference ||
                    (ShareholderReference != null &&
                     ShareholderReference.Equals(input.ShareholderReference))
                ) &&
                (
                    ShareholderType == input.ShareholderType ||
                    (ShareholderType != null &&
                     ShareholderType.Equals(input.ShareholderType))
                ) &&
                (
                    WebAddress == input.WebAddress ||
                    (WebAddress != null &&
                     WebAddress.Equals(input.WebAddress))
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
                if (Address != null)
                    hashCode = hashCode * 59 + Address.GetHashCode();
                if (Email != null)
                    hashCode = hashCode * 59 + Email.GetHashCode();
                if (FullPhoneNumber != null)
                    hashCode = hashCode * 59 + FullPhoneNumber.GetHashCode();
                if (JobTitle != null)
                    hashCode = hashCode * 59 + JobTitle.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (PersonalData != null)
                    hashCode = hashCode * 59 + PersonalData.GetHashCode();
                if (ShareholderCode != null)
                    hashCode = hashCode * 59 + ShareholderCode.GetHashCode();
                if (ShareholderReference != null)
                    hashCode = hashCode * 59 + ShareholderReference.GetHashCode();
                if (ShareholderType != null)
                    hashCode = hashCode * 59 + ShareholderType.GetHashCode();
                if (WebAddress != null)
                    hashCode = hashCode * 59 + WebAddress.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext)
        {
            yield break;
        }
    }
}