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
    /// BcmcInfo
    /// </summary>
    [DataContract(Name = "BcmcInfo")]
    public partial class BcmcInfo : IEquatable<BcmcInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BcmcInfo" /> class.
        /// </summary>
        /// <param name="enableBcmcMobile">Indicates if [Bancontact mobile](https://docs.adyen.com/payment-methods/bancontact/bancontact-mobile) is enabled..</param>
        /// <param name="transactionDescription">transactionDescription.</param>
        public BcmcInfo(bool? enableBcmcMobile = default(bool?), TransactionDescriptionInfo transactionDescription = default(TransactionDescriptionInfo))
        {
            this.EnableBcmcMobile = enableBcmcMobile;
            this.TransactionDescription = transactionDescription;
        }

        /// <summary>
        /// Indicates if [Bancontact mobile](https://docs.adyen.com/payment-methods/bancontact/bancontact-mobile) is enabled.
        /// </summary>
        /// <value>Indicates if [Bancontact mobile](https://docs.adyen.com/payment-methods/bancontact/bancontact-mobile) is enabled.</value>
        [DataMember(Name = "enableBcmcMobile", EmitDefaultValue = false)]
        public bool? EnableBcmcMobile { get; set; }

        /// <summary>
        /// Gets or Sets TransactionDescription
        /// </summary>
        [DataMember(Name = "transactionDescription", EmitDefaultValue = false)]
        public TransactionDescriptionInfo TransactionDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BcmcInfo {\n");
            sb.Append("  EnableBcmcMobile: ").Append(EnableBcmcMobile).Append("\n");
            sb.Append("  TransactionDescription: ").Append(TransactionDescription).Append("\n");
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
            return this.Equals(input as BcmcInfo);
        }

        /// <summary>
        /// Returns true if BcmcInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BcmcInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BcmcInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EnableBcmcMobile == input.EnableBcmcMobile ||
                    this.EnableBcmcMobile.Equals(input.EnableBcmcMobile)
                ) && 
                (
                    this.TransactionDescription == input.TransactionDescription ||
                    (this.TransactionDescription != null &&
                    this.TransactionDescription.Equals(input.TransactionDescription))
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
                hashCode = (hashCode * 59) + this.EnableBcmcMobile.GetHashCode();
                if (this.TransactionDescription != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionDescription.GetHashCode();
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
