using Adyen.EcommLibrary.Model.AdditionalData;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Adyen.EcommLibrary.Model.ApplicationInformation;
using Adyen.EcommLibrary.Util;

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

        public PaymentRequest()
        {
            if (ApplicationInfo == null)
                ApplicationInfo = new ApplicationInfo();
        }

        public Dictionary<string, string> GetOrCreateAdditionalData()
        {
            return AdditionalData ?? (AdditionalData = new Dictionary<string, string>());
        }

        public PaymentRequest InvoiceLines(List<InvoiceLine> invoiceLines)
        {
            var count = 1;
            foreach (var invoiceLine in invoiceLines)
            {
                var sb = new StringBuilder();
                sb.Append("openinvoicedata.line");
                sb.Append(count.ToString());
                var lineNumber = sb.ToString();
                GetOrCreateAdditionalData()
                    .Add(new StringBuilder().Append(lineNumber).Append(".currencyCode").ToString(),
                        invoiceLine.CurrencyCode);
                GetOrCreateAdditionalData()
                    .Add(new StringBuilder().Append(lineNumber).Append(".description").ToString(),
                        invoiceLine.Description);
                GetOrCreateAdditionalData().Add(new StringBuilder().Append(lineNumber).Append(".itemAmount").ToString(),
                    invoiceLine.ItemAmount.ToString());
                GetOrCreateAdditionalData()
                    .Add(new StringBuilder().Append(lineNumber).Append(".itemVatAmount").ToString(),
                        invoiceLine.VatAmount.ToString());
                GetOrCreateAdditionalData()
                    .Add(new StringBuilder().Append(lineNumber).Append(".itemVatPercentage").ToString(),
                        invoiceLine.ItemVatPercentage.ToString());
                GetOrCreateAdditionalData()
                    .Add(new StringBuilder().Append(lineNumber).Append(".numberOfItems").ToString(),
                        invoiceLine.NumberOfItems.ToString());
                GetOrCreateAdditionalData()
                    .Add(new StringBuilder().Append(lineNumber).Append(".vatCategory").ToString(),
                        invoiceLine.VatCategory.ToString());

                // Addional field only for RatePay
                if (invoiceLine.ItemId != null)
                    GetOrCreateAdditionalData().Add(new StringBuilder().Append(lineNumber).Append(".itemId").ToString(),
                        invoiceLine.ItemId);
                count++;
            }

            GetOrCreateAdditionalData().Add("openinvoicedata.numberOfLines", invoiceLines.Count.ToString());
            return this;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentRequest {\n");

            sb.Append(base.ToString());
            sb.Append("    card: ").Append(Card.ToIndentedString()).Append("\n");
            sb.Append("    mpiData: ").Append(MpiData.ToIndentedString()).Append("\n");
            sb.Append("    bankAccount: ").Append(BankAccount.ToIndentedString()).Append("\n");
            sb.Append("}");
            return sb.ToString();
        }
    }
}