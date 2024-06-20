/*
* Adyen Payment API
*
*
* The version of the OpenAPI document: 68
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.Payment
{
    /// <summary>
    /// ShopperInteractionDevice
    /// </summary>
    [DataContract(Name = "ShopperInteractionDevice")]
    public partial class ShopperInteractionDevice : IEquatable<ShopperInteractionDevice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopperInteractionDevice" /> class.
        /// </summary>
        /// <param name="locale">Locale on the shopper interaction device..</param>
        /// <param name="os">Operating system running on the shopper interaction device..</param>
        /// <param name="osVersion">Version of the operating system on the shopper interaction device..</param>
        public ShopperInteractionDevice(string locale = default(string), string os = default(string), string osVersion = default(string))
        {
            this.Locale = locale;
            this.Os = os;
            this.OsVersion = osVersion;
        }

        /// <summary>
        /// Locale on the shopper interaction device.
        /// </summary>
        /// <value>Locale on the shopper interaction device.</value>
        [DataMember(Name = "locale", EmitDefaultValue = false)]
        public string Locale { get; set; }

        /// <summary>
        /// Operating system running on the shopper interaction device.
        /// </summary>
        /// <value>Operating system running on the shopper interaction device.</value>
        [DataMember(Name = "os", EmitDefaultValue = false)]
        public string Os { get; set; }

        /// <summary>
        /// Version of the operating system on the shopper interaction device.
        /// </summary>
        /// <value>Version of the operating system on the shopper interaction device.</value>
        [DataMember(Name = "osVersion", EmitDefaultValue = false)]
        public string OsVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShopperInteractionDevice {\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  Os: ").Append(Os).Append("\n");
            sb.Append("  OsVersion: ").Append(OsVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }
    
        /// <summary>
        /// Returns the ShopperInteractionDevice object from the json payload
        /// </summary>
        /// <returns>ShopperInteractionDevice</returns>
        public static ShopperInteractionDevice FromJson(string json)
        {
            return JsonConvert.DeserializeObject<ShopperInteractionDevice>(json);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShopperInteractionDevice);
        }

        /// <summary>
        /// Returns true if ShopperInteractionDevice instances are equal
        /// </summary>
        /// <param name="input">Instance of ShopperInteractionDevice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShopperInteractionDevice input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
                ) && 
                (
                    this.Os == input.Os ||
                    (this.Os != null &&
                    this.Os.Equals(input.Os))
                ) && 
                (
                    this.OsVersion == input.OsVersion ||
                    (this.OsVersion != null &&
                    this.OsVersion.Equals(input.OsVersion))
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
                if (this.Locale != null)
                {
                    hashCode = (hashCode * 59) + this.Locale.GetHashCode();
                }
                if (this.Os != null)
                {
                    hashCode = (hashCode * 59) + this.Os.GetHashCode();
                }
                if (this.OsVersion != null)
                {
                    hashCode = (hashCode * 59) + this.OsVersion.GetHashCode();
                }
                return hashCode;
            }
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
