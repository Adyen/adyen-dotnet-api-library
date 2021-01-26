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
    /// ExternalPlatform
    /// </summary>
    [DataContract]
    public partial class ExternalPlatform :  IEquatable<ExternalPlatform>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalPlatform" /> class.
        /// </summary>
        /// <param name="Integrator">External platform integrator..</param>
        /// <param name="Name">Name of the field. For example, Name of External Platform..</param>
        /// <param name="Version">Version of the field. For example, Version of External Platform..</param>
        public ExternalPlatform(string Integrator = default(string), string Name = default(string), string Version = default(string))
        {
            this.Integrator = Integrator;
            this.Name = Name;
            this.Version = Version;
        }
        
        /// <summary>
        /// External platform integrator.
        /// </summary>
        /// <value>External platform integrator.</value>
        [DataMember(Name="integrator", EmitDefaultValue=false)]
        public string Integrator { get; set; }

        /// <summary>
        /// Name of the field. For example, Name of External Platform.
        /// </summary>
        /// <value>Name of the field. For example, Name of External Platform.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Version of the field. For example, Version of External Platform.
        /// </summary>
        /// <value>Version of the field. For example, Version of External Platform.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalPlatform {\n");
            sb.Append("  Integrator: ").Append(Integrator).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as ExternalPlatform);
        }

        /// <summary>
        /// Returns true if ExternalPlatform instances are equal
        /// </summary>
        /// <param name="input">Instance of ExternalPlatform to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalPlatform input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Integrator == input.Integrator ||
                    (this.Integrator != null &&
                    this.Integrator.Equals(input.Integrator))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Integrator != null)
                    hashCode = hashCode * 59 + this.Integrator.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
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
