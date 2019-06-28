namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoginRequest
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime DateTime;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SaleSoftware SaleSoftware;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SaleTerminalData SaleTerminalData;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool TrainingModeFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OperatorLanguage;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OperatorID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ShiftNumber;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TokenRequested;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] CustomerOrderReq;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string POISerialNumber;

        public LoginRequest()
        {
            this.TrainingModeFlag = false;
        }
    }
}