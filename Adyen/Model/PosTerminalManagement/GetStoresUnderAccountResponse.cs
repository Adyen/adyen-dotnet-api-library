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
    /// GetStoresUnderAccountResponse
    /// </summary>
    [DataContract(Name = "GetStoresUnderAccountResponse")]
    public partial class GetStoresUnderAccountResponse : IEquatable<GetStoresUnderAccountResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetStoresUnderAccountResponse" /> class.
        /// </summary>
        /// <param name="stores">Array that returns a list of all stores for the specified merchant account, or for all merchant accounts under the company account..</param>
        public GetStoresUnderAccountResponse(List<Store> stores = default(List<Store>))
        {
            this.Stores = stores;
        }

        /// <summary>
        /// Array that returns a list of all stores for the specified merchant account, or for all merchant accounts under the company account.
        /// </summary>
        /// <value>Array that returns a list of all stores for the specified merchant account, or for all merchant accounts under the company account.</value>
        [DataMember(Name = "stores", EmitDefaultValue = false)]
        public List<Store> Stores { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetStoresUnderAccountResponse {\n");
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
            return this.Equals(input as GetStoresUnderAccountResponse);
        }

        /// <summary>
        /// Returns true if GetStoresUnderAccountResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetStoresUnderAccountResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetStoresUnderAccountResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
