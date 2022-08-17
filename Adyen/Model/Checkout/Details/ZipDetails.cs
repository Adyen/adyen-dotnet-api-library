// #region License
// 
//                         ######
//                         ######
//   ############    ####( ######  #####. ######  ############   ############
//   #############  #####( ######  #####. ######  #############  #############
//          ######  #####( ######  #####. ######  #####  ######  #####  ######
//   ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//   ###### ######  #####( ######  #####. ######  #####          #####  ######
//   #############  #############  #############  #############  #####  ######
//    ############   ############  #############   ############  #####  ######
//                                        ######
//                                 #############
//                                 ############
// 
//   Adyen Dotnet API Library
// 
//   Copyright (c) 2022 Adyen N.V.
//   This file is open source and available under the MIT license.
//   See the LICENSE file for more info.
// 
// #endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout.Details
{
    /// <summary>
    /// ZipDetails
    /// </summary>
    [DataContract]
    public partial class ZipDetails : IEquatable<ZipDetails>, IValidatableObject, IPaymentMethodDetails
    {
        public const string Zip = "zip";
        public const string Zip_Pos = "zip_pos";

        /// <summary>
        /// **zip**
        /// </summary>
        /// <value>**zip**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZipDetails" /> class.
        /// </summary>
        /// <param name="clickAndCollect">Set this to **true** if the shopper would like to pick up and collect their order, instead of having the goods delivered to them..</param>
        /// <param name="recurringDetailReference">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        /// <param name="storedPaymentMethodId">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        /// <param name="type">**zip** (default to TypeEnum.Zip).</param>
        public ZipDetails(string clickAndCollect = default(string), string recurringDetailReference = default(string),
            string storedPaymentMethodId = default(string), string type = default(string))
        {
            this.ClickAndCollect = clickAndCollect;
            this.RecurringDetailReference = recurringDetailReference;
            this.StoredPaymentMethodId = storedPaymentMethodId;
            this.Type = type;
        }

        /// <summary>
        /// Set this to **true** if the shopper would like to pick up and collect their order, instead of having the goods delivered to them.
        /// </summary>
        /// <value>Set this to **true** if the shopper would like to pick up and collect their order, instead of having the goods delivered to them.</value>
        [DataMember(Name = "clickAndCollect", EmitDefaultValue = false)]
        public string ClickAndCollect { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ZipDetails {\n");
            sb.Append("  ClickAndCollect: ").Append(ClickAndCollect).Append("\n");
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
            return this.Equals(input as ZipDetails);
        }

        /// <summary>
        /// Returns true if ZipDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ZipDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZipDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ClickAndCollect == input.ClickAndCollect ||
                    (this.ClickAndCollect != null &&
                     this.ClickAndCollect.Equals(input.ClickAndCollect))
                ) &&
                (
                    this.RecurringDetailReference == input.RecurringDetailReference ||
                    (this.RecurringDetailReference != null &&
                     this.RecurringDetailReference.Equals(input.RecurringDetailReference))
                ) &&
                (
                    this.StoredPaymentMethodId == input.StoredPaymentMethodId ||
                    (this.StoredPaymentMethodId != null &&
                     this.StoredPaymentMethodId.Equals(input.StoredPaymentMethodId))
                ) &&
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                     this.Type.Equals(input.Type))
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
                if (this.ClickAndCollect != null)
                    hashCode = hashCode * 59 + this.ClickAndCollect.GetHashCode();
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