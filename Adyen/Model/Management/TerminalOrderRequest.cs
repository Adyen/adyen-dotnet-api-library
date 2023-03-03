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
    /// TerminalOrderRequest
    /// </summary>
    [DataContract(Name = "TerminalOrderRequest")]
    public partial class TerminalOrderRequest : IEquatable<TerminalOrderRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TerminalOrderRequest" /> class.
        /// </summary>
        /// <param name="billingEntityId">The identification of the billing entity to use for the order..</param>
        /// <param name="customerOrderReference">The merchant-defined purchase order reference..</param>
        /// <param name="items">The products included in the order..</param>
        /// <param name="shippingLocationId">The identification of the shipping location to use for the order..</param>
        /// <param name="taxId">The tax number of the billing entity..</param>
        public TerminalOrderRequest(string billingEntityId = default(string), string customerOrderReference = default(string), List<OrderItem> items = default(List<OrderItem>), string shippingLocationId = default(string), string taxId = default(string))
        {
            this.BillingEntityId = billingEntityId;
            this.CustomerOrderReference = customerOrderReference;
            this.Items = items;
            this.ShippingLocationId = shippingLocationId;
            this.TaxId = taxId;
        }

        /// <summary>
        /// The identification of the billing entity to use for the order.
        /// </summary>
        /// <value>The identification of the billing entity to use for the order.</value>
        [DataMember(Name = "billingEntityId", EmitDefaultValue = false)]
        public string BillingEntityId { get; set; }

        /// <summary>
        /// The merchant-defined purchase order reference.
        /// </summary>
        /// <value>The merchant-defined purchase order reference.</value>
        [DataMember(Name = "customerOrderReference", EmitDefaultValue = false)]
        public string CustomerOrderReference { get; set; }

        /// <summary>
        /// The products included in the order.
        /// </summary>
        /// <value>The products included in the order.</value>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<OrderItem> Items { get; set; }

        /// <summary>
        /// The identification of the shipping location to use for the order.
        /// </summary>
        /// <value>The identification of the shipping location to use for the order.</value>
        [DataMember(Name = "shippingLocationId", EmitDefaultValue = false)]
        public string ShippingLocationId { get; set; }

        /// <summary>
        /// The tax number of the billing entity.
        /// </summary>
        /// <value>The tax number of the billing entity.</value>
        [DataMember(Name = "taxId", EmitDefaultValue = false)]
        public string TaxId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TerminalOrderRequest {\n");
            sb.Append("  BillingEntityId: ").Append(BillingEntityId).Append("\n");
            sb.Append("  CustomerOrderReference: ").Append(CustomerOrderReference).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  ShippingLocationId: ").Append(ShippingLocationId).Append("\n");
            sb.Append("  TaxId: ").Append(TaxId).Append("\n");
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
            return this.Equals(input as TerminalOrderRequest);
        }

        /// <summary>
        /// Returns true if TerminalOrderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TerminalOrderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TerminalOrderRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BillingEntityId == input.BillingEntityId ||
                    (this.BillingEntityId != null &&
                    this.BillingEntityId.Equals(input.BillingEntityId))
                ) && 
                (
                    this.CustomerOrderReference == input.CustomerOrderReference ||
                    (this.CustomerOrderReference != null &&
                    this.CustomerOrderReference.Equals(input.CustomerOrderReference))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.ShippingLocationId == input.ShippingLocationId ||
                    (this.ShippingLocationId != null &&
                    this.ShippingLocationId.Equals(input.ShippingLocationId))
                ) && 
                (
                    this.TaxId == input.TaxId ||
                    (this.TaxId != null &&
                    this.TaxId.Equals(input.TaxId))
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
                if (this.BillingEntityId != null)
                {
                    hashCode = (hashCode * 59) + this.BillingEntityId.GetHashCode();
                }
                if (this.CustomerOrderReference != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerOrderReference.GetHashCode();
                }
                if (this.Items != null)
                {
                    hashCode = (hashCode * 59) + this.Items.GetHashCode();
                }
                if (this.ShippingLocationId != null)
                {
                    hashCode = (hashCode * 59) + this.ShippingLocationId.GetHashCode();
                }
                if (this.TaxId != null)
                {
                    hashCode = (hashCode * 59) + this.TaxId.GetHashCode();
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
