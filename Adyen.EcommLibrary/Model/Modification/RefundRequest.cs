using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Adyen.EcommLibrary.Constants;
using Adyen.EcommLibrary.Model.ApplicationInfo;
using Newtonsoft.Json;

namespace Adyen.EcommLibrary.Model.Modification
{
    [DataContract]
    public class RefundRequest : AbstractModificationRequest
    {
        [DataMember(Name = "modificationAmount", EmitDefaultValue = false)]
        public Amount ModificationAmount { get; set; }

        public RefundRequest()
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
            sb.Append("class RefundRequest {\n");
            sb.Append(base.ToString());
            sb.Append("  modificationAmount.Currency: ").Append(ModificationAmount.Currency).Append("\n");
            sb.Append("  modificationAmount.Value: ").Append(ModificationAmount.Value).Append("\n");

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
