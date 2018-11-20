using System;
using System.Runtime.Serialization;
using System.Text;
using Adyen.EcommLibrary.Constants;

namespace Adyen.EcommLibrary.Model
{
    [DataContract]
    public class PaymentRequest3D : AbstractPaymentRequest
    {
        [DataMember(Name = "md", EmitDefaultValue = false)]
        public string Md { get; set; }

        [DataMember(Name = "paResponse", EmitDefaultValue = false)]
        public string PaResponse { get; set; }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentRequest {\n");

            sb.Append(base.ToString());
            sb.Append("    md: ").Append(ToIndentedString(Md)).Append("\n");
            sb.Append("    paResponse: ").Append(ToIndentedString(PaResponse)).Append("\n");
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
