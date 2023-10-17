﻿namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class PaymentToken
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public TokenRequestedType TokenRequestedType;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string TokenValue;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public System.DateTime ExpiryDateTime;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? ExpiryDateTimeSpecified;
    }
}