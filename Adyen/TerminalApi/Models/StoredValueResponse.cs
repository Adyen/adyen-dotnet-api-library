using Adyen.ApiSerialization;

namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class StoredValueResponse : IMessagePayload
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Response Response;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SaleData SaleData;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public POIData POIData;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StoredValueResult", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public StoredValueResult[] StoredValueResult;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentReceipt", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PaymentReceipt[] PaymentReceipt;
    }
}
