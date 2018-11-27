using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Adyen.EcommLibrary.Constants;
using Adyen.EcommLibrary.Model.ApplicationInfo;

namespace Adyen.EcommLibrary.Model.Modification
{
    public class CancelOrRefundRequest : AbstractModificationRequest
    {
        public CancelOrRefundRequest()
        {
            var commonField = new CommonField
            {
                Name = ClientConfig.LibName,
                Version = ClientConfig.LibVersion
            };
            ApplicationInfo = new ApplicationInfo.ApplicationInfo(commonField);
        }

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
