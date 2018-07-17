using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Adyen.EcommLibrary.Model.Nexo.Message
{
    public class SaleToPoiMessage
    {
        [Required]
        public MessageHeader MessageHeader { get; set; }

        [Required]
        public Object MessagePayload { get; set; }
    }
}
