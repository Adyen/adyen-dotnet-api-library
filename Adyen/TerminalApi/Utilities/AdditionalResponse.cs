using System.Collections.Generic;

namespace Adyen.Util.TerminalApi
{

    public class AdditionalResponse
    {
        public Dictionary<string, string> AdditionalData { get; set; }
        public string Message { get; set; }
        public string Store { get; set; }
    }
}