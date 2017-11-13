using Adyen.EcommLibrary.Constants;
using System.Collections.Generic;
using System.Text;

namespace Adyen.EcommLibrary.Model.Hpp
{
    public class PaymentMethod
    {
        public string BrandCode { get; set; }
        public string Name { get; set; }
        public List<Issuer> Issuers { get; set; }

        private readonly List<string> _cards = new List<string>{
           BrandCodes.Paypal    ,
           BrandCodes.PaypalEcs ,
           BrandCodes.Klarna    ,
           BrandCodes.Afterpay  ,
           BrandCodes.SepaDirectDebit,
           BrandCodes.Ideal ,
           BrandCodes.ChinaUnionPay,
           BrandCodes.Cartebancaire,
           BrandCodes.Visa ,
           BrandCodes.Mastercard,
           BrandCodes.Uatp ,
           BrandCodes.Amex,
           BrandCodes.Maestro ,
           BrandCodes.MaestroUk ,
           BrandCodes.Diners,
           BrandCodes.Discover ,
           BrandCodes.VisaDankort,
           BrandCodes.Jcb ,
           BrandCodes.Laser,
           BrandCodes.Vias ,
           BrandCodes.Solo ,
           BrandCodes.Bcmc ,
           BrandCodes.Bijcard ,
           BrandCodes.Dankort,
           BrandCodes.Hipercard ,
           BrandCodes.Elo ,
           BrandCodes.VisaAlphabankBonus,
           BrandCodes.McAlphabankBonus,
           BrandCodes.Karenmillen,
           BrandCodes.Oasis ,
           BrandCodes.Warehouse
        };
        
        public bool IsCard()
        {
            return _cards.Contains(GetBrandCode());
        }

        public string GetBrandCode()
        {
            return BrandCode;
        }

        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentMethod {\n");
            sb.Append("    brandCode: ").Append(Util.Util.ToIndentedString(this.BrandCode)).Append("\n");
            sb.Append("    name: ").Append(Util.Util.ToIndentedString(this.Name)).Append("\n");
            sb.Append("    issuers: ").Append(Util.Util.ToIndentedString(this.Issuers)).Append("\n");
            sb.Append("}");
            return sb.ToString();
        }
    }
}
