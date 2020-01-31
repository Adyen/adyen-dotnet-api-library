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

using Adyen.Model.Enum;

namespace Adyen.Model.AdditionalData
{
    public class InvoiceLine
    {
        public long VatAmount { get; set; }
        public string CurrencyCode { get; set; }
        public string Description { get; set; }
        public long ItemAmount { get; set; }
        public long ItemVatAmount { get; set; }
        public long ItemVatPercentage { get; set; }
        public int NumberOfItems { get; set; }
        public VatCategory VatCategory { get; set; }
        public string ItemId { get; set; }
    }
}
