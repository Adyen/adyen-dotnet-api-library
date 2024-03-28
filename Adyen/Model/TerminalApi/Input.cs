namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class Input
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool? ConfirmedFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? ConfirmedFlagSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FunctionKey;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TextInput;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DigitInput;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Password;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MenuEntryNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int[] MenuEntryNumber;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public InputCommandType InputCommand;
    }
}
