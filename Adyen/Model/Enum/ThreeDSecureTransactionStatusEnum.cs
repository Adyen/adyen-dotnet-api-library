using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Adyen.Model.Enum
{
    /// <summary>
    /// transStatus codes as defined in the EMVCo specification for 2.1.0 (page 197) and 2.2.0 (page 216)
    /// https://www.emvco.com/emv-technologies/3d-secure/
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ThreeDSecureTransactionStatusEnum
    {
        /// <summary>
        /// Attempts Processing Performed; Not Authenticated/Verified, but a proof of attempted authentication/verification is provided.
        /// 2.1.0, 2.2.0
        /// </summary>
        [EnumMember(Value = "A")] A = 1,

        /// <summary>
        /// Challenge Required; Additional authentication is required using the CReq/CRes.
        /// 2.1.0, 2.2.0
        /// </summary>
        [EnumMember(Value = "C")] C = 2,

        /// <summary>
        /// Challenge Required; Decoupled Authentication confirmed.
        /// 2.1.0, 2.2.0
        /// </summary>
        [EnumMember(Value = "D")] D = 3,

        /// <summary>
        /// Informational Only; 3DS Requestor challenge preference acknowledged.
        /// 2.2.0 only
        /// </summary>
        [EnumMember(Value = "I")] I = 4,

        /// <summary>
        /// Not Authenticated /Account Not Verified; Transaction denied.
        /// 2.1.0, 2.2.0
        /// </summary>
        [EnumMember(Value = "N")] N = 5,

        /// <summary>
        /// Authentication/ Account Verification Rejected; Issuer is rejecting authentication/verification and request that authorisation not be attempted.
        /// 2.2.0 only
        /// </summary>
        [EnumMember(Value = "R")] R = 6,

        /// <summary>
        /// Authentication/ Account Verification Could Not Be Performed; Technical or other problem, as indicated in ARes or RReq
        /// 2.1.0, 2.2.0
        /// </summary>
        [EnumMember(Value = "U")] U = 7,

        /// <summary>
        /// Authentication Verification Successful.
        /// 2.1.0, 2.2.0
        /// </summary>
        [EnumMember(Value = "Y")] Y = 8,

        /// <summary>
        /// Adyen internal only! Error
        /// </summary>
        [EnumMember(Value = "E")] E
    }
}
