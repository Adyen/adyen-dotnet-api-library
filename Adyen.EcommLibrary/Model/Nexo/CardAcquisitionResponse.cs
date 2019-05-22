using Adyen.EcommLibrary.CloudApiSerialization;

namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CardAcquisitionResponse : IMessagePayload
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
        [System.Xml.Serialization.XmlElementAttribute("PaymentBrand", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] PaymentBrand;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PaymentInstrumentData PaymentInstrumentData;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LoyaltyAccount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoyaltyAccount[] LoyaltyAccount;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CustomerOrder", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CustomerOrder[] CustomerOrder;
    }
}