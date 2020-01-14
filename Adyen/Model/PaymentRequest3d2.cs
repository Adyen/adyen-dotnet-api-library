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
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;
using Adyen.Model.Checkout;
using Adyen.Model.Enum;
using Adyen.Util;

namespace Adyen.Model
{
    [DataContract]
    public class PaymentRequestThreeDS2 : PaymentRequest
    {
        [DataMember(Name = "threeDS2RequestData", EmitDefaultValue = false)]
        public ThreeDS2RequestData ThreeDS2RequestData { get; set; }

        [DataMember(Name = "threeDS2Token", EmitDefaultValue = false)]
        public string ThreeDS2Token { get; set; }

        [DataMember(Name="deviceFingerprint", EmitDefaultValue = false)]
        public string DeviceFingerPrint { get; set; }

        [DataMember(Name="threeDS2Result", EmitDefaultValue = false)]
        public ThreeDS2Result ThreeDS2Result { get; set; }

        public override string ToString()
        {
            return this.ToClassDefinitionString();
        }
    }

}
