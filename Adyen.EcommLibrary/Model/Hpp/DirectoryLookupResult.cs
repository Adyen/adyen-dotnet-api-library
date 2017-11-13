using System.Collections.Generic;
using System.Text;

namespace Adyen.EcommLibrary.Model.Hpp
{
    public class DirectoryLookupResult
    {
        public List<PaymentMethod> PaymentMethods { get;set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DirectoryLookupResult {\n");
            sb.Append("    paymentMethods: ").Append(Util.Util.ToIndentedString(this.PaymentMethods)).Append("\n");
            sb.Append("}");
            return sb.ToString();
        }
    }
}
