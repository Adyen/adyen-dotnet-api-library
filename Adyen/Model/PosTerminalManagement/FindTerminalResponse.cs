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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Adyen.Model.PosTerminalManagement
{
    /// <summary>
    /// FindTerminalResponse
    /// </summary>
    [DataContract]
    public partial class FindTerminalResponse :  IEquatable<FindTerminalResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FindTerminalResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FindTerminalResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FindTerminalResponse" /> class.
        /// </summary>
        /// <param name="companyAccount">The company account that the terminal is associated with. If this is the only account level shown in the response, the terminal is assigned to the inventory of the company account. (required).</param>
        /// <param name="merchantAccount">The merchant account that the terminal is associated with. If the response doesn&#39;t contain a &#x60;store&#x60; the terminal is assigned to this merchant account..</param>
        /// <param name="merchantInventory">Boolean that indicates if the terminal is assigned to the merchant inventory. This is returned when the terminal is assigned to a merchant account.  - If **true**, this indicates that the terminal is in the merchant inventory. This also means that the terminal cannot be boarded.  - If **false**, this indicates that the terminal is assigned to the merchant account as an in-store terminal. This means that the terminal is ready to be boarded, or is already boarded..</param>
        /// <param name="store">The store code of the store that the terminal is assigned to..</param>
        /// <param name="terminal">The unique terminal ID. (required).</param>
        public FindTerminalResponse(string companyAccount = default(string), string merchantAccount = default(string), bool merchantInventory = default(bool), string store = default(string), string terminal = default(string))
        {
            this.CompanyAccount = companyAccount;
            this.MerchantAccount = merchantAccount;
            this.MerchantInventory = merchantInventory;
            this.Store = store;
            this.Terminal = terminal;
        }

        /// <summary>
        /// The company account that the terminal is associated with. If this is the only account level shown in the response, the terminal is assigned to the inventory of the company account.
        /// </summary>
        /// <value>The company account that the terminal is associated with. If this is the only account level shown in the response, the terminal is assigned to the inventory of the company account.</value>
        [DataMember(Name="companyAccount", EmitDefaultValue=true)]
        public string CompanyAccount { get; set; }

        /// <summary>
        /// The merchant account that the terminal is associated with. If the response doesn&#39;t contain a &#x60;store&#x60; the terminal is assigned to this merchant account.
        /// </summary>
        /// <value>The merchant account that the terminal is associated with. If the response doesn&#39;t contain a &#x60;store&#x60; the terminal is assigned to this merchant account.</value>
        [DataMember(Name="merchantAccount", EmitDefaultValue=false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// Boolean that indicates if the terminal is assigned to the merchant inventory. This is returned when the terminal is assigned to a merchant account.  - If **true**, this indicates that the terminal is in the merchant inventory. This also means that the terminal cannot be boarded.  - If **false**, this indicates that the terminal is assigned to the merchant account as an in-store terminal. This means that the terminal is ready to be boarded, or is already boarded.
        /// </summary>
        /// <value>Boolean that indicates if the terminal is assigned to the merchant inventory. This is returned when the terminal is assigned to a merchant account.  - If **true**, this indicates that the terminal is in the merchant inventory. This also means that the terminal cannot be boarded.  - If **false**, this indicates that the terminal is assigned to the merchant account as an in-store terminal. This means that the terminal is ready to be boarded, or is already boarded.</value>
        [DataMember(Name="merchantInventory", EmitDefaultValue=false)]
        public bool MerchantInventory { get; set; }

        /// <summary>
        /// The store code of the store that the terminal is assigned to.
        /// </summary>
        /// <value>The store code of the store that the terminal is assigned to.</value>
        [DataMember(Name="store", EmitDefaultValue=false)]
        public string Store { get; set; }

        /// <summary>
        /// The unique terminal ID.
        /// </summary>
        /// <value>The unique terminal ID.</value>
        [DataMember(Name="terminal", EmitDefaultValue=true)]
        public string Terminal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FindTerminalResponse {\n");
            sb.Append("  CompanyAccount: ").Append(CompanyAccount).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  MerchantInventory: ").Append(MerchantInventory).Append("\n");
            sb.Append("  Store: ").Append(Store).Append("\n");
            sb.Append("  Terminal: ").Append(Terminal).Append("\n");
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
            return this.Equals(input as FindTerminalResponse);
        }

        /// <summary>
        /// Returns true if FindTerminalResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of FindTerminalResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FindTerminalResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CompanyAccount == input.CompanyAccount ||
                    (this.CompanyAccount != null &&
                    this.CompanyAccount.Equals(input.CompanyAccount))
                ) && 
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    (this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(input.MerchantAccount))
                ) && 
                (
                    this.MerchantInventory == input.MerchantInventory ||
                    (this.MerchantInventory != null &&
                    this.MerchantInventory.Equals(input.MerchantInventory))
                ) && 
                (
                    this.Store == input.Store ||
                    (this.Store != null &&
                    this.Store.Equals(input.Store))
                ) && 
                (
                    this.Terminal == input.Terminal ||
                    (this.Terminal != null &&
                    this.Terminal.Equals(input.Terminal))
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
                if (this.CompanyAccount != null)
                    hashCode = hashCode * 59 + this.CompanyAccount.GetHashCode();
                if (this.MerchantAccount != null)
                    hashCode = hashCode * 59 + this.MerchantAccount.GetHashCode();
                if (this.MerchantInventory != null)
                    hashCode = hashCode * 59 + this.MerchantInventory.GetHashCode();
                if (this.Store != null)
                    hashCode = hashCode * 59 + this.Store.GetHashCode();
                if (this.Terminal != null)
                    hashCode = hashCode * 59 + this.Terminal.GetHashCode();
                return hashCode;
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
