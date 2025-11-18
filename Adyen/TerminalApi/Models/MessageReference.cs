namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class MessageReference
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public MessageCategoryType MessageCategory;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? MessageCategorySpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string ServiceID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string DeviceID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string SaleID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string POIID;
    }
}