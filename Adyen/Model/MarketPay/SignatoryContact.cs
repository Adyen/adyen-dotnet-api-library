using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// SignatoryContact
    /// </summary>
    [DataContract(Name = "SignatoryContact")]
    public class SignatoryContact : IEquatable<SignatoryContact>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatoryContact" /> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="email">The e-mail address of the person..</param>
        /// <param name="fullPhoneNumber">The phone number of the person provided as a single string.  It will be handled as a landline phone. Examples: \&quot;0031 6 11 22 33 44\&quot;, \&quot;+316/1122-3344\&quot;, \&quot;(0031) 611223344\&quot;.</param>
        /// <param name="jobTitle">Job title of the signatory.  Example values: **Chief Executive Officer**, **Chief Financial Officer**, **Chief Operating Officer**, **President**, **Vice President**, **Executive President**, **Managing Member**, **Partner**, **Treasurer**, **Director**, or **Other**..</param>
        /// <param name="name">name.</param>
        /// <param name="personalData">personalData.</param>
        /// <param name="phoneNumber">phoneNumber.</param>
        /// <param name="signatoryCode">The unique identifier (UUID) of the signatory. &gt;**If, during an Account Holder create or update request, this field is left blank (but other fields provided), a new Signatory will be created with a procedurally-generated UUID.**  &gt;**If, during an Account Holder create request, a UUID is provided, the creation of the Signatory will fail while the creation of the Account Holder will continue.**  &gt;**If, during an Account Holder update request, a UUID that is not correlated with an existing Signatory is provided, the update of the Signatory will fail.**  &gt;**If, during an Account Holder update request, a UUID that is correlated with an existing Signatory is provided, the existing Signatory will be updated.** .</param>
        /// <param name="signatoryReference">Your reference for the signatory..</param>
        /// <param name="webAddress">The URL of the person&#39;s website..</param>
        public SignatoryContact(ViasAddress address = default(ViasAddress), string email = default(string), string fullPhoneNumber = default(string), string jobTitle = default(string), ViasName name = default(ViasName), ViasPersonalData personalData = default(ViasPersonalData), ViasPhoneNumber phoneNumber = default(ViasPhoneNumber), string signatoryCode = default(string), string signatoryReference = default(string), string webAddress = default(string))
        {
            Address = address;
            Email = email;
            FullPhoneNumber = fullPhoneNumber;
            JobTitle = jobTitle;
            Name = name;
            PersonalData = personalData;
            PhoneNumber = phoneNumber;
            SignatoryCode = signatoryCode;
            SignatoryReference = signatoryReference;
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
        /// Job title of the signatory.  Example values: **Chief Executive Officer**, **Chief Financial Officer**, **Chief Operating Officer**, **President**, **Vice President**, **Executive President**, **Managing Member**, **Partner**, **Treasurer**, **Director**, or **Other**.
        /// </summary>
        /// <value>Job title of the signatory.  Example values: **Chief Executive Officer**, **Chief Financial Officer**, **Chief Operating Officer**, **President**, **Vice President**, **Executive President**, **Managing Member**, **Partner**, **Treasurer**, **Director**, or **Other**.</value>
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
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        public ViasPhoneNumber PhoneNumber { get; set; }

        /// <summary>
        /// The unique identifier (UUID) of the signatory. &gt;**If, during an Account Holder create or update request, this field is left blank (but other fields provided), a new Signatory will be created with a procedurally-generated UUID.**  &gt;**If, during an Account Holder create request, a UUID is provided, the creation of the Signatory will fail while the creation of the Account Holder will continue.**  &gt;**If, during an Account Holder update request, a UUID that is not correlated with an existing Signatory is provided, the update of the Signatory will fail.**  &gt;**If, during an Account Holder update request, a UUID that is correlated with an existing Signatory is provided, the existing Signatory will be updated.** 
        /// </summary>
        /// <value>The unique identifier (UUID) of the signatory. &gt;**If, during an Account Holder create or update request, this field is left blank (but other fields provided), a new Signatory will be created with a procedurally-generated UUID.**  &gt;**If, during an Account Holder create request, a UUID is provided, the creation of the Signatory will fail while the creation of the Account Holder will continue.**  &gt;**If, during an Account Holder update request, a UUID that is not correlated with an existing Signatory is provided, the update of the Signatory will fail.**  &gt;**If, during an Account Holder update request, a UUID that is correlated with an existing Signatory is provided, the existing Signatory will be updated.** </value>
        [DataMember(Name = "signatoryCode", EmitDefaultValue = false)]
        public string SignatoryCode { get; set; }

        /// <summary>
        /// Your reference for the signatory.
        /// </summary>
        /// <value>Your reference for the signatory.</value>
        [DataMember(Name = "signatoryReference", EmitDefaultValue = false)]
        public string SignatoryReference { get; set; }

        /// <summary>
        /// The URL of the person&#39;s website.
        /// </summary>
        /// <value>The URL of the person&#39;s website.</value>
        [DataMember(Name = "webAddress", EmitDefaultValue = false)]
        public string WebAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignatoryContact {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FullPhoneNumber: ").Append(FullPhoneNumber).Append("\n");
            sb.Append("  JobTitle: ").Append(JobTitle).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PersonalData: ").Append(PersonalData).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  SignatoryCode: ").Append(SignatoryCode).Append("\n");
            sb.Append("  SignatoryReference: ").Append(SignatoryReference).Append("\n");
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
            return Equals(input as SignatoryContact);
        }

        /// <summary>
        /// Returns true if SignatoryContact instances are equal
        /// </summary>
        /// <param name="input">Instance of SignatoryContact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignatoryContact input)
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
                    PhoneNumber == input.PhoneNumber ||
                    (PhoneNumber != null &&
                    PhoneNumber.Equals(input.PhoneNumber))
                ) &&
                (
                    SignatoryCode == input.SignatoryCode ||
                    (SignatoryCode != null &&
                    SignatoryCode.Equals(input.SignatoryCode))
                ) &&
                (
                    SignatoryReference == input.SignatoryReference ||
                    (SignatoryReference != null &&
                    SignatoryReference.Equals(input.SignatoryReference))
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
                if (PhoneNumber != null)
                    hashCode = hashCode * 59 + PhoneNumber.GetHashCode();
                if (SignatoryCode != null)
                    hashCode = hashCode * 59 + SignatoryCode.GetHashCode();
                if (SignatoryReference != null)
                    hashCode = hashCode * 59 + SignatoryReference.GetHashCode();
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
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
