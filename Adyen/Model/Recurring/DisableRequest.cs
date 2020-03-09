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

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.Model.Recurring
{
    /// <summary>
    /// DisableRequest
    /// </summary>
    [DataContract]
    public partial class DisableRequest :  IEquatable<DisableRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DisableRequest" /> class.
        /// </summary>
        /// <param name="MerchantAccount">the merchant account which will be used for processing this request.</param>
        /// <param name="Contract">specify the contract if you only want to disable a specific use.</param>
        /// <param name="RecurringDetailReference">the recurring detail you wish to disable.</param>
        /// <param name="ShopperReference">a reference you use to uniquely identify the shopper (e.g. user ID or account ID).</param>
        public DisableRequest(string MerchantAccount = default(string), string Contract = default(string), string RecurringDetailReference = default(string), string ShopperReference = default(string))
        {
            this.MerchantAccount = MerchantAccount;
            this.Contract = Contract;
            this.RecurringDetailReference = RecurringDetailReference;
            this.ShopperReference = ShopperReference;
        }
        
        /// <summary>
        /// the merchant account which will be used for processing this request
        /// </summary>
        /// <value>the merchant account which will be used for processing this request</value>
        [DataMember(Name="merchantAccount", EmitDefaultValue=false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// specify the contract if you only want to disable a specific use
        /// </summary>
        /// <value>specify the contract if you only want to disable a specific use</value>
        [DataMember(Name="contract", EmitDefaultValue=false)]
        public string Contract { get; set; }

        /// <summary>
        /// the recurring detail you wish to disable
        /// </summary>
        /// <value>the recurring detail you wish to disable</value>
        [DataMember(Name="recurringDetailReference", EmitDefaultValue=false)]
        public string RecurringDetailReference { get; set; }

        /// <summary>
        /// a reference you use to uniquely identify the shopper (e.g. user ID or account ID)
        /// </summary>
        /// <value>a reference you use to uniquely identify the shopper (e.g. user ID or account ID)</value>
        [DataMember(Name="shopperReference", EmitDefaultValue=false)]
        public string ShopperReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisableRequest {\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
            sb.Append("  ShopperReference: ").Append(ShopperReference).Append("\n");
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
            return this.Equals(obj as DisableRequest);
        }

        /// <summary>
        /// Returns true if DisableRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of DisableRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DisableRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MerchantAccount == other.MerchantAccount ||
                    this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(other.MerchantAccount)
                ) && 
                (
                    this.Contract == other.Contract ||
                    this.Contract != null &&
                    this.Contract.Equals(other.Contract)
                ) && 
                (
                    this.RecurringDetailReference == other.RecurringDetailReference ||
                    this.RecurringDetailReference != null &&
                    this.RecurringDetailReference.Equals(other.RecurringDetailReference)
                ) && 
                (
                    this.ShopperReference == other.ShopperReference ||
                    this.ShopperReference != null &&
                    this.ShopperReference.Equals(other.ShopperReference)
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
                if (this.MerchantAccount != null)
                    hash = hash * 59 + this.MerchantAccount.GetHashCode();
                if (this.Contract != null)
                    hash = hash * 59 + this.Contract.GetHashCode();
                if (this.RecurringDetailReference != null)
                    hash = hash * 59 + this.RecurringDetailReference.GetHashCode();
                if (this.ShopperReference != null)
                    hash = hash * 59 + this.ShopperReference.GetHashCode();
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
