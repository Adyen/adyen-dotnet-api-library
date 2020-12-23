#region Licence

// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2020 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

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
    /// WeChatPayDetails
    /// </summary>
    [DataContract]
    public partial class WeChatPayDetails : IEquatable<WeChatPayDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeChatPayDetails" /> class.
        /// </summary>
        /// <param name="appId">appId.</param>
        /// <param name="openid">openid.</param>
        /// <param name="type">**wechatpay** (default to &quot;wechatpay&quot;).</param>
        public WeChatPayDetails(string appId = default(string), string openid = default(string),
            string type = "wechatpay")
        {
            this.AppId = appId;
            this.Openid = openid;
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "wechatpay";
            }
            else
            {
                this.Type = type;
            }
        }

        /// <summary>
        /// Gets or Sets AppId
        /// </summary>
        [DataMember(Name = "appId", EmitDefaultValue = false)]
        public string AppId { get; set; }

        /// <summary>
        /// Gets or Sets Openid
        /// </summary>
        [DataMember(Name = "openid", EmitDefaultValue = false)]
        public string Openid { get; set; }

        /// <summary>
        /// **wechatpay**
        /// </summary>
        /// <value>**wechatpay**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WeChatPayDetails {\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  Openid: ").Append(Openid).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as WeChatPayDetails);
        }

        /// <summary>
        /// Returns true if WeChatPayDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of WeChatPayDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WeChatPayDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AppId == input.AppId ||
                    this.AppId != null &&
                    this.AppId.Equals(input.AppId)
                ) &&
                (
                    this.Openid == input.Openid ||
                    this.Openid != null &&
                    this.Openid.Equals(input.Openid)
                ) &&
                (
                    this.Type == input.Type ||
                    this.Type != null &&
                    this.Type.Equals(input.Type)
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
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.Openid != null)
                    hashCode = hashCode * 59 + this.Openid.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext)
        {
            yield break;
        }
    }
}