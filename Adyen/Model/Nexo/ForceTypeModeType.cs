namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    public enum ForceEntryModeType
    {
        //Payment instrument information are taken from RFID
        /// <remarks/>
        RFID,
        //Manual key entry
        /// <remarks/>
        Keyed,
        //Reading of embossing or OCR of printed data either at time of transaction or after the event.
        /// <remarks/>
        Manual,
        //Account data on file
        /// <remarks/>
        File,
        //Scanned by a bar code reader.
        /// <remarks/>
        Scanned,
        //Magnetic stripe
        /// <remarks/>
        MagStripe,
        //Contact ICC (asynchronous)
        /// <remarks/>
        ICC,
        //Contact ICC (synchronous)
        /// <remarks/>
        SynchronousICC,
        //Contactless card reader Magnetic Stripe
        /// <remarks/>
        Tapped,
        //Contactless card reader conform to ISO 14443        
        /// <remarks/>
        Contactless,
    }
}
