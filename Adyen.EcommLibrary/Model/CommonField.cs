using System.Runtime.Serialization;

namespace Adyen.EcommLibrary.Model
{
    [DataContract]
    public class CommonField
    {
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string Version { get; set; }

    }
}