﻿namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CashHandlingDevice
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CoinsOrBills", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CoinsOrBills[] CoinsOrBills;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool? CashHandlingOKFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency;
    }
}