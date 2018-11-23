using Adyen.EcommLibrary.Model.AdditionalData;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Adyen.EcommLibrary.Constants;

namespace Adyen.EcommLibrary.Model
{
    [DataContract]
    public class PaymentRequest : AbstractPaymentRequest
    {
        [DataMember(Name = "card", EmitDefaultValue = false)]
        public Card Card { get; set; }
        [DataMember(Name = "mpiData", EmitDefaultValue = false)]
        public ThreeDSecureData MpiData { get; set; }
        [DataMember(Name = "bankAccount", EmitDefaultValue = false)]
        public BankAccount BankAccount { get; set; }
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
            sb.Append("    card: ").Append(ToIndentedString(Card)).Append("\n");
            sb.Append("    mpiData: ").Append(ToIndentedString(MpiData)).Append("\n");
            sb.Append("    bankAccount: ").Append(ToIndentedString(BankAccount)).Append("\n");
            sb.Append("}");
            return sb.ToString();
        }
        private string ToIndentedString(Object o)
        {
            if (o == null)
            {
                return "null";
            }
            return o.ToString().Replace("\n", "\n    ");
        }
    }
}