using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Adyen.EcommLibrary.Model.Enum;

namespace Adyen.EcommLibrary.Model
{
    /// <summary>
    /// ThreeDSecureData
    /// </summary>
    [DataContract]
    public partial class ThreeDSecureData : IEquatable<ThreeDSecureData>, IValidatableObject
    {
        /// <summary>
        /// The authentication response if the shopper was redirected.
        /// </summary>
        /// <value>The authentication response if the shopper was redirected.</value>
        [DataMember(Name = "authenticationResponse", EmitDefaultValue = false)]
        public AuthenticationResponseEnum? AuthenticationResponse { get; set; }

        /// <summary>
        /// The enrollment response from the 3D directory server.
        /// </summary>
        /// <value>The enrollment response from the 3D directory server.</value>
        [DataMember(Name = "directoryResponse", EmitDefaultValue = false)]
        public DirectoryResponseEnum? DirectoryResponse { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDSecureData" /> class.
        /// </summary>
        /// <param name="Cavv">The cardholder authentication value (base64 encoded, 20 bytes in a decoded form)..</param>
        /// <param name="AuthenticationResponse">The authentication response if the shopper was redirected..</param>
        /// <param name="Xid">The transaction identifier (base64 encoded, 20 bytes in a decoded form)..</param>
        /// <param name="CavvAlgorithm">The CAVV algorithm used..</param>
        /// <param name="DirectoryResponse">The enrollment response from the 3D directory server..</param>
        /// <param name="Eci">The electronic commerce indicator..</param>
        public ThreeDSecureData(byte[] Cavv = default(byte[]),
            AuthenticationResponseEnum? AuthenticationResponse = default(AuthenticationResponseEnum?),
            byte[] Xid = default(byte[]), string CavvAlgorithm = default(string),
            DirectoryResponseEnum? DirectoryResponse = default(DirectoryResponseEnum?), string Eci = default(string))
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
            return Equals(obj as ThreeDSecureData);
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
                    Cavv == other.Cavv ||
                    Cavv != null &&
                    Cavv.Equals(other.Cavv)
                ) &&
                (
                    AuthenticationResponse == other.AuthenticationResponse ||
                    AuthenticationResponse != null &&
                    AuthenticationResponse.Equals(other.AuthenticationResponse)
                ) &&
                (
                    Xid == other.Xid ||
                    Xid != null &&
                    Xid.Equals(other.Xid)
                ) &&
                (
                    CavvAlgorithm == other.CavvAlgorithm ||
                    CavvAlgorithm != null &&
                    CavvAlgorithm.Equals(other.CavvAlgorithm)
                ) &&
                (
                    DirectoryResponse == other.DirectoryResponse ||
                    DirectoryResponse != null &&
                    DirectoryResponse.Equals(other.DirectoryResponse)
                ) &&
                (
                    Eci == other.Eci ||
                    Eci != null &&
                    Eci.Equals(other.Eci)
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
                var hash = 41;
                // Suitable nullity checks etc, of course :)
                if (Cavv != null)
                    hash = hash * 59 + Cavv.GetHashCode();
                if (AuthenticationResponse != null)
                    hash = hash * 59 + AuthenticationResponse.GetHashCode();
                if (Xid != null)
                    hash = hash * 59 + Xid.GetHashCode();
                if (CavvAlgorithm != null)
                    hash = hash * 59 + CavvAlgorithm.GetHashCode();
                if (DirectoryResponse != null)
                    hash = hash * 59 + DirectoryResponse.GetHashCode();
                if (Eci != null)
                    hash = hash * 59 + Eci.GetHashCode();
                return hash;
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