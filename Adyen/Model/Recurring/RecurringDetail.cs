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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.Model.Recurring
{
    /// <summary>
    /// RecurringDetail
    /// </summary>
    [DataContract]
    public partial class RecurringDetail :  IEquatable<RecurringDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecurringDetail" /> class.
        /// </summary>
        /// <param name="TokenDetails">TokenDetails.</param>
        /// <param name="SocialSecurityNumber">SocialSecurityNumber.</param>
        /// <param name="FirstPspReference">FirstPspReference.</param>
        /// <param name="CreationDate">CreationDate.</param>
        /// <param name="Acquirer">Acquirer.</param>
        /// <param name="Bank">Bank.</param>
        /// <param name="ShopperName">ShopperName.</param>
        /// <param name="AcquirerAccount">AcquirerAccount.</param>
        /// <param name="AliasType">AliasType.</param>
        /// <param name="Name">An optional descriptive name for this recurring detail.</param>
        /// <param name="Variant">Variant.</param>
        /// <param name="RecurringDetailReference">The reference that uniquely identifies the recurring detail.</param>
        /// <param name="Alias">Alias.</param>
        /// <param name="ContractTypes">ContractTypes.</param>
        /// <param name="PaymentMethodVariant">PaymentMethodVariant.</param>
        /// <param name="BillingAddress">BillingAddress.</param>
        /// <param name="AdditionalData">AdditionalData.</param>
        /// <param name="Card">Card.</param>
        public RecurringDetail(TokenDetails TokenDetails = default(TokenDetails), string SocialSecurityNumber = default(string), string FirstPspReference = default(string), DateTime? CreationDate = default(DateTime?), string Acquirer = default(string), BankAccount Bank = default(BankAccount), Name ShopperName = default(Name), string AcquirerAccount = default(string), string AliasType = default(string), string Name = default(string), string Variant = default(string), string RecurringDetailReference = default(string), string Alias = default(string), List<string> ContractTypes = default(List<string>), string PaymentMethodVariant = default(string), Address BillingAddress = default(Address), Dictionary<string, string> AdditionalData = default(Dictionary<string, string>), Card Card = default(Card))
        {
            this.TokenDetails = TokenDetails;
            this.SocialSecurityNumber = SocialSecurityNumber;
            this.FirstPspReference = FirstPspReference;
            this.CreationDate = CreationDate;
            this.Acquirer = Acquirer;
          
            this.Bank = Bank;
            this.ShopperName = ShopperName;
            this.AcquirerAccount = AcquirerAccount;
            this.AliasType = AliasType;
            this.Name = Name;
            this.Variant = Variant;
            this.RecurringDetailReference = RecurringDetailReference;
            this.Alias = Alias;
            this.ContractTypes = ContractTypes;
            this.PaymentMethodVariant = PaymentMethodVariant;
            this.BillingAddress = BillingAddress;
            this.AdditionalData = AdditionalData;
            this.Card = Card;
        }
        
        /// <summary>
        /// Gets or Sets TokenDetails
        /// </summary>
        [DataMember(Name="tokenDetails", EmitDefaultValue=false)]
        public TokenDetails TokenDetails { get; set; }

        /// <summary>
        /// Gets or Sets SocialSecurityNumber
        /// </summary>
        [DataMember(Name="socialSecurityNumber", EmitDefaultValue=false)]
        public string SocialSecurityNumber { get; set; }

        /// <summary>
        /// Gets or Sets FirstPspReference
        /// </summary>
        [DataMember(Name="firstPspReference", EmitDefaultValue=false)]
        public string FirstPspReference { get; set; }

        /// <summary>
        /// Gets or Sets CreationDate
        /// </summary>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Gets or Sets Acquirer
        /// </summary>
        [DataMember(Name="acquirer", EmitDefaultValue=false)]
        public string Acquirer { get; set; }

       

        /// <summary>
        /// Gets or Sets Bank
        /// </summary>
        [DataMember(Name="bank", EmitDefaultValue=false)]
        public BankAccount Bank { get; set; }

        /// <summary>
        /// Gets or Sets ShopperName
        /// </summary>
        [DataMember(Name="shopperName", EmitDefaultValue=false)]
        public Name ShopperName { get; set; }

        /// <summary>
        /// Gets or Sets AcquirerAccount
        /// </summary>
        [DataMember(Name="acquirerAccount", EmitDefaultValue=false)]
        public string AcquirerAccount { get; set; }

        /// <summary>
        /// Gets or Sets AliasType
        /// </summary>
        [DataMember(Name="aliasType", EmitDefaultValue=false)]
        public string AliasType { get; set; }

        /// <summary>
        /// An optional descriptive name for this recurring detail
        /// </summary>
        /// <value>An optional descriptive name for this recurring detail</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Variant
        /// </summary>
        [DataMember(Name="variant", EmitDefaultValue=false)]
        public string Variant { get; set; }

        /// <summary>
        /// The reference that uniquely identifies the recurring detail
        /// </summary>
        /// <value>The reference that uniquely identifies the recurring detail</value>
        [DataMember(Name="recurringDetailReference", EmitDefaultValue=false)]
        public string RecurringDetailReference { get; set; }

        /// <summary>
        /// Gets or Sets Alias
        /// </summary>
        [DataMember(Name="alias", EmitDefaultValue=false)]
        public string Alias { get; set; }

        /// <summary>
        /// Gets or Sets ContractTypes
        /// </summary>
        [DataMember(Name="contractTypes", EmitDefaultValue=false)]
        public List<string> ContractTypes { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethodVariant
        /// </summary>
        [DataMember(Name="paymentMethodVariant", EmitDefaultValue=false)]
        public string PaymentMethodVariant { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name="billingAddress", EmitDefaultValue=false)]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalData
        /// </summary>
        [DataMember(Name="additionalData", EmitDefaultValue=false)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// Gets or Sets Card
        /// </summary>
        [DataMember(Name="card", EmitDefaultValue=false)]
        public Card Card { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecurringDetail {\n");
            sb.Append("  TokenDetails: ").Append(TokenDetails).Append("\n");
            sb.Append("  SocialSecurityNumber: ").Append(SocialSecurityNumber).Append("\n");
            sb.Append("  FirstPspReference: ").Append(FirstPspReference).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  Acquirer: ").Append(Acquirer).Append("\n");
           
            sb.Append("  Bank: ").Append(Bank).Append("\n");
            sb.Append("  ShopperName: ").Append(ShopperName).Append("\n");
            sb.Append("  AcquirerAccount: ").Append(AcquirerAccount).Append("\n");
            sb.Append("  AliasType: ").Append(AliasType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Variant: ").Append(Variant).Append("\n");
            sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  ContractTypes: ").Append(ContractTypes).Append("\n");
            sb.Append("  PaymentMethodVariant: ").Append(PaymentMethodVariant).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
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
            return this.Equals(obj as RecurringDetail);
        }

        /// <summary>
        /// Returns true if RecurringDetail instances are equal
        /// </summary>
        /// <param name="other">Instance of RecurringDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecurringDetail other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TokenDetails == other.TokenDetails ||
                    this.TokenDetails != null &&
                    this.TokenDetails.Equals(other.TokenDetails)
                ) && 
                (
                    this.SocialSecurityNumber == other.SocialSecurityNumber ||
                    this.SocialSecurityNumber != null &&
                    this.SocialSecurityNumber.Equals(other.SocialSecurityNumber)
                ) && 
                (
                    this.FirstPspReference == other.FirstPspReference ||
                    this.FirstPspReference != null &&
                    this.FirstPspReference.Equals(other.FirstPspReference)
                ) && 
                (
                    this.CreationDate == other.CreationDate ||
                    this.CreationDate != null &&
                    this.CreationDate.Equals(other.CreationDate)
                ) && 
                (
                    this.Acquirer == other.Acquirer ||
                    this.Acquirer != null &&
                    this.Acquirer.Equals(other.Acquirer)
                ) && 
                
                (
                    this.Bank == other.Bank ||
                    this.Bank != null &&
                    this.Bank.Equals(other.Bank)
                ) && 
                (
                    this.ShopperName == other.ShopperName ||
                    this.ShopperName != null &&
                    this.ShopperName.Equals(other.ShopperName)
                ) && 
                (
                    this.AcquirerAccount == other.AcquirerAccount ||
                    this.AcquirerAccount != null &&
                    this.AcquirerAccount.Equals(other.AcquirerAccount)
                ) && 
                (
                    this.AliasType == other.AliasType ||
                    this.AliasType != null &&
                    this.AliasType.Equals(other.AliasType)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Variant == other.Variant ||
                    this.Variant != null &&
                    this.Variant.Equals(other.Variant)
                ) && 
                (
                    this.RecurringDetailReference == other.RecurringDetailReference ||
                    this.RecurringDetailReference != null &&
                    this.RecurringDetailReference.Equals(other.RecurringDetailReference)
                ) && 
                (
                    this.Alias == other.Alias ||
                    this.Alias != null &&
                    this.Alias.Equals(other.Alias)
                ) && 
                (
                    this.ContractTypes == other.ContractTypes ||
                    this.ContractTypes != null &&
                    this.ContractTypes.SequenceEqual(other.ContractTypes)
                ) && 
                (
                    this.PaymentMethodVariant == other.PaymentMethodVariant ||
                    this.PaymentMethodVariant != null &&
                    this.PaymentMethodVariant.Equals(other.PaymentMethodVariant)
                ) && 
                (
                    this.BillingAddress == other.BillingAddress ||
                    this.BillingAddress != null &&
                    this.BillingAddress.Equals(other.BillingAddress)
                ) && 
                (
                    this.AdditionalData == other.AdditionalData ||
                    this.AdditionalData != null &&
                    this.AdditionalData.SequenceEqual(other.AdditionalData)
                ) && 
                (
                    this.Card == other.Card ||
                    this.Card != null &&
                    this.Card.Equals(other.Card)
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
                if (this.TokenDetails != null)
                    hash = hash * 59 + this.TokenDetails.GetHashCode();
                if (this.SocialSecurityNumber != null)
                    hash = hash * 59 + this.SocialSecurityNumber.GetHashCode();
                if (this.FirstPspReference != null)
                    hash = hash * 59 + this.FirstPspReference.GetHashCode();
                if (this.CreationDate != null)
                    hash = hash * 59 + this.CreationDate.GetHashCode();
                if (this.Acquirer != null)
                    hash = hash * 59 + this.Acquirer.GetHashCode();
               
                if (this.Bank != null)
                    hash = hash * 59 + this.Bank.GetHashCode();
                if (this.ShopperName != null)
                    hash = hash * 59 + this.ShopperName.GetHashCode();
                if (this.AcquirerAccount != null)
                    hash = hash * 59 + this.AcquirerAccount.GetHashCode();
                if (this.AliasType != null)
                    hash = hash * 59 + this.AliasType.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Variant != null)
                    hash = hash * 59 + this.Variant.GetHashCode();
                if (this.RecurringDetailReference != null)
                    hash = hash * 59 + this.RecurringDetailReference.GetHashCode();
                if (this.Alias != null)
                    hash = hash * 59 + this.Alias.GetHashCode();
                if (this.ContractTypes != null)
                    hash = hash * 59 + this.ContractTypes.GetHashCode();
                if (this.PaymentMethodVariant != null)
                    hash = hash * 59 + this.PaymentMethodVariant.GetHashCode();
                if (this.BillingAddress != null)
                    hash = hash * 59 + this.BillingAddress.GetHashCode();
                if (this.AdditionalData != null)
                    hash = hash * 59 + this.AdditionalData.GetHashCode();
                if (this.Card != null)
                    hash = hash * 59 + this.Card.GetHashCode();
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
