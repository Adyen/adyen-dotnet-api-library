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
    /// RecurringDetailsRequest
    /// </summary>
    [DataContract]
    public partial class RecurringDetailsRequest :  IEquatable<RecurringDetailsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecurringDetailsRequest" /> class.
        /// </summary>
        /// <param name="MerchantAccount">the merchant account which will be used for processing this request.</param>
        /// <param name="Recurring">Recurring.</param>
        /// <param name="ShopperReference">a reference you use to uniquely identify the shopper (e.g. user ID or account ID).</param>
        public RecurringDetailsRequest(string MerchantAccount = default(string), Recurring Recurring = default(Recurring), string ShopperReference = default(string))
        {
            this.MerchantAccount = MerchantAccount;
            this.Recurring = Recurring;
            this.ShopperReference = ShopperReference;
        }
        
        /// <summary>
        /// the merchant account which will be used for processing this request
        /// </summary>
        /// <value>the merchant account which will be used for processing this request</value>
        [DataMember(Name="merchantAccount", EmitDefaultValue=false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// Gets or Sets Recurring
        /// </summary>
        [DataMember(Name="recurring", EmitDefaultValue=false)]
        public Recurring Recurring { get; set; }

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
            sb.Append("class RecurringDetailsRequest {\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  Recurring: ").Append(Recurring).Append("\n");
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
            return this.Equals(obj as RecurringDetailsRequest);
        }

        /// <summary>
        /// Returns true if RecurringDetailsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of RecurringDetailsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecurringDetailsRequest other)
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
                    this.Recurring == other.Recurring ||
                    this.Recurring != null &&
                    this.Recurring.Equals(other.Recurring)
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
                if (this.Recurring != null)
                    hash = hash * 59 + this.Recurring.GetHashCode();
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
