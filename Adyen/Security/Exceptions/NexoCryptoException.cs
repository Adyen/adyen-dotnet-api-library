#region License
 /*
  *                       ######
  *                       ######
  * ############    ####( ######  #####. ######  ############   ############
  * #############  #####( ######  #####. ######  #############  #############
  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
  * ###### ######  #####( ######  #####. ######  #####          #####  ######
  * #############  #############  #############  #############  #####  ######
  *  ############   ############  #############   ############  #####  ######
  *                                      ######
  *                               #############
  *                               ############
  *
  * Adyen Dotnet API Library
  *
  * Copyright (c) 2021 Adyen B.V.
  * This file is open source and available under the MIT license.
  * See the LICENSE file for more info.
  */
#endregion

using System;

namespace Adyen.Security.Exceptions
{
    public class NexoCryptoException : Exception
    {
        public NexoCryptoException(string message) : base(message)
        {
        }
    }
}
