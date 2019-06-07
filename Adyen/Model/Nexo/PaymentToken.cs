namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PaymentToken
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TokenRequestedType TokenRequested;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TokenValue;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime ExpiryDateTime;

    }
}