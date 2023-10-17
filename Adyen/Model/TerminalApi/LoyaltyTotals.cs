﻿namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class LoyaltyTotals
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public TransactionType TransactionType;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public int? TransactionCount;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public decimal? TransactionAmount;
    }
}