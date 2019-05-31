using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.EcommLibrary.Model.Checkout
{
    /// <summary>
    /// AccountInfo
    /// </summary>
    [DataContract]
    public partial class AccountInfo : IEquatable<AccountInfo>, IValidatableObject
    {
        /// <summary>
        /// Indicator of how long this shopper account exists in the merchant&#39;s environment.
        /// </summary>
        /// <value>Indicator of how long this shopper account exists in the merchant&#39;s environment.</value>
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
            [EnumMember(Value = "thisTransaction")]
            ThisTransaction = 2,

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
        /// Indicator of how long this shopper account exists in the merchant&#39;s environment.
        /// </summary>
        /// <value>Indicator of how long this shopper account exists in the merchant&#39;s environment.</value>
        [DataMember(Name = "accountAgeIndicator", EmitDefaultValue = false)]
        public AccountAgeIndicatorEnum? AccountAgeIndicator { get; set; }

        /// <summary>
        /// Indicator when the shopper&#39;s account was last changed.
        /// </summary>
        /// <value>Indicator when the shopper&#39;s account was last changed.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountChangeIndicatorEnum
        {
            /// <summary>
            /// Enum ThisTransaction for value: thisTransaction
            /// </summary>
            [EnumMember(Value = "thisTransaction")]
            ThisTransaction = 1,

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
        /// Indicator when the shopper&#39;s account was last changed.
        /// </summary>
        /// <value>Indicator when the shopper&#39;s account was last changed.</value>
        [DataMember(Name = "accountChangeIndicator", EmitDefaultValue = false)]
        public AccountChangeIndicatorEnum? AccountChangeIndicator { get; set; }

        /// <summary>
        /// Indicator for when this delivery address was last used.
        /// </summary>
        /// <value>Indicator for when this delivery address was last used.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeliveryAddressUsageIndicatorEnum
        {
            /// <summary>
            /// Enum ThisTransaction for value: thisTransaction
            /// </summary>
            [EnumMember(Value = "thisTransaction")]
            ThisTransaction = 1,

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
        /// Indicator for when this delivery address was last used.
        /// </summary>
        /// <value>Indicator for when this delivery address was last used.</value>
        [DataMember(Name = "deliveryAddressUsageIndicator", EmitDefaultValue = false)]
        public DeliveryAddressUsageIndicatorEnum? DeliveryAddressUsageIndicator { get; set; }

        /// <summary>
        /// Indicator when the shopper has changed their password.
        /// </summary>
        /// <value>Indicator when the shopper has changed their password.</value>
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
            [EnumMember(Value = "thisTransaction")]
            ThisTransaction = 2,

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
        /// Indicator when the shopper has changed their password.
        /// </summary>
        /// <value>Indicator when the shopper has changed their password.</value>
        [DataMember(Name = "passwordChangeIndicator", EmitDefaultValue = false)]
        public PasswordChangeIndicatorEnum? PasswordChangeIndicator { get; set; }

        /// <summary>
        /// Indicator for the amount of time this payment method was enrolled with this account.
        /// </summary>
        /// <value>Indicator for the amount of time this payment method was enrolled with this account.</value>
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
            [EnumMember(Value = "thisTransaction")]
            ThisTransaction = 2,

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
        /// Indicator for the amount of time this payment method was enrolled with this account.
        /// </summary>
        /// <value>Indicator for the amount of time this payment method was enrolled with this account.</value>
        [DataMember(Name = "paymentAccountIndicator", EmitDefaultValue = false)]
        public PaymentAccountIndicatorEnum? PaymentAccountIndicator { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountInfo" /> class.
        /// </summary>
        /// <param name="AccountAgeIndicator">Indicator of how long this shopper account exists in the merchant&#39;s environment..</param>
        /// <param name="AccountChangeDate">Date when the shopper&#39;s account was last changed..</param>
        /// <param name="AccountChangeIndicator">Indicator when the shopper&#39;s account was last changed..</param>
        /// <param name="AccountCreationDate">Date when the shopper&#39;s account was created..</param>
        /// <param name="AddCardAttemptsDay">Number of attempts the shopper tried to add a card to their account in the last day..</param>
        /// <param name="DeliveryAddressUsageDate">Date the selected delivery address was last used..</param>
        /// <param name="DeliveryAddressUsageIndicator">Indicator for when this delivery address was last used..</param>
        /// <param name="HomePhone">Shopper&#39;s home phone number (including the country code)..</param>
        /// <param name="MobilePhone">Shopper&#39;s mobile phone number (including the country code)..</param>
        /// <param name="PasswordChangeDate">Date when the shopper has changed their password..</param>
        /// <param name="PasswordChangeIndicator">Indicator when the shopper has changed their password..</param>
        /// <param name="PastTransactionsDay">Number of transactions of this shopper in the past 24 hours..</param>
        /// <param name="PastTransactionsYear">Number of transactions of this shopper in the past year..</param>
        /// <param name="PaymentAccountAge">Date this payment method was added to the shopper&#39;s account..</param>
        /// <param name="PaymentAccountIndicator">Indicator for the amount of time this payment method was enrolled with this account..</param>
        /// <param name="PurchasesLast6Months">Number of purchases in the last 6 months..</param>
        /// <param name="SuspiciousActivity">Whether suspicious activity was recorded on this account..</param>
        /// <param name="WorkPhone">Shopper&#39;s work phone number (including the country code)..</param>
        public AccountInfo(AccountAgeIndicatorEnum? AccountAgeIndicator = default(AccountAgeIndicatorEnum?),
            DateTime? AccountChangeDate = default(DateTime?),
            AccountChangeIndicatorEnum? AccountChangeIndicator = default(AccountChangeIndicatorEnum?),
            DateTime? AccountCreationDate = default(DateTime?), int? AddCardAttemptsDay = default(int?),
            DateTime? DeliveryAddressUsageDate = default(DateTime?),
            DeliveryAddressUsageIndicatorEnum? DeliveryAddressUsageIndicator =
                default(DeliveryAddressUsageIndicatorEnum?), string HomePhone = default(string),
            string MobilePhone = default(string), DateTime? PasswordChangeDate = default(DateTime?),
            PasswordChangeIndicatorEnum? PasswordChangeIndicator = default(PasswordChangeIndicatorEnum?),
            int? PastTransactionsDay = default(int?), int? PastTransactionsYear = default(int?),
            DateTime? PaymentAccountAge = default(DateTime?),
            PaymentAccountIndicatorEnum? PaymentAccountIndicator = default(PaymentAccountIndicatorEnum?),
            int? PurchasesLast6Months = default(int?), bool? SuspiciousActivity = default(bool?),
            string WorkPhone = default(string))
        {
            this.AccountAgeIndicator = AccountAgeIndicator;
            this.AccountChangeDate = AccountChangeDate;
            this.AccountChangeIndicator = AccountChangeIndicator;
            this.AccountCreationDate = AccountCreationDate;
            this.AddCardAttemptsDay = AddCardAttemptsDay;
            this.DeliveryAddressUsageDate = DeliveryAddressUsageDate;
            this.DeliveryAddressUsageIndicator = DeliveryAddressUsageIndicator;
            this.HomePhone = HomePhone;
            this.MobilePhone = MobilePhone;
            this.PasswordChangeDate = PasswordChangeDate;
            this.PasswordChangeIndicator = PasswordChangeIndicator;
            this.PastTransactionsDay = PastTransactionsDay;
            this.PastTransactionsYear = PastTransactionsYear;
            this.PaymentAccountAge = PaymentAccountAge;
            this.PaymentAccountIndicator = PaymentAccountIndicator;
            this.PurchasesLast6Months = PurchasesLast6Months;
            this.SuspiciousActivity = SuspiciousActivity;
            this.WorkPhone = WorkPhone;
        }


        /// <summary>
        /// Date when the shopper&#39;s account was last changed.
        /// </summary>
        /// <value>Date when the shopper&#39;s account was last changed.</value>
        [DataMember(Name = "accountChangeDate", EmitDefaultValue = false)]
        public DateTime? AccountChangeDate { get; set; }


        /// <summary>
        /// Date when the shopper&#39;s account was created.
        /// </summary>
        /// <value>Date when the shopper&#39;s account was created.</value>
        [DataMember(Name = "accountCreationDate", EmitDefaultValue = false)]
        public DateTime? AccountCreationDate { get; set; }

        /// <summary>
        /// Number of attempts the shopper tried to add a card to their account in the last day.
        /// </summary>
        /// <value>Number of attempts the shopper tried to add a card to their account in the last day.</value>
        [DataMember(Name = "addCardAttemptsDay", EmitDefaultValue = false)]
        public int? AddCardAttemptsDay { get; set; }

        /// <summary>
        /// Date the selected delivery address was last used.
        /// </summary>
        /// <value>Date the selected delivery address was last used.</value>
        [DataMember(Name = "deliveryAddressUsageDate", EmitDefaultValue = false)]
        public DateTime? DeliveryAddressUsageDate { get; set; }


        /// <summary>
        /// Shopper&#39;s home phone number (including the country code).
        /// </summary>
        /// <value>Shopper&#39;s home phone number (including the country code).</value>
        [DataMember(Name = "homePhone", EmitDefaultValue = false)]
        public string HomePhone { get; set; }

        /// <summary>
        /// Shopper&#39;s mobile phone number (including the country code).
        /// </summary>
        /// <value>Shopper&#39;s mobile phone number (including the country code).</value>
        [DataMember(Name = "mobilePhone", EmitDefaultValue = false)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Date when the shopper has changed their password.
        /// </summary>
        /// <value>Date when the shopper has changed their password.</value>
        [DataMember(Name = "passwordChangeDate", EmitDefaultValue = false)]
        public DateTime? PasswordChangeDate { get; set; }


        /// <summary>
        /// Number of transactions of this shopper in the past 24 hours.
        /// </summary>
        /// <value>Number of transactions of this shopper in the past 24 hours.</value>
        [DataMember(Name = "pastTransactionsDay", EmitDefaultValue = false)]
        public int? PastTransactionsDay { get; set; }

        /// <summary>
        /// Number of transactions of this shopper in the past year.
        /// </summary>
        /// <value>Number of transactions of this shopper in the past year.</value>
        [DataMember(Name = "pastTransactionsYear", EmitDefaultValue = false)]
        public int? PastTransactionsYear { get; set; }

        /// <summary>
        /// Date this payment method was added to the shopper&#39;s account.
        /// </summary>
        /// <value>Date this payment method was added to the shopper&#39;s account.</value>
        [DataMember(Name = "paymentAccountAge", EmitDefaultValue = false)]
        public DateTime? PaymentAccountAge { get; set; }


        /// <summary>
        /// Number of purchases in the last 6 months.
        /// </summary>
        /// <value>Number of purchases in the last 6 months.</value>
        [DataMember(Name = "purchasesLast6Months", EmitDefaultValue = false)]
        public int? PurchasesLast6Months { get; set; }

        /// <summary>
        /// Whether suspicious activity was recorded on this account.
        /// </summary>
        /// <value>Whether suspicious activity was recorded on this account.</value>
        [DataMember(Name = "suspiciousActivity", EmitDefaultValue = false)]
        public bool? SuspiciousActivity { get; set; }

        /// <summary>
        /// Shopper&#39;s work phone number (including the country code).
        /// </summary>
        /// <value>Shopper&#39;s work phone number (including the country code).</value>
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
            return Equals(input as AccountInfo);
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
                    AccountAgeIndicator == input.AccountAgeIndicator ||
                    AccountAgeIndicator != null &&
                    AccountAgeIndicator.Equals(input.AccountAgeIndicator)
                ) &&
                (
                    AccountChangeDate == input.AccountChangeDate ||
                    AccountChangeDate != null &&
                    AccountChangeDate.Equals(input.AccountChangeDate)
                ) &&
                (
                    AccountChangeIndicator == input.AccountChangeIndicator ||
                    AccountChangeIndicator != null &&
                    AccountChangeIndicator.Equals(input.AccountChangeIndicator)
                ) &&
                (
                    AccountCreationDate == input.AccountCreationDate ||
                    AccountCreationDate != null &&
                    AccountCreationDate.Equals(input.AccountCreationDate)
                ) &&
                (
                    AddCardAttemptsDay == input.AddCardAttemptsDay ||
                    AddCardAttemptsDay != null &&
                    AddCardAttemptsDay.Equals(input.AddCardAttemptsDay)
                ) &&
                (
                    DeliveryAddressUsageDate == input.DeliveryAddressUsageDate ||
                    DeliveryAddressUsageDate != null &&
                    DeliveryAddressUsageDate.Equals(input.DeliveryAddressUsageDate)
                ) &&
                (
                    DeliveryAddressUsageIndicator == input.DeliveryAddressUsageIndicator ||
                    DeliveryAddressUsageIndicator != null &&
                    DeliveryAddressUsageIndicator.Equals(input.DeliveryAddressUsageIndicator)
                ) &&
                (
                    HomePhone == input.HomePhone ||
                    HomePhone != null &&
                    HomePhone.Equals(input.HomePhone)
                ) &&
                (
                    MobilePhone == input.MobilePhone ||
                    MobilePhone != null &&
                    MobilePhone.Equals(input.MobilePhone)
                ) &&
                (
                    PasswordChangeDate == input.PasswordChangeDate ||
                    PasswordChangeDate != null &&
                    PasswordChangeDate.Equals(input.PasswordChangeDate)
                ) &&
                (
                    PasswordChangeIndicator == input.PasswordChangeIndicator ||
                    PasswordChangeIndicator != null &&
                    PasswordChangeIndicator.Equals(input.PasswordChangeIndicator)
                ) &&
                (
                    PastTransactionsDay == input.PastTransactionsDay ||
                    PastTransactionsDay != null &&
                    PastTransactionsDay.Equals(input.PastTransactionsDay)
                ) &&
                (
                    PastTransactionsYear == input.PastTransactionsYear ||
                    PastTransactionsYear != null &&
                    PastTransactionsYear.Equals(input.PastTransactionsYear)
                ) &&
                (
                    PaymentAccountAge == input.PaymentAccountAge ||
                    PaymentAccountAge != null &&
                    PaymentAccountAge.Equals(input.PaymentAccountAge)
                ) &&
                (
                    PaymentAccountIndicator == input.PaymentAccountIndicator ||
                    PaymentAccountIndicator != null &&
                    PaymentAccountIndicator.Equals(input.PaymentAccountIndicator)
                ) &&
                (
                    PurchasesLast6Months == input.PurchasesLast6Months ||
                    PurchasesLast6Months != null &&
                    PurchasesLast6Months.Equals(input.PurchasesLast6Months)
                ) &&
                (
                    SuspiciousActivity == input.SuspiciousActivity ||
                    SuspiciousActivity != null &&
                    SuspiciousActivity.Equals(input.SuspiciousActivity)
                ) &&
                (
                    WorkPhone == input.WorkPhone ||
                    WorkPhone != null &&
                    WorkPhone.Equals(input.WorkPhone)
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
                var hashCode = 41;
                if (AccountAgeIndicator != null)
                    hashCode = hashCode * 59 + AccountAgeIndicator.GetHashCode();
                if (AccountChangeDate != null)
                    hashCode = hashCode * 59 + AccountChangeDate.GetHashCode();
                if (AccountChangeIndicator != null)
                    hashCode = hashCode * 59 + AccountChangeIndicator.GetHashCode();
                if (AccountCreationDate != null)
                    hashCode = hashCode * 59 + AccountCreationDate.GetHashCode();
                if (AddCardAttemptsDay != null)
                    hashCode = hashCode * 59 + AddCardAttemptsDay.GetHashCode();
                if (DeliveryAddressUsageDate != null)
                    hashCode = hashCode * 59 + DeliveryAddressUsageDate.GetHashCode();
                if (DeliveryAddressUsageIndicator != null)
                    hashCode = hashCode * 59 + DeliveryAddressUsageIndicator.GetHashCode();
                if (HomePhone != null)
                    hashCode = hashCode * 59 + HomePhone.GetHashCode();
                if (MobilePhone != null)
                    hashCode = hashCode * 59 + MobilePhone.GetHashCode();
                if (PasswordChangeDate != null)
                    hashCode = hashCode * 59 + PasswordChangeDate.GetHashCode();
                if (PasswordChangeIndicator != null)
                    hashCode = hashCode * 59 + PasswordChangeIndicator.GetHashCode();
                if (PastTransactionsDay != null)
                    hashCode = hashCode * 59 + PastTransactionsDay.GetHashCode();
                if (PastTransactionsYear != null)
                    hashCode = hashCode * 59 + PastTransactionsYear.GetHashCode();
                if (PaymentAccountAge != null)
                    hashCode = hashCode * 59 + PaymentAccountAge.GetHashCode();
                if (PaymentAccountIndicator != null)
                    hashCode = hashCode * 59 + PaymentAccountIndicator.GetHashCode();
                if (PurchasesLast6Months != null)
                    hashCode = hashCode * 59 + PurchasesLast6Months.GetHashCode();
                if (SuspiciousActivity != null)
                    hashCode = hashCode * 59 + SuspiciousActivity.GetHashCode();
                if (WorkPhone != null)
                    hashCode = hashCode * 59 + WorkPhone.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}