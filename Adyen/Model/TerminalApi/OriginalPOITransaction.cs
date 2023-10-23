﻿namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class OriginalPOITransaction
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TransactionIdentification POITransactionID;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ApprovalCode;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TransactionIdentification HostTransactionID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string SaleID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string POIID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool? ReuseCardDataFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string CustomerLanguage;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string AcquirerID;

        public OriginalPOITransaction()
        {
            ReuseCardDataFlag = true;
        }
    }
}