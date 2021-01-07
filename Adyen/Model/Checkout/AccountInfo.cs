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
    /// AccountInfo
    /// </summary>
    [DataContract]
    public partial class AccountInfo : IEquatable<AccountInfo>, IValidatableObject
    {
        /// <summary>
        /// Indicator for the length of time since this shopper account was created in the merchant&#x27;s environment. Allowed values: * notApplicable * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days
        /// </summary>
        /// <value>Indicator for the length of time since this shopper account was created in the merchant&#x27;s environment. Allowed values: * notApplicable * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountAgeIndicatorEnum
        {
            /// <summary>
            /// Enum NotApplicable for value: notApplicable
            /// </summary>
            [EnumMember(Value = "notApplicable")] NotApplicable = 1,

            /// <summary>
            /// Enum ThisTransaction for value: thisTransaction
            /// </summary>
            [EnumMember(Value = "thisTransaction")] ThisTransaction = 2,

            /// <summary>
            /// Enum LessThan30Days for value: lessThan30Days
            /// </summary>
            [EnumMember(Value = "lessThan30Days")] LessThan30Days = 3,

            /// <summary>
            /// Enum From30To60Days for value: from30To60Days
            /// </summary>
            [EnumMember(Value = "from30To60Days")] From30To60Days = 4,

            /// <summary>
            /// Enum MoreThan60Days for value: moreThan60Days
            /// </summary>
            [EnumMember(Value = "moreThan60Days")] MoreThan60Days = 5
        }

        /// <summary>
        /// Indicator for the length of time since this shopper account was created in the merchant&#x27;s environment. Allowed values: * notApplicable * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days
        /// </summary>
        /// <value>Indicator for the length of time since this shopper account was created in the merchant&#x27;s environment. Allowed values: * notApplicable * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days</value>
        [DataMember(Name = "accountAgeIndicator", EmitDefaultValue = false)]
        public AccountAgeIndicatorEnum? AccountAgeIndicator { get; set; }

        /// <summary>
        /// Indicator for the length of time since the shopper&#x27;s account was last updated. Allowed values: * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days
        /// </summary>
        /// <value>Indicator for the length of time since the shopper&#x27;s account was last updated. Allowed values: * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountChangeIndicatorEnum
        {
            /// <summary>
            /// Enum ThisTransaction for value: thisTransaction
            /// </summary>
            [EnumMember(Value = "thisTransaction")] ThisTransaction = 1,

            /// <summary>
            /// Enum LessThan30Days for value: lessThan30Days
            /// </summary>
            [EnumMember(Value = "lessThan30Days")] LessThan30Days = 2,

            /// <summary>
            /// Enum From30To60Days for value: from30To60Days
            /// </summary>
            [EnumMember(Value = "from30To60Days")] From30To60Days = 3,

            /// <summary>
            /// Enum MoreThan60Days for value: moreThan60Days
            /// </summary>
            [EnumMember(Value = "moreThan60Days")] MoreThan60Days = 4
        }

        /// <summary>
        /// Indicator for the length of time since the shopper&#x27;s account was last updated. Allowed values: * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days
        /// </summary>
        /// <value>Indicator for the length of time since the shopper&#x27;s account was last updated. Allowed values: * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days</value>
        [DataMember(Name = "accountChangeIndicator", EmitDefaultValue = false)]
        public AccountChangeIndicatorEnum? AccountChangeIndicator { get; set; }

        /// <summary>
        /// Indicates the type of account. For example, for a multi-account card product. Allowed values: * notApplicable * credit * debit
        /// </summary>
        /// <value>Indicates the type of account. For example, for a multi-account card product. Allowed values: * notApplicable * credit * debit</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountTypeEnum
        {
            /// <summary>
            /// Enum NotApplicable for value: notApplicable
            /// </summary>
            [EnumMember(Value = "notApplicable")] NotApplicable = 1,

            /// <summary>
            /// Enum Credit for value: credit
            /// </summary>
            [EnumMember(Value = "credit")] Credit = 2,

            /// <summary>
            /// Enum Debit for value: debit
            /// </summary>
            [EnumMember(Value = "debit")] Debit = 3
        }

        /// <summary>
        /// Indicates the type of account. For example, for a multi-account card product. Allowed values: * notApplicable * credit * debit
        /// </summary>
        /// <value>Indicates the type of account. For example, for a multi-account card product. Allowed values: * notApplicable * credit * debit</value>
        [DataMember(Name = "accountType", EmitDefaultValue = false)]
        public AccountTypeEnum? AccountType { get; set; }

        /// <summary>
        /// Indicator for the length of time since this delivery address was first used. Allowed values: * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days
        /// </summary>
        /// <value>Indicator for the length of time since this delivery address was first used. Allowed values: * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeliveryAddressUsageIndicatorEnum
        {
            /// <summary>
            /// Enum ThisTransaction for value: thisTransaction
            /// </summary>
            [EnumMember(Value = "thisTransaction")] ThisTransaction = 1,

            /// <summary>
            /// Enum LessThan30Days for value: lessThan30Days
            /// </summary>
            [EnumMember(Value = "lessThan30Days")] LessThan30Days = 2,

            /// <summary>
            /// Enum From30To60Days for value: from30To60Days
            /// </summary>
            [EnumMember(Value = "from30To60Days")] From30To60Days = 3,

            /// <summary>
            /// Enum MoreThan60Days for value: moreThan60Days
            /// </summary>
            [EnumMember(Value = "moreThan60Days")] MoreThan60Days = 4
        }

        /// <summary>
        /// Indicator for the length of time since this delivery address was first used. Allowed values: * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days
        /// </summary>
        /// <value>Indicator for the length of time since this delivery address was first used. Allowed values: * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days</value>
        [DataMember(Name = "deliveryAddressUsageIndicator", EmitDefaultValue = false)]
        public DeliveryAddressUsageIndicatorEnum? DeliveryAddressUsageIndicator { get; set; }

        /// <summary>
        /// Indicator when the shopper has changed their password. Allowed values: * notApplicable * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days
        /// </summary>
        /// <value>Indicator when the shopper has changed their password. Allowed values: * notApplicable * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PasswordChangeIndicatorEnum
        {
            /// <summary>
            /// Enum NotApplicable for value: notApplicable
            /// </summary>
            [EnumMember(Value = "notApplicable")] NotApplicable = 1,

            /// <summary>
            /// Enum ThisTransaction for value: thisTransaction
            /// </summary>
            [EnumMember(Value = "thisTransaction")] ThisTransaction = 2,

            /// <summary>
            /// Enum LessThan30Days for value: lessThan30Days
            /// </summary>
            [EnumMember(Value = "lessThan30Days")] LessThan30Days = 3,

            /// <summary>
            /// Enum From30To60Days for value: from30To60Days
            /// </summary>
            [EnumMember(Value = "from30To60Days")] From30To60Days = 4,

            /// <summary>
            /// Enum MoreThan60Days for value: moreThan60Days
            /// </summary>
            [EnumMember(Value = "moreThan60Days")] MoreThan60Days = 5
        }

        /// <summary>
        /// Indicator when the shopper has changed their password. Allowed values: * notApplicable * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days
        /// </summary>
        /// <value>Indicator when the shopper has changed their password. Allowed values: * notApplicable * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days</value>
        [DataMember(Name = "passwordChangeIndicator", EmitDefaultValue = false)]
        public PasswordChangeIndicatorEnum? PasswordChangeIndicator { get; set; }

        /// <summary>
        /// Indicator for the length of time since this payment method was added to this shopper&#x27;s account. Allowed values: * notApplicable * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days
        /// </summary>
        /// <value>Indicator for the length of time since this payment method was added to this shopper&#x27;s account. Allowed values: * notApplicable * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentAccountIndicatorEnum
        {
            /// <summary>
            /// Enum NotApplicable for value: notApplicable
            /// </summary>
            [EnumMember(Value = "notApplicable")] NotApplicable = 1,

            /// <summary>
            /// Enum ThisTransaction for value: thisTransaction
            /// </summary>
            [EnumMember(Value = "thisTransaction")] ThisTransaction = 2,

            /// <summary>
            /// Enum LessThan30Days for value: lessThan30Days
            /// </summary>
            [EnumMember(Value = "lessThan30Days")] LessThan30Days = 3,

            /// <summary>
            /// Enum From30To60Days for value: from30To60Days
            /// </summary>
            [EnumMember(Value = "from30To60Days")] From30To60Days = 4,

            /// <summary>
            /// Enum MoreThan60Days for value: moreThan60Days
            /// </summary>
            [EnumMember(Value = "moreThan60Days")] MoreThan60Days = 5
        }

        /// <summary>
        /// Indicator for the length of time since this payment method was added to this shopper&#x27;s account. Allowed values: * notApplicable * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days
        /// </summary>
        /// <value>Indicator for the length of time since this payment method was added to this shopper&#x27;s account. Allowed values: * notApplicable * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days</value>
        [DataMember(Name = "paymentAccountIndicator", EmitDefaultValue = false)]
        public PaymentAccountIndicatorEnum? PaymentAccountIndicator { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountInfo" /> class.
        /// </summary>
        /// <param name="accountAgeIndicator">Indicator for the length of time since this shopper account was created in the merchant&#x27;s environment. Allowed values: * notApplicable * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days.</param>
        /// <param name="accountChangeDate">Date when the shopper&#x27;s account was last changed..</param>
        /// <param name="accountChangeIndicator">Indicator for the length of time since the shopper&#x27;s account was last updated. Allowed values: * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days.</param>
        /// <param name="accountCreationDate">Date when the shopper&#x27;s account was created..</param>
        /// <param name="accountType">Indicates the type of account. For example, for a multi-account card product. Allowed values: * notApplicable * credit * debit.</param>
        /// <param name="addCardAttemptsDay">Number of attempts the shopper tried to add a card to their account in the last day..</param>
        /// <param name="deliveryAddressUsageDate">Date the selected delivery address was first used..</param>
        /// <param name="deliveryAddressUsageIndicator">Indicator for the length of time since this delivery address was first used. Allowed values: * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days.</param>
        /// <param name="homePhone">Shopper&#x27;s home phone number (including the country code)..</param>
        /// <param name="mobilePhone">Shopper&#x27;s mobile phone number (including the country code)..</param>
        /// <param name="passwordChangeDate">Date when the shopper last changed their password..</param>
        /// <param name="passwordChangeIndicator">Indicator when the shopper has changed their password. Allowed values: * notApplicable * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days.</param>
        /// <param name="pastTransactionsDay">Number of all transactions (successful and abandoned) from this shopper in the past 24 hours..</param>
        /// <param name="pastTransactionsYear">Number of all transactions (successful and abandoned) from this shopper in the past year..</param>
        /// <param name="paymentAccountAge">Date this payment method was added to the shopper&#x27;s account..</param>
        /// <param name="paymentAccountIndicator">Indicator for the length of time since this payment method was added to this shopper&#x27;s account. Allowed values: * notApplicable * thisTransaction * lessThan30Days * from30To60Days * moreThan60Days.</param>
        /// <param name="purchasesLast6Months">Number of successful purchases in the last six months..</param>
        /// <param name="suspiciousActivity">Whether suspicious activity was recorded on this account..</param>
        /// <param name="workPhone">Shopper&#x27;s work phone number (including the country code)..</param>
        public AccountInfo(AccountAgeIndicatorEnum? accountAgeIndicator = default(AccountAgeIndicatorEnum?),
            DateTime? accountChangeDate = default(DateTime?),
            AccountChangeIndicatorEnum? accountChangeIndicator = default(AccountChangeIndicatorEnum?),
            DateTime? accountCreationDate = default(DateTime?),
            AccountTypeEnum? accountType = default(AccountTypeEnum?), int? addCardAttemptsDay = default(int?),
            DateTime? deliveryAddressUsageDate = default(DateTime?),
            DeliveryAddressUsageIndicatorEnum? deliveryAddressUsageIndicator =
                default(DeliveryAddressUsageIndicatorEnum?), string homePhone = default(string),
            string mobilePhone = default(string), DateTime? passwordChangeDate = default(DateTime?),
            PasswordChangeIndicatorEnum? passwordChangeIndicator = default(PasswordChangeIndicatorEnum?),
            int? pastTransactionsDay = default(int?), int? pastTransactionsYear = default(int?),
            DateTime? paymentAccountAge = default(DateTime?),
            PaymentAccountIndicatorEnum? paymentAccountIndicator = default(PaymentAccountIndicatorEnum?),
            int? purchasesLast6Months = default(int?), bool? suspiciousActivity = default(bool?),
            string workPhone = default(string))
        {
            this.AccountAgeIndicator = accountAgeIndicator;
            this.AccountChangeDate = accountChangeDate;
            this.AccountChangeIndicator = accountChangeIndicator;
            this.AccountCreationDate = accountCreationDate;
            this.AccountType = accountType;
            this.AddCardAttemptsDay = addCardAttemptsDay;
            this.DeliveryAddressUsageDate = deliveryAddressUsageDate;
            this.DeliveryAddressUsageIndicator = deliveryAddressUsageIndicator;
            this.HomePhone = homePhone;
            this.MobilePhone = mobilePhone;
            this.PasswordChangeDate = passwordChangeDate;
            this.PasswordChangeIndicator = passwordChangeIndicator;
            this.PastTransactionsDay = pastTransactionsDay;
            this.PastTransactionsYear = pastTransactionsYear;
            this.PaymentAccountAge = paymentAccountAge;
            this.PaymentAccountIndicator = paymentAccountIndicator;
            this.PurchasesLast6Months = purchasesLast6Months;
            this.SuspiciousActivity = suspiciousActivity;
            this.WorkPhone = workPhone;
        }


        /// <summary>
        /// Date when the shopper&#x27;s account was last changed.
        /// </summary>
        /// <value>Date when the shopper&#x27;s account was last changed.</value>
        [DataMember(Name = "accountChangeDate", EmitDefaultValue = false)]
        public DateTime? AccountChangeDate { get; set; }


        /// <summary>
        /// Date when the shopper&#x27;s account was created.
        /// </summary>
        /// <value>Date when the shopper&#x27;s account was created.</value>
        [DataMember(Name = "accountCreationDate", EmitDefaultValue = false)]
        public DateTime? AccountCreationDate { get; set; }


        /// <summary>
        /// Number of attempts the shopper tried to add a card to their account in the last day.
        /// </summary>
        /// <value>Number of attempts the shopper tried to add a card to their account in the last day.</value>
        [DataMember(Name = "addCardAttemptsDay", EmitDefaultValue = false)]
        public int? AddCardAttemptsDay { get; set; }

        /// <summary>
        /// Date the selected delivery address was first used.
        /// </summary>
        /// <value>Date the selected delivery address was first used.</value>
        [DataMember(Name = "deliveryAddressUsageDate", EmitDefaultValue = false)]
        public DateTime? DeliveryAddressUsageDate { get; set; }


        /// <summary>
        /// Shopper&#x27;s home phone number (including the country code).
        /// </summary>
        /// <value>Shopper&#x27;s home phone number (including the country code).</value>
        [DataMember(Name = "homePhone", EmitDefaultValue = false)]
        public string HomePhone { get; set; }

        /// <summary>
        /// Shopper&#x27;s mobile phone number (including the country code).
        /// </summary>
        /// <value>Shopper&#x27;s mobile phone number (including the country code).</value>
        [DataMember(Name = "mobilePhone", EmitDefaultValue = false)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Date when the shopper last changed their password.
        /// </summary>
        /// <value>Date when the shopper last changed their password.</value>
        [DataMember(Name = "passwordChangeDate", EmitDefaultValue = false)]
        public DateTime? PasswordChangeDate { get; set; }


        /// <summary>
        /// Number of all transactions (successful and abandoned) from this shopper in the past 24 hours.
        /// </summary>
        /// <value>Number of all transactions (successful and abandoned) from this shopper in the past 24 hours.</value>
        [DataMember(Name = "pastTransactionsDay", EmitDefaultValue = false)]
        public int? PastTransactionsDay { get; set; }

        /// <summary>
        /// Number of all transactions (successful and abandoned) from this shopper in the past year.
        /// </summary>
        /// <value>Number of all transactions (successful and abandoned) from this shopper in the past year.</value>
        [DataMember(Name = "pastTransactionsYear", EmitDefaultValue = false)]
        public int? PastTransactionsYear { get; set; }

        /// <summary>
        /// Date this payment method was added to the shopper&#x27;s account.
        /// </summary>
        /// <value>Date this payment method was added to the shopper&#x27;s account.</value>
        [DataMember(Name = "paymentAccountAge", EmitDefaultValue = false)]
        public DateTime? PaymentAccountAge { get; set; }


        /// <summary>
        /// Number of successful purchases in the last six months.
        /// </summary>
        /// <value>Number of successful purchases in the last six months.</value>
        [DataMember(Name = "purchasesLast6Months", EmitDefaultValue = false)]
        public int? PurchasesLast6Months { get; set; }

        /// <summary>
        /// Whether suspicious activity was recorded on this account.
        /// </summary>
        /// <value>Whether suspicious activity was recorded on this account.</value>
        [DataMember(Name = "suspiciousActivity", EmitDefaultValue = false)]
        public bool? SuspiciousActivity { get; set; }

        /// <summary>
        /// Shopper&#x27;s work phone number (including the country code).
        /// </summary>
        /// <value>Shopper&#x27;s work phone number (including the country code).</value>
        [DataMember(Name = "workPhone", EmitDefaultValue = false)]
        public string WorkPhone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountInfo {\n");
            sb.Append("  AccountAgeIndicator: ").Append(AccountAgeIndicator).Append("\n");
            sb.Append("  AccountChangeDate: ").Append(AccountChangeDate).Append("\n");
            sb.Append("  AccountChangeIndicator: ").Append(AccountChangeIndicator).Append("\n");
            sb.Append("  AccountCreationDate: ").Append(AccountCreationDate).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  AddCardAttemptsDay: ").Append(AddCardAttemptsDay).Append("\n");
            sb.Append("  DeliveryAddressUsageDate: ").Append(DeliveryAddressUsageDate).Append("\n");
            sb.Append("  DeliveryAddressUsageIndicator: ").Append(DeliveryAddressUsageIndicator).Append("\n");
            sb.Append("  HomePhone: ").Append(HomePhone).Append("\n");
            sb.Append("  MobilePhone: ").Append(MobilePhone).Append("\n");
            sb.Append("  PasswordChangeDate: ").Append(PasswordChangeDate).Append("\n");
            sb.Append("  PasswordChangeIndicator: ").Append(PasswordChangeIndicator).Append("\n");
            sb.Append("  PastTransactionsDay: ").Append(PastTransactionsDay).Append("\n");
            sb.Append("  PastTransactionsYear: ").Append(PastTransactionsYear).Append("\n");
            sb.Append("  PaymentAccountAge: ").Append(PaymentAccountAge).Append("\n");
            sb.Append("  PaymentAccountIndicator: ").Append(PaymentAccountIndicator).Append("\n");
            sb.Append("  PurchasesLast6Months: ").Append(PurchasesLast6Months).Append("\n");
            sb.Append("  SuspiciousActivity: ").Append(SuspiciousActivity).Append("\n");
            sb.Append("  WorkPhone: ").Append(WorkPhone).Append("\n");
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
            return this.Equals(input as AccountInfo);
        }

        /// <summary>
        /// Returns true if AccountInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountInfo input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AccountAgeIndicator == input.AccountAgeIndicator ||
                    this.AccountAgeIndicator != null &&
                    this.AccountAgeIndicator.Equals(input.AccountAgeIndicator)
                ) &&
                (
                    this.AccountChangeDate == input.AccountChangeDate ||
                    this.AccountChangeDate != null &&
                    this.AccountChangeDate.Equals(input.AccountChangeDate)
                ) &&
                (
                    this.AccountChangeIndicator == input.AccountChangeIndicator ||
                    this.AccountChangeIndicator != null &&
                    this.AccountChangeIndicator.Equals(input.AccountChangeIndicator)
                ) &&
                (
                    this.AccountCreationDate == input.AccountCreationDate ||
                    this.AccountCreationDate != null &&
                    this.AccountCreationDate.Equals(input.AccountCreationDate)
                ) &&
                (
                    this.AccountType == input.AccountType ||
                    this.AccountType != null &&
                    this.AccountType.Equals(input.AccountType)
                ) &&
                (
                    this.AddCardAttemptsDay == input.AddCardAttemptsDay ||
                    this.AddCardAttemptsDay != null &&
                    this.AddCardAttemptsDay.Equals(input.AddCardAttemptsDay)
                ) &&
                (
                    this.DeliveryAddressUsageDate == input.DeliveryAddressUsageDate ||
                    this.DeliveryAddressUsageDate != null &&
                    this.DeliveryAddressUsageDate.Equals(input.DeliveryAddressUsageDate)
                ) &&
                (
                    this.DeliveryAddressUsageIndicator == input.DeliveryAddressUsageIndicator ||
                    this.DeliveryAddressUsageIndicator != null &&
                    this.DeliveryAddressUsageIndicator.Equals(input.DeliveryAddressUsageIndicator)
                ) &&
                (
                    this.HomePhone == input.HomePhone ||
                    this.HomePhone != null &&
                    this.HomePhone.Equals(input.HomePhone)
                ) &&
                (
                    this.MobilePhone == input.MobilePhone ||
                    this.MobilePhone != null &&
                    this.MobilePhone.Equals(input.MobilePhone)
                ) &&
                (
                    this.PasswordChangeDate == input.PasswordChangeDate ||
                    this.PasswordChangeDate != null &&
                    this.PasswordChangeDate.Equals(input.PasswordChangeDate)
                ) &&
                (
                    this.PasswordChangeIndicator == input.PasswordChangeIndicator ||
                    this.PasswordChangeIndicator != null &&
                    this.PasswordChangeIndicator.Equals(input.PasswordChangeIndicator)
                ) &&
                (
                    this.PastTransactionsDay == input.PastTransactionsDay ||
                    this.PastTransactionsDay != null &&
                    this.PastTransactionsDay.Equals(input.PastTransactionsDay)
                ) &&
                (
                    this.PastTransactionsYear == input.PastTransactionsYear ||
                    this.PastTransactionsYear != null &&
                    this.PastTransactionsYear.Equals(input.PastTransactionsYear)
                ) &&
                (
                    this.PaymentAccountAge == input.PaymentAccountAge ||
                    this.PaymentAccountAge != null &&
                    this.PaymentAccountAge.Equals(input.PaymentAccountAge)
                ) &&
                (
                    this.PaymentAccountIndicator == input.PaymentAccountIndicator ||
                    this.PaymentAccountIndicator != null &&
                    this.PaymentAccountIndicator.Equals(input.PaymentAccountIndicator)
                ) &&
                (
                    this.PurchasesLast6Months == input.PurchasesLast6Months ||
                    this.PurchasesLast6Months != null &&
                    this.PurchasesLast6Months.Equals(input.PurchasesLast6Months)
                ) &&
                (
                    this.SuspiciousActivity == input.SuspiciousActivity ||
                    this.SuspiciousActivity != null &&
                    this.SuspiciousActivity.Equals(input.SuspiciousActivity)
                ) &&
                (
                    this.WorkPhone == input.WorkPhone ||
                    this.WorkPhone != null &&
                    this.WorkPhone.Equals(input.WorkPhone)
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
                if (this.AccountAgeIndicator != null)
                    hashCode = hashCode * 59 + this.AccountAgeIndicator.GetHashCode();
                if (this.AccountChangeDate != null)
                    hashCode = hashCode * 59 + this.AccountChangeDate.GetHashCode();
                if (this.AccountChangeIndicator != null)
                    hashCode = hashCode * 59 + this.AccountChangeIndicator.GetHashCode();
                if (this.AccountCreationDate != null)
                    hashCode = hashCode * 59 + this.AccountCreationDate.GetHashCode();
                if (this.AccountType != null)
                    hashCode = hashCode * 59 + this.AccountType.GetHashCode();
                if (this.AddCardAttemptsDay != null)
                    hashCode = hashCode * 59 + this.AddCardAttemptsDay.GetHashCode();
                if (this.DeliveryAddressUsageDate != null)
                    hashCode = hashCode * 59 + this.DeliveryAddressUsageDate.GetHashCode();
                if (this.DeliveryAddressUsageIndicator != null)
                    hashCode = hashCode * 59 + this.DeliveryAddressUsageIndicator.GetHashCode();
                if (this.HomePhone != null)
                    hashCode = hashCode * 59 + this.HomePhone.GetHashCode();
                if (this.MobilePhone != null)
                    hashCode = hashCode * 59 + this.MobilePhone.GetHashCode();
                if (this.PasswordChangeDate != null)
                    hashCode = hashCode * 59 + this.PasswordChangeDate.GetHashCode();
                if (this.PasswordChangeIndicator != null)
                    hashCode = hashCode * 59 + this.PasswordChangeIndicator.GetHashCode();
                if (this.PastTransactionsDay != null)
                    hashCode = hashCode * 59 + this.PastTransactionsDay.GetHashCode();
                if (this.PastTransactionsYear != null)
                    hashCode = hashCode * 59 + this.PastTransactionsYear.GetHashCode();
                if (this.PaymentAccountAge != null)
                    hashCode = hashCode * 59 + this.PaymentAccountAge.GetHashCode();
                if (this.PaymentAccountIndicator != null)
                    hashCode = hashCode * 59 + this.PaymentAccountIndicator.GetHashCode();
                if (this.PurchasesLast6Months != null)
                    hashCode = hashCode * 59 + this.PurchasesLast6Months.GetHashCode();
                if (this.SuspiciousActivity != null)
                    hashCode = hashCode * 59 + this.SuspiciousActivity.GetHashCode();
                if (this.WorkPhone != null)
                    hashCode = hashCode * 59 + this.WorkPhone.GetHashCode();
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