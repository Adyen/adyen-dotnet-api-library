using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Adyen.EcommLibrary.Model.Enum;

namespace Adyen.EcommLibrary.Model
{
    /// <summary>
    /// ThreeDSecureData
    /// </summary>
    [DataContract]
    public partial class ThreeDSecure2Data
    {
        /// <summary>
        /// Address Match Indicator.
        /// </summary>
        /// <value>Address Match Indicator.</value>
        [DataMember(Name = "addrMatch", EmitDefaultValue = false)]
        public string AddressMatch { get; set; }

        /// <summary>
        /// The device that the payment is being initiated from.
        /// </summary>
        /// <value>The device that the payment is being initiated from.</value>
        [DataMember(Name = "deviceChannel", EmitDefaultValue = false)]
        public DeviceChannelEnum? DeviceChannel { get; set; }

        /// <summary>
        /// The merchants name.
        /// </summary>
        /// <value>The merchants name.</value>
        [DataMember(Name = "merchantName", EmitDefaultValue = false)]
        public string MerchantName { get; set; }

        /// <summary>
        /// The URL the shopper is redirected to after the Challenge.
        /// </summary>
        /// <value>The URL the shopper is redirected to after the Challenge. This is the URL of your payment page.</value>
        [DataMember(Name = "notificationURL", EmitDefaultValue = false)]
        public string NotificationUrl { get; set; }

        /// <summary>
        /// Indicates whether device fingerprinting was successfully completed.
        /// </summary>
        /// <value>Indicates whether device fingerprinting was successfully completed.</value>
        [DataMember(Name = "threeDSCompInd")]
        public DeviceFingerprintCompletedEnum ThreeDSecureDeviceFingerprintCompleted { get; set; }

        /// <summary>
        /// The unique identifier for the 3D Secure 2.0 transaction.
        /// </summary>
        /// <value>The unique identifier for the 3D Secure 2.0 transaction.</value>
        [DataMember(Name = "threeDSServerTransID", EmitDefaultValue = false)]
        public string ThreeDSecureServerTransactionId { get; set; }
    }

}
