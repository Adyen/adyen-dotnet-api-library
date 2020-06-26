using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.Model.PosTerminalManagement
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class GetTerminalDetailsResponse : Dictionary<string, object>
    {
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"class {nameof(GetTerminalDetailsResponse)} {{\n");

            foreach (var kvp in this)
            {
              sb.Append($"  {kvp.Key}: {kvp.Value}\n");
            }

            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
