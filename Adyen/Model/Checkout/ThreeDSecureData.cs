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
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// ThreeDSecureData
    /// </summary>
    [DataContract]
    public partial class ThreeDSecureData : IEquatable<ThreeDSecureData>, IValidatableObject
    {
        /// <summary>
        /// In 3D Secure 1, the authentication response if the shopper was redirected.  In 3D Secure 2, this is the &#x60;transStatus&#x60; from the challenge result. If the transaction was frictionless, omit this parameter.
        /// </summary>
        /// <value>In 3D Secure 1, the authentication response if the shopper was redirected.  In 3D Secure 2, this is the &#x60;transStatus&#x60; from the challenge result. If the transaction was frictionless, omit this parameter.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthenticationResponseEnum
        {
            /// <summary>
            /// Enum Y for value: Y
            /// </summary>
            [EnumMember(Value = "Y")] Y = 1,

            /// <summary>
            /// Enum N for value: N
            /// </summary>
            [EnumMember(Value = "N")] N = 2,

            /// <summary>
            /// Enum U for value: U
            /// </summary>
            [EnumMember(Value = "U")] U = 3,

            /// <summary>
            /// Enum A for value: A
            /// </summary>
            [EnumMember(Value = "A")] A = 4
        }

        /// <summary>
        /// In 3D Secure 1, the authentication response if the shopper was redirected.  In 3D Secure 2, this is the &#x60;transStatus&#x60; from the challenge result. If the transaction was frictionless, omit this parameter.
        /// </summary>
        /// <value>In 3D Secure 1, the authentication response if the shopper was redirected.  In 3D Secure 2, this is the &#x60;transStatus&#x60; from the challenge result. If the transaction was frictionless, omit this parameter.</value>
        [DataMember(Name = "authenticationResponse", EmitDefaultValue = false)]
        public AuthenticationResponseEnum? AuthenticationResponse { get; set; }

        /// <summary>
        /// In 3D Secure 1, this is the enrollment response from the 3D directory server.  In 3D Secure 2, this is the &#x60;transStatus&#x60; from the &#x60;ARes&#x60;.
        /// </summary>
        /// <value>In 3D Secure 1, this is the enrollment response from the 3D directory server.  In 3D Secure 2, this is the &#x60;transStatus&#x60; from the &#x60;ARes&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectoryResponseEnum
        {
            /// <summary>
            /// Enum A for value: A
            /// </summary>
            [EnumMember(Value = "A")] A = 1,

            /// <summary>
            /// Enum C for value: C
            /// </summary>
            [EnumMember(Value = "C")] C = 2,

            /// <summary>
            /// Enum D for value: D
            /// </summary>
            [EnumMember(Value = "D")] D = 3,

            /// <summary>
            /// Enum I for value: I
            /// </summary>
            [EnumMember(Value = "I")] I = 4,

            /// <summary>
            /// Enum N for value: N
            /// </summary>
            [EnumMember(Value = "N")] N = 5,

            /// <summary>
            /// Enum R for value: R
            /// </summary>
            [EnumMember(Value = "R")] R = 6,

            /// <summary>
            /// Enum U for value: U
            /// </summary>
            [EnumMember(Value = "U")] U = 7,

            /// <summary>
            /// Enum Y for value: Y
            /// </summary>
            [EnumMember(Value = "Y")] Y = 8
        }

        /// <summary>
        /// In 3D Secure 1, this is the enrollment response from the 3D directory server.  In 3D Secure 2, this is the &#x60;transStatus&#x60; from the &#x60;ARes&#x60;.
        /// </summary>
        /// <value>In 3D Secure 1, this is the enrollment response from the 3D directory server.  In 3D Secure 2, this is the &#x60;transStatus&#x60; from the &#x60;ARes&#x60;.</value>
        [DataMember(Name = "directoryResponse", EmitDefaultValue = false)]
        public DirectoryResponseEnum? DirectoryResponse { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDSecureData" /> class.
        /// </summary>
        /// <param name="authenticationResponse">In 3D Secure 1, the authentication response if the shopper was redirected.  In 3D Secure 2, this is the &#x60;transStatus&#x60; from the challenge result. If the transaction was frictionless, omit this parameter..</param>
        /// <param name="cavv">The cardholder authentication value (base64 encoded, 20 bytes in a decoded form)..</param>
        /// <param name="cavvAlgorithm">The CAVV algorithm used. Include this only for 3D Secure 1..</param>
        /// <param name="directoryResponse">In 3D Secure 1, this is the enrollment response from the 3D directory server.  In 3D Secure 2, this is the &#x60;transStatus&#x60; from the &#x60;ARes&#x60;..</param>
        /// <param name="dsTransID">Supported for 3D Secure 2. The unique transaction identifier assigned by the Directory Server (DS) to identify a single transaction..</param>
        /// <param name="eci">The electronic commerce indicator..</param>
        /// <param name="threeDSVersion">The version of the 3D Secure protocol..</param>
        /// <param name="xid">Supported for 3D Secure 1. The transaction identifier (Base64-encoded, 20 bytes in a decoded form)..</param>
        public ThreeDSecureData(
            AuthenticationResponseEnum? authenticationResponse = default(AuthenticationResponseEnum?),
            byte[] cavv = default(byte[]), string cavvAlgorithm = default(string),
            DirectoryResponseEnum? directoryResponse = default(DirectoryResponseEnum?),
            string dsTransID = default(string), string eci = default(string), string threeDSVersion = default(string),
            byte[] xid = default(byte[]))
        {
            this.AuthenticationResponse = authenticationResponse;
            this.Cavv = cavv;
            this.CavvAlgorithm = cavvAlgorithm;
            this.DirectoryResponse = directoryResponse;
            this.DsTransID = dsTransID;
            this.Eci = eci;
            this.ThreeDSVersion = threeDSVersion;
            this.Xid = xid;
        }


        /// <summary>
        /// The cardholder authentication value (base64 encoded, 20 bytes in a decoded form).
        /// </summary>
        /// <value>The cardholder authentication value (base64 encoded, 20 bytes in a decoded form).</value>
        [DataMember(Name = "cavv", EmitDefaultValue = false)]
        public byte[] Cavv { get; set; }

        /// <summary>
        /// The CAVV algorithm used. Include this only for 3D Secure 1.
        /// </summary>
        /// <value>The CAVV algorithm used. Include this only for 3D Secure 1.</value>
        [DataMember(Name = "cavvAlgorithm", EmitDefaultValue = false)]
        public string CavvAlgorithm { get; set; }


        /// <summary>
        /// Supported for 3D Secure 2. The unique transaction identifier assigned by the Directory Server (DS) to identify a single transaction.
        /// </summary>
        /// <value>Supported for 3D Secure 2. The unique transaction identifier assigned by the Directory Server (DS) to identify a single transaction.</value>
        [DataMember(Name = "dsTransID", EmitDefaultValue = false)]
        public string DsTransID { get; set; }

        /// <summary>
        /// The electronic commerce indicator.
        /// </summary>
        /// <value>The electronic commerce indicator.</value>
        [DataMember(Name = "eci", EmitDefaultValue = false)]
        public string Eci { get; set; }

        /// <summary>
        /// The version of the 3D Secure protocol.
        /// </summary>
        /// <value>The version of the 3D Secure protocol.</value>
        [DataMember(Name = "threeDSVersion", EmitDefaultValue = false)]
        public string ThreeDSVersion { get; set; }

        /// <summary>
        /// Supported for 3D Secure 1. The transaction identifier (Base64-encoded, 20 bytes in a decoded form).
        /// </summary>
        /// <value>Supported for 3D Secure 1. The transaction identifier (Base64-encoded, 20 bytes in a decoded form).</value>
        [DataMember(Name = "xid", EmitDefaultValue = false)]
        public byte[] Xid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThreeDSecureData {\n");
            sb.Append("  AuthenticationResponse: ").Append(AuthenticationResponse).Append("\n");
            sb.Append("  Cavv: ").Append(Cavv).Append("\n");
            sb.Append("  CavvAlgorithm: ").Append(CavvAlgorithm).Append("\n");
            sb.Append("  DirectoryResponse: ").Append(DirectoryResponse).Append("\n");
            sb.Append("  DsTransID: ").Append(DsTransID).Append("\n");
            sb.Append("  Eci: ").Append(Eci).Append("\n");
            sb.Append("  ThreeDSVersion: ").Append(ThreeDSVersion).Append("\n");
            sb.Append("  Xid: ").Append(Xid).Append("\n");
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
            return this.Equals(input as ThreeDSecureData);
        }

        /// <summary>
        /// Returns true if ThreeDSecureData instances are equal
        /// </summary>
        /// <param name="input">Instance of ThreeDSecureData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThreeDSecureData input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AuthenticationResponse == input.AuthenticationResponse ||
                    this.AuthenticationResponse != null &&
                    this.AuthenticationResponse.Equals(input.AuthenticationResponse)
                ) &&
                (
                    this.Cavv == input.Cavv ||
                    this.Cavv != null &&
                    this.Cavv.Equals(input.Cavv)
                ) &&
                (
                    this.CavvAlgorithm == input.CavvAlgorithm ||
                    this.CavvAlgorithm != null &&
                    this.CavvAlgorithm.Equals(input.CavvAlgorithm)
                ) &&
                (
                    this.DirectoryResponse == input.DirectoryResponse ||
                    this.DirectoryResponse != null &&
                    this.DirectoryResponse.Equals(input.DirectoryResponse)
                ) &&
                (
                    this.DsTransID == input.DsTransID ||
                    this.DsTransID != null &&
                    this.DsTransID.Equals(input.DsTransID)
                ) &&
                (
                    this.Eci == input.Eci ||
                    this.Eci != null &&
                    this.Eci.Equals(input.Eci)
                ) &&
                (
                    this.ThreeDSVersion == input.ThreeDSVersion ||
                    this.ThreeDSVersion != null &&
                    this.ThreeDSVersion.Equals(input.ThreeDSVersion)
                ) &&
                (
                    this.Xid == input.Xid ||
                    this.Xid != null &&
                    this.Xid.Equals(input.Xid)
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
                if (this.AuthenticationResponse != null)
                    hashCode = hashCode * 59 + this.AuthenticationResponse.GetHashCode();
                if (this.Cavv != null)
                    hashCode = hashCode * 59 + this.Cavv.GetHashCode();
                if (this.CavvAlgorithm != null)
                    hashCode = hashCode * 59 + this.CavvAlgorithm.GetHashCode();
                if (this.DirectoryResponse != null)
                    hashCode = hashCode * 59 + this.DirectoryResponse.GetHashCode();
                if (this.DsTransID != null)
                    hashCode = hashCode * 59 + this.DsTransID.GetHashCode();
                if (this.Eci != null)
                    hashCode = hashCode * 59 + this.Eci.GetHashCode();
                if (this.ThreeDSVersion != null)
                    hashCode = hashCode * 59 + this.ThreeDSVersion.GetHashCode();
                if (this.Xid != null)
                    hashCode = hashCode * 59 + this.Xid.GetHashCode();
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