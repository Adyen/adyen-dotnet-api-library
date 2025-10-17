namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class SaleItemRebate
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitOfMeasureType UnitOfMeasure;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? UnitOfMeasureSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal? Quantity;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? QuantitySpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RebateLabel;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public int? ItemID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string ProductCode;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string EanUpc;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public decimal? ItemAmount;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? ItemAmountSpecified;
    }
}