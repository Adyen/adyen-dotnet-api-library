#region Licence

// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2020 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// Configuration
    /// </summary>
    [DataContract]
    public partial class Configuration : IEquatable<Configuration>, IValidatableObject
    {
        /// <summary>
        /// Determines whether the cardholder name should be provided or not.  Permitted values: * NONE * OPTIONAL * REQUIRED
        /// </summary>
        /// <value>Determines whether the cardholder name should be provided or not.  Permitted values: * NONE * OPTIONAL * REQUIRED</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CardHolderNameEnum
        {
            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            [EnumMember(Value = "NONE")] NONE = 1,

            /// <summary>
            /// Enum OPTIONAL for value: OPTIONAL
            /// </summary>
            [EnumMember(Value = "OPTIONAL")] OPTIONAL = 2,

            /// <summary>
            /// Enum REQUIRED for value: REQUIRED
            /// </summary>
            [EnumMember(Value = "REQUIRED")] REQUIRED = 3
        }

        /// <summary>
        /// Determines whether the cardholder name should be provided or not.  Permitted values: * NONE * OPTIONAL * REQUIRED
        /// </summary>
        /// <value>Determines whether the cardholder name should be provided or not.  Permitted values: * NONE * OPTIONAL * REQUIRED</value>
        [DataMember(Name = "cardHolderName", EmitDefaultValue = false)]
        public CardHolderNameEnum? CardHolderName { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration" /> class.
        /// </summary>
        /// <param name="avs">avs.</param>
        /// <param name="cardHolderName">Determines whether the cardholder name should be provided or not.  Permitted values: * NONE * OPTIONAL * REQUIRED.</param>
        /// <param name="installments">installments.</param>
        /// <param name="shopperInput">shopperInput.</param>
        public Configuration(Avs avs = default(Avs), CardHolderNameEnum? cardHolderName = default(CardHolderNameEnum?),
            Installments2 installments = default(Installments2), ShopperInput shopperInput = default(ShopperInput))
        {
            this.Avs = avs;
            this.CardHolderName = cardHolderName;
            this.Installments = installments;
            this.ShopperInput = shopperInput;
        }

        /// <summary>
        /// Gets or Sets Avs
        /// </summary>
        [DataMember(Name = "avs", EmitDefaultValue = false)]
        public Avs Avs { get; set; }


        /// <summary>
        /// Gets or Sets Installments
        /// </summary>
        [DataMember(Name = "installments", EmitDefaultValue = false)]
        public Installments2 Installments { get; set; }

        /// <summary>
        /// Gets or Sets ShopperInput
        /// </summary>
        [DataMember(Name = "shopperInput", EmitDefaultValue = false)]
        public ShopperInput ShopperInput { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Configuration {\n");
            sb.Append("  Avs: ").Append(Avs).Append("\n");
            sb.Append("  CardHolderName: ").Append(CardHolderName).Append("\n");
            sb.Append("  Installments: ").Append(Installments).Append("\n");
            sb.Append("  ShopperInput: ").Append(ShopperInput).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as Configuration);
        }

        /// <summary>
        /// Returns true if Configuration instances are equal
        /// </summary>
        /// <param name="input">Instance of Configuration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Configuration input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Avs == input.Avs ||
                    this.Avs != null &&
                    this.Avs.Equals(input.Avs)
                ) &&
                (
                    this.CardHolderName == input.CardHolderName ||
                    this.CardHolderName != null &&
                    this.CardHolderName.Equals(input.CardHolderName)
                ) &&
                (
                    this.Installments == input.Installments ||
                    this.Installments != null &&
                    this.Installments.Equals(input.Installments)
                ) &&
                (
                    this.ShopperInput == input.ShopperInput ||
                    this.ShopperInput != null &&
                    this.ShopperInput.Equals(input.ShopperInput)
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
                if (this.Avs != null)
                    hashCode = hashCode * 59 + this.Avs.GetHashCode();
                if (this.CardHolderName != null)
                    hashCode = hashCode * 59 + this.CardHolderName.GetHashCode();
                if (this.Installments != null)
                    hashCode = hashCode * 59 + this.Installments.GetHashCode();
                if (this.ShopperInput != null)
                    hashCode = hashCode * 59 + this.ShopperInput.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext)
        {
            yield break;
        }
    }
}