/*
* POS Terminal Management API
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

namespace Adyen.Model.PosTerminalManagement
{
    /// <summary>
    /// MerchantAccount
    /// </summary>
    [DataContract(Name = "MerchantAccount")]
    public partial class MerchantAccount : IEquatable<MerchantAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantAccount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MerchantAccount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantAccount" /> class.
        /// </summary>
        /// <param name="inStoreTerminals">List of terminals assigned to this merchant account as in-store terminals. This means that the terminal is ready to be boarded, or is already boarded..</param>
        /// <param name="inventoryTerminals">List of terminals assigned to the inventory of this merchant account..</param>
        /// <param name="merchantAccount">The merchant account. (required).</param>
        /// <param name="stores">Array of stores under this merchant account..</param>
        public MerchantAccount(List<string> inStoreTerminals = default(List<string>), List<string> inventoryTerminals = default(List<string>), string merchantAccount = default(string), List<Store> stores = default(List<Store>))
        {
            this._MerchantAccount = merchantAccount;
            this.InStoreTerminals = inStoreTerminals;
            this.InventoryTerminals = inventoryTerminals;
            this.Stores = stores;
        }

        /// <summary>
        /// List of terminals assigned to this merchant account as in-store terminals. This means that the terminal is ready to be boarded, or is already boarded.
        /// </summary>
        /// <value>List of terminals assigned to this merchant account as in-store terminals. This means that the terminal is ready to be boarded, or is already boarded.</value>
        [DataMember(Name = "inStoreTerminals", EmitDefaultValue = false)]
        public List<string> InStoreTerminals { get; set; }

        /// <summary>
        /// List of terminals assigned to the inventory of this merchant account.
        /// </summary>
        /// <value>List of terminals assigned to the inventory of this merchant account.</value>
        [DataMember(Name = "inventoryTerminals", EmitDefaultValue = false)]
        public List<string> InventoryTerminals { get; set; }

        /// <summary>
        /// The merchant account.
        /// </summary>
        /// <value>The merchant account.</value>
        [DataMember(Name = "merchantAccount", IsRequired = false, EmitDefaultValue = false)]
        public string _MerchantAccount { get; set; }

        /// <summary>
        /// Array of stores under this merchant account.
        /// </summary>
        /// <value>Array of stores under this merchant account.</value>
        [DataMember(Name = "stores", EmitDefaultValue = false)]
        public List<Store> Stores { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MerchantAccount {\n");
            sb.Append("  InStoreTerminals: ").Append(InStoreTerminals).Append("\n");
            sb.Append("  InventoryTerminals: ").Append(InventoryTerminals).Append("\n");
            sb.Append("  _MerchantAccount: ").Append(_MerchantAccount).Append("\n");
            sb.Append("  Stores: ").Append(Stores).Append("\n");
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
            return this.Equals(input as MerchantAccount);
        }

        /// <summary>
        /// Returns true if MerchantAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantAccount input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InStoreTerminals == input.InStoreTerminals ||
                    this.InStoreTerminals != null &&
                    input.InStoreTerminals != null &&
                    this.InStoreTerminals.SequenceEqual(input.InStoreTerminals)
                ) && 
                (
                    this.InventoryTerminals == input.InventoryTerminals ||
                    this.InventoryTerminals != null &&
                    input.InventoryTerminals != null &&
                    this.InventoryTerminals.SequenceEqual(input.InventoryTerminals)
                ) && 
                (
                    this._MerchantAccount == input._MerchantAccount ||
                    (this._MerchantAccount != null &&
                    this._MerchantAccount.Equals(input._MerchantAccount))
                ) && 
                (
                    this.Stores == input.Stores ||
                    this.Stores != null &&
                    input.Stores != null &&
                    this.Stores.SequenceEqual(input.Stores)
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
                if (this.InStoreTerminals != null)
                {
                    hashCode = (hashCode * 59) + this.InStoreTerminals.GetHashCode();
                }
                if (this.InventoryTerminals != null)
                {
                    hashCode = (hashCode * 59) + this.InventoryTerminals.GetHashCode();
                }
                if (this._MerchantAccount != null)
                {
                    hashCode = (hashCode * 59) + this._MerchantAccount.GetHashCode();
                }
                if (this.Stores != null)
                {
                    hashCode = (hashCode * 59) + this.Stores.GetHashCode();
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
