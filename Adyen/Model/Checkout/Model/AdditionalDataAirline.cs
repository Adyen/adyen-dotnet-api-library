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
  public class AdditionalDataAirline {
    /// <summary>
    /// Reference number for the invoice, issued by the agency. * minLength: 1 * maxLength: 6
    /// </summary>
    /// <value>Reference number for the invoice, issued by the agency. * minLength: 1 * maxLength: 6</value>
    [DataMember(Name="airline.agency_invoice_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airline.agency_invoice_number")]
    public string AirlineAgencyInvoiceNumber { get; set; }

    /// <summary>
    /// 2-letter agency plan identifier; alphabetical. * minLength: 2 * maxLength: 2
    /// </summary>
    /// <value>2-letter agency plan identifier; alphabetical. * minLength: 2 * maxLength: 2</value>
    [DataMember(Name="airline.agency_plan_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airline.agency_plan_name")]
    public string AirlineAgencyPlanName { get; set; }

    /// <summary>
    /// [IATA](https://www.iata.org/services/pages/codes.aspx) 3-digit accounting code (PAX); numeric. It identifies the carrier. * Format: IATA 3-digit accounting code (PAX) * Example: KLM = 074 * minLength: 3 * maxLength: 3
    /// </summary>
    /// <value>[IATA](https://www.iata.org/services/pages/codes.aspx) 3-digit accounting code (PAX); numeric. It identifies the carrier. * Format: IATA 3-digit accounting code (PAX) * Example: KLM = 074 * minLength: 3 * maxLength: 3</value>
    [DataMember(Name="airline.airline_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airline.airline_code")]
    public string AirlineAirlineCode { get; set; }

    /// <summary>
    /// [IATA](https://www.iata.org/services/pages/codes.aspx) 2-letter accounting code (PAX); alphabetical. It identifies the carrier. * Format: [IATA](https://www.iata.org/services/pages/codes.aspx) 2-letter airline code * Example: KLM = KL * minLength: 2 * maxLength: 2
    /// </summary>
    /// <value>[IATA](https://www.iata.org/services/pages/codes.aspx) 2-letter accounting code (PAX); alphabetical. It identifies the carrier. * Format: [IATA](https://www.iata.org/services/pages/codes.aspx) 2-letter airline code * Example: KLM = KL * minLength: 2 * maxLength: 2</value>
    [DataMember(Name="airline.airline_designator_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airline.airline_designator_code")]
    public string AirlineAirlineDesignatorCode { get; set; }

    /// <summary>
    /// Chargeable amount for boarding the plane. The transaction amount needs to be represented in minor units according to the [following table](https://docs.adyen.com/development-resources/currency-codes). * minLength: 1 * maxLength: 18
    /// </summary>
    /// <value>Chargeable amount for boarding the plane. The transaction amount needs to be represented in minor units according to the [following table](https://docs.adyen.com/development-resources/currency-codes). * minLength: 1 * maxLength: 18</value>
    [DataMember(Name="airline.boarding_fee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airline.boarding_fee")]
    public string AirlineBoardingFee { get; set; }

    /// <summary>
    /// The [CRS](https://en.wikipedia.org/wiki/Computer_reservation_system) used to make the reservation and purchase the ticket. * Format: alphanumeric. * minLength: 4 * maxLength: 4
    /// </summary>
    /// <value>The [CRS](https://en.wikipedia.org/wiki/Computer_reservation_system) used to make the reservation and purchase the ticket. * Format: alphanumeric. * minLength: 4 * maxLength: 4</value>
    [DataMember(Name="airline.computerized_reservation_system", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airline.computerized_reservation_system")]
    public string AirlineComputerizedReservationSystem { get; set; }

    /// <summary>
    /// Reference number; alphanumeric. * minLength: 0 * maxLength: 20
    /// </summary>
    /// <value>Reference number; alphanumeric. * minLength: 0 * maxLength: 20</value>
    [DataMember(Name="airline.customer_reference_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airline.customer_reference_number")]
    public string AirlineCustomerReferenceNumber { get; set; }

    /// <summary>
    /// Optional 2-digit code; alphanumeric. It identifies the type of product of the transaction. The description of the code may appear on credit card statements. * Format: 2-digit code * Example: Passenger ticket = 01 * minLength: 2 * maxLength: 2
    /// </summary>
    /// <value>Optional 2-digit code; alphanumeric. It identifies the type of product of the transaction. The description of the code may appear on credit card statements. * Format: 2-digit code * Example: Passenger ticket = 01 * minLength: 2 * maxLength: 2</value>
    [DataMember(Name="airline.document_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airline.document_type")]
    public string AirlineDocumentType { get; set; }

    /// <summary>
    /// Flight departure date. Local time `(HH:mm)` is optional. * Date format: `yyyy-MM-dd` * Date and time format: `yyyy-MM-dd HH:mm` * minLength: 10 * maxLength: 16
    /// </summary>
    /// <value>Flight departure date. Local time `(HH:mm)` is optional. * Date format: `yyyy-MM-dd` * Date and time format: `yyyy-MM-dd HH:mm` * minLength: 10 * maxLength: 16</value>
    [DataMember(Name="airline.flight_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airline.flight_date")]
    public string AirlineFlightDate { get; set; }

    /// <summary>
    /// [IATA](https://www.iata.org/services/pages/codes.aspx) 2-letter accounting code (PAX); alphabetical. It identifies the carrier. This field is required/mandatory if the airline data includes leg details. * Format: IATA 2-letter airline code * Example: KLM = KL * minLength: 2 * maxLength: 2
    /// </summary>
    /// <value>[IATA](https://www.iata.org/services/pages/codes.aspx) 2-letter accounting code (PAX); alphabetical. It identifies the carrier. This field is required/mandatory if the airline data includes leg details. * Format: IATA 2-letter airline code * Example: KLM = KL * minLength: 2 * maxLength: 2</value>
    [DataMember(Name="airline.leg.carrier_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airline.leg.carrier_code")]
    public string AirlineLegCarrierCode { get; set; }

    /// <summary>
    /// 1-letter travel class identifier; alphabetical. There is no standard; however, the following codes are used rather consistently: * F: first class * J: business class * Y: economy class * W: premium economy  Limitations: * minLength: 1 * maxLength: 1
    /// </summary>
    /// <value>1-letter travel class identifier; alphabetical. There is no standard; however, the following codes are used rather consistently: * F: first class * J: business class * Y: economy class * W: premium economy  Limitations: * minLength: 1 * maxLength: 1</value>
    [DataMember(Name="airline.leg.class_of_travel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airline.leg.class_of_travel")]
    public string AirlineLegClassOfTravel { get; set; }

    /// <summary>
    ///   Date and time of travel. [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601)-compliant. * Format: `yyyy-MM-dd HH:mm` * minLength: 16 * maxLength: 16
    /// </summary>
    /// <value>  Date and time of travel. [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601)-compliant. * Format: `yyyy-MM-dd HH:mm` * minLength: 16 * maxLength: 16</value>
    [DataMember(Name="airline.leg.date_of_travel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airline.leg.date_of_travel")]
    public string AirlineLegDateOfTravel { get; set; }

    /// <summary>
    /// Alphabetical identifier of the departure airport. This field is required if the airline data includes leg details. * Format: [IATA](https://www.iata.org/services/pages/codes.aspx) 3-letter airport code. * Example: Amsterdam = AMS * minLength: 3 * maxLength: 3
    /// </summary>
    /// <value>Alphabetical identifier of the departure airport. This field is required if the airline data includes leg details. * Format: [IATA](https://www.iata.org/services/pages/codes.aspx) 3-letter airport code. * Example: Amsterdam = AMS * minLength: 3 * maxLength: 3</value>
    [DataMember(Name="airline.leg.depart_airport", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airline.leg.depart_airport")]
    public string AirlineLegDepartAirport { get; set; }

    /// <summary>
    /// [Departure tax](https://en.wikipedia.org/wiki/Departure_tax). Amount charged by a country to an individual upon their leaving. The transaction amount needs to be represented in minor units according to the [following table](https://docs.adyen.com/development-resources/currency-codes). * minLength: 1 * maxLength: 12
    /// </summary>
    /// <value>[Departure tax](https://en.wikipedia.org/wiki/Departure_tax). Amount charged by a country to an individual upon their leaving. The transaction amount needs to be represented in minor units according to the [following table](https://docs.adyen.com/development-resources/currency-codes). * minLength: 1 * maxLength: 12</value>
    [DataMember(Name="airline.leg.depart_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airline.leg.depart_tax")]
    public string AirlineLegDepartTax { get; set; }

    /// <summary>
    /// Alphabetical identifier of the destination/arrival airport. This field is required/mandatory if the airline data includes leg details. * Format: [IATA](https://www.iata.org/services/pages/codes.aspx) 3-letter airport code. * Example: Amsterdam = AMS * minLength: 3 * maxLength: 3
    /// </summary>
    /// <value>Alphabetical identifier of the destination/arrival airport. This field is required/mandatory if the airline data includes leg details. * Format: [IATA](https://www.iata.org/services/pages/codes.aspx) 3-letter airport code. * Example: Amsterdam = AMS * minLength: 3 * maxLength: 3</value>
    [DataMember(Name="airline.leg.destination_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airline.leg.destination_code")]
    public string AirlineLegDestinationCode { get; set; }

    /// <summary>
    /// [Fare basis code](https://en.wikipedia.org/wiki/Fare_basis_code); alphanumeric. * minLength: 1 * maxLength: 7
    /// </summary>
    /// <value>[Fare basis code](https://en.wikipedia.org/wiki/Fare_basis_code); alphanumeric. * minLength: 1 * maxLength: 7</value>
    [DataMember(Name="airline.leg.fare_base_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airline.leg.fare_base_code")]
    public string AirlineLegFareBaseCode { get; set; }

    /// <summary>
    /// The flight identifier. * minLength: 1 * maxLength: 5
    /// </summary>
    /// <value>The flight identifier. * minLength: 1 * maxLength: 5</value>
    [DataMember(Name="airline.leg.flight_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airline.leg.flight_number")]
    public string AirlineLegFlightNumber { get; set; }

    /// <summary>
    /// 1-letter code that indicates whether the passenger is entitled to make a stopover. Only two types of characters are allowed: * O: Stopover allowed * X: Stopover not allowed  Limitations: * minLength: 1 * maxLength: 1
    /// </summary>
    /// <value>1-letter code that indicates whether the passenger is entitled to make a stopover. Only two types of characters are allowed: * O: Stopover allowed * X: Stopover not allowed  Limitations: * minLength: 1 * maxLength: 1</value>
    [DataMember(Name="airline.leg.stop_over_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airline.leg.stop_over_code")]
    public string AirlineLegStopOverCode { get; set; }

    /// <summary>
    /// Date of birth of the passenger.  Date format: `yyyy-MM-dd` * minLength: 10 * maxLength: 10
    /// </summary>
    /// <value>Date of birth of the passenger.  Date format: `yyyy-MM-dd` * minLength: 10 * maxLength: 10</value>
    [DataMember(Name="airline.passenger.date_of_birth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airline.passenger.date_of_birth")]
    public string AirlinePassengerDateOfBirth { get; set; }

    /// <summary>
    /// Passenger first name/given name. > This field is required/mandatory if the airline data includes passenger details or leg details.
    /// </summary>
    /// <value>Passenger first name/given name. > This field is required/mandatory if the airline data includes passenger details or leg details.</value>
    [DataMember(Name="airline.passenger.first_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airline.passenger.first_name")]
    public string AirlinePassengerFirstName { get; set; }

    /// <summary>
    /// Passenger last name/family name. > This field is required/mandatory if the airline data includes passenger details or leg details.
    /// </summary>
    /// <value>Passenger last name/family name. > This field is required/mandatory if the airline data includes passenger details or leg details.</value>
    [DataMember(Name="airline.passenger.last_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airline.passenger.last_name")]
    public string AirlinePassengerLastName { get; set; }

    /// <summary>
    /// Telephone number of the passenger, including country code. This is an alphanumeric field that can include the '+' and '-' signs. * minLength: 3 * maxLength: 30
    /// </summary>
    /// <value>Telephone number of the passenger, including country code. This is an alphanumeric field that can include the '+' and '-' signs. * minLength: 3 * maxLength: 30</value>
    [DataMember(Name="airline.passenger.telephone_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airline.passenger.telephone_number")]
    public string AirlinePassengerTelephoneNumber { get; set; }

    /// <summary>
    /// Passenger type code (PTC). IATA PTC values are 3-letter alphabetical. Example: ADT, SRC, CNN, INS.  However, several carriers use non-standard codes that can be up to 5 alphanumeric characters. * minLength: 3 * maxLength: 6
    /// </summary>
    /// <value>Passenger type code (PTC). IATA PTC values are 3-letter alphabetical. Example: ADT, SRC, CNN, INS.  However, several carriers use non-standard codes that can be up to 5 alphanumeric characters. * minLength: 3 * maxLength: 6</value>
    [DataMember(Name="airline.passenger.traveller_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airline.passenger.traveller_type")]
    public string AirlinePassengerTravellerType { get; set; }

    /// <summary>
    /// Passenger name, initials, and a title. * Format: last name + first name or initials + title. * Example: *FLYER / MARY MS*. * minLength: 1 * maxLength: 49
    /// </summary>
    /// <value>Passenger name, initials, and a title. * Format: last name + first name or initials + title. * Example: *FLYER / MARY MS*. * minLength: 1 * maxLength: 49</value>
    [DataMember(Name="airline.passenger_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airline.passenger_name")]
    public string AirlinePassengerName { get; set; }

    /// <summary>
    /// Address of the place/agency that issued the ticket. * minLength: 0 * maxLength: 16
    /// </summary>
    /// <value>Address of the place/agency that issued the ticket. * minLength: 0 * maxLength: 16</value>
    [DataMember(Name="airline.ticket_issue_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airline.ticket_issue_address")]
    public string AirlineTicketIssueAddress { get; set; }

    /// <summary>
    /// The ticket's unique identifier. * minLength: 1 * maxLength: 150
    /// </summary>
    /// <value>The ticket's unique identifier. * minLength: 1 * maxLength: 150</value>
    [DataMember(Name="airline.ticket_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airline.ticket_number")]
    public string AirlineTicketNumber { get; set; }

    /// <summary>
    /// IATA number, also ARC number or ARC/IATA number. Unique identifier number for travel agencies. * minLength: 1 * maxLength: 8
    /// </summary>
    /// <value>IATA number, also ARC number or ARC/IATA number. Unique identifier number for travel agencies. * minLength: 1 * maxLength: 8</value>
    [DataMember(Name="airline.travel_agency_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airline.travel_agency_code")]
    public string AirlineTravelAgencyCode { get; set; }

    /// <summary>
    /// The name of the travel agency. * minLength: 1 * maxLength: 25
    /// </summary>
    /// <value>The name of the travel agency. * minLength: 1 * maxLength: 25</value>
    [DataMember(Name="airline.travel_agency_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airline.travel_agency_name")]
    public string AirlineTravelAgencyName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AdditionalDataAirline {\n");
      sb.Append("  AirlineAgencyInvoiceNumber: ").Append(AirlineAgencyInvoiceNumber).Append("\n");
      sb.Append("  AirlineAgencyPlanName: ").Append(AirlineAgencyPlanName).Append("\n");
      sb.Append("  AirlineAirlineCode: ").Append(AirlineAirlineCode).Append("\n");
      sb.Append("  AirlineAirlineDesignatorCode: ").Append(AirlineAirlineDesignatorCode).Append("\n");
      sb.Append("  AirlineBoardingFee: ").Append(AirlineBoardingFee).Append("\n");
      sb.Append("  AirlineComputerizedReservationSystem: ").Append(AirlineComputerizedReservationSystem).Append("\n");
      sb.Append("  AirlineCustomerReferenceNumber: ").Append(AirlineCustomerReferenceNumber).Append("\n");
      sb.Append("  AirlineDocumentType: ").Append(AirlineDocumentType).Append("\n");
      sb.Append("  AirlineFlightDate: ").Append(AirlineFlightDate).Append("\n");
      sb.Append("  AirlineLegCarrierCode: ").Append(AirlineLegCarrierCode).Append("\n");
      sb.Append("  AirlineLegClassOfTravel: ").Append(AirlineLegClassOfTravel).Append("\n");
      sb.Append("  AirlineLegDateOfTravel: ").Append(AirlineLegDateOfTravel).Append("\n");
      sb.Append("  AirlineLegDepartAirport: ").Append(AirlineLegDepartAirport).Append("\n");
      sb.Append("  AirlineLegDepartTax: ").Append(AirlineLegDepartTax).Append("\n");
      sb.Append("  AirlineLegDestinationCode: ").Append(AirlineLegDestinationCode).Append("\n");
      sb.Append("  AirlineLegFareBaseCode: ").Append(AirlineLegFareBaseCode).Append("\n");
      sb.Append("  AirlineLegFlightNumber: ").Append(AirlineLegFlightNumber).Append("\n");
      sb.Append("  AirlineLegStopOverCode: ").Append(AirlineLegStopOverCode).Append("\n");
      sb.Append("  AirlinePassengerDateOfBirth: ").Append(AirlinePassengerDateOfBirth).Append("\n");
      sb.Append("  AirlinePassengerFirstName: ").Append(AirlinePassengerFirstName).Append("\n");
      sb.Append("  AirlinePassengerLastName: ").Append(AirlinePassengerLastName).Append("\n");
      sb.Append("  AirlinePassengerTelephoneNumber: ").Append(AirlinePassengerTelephoneNumber).Append("\n");
      sb.Append("  AirlinePassengerTravellerType: ").Append(AirlinePassengerTravellerType).Append("\n");
      sb.Append("  AirlinePassengerName: ").Append(AirlinePassengerName).Append("\n");
      sb.Append("  AirlineTicketIssueAddress: ").Append(AirlineTicketIssueAddress).Append("\n");
      sb.Append("  AirlineTicketNumber: ").Append(AirlineTicketNumber).Append("\n");
      sb.Append("  AirlineTravelAgencyCode: ").Append(AirlineTravelAgencyCode).Append("\n");
      sb.Append("  AirlineTravelAgencyName: ").Append(AirlineTravelAgencyName).Append("\n");
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
