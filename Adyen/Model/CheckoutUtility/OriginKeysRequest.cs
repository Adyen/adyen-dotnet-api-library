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
//  * Copyright (c) 2019 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.Model.CheckoutUtility
{
    /// <summary>
    /// OriginKeysRequest
    /// </summary>
    [DataContract]
    public class OriginKeysRequest : IEquatable<OriginKeysRequest>, IValidatableObject
    {
        [DataMember(Name = "originDomains", EmitDefaultValue = false)]
        public List<string> OriginDomains { get;set;}
        
        public bool Equals(OriginKeysRequest input)
        {
            if (input == null)
                return false;

            return (
             this.OriginDomains == input.OriginDomains ||
                    this.OriginDomains != null &&
                    this.OriginDomains.SequenceEqual(input.OriginDomains));
        } 

        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OriginKeysRequest {\n");
            sb.Append("  OriginDomains: ").Append(OriginDomains).Append("\n");
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
            return this.Equals(input as OriginKeysRequest);
        }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
              yield break;
        }
    }
}
