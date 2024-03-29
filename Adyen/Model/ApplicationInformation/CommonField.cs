﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.ApplicationInformation
{
    /// <summary>
    /// CommonField
    /// </summary>
    [DataContract]
    public class CommonField :  IEquatable<CommonField>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonField" /> class.
        /// </summary>
        /// <param name="Name">Name of the field. For example, Name of External Platform..</param>
        /// <param name="Version">Version of the field. For example, Version of External Platform..</param>
        public CommonField(string Name = default(string), string Version = default(string))
        {
            this.Name = Name;
            this.Version = Version;
        }
        
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
            sb.Append("class CommonField {\n");
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
            return Equals(input as CommonField);
        }

        /// <summary>
        /// Returns true if CommonField instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonField input)
        {
            if (input == null)
                return false;

            return 
                (
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
                ) && 
                (
                    Version == input.Version ||
                    (Version != null &&
                    Version.Equals(input.Version))
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
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Version != null)
                    hashCode = hashCode * 59 + Version.GetHashCode();
                return hashCode;
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
