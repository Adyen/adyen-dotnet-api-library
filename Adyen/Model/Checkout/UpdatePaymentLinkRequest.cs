#region Licence

// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2020 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// UpdatePaymentLinkRequest
    /// </summary>
    [DataContract]
    public partial class UpdatePaymentLinkRequest : IEquatable<UpdatePaymentLinkRequest>, IValidatableObject
    {
        /// <summary>
        /// Status of the payment link. Possible values: * **expired**
        /// </summary>
        /// <value>Status of the payment link. Possible values: * **expired**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Expired for value: expired
            /// </summary>
            [EnumMember(Value = "expired")] Expired = 1
        }

        /// <summary>
        /// Status of the payment link. Possible values: * **expired**
        /// </summary>
        /// <value>Status of the payment link. Possible values: * **expired**</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePaymentLinkRequest" /> class.
        /// </summary>
        /// <param name="status">Status of the payment link. Possible values: * **expired** (required).</param>
        public UpdatePaymentLinkRequest(StatusEnum status = default(StatusEnum))
        {
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException(
                    "status is a required property for UpdatePaymentLinkRequest and cannot be null");
            }
            else
            {
                this.Status = status;
            }
        }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePaymentLinkRequest {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as UpdatePaymentLinkRequest);
        }

        /// <summary>
        /// Returns true if UpdatePaymentLinkRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdatePaymentLinkRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdatePaymentLinkRequest input)
        {
            if (input == null)
                return false;

            return
                this.Status == input.Status ||
                this.Status != null &&
                this.Status.Equals(input.Status);
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext)
        {
            yield break;
        }
    }
}