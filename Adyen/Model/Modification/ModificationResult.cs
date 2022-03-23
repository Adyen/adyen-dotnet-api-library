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
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using Adyen.Model.Enum;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.Model.Modification
{
    /// <summary>
    /// ModificationResult
    /// </summary>
    [DataContract]
    public class ModificationResult :  IEquatable<ModificationResult>, IValidatableObject
    {
        /// <summary>
        /// Indicates if the modification request has been received for processing.
        /// </summary>
        /// <value>Indicates if the modification request has been received for processing.</value>
        [DataMember(Name = "response", EmitDefaultValue = false)]
        public ResponseEnum? Response { get; set; }

        /// <summary>
        /// This field contains additional data, which may be returned in a particular modification response.
        /// </summary>
        /// <value>This field contains additional data, which may be returned in a particular modification response.</value>
        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// Adyen&#39;s 16-digit unique reference associated with the transaction/the request. This value is globally unique; quote it when communicating with us about this request.
        /// </summary>
        /// <value>Adyen&#39;s 16-digit unique reference associated with the transaction/the request. This value is globally unique; quote it when communicating with us about this request.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        public string PspReference { get; set; }


        /// <summary>
        /// Adyen&#39;s 16-digit unique reference associated with the transaction/the request. This value is globally unique; quote it when communicating with us about this request.
        /// </summary>
        /// <value>Adyen&#39;s 16-digit unique reference associated with the transaction/the request. This value is globally unique; quote it when communicating with us about this request.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Adyen&#39;s 16-digit unique reference associated with the transaction/the request. This value is globally unique; quote it when communicating with us about this request.
        /// </summary>
        /// <value>Adyen&#39;s 16-digit unique reference associated with the transaction/the request. This value is globally unique; quote it when communicating with us about this request.</value>
        [DataMember(Name = "errorCode", EmitDefaultValue = false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Adyen&#39;s 16-digit unique reference associated with the transaction/the request. This value is globally unique; quote it when communicating with us about this request.
        /// </summary>
        /// <value>Adyen&#39;s 16-digit unique reference associated with the transaction/the request. This value is globally unique; quote it when communicating with us about this request.</value>
        [DataMember(Name = "errorType", EmitDefaultValue = false)]
        public string ErrorType { get; set; }

        /// <summary>
        /// Adyen&#39;s 16-digit unique reference associated with the transaction/the request. This value is globally unique; quote it when communicating with us about this request.
        /// </summary>
        /// <value>Adyen&#39;s 16-digit unique reference associated with the transaction/the request. This value is globally unique; quote it when communicating with us about this request.</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModificationResult" /> class.
        /// </summary>
        /// <param name="Response">Indicates if the modification request has been received for processing..</param>
        /// <param name="AdditionalData">This field contains additional data, which may be returned in a particular modification response..</param>
        /// <param name="PspReference">Adyen&#39;s 16-digit unique reference associated with the transaction/the request. This value is globally unique; quote it when communicating with us about this request..</param>
        public ModificationResult(ResponseEnum? Response = default(ResponseEnum?), Dictionary<string, string> AdditionalData = default(Dictionary<string, string>), string PspReference = default(string))
        {
            this.Response = Response;
            this.AdditionalData = AdditionalData;
            this.PspReference = PspReference;
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModificationResult {\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
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
            return this.Equals(obj as ModificationResult);
        }

        /// <summary>
        /// Returns true if ModificationResult instances are equal
        /// </summary>
        /// <param name="other">Instance of ModificationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModificationResult other)
        {
            if (other == null)
                return false;

            return 
                (
                    this.Response == other.Response ||
                    this.Response != null &&
                    this.Response.Equals(other.Response)
                ) && 
                (
                    this.AdditionalData == other.AdditionalData ||
                    this.AdditionalData != null &&
                    this.AdditionalData.SequenceEqual(other.AdditionalData)
                ) && 
                (
                    this.PspReference == other.PspReference ||
                    this.PspReference != null &&
                    this.PspReference.Equals(other.PspReference)
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
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Response != null)
                    hash = hash * 59 + this.Response.GetHashCode();
                if (this.AdditionalData != null)
                    hash = hash * 59 + this.AdditionalData.GetHashCode();
                if (this.PspReference != null)
                    hash = hash * 59 + this.PspReference.GetHashCode();
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
