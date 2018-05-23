using Adyen.EcommLibrary.Model.Enum;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Adyen.EcommLibrary.Model.Nexo.Message
{
    ///<usage>
    ///It conveys Information related to the Sale to POI protocol management
    ///</usage>
    ///<definition>
    ///Message header of the Sale to POI protocol message.
    ///</definition>
    public class MessageHeader:IMessagePayload
    {
        public string ProtocolVersion { get; set; }
       // [Required]
        //public MessageClass? MessageClass { get; set; }
        //[Required]
        //public MessageCategory? MessageCategory { get; set; }
        [Required]
        public MessageType? MessageType { get; set; }
        [StringLength(10, MinimumLength = 1)]
        public string ServiceID { get; set; }
        [StringLength(10, MinimumLength = 1)]
        public string DeviceID { get; set; }
        [Required]
        public string SaleID { get; set; }
        [Required]
        public string POIID { get; set; }

        [Required]
        public MessageClass? MessageClass { get; set; }
        [Required]
        public MessageCategory? MessageCategory { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new StringEnumConverter());
        }
    }
}
