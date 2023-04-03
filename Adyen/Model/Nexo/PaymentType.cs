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
    public enum PaymentType
    {

        /// <remarks/>
        Normal,

        /// <remarks/>
        Refund,

        /// <remarks/>
        OneTimeReservation,

        /// <remarks/>
        FirstReservation,

        /// <remarks/>
        UpdateReservation,

        /// <remarks/>
        Completion,

        /// <remarks/>
        CashAdvance,

        /// <remarks/>
        CashDeposit,

        /// <remarks/>
        Recurring,

        /// <remarks/>
        Instalment,

        /// <remarks/>
        IssuerInstalment,

        /// <remarks/>
        PaidOut,
    }
}