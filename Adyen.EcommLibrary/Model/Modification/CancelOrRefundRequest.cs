using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.EcommLibrary.Model.Modification
{
    public class CancelOrRefundRequest : AbstractModificationRequest
    {
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CancelOrRefundRequest {\n");
            sb.Append(base.ToString());
            sb.Append("}");
            return sb.ToString();
        }
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
