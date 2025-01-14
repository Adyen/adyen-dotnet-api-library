/*
* Configuration API
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

namespace Adyen.Model.BalancePlatform
{
    /// <summary>
    /// VerificationErrorRecursive
    /// </summary>
    [DataContract(Name = "VerificationError-recursive")]
    public partial class VerificationErrorRecursive : IEquatable<VerificationErrorRecursive>, IValidatableObject
    {
        /// <summary>
        /// Defines Capabilities
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CapabilitiesEnum
        {
            /// <summary>
            /// Enum AcceptExternalFunding for value: acceptExternalFunding
            /// </summary>
            [EnumMember(Value = "acceptExternalFunding")]
            AcceptExternalFunding = 1,

            /// <summary>
            /// Enum AcceptPspFunding for value: acceptPspFunding
            /// </summary>
            [EnumMember(Value = "acceptPspFunding")]
            AcceptPspFunding = 2,

            /// <summary>
            /// Enum AcceptTransactionInRestrictedCountries for value: acceptTransactionInRestrictedCountries
            /// </summary>
            [EnumMember(Value = "acceptTransactionInRestrictedCountries")]
            AcceptTransactionInRestrictedCountries = 3,

            /// <summary>
            /// Enum AcceptTransactionInRestrictedCountriesCommercial for value: acceptTransactionInRestrictedCountriesCommercial
            /// </summary>
            [EnumMember(Value = "acceptTransactionInRestrictedCountriesCommercial")]
            AcceptTransactionInRestrictedCountriesCommercial = 4,

            /// <summary>
            /// Enum AcceptTransactionInRestrictedCountriesConsumer for value: acceptTransactionInRestrictedCountriesConsumer
            /// </summary>
            [EnumMember(Value = "acceptTransactionInRestrictedCountriesConsumer")]
            AcceptTransactionInRestrictedCountriesConsumer = 5,

            /// <summary>
            /// Enum AcceptTransactionInRestrictedIndustries for value: acceptTransactionInRestrictedIndustries
            /// </summary>
            [EnumMember(Value = "acceptTransactionInRestrictedIndustries")]
            AcceptTransactionInRestrictedIndustries = 6,

            /// <summary>
            /// Enum AcceptTransactionInRestrictedIndustriesCommercial for value: acceptTransactionInRestrictedIndustriesCommercial
            /// </summary>
            [EnumMember(Value = "acceptTransactionInRestrictedIndustriesCommercial")]
            AcceptTransactionInRestrictedIndustriesCommercial = 7,

            /// <summary>
            /// Enum AcceptTransactionInRestrictedIndustriesConsumer for value: acceptTransactionInRestrictedIndustriesConsumer
            /// </summary>
            [EnumMember(Value = "acceptTransactionInRestrictedIndustriesConsumer")]
            AcceptTransactionInRestrictedIndustriesConsumer = 8,

            /// <summary>
            /// Enum Acquiring for value: acquiring
            /// </summary>
            [EnumMember(Value = "acquiring")]
            Acquiring = 9,

            /// <summary>
            /// Enum AtmWithdrawal for value: atmWithdrawal
            /// </summary>
            [EnumMember(Value = "atmWithdrawal")]
            AtmWithdrawal = 10,

            /// <summary>
            /// Enum AtmWithdrawalCommercial for value: atmWithdrawalCommercial
            /// </summary>
            [EnumMember(Value = "atmWithdrawalCommercial")]
            AtmWithdrawalCommercial = 11,

            /// <summary>
            /// Enum AtmWithdrawalConsumer for value: atmWithdrawalConsumer
            /// </summary>
            [EnumMember(Value = "atmWithdrawalConsumer")]
            AtmWithdrawalConsumer = 12,

            /// <summary>
            /// Enum AtmWithdrawalInRestrictedCountries for value: atmWithdrawalInRestrictedCountries
            /// </summary>
            [EnumMember(Value = "atmWithdrawalInRestrictedCountries")]
            AtmWithdrawalInRestrictedCountries = 13,

            /// <summary>
            /// Enum AtmWithdrawalInRestrictedCountriesCommercial for value: atmWithdrawalInRestrictedCountriesCommercial
            /// </summary>
            [EnumMember(Value = "atmWithdrawalInRestrictedCountriesCommercial")]
            AtmWithdrawalInRestrictedCountriesCommercial = 14,

            /// <summary>
            /// Enum AtmWithdrawalInRestrictedCountriesConsumer for value: atmWithdrawalInRestrictedCountriesConsumer
            /// </summary>
            [EnumMember(Value = "atmWithdrawalInRestrictedCountriesConsumer")]
            AtmWithdrawalInRestrictedCountriesConsumer = 15,

            /// <summary>
            /// Enum AuthorisedPaymentInstrumentUser for value: authorisedPaymentInstrumentUser
            /// </summary>
            [EnumMember(Value = "authorisedPaymentInstrumentUser")]
            AuthorisedPaymentInstrumentUser = 16,

            /// <summary>
            /// Enum GetGrantOffers for value: getGrantOffers
            /// </summary>
            [EnumMember(Value = "getGrantOffers")]
            GetGrantOffers = 17,

            /// <summary>
            /// Enum IssueBankAccount for value: issueBankAccount
            /// </summary>
            [EnumMember(Value = "issueBankAccount")]
            IssueBankAccount = 18,

            /// <summary>
            /// Enum IssueCard for value: issueCard
            /// </summary>
            [EnumMember(Value = "issueCard")]
            IssueCard = 19,

            /// <summary>
            /// Enum IssueCardCommercial for value: issueCardCommercial
            /// </summary>
            [EnumMember(Value = "issueCardCommercial")]
            IssueCardCommercial = 20,

            /// <summary>
            /// Enum IssueCardConsumer for value: issueCardConsumer
            /// </summary>
            [EnumMember(Value = "issueCardConsumer")]
            IssueCardConsumer = 21,

            /// <summary>
            /// Enum IssueChargeCard for value: issueChargeCard
            /// </summary>
            [EnumMember(Value = "issueChargeCard")]
            IssueChargeCard = 22,

            /// <summary>
            /// Enum IssueChargeCardCommercial for value: issueChargeCardCommercial
            /// </summary>
            [EnumMember(Value = "issueChargeCardCommercial")]
            IssueChargeCardCommercial = 23,

            /// <summary>
            /// Enum IssueCreditLimit for value: issueCreditLimit
            /// </summary>
            [EnumMember(Value = "issueCreditLimit")]
            IssueCreditLimit = 24,

            /// <summary>
            /// Enum LocalAcceptance for value: localAcceptance
            /// </summary>
            [EnumMember(Value = "localAcceptance")]
            LocalAcceptance = 25,

            /// <summary>
            /// Enum Payout for value: payout
            /// </summary>
            [EnumMember(Value = "payout")]
            Payout = 26,

            /// <summary>
            /// Enum PayoutToTransferInstrument for value: payoutToTransferInstrument
            /// </summary>
            [EnumMember(Value = "payoutToTransferInstrument")]
            PayoutToTransferInstrument = 27,

            /// <summary>
            /// Enum Processing for value: processing
            /// </summary>
            [EnumMember(Value = "processing")]
            Processing = 28,

            /// <summary>
            /// Enum ReceiveFromBalanceAccount for value: receiveFromBalanceAccount
            /// </summary>
            [EnumMember(Value = "receiveFromBalanceAccount")]
            ReceiveFromBalanceAccount = 29,

            /// <summary>
            /// Enum ReceiveFromPlatformPayments for value: receiveFromPlatformPayments
            /// </summary>
            [EnumMember(Value = "receiveFromPlatformPayments")]
            ReceiveFromPlatformPayments = 30,

            /// <summary>
            /// Enum ReceiveFromThirdParty for value: receiveFromThirdParty
            /// </summary>
            [EnumMember(Value = "receiveFromThirdParty")]
            ReceiveFromThirdParty = 31,

            /// <summary>
            /// Enum ReceiveFromTransferInstrument for value: receiveFromTransferInstrument
            /// </summary>
            [EnumMember(Value = "receiveFromTransferInstrument")]
            ReceiveFromTransferInstrument = 32,

            /// <summary>
            /// Enum ReceiveGrants for value: receiveGrants
            /// </summary>
            [EnumMember(Value = "receiveGrants")]
            ReceiveGrants = 33,

            /// <summary>
            /// Enum ReceivePayments for value: receivePayments
            /// </summary>
            [EnumMember(Value = "receivePayments")]
            ReceivePayments = 34,

            /// <summary>
            /// Enum SendToBalanceAccount for value: sendToBalanceAccount
            /// </summary>
            [EnumMember(Value = "sendToBalanceAccount")]
            SendToBalanceAccount = 35,

            /// <summary>
            /// Enum SendToThirdParty for value: sendToThirdParty
            /// </summary>
            [EnumMember(Value = "sendToThirdParty")]
            SendToThirdParty = 36,

            /// <summary>
            /// Enum SendToTransferInstrument for value: sendToTransferInstrument
            /// </summary>
            [EnumMember(Value = "sendToTransferInstrument")]
            SendToTransferInstrument = 37,

            /// <summary>
            /// Enum ThirdPartyFunding for value: thirdPartyFunding
            /// </summary>
            [EnumMember(Value = "thirdPartyFunding")]
            ThirdPartyFunding = 38,

            /// <summary>
            /// Enum UseCard for value: useCard
            /// </summary>
            [EnumMember(Value = "useCard")]
            UseCard = 39,

            /// <summary>
            /// Enum UseCardCommercial for value: useCardCommercial
            /// </summary>
            [EnumMember(Value = "useCardCommercial")]
            UseCardCommercial = 40,

            /// <summary>
            /// Enum UseCardConsumer for value: useCardConsumer
            /// </summary>
            [EnumMember(Value = "useCardConsumer")]
            UseCardConsumer = 41,

            /// <summary>
            /// Enum UseCardInRestrictedCountries for value: useCardInRestrictedCountries
            /// </summary>
            [EnumMember(Value = "useCardInRestrictedCountries")]
            UseCardInRestrictedCountries = 42,

            /// <summary>
            /// Enum UseCardInRestrictedCountriesCommercial for value: useCardInRestrictedCountriesCommercial
            /// </summary>
            [EnumMember(Value = "useCardInRestrictedCountriesCommercial")]
            UseCardInRestrictedCountriesCommercial = 43,

            /// <summary>
            /// Enum UseCardInRestrictedCountriesConsumer for value: useCardInRestrictedCountriesConsumer
            /// </summary>
            [EnumMember(Value = "useCardInRestrictedCountriesConsumer")]
            UseCardInRestrictedCountriesConsumer = 44,

            /// <summary>
            /// Enum UseCardInRestrictedIndustries for value: useCardInRestrictedIndustries
            /// </summary>
            [EnumMember(Value = "useCardInRestrictedIndustries")]
            UseCardInRestrictedIndustries = 45,

            /// <summary>
            /// Enum UseCardInRestrictedIndustriesCommercial for value: useCardInRestrictedIndustriesCommercial
            /// </summary>
            [EnumMember(Value = "useCardInRestrictedIndustriesCommercial")]
            UseCardInRestrictedIndustriesCommercial = 46,

            /// <summary>
            /// Enum UseCardInRestrictedIndustriesConsumer for value: useCardInRestrictedIndustriesConsumer
            /// </summary>
            [EnumMember(Value = "useCardInRestrictedIndustriesConsumer")]
            UseCardInRestrictedIndustriesConsumer = 47,

            /// <summary>
            /// Enum UseChargeCard for value: useChargeCard
            /// </summary>
            [EnumMember(Value = "useChargeCard")]
            UseChargeCard = 48,

            /// <summary>
            /// Enum UseChargeCardCommercial for value: useChargeCardCommercial
            /// </summary>
            [EnumMember(Value = "useChargeCardCommercial")]
            UseChargeCardCommercial = 49,

            /// <summary>
            /// Enum WithdrawFromAtm for value: withdrawFromAtm
            /// </summary>
            [EnumMember(Value = "withdrawFromAtm")]
            WithdrawFromAtm = 50,

            /// <summary>
            /// Enum WithdrawFromAtmCommercial for value: withdrawFromAtmCommercial
            /// </summary>
            [EnumMember(Value = "withdrawFromAtmCommercial")]
            WithdrawFromAtmCommercial = 51,

            /// <summary>
            /// Enum WithdrawFromAtmConsumer for value: withdrawFromAtmConsumer
            /// </summary>
            [EnumMember(Value = "withdrawFromAtmConsumer")]
            WithdrawFromAtmConsumer = 52,

            /// <summary>
            /// Enum WithdrawFromAtmInRestrictedCountries for value: withdrawFromAtmInRestrictedCountries
            /// </summary>
            [EnumMember(Value = "withdrawFromAtmInRestrictedCountries")]
            WithdrawFromAtmInRestrictedCountries = 53,

            /// <summary>
            /// Enum WithdrawFromAtmInRestrictedCountriesCommercial for value: withdrawFromAtmInRestrictedCountriesCommercial
            /// </summary>
            [EnumMember(Value = "withdrawFromAtmInRestrictedCountriesCommercial")]
            WithdrawFromAtmInRestrictedCountriesCommercial = 54,

            /// <summary>
            /// Enum WithdrawFromAtmInRestrictedCountriesConsumer for value: withdrawFromAtmInRestrictedCountriesConsumer
            /// </summary>
            [EnumMember(Value = "withdrawFromAtmInRestrictedCountriesConsumer")]
            WithdrawFromAtmInRestrictedCountriesConsumer = 55

        }



        /// <summary>
        /// Contains the capabilities that the verification error applies to.
        /// </summary>
        /// <value>Contains the capabilities that the verification error applies to.</value>
        [DataMember(Name = "capabilities", EmitDefaultValue = false)]
        public List<CapabilitiesEnum> Capabilities { get; set; }
        /// <summary>
        /// The type of error.   Possible values: **invalidInput**, **dataMissing**.
        /// </summary>
        /// <value>The type of error.   Possible values: **invalidInput**, **dataMissing**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum DataMissing for value: dataMissing
            /// </summary>
            [EnumMember(Value = "dataMissing")]
            DataMissing = 1,

            /// <summary>
            /// Enum InvalidInput for value: invalidInput
            /// </summary>
            [EnumMember(Value = "invalidInput")]
            InvalidInput = 2,

            /// <summary>
            /// Enum PendingStatus for value: pendingStatus
            /// </summary>
            [EnumMember(Value = "pendingStatus")]
            PendingStatus = 3

        }


        /// <summary>
        /// The type of error.   Possible values: **invalidInput**, **dataMissing**.
        /// </summary>
        /// <value>The type of error.   Possible values: **invalidInput**, **dataMissing**.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VerificationErrorRecursive" /> class.
        /// </summary>
        /// <param name="capabilities">Contains the capabilities that the verification error applies to..</param>
        /// <param name="code">The verification error code..</param>
        /// <param name="message">A description of the error..</param>
        /// <param name="type">The type of error.   Possible values: **invalidInput**, **dataMissing**..</param>
        /// <param name="remediatingActions">Contains the actions that you can take to resolve the verification error..</param>
        public VerificationErrorRecursive(List<CapabilitiesEnum> capabilities = default(List<CapabilitiesEnum>), string code = default(string), string message = default(string), TypeEnum? type = default(TypeEnum?), List<RemediatingAction> remediatingActions = default(List<RemediatingAction>))
        {
            this.Capabilities = capabilities;
            this.Code = code;
            this.Message = message;
            this.Type = type;
            this.RemediatingActions = remediatingActions;
        }

        /// <summary>
        /// The verification error code.
        /// </summary>
        /// <value>The verification error code.</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// A description of the error.
        /// </summary>
        /// <value>A description of the error.</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Contains the actions that you can take to resolve the verification error.
        /// </summary>
        /// <value>Contains the actions that you can take to resolve the verification error.</value>
        [DataMember(Name = "remediatingActions", EmitDefaultValue = false)]
        public List<RemediatingAction> RemediatingActions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VerificationErrorRecursive {\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  RemediatingActions: ").Append(RemediatingActions).Append("\n");
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
            return this.Equals(input as VerificationErrorRecursive);
        }

        /// <summary>
        /// Returns true if VerificationErrorRecursive instances are equal
        /// </summary>
        /// <param name="input">Instance of VerificationErrorRecursive to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerificationErrorRecursive input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Capabilities == input.Capabilities ||
                    this.Capabilities.SequenceEqual(input.Capabilities)
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.RemediatingActions == input.RemediatingActions ||
                    this.RemediatingActions != null &&
                    input.RemediatingActions != null &&
                    this.RemediatingActions.SequenceEqual(input.RemediatingActions)
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
                hashCode = (hashCode * 59) + this.Capabilities.GetHashCode();
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.RemediatingActions != null)
                {
                    hashCode = (hashCode * 59) + this.RemediatingActions.GetHashCode();
                }
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
            yield break;
        }
    }

}
