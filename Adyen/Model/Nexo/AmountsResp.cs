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
//  * Copyright (c) 2019 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AmountsResp
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal? AuthorizedAmount;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal? TotalRebatesAmount;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool? TotalRebatesAmountSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal? TotalFeesAmount;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool? TotalFeesAmountSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal? CashBackAmount;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool? CashBackAmountSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal? TipAmount;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool? TipAmountSpecified;
    }
}