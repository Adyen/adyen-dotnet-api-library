/*
* Management API
*
*
* The version of the OpenAPI document: 1
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
    /// PaginationLinks
    /// </summary>
    [DataContract(Name = "PaginationLinks")]
    public partial class PaginationLinks : IEquatable<PaginationLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationLinks" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaginationLinks() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationLinks" /> class.
        /// </summary>
        /// <param name="first">first (required).</param>
        /// <param name="last">last (required).</param>
        /// <param name="next">next.</param>
        /// <param name="prev">prev.</param>
        /// <param name="self">self (required).</param>
        public PaginationLinks(LinksElement first = default(LinksElement), LinksElement last = default(LinksElement), LinksElement next = default(LinksElement), LinksElement prev = default(LinksElement), LinksElement self = default(LinksElement))
        {
            this.First = first;
            this.Last = last;
            this.Self = self;
            this.Next = next;
            this.Prev = prev;
        }

        /// <summary>
        /// Gets or Sets First
        /// </summary>
        [DataMember(Name = "first", IsRequired = false, EmitDefaultValue = false)]
        public LinksElement First { get; set; }

        /// <summary>
        /// Gets or Sets Last
        /// </summary>
        [DataMember(Name = "last", IsRequired = false, EmitDefaultValue = false)]
        public LinksElement Last { get; set; }

        /// <summary>
        /// Gets or Sets Next
        /// </summary>
        [DataMember(Name = "next", EmitDefaultValue = false)]
        public LinksElement Next { get; set; }

        /// <summary>
        /// Gets or Sets Prev
        /// </summary>
        [DataMember(Name = "prev", EmitDefaultValue = false)]
        public LinksElement Prev { get; set; }

        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name = "self", IsRequired = false, EmitDefaultValue = false)]
        public LinksElement Self { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaginationLinks {\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  Last: ").Append(Last).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
            sb.Append("  Prev: ").Append(Prev).Append("\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
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
            return this.Equals(input as PaginationLinks);
        }

        /// <summary>
        /// Returns true if PaginationLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of PaginationLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaginationLinks input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.First == input.First ||
                    (this.First != null &&
                    this.First.Equals(input.First))
                ) && 
                (
                    this.Last == input.Last ||
                    (this.Last != null &&
                    this.Last.Equals(input.Last))
                ) && 
                (
                    this.Next == input.Next ||
                    (this.Next != null &&
                    this.Next.Equals(input.Next))
                ) && 
                (
                    this.Prev == input.Prev ||
                    (this.Prev != null &&
                    this.Prev.Equals(input.Prev))
                ) && 
                (
                    this.Self == input.Self ||
                    (this.Self != null &&
                    this.Self.Equals(input.Self))
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
                if (this.First != null)
                {
                    hashCode = (hashCode * 59) + this.First.GetHashCode();
                }
                if (this.Last != null)
                {
                    hashCode = (hashCode * 59) + this.Last.GetHashCode();
                }
                if (this.Next != null)
                {
                    hashCode = (hashCode * 59) + this.Next.GetHashCode();
                }
                if (this.Prev != null)
                {
                    hashCode = (hashCode * 59) + this.Prev.GetHashCode();
                }
                if (this.Self != null)
                {
                    hashCode = (hashCode * 59) + this.Self.GetHashCode();
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
