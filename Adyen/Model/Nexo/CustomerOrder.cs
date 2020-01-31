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

namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CustomerOrder
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AdditionalInformation;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CustomerOrderID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool? OpenOrderState;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime StartDate;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime EndDate;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool? EndDateSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal? ForecastedAmount;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal? CurrentAmount;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AccessedBy;
    }
}