using System.Runtime.Serialization;
using Adyen.EcommLibrary.Model.Checkout;
using Adyen.EcommLibrary.Util;

namespace Adyen.EcommLibrary.Model
{
    [DataContract]
    public class PaymentRequestThreeDS2 : PaymentRequest
    {
        [DataMember(Name = "threeDS2RequestData", EmitDefaultValue = false)]
        public ThreeDS2RequestData ThreeDS2RequestData { get; set; }

        [DataMember(Name = "threeDS2Token", EmitDefaultValue = false)]
        public string ThreeDS2Token { get; set; }

        [DataMember(Name = "deviceFingerprint", EmitDefaultValue = false)]
        public string DeviceFingerPrint { get; set; }

        [DataMember(Name = "threeDS2Result", EmitDefaultValue = false)]
        public ThreeDS2Result ThreeDS2Result { get; set; }

        public override string ToString()
        {
            return this.ToClassDefinitionString();
        }
    }
}