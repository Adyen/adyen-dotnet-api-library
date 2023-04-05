namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class BatchRequest
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransactionToPerform", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TransactionToPerform[] TransactionToPerform;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public bool? RemoveAllFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? RemoveAllFlagSpecified;
    }
}