using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class AdditionalDataCarRental {
    /// <summary>
    /// Pick-up date. * Date format: `yyyyMMdd`
    /// </summary>
    /// <value>Pick-up date. * Date format: `yyyyMMdd`</value>
    [DataMember(Name="carRental.checkOutDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carRental.checkOutDate")]
    public string CarRentalCheckOutDate { get; set; }

    /// <summary>
    /// The customer service phone number of the car rental company. * Format: Alphanumeric * maxLength: 17
    /// </summary>
    /// <value>The customer service phone number of the car rental company. * Format: Alphanumeric * maxLength: 17</value>
    [DataMember(Name="carRental.customerServiceTollFreeNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carRental.customerServiceTollFreeNumber")]
    public string CarRentalCustomerServiceTollFreeNumber { get; set; }

    /// <summary>
    /// Number of days for which the car is being rented. * Format: Numeric * maxLength: 19
    /// </summary>
    /// <value>Number of days for which the car is being rented. * Format: Numeric * maxLength: 19</value>
    [DataMember(Name="carRental.daysRented", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carRental.daysRented")]
    public string CarRentalDaysRented { get; set; }

    /// <summary>
    /// Any fuel charges associated with the rental. * Format: Numeric * maxLength: 12
    /// </summary>
    /// <value>Any fuel charges associated with the rental. * Format: Numeric * maxLength: 12</value>
    [DataMember(Name="carRental.fuelCharges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carRental.fuelCharges")]
    public string CarRentalFuelCharges { get; set; }

    /// <summary>
    /// Any insurance charges associated with the rental. * Format: Numeric * maxLength: 12
    /// </summary>
    /// <value>Any insurance charges associated with the rental. * Format: Numeric * maxLength: 12</value>
    [DataMember(Name="carRental.insuranceCharges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carRental.insuranceCharges")]
    public string CarRentalInsuranceCharges { get; set; }

    /// <summary>
    /// The city from which the car is rented. * Format: Alphanumeric * maxLength: 18
    /// </summary>
    /// <value>The city from which the car is rented. * Format: Alphanumeric * maxLength: 18</value>
    [DataMember(Name="carRental.locationCity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carRental.locationCity")]
    public string CarRentalLocationCity { get; set; }

    /// <summary>
    /// The country from which the car is rented. * Format: Alphanumeric * maxLength: 2
    /// </summary>
    /// <value>The country from which the car is rented. * Format: Alphanumeric * maxLength: 2</value>
    [DataMember(Name="carRental.locationCountry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carRental.locationCountry")]
    public string CarRentalLocationCountry { get; set; }

    /// <summary>
    /// The state or province from where the car is rented. * Format: Alphanumeric * maxLength: 3
    /// </summary>
    /// <value>The state or province from where the car is rented. * Format: Alphanumeric * maxLength: 3</value>
    [DataMember(Name="carRental.locationStateProvince", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carRental.locationStateProvince")]
    public string CarRentalLocationStateProvince { get; set; }

    /// <summary>
    /// Indicates if the customer was a \"no-show\" (neither keeps nor cancels their booking). * Y - Customer was a no show. * N - Not applicable.
    /// </summary>
    /// <value>Indicates if the customer was a \"no-show\" (neither keeps nor cancels their booking). * Y - Customer was a no show. * N - Not applicable.</value>
    [DataMember(Name="carRental.noShowIndicator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carRental.noShowIndicator")]
    public string CarRentalNoShowIndicator { get; set; }

    /// <summary>
    /// Charge associated with not returning a vehicle to the original rental location.
    /// </summary>
    /// <value>Charge associated with not returning a vehicle to the original rental location.</value>
    [DataMember(Name="carRental.oneWayDropOffCharges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carRental.oneWayDropOffCharges")]
    public string CarRentalOneWayDropOffCharges { get; set; }

    /// <summary>
    /// Daily rental rate. * Format: Alphanumeric * maxLength: 12
    /// </summary>
    /// <value>Daily rental rate. * Format: Alphanumeric * maxLength: 12</value>
    [DataMember(Name="carRental.rate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carRental.rate")]
    public string CarRentalRate { get; set; }

    /// <summary>
    /// Specifies whether the given rate is applied daily or weekly. * D - Daily rate. * W - Weekly rate.
    /// </summary>
    /// <value>Specifies whether the given rate is applied daily or weekly. * D - Daily rate. * W - Weekly rate.</value>
    [DataMember(Name="carRental.rateIndicator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carRental.rateIndicator")]
    public string CarRentalRateIndicator { get; set; }

    /// <summary>
    /// The rental agreement number associated with this car rental. * Format: Alphanumeric * maxLength: 9
    /// </summary>
    /// <value>The rental agreement number associated with this car rental. * Format: Alphanumeric * maxLength: 9</value>
    [DataMember(Name="carRental.rentalAgreementNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carRental.rentalAgreementNumber")]
    public string CarRentalRentalAgreementNumber { get; set; }

    /// <summary>
    /// Daily rental rate. * Format: Alphanumeric * maxLength: 12
    /// </summary>
    /// <value>Daily rental rate. * Format: Alphanumeric * maxLength: 12</value>
    [DataMember(Name="carRental.rentalClassId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carRental.rentalClassId")]
    public string CarRentalRentalClassId { get; set; }

    /// <summary>
    /// The name of the person renting the car. * Format: Alphanumeric * maxLength: 26
    /// </summary>
    /// <value>The name of the person renting the car. * Format: Alphanumeric * maxLength: 26</value>
    [DataMember(Name="carRental.renterName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carRental.renterName")]
    public string CarRentalRenterName { get; set; }

    /// <summary>
    /// The city where the car must be returned. * Format: Alphanumeric * maxLength: 18
    /// </summary>
    /// <value>The city where the car must be returned. * Format: Alphanumeric * maxLength: 18</value>
    [DataMember(Name="carRental.returnCity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carRental.returnCity")]
    public string CarRentalReturnCity { get; set; }

    /// <summary>
    /// The country where the car must be returned. * Format: Alphanumeric * maxLength: 2
    /// </summary>
    /// <value>The country where the car must be returned. * Format: Alphanumeric * maxLength: 2</value>
    [DataMember(Name="carRental.returnCountry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carRental.returnCountry")]
    public string CarRentalReturnCountry { get; set; }

    /// <summary>
    /// The last date to return the car by. * Date format: `yyyyMMdd`
    /// </summary>
    /// <value>The last date to return the car by. * Date format: `yyyyMMdd`</value>
    [DataMember(Name="carRental.returnDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carRental.returnDate")]
    public string CarRentalReturnDate { get; set; }

    /// <summary>
    /// Agency code, phone number, or address abbreviation * Format: Alphanumeric * maxLength: 10
    /// </summary>
    /// <value>Agency code, phone number, or address abbreviation * Format: Alphanumeric * maxLength: 10</value>
    [DataMember(Name="carRental.returnLocationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carRental.returnLocationId")]
    public string CarRentalReturnLocationId { get; set; }

    /// <summary>
    /// The state or province where the car must be returned. * Format: Alphanumeric * maxLength: 3
    /// </summary>
    /// <value>The state or province where the car must be returned. * Format: Alphanumeric * maxLength: 3</value>
    [DataMember(Name="carRental.returnStateProvince", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carRental.returnStateProvince")]
    public string CarRentalReturnStateProvince { get; set; }

    /// <summary>
    /// Indicates whether the goods or services were tax-exempt, or tax was not collected.  Values: * Y - Goods or services were tax exempt * N - Tax was not collected
    /// </summary>
    /// <value>Indicates whether the goods or services were tax-exempt, or tax was not collected.  Values: * Y - Goods or services were tax exempt * N - Tax was not collected</value>
    [DataMember(Name="carRental.taxExemptIndicator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carRental.taxExemptIndicator")]
    public string CarRentalTaxExemptIndicator { get; set; }

    /// <summary>
    /// Number of nights.  This should be included in the auth message. * Format: Numeric * maxLength: 2
    /// </summary>
    /// <value>Number of nights.  This should be included in the auth message. * Format: Numeric * maxLength: 2</value>
    [DataMember(Name="travelEntertainmentAuthData.duration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "travelEntertainmentAuthData.duration")]
    public string TravelEntertainmentAuthDataDuration { get; set; }

    /// <summary>
    /// Indicates what market-specific dataset will be submitted or is being submitted. Value should be \"A\" for Car rental. This should be included in the auth message. * Format: Alphanumeric * maxLength: 1
    /// </summary>
    /// <value>Indicates what market-specific dataset will be submitted or is being submitted. Value should be \"A\" for Car rental. This should be included in the auth message. * Format: Alphanumeric * maxLength: 1</value>
    [DataMember(Name="travelEntertainmentAuthData.market", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "travelEntertainmentAuthData.market")]
    public string TravelEntertainmentAuthDataMarket { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
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
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
