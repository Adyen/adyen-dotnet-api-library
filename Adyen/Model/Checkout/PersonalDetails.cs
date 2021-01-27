#region License
// 
//                       ######
//                       ######
// ############    ####( ######  #####. ######  ############   ############
// #############  #####( ######  #####. ######  #############  #############
//        ######  #####( ######  #####. ######  #####  ######  #####  ######
// ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
// ###### ######  #####( ######  #####. ######  #####          #####  ######
// #############  #############  #############  #############  #####  ######
//  ############   ############  #############   ############  #####  ######
//                                      ######
//                               #############
//                               ############
// 
// Adyen Dotnet API Library
// 
// Copyright (c) 2020 Adyen B.V.
// This file is open source and available under the MIT license.
// See the LICENSE file for more info.
// 
#endregion

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    [DataContract]
    public class PersonalDetails : IValidatableObject
    {
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        public string FirstName { get; set; }
        [DataMember(Name = "infix", EmitDefaultValue = false)]
        public string Infix { get; set; }
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        public string LastName { get; set; }
        [DataMember(Name = "dateOfBirth", EmitDefaultValue = false)]
        public string DateOfBirth { get; set; }
        [DataMember(Name = "telephoneNumber", EmitDefaultValue = false)]
        public string TelephoneNumber { get; set; }
        [DataMember(Name = "socialSecurityNumber", EmitDefaultValue = false)]
        public string SocialSecurityNumber { get; set; }
        [DataMember(Name = "shopperEmail", EmitDefaultValue = false)]
        public string ShopperEmail { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PermitRestriction {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  Infix: ").Append(Infix).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  TelephoneNumber: ").Append(TelephoneNumber).Append("\n");
            sb.Append("  SingleUse: ").Append(SocialSecurityNumber).Append("\n");
            sb.Append("  ShopperEmail: ").Append(ShopperEmail).Append("\n");
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
            return this.Equals(input as PersonalDetails);
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

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.Infix != null)
                    hashCode = hashCode * 59 + this.Infix.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.DateOfBirth != null)
                    hashCode = hashCode * 59 + this.DateOfBirth.GetHashCode();
                if (this.TelephoneNumber != null)
                    hashCode = hashCode * 59 + this.TelephoneNumber.GetHashCode();
                if (this.SocialSecurityNumber != null)
                    hashCode = hashCode * 59 + this.SocialSecurityNumber.GetHashCode();
                if (this.ShopperEmail != null)
                    hashCode = hashCode * 59 + this.ShopperEmail.GetHashCode();

                return hashCode;
            }
        }

    }
}