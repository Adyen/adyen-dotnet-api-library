/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 71
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// AdditionalDataLodging
    /// </summary>
    [DataContract(Name = "AdditionalDataLodging")]
    public partial class AdditionalDataLodging : IEquatable<AdditionalDataLodging>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataLodging" /> class.
        /// </summary>
        /// <param name="lodgingSpecialProgramCode">A code that corresponds to the category of lodging charges for the payment. Possible values: * 1: Lodging * 2: No show reservation * 3: Advanced deposit.</param>
        /// <param name="lodgingCheckInDate">The arrival date. * Date format: **yyyyMmDd**. For example, for 2023 April 22, **20230422**..</param>
        /// <param name="lodgingCheckOutDate">The departure date. * Date format: **yyyyMmDd**. For example, for 2023 April 22, **20230422**..</param>
        /// <param name="lodgingCustomerServiceTollFreeNumber">The toll-free phone number for the lodging. * Format: numeric * Max length: 17 characters. * For US and CA numbers must be 10 characters in length * Must not start with a space * Must not contain any special characters such as + or - *Must not be all zeros..</param>
        /// <param name="lodgingFireSafetyActIndicator">Identifies that the facility complies with the Hotel and Motel Fire Safety Act of 1990. Must be &#39;Y&#39; or &#39;N&#39;. * Format: alphabetic * Max length: 1 character.</param>
        /// <param name="lodgingFolioCashAdvances">The folio cash advances, in [minor units](https://docs.adyen.com/development-resources/currency-codes). * Format: numeric * Max length: 12 characters.</param>
        /// <param name="lodgingFolioNumber">The card acceptor’s internal invoice or billing ID reference number. * Max length: 25 characters. * Must not start with a space *Must not be all zeros..</param>
        /// <param name="lodgingFoodBeverageCharges">Any charges for food and beverages associated with the booking, in [minor units](https://docs.adyen.com/development-resources/currency-codes). * Format: numeric * Max length: 12 characters.</param>
        /// <param name="lodgingNoShowIndicator">Indicates if the customer didn&#39;t check in for their booking.  Possible values:  * **Y**: the customer didn&#39;t check in  * **N**: the customer checked in.</param>
        /// <param name="lodgingPrepaidExpenses">The prepaid expenses for the booking. * Format: numeric * Max length: 12 characters.</param>
        /// <param name="lodgingPropertyPhoneNumber">The lodging property location&#39;s phone number. * Format: numeric. * Min length: 10 characters * Max length: 17 characters * For US and CA numbers must be 10 characters in length * Must not start with a space * Must not contain any special characters such as + or - *Must not be all zeros..</param>
        /// <param name="lodgingRoom1NumberOfNights">The total number of nights the room is booked for. * Format: numeric * Must be a number between 0 and 99 * Max length: 4 characters.</param>
        /// <param name="lodgingRoom1Rate">The rate for the room, in [minor units](https://docs.adyen.com/development-resources/currency-codes). * Format: numeric * Max length: 12 characters * Must not be a negative number.</param>
        /// <param name="lodgingTotalRoomTax">The total room tax amount, in [minor units](https://docs.adyen.com/development-resources/currency-codes). * Format: numeric * Max length: 12 characters * Must not be a negative number.</param>
        /// <param name="lodgingTotalTax">The total tax amount, in [minor units](https://docs.adyen.com/development-resources/currency-codes). * Format: numeric * Max length: 12 characters * Must not be a negative number.</param>
        /// <param name="travelEntertainmentAuthDataDuration">The number of nights. This should be included in the auth message. * Format: numeric * Max length: 4 characters.</param>
        /// <param name="travelEntertainmentAuthDataMarket">Indicates what market-specific dataset will be submitted. Must be &#39;H&#39; for Hotel. This should be included in the auth message.  * Format: alphanumeric * Max length: 1 character.</param>
        public AdditionalDataLodging(string lodgingSpecialProgramCode = default(string), string lodgingCheckInDate = default(string), string lodgingCheckOutDate = default(string), string lodgingCustomerServiceTollFreeNumber = default(string), string lodgingFireSafetyActIndicator = default(string), string lodgingFolioCashAdvances = default(string), string lodgingFolioNumber = default(string), string lodgingFoodBeverageCharges = default(string), string lodgingNoShowIndicator = default(string), string lodgingPrepaidExpenses = default(string), string lodgingPropertyPhoneNumber = default(string), string lodgingRoom1NumberOfNights = default(string), string lodgingRoom1Rate = default(string), string lodgingTotalRoomTax = default(string), string lodgingTotalTax = default(string), string travelEntertainmentAuthDataDuration = default(string), string travelEntertainmentAuthDataMarket = default(string))
        {
            this.LodgingSpecialProgramCode = lodgingSpecialProgramCode;
            this.LodgingCheckInDate = lodgingCheckInDate;
            this.LodgingCheckOutDate = lodgingCheckOutDate;
            this.LodgingCustomerServiceTollFreeNumber = lodgingCustomerServiceTollFreeNumber;
            this.LodgingFireSafetyActIndicator = lodgingFireSafetyActIndicator;
            this.LodgingFolioCashAdvances = lodgingFolioCashAdvances;
            this.LodgingFolioNumber = lodgingFolioNumber;
            this.LodgingFoodBeverageCharges = lodgingFoodBeverageCharges;
            this.LodgingNoShowIndicator = lodgingNoShowIndicator;
            this.LodgingPrepaidExpenses = lodgingPrepaidExpenses;
            this.LodgingPropertyPhoneNumber = lodgingPropertyPhoneNumber;
            this.LodgingRoom1NumberOfNights = lodgingRoom1NumberOfNights;
            this.LodgingRoom1Rate = lodgingRoom1Rate;
            this.LodgingTotalRoomTax = lodgingTotalRoomTax;
            this.LodgingTotalTax = lodgingTotalTax;
            this.TravelEntertainmentAuthDataDuration = travelEntertainmentAuthDataDuration;
            this.TravelEntertainmentAuthDataMarket = travelEntertainmentAuthDataMarket;
        }

        /// <summary>
        /// A code that corresponds to the category of lodging charges for the payment. Possible values: * 1: Lodging * 2: No show reservation * 3: Advanced deposit
        /// </summary>
        /// <value>A code that corresponds to the category of lodging charges for the payment. Possible values: * 1: Lodging * 2: No show reservation * 3: Advanced deposit</value>
        [DataMember(Name = "lodging.SpecialProgramCode", EmitDefaultValue = false)]
        public string LodgingSpecialProgramCode { get; set; }

        /// <summary>
        /// The arrival date. * Date format: **yyyyMmDd**. For example, for 2023 April 22, **20230422**.
        /// </summary>
        /// <value>The arrival date. * Date format: **yyyyMmDd**. For example, for 2023 April 22, **20230422**.</value>
        [DataMember(Name = "lodging.checkInDate", EmitDefaultValue = false)]
        public string LodgingCheckInDate { get; set; }

        /// <summary>
        /// The departure date. * Date format: **yyyyMmDd**. For example, for 2023 April 22, **20230422**.
        /// </summary>
        /// <value>The departure date. * Date format: **yyyyMmDd**. For example, for 2023 April 22, **20230422**.</value>
        [DataMember(Name = "lodging.checkOutDate", EmitDefaultValue = false)]
        public string LodgingCheckOutDate { get; set; }

        /// <summary>
        /// The toll-free phone number for the lodging. * Format: numeric * Max length: 17 characters. * For US and CA numbers must be 10 characters in length * Must not start with a space * Must not contain any special characters such as + or - *Must not be all zeros.
        /// </summary>
        /// <value>The toll-free phone number for the lodging. * Format: numeric * Max length: 17 characters. * For US and CA numbers must be 10 characters in length * Must not start with a space * Must not contain any special characters such as + or - *Must not be all zeros.</value>
        [DataMember(Name = "lodging.customerServiceTollFreeNumber", EmitDefaultValue = false)]
        public string LodgingCustomerServiceTollFreeNumber { get; set; }

        /// <summary>
        /// Identifies that the facility complies with the Hotel and Motel Fire Safety Act of 1990. Must be &#39;Y&#39; or &#39;N&#39;. * Format: alphabetic * Max length: 1 character
        /// </summary>
        /// <value>Identifies that the facility complies with the Hotel and Motel Fire Safety Act of 1990. Must be &#39;Y&#39; or &#39;N&#39;. * Format: alphabetic * Max length: 1 character</value>
        [DataMember(Name = "lodging.fireSafetyActIndicator", EmitDefaultValue = false)]
        public string LodgingFireSafetyActIndicator { get; set; }

        /// <summary>
        /// The folio cash advances, in [minor units](https://docs.adyen.com/development-resources/currency-codes). * Format: numeric * Max length: 12 characters
        /// </summary>
        /// <value>The folio cash advances, in [minor units](https://docs.adyen.com/development-resources/currency-codes). * Format: numeric * Max length: 12 characters</value>
        [DataMember(Name = "lodging.folioCashAdvances", EmitDefaultValue = false)]
        public string LodgingFolioCashAdvances { get; set; }

        /// <summary>
        /// The card acceptor’s internal invoice or billing ID reference number. * Max length: 25 characters. * Must not start with a space *Must not be all zeros.
        /// </summary>
        /// <value>The card acceptor’s internal invoice or billing ID reference number. * Max length: 25 characters. * Must not start with a space *Must not be all zeros.</value>
        [DataMember(Name = "lodging.folioNumber", EmitDefaultValue = false)]
        public string LodgingFolioNumber { get; set; }

        /// <summary>
        /// Any charges for food and beverages associated with the booking, in [minor units](https://docs.adyen.com/development-resources/currency-codes). * Format: numeric * Max length: 12 characters
        /// </summary>
        /// <value>Any charges for food and beverages associated with the booking, in [minor units](https://docs.adyen.com/development-resources/currency-codes). * Format: numeric * Max length: 12 characters</value>
        [DataMember(Name = "lodging.foodBeverageCharges", EmitDefaultValue = false)]
        public string LodgingFoodBeverageCharges { get; set; }

        /// <summary>
        /// Indicates if the customer didn&#39;t check in for their booking.  Possible values:  * **Y**: the customer didn&#39;t check in  * **N**: the customer checked in
        /// </summary>
        /// <value>Indicates if the customer didn&#39;t check in for their booking.  Possible values:  * **Y**: the customer didn&#39;t check in  * **N**: the customer checked in</value>
        [DataMember(Name = "lodging.noShowIndicator", EmitDefaultValue = false)]
        public string LodgingNoShowIndicator { get; set; }

        /// <summary>
        /// The prepaid expenses for the booking. * Format: numeric * Max length: 12 characters
        /// </summary>
        /// <value>The prepaid expenses for the booking. * Format: numeric * Max length: 12 characters</value>
        [DataMember(Name = "lodging.prepaidExpenses", EmitDefaultValue = false)]
        public string LodgingPrepaidExpenses { get; set; }

        /// <summary>
        /// The lodging property location&#39;s phone number. * Format: numeric. * Min length: 10 characters * Max length: 17 characters * For US and CA numbers must be 10 characters in length * Must not start with a space * Must not contain any special characters such as + or - *Must not be all zeros.
        /// </summary>
        /// <value>The lodging property location&#39;s phone number. * Format: numeric. * Min length: 10 characters * Max length: 17 characters * For US and CA numbers must be 10 characters in length * Must not start with a space * Must not contain any special characters such as + or - *Must not be all zeros.</value>
        [DataMember(Name = "lodging.propertyPhoneNumber", EmitDefaultValue = false)]
        public string LodgingPropertyPhoneNumber { get; set; }

        /// <summary>
        /// The total number of nights the room is booked for. * Format: numeric * Must be a number between 0 and 99 * Max length: 4 characters
        /// </summary>
        /// <value>The total number of nights the room is booked for. * Format: numeric * Must be a number between 0 and 99 * Max length: 4 characters</value>
        [DataMember(Name = "lodging.room1.numberOfNights", EmitDefaultValue = false)]
        public string LodgingRoom1NumberOfNights { get; set; }

        /// <summary>
        /// The rate for the room, in [minor units](https://docs.adyen.com/development-resources/currency-codes). * Format: numeric * Max length: 12 characters * Must not be a negative number
        /// </summary>
        /// <value>The rate for the room, in [minor units](https://docs.adyen.com/development-resources/currency-codes). * Format: numeric * Max length: 12 characters * Must not be a negative number</value>
        [DataMember(Name = "lodging.room1.rate", EmitDefaultValue = false)]
        public string LodgingRoom1Rate { get; set; }

        /// <summary>
        /// The total room tax amount, in [minor units](https://docs.adyen.com/development-resources/currency-codes). * Format: numeric * Max length: 12 characters * Must not be a negative number
        /// </summary>
        /// <value>The total room tax amount, in [minor units](https://docs.adyen.com/development-resources/currency-codes). * Format: numeric * Max length: 12 characters * Must not be a negative number</value>
        [DataMember(Name = "lodging.totalRoomTax", EmitDefaultValue = false)]
        public string LodgingTotalRoomTax { get; set; }

        /// <summary>
        /// The total tax amount, in [minor units](https://docs.adyen.com/development-resources/currency-codes). * Format: numeric * Max length: 12 characters * Must not be a negative number
        /// </summary>
        /// <value>The total tax amount, in [minor units](https://docs.adyen.com/development-resources/currency-codes). * Format: numeric * Max length: 12 characters * Must not be a negative number</value>
        [DataMember(Name = "lodging.totalTax", EmitDefaultValue = false)]
        public string LodgingTotalTax { get; set; }

        /// <summary>
        /// The number of nights. This should be included in the auth message. * Format: numeric * Max length: 4 characters
        /// </summary>
        /// <value>The number of nights. This should be included in the auth message. * Format: numeric * Max length: 4 characters</value>
        [DataMember(Name = "travelEntertainmentAuthData.duration", EmitDefaultValue = false)]
        public string TravelEntertainmentAuthDataDuration { get; set; }

        /// <summary>
        /// Indicates what market-specific dataset will be submitted. Must be &#39;H&#39; for Hotel. This should be included in the auth message.  * Format: alphanumeric * Max length: 1 character
        /// </summary>
        /// <value>Indicates what market-specific dataset will be submitted. Must be &#39;H&#39; for Hotel. This should be included in the auth message.  * Format: alphanumeric * Max length: 1 character</value>
        [DataMember(Name = "travelEntertainmentAuthData.market", EmitDefaultValue = false)]
        public string TravelEntertainmentAuthDataMarket { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdditionalDataLodging {\n");
            sb.Append("  LodgingSpecialProgramCode: ").Append(LodgingSpecialProgramCode).Append("\n");
            sb.Append("  LodgingCheckInDate: ").Append(LodgingCheckInDate).Append("\n");
            sb.Append("  LodgingCheckOutDate: ").Append(LodgingCheckOutDate).Append("\n");
            sb.Append("  LodgingCustomerServiceTollFreeNumber: ").Append(LodgingCustomerServiceTollFreeNumber).Append("\n");
            sb.Append("  LodgingFireSafetyActIndicator: ").Append(LodgingFireSafetyActIndicator).Append("\n");
            sb.Append("  LodgingFolioCashAdvances: ").Append(LodgingFolioCashAdvances).Append("\n");
            sb.Append("  LodgingFolioNumber: ").Append(LodgingFolioNumber).Append("\n");
            sb.Append("  LodgingFoodBeverageCharges: ").Append(LodgingFoodBeverageCharges).Append("\n");
            sb.Append("  LodgingNoShowIndicator: ").Append(LodgingNoShowIndicator).Append("\n");
            sb.Append("  LodgingPrepaidExpenses: ").Append(LodgingPrepaidExpenses).Append("\n");
            sb.Append("  LodgingPropertyPhoneNumber: ").Append(LodgingPropertyPhoneNumber).Append("\n");
            sb.Append("  LodgingRoom1NumberOfNights: ").Append(LodgingRoom1NumberOfNights).Append("\n");
            sb.Append("  LodgingRoom1Rate: ").Append(LodgingRoom1Rate).Append("\n");
            sb.Append("  LodgingTotalRoomTax: ").Append(LodgingTotalRoomTax).Append("\n");
            sb.Append("  LodgingTotalTax: ").Append(LodgingTotalTax).Append("\n");
            sb.Append("  TravelEntertainmentAuthDataDuration: ").Append(TravelEntertainmentAuthDataDuration).Append("\n");
            sb.Append("  TravelEntertainmentAuthDataMarket: ").Append(TravelEntertainmentAuthDataMarket).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AdditionalDataLodging);
        }

        /// <summary>
        /// Returns true if AdditionalDataLodging instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalDataLodging to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalDataLodging input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LodgingSpecialProgramCode == input.LodgingSpecialProgramCode ||
                    (this.LodgingSpecialProgramCode != null &&
                    this.LodgingSpecialProgramCode.Equals(input.LodgingSpecialProgramCode))
                ) && 
                (
                    this.LodgingCheckInDate == input.LodgingCheckInDate ||
                    (this.LodgingCheckInDate != null &&
                    this.LodgingCheckInDate.Equals(input.LodgingCheckInDate))
                ) && 
                (
                    this.LodgingCheckOutDate == input.LodgingCheckOutDate ||
                    (this.LodgingCheckOutDate != null &&
                    this.LodgingCheckOutDate.Equals(input.LodgingCheckOutDate))
                ) && 
                (
                    this.LodgingCustomerServiceTollFreeNumber == input.LodgingCustomerServiceTollFreeNumber ||
                    (this.LodgingCustomerServiceTollFreeNumber != null &&
                    this.LodgingCustomerServiceTollFreeNumber.Equals(input.LodgingCustomerServiceTollFreeNumber))
                ) && 
                (
                    this.LodgingFireSafetyActIndicator == input.LodgingFireSafetyActIndicator ||
                    (this.LodgingFireSafetyActIndicator != null &&
                    this.LodgingFireSafetyActIndicator.Equals(input.LodgingFireSafetyActIndicator))
                ) && 
                (
                    this.LodgingFolioCashAdvances == input.LodgingFolioCashAdvances ||
                    (this.LodgingFolioCashAdvances != null &&
                    this.LodgingFolioCashAdvances.Equals(input.LodgingFolioCashAdvances))
                ) && 
                (
                    this.LodgingFolioNumber == input.LodgingFolioNumber ||
                    (this.LodgingFolioNumber != null &&
                    this.LodgingFolioNumber.Equals(input.LodgingFolioNumber))
                ) && 
                (
                    this.LodgingFoodBeverageCharges == input.LodgingFoodBeverageCharges ||
                    (this.LodgingFoodBeverageCharges != null &&
                    this.LodgingFoodBeverageCharges.Equals(input.LodgingFoodBeverageCharges))
                ) && 
                (
                    this.LodgingNoShowIndicator == input.LodgingNoShowIndicator ||
                    (this.LodgingNoShowIndicator != null &&
                    this.LodgingNoShowIndicator.Equals(input.LodgingNoShowIndicator))
                ) && 
                (
                    this.LodgingPrepaidExpenses == input.LodgingPrepaidExpenses ||
                    (this.LodgingPrepaidExpenses != null &&
                    this.LodgingPrepaidExpenses.Equals(input.LodgingPrepaidExpenses))
                ) && 
                (
                    this.LodgingPropertyPhoneNumber == input.LodgingPropertyPhoneNumber ||
                    (this.LodgingPropertyPhoneNumber != null &&
                    this.LodgingPropertyPhoneNumber.Equals(input.LodgingPropertyPhoneNumber))
                ) && 
                (
                    this.LodgingRoom1NumberOfNights == input.LodgingRoom1NumberOfNights ||
                    (this.LodgingRoom1NumberOfNights != null &&
                    this.LodgingRoom1NumberOfNights.Equals(input.LodgingRoom1NumberOfNights))
                ) && 
                (
                    this.LodgingRoom1Rate == input.LodgingRoom1Rate ||
                    (this.LodgingRoom1Rate != null &&
                    this.LodgingRoom1Rate.Equals(input.LodgingRoom1Rate))
                ) && 
                (
                    this.LodgingTotalRoomTax == input.LodgingTotalRoomTax ||
                    (this.LodgingTotalRoomTax != null &&
                    this.LodgingTotalRoomTax.Equals(input.LodgingTotalRoomTax))
                ) && 
                (
                    this.LodgingTotalTax == input.LodgingTotalTax ||
                    (this.LodgingTotalTax != null &&
                    this.LodgingTotalTax.Equals(input.LodgingTotalTax))
                ) && 
                (
                    this.TravelEntertainmentAuthDataDuration == input.TravelEntertainmentAuthDataDuration ||
                    (this.TravelEntertainmentAuthDataDuration != null &&
                    this.TravelEntertainmentAuthDataDuration.Equals(input.TravelEntertainmentAuthDataDuration))
                ) && 
                (
                    this.TravelEntertainmentAuthDataMarket == input.TravelEntertainmentAuthDataMarket ||
                    (this.TravelEntertainmentAuthDataMarket != null &&
                    this.TravelEntertainmentAuthDataMarket.Equals(input.TravelEntertainmentAuthDataMarket))
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
                if (this.LodgingSpecialProgramCode != null)
                {
                    hashCode = (hashCode * 59) + this.LodgingSpecialProgramCode.GetHashCode();
                }
                if (this.LodgingCheckInDate != null)
                {
                    hashCode = (hashCode * 59) + this.LodgingCheckInDate.GetHashCode();
                }
                if (this.LodgingCheckOutDate != null)
                {
                    hashCode = (hashCode * 59) + this.LodgingCheckOutDate.GetHashCode();
                }
                if (this.LodgingCustomerServiceTollFreeNumber != null)
                {
                    hashCode = (hashCode * 59) + this.LodgingCustomerServiceTollFreeNumber.GetHashCode();
                }
                if (this.LodgingFireSafetyActIndicator != null)
                {
                    hashCode = (hashCode * 59) + this.LodgingFireSafetyActIndicator.GetHashCode();
                }
                if (this.LodgingFolioCashAdvances != null)
                {
                    hashCode = (hashCode * 59) + this.LodgingFolioCashAdvances.GetHashCode();
                }
                if (this.LodgingFolioNumber != null)
                {
                    hashCode = (hashCode * 59) + this.LodgingFolioNumber.GetHashCode();
                }
                if (this.LodgingFoodBeverageCharges != null)
                {
                    hashCode = (hashCode * 59) + this.LodgingFoodBeverageCharges.GetHashCode();
                }
                if (this.LodgingNoShowIndicator != null)
                {
                    hashCode = (hashCode * 59) + this.LodgingNoShowIndicator.GetHashCode();
                }
                if (this.LodgingPrepaidExpenses != null)
                {
                    hashCode = (hashCode * 59) + this.LodgingPrepaidExpenses.GetHashCode();
                }
                if (this.LodgingPropertyPhoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this.LodgingPropertyPhoneNumber.GetHashCode();
                }
                if (this.LodgingRoom1NumberOfNights != null)
                {
                    hashCode = (hashCode * 59) + this.LodgingRoom1NumberOfNights.GetHashCode();
                }
                if (this.LodgingRoom1Rate != null)
                {
                    hashCode = (hashCode * 59) + this.LodgingRoom1Rate.GetHashCode();
                }
                if (this.LodgingTotalRoomTax != null)
                {
                    hashCode = (hashCode * 59) + this.LodgingTotalRoomTax.GetHashCode();
                }
                if (this.LodgingTotalTax != null)
                {
                    hashCode = (hashCode * 59) + this.LodgingTotalTax.GetHashCode();
                }
                if (this.TravelEntertainmentAuthDataDuration != null)
                {
                    hashCode = (hashCode * 59) + this.TravelEntertainmentAuthDataDuration.GetHashCode();
                }
                if (this.TravelEntertainmentAuthDataMarket != null)
                {
                    hashCode = (hashCode * 59) + this.TravelEntertainmentAuthDataMarket.GetHashCode();
                }
                return hashCode;
            }
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
