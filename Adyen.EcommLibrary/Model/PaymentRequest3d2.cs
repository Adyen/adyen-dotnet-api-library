using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;
using Adyen.EcommLibrary.Model.Checkout;
using Adyen.EcommLibrary.Model.Enum;
using Adyen.EcommLibrary.Util;

namespace Adyen.EcommLibrary.Model
{
    [DataContract]
    public class PaymentRequestThreeDSecure2 : PaymentRequest
    {
        [DataMember(Name = "threeDS2RequestData", EmitDefaultValue = false)]
        public ThreeDSecure2RequestData ThreeDSecure2RequestData { get; set; }

        [DataMember(Name = "threeDS2Token", EmitDefaultValue = false)]
        public string ThreeDSecure2Token { get; set; }

        [DataMember(Name="deviceFingerprint", EmitDefaultValue = false)]
        public string DeviceFingerPrint { get; set; }

        [DataMember(Name="threeDS2Result", EmitDefaultValue = false)]
        public ThreeDSecure2Result ThreeDSecure2Result { get; set; }

        public override string ToString()
        {
            return this.ToClassDefinitionString();
        }
    }

}
