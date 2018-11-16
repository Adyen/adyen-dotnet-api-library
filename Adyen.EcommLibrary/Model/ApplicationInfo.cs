using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Adyen.EcommLibrary.Model
{
    [DataContract]
    public class ApplicationInfo
    {
        [DataMember(Name = "adyenLibrary", EmitDefaultValue = false)]

        public CommonField AdyenLibrary { get; private set; }

        public ApplicationInfo(CommonField adyenLibrary)
        {
            AdyenLibrary = adyenLibrary;
        }
    }
}
