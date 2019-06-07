namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class StoredValueAccountID
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public StoredValueAccountType StoredValueAccount;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StoredValueProvider;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OwnerName;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ExpiryDate;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public EntryModeType[] EntryMode;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public IdentificationType Identification;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }
}