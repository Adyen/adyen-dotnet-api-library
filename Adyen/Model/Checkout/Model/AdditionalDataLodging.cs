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
  public class AdditionalDataLodging {
    /// <summary>
    /// The arrival date. * Date format: `yyyyMMdd`
    /// </summary>
    /// <value>The arrival date. * Date format: `yyyyMMdd`</value>
    [DataMember(Name="lodging.checkInDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lodging.checkInDate")]
    public string LodgingCheckInDate { get; set; }

    /// <summary>
    /// The departure date. * Date format: `yyyyMMdd`
    /// </summary>
    /// <value>The departure date. * Date format: `yyyyMMdd`</value>
    [DataMember(Name="lodging.checkOutDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lodging.checkOutDate")]
    public string LodgingCheckOutDate { get; set; }

    /// <summary>
    /// The toll free phone number for the hotel/lodgings. * Format: Alphanumeric * maxLength: 17
    /// </summary>
    /// <value>The toll free phone number for the hotel/lodgings. * Format: Alphanumeric * maxLength: 17</value>
    [DataMember(Name="lodging.customerServiceTollFreeNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lodging.customerServiceTollFreeNumber")]
    public string LodgingCustomerServiceTollFreeNumber { get; set; }

    /// <summary>
    /// Identifies that the facility complies with the Hotel and Motel Fire Safety Act of 1990. Values can be: 'Y' or 'N'. * Format: Alphabetic * maxLength: 1
    /// </summary>
    /// <value>Identifies that the facility complies with the Hotel and Motel Fire Safety Act of 1990. Values can be: 'Y' or 'N'. * Format: Alphabetic * maxLength: 1</value>
    [DataMember(Name="lodging.fireSafetyActIndicator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lodging.fireSafetyActIndicator")]
    public string LodgingFireSafetyActIndicator { get; set; }

    /// <summary>
    /// The folio cash advances. * Format: Numeric * maxLength: 12
    /// </summary>
    /// <value>The folio cash advances. * Format: Numeric * maxLength: 12</value>
    [DataMember(Name="lodging.folioCashAdvances", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lodging.folioCashAdvances")]
    public string LodgingFolioCashAdvances { get; set; }

    /// <summary>
    /// Card acceptor’s internal invoice or billing ID reference number. * Format: Alphanumeric * maxLength: 25
    /// </summary>
    /// <value>Card acceptor’s internal invoice or billing ID reference number. * Format: Alphanumeric * maxLength: 25</value>
    [DataMember(Name="lodging.folioNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lodging.folioNumber")]
    public string LodgingFolioNumber { get; set; }

    /// <summary>
    /// Any charges for food and beverages associated with the booking. * Format: Numeric * maxLength: 12
    /// </summary>
    /// <value>Any charges for food and beverages associated with the booking. * Format: Numeric * maxLength: 12</value>
    [DataMember(Name="lodging.foodBeverageCharges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lodging.foodBeverageCharges")]
    public string LodgingFoodBeverageCharges { get; set; }

    /// <summary>
    /// Indicates if the customer was a \"no-show\" (neither keeps nor cancels their booking).  Value should be Y or N. * Format: Numeric * maxLength: 1
    /// </summary>
    /// <value>Indicates if the customer was a \"no-show\" (neither keeps nor cancels their booking).  Value should be Y or N. * Format: Numeric * maxLength: 1</value>
    [DataMember(Name="lodging.noShowIndicator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lodging.noShowIndicator")]
    public string LodgingNoShowIndicator { get; set; }

    /// <summary>
    /// Prepaid expenses for the booking. * Format: Numeric * maxLength: 12
    /// </summary>
    /// <value>Prepaid expenses for the booking. * Format: Numeric * maxLength: 12</value>
    [DataMember(Name="lodging.prepaidExpenses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lodging.prepaidExpenses")]
    public string LodgingPrepaidExpenses { get; set; }

    /// <summary>
    /// Identifies specific lodging property location by its local phone number. * Format: Alphanumeric * maxLength: 17
    /// </summary>
    /// <value>Identifies specific lodging property location by its local phone number. * Format: Alphanumeric * maxLength: 17</value>
    [DataMember(Name="lodging.propertyPhoneNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lodging.propertyPhoneNumber")]
    public string LodgingPropertyPhoneNumber { get; set; }

    /// <summary>
    /// Total number of nights the room will be rented. * Format: Numeric * maxLength: 4
    /// </summary>
    /// <value>Total number of nights the room will be rented. * Format: Numeric * maxLength: 4</value>
    [DataMember(Name="lodging.room1.numberOfNights", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lodging.room1.numberOfNights")]
    public string LodgingRoom1NumberOfNights { get; set; }

    /// <summary>
    /// The rate of the room. * Format: Numeric * maxLength: 12
    /// </summary>
    /// <value>The rate of the room. * Format: Numeric * maxLength: 12</value>
    [DataMember(Name="lodging.room1.rate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lodging.room1.rate")]
    public string LodgingRoom1Rate { get; set; }

    /// <summary>
    /// The total amount of tax to be paid. * Format: Numeric * maxLength: 12
    /// </summary>
    /// <value>The total amount of tax to be paid. * Format: Numeric * maxLength: 12</value>
    [DataMember(Name="lodging.room1.tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lodging.room1.tax")]
    public string LodgingRoom1Tax { get; set; }

    /// <summary>
    /// Total room tax amount. * Format: Numeric * maxLength: 12
    /// </summary>
    /// <value>Total room tax amount. * Format: Numeric * maxLength: 12</value>
    [DataMember(Name="lodging.totalRoomTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lodging.totalRoomTax")]
    public string LodgingTotalRoomTax { get; set; }

    /// <summary>
    /// Total tax amount. * Format: Numeric * maxLength: 12
    /// </summary>
    /// <value>Total tax amount. * Format: Numeric * maxLength: 12</value>
    [DataMember(Name="lodging.totalTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lodging.totalTax")]
    public string LodgingTotalTax { get; set; }

    /// <summary>
    /// Number of nights. This should be included in the auth message. * Format: Numeric * maxLength: 2
    /// </summary>
    /// <value>Number of nights. This should be included in the auth message. * Format: Numeric * maxLength: 2</value>
    [DataMember(Name="travelEntertainmentAuthData.duration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "travelEntertainmentAuthData.duration")]
    public string TravelEntertainmentAuthDataDuration { get; set; }

    /// <summary>
    /// Indicates what market-specific dataset will be submitted or is being submitted. Value should be \"H\" for Hotel. This should be included in the auth message.  * Format: Alphanumeric * maxLength: 1
    /// </summary>
    /// <value>Indicates what market-specific dataset will be submitted or is being submitted. Value should be \"H\" for Hotel. This should be included in the auth message.  * Format: Alphanumeric * maxLength: 1</value>
    [DataMember(Name="travelEntertainmentAuthData.market", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "travelEntertainmentAuthData.market")]
    public string TravelEntertainmentAuthDataMarket { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AdditionalDataLodging {\n");
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
      sb.Append("  LodgingRoom1Tax: ").Append(LodgingRoom1Tax).Append("\n");
      sb.Append("  LodgingTotalRoomTax: ").Append(LodgingTotalRoomTax).Append("\n");
      sb.Append("  LodgingTotalTax: ").Append(LodgingTotalTax).Append("\n");
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
