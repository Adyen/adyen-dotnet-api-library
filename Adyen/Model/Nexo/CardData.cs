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
    public partial class CardData
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ContentInformation ProtectedCardData;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SensitiveCardData SensitiveCardData;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowedProductCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] AllowedProductCode;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowedProduct", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AllowedProduct[] AllowedProduct;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PaymentToken PaymentToken;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CustomerOrder", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CustomerOrder[] CustomerOrder;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PaymentBrand;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MaskedPAN;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PaymentAccountRef;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public EntryModeType[] EntryMode;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CardCountryCode;
    }
}