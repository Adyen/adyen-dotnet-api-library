namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InputData
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DefaultInputString;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string StringMask;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Device;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InfoQualify;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InputCommand;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()] [System.ComponentModel.DefaultValueAttribute(false)]
        public bool NotifyCardInputFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string MaxInputTime;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()] [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ImmediateResponseFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string MinLength;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string MaxLength;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string MaxDecimalLength;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()] [System.ComponentModel.DefaultValueAttribute(true)]
        public bool WaitUserValidationFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()] [System.ComponentModel.DefaultValueAttribute(false)]
        public bool FromRightToLeftFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()] [System.ComponentModel.DefaultValueAttribute(false)]
        public bool MaskCharactersFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()] [System.ComponentModel.DefaultValueAttribute(false)]
        public bool BeepKeyFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()] [System.ComponentModel.DefaultValueAttribute(false)]
        public bool GlobalCorrectionFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()] [System.ComponentModel.DefaultValueAttribute(false)]
        public bool DisableCancelFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()] [System.ComponentModel.DefaultValueAttribute(false)]
        public bool DisableCorrectFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()] [System.ComponentModel.DefaultValueAttribute(false)]
        public bool DisableValidFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()] [System.ComponentModel.DefaultValueAttribute(false)]
        public bool MenuBackFlag;

        public InputData()
        {
            NotifyCardInputFlag = false;
            ImmediateResponseFlag = false;
            WaitUserValidationFlag = true;
            FromRightToLeftFlag = false;
            MaskCharactersFlag = false;
            BeepKeyFlag = false;
            GlobalCorrectionFlag = false;
            DisableCancelFlag = false;
            DisableCorrectFlag = false;
            DisableValidFlag = false;
            MenuBackFlag = false;
        }
    }
}