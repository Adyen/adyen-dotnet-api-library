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

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// GetAccountHolderRequest
    /// </summary>
    [DataContract]
        public partial class GetAccountHolderRequest :  IEquatable<GetAccountHolderRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountHolderRequest" /> class.
        /// </summary>
        /// <param name="accountCode">The code of the account of which to retrieve the details. &gt; Required if no &#x60;accountHolderCode&#x60; is provided..</param>
        /// <param name="accountHolderCode">The code of the account holder of which to retrieve the details. &gt; Required if no &#x60;accountCode&#x60; is provided..</param>
        /// <param name="showDetails">True if the request should return the account holder details.</param>
        public GetAccountHolderRequest(string accountCode = default(string), string accountHolderCode = default(string), bool? showDetails = default(bool?))
        {
            this.AccountCode = accountCode;
            this.AccountHolderCode = accountHolderCode;
            this.ShowDetails = showDetails;
        }
        
        /// <summary>
        /// The code of the account of which to retrieve the details. &gt; Required if no &#x60;accountHolderCode&#x60; is provided.
        /// </summary>
        /// <value>The code of the account of which to retrieve the details. &gt; Required if no &#x60;accountHolderCode&#x60; is provided.</value>
        [DataMember(Name="accountCode", EmitDefaultValue=false)]
        public string AccountCode { get; set; }

        /// <summary>
        /// The code of the account holder of which to retrieve the details. &gt; Required if no &#x60;accountCode&#x60; is provided.
        /// </summary>
        /// <value>The code of the account holder of which to retrieve the details. &gt; Required if no &#x60;accountCode&#x60; is provided.</value>
        [DataMember(Name="accountHolderCode", EmitDefaultValue=false)]
        public string AccountHolderCode { get; set; }

        /// <summary>
        /// True if the request should return the account holder details
        /// </summary>
        /// <value>True if the request should return the account holder details</value>
        [DataMember(Name="showDetails", EmitDefaultValue=false)]
        public bool? ShowDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetAccountHolderRequest {\n");
            sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
            sb.Append("  AccountHolderCode: ").Append(AccountHolderCode).Append("\n");
            sb.Append("  ShowDetails: ").Append(ShowDetails).Append("\n");
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
            return this.Equals(input as GetAccountHolderRequest);
        }

        /// <summary>
        /// Returns true if GetAccountHolderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAccountHolderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAccountHolderRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountCode == input.AccountCode ||
                    (this.AccountCode != null &&
                    this.AccountCode.Equals(input.AccountCode))
                ) && 
                (
                    this.AccountHolderCode == input.AccountHolderCode ||
                    (this.AccountHolderCode != null &&
                    this.AccountHolderCode.Equals(input.AccountHolderCode))
                ) && 
                (
                    this.ShowDetails == input.ShowDetails ||
                    (this.ShowDetails != null &&
                    this.ShowDetails.Equals(input.ShowDetails))
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
                if (this.AccountCode != null)
                    hashCode = hashCode * 59 + this.AccountCode.GetHashCode();
                if (this.AccountHolderCode != null)
                    hashCode = hashCode * 59 + this.AccountHolderCode.GetHashCode();
                if (this.ShowDetails != null)
                    hashCode = hashCode * 59 + this.ShowDetails.GetHashCode();
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
