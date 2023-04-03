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
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    public enum EventToNotifyType
    {

        /// <remarks/>
        BeginMaintenance,

        /// <remarks/>
        EndMaintenance,

        /// <remarks/>
        Shutdown,

        /// <remarks/>
        Initialised,

        /// <remarks/>
        OutOfOrder,

        /// <remarks/>
        Completed,

        /// <remarks/>
        Abort,

        /// <remarks/>
        SaleWakeUp,

        /// <remarks/>
        SaleAdmin,

        /// <remarks/>
        CustomerLanguage,

        /// <remarks/>
        KeyPressed,

        /// <remarks/>
        SecurityAlarm,

        /// <remarks/>
        StopAssistance,

        /// <remarks/>
        CardInserted,

        /// <remarks/>
        CardRemoved,

        /// <remarks/>
        Reject,
    }
}