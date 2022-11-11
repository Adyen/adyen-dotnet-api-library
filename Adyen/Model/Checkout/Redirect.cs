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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Adyen.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// Redirect
    /// </summary>
    [DataContract]
    public partial class Redirect : IEquatable<Redirect>, IValidatableObject
    {
        /// <summary>
        /// The web method that you must use to access the redirect URL.  Possible values: GET, POST.
        /// </summary>
        /// <value>The web method that you must use to access the redirect URL.  Possible values: GET, POST.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MethodEnum
        {
            /// <summary>
            /// Enum GET for value: GET
            /// </summary>
            [EnumMember(Value = "GET")] GET = 1,

            /// <summary>
            /// Enum POST for value: POST
            /// </summary>
            [EnumMember(Value = "POST")] POST = 2
        }

        /// <summary>
        /// The web method that you must use to access the redirect URL.  Possible values: GET, POST.
        /// </summary>
        /// <value>The web method that you must use to access the redirect URL.  Possible values: GET, POST.</value>
        [DataMember(Name = "method", EmitDefaultValue = false)]
        public MethodEnum? Method { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Redirect" /> class.
        /// </summary>
        /// <param name="data">When the redirect URL must be accessed via POST, use this data to post to the redirect URL..</param>
        /// <param name="method">The web method that you must use to access the redirect URL.  Possible values: GET, POST..</param>
        /// <param name="url">The URL, to which you must redirect a shopper to complete a payment..</param>
        public Redirect(Dictionary<string, string> data = default(Dictionary<string, string>),
            MethodEnum? method = default(MethodEnum?), string url = default(string))
        {
            this.Data = data;
            this.Method = method;
            this.Url = url;
        }

        /// <summary>
        /// When the redirect URL must be accessed via POST, use this data to post to the redirect URL.
        /// </summary>
        /// <value>When the redirect URL must be accessed via POST, use this data to post to the redirect URL.</value>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public Dictionary<string, string> Data { get; set; }


        /// <summary>
        /// The URL, to which you must redirect a shopper to complete a payment.
        /// </summary>
        /// <value>The URL, to which you must redirect a shopper to complete a payment.</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Redirect {\n");
            sb.Append("  Data: ").Append(Data.ToCollectionsString()).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as Redirect);
        }

        /// <summary>
        /// Returns true if Redirect instances are equal
        /// </summary>
        /// <param name="input">Instance of Redirect to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Redirect input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) &&
                (
                    this.Method == input.Method ||
                    this.Method != null &&
                    this.Method.Equals(input.Method)
                ) &&
                (
                    this.Url == input.Url ||
                    this.Url != null &&
                    this.Url.Equals(input.Url)
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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