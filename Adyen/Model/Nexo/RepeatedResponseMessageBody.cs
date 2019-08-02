﻿using Adyen.CloudApiSerialization;

namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class RepeatedResponseMessageBody : IMessagePayload
    {
        [System.Xml.Serialization.XmlElementAttribute("CardAcquisitionResponse", typeof(CardAcquisitionResponse), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("CardReaderAPDUResponse", typeof(CardReaderAPDUResponse), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("LoyaltyResponse", typeof(LoyaltyResponse), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PaymentResponse", typeof(PaymentResponse), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("ReversalResponse", typeof(ReversalResponse), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("StoredValueResponse", typeof(StoredValueResponse), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public dynamic MessagePayload;
    }
}