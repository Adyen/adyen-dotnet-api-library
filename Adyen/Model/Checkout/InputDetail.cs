#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// InputDetail
    /// </summary>
    [DataContract]
    public partial class InputDetail :  IEquatable<InputDetail>, IValidatableObject
    {
        /// <summary>
        /// The type of validation to be applied to the input value.
        /// </summary>
        /// <value>The type of validation to be applied to the input value.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ValidationTypeEnum
        {
            
            /// <summary>
            /// Enum IBAN for value: IBAN
            /// </summary>
            [EnumMember(Value = "IBAN")]
            IBAN = 1,
            
            /// <summary>
            /// Enum Name for value: Name
            /// </summary>
            [EnumMember(Value = "Name")]
            Name = 2
        }

        /// <summary>
        /// The type of validation to be applied to the input value.
        /// </summary>
        /// <value>The type of validation to be applied to the input value.</value>
        [DataMember(Name="validationType", EmitDefaultValue=false)]
        public ValidationTypeEnum? ValidationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InputDetail" /> class.
        /// </summary>
        /// <param name="Configuration">Configuration parameters for the required input..</param>
        /// <param name="Details">Input details can also be provided recursively..</param>
        /// <param name="ItemSearchUrl">In case of a select, the URL from which to query the items..</param>
        /// <param name="Items">In case of a select, the items to choose from..</param>
        /// <param name="Key">The value to provide in the result..</param>
        /// <param name="Name">The default name for this input field, which will be displayed by the SDKs..</param>
        /// <param name="Optional">True if this input value is optional..</param>
        /// <param name="Type">The type of the required input..</param>
        /// <param name="ValidationType">The type of validation to be applied to the input value..</param>
        /// <param name="Value">The value can be pre-filled, if available..</param>
        public InputDetail(Dictionary<string, string> Configuration = default(Dictionary<string, string>), List<SubInputDetail> Details = default(List<SubInputDetail>), string ItemSearchUrl = default(string), List<Item> Items = default(List<Item>), string Key = default(string), string Name = default(string), bool? Optional = default(bool?), string Type = default(string), ValidationTypeEnum? ValidationType = default(ValidationTypeEnum?), string Value = default(string))
        {
            this.Configuration = Configuration;
            this.Details = Details;
            this.ItemSearchUrl = ItemSearchUrl;
            this.Items = Items;
            this.Key = Key;
            this.Name = Name;
            this.Optional = Optional;
            this.Type = Type;
            this.ValidationType = ValidationType;
            this.Value = Value;
        }
        
        /// <summary>
        /// Configuration parameters for the required input.
        /// </summary>
        /// <value>Configuration parameters for the required input.</value>
        [DataMember(Name="configuration", EmitDefaultValue=false)]
        public Dictionary<string, string> Configuration { get; set; }

        /// <summary>
        /// Input details can also be provided recursively.
        /// </summary>
        /// <value>Input details can also be provided recursively.</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public List<SubInputDetail> Details { get; set; }

        /// <summary>
        /// In case of a select, the URL from which to query the items.
        /// </summary>
        /// <value>In case of a select, the URL from which to query the items.</value>
        [DataMember(Name="itemSearchUrl", EmitDefaultValue=false)]
        public string ItemSearchUrl { get; set; }

        /// <summary>
        /// In case of a select, the items to choose from.
        /// </summary>
        /// <value>In case of a select, the items to choose from.</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<Item> Items { get; set; }

        /// <summary>
        /// The value to provide in the result.
        /// </summary>
        /// <value>The value to provide in the result.</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// The default name for this input field, which will be displayed by the SDKs.
        /// </summary>
        /// <value>The default name for this input field, which will be displayed by the SDKs.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// True if this input value is optional.
        /// </summary>
        /// <value>True if this input value is optional.</value>
        [DataMember(Name="optional", EmitDefaultValue=false)]
        public bool? Optional { get; set; }

        /// <summary>
        /// The type of the required input.
        /// </summary>
        /// <value>The type of the required input.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }


        /// <summary>
        /// The value can be pre-filled, if available.
        /// </summary>
        /// <value>The value can be pre-filled, if available.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InputDetail {\n");
            sb.Append("  Configuration: ").Append(Configuration).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  ItemSearchUrl: ").Append(ItemSearchUrl).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Optional: ").Append(Optional).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ValidationType: ").Append(ValidationType).Append("\n");
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
            return this.Equals(input as InputDetail);
        }

        /// <summary>
        /// Returns true if InputDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of InputDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InputDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Configuration == input.Configuration ||
                    this.Configuration != null &&
                    this.Configuration.SequenceEqual(input.Configuration)
                ) && 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && 
                (
                    this.ItemSearchUrl == input.ItemSearchUrl ||
                    (this.ItemSearchUrl != null &&
                    this.ItemSearchUrl.Equals(input.ItemSearchUrl))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Optional == input.Optional ||
                    (this.Optional != null &&
                    this.Optional.Equals(input.Optional))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ValidationType == input.ValidationType ||
                    (this.ValidationType != null &&
                    this.ValidationType.Equals(input.ValidationType))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Configuration != null)
                    hashCode = hashCode * 59 + this.Configuration.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.ItemSearchUrl != null)
                    hashCode = hashCode * 59 + this.ItemSearchUrl.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Optional != null)
                    hashCode = hashCode * 59 + this.Optional.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ValidationType != null)
                    hashCode = hashCode * 59 + this.ValidationType.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
