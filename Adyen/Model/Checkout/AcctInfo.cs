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
//  Copyright (c) 2022 Adyen N.V.
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
    /// AcctInfo
    /// </summary>
    [DataContract]
    public partial class AcctInfo : IEquatable<AcctInfo>, IValidatableObject
    {
        /// <summary>
        /// Length of time that the cardholder has had the account with the 3DS Requestor.  Allowed values: * **01** — No account * **02** — Created during this transaction * **03** — Less than 30 days * **04** — 30–60 days * **05** — More than 60 days
        /// </summary>
        /// <value>Length of time that the cardholder has had the account with the 3DS Requestor.  Allowed values: * **01** — No account * **02** — Created during this transaction * **03** — Less than 30 days * **04** — 30–60 days * **05** — More than 60 days</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChAccAgeIndEnum
        {
            /// <summary>
            /// Enum _01 for value: 01
            /// </summary>
            [EnumMember(Value = "01")] _01 = 1,

            /// <summary>
            /// Enum _02 for value: 02
            /// </summary>
            [EnumMember(Value = "02")] _02 = 2,

            /// <summary>
            /// Enum _03 for value: 03
            /// </summary>
            [EnumMember(Value = "03")] _03 = 3,

            /// <summary>
            /// Enum _04 for value: 04
            /// </summary>
            [EnumMember(Value = "04")] _04 = 4,

            /// <summary>
            /// Enum _05 for value: 05
            /// </summary>
            [EnumMember(Value = "05")] _05 = 5
        }

        /// <summary>
        /// Length of time that the cardholder has had the account with the 3DS Requestor.  Allowed values: * **01** — No account * **02** — Created during this transaction * **03** — Less than 30 days * **04** — 30–60 days * **05** — More than 60 days
        /// </summary>
        /// <value>Length of time that the cardholder has had the account with the 3DS Requestor.  Allowed values: * **01** — No account * **02** — Created during this transaction * **03** — Less than 30 days * **04** — 30–60 days * **05** — More than 60 days</value>
        [DataMember(Name = "chAccAgeInd", EmitDefaultValue = false)]
        public ChAccAgeIndEnum? ChAccAgeInd { get; set; }

        /// <summary>
        /// Length of time since the cardholder’s account information with the 3DS Requestor was last changed, including Billing or Shipping address, new payment account, or new user(s) added.  Allowed values: * **01** — Changed during this transaction * **02** — Less than 30 days * **03** — 30–60 days * **04** — More than 60 days
        /// </summary>
        /// <value>Length of time since the cardholder’s account information with the 3DS Requestor was last changed, including Billing or Shipping address, new payment account, or new user(s) added.  Allowed values: * **01** — Changed during this transaction * **02** — Less than 30 days * **03** — 30–60 days * **04** — More than 60 days</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChAccChangeIndEnum
        {
            /// <summary>
            /// Enum _01 for value: 01
            /// </summary>
            [EnumMember(Value = "01")] _01 = 1,

            /// <summary>
            /// Enum _02 for value: 02
            /// </summary>
            [EnumMember(Value = "02")] _02 = 2,

            /// <summary>
            /// Enum _03 for value: 03
            /// </summary>
            [EnumMember(Value = "03")] _03 = 3,

            /// <summary>
            /// Enum _04 for value: 04
            /// </summary>
            [EnumMember(Value = "04")] _04 = 4
        }

        /// <summary>
        /// Length of time since the cardholder’s account information with the 3DS Requestor was last changed, including Billing or Shipping address, new payment account, or new user(s) added.  Allowed values: * **01** — Changed during this transaction * **02** — Less than 30 days * **03** — 30–60 days * **04** — More than 60 days
        /// </summary>
        /// <value>Length of time since the cardholder’s account information with the 3DS Requestor was last changed, including Billing or Shipping address, new payment account, or new user(s) added.  Allowed values: * **01** — Changed during this transaction * **02** — Less than 30 days * **03** — 30–60 days * **04** — More than 60 days</value>
        [DataMember(Name = "chAccChangeInd", EmitDefaultValue = false)]
        public ChAccChangeIndEnum? ChAccChangeInd { get; set; }

        /// <summary>
        /// Indicates the length of time since the cardholder’s account with the 3DS Requestor had a password change or account reset.  Allowed values: * **01** — No change * **02** — Changed during this transaction * **03** — Less than 30 days * **04** — 30–60 days * **05** — More than 60 days
        /// </summary>
        /// <value>Indicates the length of time since the cardholder’s account with the 3DS Requestor had a password change or account reset.  Allowed values: * **01** — No change * **02** — Changed during this transaction * **03** — Less than 30 days * **04** — 30–60 days * **05** — More than 60 days</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChAccPwChangeIndEnum
        {
            /// <summary>
            /// Enum _01 for value: 01
            /// </summary>
            [EnumMember(Value = "01")] _01 = 1,

            /// <summary>
            /// Enum _02 for value: 02
            /// </summary>
            [EnumMember(Value = "02")] _02 = 2,

            /// <summary>
            /// Enum _03 for value: 03
            /// </summary>
            [EnumMember(Value = "03")] _03 = 3,

            /// <summary>
            /// Enum _04 for value: 04
            /// </summary>
            [EnumMember(Value = "04")] _04 = 4,

            /// <summary>
            /// Enum _05 for value: 05
            /// </summary>
            [EnumMember(Value = "05")] _05 = 5
        }

        /// <summary>
        /// Indicates the length of time since the cardholder’s account with the 3DS Requestor had a password change or account reset.  Allowed values: * **01** — No change * **02** — Changed during this transaction * **03** — Less than 30 days * **04** — 30–60 days * **05** — More than 60 days
        /// </summary>
        /// <value>Indicates the length of time since the cardholder’s account with the 3DS Requestor had a password change or account reset.  Allowed values: * **01** — No change * **02** — Changed during this transaction * **03** — Less than 30 days * **04** — 30–60 days * **05** — More than 60 days</value>
        [DataMember(Name = "chAccPwChangeInd", EmitDefaultValue = false)]
        public ChAccPwChangeIndEnum? ChAccPwChangeInd { get; set; }

        /// <summary>
        /// Indicates the length of time that the payment account was enrolled in the cardholder’s account with the 3DS Requestor.  Allowed values: * **01** — No account (guest checkout) * **02** — During this transaction * **03** — Less than 30 days * **04** — 30–60 days * **05** — More than 60 days
        /// </summary>
        /// <value>Indicates the length of time that the payment account was enrolled in the cardholder’s account with the 3DS Requestor.  Allowed values: * **01** — No account (guest checkout) * **02** — During this transaction * **03** — Less than 30 days * **04** — 30–60 days * **05** — More than 60 days</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentAccIndEnum
        {
            /// <summary>
            /// Enum _01 for value: 01
            /// </summary>
            [EnumMember(Value = "01")] _01 = 1,

            /// <summary>
            /// Enum _02 for value: 02
            /// </summary>
            [EnumMember(Value = "02")] _02 = 2,

            /// <summary>
            /// Enum _03 for value: 03
            /// </summary>
            [EnumMember(Value = "03")] _03 = 3,

            /// <summary>
            /// Enum _04 for value: 04
            /// </summary>
            [EnumMember(Value = "04")] _04 = 4,

            /// <summary>
            /// Enum _05 for value: 05
            /// </summary>
            [EnumMember(Value = "05")] _05 = 5
        }

        /// <summary>
        /// Indicates the length of time that the payment account was enrolled in the cardholder’s account with the 3DS Requestor.  Allowed values: * **01** — No account (guest checkout) * **02** — During this transaction * **03** — Less than 30 days * **04** — 30–60 days * **05** — More than 60 days
        /// </summary>
        /// <value>Indicates the length of time that the payment account was enrolled in the cardholder’s account with the 3DS Requestor.  Allowed values: * **01** — No account (guest checkout) * **02** — During this transaction * **03** — Less than 30 days * **04** — 30–60 days * **05** — More than 60 days</value>
        [DataMember(Name = "paymentAccInd", EmitDefaultValue = false)]
        public PaymentAccIndEnum? PaymentAccInd { get; set; }

        /// <summary>
        /// Indicates when the shipping address used for this transaction was first used with the 3DS Requestor.  Allowed values: * **01** — This transaction * **02** — Less than 30 days * **03** — 30–60 days * **04** — More than 60 days
        /// </summary>
        /// <value>Indicates when the shipping address used for this transaction was first used with the 3DS Requestor.  Allowed values: * **01** — This transaction * **02** — Less than 30 days * **03** — 30–60 days * **04** — More than 60 days</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShipAddressUsageIndEnum
        {
            /// <summary>
            /// Enum _01 for value: 01
            /// </summary>
            [EnumMember(Value = "01")] _01 = 1,

            /// <summary>
            /// Enum _02 for value: 02
            /// </summary>
            [EnumMember(Value = "02")] _02 = 2,

            /// <summary>
            /// Enum _03 for value: 03
            /// </summary>
            [EnumMember(Value = "03")] _03 = 3,

            /// <summary>
            /// Enum _04 for value: 04
            /// </summary>
            [EnumMember(Value = "04")] _04 = 4
        }

        /// <summary>
        /// Indicates when the shipping address used for this transaction was first used with the 3DS Requestor.  Allowed values: * **01** — This transaction * **02** — Less than 30 days * **03** — 30–60 days * **04** — More than 60 days
        /// </summary>
        /// <value>Indicates when the shipping address used for this transaction was first used with the 3DS Requestor.  Allowed values: * **01** — This transaction * **02** — Less than 30 days * **03** — 30–60 days * **04** — More than 60 days</value>
        [DataMember(Name = "shipAddressUsageInd", EmitDefaultValue = false)]
        public ShipAddressUsageIndEnum? ShipAddressUsageInd { get; set; }

        /// <summary>
        /// Indicates if the Cardholder Name on the account is identical to the shipping Name used for this transaction.  Allowed values: * **01** — Account Name identical to shipping Name * **02** — Account Name different to shipping Name
        /// </summary>
        /// <value>Indicates if the Cardholder Name on the account is identical to the shipping Name used for this transaction.  Allowed values: * **01** — Account Name identical to shipping Name * **02** — Account Name different to shipping Name</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShipNameIndicatorEnum
        {
            /// <summary>
            /// Enum _01 for value: 01
            /// </summary>
            [EnumMember(Value = "01")] _01 = 1,

            /// <summary>
            /// Enum _02 for value: 02
            /// </summary>
            [EnumMember(Value = "02")] _02 = 2
        }

        /// <summary>
        /// Indicates if the Cardholder Name on the account is identical to the shipping Name used for this transaction.  Allowed values: * **01** — Account Name identical to shipping Name * **02** — Account Name different to shipping Name
        /// </summary>
        /// <value>Indicates if the Cardholder Name on the account is identical to the shipping Name used for this transaction.  Allowed values: * **01** — Account Name identical to shipping Name * **02** — Account Name different to shipping Name</value>
        [DataMember(Name = "shipNameIndicator", EmitDefaultValue = false)]
        public ShipNameIndicatorEnum? ShipNameIndicator { get; set; }

        /// <summary>
        /// Indicates whether the 3DS Requestor has experienced suspicious activity (including previous fraud) on the cardholder account.  Allowed values: * **01** — No suspicious activity has been observed * **02** — Suspicious activity has been observed
        /// </summary>
        /// <value>Indicates whether the 3DS Requestor has experienced suspicious activity (including previous fraud) on the cardholder account.  Allowed values: * **01** — No suspicious activity has been observed * **02** — Suspicious activity has been observed</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SuspiciousAccActivityEnum
        {
            /// <summary>
            /// Enum _01 for value: 01
            /// </summary>
            [EnumMember(Value = "01")] _01 = 1,

            /// <summary>
            /// Enum _02 for value: 02
            /// </summary>
            [EnumMember(Value = "02")] _02 = 2
        }

        /// <summary>
        /// Indicates whether the 3DS Requestor has experienced suspicious activity (including previous fraud) on the cardholder account.  Allowed values: * **01** — No suspicious activity has been observed * **02** — Suspicious activity has been observed
        /// </summary>
        /// <value>Indicates whether the 3DS Requestor has experienced suspicious activity (including previous fraud) on the cardholder account.  Allowed values: * **01** — No suspicious activity has been observed * **02** — Suspicious activity has been observed</value>
        [DataMember(Name = "suspiciousAccActivity", EmitDefaultValue = false)]
        public SuspiciousAccActivityEnum? SuspiciousAccActivity { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AcctInfo" /> class.
        /// </summary>
        /// <param name="chAccAgeInd">Length of time that the cardholder has had the account with the 3DS Requestor.  Allowed values: * **01** — No account * **02** — Created during this transaction * **03** — Less than 30 days * **04** — 30–60 days * **05** — More than 60 days.</param>
        /// <param name="chAccChange">Date that the cardholder’s account with the 3DS Requestor was last changed, including Billing or Shipping address, new payment account, or new user(s) added.  Format: **YYYYMMDD**.</param>
        /// <param name="chAccChangeInd">Length of time since the cardholder’s account information with the 3DS Requestor was last changed, including Billing or Shipping address, new payment account, or new user(s) added.  Allowed values: * **01** — Changed during this transaction * **02** — Less than 30 days * **03** — 30–60 days * **04** — More than 60 days.</param>
        /// <param name="chAccPwChange">Date that cardholder’s account with the 3DS Requestor had a password change or account reset.  Format: **YYYYMMDD**.</param>
        /// <param name="chAccPwChangeInd">Indicates the length of time since the cardholder’s account with the 3DS Requestor had a password change or account reset.  Allowed values: * **01** — No change * **02** — Changed during this transaction * **03** — Less than 30 days * **04** — 30–60 days * **05** — More than 60 days.</param>
        /// <param name="chAccString">Date that the cardholder opened the account with the 3DS Requestor.  Format: **YYYYMMDD**.</param>
        /// <param name="nbPurchaseAccount">Number of purchases with this cardholder account during the previous six months. Max length: 4 characters..</param>
        /// <param name="paymentAccAge">String that the payment account was enrolled in the cardholder’s account with the 3DS Requestor.  Format: **YYYYMMDD**.</param>
        /// <param name="paymentAccInd">Indicates the length of time that the payment account was enrolled in the cardholder’s account with the 3DS Requestor.  Allowed values: * **01** — No account (guest checkout) * **02** — During this transaction * **03** — Less than 30 days * **04** — 30–60 days * **05** — More than 60 days.</param>
        /// <param name="provisionAttemptsDay">Number of Add Card attempts in the last 24 hours. Max length: 3 characters..</param>
        /// <param name="shipAddressUsage">String when the shipping address used for this transaction was first used with the 3DS Requestor.  Format: **YYYYMMDD**.</param>
        /// <param name="shipAddressUsageInd">Indicates when the shipping address used for this transaction was first used with the 3DS Requestor.  Allowed values: * **01** — This transaction * **02** — Less than 30 days * **03** — 30–60 days * **04** — More than 60 days.</param>
        /// <param name="shipNameIndicator">Indicates if the Cardholder Name on the account is identical to the shipping Name used for this transaction.  Allowed values: * **01** — Account Name identical to shipping Name * **02** — Account Name different to shipping Name.</param>
        /// <param name="suspiciousAccActivity">Indicates whether the 3DS Requestor has experienced suspicious activity (including previous fraud) on the cardholder account.  Allowed values: * **01** — No suspicious activity has been observed * **02** — Suspicious activity has been observed.</param>
        /// <param name="txnActivityDay">Number of transactions (successful and abandoned) for this cardholder account with the 3DS Requestor across all payment accounts in the previous 24 hours. Max length: 3 characters..</param>
        /// <param name="txnActivityYear">Number of transactions (successful and abandoned) for this cardholder account with the 3DS Requestor across all payment accounts in the previous year. Max length: 3 characters..</param>
        public AcctInfo(ChAccAgeIndEnum? chAccAgeInd = default(ChAccAgeIndEnum?), string chAccChange = default(string),
            ChAccChangeIndEnum? chAccChangeInd = default(ChAccChangeIndEnum?), string chAccPwChange = default(string),
            ChAccPwChangeIndEnum? chAccPwChangeInd = default(ChAccPwChangeIndEnum?),
            string chAccString = default(string), string nbPurchaseAccount = default(string),
            string paymentAccAge = default(string), PaymentAccIndEnum? paymentAccInd = default(PaymentAccIndEnum?),
            string provisionAttemptsDay = default(string), string shipAddressUsage = default(string),
            ShipAddressUsageIndEnum? shipAddressUsageInd = default(ShipAddressUsageIndEnum?),
            ShipNameIndicatorEnum? shipNameIndicator = default(ShipNameIndicatorEnum?),
            SuspiciousAccActivityEnum? suspiciousAccActivity = default(SuspiciousAccActivityEnum?),
            string txnActivityDay = default(string), string txnActivityYear = default(string))
        {
            this.ChAccAgeInd = chAccAgeInd;
            this.ChAccChange = chAccChange;
            this.ChAccChangeInd = chAccChangeInd;
            this.ChAccPwChange = chAccPwChange;
            this.ChAccPwChangeInd = chAccPwChangeInd;
            this.ChAccString = chAccString;
            this.NbPurchaseAccount = nbPurchaseAccount;
            this.PaymentAccAge = paymentAccAge;
            this.PaymentAccInd = paymentAccInd;
            this.ProvisionAttemptsDay = provisionAttemptsDay;
            this.ShipAddressUsage = shipAddressUsage;
            this.ShipAddressUsageInd = shipAddressUsageInd;
            this.ShipNameIndicator = shipNameIndicator;
            this.SuspiciousAccActivity = suspiciousAccActivity;
            this.TxnActivityDay = txnActivityDay;
            this.TxnActivityYear = txnActivityYear;
        }

        /// <summary>
        /// Date that the cardholder’s account with the 3DS Requestor was last changed, including Billing or Shipping address, new payment account, or new user(s) added.  Format: **YYYYMMDD**
        /// </summary>
        /// <value>Date that the cardholder’s account with the 3DS Requestor was last changed, including Billing or Shipping address, new payment account, or new user(s) added.  Format: **YYYYMMDD**</value>
        [DataMember(Name = "chAccChange", EmitDefaultValue = false)]
        public string ChAccChange { get; set; }

        /// <summary>
        /// Date that cardholder’s account with the 3DS Requestor had a password change or account reset.  Format: **YYYYMMDD**
        /// </summary>
        /// <value>Date that cardholder’s account with the 3DS Requestor had a password change or account reset.  Format: **YYYYMMDD**</value>
        [DataMember(Name = "chAccPwChange", EmitDefaultValue = false)]
        public string ChAccPwChange { get; set; }

        /// <summary>
        /// Date that the cardholder opened the account with the 3DS Requestor.  Format: **YYYYMMDD**
        /// </summary>
        /// <value>Date that the cardholder opened the account with the 3DS Requestor.  Format: **YYYYMMDD**</value>
        [DataMember(Name = "chAccString", EmitDefaultValue = false)]
        public string ChAccString { get; set; }

        /// <summary>
        /// Number of purchases with this cardholder account during the previous six months. Max length: 4 characters.
        /// </summary>
        /// <value>Number of purchases with this cardholder account during the previous six months. Max length: 4 characters.</value>
        [DataMember(Name = "nbPurchaseAccount", EmitDefaultValue = false)]
        public string NbPurchaseAccount { get; set; }

        /// <summary>
        /// String that the payment account was enrolled in the cardholder’s account with the 3DS Requestor.  Format: **YYYYMMDD**
        /// </summary>
        /// <value>String that the payment account was enrolled in the cardholder’s account with the 3DS Requestor.  Format: **YYYYMMDD**</value>
        [DataMember(Name = "paymentAccAge", EmitDefaultValue = false)]
        public string PaymentAccAge { get; set; }

        /// <summary>
        /// Number of Add Card attempts in the last 24 hours. Max length: 3 characters.
        /// </summary>
        /// <value>Number of Add Card attempts in the last 24 hours. Max length: 3 characters.</value>
        [DataMember(Name = "provisionAttemptsDay", EmitDefaultValue = false)]
        public string ProvisionAttemptsDay { get; set; }

        /// <summary>
        /// String when the shipping address used for this transaction was first used with the 3DS Requestor.  Format: **YYYYMMDD**
        /// </summary>
        /// <value>String when the shipping address used for this transaction was first used with the 3DS Requestor.  Format: **YYYYMMDD**</value>
        [DataMember(Name = "shipAddressUsage", EmitDefaultValue = false)]
        public string ShipAddressUsage { get; set; }

        /// <summary>
        /// Number of transactions (successful and abandoned) for this cardholder account with the 3DS Requestor across all payment accounts in the previous 24 hours. Max length: 3 characters.
        /// </summary>
        /// <value>Number of transactions (successful and abandoned) for this cardholder account with the 3DS Requestor across all payment accounts in the previous 24 hours. Max length: 3 characters.</value>
        [DataMember(Name = "txnActivityDay", EmitDefaultValue = false)]
        public string TxnActivityDay { get; set; }

        /// <summary>
        /// Number of transactions (successful and abandoned) for this cardholder account with the 3DS Requestor across all payment accounts in the previous year. Max length: 3 characters.
        /// </summary>
        /// <value>Number of transactions (successful and abandoned) for this cardholder account with the 3DS Requestor across all payment accounts in the previous year. Max length: 3 characters.</value>
        [DataMember(Name = "txnActivityYear", EmitDefaultValue = false)]
        public string TxnActivityYear { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AcctInfo {\n");
            sb.Append("  ChAccAgeInd: ").Append(ChAccAgeInd).Append("\n");
            sb.Append("  ChAccChange: ").Append(ChAccChange).Append("\n");
            sb.Append("  ChAccChangeInd: ").Append(ChAccChangeInd).Append("\n");
            sb.Append("  ChAccPwChange: ").Append(ChAccPwChange).Append("\n");
            sb.Append("  ChAccPwChangeInd: ").Append(ChAccPwChangeInd).Append("\n");
            sb.Append("  ChAccString: ").Append(ChAccString).Append("\n");
            sb.Append("  NbPurchaseAccount: ").Append(NbPurchaseAccount).Append("\n");
            sb.Append("  PaymentAccAge: ").Append(PaymentAccAge).Append("\n");
            sb.Append("  PaymentAccInd: ").Append(PaymentAccInd).Append("\n");
            sb.Append("  ProvisionAttemptsDay: ").Append(ProvisionAttemptsDay).Append("\n");
            sb.Append("  ShipAddressUsage: ").Append(ShipAddressUsage).Append("\n");
            sb.Append("  ShipAddressUsageInd: ").Append(ShipAddressUsageInd).Append("\n");
            sb.Append("  ShipNameIndicator: ").Append(ShipNameIndicator).Append("\n");
            sb.Append("  SuspiciousAccActivity: ").Append(SuspiciousAccActivity).Append("\n");
            sb.Append("  TxnActivityDay: ").Append(TxnActivityDay).Append("\n");
            sb.Append("  TxnActivityYear: ").Append(TxnActivityYear).Append("\n");
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
            return this.Equals(input as AcctInfo);
        }

        /// <summary>
        /// Returns true if AcctInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AcctInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AcctInfo input)
        {
            if (input == null) return false;

            return
                (this.ChAccAgeInd == input.ChAccAgeInd ||
                 (this.ChAccAgeInd != null && this.ChAccAgeInd.Equals(input.ChAccAgeInd))) &&
                (this.ChAccChange == input.ChAccChange ||
                 (this.ChAccChange != null && this.ChAccChange.Equals(input.ChAccChange))) &&
                (this.ChAccChangeInd == input.ChAccChangeInd ||
                 (this.ChAccChangeInd != null && this.ChAccChangeInd.Equals(input.ChAccChangeInd))) &&
                (this.ChAccPwChange == input.ChAccPwChange ||
                 (this.ChAccPwChange != null && this.ChAccPwChange.Equals(input.ChAccPwChange))) &&
                (this.ChAccPwChangeInd == input.ChAccPwChangeInd || (this.ChAccPwChangeInd != null &&
                                                                     this.ChAccPwChangeInd.Equals(
                                                                         input.ChAccPwChangeInd))) &&
                (this.ChAccString == input.ChAccString ||
                 (this.ChAccString != null && this.ChAccString.Equals(input.ChAccString))) &&
                (this.NbPurchaseAccount == input.NbPurchaseAccount || (this.NbPurchaseAccount != null &&
                                                                       this.NbPurchaseAccount.Equals(
                                                                           input.NbPurchaseAccount))) &&
                (this.PaymentAccAge == input.PaymentAccAge ||
                 (this.PaymentAccAge != null && this.PaymentAccAge.Equals(input.PaymentAccAge))) &&
                (this.PaymentAccInd == input.PaymentAccInd ||
                 (this.PaymentAccInd != null && this.PaymentAccInd.Equals(input.PaymentAccInd))) &&
                (this.ProvisionAttemptsDay == input.ProvisionAttemptsDay || (this.ProvisionAttemptsDay != null &&
                                                                             this.ProvisionAttemptsDay.Equals(
                                                                                 input.ProvisionAttemptsDay))) &&
                (this.ShipAddressUsage == input.ShipAddressUsage || (this.ShipAddressUsage != null &&
                                                                     this.ShipAddressUsage.Equals(
                                                                         input.ShipAddressUsage))) &&
                (this.ShipAddressUsageInd == input.ShipAddressUsageInd || (this.ShipAddressUsageInd != null &&
                                                                           this.ShipAddressUsageInd.Equals(
                                                                               input.ShipAddressUsageInd))) &&
                (this.ShipNameIndicator == input.ShipNameIndicator || (this.ShipNameIndicator != null &&
                                                                       this.ShipNameIndicator.Equals(
                                                                           input.ShipNameIndicator))) &&
                (this.SuspiciousAccActivity == input.SuspiciousAccActivity || (this.SuspiciousAccActivity != null &&
                                                                               this.SuspiciousAccActivity.Equals(
                                                                                   input.SuspiciousAccActivity))) &&
                (this.TxnActivityDay == input.TxnActivityDay ||
                 (this.TxnActivityDay != null && this.TxnActivityDay.Equals(input.TxnActivityDay))) &&
                (this.TxnActivityYear == input.TxnActivityYear || (this.TxnActivityYear != null &&
                                                                   this.TxnActivityYear.Equals(input.TxnActivityYear)));
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
                if (this.ChAccAgeInd != null) hashCode = hashCode * 59 + this.ChAccAgeInd.GetHashCode();
                if (this.ChAccChange != null) hashCode = hashCode * 59 + this.ChAccChange.GetHashCode();
                if (this.ChAccChangeInd != null) hashCode = hashCode * 59 + this.ChAccChangeInd.GetHashCode();
                if (this.ChAccPwChange != null) hashCode = hashCode * 59 + this.ChAccPwChange.GetHashCode();
                if (this.ChAccPwChangeInd != null) hashCode = hashCode * 59 + this.ChAccPwChangeInd.GetHashCode();
                if (this.ChAccString != null) hashCode = hashCode * 59 + this.ChAccString.GetHashCode();
                if (this.NbPurchaseAccount != null) hashCode = hashCode * 59 + this.NbPurchaseAccount.GetHashCode();
                if (this.PaymentAccAge != null) hashCode = hashCode * 59 + this.PaymentAccAge.GetHashCode();
                if (this.PaymentAccInd != null) hashCode = hashCode * 59 + this.PaymentAccInd.GetHashCode();
                if (this.ProvisionAttemptsDay != null)
                    hashCode = hashCode * 59 + this.ProvisionAttemptsDay.GetHashCode();
                if (this.ShipAddressUsage != null) hashCode = hashCode * 59 + this.ShipAddressUsage.GetHashCode();
                if (this.ShipAddressUsageInd != null) hashCode = hashCode * 59 + this.ShipAddressUsageInd.GetHashCode();
                if (this.ShipNameIndicator != null) hashCode = hashCode * 59 + this.ShipNameIndicator.GetHashCode();
                if (this.SuspiciousAccActivity != null)
                    hashCode = hashCode * 59 + this.SuspiciousAccActivity.GetHashCode();
                if (this.TxnActivityDay != null) hashCode = hashCode * 59 + this.TxnActivityDay.GetHashCode();
                if (this.TxnActivityYear != null) hashCode = hashCode * 59 + this.TxnActivityYear.GetHashCode();
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