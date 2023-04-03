using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Adyen.Constants;
using Newtonsoft.Json;

namespace Adyen.Model.ApplicationInformation
{
    /// <summary>
    /// ApplicationInfo
    /// </summary>
    [DataContract]
    public class ApplicationInfo : IEquatable<ApplicationInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInfo" /> class.
        /// </summary>
        public ApplicationInfo()
        {
            AdyenLibrary = new CommonField
            {
                Name = ClientConfig.LibName,
                Version = ClientConfig.LibVersion
            };
        }

        /// <summary>
        /// Gets or Sets AdyenLibrary
        /// </summary>
        [DataMember(Name = "adyenLibrary", EmitDefaultValue = false)]
        public CommonField AdyenLibrary { get; private set; }

        /// <summary>
        /// Gets or Sets AdyenPaymentSource
        /// </summary>
        [DataMember(Name = "adyenPaymentSource", EmitDefaultValue = false)]
        public CommonField AdyenPaymentSource { get; set; }

        /// <summary>
        /// Gets or Sets ExternalPlatform
        /// </summary>
        [DataMember(Name = "externalPlatform", EmitDefaultValue = false)]
        public ExternalPlatform ExternalPlatform { get; set; }

        /// <summary>
        /// Gets or Sets MerchantApplication
        /// </summary>
        [DataMember(Name = "merchantApplication", EmitDefaultValue = false)]
        public CommonField MerchantApplication { get; set; }

        /// <summary>
        /// Gets or Sets MerchantDevice
        /// </summary>
        [DataMember(Name = "merchantDevice", EmitDefaultValue = false)]
        public MerchantDevice MerchantDevice { get; set; }

        /// <summary>
        /// Gets or Sets ShopperInteractionDevice
        /// </summary>
        [DataMember(Name = "shopperInteractionDevice", EmitDefaultValue = false)]
        public ShopperInteractionDevice ShopperInteractionDevice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationInfo {\n");
            sb.Append("  AdyenLibrary: ").Append(AdyenLibrary).Append("\n");
            sb.Append("  AdyenPaymentSource: ").Append(AdyenPaymentSource).Append("\n");
            sb.Append("  ExternalPlatform: ").Append(ExternalPlatform).Append("\n");
            sb.Append("  MerchantApplication: ").Append(MerchantApplication).Append("\n");
            sb.Append("  MerchantDevice: ").Append(MerchantDevice).Append("\n");
            sb.Append("  ShopperInteractionDevice: ").Append(ShopperInteractionDevice).Append("\n");
            sb.Append("}\n");
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

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as ApplicationInfo);
        }

        /// <summary>
        /// Returns true if ApplicationInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationInfo input)
        {
            if (input == null)
                return false;

            return
                (
                    AdyenLibrary == input.AdyenLibrary ||
                    (AdyenLibrary != null &&
                    AdyenLibrary.Equals(input.AdyenLibrary))
                ) &&
                (
                    AdyenPaymentSource == input.AdyenPaymentSource ||
                    (AdyenPaymentSource != null &&
                    AdyenPaymentSource.Equals(input.AdyenPaymentSource))
                ) &&
                (
                    ExternalPlatform == input.ExternalPlatform ||
                    (ExternalPlatform != null &&
                    ExternalPlatform.Equals(input.ExternalPlatform))
                ) &&
                (
                    MerchantApplication == input.MerchantApplication ||
                    (MerchantApplication != null &&
                    MerchantApplication.Equals(input.MerchantApplication))
                ) &&
                (
                    MerchantDevice == input.MerchantDevice ||
                    (MerchantDevice != null &&
                    MerchantDevice.Equals(input.MerchantDevice))
                ) &&
                (
                    ShopperInteractionDevice == input.ShopperInteractionDevice ||
                    (ShopperInteractionDevice != null &&
                    ShopperInteractionDevice.Equals(input.ShopperInteractionDevice))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (AdyenLibrary != null)
                    hashCode = hashCode * 59 + AdyenLibrary.GetHashCode();
                if (AdyenPaymentSource != null)
                    hashCode = hashCode * 59 + AdyenPaymentSource.GetHashCode();
                if (ExternalPlatform != null)
                    hashCode = hashCode * 59 + ExternalPlatform.GetHashCode();
                if (MerchantApplication != null)
                    hashCode = hashCode * 59 + MerchantApplication.GetHashCode();
                if (MerchantDevice != null)
                    hashCode = hashCode * 59 + MerchantDevice.GetHashCode();
                if (ShopperInteractionDevice != null)
                    hashCode = hashCode * 59 + ShopperInteractionDevice.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
