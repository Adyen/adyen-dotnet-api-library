/*
* Configuration webhooks
*
*
* The version of the OpenAPI document: 2
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.ConfigurationWebhooks
{
    /// <summary>
    /// SweepConfigurationV2
    /// </summary>
    [DataContract(Name = "SweepConfigurationV2")]
    public partial class SweepConfigurationV2 : IEquatable<SweepConfigurationV2>, IValidatableObject
    {
        /// <summary>
        /// The type of transfer that results from the sweep.  Possible values:   - **bank**: Sweep to a [transfer instrument](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id).  - **internal**: Transfer to another [balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/balanceAccounts__resParam_id) within your platform.  Required when setting &#x60;priorities&#x60;.
        /// </summary>
        /// <value>The type of transfer that results from the sweep.  Possible values:   - **bank**: Sweep to a [transfer instrument](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id).  - **internal**: Transfer to another [balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/balanceAccounts__resParam_id) within your platform.  Required when setting &#x60;priorities&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CategoryEnum
        {
            /// <summary>
            /// Enum Bank for value: bank
            /// </summary>
            [EnumMember(Value = "bank")]
            Bank = 1,

            /// <summary>
            /// Enum Internal for value: internal
            /// </summary>
            [EnumMember(Value = "internal")]
            Internal = 2,

            /// <summary>
            /// Enum PlatformPayment for value: platformPayment
            /// </summary>
            [EnumMember(Value = "platformPayment")]
            PlatformPayment = 3

        }


        /// <summary>
        /// The type of transfer that results from the sweep.  Possible values:   - **bank**: Sweep to a [transfer instrument](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id).  - **internal**: Transfer to another [balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/balanceAccounts__resParam_id) within your platform.  Required when setting &#x60;priorities&#x60;.
        /// </summary>
        /// <value>The type of transfer that results from the sweep.  Possible values:   - **bank**: Sweep to a [transfer instrument](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id).  - **internal**: Transfer to another [balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/balanceAccounts__resParam_id) within your platform.  Required when setting &#x60;priorities&#x60;.</value>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public CategoryEnum? Category { get; set; }
        /// <summary>
        /// Defines Priorities
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PrioritiesEnum
        {
            /// <summary>
            /// Enum CrossBorder for value: crossBorder
            /// </summary>
            [EnumMember(Value = "crossBorder")]
            CrossBorder = 1,

            /// <summary>
            /// Enum Fast for value: fast
            /// </summary>
            [EnumMember(Value = "fast")]
            Fast = 2,

            /// <summary>
            /// Enum Instant for value: instant
            /// </summary>
            [EnumMember(Value = "instant")]
            Instant = 3,

            /// <summary>
            /// Enum Internal for value: internal
            /// </summary>
            [EnumMember(Value = "internal")]
            Internal = 4,

            /// <summary>
            /// Enum Regular for value: regular
            /// </summary>
            [EnumMember(Value = "regular")]
            Regular = 5,

            /// <summary>
            /// Enum Wire for value: wire
            /// </summary>
            [EnumMember(Value = "wire")]
            Wire = 6

        }



        /// <summary>
        /// The list of priorities for the bank transfer. This sets the speed at which the transfer is sent and the fees that you have to pay. You can provide multiple priorities, ordered by your preference. Adyen will try to pay out using the priorities in the given order. If the first priority is not currently supported or enabled for your platform, the system will try the next one, and so on.  The request will be accepted as long as **at least one** of the provided priorities is valid (i.e., supported by Adyen and activated for your platform). For example, if you provide &#x60;[\&quot;wire\&quot;,\&quot;regular\&quot;]&#x60;, and &#x60;wire&#x60; is not supported but &#x60;regular&#x60; is, the request will still be accepted and processed.  Possible values:  * **regular**: for normal, low-value transactions.  * **fast**: a faster way to transfer funds, but the fees are higher. Recommended for high-priority, low-value transactions.  * **wire**: the fastest way to transfer funds, but this has the highest fees. Recommended for high-priority, high-value transactions.  * **instant**: for instant funds transfers within the United States and in [SEPA locations](https://www.ecb.europa.eu/paym/integration/retail/sepa/html/index.en.html).  * **crossBorder**: for high-value transfers to a recipient in a different country.  * **internal**: for transfers to an Adyen-issued business bank account (by bank account number/IBAN).  Set &#x60;category&#x60; to **bank**. For more details, see optional priorities setup for [marketplaces](https://docs.adyen.com/marketplaces/payout-to-users/scheduled-payouts#optional-priorities-setup) or [platforms](https://docs.adyen.com/platforms/payout-to-users/scheduled-payouts#optional-priorities-setup).
        /// </summary>
        /// <value>The list of priorities for the bank transfer. This sets the speed at which the transfer is sent and the fees that you have to pay. You can provide multiple priorities, ordered by your preference. Adyen will try to pay out using the priorities in the given order. If the first priority is not currently supported or enabled for your platform, the system will try the next one, and so on.  The request will be accepted as long as **at least one** of the provided priorities is valid (i.e., supported by Adyen and activated for your platform). For example, if you provide &#x60;[\&quot;wire\&quot;,\&quot;regular\&quot;]&#x60;, and &#x60;wire&#x60; is not supported but &#x60;regular&#x60; is, the request will still be accepted and processed.  Possible values:  * **regular**: for normal, low-value transactions.  * **fast**: a faster way to transfer funds, but the fees are higher. Recommended for high-priority, low-value transactions.  * **wire**: the fastest way to transfer funds, but this has the highest fees. Recommended for high-priority, high-value transactions.  * **instant**: for instant funds transfers within the United States and in [SEPA locations](https://www.ecb.europa.eu/paym/integration/retail/sepa/html/index.en.html).  * **crossBorder**: for high-value transfers to a recipient in a different country.  * **internal**: for transfers to an Adyen-issued business bank account (by bank account number/IBAN).  Set &#x60;category&#x60; to **bank**. For more details, see optional priorities setup for [marketplaces](https://docs.adyen.com/marketplaces/payout-to-users/scheduled-payouts#optional-priorities-setup) or [platforms](https://docs.adyen.com/platforms/payout-to-users/scheduled-payouts#optional-priorities-setup).</value>
        [DataMember(Name = "priorities", EmitDefaultValue = false)]
        public List<PrioritiesEnum> Priorities { get; set; }
        /// <summary>
        /// The reason for disabling the sweep.
        /// </summary>
        /// <value>The reason for disabling the sweep.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReasonEnum
        {
            /// <summary>
            /// Enum AccountHierarchyNotActive for value: accountHierarchyNotActive
            /// </summary>
            [EnumMember(Value = "accountHierarchyNotActive")]
            AccountHierarchyNotActive = 1,

            /// <summary>
            /// Enum AmountLimitExceeded for value: amountLimitExceeded
            /// </summary>
            [EnumMember(Value = "amountLimitExceeded")]
            AmountLimitExceeded = 2,

            /// <summary>
            /// Enum Approved for value: approved
            /// </summary>
            [EnumMember(Value = "approved")]
            Approved = 3,

            /// <summary>
            /// Enum BalanceAccountTemporarilyBlockedByTransactionRule for value: balanceAccountTemporarilyBlockedByTransactionRule
            /// </summary>
            [EnumMember(Value = "balanceAccountTemporarilyBlockedByTransactionRule")]
            BalanceAccountTemporarilyBlockedByTransactionRule = 4,

            /// <summary>
            /// Enum CounterpartyAccountBlocked for value: counterpartyAccountBlocked
            /// </summary>
            [EnumMember(Value = "counterpartyAccountBlocked")]
            CounterpartyAccountBlocked = 5,

            /// <summary>
            /// Enum CounterpartyAccountClosed for value: counterpartyAccountClosed
            /// </summary>
            [EnumMember(Value = "counterpartyAccountClosed")]
            CounterpartyAccountClosed = 6,

            /// <summary>
            /// Enum CounterpartyAccountNotFound for value: counterpartyAccountNotFound
            /// </summary>
            [EnumMember(Value = "counterpartyAccountNotFound")]
            CounterpartyAccountNotFound = 7,

            /// <summary>
            /// Enum CounterpartyAddressRequired for value: counterpartyAddressRequired
            /// </summary>
            [EnumMember(Value = "counterpartyAddressRequired")]
            CounterpartyAddressRequired = 8,

            /// <summary>
            /// Enum CounterpartyBankTimedOut for value: counterpartyBankTimedOut
            /// </summary>
            [EnumMember(Value = "counterpartyBankTimedOut")]
            CounterpartyBankTimedOut = 9,

            /// <summary>
            /// Enum CounterpartyBankUnavailable for value: counterpartyBankUnavailable
            /// </summary>
            [EnumMember(Value = "counterpartyBankUnavailable")]
            CounterpartyBankUnavailable = 10,

            /// <summary>
            /// Enum Declined for value: declined
            /// </summary>
            [EnumMember(Value = "declined")]
            Declined = 11,

            /// <summary>
            /// Enum DeclinedByTransactionRule for value: declinedByTransactionRule
            /// </summary>
            [EnumMember(Value = "declinedByTransactionRule")]
            DeclinedByTransactionRule = 12,

            /// <summary>
            /// Enum DirectDebitNotSupported for value: directDebitNotSupported
            /// </summary>
            [EnumMember(Value = "directDebitNotSupported")]
            DirectDebitNotSupported = 13,

            /// <summary>
            /// Enum Error for value: error
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 14,

            /// <summary>
            /// Enum NotEnoughBalance for value: notEnoughBalance
            /// </summary>
            [EnumMember(Value = "notEnoughBalance")]
            NotEnoughBalance = 15,

            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 16,

            /// <summary>
            /// Enum PendingApproval for value: pendingApproval
            /// </summary>
            [EnumMember(Value = "pendingApproval")]
            PendingApproval = 17,

            /// <summary>
            /// Enum PendingExecution for value: pendingExecution
            /// </summary>
            [EnumMember(Value = "pendingExecution")]
            PendingExecution = 18,

            /// <summary>
            /// Enum RefusedByCounterpartyBank for value: refusedByCounterpartyBank
            /// </summary>
            [EnumMember(Value = "refusedByCounterpartyBank")]
            RefusedByCounterpartyBank = 19,

            /// <summary>
            /// Enum RefusedByCustomer for value: refusedByCustomer
            /// </summary>
            [EnumMember(Value = "refusedByCustomer")]
            RefusedByCustomer = 20,

            /// <summary>
            /// Enum RouteNotFound for value: routeNotFound
            /// </summary>
            [EnumMember(Value = "routeNotFound")]
            RouteNotFound = 21,

            /// <summary>
            /// Enum ScaFailed for value: scaFailed
            /// </summary>
            [EnumMember(Value = "scaFailed")]
            ScaFailed = 22,

            /// <summary>
            /// Enum TransferInstrumentDoesNotExist for value: transferInstrumentDoesNotExist
            /// </summary>
            [EnumMember(Value = "transferInstrumentDoesNotExist")]
            TransferInstrumentDoesNotExist = 23,

            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 24

        }


        /// <summary>
        /// The reason for disabling the sweep.
        /// </summary>
        /// <value>The reason for disabling the sweep.</value>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public ReasonEnum? Reason { get; set; }
        /// <summary>
        /// The status of the sweep. If not provided, by default, this is set to **active**.  Possible values:    * **active**:  the sweep is enabled and funds will be pulled in or pushed out based on the defined configuration.    * **inactive**: the sweep is disabled and cannot be triggered.   
        /// </summary>
        /// <value>The status of the sweep. If not provided, by default, this is set to **active**.  Possible values:    * **active**:  the sweep is enabled and funds will be pulled in or pushed out based on the defined configuration.    * **inactive**: the sweep is disabled and cannot be triggered.   </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,

            /// <summary>
            /// Enum Inactive for value: inactive
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive = 2

        }


        /// <summary>
        /// The status of the sweep. If not provided, by default, this is set to **active**.  Possible values:    * **active**:  the sweep is enabled and funds will be pulled in or pushed out based on the defined configuration.    * **inactive**: the sweep is disabled and cannot be triggered.   
        /// </summary>
        /// <value>The status of the sweep. If not provided, by default, this is set to **active**.  Possible values:    * **active**:  the sweep is enabled and funds will be pulled in or pushed out based on the defined configuration.    * **inactive**: the sweep is disabled and cannot be triggered.   </value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// The direction of sweep, whether pushing out or pulling in funds to the balance account. If not provided, by default, this is set to **push**.  Possible values:   * **push**: _push out funds_ to a destination balance account or transfer instrument.   * **pull**: _pull in funds_ from a source merchant account, transfer instrument, or balance account.
        /// </summary>
        /// <value>The direction of sweep, whether pushing out or pulling in funds to the balance account. If not provided, by default, this is set to **push**.  Possible values:   * **push**: _push out funds_ to a destination balance account or transfer instrument.   * **pull**: _pull in funds_ from a source merchant account, transfer instrument, or balance account.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Pull for value: pull
            /// </summary>
            [EnumMember(Value = "pull")]
            Pull = 1,

            /// <summary>
            /// Enum Push for value: push
            /// </summary>
            [EnumMember(Value = "push")]
            Push = 2

        }


        /// <summary>
        /// The direction of sweep, whether pushing out or pulling in funds to the balance account. If not provided, by default, this is set to **push**.  Possible values:   * **push**: _push out funds_ to a destination balance account or transfer instrument.   * **pull**: _pull in funds_ from a source merchant account, transfer instrument, or balance account.
        /// </summary>
        /// <value>The direction of sweep, whether pushing out or pulling in funds to the balance account. If not provided, by default, this is set to **push**.  Possible values:   * **push**: _push out funds_ to a destination balance account or transfer instrument.   * **pull**: _pull in funds_ from a source merchant account, transfer instrument, or balance account.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SweepConfigurationV2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SweepConfigurationV2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SweepConfigurationV2" /> class.
        /// </summary>
        /// <param name="category">The type of transfer that results from the sweep.  Possible values:   - **bank**: Sweep to a [transfer instrument](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id).  - **internal**: Transfer to another [balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/balanceAccounts__resParam_id) within your platform.  Required when setting &#x60;priorities&#x60;..</param>
        /// <param name="counterparty">counterparty (required).</param>
        /// <param name="currency">The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes) in uppercase. For example, **EUR**.  The sweep currency must match any of the [balances currencies](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balanceAccounts/{id}__resParam_balances). (required).</param>
        /// <param name="description">The message that will be used in the sweep transfer&#39;s description body with a maximum length of 140 characters.  If the message is longer after replacing placeholders, the message will be cut off at 140 characters..</param>
        /// <param name="id">The unique identifier of the sweep. (required).</param>
        /// <param name="priorities">The list of priorities for the bank transfer. This sets the speed at which the transfer is sent and the fees that you have to pay. You can provide multiple priorities, ordered by your preference. Adyen will try to pay out using the priorities in the given order. If the first priority is not currently supported or enabled for your platform, the system will try the next one, and so on.  The request will be accepted as long as **at least one** of the provided priorities is valid (i.e., supported by Adyen and activated for your platform). For example, if you provide &#x60;[\&quot;wire\&quot;,\&quot;regular\&quot;]&#x60;, and &#x60;wire&#x60; is not supported but &#x60;regular&#x60; is, the request will still be accepted and processed.  Possible values:  * **regular**: for normal, low-value transactions.  * **fast**: a faster way to transfer funds, but the fees are higher. Recommended for high-priority, low-value transactions.  * **wire**: the fastest way to transfer funds, but this has the highest fees. Recommended for high-priority, high-value transactions.  * **instant**: for instant funds transfers within the United States and in [SEPA locations](https://www.ecb.europa.eu/paym/integration/retail/sepa/html/index.en.html).  * **crossBorder**: for high-value transfers to a recipient in a different country.  * **internal**: for transfers to an Adyen-issued business bank account (by bank account number/IBAN).  Set &#x60;category&#x60; to **bank**. For more details, see optional priorities setup for [marketplaces](https://docs.adyen.com/marketplaces/payout-to-users/scheduled-payouts#optional-priorities-setup) or [platforms](https://docs.adyen.com/platforms/payout-to-users/scheduled-payouts#optional-priorities-setup)..</param>
        /// <param name="reason">The reason for disabling the sweep..</param>
        /// <param name="reasonDetail">The human readable reason for disabling the sweep..</param>
        /// <param name="reference">Your reference for the sweep configuration..</param>
        /// <param name="referenceForBeneficiary">The reference sent to or received from the counterparty. Only alphanumeric characters are allowed..</param>
        /// <param name="schedule">schedule (required).</param>
        /// <param name="status">The status of the sweep. If not provided, by default, this is set to **active**.  Possible values:    * **active**:  the sweep is enabled and funds will be pulled in or pushed out based on the defined configuration.    * **inactive**: the sweep is disabled and cannot be triggered.   .</param>
        /// <param name="sweepAmount">sweepAmount.</param>
        /// <param name="targetAmount">targetAmount.</param>
        /// <param name="triggerAmount">triggerAmount.</param>
        /// <param name="type">The direction of sweep, whether pushing out or pulling in funds to the balance account. If not provided, by default, this is set to **push**.  Possible values:   * **push**: _push out funds_ to a destination balance account or transfer instrument.   * **pull**: _pull in funds_ from a source merchant account, transfer instrument, or balance account. (default to TypeEnum.Push).</param>
        public SweepConfigurationV2(CategoryEnum? category = default(CategoryEnum?), SweepCounterparty counterparty = default(SweepCounterparty), string currency = default(string), string description = default(string), string id = default(string), List<PrioritiesEnum> priorities = default(List<PrioritiesEnum>), ReasonEnum? reason = default(ReasonEnum?), string reasonDetail = default(string), string reference = default(string), string referenceForBeneficiary = default(string), SweepSchedule schedule = default(SweepSchedule), StatusEnum? status = default(StatusEnum?), Amount sweepAmount = default(Amount), Amount targetAmount = default(Amount), Amount triggerAmount = default(Amount), TypeEnum? type = TypeEnum.Push)
        {
            this.Counterparty = counterparty;
            this.Currency = currency;
            this.Id = id;
            this.Schedule = schedule;
            this.Category = category;
            this.Description = description;
            this.Priorities = priorities;
            this.Reason = reason;
            this.ReasonDetail = reasonDetail;
            this.Reference = reference;
            this.ReferenceForBeneficiary = referenceForBeneficiary;
            this.Status = status;
            this.SweepAmount = sweepAmount;
            this.TargetAmount = targetAmount;
            this.TriggerAmount = triggerAmount;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Counterparty
        /// </summary>
        [DataMember(Name = "counterparty", IsRequired = false, EmitDefaultValue = false)]
        public SweepCounterparty Counterparty { get; set; }

        /// <summary>
        /// The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes) in uppercase. For example, **EUR**.  The sweep currency must match any of the [balances currencies](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balanceAccounts/{id}__resParam_balances).
        /// </summary>
        /// <value>The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes) in uppercase. For example, **EUR**.  The sweep currency must match any of the [balances currencies](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balanceAccounts/{id}__resParam_balances).</value>
        [DataMember(Name = "currency", IsRequired = false, EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// The message that will be used in the sweep transfer&#39;s description body with a maximum length of 140 characters.  If the message is longer after replacing placeholders, the message will be cut off at 140 characters.
        /// </summary>
        /// <value>The message that will be used in the sweep transfer&#39;s description body with a maximum length of 140 characters.  If the message is longer after replacing placeholders, the message will be cut off at 140 characters.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The unique identifier of the sweep.
        /// </summary>
        /// <value>The unique identifier of the sweep.</value>
        [DataMember(Name = "id", IsRequired = false, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The human readable reason for disabling the sweep.
        /// </summary>
        /// <value>The human readable reason for disabling the sweep.</value>
        [DataMember(Name = "reasonDetail", EmitDefaultValue = false)]
        public string ReasonDetail { get; set; }

        /// <summary>
        /// Your reference for the sweep configuration.
        /// </summary>
        /// <value>Your reference for the sweep configuration.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// The reference sent to or received from the counterparty. Only alphanumeric characters are allowed.
        /// </summary>
        /// <value>The reference sent to or received from the counterparty. Only alphanumeric characters are allowed.</value>
        [DataMember(Name = "referenceForBeneficiary", EmitDefaultValue = false)]
        public string ReferenceForBeneficiary { get; set; }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name = "schedule", IsRequired = false, EmitDefaultValue = false)]
        public SweepSchedule Schedule { get; set; }

        /// <summary>
        /// Gets or Sets SweepAmount
        /// </summary>
        [DataMember(Name = "sweepAmount", EmitDefaultValue = false)]
        public Amount SweepAmount { get; set; }

        /// <summary>
        /// Gets or Sets TargetAmount
        /// </summary>
        [DataMember(Name = "targetAmount", EmitDefaultValue = false)]
        public Amount TargetAmount { get; set; }

        /// <summary>
        /// Gets or Sets TriggerAmount
        /// </summary>
        [DataMember(Name = "triggerAmount", EmitDefaultValue = false)]
        public Amount TriggerAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SweepConfigurationV2 {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Counterparty: ").Append(Counterparty).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Priorities: ").Append(Priorities).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  ReasonDetail: ").Append(ReasonDetail).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  ReferenceForBeneficiary: ").Append(ReferenceForBeneficiary).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SweepAmount: ").Append(SweepAmount).Append("\n");
            sb.Append("  TargetAmount: ").Append(TargetAmount).Append("\n");
            sb.Append("  TriggerAmount: ").Append(TriggerAmount).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SweepConfigurationV2);
        }

        /// <summary>
        /// Returns true if SweepConfigurationV2 instances are equal
        /// </summary>
        /// <param name="input">Instance of SweepConfigurationV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SweepConfigurationV2 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Category == input.Category ||
                    this.Category.Equals(input.Category)
                ) && 
                (
                    this.Counterparty == input.Counterparty ||
                    (this.Counterparty != null &&
                    this.Counterparty.Equals(input.Counterparty))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Priorities == input.Priorities ||
                    this.Priorities.SequenceEqual(input.Priorities)
                ) && 
                (
                    this.Reason == input.Reason ||
                    this.Reason.Equals(input.Reason)
                ) && 
                (
                    this.ReasonDetail == input.ReasonDetail ||
                    (this.ReasonDetail != null &&
                    this.ReasonDetail.Equals(input.ReasonDetail))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.ReferenceForBeneficiary == input.ReferenceForBeneficiary ||
                    (this.ReferenceForBeneficiary != null &&
                    this.ReferenceForBeneficiary.Equals(input.ReferenceForBeneficiary))
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.SweepAmount == input.SweepAmount ||
                    (this.SweepAmount != null &&
                    this.SweepAmount.Equals(input.SweepAmount))
                ) && 
                (
                    this.TargetAmount == input.TargetAmount ||
                    (this.TargetAmount != null &&
                    this.TargetAmount.Equals(input.TargetAmount))
                ) && 
                (
                    this.TriggerAmount == input.TriggerAmount ||
                    (this.TriggerAmount != null &&
                    this.TriggerAmount.Equals(input.TriggerAmount))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                hashCode = (hashCode * 59) + this.Category.GetHashCode();
                if (this.Counterparty != null)
                {
                    hashCode = (hashCode * 59) + this.Counterparty.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Priorities.GetHashCode();
                hashCode = (hashCode * 59) + this.Reason.GetHashCode();
                if (this.ReasonDetail != null)
                {
                    hashCode = (hashCode * 59) + this.ReasonDetail.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.ReferenceForBeneficiary != null)
                {
                    hashCode = (hashCode * 59) + this.ReferenceForBeneficiary.GetHashCode();
                }
                if (this.Schedule != null)
                {
                    hashCode = (hashCode * 59) + this.Schedule.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.SweepAmount != null)
                {
                    hashCode = (hashCode * 59) + this.SweepAmount.GetHashCode();
                }
                if (this.TargetAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TargetAmount.GetHashCode();
                }
                if (this.TriggerAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TriggerAmount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                return hashCode;
            }
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // Reference (string) maxLength
            if (this.Reference != null && this.Reference.Length > 80)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Reference, length must be less than 80.", new [] { "Reference" });
            }

            // ReferenceForBeneficiary (string) maxLength
            if (this.ReferenceForBeneficiary != null && this.ReferenceForBeneficiary.Length > 80)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReferenceForBeneficiary, length must be less than 80.", new [] { "ReferenceForBeneficiary" });
            }

            yield break;
        }
    }

}
