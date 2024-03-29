﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.ApplicationInformation
{
    /// <summary>
    /// MerchantDevice
    /// </summary>
    [DataContract]
    public class MerchantDevice :  IEquatable<MerchantDevice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantDevice" /> class.
        /// </summary>
        /// <param name="Os">Operating system running on the merchant device..</param>
        /// <param name="OsVersion">Version of the operating system on the merchant device..</param>
        /// <param name="Reference">Merchant device reference..</param>
        public MerchantDevice(string Os = default(string), string OsVersion = default(string), string Reference = default(string))
        {
            this.Os = Os;
            this.OsVersion = OsVersion;
            this.Reference = Reference;
        }
        
        /// <summary>
        /// Operating system running on the merchant device.
        /// </summary>
        /// <value>Operating system running on the merchant device.</value>
        [DataMember(Name="os", EmitDefaultValue=false)]
        public string Os { get; set; }

        /// <summary>
        /// Version of the operating system on the merchant device.
        /// </summary>
        /// <value>Version of the operating system on the merchant device.</value>
        [DataMember(Name="osVersion", EmitDefaultValue=false)]
        public string OsVersion { get; set; }

        /// <summary>
        /// Merchant device reference.
        /// </summary>
        /// <value>Merchant device reference.</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantDevice {\n");
            sb.Append("  Os: ").Append(Os).Append("\n");
            sb.Append("  OsVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as MerchantDevice);
        }

        /// <summary>
        /// Returns true if MerchantDevice instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantDevice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantDevice input)
        {
            if (input == null)
                return false;

            return 
                (
                    Os == input.Os ||
                    (Os != null &&
                    Os.Equals(input.Os))
                ) && 
                (
                    OsVersion == input.OsVersion ||
                    (OsVersion != null &&
                    OsVersion.Equals(input.OsVersion))
                ) && 
                (
                    Reference == input.Reference ||
                    (Reference != null &&
                    Reference.Equals(input.Reference))
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
                if (Os != null)
                    hashCode = hashCode * 59 + Os.GetHashCode();
                if (OsVersion != null)
                    hashCode = hashCode * 59 + OsVersion.GetHashCode();
                if (Reference != null)
                    hashCode = hashCode * 59 + Reference.GetHashCode();
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
