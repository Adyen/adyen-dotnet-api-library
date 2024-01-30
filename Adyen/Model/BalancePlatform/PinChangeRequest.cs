/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
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
    /// PinChangeRequest
    /// </summary>
    [DataContract(Name = "PinChangeRequest")]
    public partial class PinChangeRequest : IEquatable<PinChangeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PinChangeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PinChangeRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PinChangeRequest" /> class.
        /// </summary>
        /// <param name="encryptedKey">Symmetric session key encrypted under the public key. (required).</param>
        /// <param name="encryptedPinBlock">The encrypted PIN block (required).</param>
        /// <param name="paymentInstrumentId">The unique identifier of the payment instrument. (required).</param>
        /// <param name="token">The token which is used to construct the pinblock. (required).</param>
        public PinChangeRequest(string encryptedKey = default(string), string encryptedPinBlock = default(string), string paymentInstrumentId = default(string), string token = default(string))
        {
            this.EncryptedKey = encryptedKey;
            this.EncryptedPinBlock = encryptedPinBlock;
            this.PaymentInstrumentId = paymentInstrumentId;
            this.Token = token;
        }

        /// <summary>
        /// Symmetric session key encrypted under the public key.
        /// </summary>
        /// <value>Symmetric session key encrypted under the public key.</value>
        [DataMember(Name = "encryptedKey", IsRequired = false, EmitDefaultValue = false)]
        public string EncryptedKey { get; set; }

        /// <summary>
        /// The encrypted PIN block
        /// </summary>
        /// <value>The encrypted PIN block</value>
        [DataMember(Name = "encryptedPinBlock", IsRequired = false, EmitDefaultValue = false)]
        public string EncryptedPinBlock { get; set; }

        /// <summary>
        /// The unique identifier of the payment instrument.
        /// </summary>
        /// <value>The unique identifier of the payment instrument.</value>
        [DataMember(Name = "paymentInstrumentId", IsRequired = false, EmitDefaultValue = false)]
        public string PaymentInstrumentId { get; set; }

        /// <summary>
        /// The token which is used to construct the pinblock.
        /// </summary>
        /// <value>The token which is used to construct the pinblock.</value>
        [DataMember(Name = "token", IsRequired = false, EmitDefaultValue = false)]
        public string Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PinChangeRequest {\n");
            sb.Append("  EncryptedKey: ").Append(EncryptedKey).Append("\n");
            sb.Append("  EncryptedPinBlock: ").Append(EncryptedPinBlock).Append("\n");
            sb.Append("  PaymentInstrumentId: ").Append(PaymentInstrumentId).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return this.Equals(input as PinChangeRequest);
        }

        /// <summary>
        /// Returns true if PinChangeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PinChangeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PinChangeRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EncryptedKey == input.EncryptedKey ||
                    (this.EncryptedKey != null &&
                    this.EncryptedKey.Equals(input.EncryptedKey))
                ) && 
                (
                    this.EncryptedPinBlock == input.EncryptedPinBlock ||
                    (this.EncryptedPinBlock != null &&
                    this.EncryptedPinBlock.Equals(input.EncryptedPinBlock))
                ) && 
                (
                    this.PaymentInstrumentId == input.PaymentInstrumentId ||
                    (this.PaymentInstrumentId != null &&
                    this.PaymentInstrumentId.Equals(input.PaymentInstrumentId))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
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
                if (this.EncryptedKey != null)
                {
                    hashCode = (hashCode * 59) + this.EncryptedKey.GetHashCode();
                }
                if (this.EncryptedPinBlock != null)
                {
                    hashCode = (hashCode * 59) + this.EncryptedPinBlock.GetHashCode();
                }
                if (this.PaymentInstrumentId != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentInstrumentId.GetHashCode();
                }
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
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
