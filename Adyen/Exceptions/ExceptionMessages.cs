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

using System;
using System.Collections.Generic;
using System.Text;

namespace Adyen.Exceptions
{
    internal class ExceptionMessages
    {
        internal const string SaleToPoiMessageRootMissing = "SaleToPOIMessage missing root";
        internal const string ExceptionDuringNotification = "Notifications are not yet supported";
        internal const string InvalidMessageType = "Invalid Message Type for the message: {0}";
        internal const string TerminalErrorResponse = "Terminal Error Response: {0}";
        internal const string ExceptionDuringDeserialization = "Exception during deserialization of object: {0}, Exception Message: {1}";
        internal const string MissingLiveEndpointUrlPrefix = "Missing liveEndpointUrlPrefix for endpoint generation";
    }
}
