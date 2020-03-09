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

using Adyen.Constants;
using System.Collections.Generic;
using System.Text;
using Adyen.Util;

namespace Adyen.Model.Hpp
{
    public class PaymentMethod
    {
        public string BrandCode { get; set; }
        public string Name { get; set; }
        public List<Issuer> Issuers { get; set; }

        private readonly List<string> _cards = new List<string>{
            BrandCodes.Mastercard,
            BrandCodes.VisaDankort,
            BrandCodes.Visa,
            BrandCodes.Amex,
            BrandCodes.Vias,
            BrandCodes.Diners,
            BrandCodes.MaestroUk,
            BrandCodes.Solo,
            BrandCodes.Laser,
            BrandCodes.Discover,
            BrandCodes.Jcb,
            BrandCodes.Bcmc,
            BrandCodes.Bijcard,
            BrandCodes.Dankort,
            BrandCodes.Hipercard,
            BrandCodes.Maestro,
            BrandCodes.Elo,
            BrandCodes.Uatp,
            BrandCodes.ChinaUnionPay,
            BrandCodes.Cartebancaire,
            BrandCodes.VisaAlphabankBonus,
            BrandCodes.McAlphabankBonus,
            BrandCodes.Karenmillen,
            BrandCodes.Oasis,
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
            sb.Append("    brandCode: ").AppendLine(this.BrandCode.ToIndentedString());
            sb.Append("    name: ").AppendLine(this.Name.ToIndentedString());
            sb.Append("    issuers: ").AppendLine(this.Issuers.ToIndentedString());
            sb.Append("}");
            return sb.ToString();
        }
    }
}
