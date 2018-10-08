namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CardReaderInitRequest
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ForceEntryMode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] ForceEntryMode;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DisplayOutput DisplayOutput;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool WarmResetFlag;

      

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool LeaveCardFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string MaxWaitingTime;

        public CardReaderInitRequest()
        {
            this.LeaveCardFlag = true;
        }
    }
}