namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InstalmentType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InstalmentType", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string InstalmentType1;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string SequenceNumber;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PlanID;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Period;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PeriodUnit;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FirstPaymentDate;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string TotalNbOfPayments;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal CumulativeAmount;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CumulativeAmountSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal FirstAmount;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FirstAmountSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Charges;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChargesSpecified;
    }
}