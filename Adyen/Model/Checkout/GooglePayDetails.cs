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
    /// GooglePayDetails
    /// </summary>
    [DataContract]
    public partial class GooglePayDetails : IEquatable<GooglePayDetails>, IValidatableObject
    {
        /// <summary>
        /// The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**.
        /// </summary>
        /// <value>The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FundingSourceEnum
        {
            /// <summary>
            /// Enum Debit for value: debit
            /// </summary>
            [EnumMember(Value = "debit")] Debit = 1
        }

        /// <summary>
        /// The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**.
        /// </summary>
        /// <value>The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**.</value>
        [DataMember(Name = "fundingSource", EmitDefaultValue = false)]
        public FundingSourceEnum? FundingSource { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooglePayDetails" /> class.
        /// </summary>
        /// <param name="fundingSource">The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**..</param>
        /// <param name="googlePayCardNetwork">googlePayCardNetwork.</param>
        /// <param name="googlePayToken">googlePayToken (required).</param>
        /// <param name="recurringDetailReference">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        /// <param name="storedPaymentMethodId">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        /// <param name="type">**paywithgoogle** (default to &quot;paywithgoogle&quot;).</param>
        public GooglePayDetails(FundingSourceEnum? fundingSource = default(FundingSourceEnum?),
            string googlePayCardNetwork = default(string), string googlePayToken = default(string),
            string recurringDetailReference = default(string), string storedPaymentMethodId = default(string),
            string type = "paywithgoogle")
        {
            // to ensure "googlePayToken" is required (not null)
            if (googlePayToken == null)
            {
                throw new InvalidDataException(
                    "googlePayToken is a required property for GooglePayDetails and cannot be null");
            }
            else
            {
                this.GooglePayToken = googlePayToken;
            }
            this.FundingSource = fundingSource;
            this.GooglePayCardNetwork = googlePayCardNetwork;
            this.RecurringDetailReference = recurringDetailReference;
            this.StoredPaymentMethodId = storedPaymentMethodId;
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "paywithgoogle";
            }
            else
            {
                this.Type = type;
            }
        }


        /// <summary>
        /// Gets or Sets GooglePayCardNetwork
        /// </summary>
        [DataMember(Name = "googlePayCardNetwork", EmitDefaultValue = false)]
        public string GooglePayCardNetwork { get; set; }

        /// <summary>
        /// Gets or Sets GooglePayToken
        /// </summary>
        [DataMember(Name = "googlePayToken", EmitDefaultValue = false)]
        public string GooglePayToken { get; set; }

        /// <summary>
        /// This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.
        /// </summary>
        /// <value>This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.</value>
        [DataMember(Name = "recurringDetailReference", EmitDefaultValue = false)]
        public string RecurringDetailReference { get; set; }

        /// <summary>
        /// This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.
        /// </summary>
        /// <value>This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.</value>
        [DataMember(Name = "storedPaymentMethodId", EmitDefaultValue = false)]
        public string StoredPaymentMethodId { get; set; }

        /// <summary>
        /// **paywithgoogle**
        /// </summary>
        /// <value>**paywithgoogle**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GooglePayDetails {\n");
            sb.Append("  FundingSource: ").Append(FundingSource).Append("\n");
            sb.Append("  GooglePayCardNetwork: ").Append(GooglePayCardNetwork).Append("\n");
            sb.Append("  GooglePayToken: ").Append(GooglePayToken).Append("\n");
            sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
            sb.Append("  StoredPaymentMethodId: ").Append(StoredPaymentMethodId).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GooglePayDetails);
        }

        /// <summary>
        /// Returns true if GooglePayDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of GooglePayDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GooglePayDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    this.FundingSource == input.FundingSource ||
                    this.FundingSource != null &&
                    this.FundingSource.Equals(input.FundingSource)
                ) &&
                (
                    this.GooglePayCardNetwork == input.GooglePayCardNetwork ||
                    this.GooglePayCardNetwork != null &&
                    this.GooglePayCardNetwork.Equals(input.GooglePayCardNetwork)
                ) &&
                (
                    this.GooglePayToken == input.GooglePayToken ||
                    this.GooglePayToken != null &&
                    this.GooglePayToken.Equals(input.GooglePayToken)
                ) &&
                (
                    this.RecurringDetailReference == input.RecurringDetailReference ||
                    this.RecurringDetailReference != null &&
                    this.RecurringDetailReference.Equals(input.RecurringDetailReference)
                ) &&
                (
                    this.StoredPaymentMethodId == input.StoredPaymentMethodId ||
                    this.StoredPaymentMethodId != null &&
                    this.StoredPaymentMethodId.Equals(input.StoredPaymentMethodId)
                ) &&
                (
                    this.Type == input.Type ||
                    this.Type != null &&
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
                if (this.FundingSource != null)
                    hashCode = hashCode * 59 + this.FundingSource.GetHashCode();
                if (this.GooglePayCardNetwork != null)
                    hashCode = hashCode * 59 + this.GooglePayCardNetwork.GetHashCode();
                if (this.GooglePayToken != null)
                    hashCode = hashCode * 59 + this.GooglePayToken.GetHashCode();
                if (this.RecurringDetailReference != null)
                    hashCode = hashCode * 59 + this.RecurringDetailReference.GetHashCode();
                if (this.StoredPaymentMethodId != null)
                    hashCode = hashCode * 59 + this.StoredPaymentMethodId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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