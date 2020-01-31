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

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.Model.Recurring
{
    /// <summary>
    /// RecurringDetailsResult
    /// </summary>
    [DataContract]
    public partial class RecurringDetailsResult : IEquatable<RecurringDetailsResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecurringDetailsResult" /> class.
        /// </summary>
        /// <param name="LastKnownShopperEmail">the most recent email for this shopper (if available).</param>
        /// <param name="Details">a list of one or more recurring payment details.</param>
        /// <param name="CreationDate">the creation date when the shopper record was created.</param>
        /// <param name="InvalidOneclickContracts">InvalidOneclickContracts.</param>
        /// <param name="ShopperReference">the reference you use to uniquely identify the shopper (e.g. user ID or account ID).</param>
        public RecurringDetailsResult(string LastKnownShopperEmail = default(string), DateTime? CreationDate = default(DateTime?), bool? InvalidOneclickContracts = default(bool?), string ShopperReference = default(string))
        {
            this.LastKnownShopperEmail = LastKnownShopperEmail;
            this.CreationDate = CreationDate;
            this.InvalidOneclickContracts = InvalidOneclickContracts;
            this.ShopperReference = ShopperReference;
        }

        /// <summary>
        /// the most recent email for this shopper (if available)
        /// </summary>
        /// <value>the most recent email for this shopper (if available)</value>
        [DataMember(Name = "lastKnownShopperEmail", EmitDefaultValue = false)]
        public string LastKnownShopperEmail { get; set; }



        /// <summary>
        /// the creation date when the shopper record was created
        /// </summary>
        /// <value>the creation date when the shopper record was created</value>
        [DataMember(Name = "creationDate", EmitDefaultValue = false)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Gets or Sets InvalidOneclickContracts
        /// </summary>
        [DataMember(Name = "invalidOneclickContracts", EmitDefaultValue = false)]
        public bool? InvalidOneclickContracts { get; set; }

        /// <summary>
        /// the reference you use to uniquely identify the shopper (e.g. user ID or account ID)
        /// </summary>
        /// <value>the reference you use to uniquely identify the shopper (e.g. user ID or account ID)</value>
        [DataMember(Name = "shopperReference", EmitDefaultValue = false)]
        public string ShopperReference { get; set; }


        /// <summary>
        /// details of the result
        /// </summary>
        /// <value>details of the result</value>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public List<RecurringDetailContainer> Details=new List<RecurringDetailContainer>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecurringDetailsResult {\n");
            sb.Append("  LastKnownShopperEmail: ").Append(LastKnownShopperEmail).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  InvalidOneclickContracts: ").Append(InvalidOneclickContracts).Append("\n");
            sb.Append("  ShopperReference: ").Append(ShopperReference).Append("\n");
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
            return this.Equals(obj as RecurringDetailsResult);
        }

        /// <summary>
        /// Returns true if RecurringDetailsResult instances are equal
        /// </summary>
        /// <param name="other">Instance of RecurringDetailsResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecurringDetailsResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.LastKnownShopperEmail == other.LastKnownShopperEmail ||
                    this.LastKnownShopperEmail != null &&
                    this.LastKnownShopperEmail.Equals(other.LastKnownShopperEmail)
                ) &&
                (
                    this.CreationDate == other.CreationDate ||
                    this.CreationDate != null &&
                    this.CreationDate.Equals(other.CreationDate)
                ) &&
                (
                    this.InvalidOneclickContracts == other.InvalidOneclickContracts ||
                    this.InvalidOneclickContracts != null &&
                    this.InvalidOneclickContracts.Equals(other.InvalidOneclickContracts)
                ) &&
                (
                    this.ShopperReference == other.ShopperReference ||
                    this.ShopperReference != null &&
                    this.ShopperReference.Equals(other.ShopperReference)
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
                if (this.LastKnownShopperEmail != null)
                    hash = hash * 59 + this.LastKnownShopperEmail.GetHashCode();
                if (this.CreationDate != null)
                    hash = hash * 59 + this.CreationDate.GetHashCode();
                if (this.InvalidOneclickContracts != null)
                    hash = hash * 59 + this.InvalidOneclickContracts.GetHashCode();
                if (this.ShopperReference != null)
                    hash = hash * 59 + this.ShopperReference.GetHashCode();
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
