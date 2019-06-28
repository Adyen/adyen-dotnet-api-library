using Adyen.Model.Enum;
using Adyen.Util;
using System.Runtime.Serialization;

namespace Adyen.Model
{
    [DataContract]
    public partial class ThreeDS2Result
    {
        /// <summary>
        /// The value for the 3D Secure 2.0 authentication session. The returned value is a Base64-encoded 20-byte array.
        /// </summary>
        [DataMember(Name = "authenticationValue", EmitDefaultValue = false)]
        public string AuthenticationValue { get; set; }

        /// <summary>
        /// The Electronic Commerce Indicator returned from the schemes for the 3D Secure 2.0 payment session.
        /// </summary>
        [DataMember(Name = "eci", EmitDefaultValue = false)]
        public string ECI { get; set; }

        /// <summary>
        /// The unique identifier assigned to the transaction by the 3D Secure 2.0 Server.
        /// </summary>
        [DataMember(Name = "threeDSServerTransID", EmitDefaultValue = false)]
        public string ThreeDSServerTransID { get; set; }

        /// <summary>
        /// The date and time of the cardholder authentication, in UTC
        /// </summary>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public string TimeStamp { get; set; }

        /// <summary>
        /// Indicates whether a transaction was authenticated, or whether additional verification is required.
        /// </summary>
        /// <value>Indicates whether a transaction was authenticated, or whether additional verification is required.</value>
        [DataMember(Name = "transStatus")]
        public ThreeDSecure2TransactionResultStatus TransactionStatus { get; set; }

        /// <summary>
        /// Provides information on why the transStatus field has the specified value.
        /// </summary>
        [DataMember(Name = "transStatusReason", EmitDefaultValue = false)]
        public string TransStatusReason { get; set; }

        public override string ToString()
        {
            return this.ToClassDefinitionString();
        }
    }
}
