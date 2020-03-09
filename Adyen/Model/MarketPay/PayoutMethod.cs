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

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// PayoutMethod
    /// </summary>
    [DataContract]
        public partial class PayoutMethod :  IEquatable<PayoutMethod>, IValidatableObject
    {
        /// <summary>
        /// Defines PayoutMethodType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum PayoutMethodTypeEnum
        {
            /// <summary>
            /// Enum CardToken for value: CardToken
            /// </summary>
            [EnumMember(Value = "CardToken")]
            CardToken = 1        }
        /// <summary>
        /// Gets or Sets PayoutMethodType
        /// </summary>
        [DataMember(Name="payoutMethodType", EmitDefaultValue=false)]
        public PayoutMethodTypeEnum? PayoutMethodType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutMethod" /> class.
        /// </summary>
        /// <param name="merchantAccount">merchantAccount (required).</param>
        /// <param name="payoutMethodCode">payoutMethodCode.</param>
        /// <param name="payoutMethodType">payoutMethodType.</param>
        /// <param name="recurringDetailReference">recurringDetailReference (required).</param>
        /// <param name="shopperReference">shopperReference (required).</param>
        public PayoutMethod(string merchantAccount = default(string), string payoutMethodCode = default(string), PayoutMethodTypeEnum? payoutMethodType = default(PayoutMethodTypeEnum?), string recurringDetailReference = default(string), string shopperReference = default(string))
        {
            // to ensure "merchantAccount" is required (not null)
            if (merchantAccount == null)
            {
                throw new InvalidDataException("merchantAccount is a required property for PayoutMethod and cannot be null");
            }
            else
            {
                this.MerchantAccount = merchantAccount;
            }
            // to ensure "recurringDetailReference" is required (not null)
            if (recurringDetailReference == null)
            {
                throw new InvalidDataException("recurringDetailReference is a required property for PayoutMethod and cannot be null");
            }
            else
            {
                this.RecurringDetailReference = recurringDetailReference;
            }
            // to ensure "shopperReference" is required (not null)
            if (shopperReference == null)
            {
                throw new InvalidDataException("shopperReference is a required property for PayoutMethod and cannot be null");
            }
            else
            {
                this.ShopperReference = shopperReference;
            }
            this.PayoutMethodCode = payoutMethodCode;
            this.PayoutMethodType = payoutMethodType;
        }
        
        /// <summary>
        /// Gets or Sets MerchantAccount
        /// </summary>
        [DataMember(Name="merchantAccount", EmitDefaultValue=false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// Gets or Sets PayoutMethodCode
        /// </summary>
        [DataMember(Name="payoutMethodCode", EmitDefaultValue=false)]
        public string PayoutMethodCode { get; set; }


        /// <summary>
        /// Gets or Sets RecurringDetailReference
        /// </summary>
        [DataMember(Name="recurringDetailReference", EmitDefaultValue=false)]
        public string RecurringDetailReference { get; set; }

        /// <summary>
        /// Gets or Sets ShopperReference
        /// </summary>
        [DataMember(Name="shopperReference", EmitDefaultValue=false)]
        public string ShopperReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayoutMethod {\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  PayoutMethodCode: ").Append(PayoutMethodCode).Append("\n");
            sb.Append("  PayoutMethodType: ").Append(PayoutMethodType).Append("\n");
            sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
            sb.Append("  ShopperReference: ").Append(ShopperReference).Append("\n");
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
            return this.Equals(input as PayoutMethod);
        }

        /// <summary>
        /// Returns true if PayoutMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of PayoutMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayoutMethod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    (this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(input.MerchantAccount))
                ) && 
                (
                    this.PayoutMethodCode == input.PayoutMethodCode ||
                    (this.PayoutMethodCode != null &&
                    this.PayoutMethodCode.Equals(input.PayoutMethodCode))
                ) && 
                (
                    this.PayoutMethodType == input.PayoutMethodType ||
                    (this.PayoutMethodType != null &&
                    this.PayoutMethodType.Equals(input.PayoutMethodType))
                ) && 
                (
                    this.RecurringDetailReference == input.RecurringDetailReference ||
                    (this.RecurringDetailReference != null &&
                    this.RecurringDetailReference.Equals(input.RecurringDetailReference))
                ) && 
                (
                    this.ShopperReference == input.ShopperReference ||
                    (this.ShopperReference != null &&
                    this.ShopperReference.Equals(input.ShopperReference))
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
                if (this.MerchantAccount != null)
                    hashCode = hashCode * 59 + this.MerchantAccount.GetHashCode();
                if (this.PayoutMethodCode != null)
                    hashCode = hashCode * 59 + this.PayoutMethodCode.GetHashCode();
                if (this.PayoutMethodType != null)
                    hashCode = hashCode * 59 + this.PayoutMethodType.GetHashCode();
                if (this.RecurringDetailReference != null)
                    hashCode = hashCode * 59 + this.RecurringDetailReference.GetHashCode();
                if (this.ShopperReference != null)
                    hashCode = hashCode * 59 + this.ShopperReference.GetHashCode();
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
