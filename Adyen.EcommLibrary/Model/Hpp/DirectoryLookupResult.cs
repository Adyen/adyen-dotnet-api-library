using System.Collections.Generic;
using System.Text;
using Adyen.EcommLibrary.Util;

namespace Adyen.EcommLibrary.Model.Hpp
{
    public class DirectoryLookupResult
    {
        public List<PaymentMethod> PaymentMethods { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("class DirectoryLookupResult {");
            sb.Append("    paymentMethods: ").AppendLine(PaymentMethods.ToIndentedString());
            sb.AppendLine("}");
            return sb.ToString();
        }
    }
}