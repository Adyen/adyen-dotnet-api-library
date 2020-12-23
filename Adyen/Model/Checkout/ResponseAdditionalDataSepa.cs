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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// ResponseAdditionalDataSepa
    /// </summary>
    [DataContract]
    public partial class ResponseAdditionalDataSepa : IEquatable<ResponseAdditionalDataSepa>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAdditionalDataSepa" /> class.
        /// </summary>
        /// <param name="sepadirectdebitDateOfSignature">The transaction signature date.  Format: yyyy-MM-dd.</param>
        /// <param name="sepadirectdebitMandateId">Its value corresponds to the pspReference value of the transaction..</param>
        /// <param name="sepadirectdebitSequenceType">This field can take one of the following values: * OneOff: (OOFF) Direct debit instruction to initiate exactly one direct debit transaction.  * First: (FRST) Initial/first collection in a series of direct debit instructions. * Recurring: (RCUR) Direct debit instruction to carry out regular direct debit transactions initiated by the creditor. * Final: (FNAL) Last/final collection in a series of direct debit instructions.  Example: OOFF.</param>
        public ResponseAdditionalDataSepa(string sepadirectdebitDateOfSignature = default(string),
            string sepadirectdebitMandateId = default(string), string sepadirectdebitSequenceType = default(string))
        {
            this.SepadirectdebitDateOfSignature = sepadirectdebitDateOfSignature;
            this.SepadirectdebitMandateId = sepadirectdebitMandateId;
            this.SepadirectdebitSequenceType = sepadirectdebitSequenceType;
        }

        /// <summary>
        /// The transaction signature date.  Format: yyyy-MM-dd
        /// </summary>
        /// <value>The transaction signature date.  Format: yyyy-MM-dd</value>
        [DataMember(Name = "sepadirectdebit.dateOfSignature", EmitDefaultValue = false)]
        public string SepadirectdebitDateOfSignature { get; set; }

        /// <summary>
        /// Its value corresponds to the pspReference value of the transaction.
        /// </summary>
        /// <value>Its value corresponds to the pspReference value of the transaction.</value>
        [DataMember(Name = "sepadirectdebit.mandateId", EmitDefaultValue = false)]
        public string SepadirectdebitMandateId { get; set; }

        /// <summary>
        /// This field can take one of the following values: * OneOff: (OOFF) Direct debit instruction to initiate exactly one direct debit transaction.  * First: (FRST) Initial/first collection in a series of direct debit instructions. * Recurring: (RCUR) Direct debit instruction to carry out regular direct debit transactions initiated by the creditor. * Final: (FNAL) Last/final collection in a series of direct debit instructions.  Example: OOFF
        /// </summary>
        /// <value>This field can take one of the following values: * OneOff: (OOFF) Direct debit instruction to initiate exactly one direct debit transaction.  * First: (FRST) Initial/first collection in a series of direct debit instructions. * Recurring: (RCUR) Direct debit instruction to carry out regular direct debit transactions initiated by the creditor. * Final: (FNAL) Last/final collection in a series of direct debit instructions.  Example: OOFF</value>
        [DataMember(Name = "sepadirectdebit.sequenceType", EmitDefaultValue = false)]
        public string SepadirectdebitSequenceType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseAdditionalDataSepa {\n");
            sb.Append("  SepadirectdebitDateOfSignature: ").Append(SepadirectdebitDateOfSignature).Append("\n");
            sb.Append("  SepadirectdebitMandateId: ").Append(SepadirectdebitMandateId).Append("\n");
            sb.Append("  SepadirectdebitSequenceType: ").Append(SepadirectdebitSequenceType).Append("\n");
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
            return this.Equals(input as ResponseAdditionalDataSepa);
        }

        /// <summary>
        /// Returns true if ResponseAdditionalDataSepa instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponseAdditionalDataSepa to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseAdditionalDataSepa input)
        {
            if (input == null)
                return false;

            return
                (
                    this.SepadirectdebitDateOfSignature == input.SepadirectdebitDateOfSignature ||
                    this.SepadirectdebitDateOfSignature != null &&
                    this.SepadirectdebitDateOfSignature.Equals(input.SepadirectdebitDateOfSignature)
                ) &&
                (
                    this.SepadirectdebitMandateId == input.SepadirectdebitMandateId ||
                    this.SepadirectdebitMandateId != null &&
                    this.SepadirectdebitMandateId.Equals(input.SepadirectdebitMandateId)
                ) &&
                (
                    this.SepadirectdebitSequenceType == input.SepadirectdebitSequenceType ||
                    this.SepadirectdebitSequenceType != null &&
                    this.SepadirectdebitSequenceType.Equals(input.SepadirectdebitSequenceType)
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
                if (this.SepadirectdebitDateOfSignature != null)
                    hashCode = hashCode * 59 + this.SepadirectdebitDateOfSignature.GetHashCode();
                if (this.SepadirectdebitMandateId != null)
                    hashCode = hashCode * 59 + this.SepadirectdebitMandateId.GetHashCode();
                if (this.SepadirectdebitSequenceType != null)
                    hashCode = hashCode * 59 + this.SepadirectdebitSequenceType.GetHashCode();
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