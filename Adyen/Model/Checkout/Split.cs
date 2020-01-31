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
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// Split
    /// </summary>
    [DataContract]
    public partial class Split :  IEquatable<Split>, IValidatableObject
    {
        /// <summary>
        /// The type of this split.  &gt;Permitted values: &#x60;Default&#x60;, &#x60;PaymentFee&#x60;, &#x60;VAT&#x60;, &#x60;Commission&#x60;, &#x60;MarketPlace&#x60;, &#x60;Verification&#x60;.
        /// </summary>
        /// <value>The type of this split.  &gt;Permitted values: &#x60;Default&#x60;, &#x60;PaymentFee&#x60;, &#x60;VAT&#x60;, &#x60;Commission&#x60;, &#x60;MarketPlace&#x60;, &#x60;Verification&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Commission for value: Commission
            /// </summary>
            [EnumMember(Value = "Commission")]
            Commission = 1,
            
            /// <summary>
            /// Enum Default for value: Default
            /// </summary>
            [EnumMember(Value = "Default")]
            Default = 2,
            
            /// <summary>
            /// Enum MarketPlace for value: MarketPlace
            /// </summary>
            [EnumMember(Value = "MarketPlace")]
            MarketPlace = 3,
            
            /// <summary>
            /// Enum PaymentFee for value: PaymentFee
            /// </summary>
            [EnumMember(Value = "PaymentFee")]
            PaymentFee = 4,
            
            /// <summary>
            /// Enum VAT for value: VAT
            /// </summary>
            [EnumMember(Value = "VAT")]
            VAT = 5,
            
            /// <summary>
            /// Enum Verification for value: Verification
            /// </summary>
            [EnumMember(Value = "Verification")]
            Verification = 6
        }

        /// <summary>
        /// The type of this split.  &gt;Permitted values: &#x60;Default&#x60;, &#x60;PaymentFee&#x60;, &#x60;VAT&#x60;, &#x60;Commission&#x60;, &#x60;MarketPlace&#x60;, &#x60;Verification&#x60;.
        /// </summary>
        /// <value>The type of this split.  &gt;Permitted values: &#x60;Default&#x60;, &#x60;PaymentFee&#x60;, &#x60;VAT&#x60;, &#x60;Commission&#x60;, &#x60;MarketPlace&#x60;, &#x60;Verification&#x60;.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Split" /> class.
        /// </summary>
        [JsonConstructor]
        protected Split() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Split" /> class.
        /// </summary>
        /// <param name="Account">The account to which this split applies.  &gt;Required if the type is &#x60;MarketPlace&#x60;..</param>
        /// <param name="Amount">The amount of this split. (required).</param>
        /// <param name="Description">A description of this split..</param>
        /// <param name="Reference">The reference of this split. Used to link other operations (e.g. captures and refunds) to this split.  &gt;Required if the type is &#x60;MarketPlace&#x60;..</param>
        /// <param name="Type">The type of this split.  &gt;Permitted values: &#x60;Default&#x60;, &#x60;PaymentFee&#x60;, &#x60;VAT&#x60;, &#x60;Commission&#x60;, &#x60;MarketPlace&#x60;, &#x60;Verification&#x60;. (required).</param>
        public Split(string Account = default(string), SplitAmount Amount = default(SplitAmount), string Description = default(string), string Reference = default(string), TypeEnum Type = default(TypeEnum))
        {
            // to ensure "Amount" is required (not null)
            if (Amount == null)
            {
                throw new InvalidDataException("Amount is a required property for Split and cannot be null");
            }
            else
            {
                this.Amount = Amount;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for Split and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.Account = Account;
            this.Description = Description;
            this.Reference = Reference;
        }
        
        /// <summary>
        /// The account to which this split applies.  &gt;Required if the type is &#x60;MarketPlace&#x60;.
        /// </summary>
        /// <value>The account to which this split applies.  &gt;Required if the type is &#x60;MarketPlace&#x60;.</value>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public string Account { get; set; }

        /// <summary>
        /// The amount of this split.
        /// </summary>
        /// <value>The amount of this split.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public SplitAmount Amount { get; set; }

        /// <summary>
        /// A description of this split.
        /// </summary>
        /// <value>A description of this split.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The reference of this split. Used to link other operations (e.g. captures and refunds) to this split.  &gt;Required if the type is &#x60;MarketPlace&#x60;.
        /// </summary>
        /// <value>The reference of this split. Used to link other operations (e.g. captures and refunds) to this split.  &gt;Required if the type is &#x60;MarketPlace&#x60;.</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Split {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as Split);
        }

        /// <summary>
        /// Returns true if Split instances are equal
        /// </summary>
        /// <param name="input">Instance of Split to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Split input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
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
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
