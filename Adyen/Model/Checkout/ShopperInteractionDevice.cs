#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// ShopperInteractionDevice
    /// </summary>
    [DataContract]
    public partial class ShopperInteractionDevice :  IEquatable<ShopperInteractionDevice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopperInteractionDevice" /> class.
        /// </summary>
        /// <param name="Locale">Locale on the shopper interaction device..</param>
        /// <param name="Os">Operating system running on the shopper interaction device..</param>
        /// <param name="OsVersion">Version of the operating system on the shopper interaction device..</param>
        public ShopperInteractionDevice(string Locale = default(string), string Os = default(string), string OsVersion = default(string))
        {
            this.Locale = Locale;
            this.Os = Os;
            this.OsVersion = OsVersion;
        }
        
        /// <summary>
        /// Locale on the shopper interaction device.
        /// </summary>
        /// <value>Locale on the shopper interaction device.</value>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; set; }

        /// <summary>
        /// Operating system running on the shopper interaction device.
        /// </summary>
        /// <value>Operating system running on the shopper interaction device.</value>
        [DataMember(Name="os", EmitDefaultValue=false)]
        public string Os { get; set; }

        /// <summary>
        /// Version of the operating system on the shopper interaction device.
        /// </summary>
        /// <value>Version of the operating system on the shopper interaction device.</value>
        [DataMember(Name="osVersion", EmitDefaultValue=false)]
        public string OsVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
                return false;

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
                    hashCode = hashCode * 59 + this.Locale.GetHashCode();
                if (this.Os != null)
                    hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.OsVersion != null)
                    hashCode = hashCode * 59 + this.OsVersion.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
