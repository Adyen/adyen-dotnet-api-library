using Adyen.EcommLibrary.Model.AdditinalData;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.EcommLibrary.Model
{
    [DataContract]
    public class PaymentRequest:AbstractPaymentRequest
    {
        [DataMember(Name = "card", EmitDefaultValue = false)]
        public Card Card { get; set; }

        [DataMember(Name = "mpiData", EmitDefaultValue = false)]
        public ThreeDSecureData MpiData { get; set; }

        [DataMember(Name = "bankAccount", EmitDefaultValue = false)]
        public BankAccount BankAccount { get; set; }

        public List<InvoiceLine> InvoiceLines { get; set; }

       
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