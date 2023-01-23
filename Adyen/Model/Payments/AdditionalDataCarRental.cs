/*
* Adyen Payment API
*
*
* The version of the OpenAPI document: 68
* Contact: developer-experience@adyen.com
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

namespace Adyen.Model.Payments
{
    /// <summary>
    /// AdditionalDataCarRental
    /// </summary>
    [DataContract(Name = "AdditionalDataCarRental")]
    public partial class AdditionalDataCarRental : IEquatable<AdditionalDataCarRental>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataCarRental" /> class.
        /// </summary>
        /// <param name="carRentalCheckOutDate">Pick-up date. * Date format: &#x60;yyyyMMdd&#x60;.</param>
        /// <param name="carRentalCustomerServiceTollFreeNumber">The customer service phone number of the car rental company. * Format: Alphanumeric * maxLength: 17.</param>
        /// <param name="carRentalDaysRented">Number of days for which the car is being rented. * Format: Numeric * maxLength: 19.</param>
        /// <param name="carRentalFuelCharges">Any fuel charges associated with the rental. * Format: Numeric * maxLength: 12.</param>
        /// <param name="carRentalInsuranceCharges">Any insurance charges associated with the rental. * Format: Numeric * maxLength: 12.</param>
        /// <param name="carRentalLocationCity">The city from which the car is rented. * Format: Alphanumeric * maxLength: 18.</param>
        /// <param name="carRentalLocationCountry">The country from which the car is rented. * Format: Alphanumeric * maxLength: 2.</param>
        /// <param name="carRentalLocationStateProvince">The state or province from where the car is rented. * Format: Alphanumeric * maxLength: 3.</param>
        /// <param name="carRentalNoShowIndicator">Indicates if the customer was a \&quot;no-show\&quot; (neither keeps nor cancels their booking). * Y - Customer was a no show. * N - Not applicable..</param>
        /// <param name="carRentalOneWayDropOffCharges">Charge associated with not returning a vehicle to the original rental location..</param>
        /// <param name="carRentalRate">Daily rental rate. * Format: Alphanumeric * maxLength: 12.</param>
        /// <param name="carRentalRateIndicator">Specifies whether the given rate is applied daily or weekly. * D - Daily rate. * W - Weekly rate..</param>
        /// <param name="carRentalRentalAgreementNumber">The rental agreement number associated with this car rental. * Format: Alphanumeric * maxLength: 9.</param>
        /// <param name="carRentalRentalClassId">Daily rental rate. * Format: Alphanumeric * maxLength: 12.</param>
        /// <param name="carRentalRenterName">The name of the person renting the car. * Format: Alphanumeric * maxLength: 26.</param>
        /// <param name="carRentalReturnCity">The city where the car must be returned. * Format: Alphanumeric * maxLength: 18.</param>
        /// <param name="carRentalReturnCountry">The country where the car must be returned. * Format: Alphanumeric * maxLength: 2.</param>
        /// <param name="carRentalReturnDate">The last date to return the car by. * Date format: &#x60;yyyyMMdd&#x60;.</param>
        /// <param name="carRentalReturnLocationId">Agency code, phone number, or address abbreviation * Format: Alphanumeric * maxLength: 10.</param>
        /// <param name="carRentalReturnStateProvince">The state or province where the car must be returned. * Format: Alphanumeric * maxLength: 3.</param>
        /// <param name="carRentalTaxExemptIndicator">Indicates whether the goods or services were tax-exempt, or tax was not collected.  Values: * Y - Goods or services were tax exempt * N - Tax was not collected.</param>
        /// <param name="travelEntertainmentAuthDataDuration">Number of nights.  This should be included in the auth message. * Format: Numeric * maxLength: 2.</param>
        /// <param name="travelEntertainmentAuthDataMarket">Indicates what market-specific dataset will be submitted or is being submitted. Value should be \&quot;A\&quot; for Car rental. This should be included in the auth message. * Format: Alphanumeric * maxLength: 1.</param>
        public AdditionalDataCarRental(string carRentalCheckOutDate = default(string), string carRentalCustomerServiceTollFreeNumber = default(string), string carRentalDaysRented = default(string), string carRentalFuelCharges = default(string), string carRentalInsuranceCharges = default(string), string carRentalLocationCity = default(string), string carRentalLocationCountry = default(string), string carRentalLocationStateProvince = default(string), string carRentalNoShowIndicator = default(string), string carRentalOneWayDropOffCharges = default(string), string carRentalRate = default(string), string carRentalRateIndicator = default(string), string carRentalRentalAgreementNumber = default(string), string carRentalRentalClassId = default(string), string carRentalRenterName = default(string), string carRentalReturnCity = default(string), string carRentalReturnCountry = default(string), string carRentalReturnDate = default(string), string carRentalReturnLocationId = default(string), string carRentalReturnStateProvince = default(string), string carRentalTaxExemptIndicator = default(string), string travelEntertainmentAuthDataDuration = default(string), string travelEntertainmentAuthDataMarket = default(string))
        {
            this.CarRentalCheckOutDate = carRentalCheckOutDate;
            this.CarRentalCustomerServiceTollFreeNumber = carRentalCustomerServiceTollFreeNumber;
            this.CarRentalDaysRented = carRentalDaysRented;
            this.CarRentalFuelCharges = carRentalFuelCharges;
            this.CarRentalInsuranceCharges = carRentalInsuranceCharges;
            this.CarRentalLocationCity = carRentalLocationCity;
            this.CarRentalLocationCountry = carRentalLocationCountry;
            this.CarRentalLocationStateProvince = carRentalLocationStateProvince;
            this.CarRentalNoShowIndicator = carRentalNoShowIndicator;
            this.CarRentalOneWayDropOffCharges = carRentalOneWayDropOffCharges;
            this.CarRentalRate = carRentalRate;
            this.CarRentalRateIndicator = carRentalRateIndicator;
            this.CarRentalRentalAgreementNumber = carRentalRentalAgreementNumber;
            this.CarRentalRentalClassId = carRentalRentalClassId;
            this.CarRentalRenterName = carRentalRenterName;
            this.CarRentalReturnCity = carRentalReturnCity;
            this.CarRentalReturnCountry = carRentalReturnCountry;
            this.CarRentalReturnDate = carRentalReturnDate;
            this.CarRentalReturnLocationId = carRentalReturnLocationId;
            this.CarRentalReturnStateProvince = carRentalReturnStateProvince;
            this.CarRentalTaxExemptIndicator = carRentalTaxExemptIndicator;
            this.TravelEntertainmentAuthDataDuration = travelEntertainmentAuthDataDuration;
            this.TravelEntertainmentAuthDataMarket = travelEntertainmentAuthDataMarket;
        }

        /// <summary>
        /// Pick-up date. * Date format: &#x60;yyyyMMdd&#x60;
        /// </summary>
        /// <value>Pick-up date. * Date format: &#x60;yyyyMMdd&#x60;</value>
        [DataMember(Name = "carRental.checkOutDate", EmitDefaultValue = false)]
        public string CarRentalCheckOutDate { get; set; }
        
        /// <summary>
        /// The customer service phone number of the car rental company. * Format: Alphanumeric * maxLength: 17
        /// </summary>
        /// <value>The customer service phone number of the car rental company. * Format: Alphanumeric * maxLength: 17</value>
        [DataMember(Name = "carRental.customerServiceTollFreeNumber", EmitDefaultValue = false)]
        public string CarRentalCustomerServiceTollFreeNumber { get; set; }
        
        /// <summary>
        /// Number of days for which the car is being rented. * Format: Numeric * maxLength: 19
        /// </summary>
        /// <value>Number of days for which the car is being rented. * Format: Numeric * maxLength: 19</value>
        [DataMember(Name = "carRental.daysRented", EmitDefaultValue = false)]
        public string CarRentalDaysRented { get; set; }
        
        /// <summary>
        /// Any fuel charges associated with the rental. * Format: Numeric * maxLength: 12
        /// </summary>
        /// <value>Any fuel charges associated with the rental. * Format: Numeric * maxLength: 12</value>
        [DataMember(Name = "carRental.fuelCharges", EmitDefaultValue = false)]
        public string CarRentalFuelCharges { get; set; }
        
        /// <summary>
        /// Any insurance charges associated with the rental. * Format: Numeric * maxLength: 12
        /// </summary>
        /// <value>Any insurance charges associated with the rental. * Format: Numeric * maxLength: 12</value>
        [DataMember(Name = "carRental.insuranceCharges", EmitDefaultValue = false)]
        public string CarRentalInsuranceCharges { get; set; }
        
        /// <summary>
        /// The city from which the car is rented. * Format: Alphanumeric * maxLength: 18
        /// </summary>
        /// <value>The city from which the car is rented. * Format: Alphanumeric * maxLength: 18</value>
        [DataMember(Name = "carRental.locationCity", EmitDefaultValue = false)]
        public string CarRentalLocationCity { get; set; }
        
        /// <summary>
        /// The country from which the car is rented. * Format: Alphanumeric * maxLength: 2
        /// </summary>
        /// <value>The country from which the car is rented. * Format: Alphanumeric * maxLength: 2</value>
        [DataMember(Name = "carRental.locationCountry", EmitDefaultValue = false)]
        public string CarRentalLocationCountry { get; set; }
        
        /// <summary>
        /// The state or province from where the car is rented. * Format: Alphanumeric * maxLength: 3
        /// </summary>
        /// <value>The state or province from where the car is rented. * Format: Alphanumeric * maxLength: 3</value>
        [DataMember(Name = "carRental.locationStateProvince", EmitDefaultValue = false)]
        public string CarRentalLocationStateProvince { get; set; }
        
        /// <summary>
        /// Indicates if the customer was a \&quot;no-show\&quot; (neither keeps nor cancels their booking). * Y - Customer was a no show. * N - Not applicable.
        /// </summary>
        /// <value>Indicates if the customer was a \&quot;no-show\&quot; (neither keeps nor cancels their booking). * Y - Customer was a no show. * N - Not applicable.</value>
        [DataMember(Name = "carRental.noShowIndicator", EmitDefaultValue = false)]
        public string CarRentalNoShowIndicator { get; set; }
        
        /// <summary>
        /// Charge associated with not returning a vehicle to the original rental location.
        /// </summary>
        /// <value>Charge associated with not returning a vehicle to the original rental location.</value>
        [DataMember(Name = "carRental.oneWayDropOffCharges", EmitDefaultValue = false)]
        public string CarRentalOneWayDropOffCharges { get; set; }
        
        /// <summary>
        /// Daily rental rate. * Format: Alphanumeric * maxLength: 12
        /// </summary>
        /// <value>Daily rental rate. * Format: Alphanumeric * maxLength: 12</value>
        [DataMember(Name = "carRental.rate", EmitDefaultValue = false)]
        public string CarRentalRate { get; set; }
        
        /// <summary>
        /// Specifies whether the given rate is applied daily or weekly. * D - Daily rate. * W - Weekly rate.
        /// </summary>
        /// <value>Specifies whether the given rate is applied daily or weekly. * D - Daily rate. * W - Weekly rate.</value>
        [DataMember(Name = "carRental.rateIndicator", EmitDefaultValue = false)]
        public string CarRentalRateIndicator { get; set; }
        
        /// <summary>
        /// The rental agreement number associated with this car rental. * Format: Alphanumeric * maxLength: 9
        /// </summary>
        /// <value>The rental agreement number associated with this car rental. * Format: Alphanumeric * maxLength: 9</value>
        [DataMember(Name = "carRental.rentalAgreementNumber", EmitDefaultValue = false)]
        public string CarRentalRentalAgreementNumber { get; set; }
        
        /// <summary>
        /// Daily rental rate. * Format: Alphanumeric * maxLength: 12
        /// </summary>
        /// <value>Daily rental rate. * Format: Alphanumeric * maxLength: 12</value>
        [DataMember(Name = "carRental.rentalClassId", EmitDefaultValue = false)]
        public string CarRentalRentalClassId { get; set; }
        
        /// <summary>
        /// The name of the person renting the car. * Format: Alphanumeric * maxLength: 26
        /// </summary>
        /// <value>The name of the person renting the car. * Format: Alphanumeric * maxLength: 26</value>
        [DataMember(Name = "carRental.renterName", EmitDefaultValue = false)]
        public string CarRentalRenterName { get; set; }
        
        /// <summary>
        /// The city where the car must be returned. * Format: Alphanumeric * maxLength: 18
        /// </summary>
        /// <value>The city where the car must be returned. * Format: Alphanumeric * maxLength: 18</value>
        [DataMember(Name = "carRental.returnCity", EmitDefaultValue = false)]
        public string CarRentalReturnCity { get; set; }
        
        /// <summary>
        /// The country where the car must be returned. * Format: Alphanumeric * maxLength: 2
        /// </summary>
        /// <value>The country where the car must be returned. * Format: Alphanumeric * maxLength: 2</value>
        [DataMember(Name = "carRental.returnCountry", EmitDefaultValue = false)]
        public string CarRentalReturnCountry { get; set; }
        
        /// <summary>
        /// The last date to return the car by. * Date format: &#x60;yyyyMMdd&#x60;
        /// </summary>
        /// <value>The last date to return the car by. * Date format: &#x60;yyyyMMdd&#x60;</value>
        [DataMember(Name = "carRental.returnDate", EmitDefaultValue = false)]
        public string CarRentalReturnDate { get; set; }
        
        /// <summary>
        /// Agency code, phone number, or address abbreviation * Format: Alphanumeric * maxLength: 10
        /// </summary>
        /// <value>Agency code, phone number, or address abbreviation * Format: Alphanumeric * maxLength: 10</value>
        [DataMember(Name = "carRental.returnLocationId", EmitDefaultValue = false)]
        public string CarRentalReturnLocationId { get; set; }
        
        /// <summary>
        /// The state or province where the car must be returned. * Format: Alphanumeric * maxLength: 3
        /// </summary>
        /// <value>The state or province where the car must be returned. * Format: Alphanumeric * maxLength: 3</value>
        [DataMember(Name = "carRental.returnStateProvince", EmitDefaultValue = false)]
        public string CarRentalReturnStateProvince { get; set; }
        
        /// <summary>
        /// Indicates whether the goods or services were tax-exempt, or tax was not collected.  Values: * Y - Goods or services were tax exempt * N - Tax was not collected
        /// </summary>
        /// <value>Indicates whether the goods or services were tax-exempt, or tax was not collected.  Values: * Y - Goods or services were tax exempt * N - Tax was not collected</value>
        [DataMember(Name = "carRental.taxExemptIndicator", EmitDefaultValue = false)]
        public string CarRentalTaxExemptIndicator { get; set; }
        
        /// <summary>
        /// Number of nights.  This should be included in the auth message. * Format: Numeric * maxLength: 2
        /// </summary>
        /// <value>Number of nights.  This should be included in the auth message. * Format: Numeric * maxLength: 2</value>
        [DataMember(Name = "travelEntertainmentAuthData.duration", EmitDefaultValue = false)]
        public string TravelEntertainmentAuthDataDuration { get; set; }
        
        /// <summary>
        /// Indicates what market-specific dataset will be submitted or is being submitted. Value should be \&quot;A\&quot; for Car rental. This should be included in the auth message. * Format: Alphanumeric * maxLength: 1
        /// </summary>
        /// <value>Indicates what market-specific dataset will be submitted or is being submitted. Value should be \&quot;A\&quot; for Car rental. This should be included in the auth message. * Format: Alphanumeric * maxLength: 1</value>
        [DataMember(Name = "travelEntertainmentAuthData.market", EmitDefaultValue = false)]
        public string TravelEntertainmentAuthDataMarket { get; set; }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdditionalDataCarRental {\n");
            sb.Append("  CarRentalCheckOutDate: ").Append(CarRentalCheckOutDate).Append("\n");
            sb.Append("  CarRentalCustomerServiceTollFreeNumber: ").Append(CarRentalCustomerServiceTollFreeNumber).Append("\n");
            sb.Append("  CarRentalDaysRented: ").Append(CarRentalDaysRented).Append("\n");
            sb.Append("  CarRentalFuelCharges: ").Append(CarRentalFuelCharges).Append("\n");
            sb.Append("  CarRentalInsuranceCharges: ").Append(CarRentalInsuranceCharges).Append("\n");
            sb.Append("  CarRentalLocationCity: ").Append(CarRentalLocationCity).Append("\n");
            sb.Append("  CarRentalLocationCountry: ").Append(CarRentalLocationCountry).Append("\n");
            sb.Append("  CarRentalLocationStateProvince: ").Append(CarRentalLocationStateProvince).Append("\n");
            sb.Append("  CarRentalNoShowIndicator: ").Append(CarRentalNoShowIndicator).Append("\n");
            sb.Append("  CarRentalOneWayDropOffCharges: ").Append(CarRentalOneWayDropOffCharges).Append("\n");
            sb.Append("  CarRentalRate: ").Append(CarRentalRate).Append("\n");
            sb.Append("  CarRentalRateIndicator: ").Append(CarRentalRateIndicator).Append("\n");
            sb.Append("  CarRentalRentalAgreementNumber: ").Append(CarRentalRentalAgreementNumber).Append("\n");
            sb.Append("  CarRentalRentalClassId: ").Append(CarRentalRentalClassId).Append("\n");
            sb.Append("  CarRentalRenterName: ").Append(CarRentalRenterName).Append("\n");
            sb.Append("  CarRentalReturnCity: ").Append(CarRentalReturnCity).Append("\n");
            sb.Append("  CarRentalReturnCountry: ").Append(CarRentalReturnCountry).Append("\n");
            sb.Append("  CarRentalReturnDate: ").Append(CarRentalReturnDate).Append("\n");
            sb.Append("  CarRentalReturnLocationId: ").Append(CarRentalReturnLocationId).Append("\n");
            sb.Append("  CarRentalReturnStateProvince: ").Append(CarRentalReturnStateProvince).Append("\n");
            sb.Append("  CarRentalTaxExemptIndicator: ").Append(CarRentalTaxExemptIndicator).Append("\n");
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
            return this.Equals(input as AdditionalDataCarRental);
        }

        /// <summary>
        /// Returns true if AdditionalDataCarRental instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalDataCarRental to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalDataCarRental input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CarRentalCheckOutDate == input.CarRentalCheckOutDate ||
                    (this.CarRentalCheckOutDate != null &&
                    this.CarRentalCheckOutDate.Equals(input.CarRentalCheckOutDate))
                ) && 
                (
                    this.CarRentalCustomerServiceTollFreeNumber == input.CarRentalCustomerServiceTollFreeNumber ||
                    (this.CarRentalCustomerServiceTollFreeNumber != null &&
                    this.CarRentalCustomerServiceTollFreeNumber.Equals(input.CarRentalCustomerServiceTollFreeNumber))
                ) && 
                (
                    this.CarRentalDaysRented == input.CarRentalDaysRented ||
                    (this.CarRentalDaysRented != null &&
                    this.CarRentalDaysRented.Equals(input.CarRentalDaysRented))
                ) && 
                (
                    this.CarRentalFuelCharges == input.CarRentalFuelCharges ||
                    (this.CarRentalFuelCharges != null &&
                    this.CarRentalFuelCharges.Equals(input.CarRentalFuelCharges))
                ) && 
                (
                    this.CarRentalInsuranceCharges == input.CarRentalInsuranceCharges ||
                    (this.CarRentalInsuranceCharges != null &&
                    this.CarRentalInsuranceCharges.Equals(input.CarRentalInsuranceCharges))
                ) && 
                (
                    this.CarRentalLocationCity == input.CarRentalLocationCity ||
                    (this.CarRentalLocationCity != null &&
                    this.CarRentalLocationCity.Equals(input.CarRentalLocationCity))
                ) && 
                (
                    this.CarRentalLocationCountry == input.CarRentalLocationCountry ||
                    (this.CarRentalLocationCountry != null &&
                    this.CarRentalLocationCountry.Equals(input.CarRentalLocationCountry))
                ) && 
                (
                    this.CarRentalLocationStateProvince == input.CarRentalLocationStateProvince ||
                    (this.CarRentalLocationStateProvince != null &&
                    this.CarRentalLocationStateProvince.Equals(input.CarRentalLocationStateProvince))
                ) && 
                (
                    this.CarRentalNoShowIndicator == input.CarRentalNoShowIndicator ||
                    (this.CarRentalNoShowIndicator != null &&
                    this.CarRentalNoShowIndicator.Equals(input.CarRentalNoShowIndicator))
                ) && 
                (
                    this.CarRentalOneWayDropOffCharges == input.CarRentalOneWayDropOffCharges ||
                    (this.CarRentalOneWayDropOffCharges != null &&
                    this.CarRentalOneWayDropOffCharges.Equals(input.CarRentalOneWayDropOffCharges))
                ) && 
                (
                    this.CarRentalRate == input.CarRentalRate ||
                    (this.CarRentalRate != null &&
                    this.CarRentalRate.Equals(input.CarRentalRate))
                ) && 
                (
                    this.CarRentalRateIndicator == input.CarRentalRateIndicator ||
                    (this.CarRentalRateIndicator != null &&
                    this.CarRentalRateIndicator.Equals(input.CarRentalRateIndicator))
                ) && 
                (
                    this.CarRentalRentalAgreementNumber == input.CarRentalRentalAgreementNumber ||
                    (this.CarRentalRentalAgreementNumber != null &&
                    this.CarRentalRentalAgreementNumber.Equals(input.CarRentalRentalAgreementNumber))
                ) && 
                (
                    this.CarRentalRentalClassId == input.CarRentalRentalClassId ||
                    (this.CarRentalRentalClassId != null &&
                    this.CarRentalRentalClassId.Equals(input.CarRentalRentalClassId))
                ) && 
                (
                    this.CarRentalRenterName == input.CarRentalRenterName ||
                    (this.CarRentalRenterName != null &&
                    this.CarRentalRenterName.Equals(input.CarRentalRenterName))
                ) && 
                (
                    this.CarRentalReturnCity == input.CarRentalReturnCity ||
                    (this.CarRentalReturnCity != null &&
                    this.CarRentalReturnCity.Equals(input.CarRentalReturnCity))
                ) && 
                (
                    this.CarRentalReturnCountry == input.CarRentalReturnCountry ||
                    (this.CarRentalReturnCountry != null &&
                    this.CarRentalReturnCountry.Equals(input.CarRentalReturnCountry))
                ) && 
                (
                    this.CarRentalReturnDate == input.CarRentalReturnDate ||
                    (this.CarRentalReturnDate != null &&
                    this.CarRentalReturnDate.Equals(input.CarRentalReturnDate))
                ) && 
                (
                    this.CarRentalReturnLocationId == input.CarRentalReturnLocationId ||
                    (this.CarRentalReturnLocationId != null &&
                    this.CarRentalReturnLocationId.Equals(input.CarRentalReturnLocationId))
                ) && 
                (
                    this.CarRentalReturnStateProvince == input.CarRentalReturnStateProvince ||
                    (this.CarRentalReturnStateProvince != null &&
                    this.CarRentalReturnStateProvince.Equals(input.CarRentalReturnStateProvince))
                ) && 
                (
                    this.CarRentalTaxExemptIndicator == input.CarRentalTaxExemptIndicator ||
                    (this.CarRentalTaxExemptIndicator != null &&
                    this.CarRentalTaxExemptIndicator.Equals(input.CarRentalTaxExemptIndicator))
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
                if (this.CarRentalCheckOutDate != null)
                {
                    hashCode = (hashCode * 59) + this.CarRentalCheckOutDate.GetHashCode();
                }
                if (this.CarRentalCustomerServiceTollFreeNumber != null)
                {
                    hashCode = (hashCode * 59) + this.CarRentalCustomerServiceTollFreeNumber.GetHashCode();
                }
                if (this.CarRentalDaysRented != null)
                {
                    hashCode = (hashCode * 59) + this.CarRentalDaysRented.GetHashCode();
                }
                if (this.CarRentalFuelCharges != null)
                {
                    hashCode = (hashCode * 59) + this.CarRentalFuelCharges.GetHashCode();
                }
                if (this.CarRentalInsuranceCharges != null)
                {
                    hashCode = (hashCode * 59) + this.CarRentalInsuranceCharges.GetHashCode();
                }
                if (this.CarRentalLocationCity != null)
                {
                    hashCode = (hashCode * 59) + this.CarRentalLocationCity.GetHashCode();
                }
                if (this.CarRentalLocationCountry != null)
                {
                    hashCode = (hashCode * 59) + this.CarRentalLocationCountry.GetHashCode();
                }
                if (this.CarRentalLocationStateProvince != null)
                {
                    hashCode = (hashCode * 59) + this.CarRentalLocationStateProvince.GetHashCode();
                }
                if (this.CarRentalNoShowIndicator != null)
                {
                    hashCode = (hashCode * 59) + this.CarRentalNoShowIndicator.GetHashCode();
                }
                if (this.CarRentalOneWayDropOffCharges != null)
                {
                    hashCode = (hashCode * 59) + this.CarRentalOneWayDropOffCharges.GetHashCode();
                }
                if (this.CarRentalRate != null)
                {
                    hashCode = (hashCode * 59) + this.CarRentalRate.GetHashCode();
                }
                if (this.CarRentalRateIndicator != null)
                {
                    hashCode = (hashCode * 59) + this.CarRentalRateIndicator.GetHashCode();
                }
                if (this.CarRentalRentalAgreementNumber != null)
                {
                    hashCode = (hashCode * 59) + this.CarRentalRentalAgreementNumber.GetHashCode();
                }
                if (this.CarRentalRentalClassId != null)
                {
                    hashCode = (hashCode * 59) + this.CarRentalRentalClassId.GetHashCode();
                }
                if (this.CarRentalRenterName != null)
                {
                    hashCode = (hashCode * 59) + this.CarRentalRenterName.GetHashCode();
                }
                if (this.CarRentalReturnCity != null)
                {
                    hashCode = (hashCode * 59) + this.CarRentalReturnCity.GetHashCode();
                }
                if (this.CarRentalReturnCountry != null)
                {
                    hashCode = (hashCode * 59) + this.CarRentalReturnCountry.GetHashCode();
                }
                if (this.CarRentalReturnDate != null)
                {
                    hashCode = (hashCode * 59) + this.CarRentalReturnDate.GetHashCode();
                }
                if (this.CarRentalReturnLocationId != null)
                {
                    hashCode = (hashCode * 59) + this.CarRentalReturnLocationId.GetHashCode();
                }
                if (this.CarRentalReturnStateProvince != null)
                {
                    hashCode = (hashCode * 59) + this.CarRentalReturnStateProvince.GetHashCode();
                }
                if (this.CarRentalTaxExemptIndicator != null)
                {
                    hashCode = (hashCode * 59) + this.CarRentalTaxExemptIndicator.GetHashCode();
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