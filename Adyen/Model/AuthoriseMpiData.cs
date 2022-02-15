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
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Adyen.Model.Enum;

namespace Adyen.Model
{
    /// <summary>
    /// AuthoriseMpiData
    /// </summary>
    [DataContract]
    public partial class AuthoriseMpiData :  IEquatable<AuthoriseMpiData>, IValidatableObject
    {
        /// <summary>
        /// The authentication response if the shopper was redirected.
        /// </summary>
        /// <value>The authentication response if the shopper was redirected.</value>
        [DataMember(Name="authenticationResponse", EmitDefaultValue=false)]
        public ThreeDSecureTransactionStatusEnum? AuthenticationResponse { get; set; }
        /// <summary>
        /// The enrollment response from the 3D directory server.
        /// </summary>
        /// <value>The enrollment response from the 3D directory server.</value>
        [DataMember(Name="directoryResponse", EmitDefaultValue=false)]
        public ThreeDSecureTransactionStatusEnum? DirectoryResponse { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthoriseMpiData" /> class.
        /// </summary>
        /// <param name="Cavv">The cardholder authentication value (base64 encoded, 20 bytes in a decoded form)..</param>
        /// <param name="AuthenticationResponse">The authentication response if the shopper was redirected..</param>
        /// <param name="Xid">The transaction identifier (base64 encoded, 20 bytes in a decoded form)..</param>
        /// <param name="CavvAlgorithm">The CAVV algorithm used..</param>
        /// <param name="DirectoryResponse">The enrollment response from the 3D directory server..</param>
        /// <param name="Eci">The electronic commerce indicator..</param>
        public AuthoriseMpiData(
            byte[] Cavv = default(byte[]), 
            ThreeDSecureTransactionStatusEnum? AuthenticationResponse = default(ThreeDSecureTransactionStatusEnum?), 
            byte[] Xid = default(byte[]), 
            string CavvAlgorithm = default(string), 
            ThreeDSecureTransactionStatusEnum? DirectoryResponse = default(ThreeDSecureTransactionStatusEnum?), 
            string Eci = default(string))
        {
            this.Cavv = Cavv;
            this.AuthenticationResponse = AuthenticationResponse;
            this.Xid = Xid;
            this.CavvAlgorithm = CavvAlgorithm;
            this.DirectoryResponse = DirectoryResponse;
            this.Eci = Eci;
        }
        
        /// <summary>
        /// The cardholder authentication value (base64 encoded, 20 bytes in a decoded form).
        /// </summary>
        /// <value>The cardholder authentication value (base64 encoded, 20 bytes in a decoded form).</value>
        [DataMember(Name="cavv", EmitDefaultValue=false)]
        public byte[] Cavv { get; set; }


        /// <summary>
        /// The transaction identifier (base64 encoded, 20 bytes in a decoded form).
        /// </summary>
        /// <value>The transaction identifier (base64 encoded, 20 bytes in a decoded form).</value>
        [DataMember(Name="xid", EmitDefaultValue=false)]
        public byte[] Xid { get; set; }

        /// <summary>
        /// The CAVV algorithm used.
        /// </summary>
        /// <value>The CAVV algorithm used.</value>
        [DataMember(Name="cavvAlgorithm", EmitDefaultValue=false)]
        public string CavvAlgorithm { get; set; }


        /// <summary>
        /// The electronic commerce indicator.
        /// </summary>
        /// <value>The electronic commerce indicator.</value>
        [DataMember(Name="eci", EmitDefaultValue=false)]
        public string Eci { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthoriseMpiData {\n");
            sb.Append("  Cavv: ").Append(Cavv).Append("\n");
            sb.Append("  AuthenticationResponse: ").Append(AuthenticationResponse).Append("\n");
            sb.Append("  Xid: ").Append(Xid).Append("\n");
            sb.Append("  CavvAlgorithm: ").Append(CavvAlgorithm).Append("\n");
            sb.Append("  DirectoryResponse: ").Append(DirectoryResponse).Append("\n");
            sb.Append("  Eci: ").Append(Eci).Append("\n");
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
            return this.Equals(obj as AuthoriseMpiData);
        }

        /// <summary>
        /// Returns true if AuthoriseMpiData instances are equal
        /// </summary>
        /// <param name="other">Instance of AuthoriseMpiData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthoriseMpiData other)
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
                );
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
