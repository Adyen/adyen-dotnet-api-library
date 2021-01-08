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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Adyen.Util;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// PaymentSessionResponse
    /// </summary>
    [DataContract]
    public partial class PaymentSessionResponse : IEquatable<PaymentSessionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSessionResponse" /> class.
        /// </summary>
        /// <param name="paymentSession">The encoded payment session that you need to pass to the SDK..</param>
        /// <param name="recurringDetails">The detailed list of stored payment details required to generate payment forms. Will be empty if oneClick is set to false in the request..</param>
        public PaymentSessionResponse(string paymentSession = default(string),
            List<RecurringDetail> recurringDetails = default(List<RecurringDetail>))
        {
            this.PaymentSession = paymentSession;
            this.RecurringDetails = recurringDetails;
        }

        /// <summary>
        /// The encoded payment session that you need to pass to the SDK.
        /// </summary>
        /// <value>The encoded payment session that you need to pass to the SDK.</value>
        [DataMember(Name = "paymentSession", EmitDefaultValue = false)]
        public string PaymentSession { get; set; }

        /// <summary>
        /// The detailed list of stored payment details required to generate payment forms. Will be empty if oneClick is set to false in the request.
        /// </summary>
        /// <value>The detailed list of stored payment details required to generate payment forms. Will be empty if oneClick is set to false in the request.</value>
        [DataMember(Name = "recurringDetails", EmitDefaultValue = false)]
        public List<RecurringDetail> RecurringDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentSessionResponse {\n");
            sb.Append("  PaymentSession: ").Append(PaymentSession).Append("\n");
            sb.Append("  RecurringDetails: ").Append(RecurringDetails.ObjectListToString()).Append("\n");
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
            return this.Equals(input as PaymentSessionResponse);
        }

        /// <summary>
        /// Returns true if PaymentSessionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentSessionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentSessionResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    this.PaymentSession == input.PaymentSession ||
                    this.PaymentSession != null &&
                    this.PaymentSession.Equals(input.PaymentSession)
                ) &&
                (
                    this.RecurringDetails == input.RecurringDetails ||
                    this.RecurringDetails != null &&
                    input.RecurringDetails != null &&
                    this.RecurringDetails.SequenceEqual(input.RecurringDetails)
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
                if (this.PaymentSession != null)
                    hashCode = hashCode * 59 + this.PaymentSession.GetHashCode();
                if (this.RecurringDetails != null)
                    hashCode = hashCode * 59 + this.RecurringDetails.GetHashCode();
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