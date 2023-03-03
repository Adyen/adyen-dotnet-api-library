/*
* Management API
*
*
* The version of the OpenAPI document: 1
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

namespace Adyen.Model.Management
{
    /// <summary>
    /// Store
    /// </summary>
    [DataContract(Name = "Store")]
    public partial class Store : IEquatable<Store>, IValidatableObject
    {
        /// <summary>
        /// The status of the store. Possible values are:  - **active**. This value is assigned automatically when a store is created.  - **inactive**. The terminals under the store are blocked from accepting new transactions, but capturing outstanding transactions is still possible. - **closed**. This status is irreversible. The terminals under the store are reassigned to the merchant inventory.
        /// </summary>
        /// <value>The status of the store. Possible values are:  - **active**. This value is assigned automatically when a store is created.  - **inactive**. The terminals under the store are blocked from accepting new transactions, but capturing outstanding transactions is still possible. - **closed**. This status is irreversible. The terminals under the store are reassigned to the merchant inventory.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,

            /// <summary>
            /// Enum Closed for value: closed
            /// </summary>
            [EnumMember(Value = "closed")]
            Closed = 2,

            /// <summary>
            /// Enum Inactive for value: inactive
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive = 3

        }


        /// <summary>
        /// The status of the store. Possible values are:  - **active**. This value is assigned automatically when a store is created.  - **inactive**. The terminals under the store are blocked from accepting new transactions, but capturing outstanding transactions is still possible. - **closed**. This status is irreversible. The terminals under the store are reassigned to the merchant inventory.
        /// </summary>
        /// <value>The status of the store. Possible values are:  - **active**. This value is assigned automatically when a store is created.  - **inactive**. The terminals under the store are blocked from accepting new transactions, but capturing outstanding transactions is still possible. - **closed**. This status is irreversible. The terminals under the store are reassigned to the merchant inventory.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Store" /> class.
        /// </summary>
        /// <param name="links">links.</param>
        /// <param name="address">address.</param>
        /// <param name="businessLineIds">The unique identifiers of the [business lines](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/businesslines__resParam_id) that the store is associated with.  If not specified, the business line of the merchant account is used. Required when there are multiple business lines under the merchant account..</param>
        /// <param name="description">The description of the store..</param>
        /// <param name="externalReferenceId">When using the Zip payment method: The location ID that Zip has assigned to your store..</param>
        /// <param name="id">The unique identifier of the store. This value is generated by Adyen..</param>
        /// <param name="merchantId">The unique identifier of the merchant account that the store belongs to..</param>
        /// <param name="phoneNumber">The phone number of the store, including &#39;+&#39; and country code..</param>
        /// <param name="reference">A reference to recognize the store by. Also known as the store code.  Allowed characters: Lowercase and uppercase letters without diacritics, numbers 0 through 9, hyphen (-), and underscore (_).</param>
        /// <param name="shopperStatement">The store name shown on the shopper&#39;s bank or credit card statement and on the shopper receipt..</param>
        /// <param name="splitConfiguration">splitConfiguration.</param>
        /// <param name="status">The status of the store. Possible values are:  - **active**. This value is assigned automatically when a store is created.  - **inactive**. The terminals under the store are blocked from accepting new transactions, but capturing outstanding transactions is still possible. - **closed**. This status is irreversible. The terminals under the store are reassigned to the merchant inventory..</param>
        public Store(Links links = default(Links), StoreLocation address = default(StoreLocation), List<string> businessLineIds = default(List<string>), string description = default(string), string externalReferenceId = default(string), string id = default(string), string merchantId = default(string), string phoneNumber = default(string), string reference = default(string), string shopperStatement = default(string), StoreSplitConfiguration splitConfiguration = default(StoreSplitConfiguration), StatusEnum? status = default(StatusEnum?))
        {
            this.Links = links;
            this.Address = address;
            this.BusinessLineIds = businessLineIds;
            this.Description = description;
            this.ExternalReferenceId = externalReferenceId;
            this.Id = id;
            this.MerchantId = merchantId;
            this.PhoneNumber = phoneNumber;
            this.Reference = reference;
            this.ShopperStatement = shopperStatement;
            this.SplitConfiguration = splitConfiguration;
            this.Status = status;
        }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "_links", EmitDefaultValue = false)]
        public Links Links { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public StoreLocation Address { get; set; }

        /// <summary>
        /// The unique identifiers of the [business lines](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/businesslines__resParam_id) that the store is associated with.  If not specified, the business line of the merchant account is used. Required when there are multiple business lines under the merchant account.
        /// </summary>
        /// <value>The unique identifiers of the [business lines](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/businesslines__resParam_id) that the store is associated with.  If not specified, the business line of the merchant account is used. Required when there are multiple business lines under the merchant account.</value>
        [DataMember(Name = "businessLineIds", EmitDefaultValue = false)]
        public List<string> BusinessLineIds { get; set; }

        /// <summary>
        /// The description of the store.
        /// </summary>
        /// <value>The description of the store.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// When using the Zip payment method: The location ID that Zip has assigned to your store.
        /// </summary>
        /// <value>When using the Zip payment method: The location ID that Zip has assigned to your store.</value>
        [DataMember(Name = "externalReferenceId", EmitDefaultValue = false)]
        public string ExternalReferenceId { get; set; }

        /// <summary>
        /// The unique identifier of the store. This value is generated by Adyen.
        /// </summary>
        /// <value>The unique identifier of the store. This value is generated by Adyen.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The unique identifier of the merchant account that the store belongs to.
        /// </summary>
        /// <value>The unique identifier of the merchant account that the store belongs to.</value>
        [DataMember(Name = "merchantId", EmitDefaultValue = false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// The phone number of the store, including &#39;+&#39; and country code.
        /// </summary>
        /// <value>The phone number of the store, including &#39;+&#39; and country code.</value>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// A reference to recognize the store by. Also known as the store code.  Allowed characters: Lowercase and uppercase letters without diacritics, numbers 0 through 9, hyphen (-), and underscore (_)
        /// </summary>
        /// <value>A reference to recognize the store by. Also known as the store code.  Allowed characters: Lowercase and uppercase letters without diacritics, numbers 0 through 9, hyphen (-), and underscore (_)</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// The store name shown on the shopper&#39;s bank or credit card statement and on the shopper receipt.
        /// </summary>
        /// <value>The store name shown on the shopper&#39;s bank or credit card statement and on the shopper receipt.</value>
        [DataMember(Name = "shopperStatement", EmitDefaultValue = false)]
        public string ShopperStatement { get; set; }

        /// <summary>
        /// Gets or Sets SplitConfiguration
        /// </summary>
        [DataMember(Name = "splitConfiguration", EmitDefaultValue = false)]
        public StoreSplitConfiguration SplitConfiguration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Store {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  BusinessLineIds: ").Append(BusinessLineIds).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExternalReferenceId: ").Append(ExternalReferenceId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  ShopperStatement: ").Append(ShopperStatement).Append("\n");
            sb.Append("  SplitConfiguration: ").Append(SplitConfiguration).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Store);
        }

        /// <summary>
        /// Returns true if Store instances are equal
        /// </summary>
        /// <param name="input">Instance of Store to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Store input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.BusinessLineIds == input.BusinessLineIds ||
                    this.BusinessLineIds != null &&
                    input.BusinessLineIds != null &&
                    this.BusinessLineIds.SequenceEqual(input.BusinessLineIds)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ExternalReferenceId == input.ExternalReferenceId ||
                    (this.ExternalReferenceId != null &&
                    this.ExternalReferenceId.Equals(input.ExternalReferenceId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.ShopperStatement == input.ShopperStatement ||
                    (this.ShopperStatement != null &&
                    this.ShopperStatement.Equals(input.ShopperStatement))
                ) && 
                (
                    this.SplitConfiguration == input.SplitConfiguration ||
                    (this.SplitConfiguration != null &&
                    this.SplitConfiguration.Equals(input.SplitConfiguration))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
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
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.BusinessLineIds != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessLineIds.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.ExternalReferenceId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalReferenceId.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.MerchantId != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantId.GetHashCode();
                }
                if (this.PhoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNumber.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.ShopperStatement != null)
                {
                    hashCode = (hashCode * 59) + this.ShopperStatement.GetHashCode();
                }
                if (this.SplitConfiguration != null)
                {
                    hashCode = (hashCode * 59) + this.SplitConfiguration.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
