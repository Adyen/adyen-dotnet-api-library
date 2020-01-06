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

using Adyen.Exceptions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Adyen.CloudApiSerialization
{
    internal class JSonConvertDeserializerWrapper<T>
    {
        internal static T DeserializeObject(string objectToDeserialize)
        {
            return JsonConvert.DeserializeObject<T>(objectToDeserialize, new JsonSerializerSettings
            {
                MissingMemberHandling = MissingMemberHandling.Error,
                Error = delegate (object sender, ErrorEventArgs args)
                {
                    var exceptionMessage = string.Format(ExceptionMessages.ExceptionDuringDeserialization,
                        objectToDeserialize,
                        args.ErrorContext.Error.Message);

                    throw new DeserializationException(exceptionMessage, args.ErrorContext.Error);
                }
            });
        }
    }
}
