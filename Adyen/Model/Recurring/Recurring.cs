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
//  * Copyright (c) 2019 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using Adyen.Model.Enum;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.Model.Recurring
{
    /// <summary>
    /// Recurring
    /// </summary>
    [DataContract]
    public partial class Recurring :  IEquatable<Recurring>, IValidatableObject
    {
       
        /// <summary>
        /// The name of the token service.
        /// </summary>
        /// <value>The name of the token service.</value>
        [DataMember(Name="tokenService", EmitDefaultValue=false)]
        public TokenServiceEnum? TokenService { get; set; }
        /// <summary>
        /// The type of recurring contract to be used. Possible values: * &#x60;ONECLICK&#x60; – The shopper opts to store their card details for future use. The shopper is present for the subsequent transaction, for cards the security code (CVC/CVV) is required. * &#x60;RECURRING&#x60; – Payment details are stored for future use. For cards, the security code (CVC/CVV) is not required for subsequent payments. This is used for shopper not present transactions. * &#x60;ONECLICK, RECURRING&#x60; – Payment details are stored for future use. This allows the use of the stored payment details regardless of whether the shopper is on your site or not.
        /// </summary>
        /// <value>The type of recurring contract to be used. Possible values: * &#x60;ONECLICK&#x60; – The shopper opts to store their card details for future use. The shopper is present for the subsequent transaction, for cards the security code (CVC/CVV) is required. * &#x60;RECURRING&#x60; – Payment details are stored for future use. For cards, the security code (CVC/CVV) is not required for subsequent payments. This is used for shopper not present transactions. * &#x60;ONECLICK, RECURRING&#x60; – Payment details are stored for future use. This allows the use of the stored payment details regardless of whether the shopper is on your site or not.</value>
        [DataMember(Name="contract", EmitDefaultValue=false)]
        public Contract? Contract { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Recurring" /> class.
        /// </summary>
        /// <param name="TokenService">The name of the token service..</param>
        /// <param name="Contract">The type of recurring contract to be used. Possible values: * &#x60;ONECLICK&#x60; – The shopper opts to store their card details for future use. The shopper is present for the subsequent transaction, for cards the security code (CVC/CVV) is required. * &#x60;RECURRING&#x60; – Payment details are stored for future use. For cards, the security code (CVC/CVV) is not required for subsequent payments. This is used for shopper not present transactions. * &#x60;ONECLICK, RECURRING&#x60; – Payment details are stored for future use. This allows the use of the stored payment details regardless of whether the shopper is on your site or not..</param>
        /// <param name="RecurringDetailName">A descriptive name for this detail..</param>
        public Recurring(TokenServiceEnum? TokenService = default(TokenServiceEnum?), Contract? Contract = default(Contract?), string RecurringDetailName = default(string))
        {
            this.TokenService = TokenService;
            this.Contract = Contract;
            this.RecurringDetailName = RecurringDetailName;
        }
        


        /// <summary>
        /// A descriptive name for this detail.
        /// </summary>
        /// <value>A descriptive name for this detail.</value>
        [DataMember(Name="recurringDetailName", EmitDefaultValue=false)]
        public string RecurringDetailName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Recurring {\n");
            sb.Append("  TokenService: ").Append(TokenService).Append("\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  RecurringDetailName: ").Append(RecurringDetailName).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Recurring);
        }

        /// <summary>
        /// Returns true if Recurring instances are equal
        /// </summary>
        /// <param name="other">Instance of Recurring to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Recurring other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TokenService == other.TokenService ||
                    this.TokenService != null &&
                    this.TokenService.Equals(other.TokenService)
                ) && 
                (
                    this.Contract == other.Contract ||
                    this.Contract != null &&
                    this.Contract.Equals(other.Contract)
                ) && 
                (
                    this.RecurringDetailName == other.RecurringDetailName ||
                    this.RecurringDetailName != null &&
                    this.RecurringDetailName.Equals(other.RecurringDetailName)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.TokenService != null)
                    hash = hash * 59 + this.TokenService.GetHashCode();
                if (this.Contract != null)
                    hash = hash * 59 + this.Contract.GetHashCode();
                if (this.RecurringDetailName != null)
                    hash = hash * 59 + this.RecurringDetailName.GetHashCode();
                return hash;
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
