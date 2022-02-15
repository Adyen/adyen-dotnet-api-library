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

using Adyen.Model.Enum;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.Model
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
        [DataMember(Name = "authenticationResponse", EmitDefaultValue = false)]
        public ThreeDSecureTransactionStatusEnum? AuthenticationResponse { get; set; }

        /// <summary>
        /// In 3D Secure 1, this is the enrollment response from the 3D directory server.  In 3D Secure 2, this is the &#x60;transStatus&#x60; from the &#x60;ARes&#x60;.
        /// </summary>
        /// <value>In 3D Secure 1, this is the enrollment response from the 3D directory server.  In 3D Secure 2, this is the &#x60;transStatus&#x60; from the &#x60;ARes&#x60;.</value>
        [DataMember(Name = "directoryResponse", EmitDefaultValue = false)]
        public ThreeDSecureTransactionStatusEnum? DirectoryResponse { get; set; }

        /// <summary>
        /// The cardholder authentication value (base64 encoded, 20 bytes in a decoded form).
        /// </summary>
        /// <value>The cardholder authentication value (base64 encoded, 20 bytes in a decoded form).</value>
        [DataMember(Name = "cavv", EmitDefaultValue = false)]
        public byte[] Cavv { get; set; }

        /// <summary>
        /// The transaction identifier (base64 encoded, 20 bytes in a decoded form).
        /// </summary>
        /// <value>The transaction identifier (base64 encoded, 20 bytes in a decoded form).</value>
        [DataMember(Name = "xid", EmitDefaultValue = false)]
        public byte[] Xid { get; set; }

        /// <summary>
        /// The CAVV algorithm used.
        /// </summary>
        /// <value>The CAVV algorithm used.</value>
        [DataMember(Name = "cavvAlgorithm", EmitDefaultValue = false)]
        public string CavvAlgorithm { get; set; }

        /// <summary>
        /// The electronic commerce indicator.
        /// </summary>
        /// <value>The electronic commerce indicator.</value>
        [DataMember(Name = "eci", EmitDefaultValue = false)]
        public string Eci { get; set; }

        /// <summary>
        /// Supported for 3D Secure 2. The unique transaction identifier assigned by the Directory Server (DS) to identify a single transaction.
        /// </summary>
        /// <value>Supported for 3D Secure 2. The unique transaction identifier assigned by the Directory Server (DS) to identify a single transaction.</value>
        [DataMember(Name = "dsTransID", EmitDefaultValue = false)]
        public string DsTransID { get; set; }

        /// <summary>
        /// The version of the 3D Secure protocol.
        /// </summary>
        /// <value>The version of the 3D Secure protocol.</value>
        [DataMember(Name = "threeDSVersion", EmitDefaultValue = false)]
        public string ThreeDSVersion { get; set; }

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
            byte[] cavv = default(byte[]),
            string cavvAlgorithm = default(string),
            ThreeDSecureTransactionStatusEnum? authenticationResponse = default(ThreeDSecureTransactionStatusEnum?),
            byte[] xid = default(byte[]),
            ThreeDSecureTransactionStatusEnum? directoryResponse = default(ThreeDSecureTransactionStatusEnum?),
            string dsTransID = default(string),
            string eci = default(string),
            string threeDSVersion = default(string))
        {
            this.Cavv = cavv;
            this.CavvAlgorithm = cavvAlgorithm;
            this.AuthenticationResponse = authenticationResponse;
            this.Xid = xid;
            this.DirectoryResponse = directoryResponse;
            this.DsTransID = dsTransID;
            this.Eci = eci;
            this.ThreeDSVersion = threeDSVersion;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThreeDSecureData {\n");
            sb.Append("  Cavv: ").Append(Cavv).Append("\n");
            sb.Append("  AuthenticationResponse: ").Append(AuthenticationResponse).Append("\n");
            sb.Append("  Xid: ").Append(Xid).Append("\n");
            sb.Append("  CavvAlgorithm: ").Append(CavvAlgorithm).Append("\n");
            sb.Append("  DirectoryResponse: ").Append(DirectoryResponse).Append("\n");
            sb.Append("  Eci: ").Append(Eci).Append("\n");
            sb.Append("  DsTransID: ").Append(DsTransID).Append("\n");
            sb.Append("  ThreeDSVersion: ").Append(ThreeDSVersion).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ThreeDSecureData);
        }

        /// <summary>
        /// Returns true if ThreeDSecureData instances are equal
        /// </summary>
        /// <param name="other">Instance of ThreeDSecureData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThreeDSecureData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Cavv == other.Cavv ||
                    this.Cavv != null &&
                    this.Cavv.Equals(other.Cavv)
                ) &&
                (
                    this.AuthenticationResponse == other.AuthenticationResponse ||
                    this.AuthenticationResponse != null &&
                    this.AuthenticationResponse.Equals(other.AuthenticationResponse)
                ) &&
                (
                    this.Xid == other.Xid ||
                    this.Xid != null &&
                    this.Xid.Equals(other.Xid)
                ) &&
                (
                    this.CavvAlgorithm == other.CavvAlgorithm ||
                    this.CavvAlgorithm != null &&
                    this.CavvAlgorithm.Equals(other.CavvAlgorithm)
                ) &&
                (
                    this.DirectoryResponse == other.DirectoryResponse ||
                    this.DirectoryResponse != null &&
                    this.DirectoryResponse.Equals(other.DirectoryResponse)
                ) &&
                (
                    this.Eci == other.Eci ||
                    this.Eci != null &&
                    this.Eci.Equals(other.Eci)
                ) &&
                (
                    this.DsTransID == other.DsTransID ||
                    this.DsTransID != null &&
                    this.DsTransID.Equals(other.DsTransID)
                ) &&
                (
                    this.ThreeDSVersion == other.ThreeDSVersion ||
                    this.ThreeDSVersion != null &&
                    this.ThreeDSVersion.Equals(other.ThreeDSVersion)
                )
                ;
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Cavv != null)
                    hash = hash * 59 + this.Cavv.GetHashCode();
                if (this.AuthenticationResponse != null)
                    hash = hash * 59 + this.AuthenticationResponse.GetHashCode();
                if (this.Xid != null)
                    hash = hash * 59 + this.Xid.GetHashCode();
                if (this.CavvAlgorithm != null)
                    hash = hash * 59 + this.CavvAlgorithm.GetHashCode();
                if (this.DirectoryResponse != null)
                    hash = hash * 59 + this.DirectoryResponse.GetHashCode();
                if (this.Eci != null)
                    hash = hash * 59 + this.Eci.GetHashCode();
                if (this.DsTransID != null)
                    hash = hash * 59 + this.DsTransID.GetHashCode();
                if (this.ThreeDSVersion != null)
                    hash = hash * 59 + this.ThreeDSVersion.GetHashCode();
                return hash;
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
