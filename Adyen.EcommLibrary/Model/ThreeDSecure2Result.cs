using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Adyen.EcommLibrary.Model.Enum;
using Adyen.EcommLibrary.Util;

namespace Adyen.EcommLibrary.Model
{
    [DataContract]
    public partial class ThreeDSecure2Result
    {
        [DataMember(Name = "transStatus")]
        public ThreeDSecure2TransactionResultStatus TransactionStatus { get; set; }

        public override string ToString()
        {
            return this.ToClassDefinitionString();
        }
    }
}
