namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class CardReaderInitRequest
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public ForceEntryModeType[] ForceEntryMode;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DisplayOutput DisplayOutput;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public bool? WarmResetFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? WarmResetFlagSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool? LeaveCardFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public int? MaxWaitingTime;
    }
}