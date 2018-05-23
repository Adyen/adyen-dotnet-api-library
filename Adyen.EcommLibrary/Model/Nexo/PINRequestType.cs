namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PINRequestType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CardholderPINType CardholderPIN;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("PINRequestType")]
        public string PINRequestType1;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PINVerifMethod;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AdditionalInput;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PINEncAlgorithm;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PINFormat;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string KeyReference;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MaxWaitingTime;
    }
}