
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.EcommLibrary.Model.Checkout
{
    /// <summary>
    /// ThreeDSecureData
    /// </summary>
    [DataContract]
    public partial class ThreeDSecureData :  IEquatable<ThreeDSecureData>, IValidatableObject
    {
        /// <summary>
        /// The authentication response if the shopper was redirected.
        /// </summary>
        /// <value>The authentication response if the shopper was redirected.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthenticationResponseEnum
        {
            
            /// <summary>
            /// Enum Y for value: Y
            /// </summary>
            [EnumMember(Value = "Y")]
            Y = 1,
            
            /// <summary>
            /// Enum N for value: N
            /// </summary>
            [EnumMember(Value = "N")]
            N = 2,
            
            /// <summary>
            /// Enum U for value: U
            /// </summary>
            [EnumMember(Value = "U")]
            U = 3,
            
            /// <summary>
            /// Enum A for value: A
            /// </summary>
            [EnumMember(Value = "A")]
            A = 4
        }

        /// <summary>
        /// The authentication response if the shopper was redirected.
        /// </summary>
        /// <value>The authentication response if the shopper was redirected.</value>
        [DataMember(Name="authenticationResponse", EmitDefaultValue=false)]
        public AuthenticationResponseEnum? AuthenticationResponse { get; set; }
        /// <summary>
        /// The enrollment response from the 3D directory server.
        /// </summary>
        /// <value>The enrollment response from the 3D directory server.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectoryResponseEnum
        {
            
            /// <summary>
            /// Enum Y for value: Y
            /// </summary>
            [EnumMember(Value = "Y")]
            Y = 1,
            
            /// <summary>
            /// Enum N for value: N
            /// </summary>
            [EnumMember(Value = "N")]
            N = 2,
            
            /// <summary>
            /// Enum U for value: U
            /// </summary>
            [EnumMember(Value = "U")]
            U = 3,
            
            /// <summary>
            /// Enum E for value: E
            /// </summary>
            [EnumMember(Value = "E")]
            E = 4
        }

        /// <summary>
        /// The enrollment response from the 3D directory server.
        /// </summary>
        /// <value>The enrollment response from the 3D directory server.</value>
        [DataMember(Name="directoryResponse", EmitDefaultValue=false)]
        public DirectoryResponseEnum? DirectoryResponse { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDSecureData" /> class.
        /// </summary>
        /// <param name="AuthenticationResponse">The authentication response if the shopper was redirected..</param>
        /// <param name="Cavv">The cardholder authentication value (base64 encoded, 20 bytes in a decoded form)..</param>
        /// <param name="CavvAlgorithm">The CAVV algorithm used..</param>
        /// <param name="DirectoryResponse">The enrollment response from the 3D directory server..</param>
        /// <param name="Eci">The electronic commerce indicator..</param>
        /// <param name="ThreeDSVersion">The version of the 3D Secure protocol..</param>
        /// <param name="Xid">The transaction identifier (base64 encoded, 20 bytes in a decoded form)..</param>
        public ThreeDSecureData(AuthenticationResponseEnum? AuthenticationResponse = default(AuthenticationResponseEnum?), byte[] Cavv = default(byte[]), string CavvAlgorithm = default(string), DirectoryResponseEnum? DirectoryResponse = default(DirectoryResponseEnum?), string Eci = default(string), string ThreeDSVersion = default(string), byte[] Xid = default(byte[]))
        {
            this.AuthenticationResponse = AuthenticationResponse;
            this.Cavv = Cavv;
            this.CavvAlgorithm = CavvAlgorithm;
            this.DirectoryResponse = DirectoryResponse;
            this.Eci = Eci;
            this.ThreeDSVersion = ThreeDSVersion;
            this.Xid = Xid;
        }
        

        /// <summary>
        /// The cardholder authentication value (base64 encoded, 20 bytes in a decoded form).
        /// </summary>
        /// <value>The cardholder authentication value (base64 encoded, 20 bytes in a decoded form).</value>
        [DataMember(Name="cavv", EmitDefaultValue=false)]
        public byte[] Cavv { get; set; }

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
        /// The version of the 3D Secure protocol.
        /// </summary>
        /// <value>The version of the 3D Secure protocol.</value>
        [DataMember(Name="threeDSVersion", EmitDefaultValue=false)]
        public string ThreeDSVersion { get; set; }

        /// <summary>
        /// The transaction identifier (base64 encoded, 20 bytes in a decoded form).
        /// </summary>
        /// <value>The transaction identifier (base64 encoded, 20 bytes in a decoded form).</value>
        [DataMember(Name="xid", EmitDefaultValue=false)]
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
                    (this.AuthenticationResponse != null &&
                    this.AuthenticationResponse.Equals(input.AuthenticationResponse))
                ) && 
                (
                    this.Cavv == input.Cavv ||
                    (this.Cavv != null &&
                    this.Cavv.Equals(input.Cavv))
                ) && 
                (
                    this.CavvAlgorithm == input.CavvAlgorithm ||
                    (this.CavvAlgorithm != null &&
                    this.CavvAlgorithm.Equals(input.CavvAlgorithm))
                ) && 
                (
                    this.DirectoryResponse == input.DirectoryResponse ||
                    (this.DirectoryResponse != null &&
                    this.DirectoryResponse.Equals(input.DirectoryResponse))
                ) && 
                (
                    this.Eci == input.Eci ||
                    (this.Eci != null &&
                    this.Eci.Equals(input.Eci))
                ) && 
                (
                    this.ThreeDSVersion == input.ThreeDSVersion ||
                    (this.ThreeDSVersion != null &&
                    this.ThreeDSVersion.Equals(input.ThreeDSVersion))
                ) && 
                (
                    this.Xid == input.Xid ||
                    (this.Xid != null &&
                    this.Xid.Equals(input.Xid))
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
