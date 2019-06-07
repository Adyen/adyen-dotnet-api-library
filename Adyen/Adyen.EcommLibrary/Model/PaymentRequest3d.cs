using System;
using System.Runtime.Serialization;
using System.Text;
using Adyen.EcommLibrary.Constants;
using Adyen.EcommLibrary.Model.ApplicationInformation;
using Adyen.EcommLibrary.Util;

namespace Adyen.EcommLibrary.Model
{
    [DataContract]
    public class PaymentRequest3D : AbstractPaymentRequest
    {
        [DataMember(Name = "md", EmitDefaultValue = false)]
        public string Md { get; set; }
        [DataMember(Name = "paResponse", EmitDefaultValue = false)]
        public string PaResponse { get; set; }

        public PaymentRequest3D()
        {
             if(ApplicationInfo==null)
                ApplicationInfo = new ApplicationInfo();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentRequest {\n");

            sb.Append(base.ToString());
            sb.Append("    md: ").Append(Md.ToIndentedString()).Append("\n");
            sb.Append("    paResponse: ").Append(PaResponse.ToIndentedString()).Append("\n");
            sb.Append("}");
            return sb.ToString();
        }
     
    }
}
