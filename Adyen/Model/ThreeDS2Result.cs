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

using Adyen.Model.Enum;
using Adyen.Util;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.Model
{
    [DataContract]
    public partial class ThreeDS2Result : IValidatableObject
    {
        /// <summary>
        /// The value for the 3D Secure 2.0 authentication session. The returned value is a Base64-encoded 20-byte array.
        /// </summary>
        [DataMember(Name = "authenticationValue", EmitDefaultValue = false)]
        public string AuthenticationValue { get; set; }

        /// <summary>
        /// The Electronic Commerce Indicator returned from the schemes for the 3D Secure 2.0 payment session.
        /// </summary>
        [DataMember(Name = "eci", EmitDefaultValue = false)]
        public string ECI { get; set; }

        /// <summary>
        /// The unique identifier assigned to the transaction by the 3D Secure 2.0 Server.
        /// </summary>
        [DataMember(Name = "threeDSServerTransID", EmitDefaultValue = false)]
        public string ThreeDSServerTransID { get; set; }

        /// <summary>
        /// The date and time of the cardholder authentication, in UTC
        /// </summary>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public string TimeStamp { get; set; }

        /// <summary>
        /// Indicates whether a transaction was authenticated, or whether additional verification is required.
        /// </summary>
        /// <value>Indicates whether a transaction was authenticated, or whether additional verification is required.</value>
        [DataMember(Name = "transStatus")]
        public string TransStatus { get; set; }

        /// <summary>
        /// Supported for 3D Secure 2. The unique transaction identifier assigned by the Directory Server (DS) to identify a single transaction.
        /// </summary>
        [DataMember(Name = "dsTransID")]
        public string DsTransID { get; set; }

        /// <summary>
        /// Provides information on why the transStatus field has the specified value.
        /// </summary>
        [DataMember(Name = "transStatusReason", EmitDefaultValue = false)]
        public string TransStatusReason { get; set; }
        /// <summary>
        /// The messageVersion value as defined in the 3D Secure 2 specification
        /// </summary>
        [DataMember(Name = "messageVersion", EmitDefaultValue = false)]
        public string MessageVersion { get; set; }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThreeDSResult {\n");
            sb.Append("  AuthenticationValue: ").Append(AuthenticationValue).Append("\n");
            sb.Append("  ECI: ").Append(ECI).Append("\n");
            sb.Append("  ThreeDSServerTransID: ").Append(ThreeDSServerTransID).Append("\n");
            sb.Append("  TimeStamp: ").Append(TimeStamp).Append("\n");
            sb.Append("  TransStatus: ").Append(TransStatus).Append("\n");
            sb.Append("  DsTransID: ").Append(DsTransID).Append("\n");
            sb.Append("  TransStatusReason: ").Append(TransStatusReason).Append("\n");
            sb.Append("  MessageVersion: ").Append(MessageVersion).Append("\n");
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
            return this.Equals(obj as ThreeDSecureData);
        }

        /// <summary>
        /// Returns true if ThreeDSecureData instances are equal
        /// </summary>
        /// <param name="other">Instance of ThreeDSecureData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThreeDS2Result other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.AuthenticationValue == other.AuthenticationValue ||
                    this.AuthenticationValue != null &&
                    this.AuthenticationValue.Equals(other.AuthenticationValue)
                ) &&
                (
                    this.ECI == other.ECI ||
                    this.ECI != null &&
                    this.ECI.Equals(other.ECI)
                ) &&
                (
                    this.ThreeDSServerTransID == other.ThreeDSServerTransID ||
                    this.ThreeDSServerTransID != null &&
                    this.ThreeDSServerTransID.Equals(other.ThreeDSServerTransID)
                ) &&
                (
                    this.TimeStamp == other.TimeStamp ||
                    this.TimeStamp != null &&
                    this.TimeStamp.Equals(other.TimeStamp)
                ) &&
                (
                    this.TransStatus == other.TransStatus ||
                    this.TransStatus != null &&
                    this.TransStatus.Equals(other.TransStatus)
                ) &&
                (
                    this.DsTransID == other.DsTransID ||
                    this.DsTransID != null &&
                    this.DsTransID.Equals(other.DsTransID)
                )&&
                (
                    this.TransStatusReason == other.TransStatusReason ||
                    this.TransStatusReason != null &&
                    this.TransStatusReason.Equals(other.TransStatusReason)
                ) &&
                (
                    this.MessageVersion == other.MessageVersion ||
                    this.MessageVersion != null &&
                    this.MessageVersion.Equals(other.MessageVersion)
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
                if (this.AuthenticationValue != null)
                    hash = hash * 59 + this.AuthenticationValue.GetHashCode();
                if (this.ECI != null)
                    hash = hash * 59 + this.ECI.GetHashCode();
                if (this.ThreeDSServerTransID != null)
                    hash = hash * 59 + this.ThreeDSServerTransID.GetHashCode();
                if (this.TimeStamp != null)
                    hash = hash * 59 + this.TimeStamp.GetHashCode();
                if (this.TransStatus != null)
                    hash = hash * 59 + this.TransStatus.GetHashCode();
                if (this.DsTransID != null)
                    hash = hash * 59 + this.DsTransID.GetHashCode();
                if (this.TransStatusReason != null)
                    hash = hash * 59 + this.TransStatusReason.GetHashCode();
                if (this.MessageVersion != null)
                    hash = hash * 59 + this.MessageVersion.GetHashCode();
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

