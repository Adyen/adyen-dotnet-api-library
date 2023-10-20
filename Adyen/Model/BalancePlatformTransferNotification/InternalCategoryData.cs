/*
* Transfer webhooks
*
*
* The version of the OpenAPI document: 4
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

namespace Adyen.Model.BalancePlatformTransferNotification
{
    /// <summary>
    /// InternalCategoryData
    /// </summary>
    [DataContract(Name = "InternalCategoryData")]
    public partial class InternalCategoryData : IEquatable<InternalCategoryData>, IValidatableObject
    {
        /// <summary>
        /// **internal**
        /// </summary>
        /// <value>**internal**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Internal for value: internal
            /// </summary>
            [EnumMember(Value = "internal")]
            Internal = 1

        }


        /// <summary>
        /// **internal**
        /// </summary>
        /// <value>**internal**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InternalCategoryData" /> class.
        /// </summary>
        /// <param name="modificationMerchantReference">The capture&#39;s merchant reference included in the transfer..</param>
        /// <param name="modificationPspReference">The capture reference included in the transfer..</param>
        /// <param name="type">**internal** (default to TypeEnum.Internal).</param>
        public InternalCategoryData(string modificationMerchantReference = default(string), string modificationPspReference = default(string), TypeEnum? type = TypeEnum.Internal)
        {
            this.ModificationMerchantReference = modificationMerchantReference;
            this.ModificationPspReference = modificationPspReference;
            this.Type = type;
        }

        /// <summary>
        /// The capture&#39;s merchant reference included in the transfer.
        /// </summary>
        /// <value>The capture&#39;s merchant reference included in the transfer.</value>
        [DataMember(Name = "modificationMerchantReference", EmitDefaultValue = false)]
        public string ModificationMerchantReference { get; set; }

        /// <summary>
        /// The capture reference included in the transfer.
        /// </summary>
        /// <value>The capture reference included in the transfer.</value>
        [DataMember(Name = "modificationPspReference", EmitDefaultValue = false)]
        public string ModificationPspReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InternalCategoryData {\n");
            sb.Append("  ModificationMerchantReference: ").Append(ModificationMerchantReference).Append("\n");
            sb.Append("  ModificationPspReference: ").Append(ModificationPspReference).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InternalCategoryData);
        }

        /// <summary>
        /// Returns true if InternalCategoryData instances are equal
        /// </summary>
        /// <param name="input">Instance of InternalCategoryData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InternalCategoryData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ModificationMerchantReference == input.ModificationMerchantReference ||
                    (this.ModificationMerchantReference != null &&
                    this.ModificationMerchantReference.Equals(input.ModificationMerchantReference))
                ) && 
                (
                    this.ModificationPspReference == input.ModificationPspReference ||
                    (this.ModificationPspReference != null &&
                    this.ModificationPspReference.Equals(input.ModificationPspReference))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.ModificationMerchantReference != null)
                {
                    hashCode = (hashCode * 59) + this.ModificationMerchantReference.GetHashCode();
                }
                if (this.ModificationPspReference != null)
                {
                    hashCode = (hashCode * 59) + this.ModificationPspReference.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
