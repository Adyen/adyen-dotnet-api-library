namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class LoyaltyAccountID
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public EntryModeType[] EntryMode;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public IdentificationType IdentificationType;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public IdentificationSupportType IdentificationSupport;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? IdentificationSupportSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute]
        public string Value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute]
        public string LoyaltyID;
    }
}