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
//  * Copyright (c) 2022 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// StoreDetail
    /// </summary>
    [DataContract]
        public partial class StoreDetail :  IEquatable<StoreDetail>, IValidatableObject
    {
        /// <summary>
        /// The sales channel. Possible values: **Ecommerce**, **POS**.
        /// </summary>
        /// <value>The sales channel. Possible values: **Ecommerce**, **POS**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ShopperInteractionEnum
        {
            /// <summary>
            /// Enum Ecommerce for value: Ecommerce
            /// </summary>
            [EnumMember(Value = "Ecommerce")]
            Ecommerce = 1,
            /// <summary>
            /// Enum POS for value: POS
            /// </summary>
            [EnumMember(Value = "POS")]
            POS = 2        }
        /// <summary>
        /// The sales channel. Possible values: **Ecommerce**, **POS**.
        /// </summary>
        /// <value>The sales channel. Possible values: **Ecommerce**, **POS**.</value>
        [DataMember(Name="shopperInteraction", EmitDefaultValue=false)]
        public ShopperInteractionEnum? ShopperInteraction { get; set; }
        /// <summary>
        /// The status of the store. Possible values: **Pending**, **Active**, **Inactive**, **InactiveWithModifications**, **Closed**.
        /// </summary>
        /// <value>The status of the store. Possible values: **Pending**, **Active**, **Inactive**, **InactiveWithModifications**, **Closed**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: Active
            /// </summary>
            [EnumMember(Value = "Active")]
            Active = 1,
            /// <summary>
            /// Enum Closed for value: Closed
            /// </summary>
            [EnumMember(Value = "Closed")]
            Closed = 2,
            /// <summary>
            /// Enum Inactive for value: Inactive
            /// </summary>
            [EnumMember(Value = "Inactive")]
            Inactive = 3,
            /// <summary>
            /// Enum InactiveWithModifications for value: InactiveWithModifications
            /// </summary>
            [EnumMember(Value = "InactiveWithModifications")]
            InactiveWithModifications = 4,
            /// <summary>
            /// Enum Pending for value: Pending
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending = 5        }
        /// <summary>
        /// The status of the store. Possible values: **Pending**, **Active**, **Inactive**, **InactiveWithModifications**, **Closed**.
        /// </summary>
        /// <value>The status of the store. Possible values: **Pending**, **Active**, **Inactive**, **InactiveWithModifications**, **Closed**.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreDetail" /> class.
        /// </summary>
        /// <param name="address">address (required).</param>
        /// <param name="fullPhoneNumber">The phone number of the store provided as a single string.  It will be handled as a landline phone.  Examples: \&quot;0031 6 11 22 33 44\&quot;, \&quot;+316/1122-3344\&quot;, \&quot;(0031) 611223344\&quot;.</param>
        /// <param name="merchantAccount">The merchant account to which the store belongs. (required).</param>
        /// <param name="merchantCategoryCode">The merchant category code (MCC) that classifies the business of the account holder. (required).</param>
        /// <param name="phoneNumber">phoneNumber.</param>
        /// <param name="shopperInteraction">The sales channel. Possible values: **Ecommerce**, **POS**..</param>
        /// <param name="splitConfigurationUUID">The unique reference for the split configuration, returned when you configure splits in your Customer Area. When this is provided, the &#x60;virtualAccount&#x60; is also required. Adyen uses the configuration and the &#x60;virtualAccount&#x60; to split funds between accounts in your platform..</param>
        /// <param name="status">The status of the store. Possible values: **Pending**, **Active**, **Inactive**, **InactiveWithModifications**, **Closed**..</param>
        /// <param name="store">Adyen-generated unique alphanumeric identifier (UUID) for the store, returned in the response when you create a store. Required when updating an existing store in an &#x60;/updateAccountHolder&#x60; request..</param>
        /// <param name="storeName">The name of the account holder&#x27;s store. This value is shown in shopper statements.  * Length: Between 3 to 22 characters   * The following characters are *not* supported: **:;}{$#@!|&lt;&gt;%^*+&#x3D;\\\\**.</param>
        /// <param name="storeReference">Your unique identifier for the store. The Customer Area also uses this value for the store description.   * Length: Between 3 to 128 characters  * The following characters are *not* supported: **:;}{$#@!|&lt;&gt;%^*+&#x3D;\\\\** (required).</param>
        /// <param name="virtualAccount">The account holder&#x27;s &#x60;accountCode&#x60; where the split amount will be sent. Required when you provide the &#x60;splitConfigurationUUID&#x60;..</param>
        /// <param name="webAddress">URL of the ecommerce store..</param>
        public StoreDetail(ViasAddress address = default(ViasAddress), string fullPhoneNumber = default(string), string merchantAccount = default(string), string merchantCategoryCode = default(string), ViasPhoneNumber phoneNumber = default(ViasPhoneNumber), ShopperInteractionEnum? shopperInteraction = default(ShopperInteractionEnum?), string splitConfigurationUUID = default(string), StatusEnum? status = default(StatusEnum?), string store = default(string), string storeName = default(string), string storeReference = default(string), string virtualAccount = default(string), string webAddress = default(string))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new InvalidDataException("address is a required property for StoreDetail and cannot be null");
            }
            else
            {
                this.Address = address;
            }
            // to ensure "merchantAccount" is required (not null)
            if (merchantAccount == null)
            {
                throw new InvalidDataException("merchantAccount is a required property for StoreDetail and cannot be null");
            }
            else
            {
                this.MerchantAccount = merchantAccount;
            }
            // to ensure "merchantCategoryCode" is required (not null)
            if (merchantCategoryCode == null)
            {
                throw new InvalidDataException("merchantCategoryCode is a required property for StoreDetail and cannot be null");
            }
            else
            {
                this.MerchantCategoryCode = merchantCategoryCode;
            }
            // to ensure "storeReference" is required (not null)
            if (storeReference == null)
            {
                throw new InvalidDataException("storeReference is a required property for StoreDetail and cannot be null");
            }
            else
            {
                this.StoreReference = storeReference;
            }
            this.FullPhoneNumber = fullPhoneNumber;
            this.PhoneNumber = phoneNumber;
            this.ShopperInteraction = shopperInteraction;
            this.SplitConfigurationUUID = splitConfigurationUUID;
            this.Status = status;
            this.Store = store;
            this.StoreName = storeName;
            this.VirtualAccount = virtualAccount;
            this.WebAddress = webAddress;
        }
        
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public ViasAddress Address { get; set; }

        /// <summary>
        /// The phone number of the store provided as a single string.  It will be handled as a landline phone.  Examples: \&quot;0031 6 11 22 33 44\&quot;, \&quot;+316/1122-3344\&quot;, \&quot;(0031) 611223344\&quot;
        /// </summary>
        /// <value>The phone number of the store provided as a single string.  It will be handled as a landline phone.  Examples: \&quot;0031 6 11 22 33 44\&quot;, \&quot;+316/1122-3344\&quot;, \&quot;(0031) 611223344\&quot;</value>
        [DataMember(Name="fullPhoneNumber", EmitDefaultValue=false)]
        public string FullPhoneNumber { get; set; }

        /// <summary>
        /// The merchant account to which the store belongs.
        /// </summary>
        /// <value>The merchant account to which the store belongs.</value>
        [DataMember(Name="merchantAccount", EmitDefaultValue=false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// The merchant category code (MCC) that classifies the business of the account holder.
        /// </summary>
        /// <value>The merchant category code (MCC) that classifies the business of the account holder.</value>
        [DataMember(Name="merchantCategoryCode", EmitDefaultValue=false)]
        public string MerchantCategoryCode { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public ViasPhoneNumber PhoneNumber { get; set; }


        /// <summary>
        /// The unique reference for the split configuration, returned when you configure splits in your Customer Area. When this is provided, the &#x60;virtualAccount&#x60; is also required. Adyen uses the configuration and the &#x60;virtualAccount&#x60; to split funds between accounts in your platform.
        /// </summary>
        /// <value>The unique reference for the split configuration, returned when you configure splits in your Customer Area. When this is provided, the &#x60;virtualAccount&#x60; is also required. Adyen uses the configuration and the &#x60;virtualAccount&#x60; to split funds between accounts in your platform.</value>
        [DataMember(Name="splitConfigurationUUID", EmitDefaultValue=false)]
        public string SplitConfigurationUUID { get; set; }


        /// <summary>
        /// Adyen-generated unique alphanumeric identifier (UUID) for the store, returned in the response when you create a store. Required when updating an existing store in an &#x60;/updateAccountHolder&#x60; request.
        /// </summary>
        /// <value>Adyen-generated unique alphanumeric identifier (UUID) for the store, returned in the response when you create a store. Required when updating an existing store in an &#x60;/updateAccountHolder&#x60; request.</value>
        [DataMember(Name="store", EmitDefaultValue=false)]
        public string Store { get; set; }

        /// <summary>
        /// The name of the account holder&#x27;s store. This value is shown in shopper statements.  * Length: Between 3 to 22 characters   * The following characters are *not* supported: **:;}{$#@!|&lt;&gt;%^*+&#x3D;\\\\**
        /// </summary>
        /// <value>The name of the account holder&#x27;s store. This value is shown in shopper statements.  * Length: Between 3 to 22 characters   * The following characters are *not* supported: **:;}{$#@!|&lt;&gt;%^*+&#x3D;\\\\**</value>
        [DataMember(Name="storeName", EmitDefaultValue=false)]
        public string StoreName { get; set; }

        /// <summary>
        /// Your unique identifier for the store. The Customer Area also uses this value for the store description.   * Length: Between 3 to 128 characters  * The following characters are *not* supported: **:;}{$#@!|&lt;&gt;%^*+&#x3D;\\\\**
        /// </summary>
        /// <value>Your unique identifier for the store. The Customer Area also uses this value for the store description.   * Length: Between 3 to 128 characters  * The following characters are *not* supported: **:;}{$#@!|&lt;&gt;%^*+&#x3D;\\\\**</value>
        [DataMember(Name="storeReference", EmitDefaultValue=false)]
        public string StoreReference { get; set; }

        /// <summary>
        /// The account holder&#x27;s &#x60;accountCode&#x60; where the split amount will be sent. Required when you provide the &#x60;splitConfigurationUUID&#x60;.
        /// </summary>
        /// <value>The account holder&#x27;s &#x60;accountCode&#x60; where the split amount will be sent. Required when you provide the &#x60;splitConfigurationUUID&#x60;.</value>
        [DataMember(Name="virtualAccount", EmitDefaultValue=false)]
        public string VirtualAccount { get; set; }

        /// <summary>
        /// URL of the ecommerce store.
        /// </summary>
        /// <value>URL of the ecommerce store.</value>
        [DataMember(Name="webAddress", EmitDefaultValue=false)]
        public string WebAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoreDetail {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  FullPhoneNumber: ").Append(FullPhoneNumber).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  MerchantCategoryCode: ").Append(MerchantCategoryCode).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  ShopperInteraction: ").Append(ShopperInteraction).Append("\n");
            sb.Append("  SplitConfigurationUUID: ").Append(SplitConfigurationUUID).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Store: ").Append(Store).Append("\n");
            sb.Append("  StoreName: ").Append(StoreName).Append("\n");
            sb.Append("  StoreReference: ").Append(StoreReference).Append("\n");
            sb.Append("  VirtualAccount: ").Append(VirtualAccount).Append("\n");
            sb.Append("  WebAddress: ").Append(WebAddress).Append("\n");
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
            return this.Equals(input as StoreDetail);
        }

        /// <summary>
        /// Returns true if StoreDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of StoreDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoreDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.FullPhoneNumber == input.FullPhoneNumber ||
                    (this.FullPhoneNumber != null &&
                    this.FullPhoneNumber.Equals(input.FullPhoneNumber))
                ) && 
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    (this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(input.MerchantAccount))
                ) && 
                (
                    this.MerchantCategoryCode == input.MerchantCategoryCode ||
                    (this.MerchantCategoryCode != null &&
                    this.MerchantCategoryCode.Equals(input.MerchantCategoryCode))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.ShopperInteraction == input.ShopperInteraction ||
                    (this.ShopperInteraction != null &&
                    this.ShopperInteraction.Equals(input.ShopperInteraction))
                ) && 
                (
                    this.SplitConfigurationUUID == input.SplitConfigurationUUID ||
                    (this.SplitConfigurationUUID != null &&
                    this.SplitConfigurationUUID.Equals(input.SplitConfigurationUUID))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Store == input.Store ||
                    (this.Store != null &&
                    this.Store.Equals(input.Store))
                ) && 
                (
                    this.StoreName == input.StoreName ||
                    (this.StoreName != null &&
                    this.StoreName.Equals(input.StoreName))
                ) && 
                (
                    this.StoreReference == input.StoreReference ||
                    (this.StoreReference != null &&
                    this.StoreReference.Equals(input.StoreReference))
                ) && 
                (
                    this.VirtualAccount == input.VirtualAccount ||
                    (this.VirtualAccount != null &&
                    this.VirtualAccount.Equals(input.VirtualAccount))
                ) && 
                (
                    this.WebAddress == input.WebAddress ||
                    (this.WebAddress != null &&
                    this.WebAddress.Equals(input.WebAddress))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.FullPhoneNumber != null)
                    hashCode = hashCode * 59 + this.FullPhoneNumber.GetHashCode();
                if (this.MerchantAccount != null)
                    hashCode = hashCode * 59 + this.MerchantAccount.GetHashCode();
                if (this.MerchantCategoryCode != null)
                    hashCode = hashCode * 59 + this.MerchantCategoryCode.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.ShopperInteraction != null)
                    hashCode = hashCode * 59 + this.ShopperInteraction.GetHashCode();
                if (this.SplitConfigurationUUID != null)
                    hashCode = hashCode * 59 + this.SplitConfigurationUUID.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Store != null)
                    hashCode = hashCode * 59 + this.Store.GetHashCode();
                if (this.StoreName != null)
                    hashCode = hashCode * 59 + this.StoreName.GetHashCode();
                if (this.StoreReference != null)
                    hashCode = hashCode * 59 + this.StoreReference.GetHashCode();
                if (this.VirtualAccount != null)
                    hashCode = hashCode * 59 + this.VirtualAccount.GetHashCode();
                if (this.WebAddress != null)
                    hashCode = hashCode * 59 + this.WebAddress.GetHashCode();
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