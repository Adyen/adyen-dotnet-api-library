/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 70
* Contact: developer-experience@adyen.com
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

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// ListStoredPaymentMethodsResponse
    /// </summary>
    [DataContract(Name = "ListStoredPaymentMethodsResponse")]
    public partial class ListStoredPaymentMethodsResponse : IEquatable<ListStoredPaymentMethodsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListStoredPaymentMethodsResponse" /> class.
        /// </summary>
        /// <param name="merchantAccount">Your merchant account..</param>
        /// <param name="shopperReference">Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address..</param>
        /// <param name="storedPaymentMethods">List of all stored payment methods..</param>
        public ListStoredPaymentMethodsResponse(string merchantAccount = default(string), string shopperReference = default(string), List<StoredPaymentMethodResource> storedPaymentMethods = default(List<StoredPaymentMethodResource>))
        {
            this.MerchantAccount = merchantAccount;
            this.ShopperReference = shopperReference;
            this.StoredPaymentMethods = storedPaymentMethods;
        }

        /// <summary>
        /// Your merchant account.
        /// </summary>
        /// <value>Your merchant account.</value>
        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address.
        /// </summary>
        /// <value>Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address.</value>
        [DataMember(Name = "shopperReference", EmitDefaultValue = false)]
        public string ShopperReference { get; set; }

        /// <summary>
        /// List of all stored payment methods.
        /// </summary>
        /// <value>List of all stored payment methods.</value>
        [DataMember(Name = "storedPaymentMethods", EmitDefaultValue = false)]
        public List<StoredPaymentMethodResource> StoredPaymentMethods { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListStoredPaymentMethodsResponse {\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  ShopperReference: ").Append(ShopperReference).Append("\n");
            sb.Append("  StoredPaymentMethods: ").Append(StoredPaymentMethods).Append("\n");
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
            return this.Equals(input as ListStoredPaymentMethodsResponse);
        }

        /// <summary>
        /// Returns true if ListStoredPaymentMethodsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ListStoredPaymentMethodsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListStoredPaymentMethodsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    (this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(input.MerchantAccount))
                ) && 
                (
                    this.ShopperReference == input.ShopperReference ||
                    (this.ShopperReference != null &&
                    this.ShopperReference.Equals(input.ShopperReference))
                ) && 
                (
                    this.StoredPaymentMethods == input.StoredPaymentMethods ||
                    this.StoredPaymentMethods != null &&
                    input.StoredPaymentMethods != null &&
                    this.StoredPaymentMethods.SequenceEqual(input.StoredPaymentMethods)
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
                if (this.MerchantAccount != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantAccount.GetHashCode();
                }
                if (this.ShopperReference != null)
                {
                    hashCode = (hashCode * 59) + this.ShopperReference.GetHashCode();
                }
                if (this.StoredPaymentMethods != null)
                {
                    hashCode = (hashCode * 59) + this.StoredPaymentMethods.GetHashCode();
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
