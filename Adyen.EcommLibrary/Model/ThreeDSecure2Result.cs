using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Adyen.EcommLibrary.Model.Enum;

namespace Adyen.EcommLibrary.Model
{
    [DataContract]
    public partial class ThreeDSecure2Result
    {
        [DataMember(Name = "transStatus")]
        public ThreeDSecure2TransactionResultStatus TransactionStatus { get; set; }
    }
}
