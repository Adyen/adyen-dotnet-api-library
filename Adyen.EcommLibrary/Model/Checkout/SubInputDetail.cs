using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.EcommLibrary.Model.Checkout
{
    /// <summary>
    /// SubInputDetail
    /// </summary>
    [DataContract]
    public partial class SubInputDetail : IEquatable<SubInputDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubInputDetail" /> class.
        /// </summary>
        /// <param name="Configuration">Configuration parameters for the required input..</param>
        /// <param name="Items">In case of a select, the items to choose from..</param>
        /// <param name="Key">The value to provide in the result..</param>
        /// <param name="Optional">True if this input is optional to provide..</param>
        /// <param name="Type">The type of the required input..</param>
        /// <param name="Value">The value can be pre-filled, if available..</param>
        public SubInputDetail(Dictionary<string, string> Configuration = default(Dictionary<string, string>),
            List<Item> Items = default(List<Item>), string Key = default(string), bool? Optional = default(bool?),
            string Type = default(string), string Value = default(string))
        {
            this.Configuration = Configuration;
            this.Items = Items;
            this.Key = Key;
            this.Optional = Optional;
            this.Type = Type;
            this.Value = Value;
        }

        /// <summary>
        /// Configuration parameters for the required input.
        /// </summary>
        /// <value>Configuration parameters for the required input.</value>
        [DataMember(Name = "configuration", EmitDefaultValue = false)]
        public Dictionary<string, string> Configuration { get; set; }

        /// <summary>
        /// In case of a select, the items to choose from.
        /// </summary>
        /// <value>In case of a select, the items to choose from.</value>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<Item> Items { get; set; }

        /// <summary>
        /// The value to provide in the result.
        /// </summary>
        /// <value>The value to provide in the result.</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// True if this input is optional to provide.
        /// </summary>
        /// <value>True if this input is optional to provide.</value>
        [DataMember(Name = "optional", EmitDefaultValue = false)]
        public bool? Optional { get; set; }

        /// <summary>
        /// The type of the required input.
        /// </summary>
        /// <value>The type of the required input.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// The value can be pre-filled, if available.
        /// </summary>
        /// <value>The value can be pre-filled, if available.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubInputDetail {\n");
            sb.Append("  Configuration: ").Append(Configuration).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Optional: ").Append(Optional).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return Equals(input as SubInputDetail);
        }

        /// <summary>
        /// Returns true if SubInputDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of SubInputDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubInputDetail input)
        {
            if (input == null)
                return false;

            return
                (
                    Configuration == input.Configuration ||
                    Configuration != null &&
                    Configuration.SequenceEqual(input.Configuration)
                ) &&
                (
                    Items == input.Items ||
                    Items != null &&
                    Items.SequenceEqual(input.Items)
                ) &&
                (
                    Key == input.Key ||
                    Key != null &&
                    Key.Equals(input.Key)
                ) &&
                (
                    Optional == input.Optional ||
                    Optional != null &&
                    Optional.Equals(input.Optional)
                ) &&
                (
                    Type == input.Type ||
                    Type != null &&
                    Type.Equals(input.Type)
                ) &&
                (
                    Value == input.Value ||
                    Value != null &&
                    Value.Equals(input.Value)
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
                var hashCode = 41;
                if (Configuration != null)
                    hashCode = hashCode * 59 + Configuration.GetHashCode();
                if (Items != null)
                    hashCode = hashCode * 59 + Items.GetHashCode();
                if (Key != null)
                    hashCode = hashCode * 59 + Key.GetHashCode();
                if (Optional != null)
                    hashCode = hashCode * 59 + Optional.GetHashCode();
                if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}