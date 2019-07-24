namespace Adyen.Model.Nexo
{
    public enum ForceEntryModeType
    {
        //Payment instrument information are taken from RFID
        RFID,
        //Manual key entry
        Keyed,
        //Reading of embossing or OCR of printed data either at time of transaction or after the event.
        Manual,
        //Account data on file
        File,
        //Scanned by a bar code reader.
        Scanned,
        //Magnetic stripe
        MagStripe,
        //Contact ICC (asynchronous)
        ICC,
        //Contact ICC (synchronous)
        SynchronousICC,
        //Contactless card reader Magnetic Stripe
        Tapped,
        //Contactless card reader conform to ISO 14443        
        Contactless,
    }
}
