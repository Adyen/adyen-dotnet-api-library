namespace Adyen.EcommLibrary.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PaymentTotals
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TransactionType Transaction;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public int TransactionCount;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TransactionAmount;
    }
}