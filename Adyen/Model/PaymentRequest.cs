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

using Adyen.Model.AdditionalData;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Adyen.Model.ApplicationInformation;
using Adyen.Util;
using Adyen.Model.Enum;

namespace Adyen.Model
{
    [DataContract]
    public class PaymentRequest : AbstractPaymentRequest
    {
        /// <summary>
        /// Defines a recurring payment type. Allowed values: Subscription – A transaction for a fixed or variable amount, which follows a fixed schedule. CardOnFile – Card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction. UnscheduledCardOnFile – Transaction that occurs on a non-fixed schedule using stored card details. For example, automatic top-ups when the cardholder's balance drops below certain amount.
        /// </summary>
        [DataMember(Name = "recurringProcessingModel", EmitDefaultValue = false)]
        public RecurringProcessingModelEnum? RecurringProcessingModel { get; set; }

        [DataMember(Name = "card", EmitDefaultValue = false)]
        public Card Card { get; set; }
        [DataMember(Name = "mpiData", EmitDefaultValue = false)]
        public ThreeDSecureData MpiData { get; set; }
        [DataMember(Name = "bankAccount", EmitDefaultValue = false)]
        public BankAccount BankAccount { get; set; }

        public PaymentRequest()
        {
            if(ApplicationInfo==null)
                ApplicationInfo = new ApplicationInfo();
        }
        public Dictionary<string, string> GetOrCreateAdditionalData()
        {
            return this.AdditionalData ?? (this.AdditionalData = new Dictionary<string, string>());
        }

        public PaymentRequest InvoiceLines(List<InvoiceLine> invoiceLines)
        {
            int count = 1;
            foreach (var invoiceLine in invoiceLines)
            {

                StringBuilder sb = new StringBuilder();
                sb.Append("openinvoicedata.line");
                sb.Append(count.ToString());
                string lineNumber = sb.ToString();
                this.GetOrCreateAdditionalData().Add(new StringBuilder().Append(lineNumber).Append(".currencyCode").ToString(), invoiceLine.CurrencyCode);
                this.GetOrCreateAdditionalData().Add(new StringBuilder().Append(lineNumber).Append(".description").ToString(), invoiceLine.Description);
                this.GetOrCreateAdditionalData().Add(new StringBuilder().Append(lineNumber).Append(".itemAmount").ToString(), invoiceLine.ItemAmount.ToString());
                this.GetOrCreateAdditionalData().Add(new StringBuilder().Append(lineNumber).Append(".itemVatAmount").ToString(), invoiceLine.VatAmount.ToString());
                this.GetOrCreateAdditionalData().Add(new StringBuilder().Append(lineNumber).Append(".itemVatPercentage").ToString(), invoiceLine.ItemVatPercentage.ToString());
                this.GetOrCreateAdditionalData().Add(new StringBuilder().Append(lineNumber).Append(".numberOfItems").ToString(), invoiceLine.NumberOfItems.ToString());
                this.GetOrCreateAdditionalData().Add(new StringBuilder().Append(lineNumber).Append(".vatCategory").ToString(), invoiceLine.VatCategory.ToString());

                // Addional field only for RatePay
                if (invoiceLine.ItemId != null)
                {
                    this.GetOrCreateAdditionalData().Add(new StringBuilder().Append(lineNumber).Append(".itemId").ToString(), invoiceLine.ItemId);
                }
                count++;
            }
            this.GetOrCreateAdditionalData().Add("openinvoicedata.numberOfLines", (invoiceLines.Count.ToString()));
            return this;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentRequest {\n");
            sb.Append(base.ToString());
            sb.Append("    card: ").Append(Card.ToIndentedString()).Append("\n");
            sb.Append("    mpiData: ").Append(MpiData.ToIndentedString()).Append("\n");
            sb.Append("    bankAccount: ").Append(BankAccount.ToIndentedString()).Append("\n");
            sb.Append("    recurringProcessingModel: ").Append(RecurringProcessingModel.ToIndentedString()).Append("\n");

            sb.Append("}");
            return sb.ToString();
        }
    }
}
