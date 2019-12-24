#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2019 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
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
