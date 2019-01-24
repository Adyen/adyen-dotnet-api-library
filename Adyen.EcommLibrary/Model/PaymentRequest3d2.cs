using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;
using Adyen.EcommLibrary.Model.Enum;

namespace Adyen.EcommLibrary.Model
{
    [DataContract]
    public class PaymentRequestThreeDSecure2 : PaymentRequest
    {
        [DataMember(Name = "threeDS2RequestData", EmitDefaultValue = false)]
        public ThreeDSecure2Data ThreeDSecure2Data { get; set; }

        [DataMember(Name = "threeDS2Token", EmitDefaultValue = false)]
        public string ThreeDSecure2Token { get; set; }

        [DataMember(Name="deviceFingerprint", EmitDefaultValue = false)]
        public string DeviceFingerPrint { get; set; }

        [DataMember(Name="threeDS2Result", EmitDefaultValue = false)]
        public ThreeDSecure2Result ThreeDSecure2Result { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentRequestThreeDSecure2 {\n");
            sb.Append(base.ToString());
            sb.Append("    ThreeDSecure2Data: ").Append(ToIndentedString(ThreeDSecure2Data)).Append("\n");
            sb.Append("}");
            return sb.ToString();
        }

        private string ToIndentedString(Object o)
        {
            if (o == null)
            {
                return "null";
            }
            return o.ToString().Replace("\n", "\n    ");
        }

    }

}
