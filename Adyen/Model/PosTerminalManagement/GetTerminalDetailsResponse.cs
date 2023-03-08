/*
* POS Terminal Management API
*
*
* The version of the OpenAPI document: 1
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
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.PosTerminalManagement
{
    /// <summary>
    /// GetTerminalDetailsResponse
    /// </summary>
    [DataContract(Name = "GetTerminalDetailsResponse")]
    public partial class GetTerminalDetailsResponse : IEquatable<GetTerminalDetailsResponse>, IValidatableObject
    {
        /// <summary>
        /// The status of the terminal:   - &#x60;OnlineToday&#x60;, &#x60;OnlineLast1Day&#x60;, &#x60;OnlineLast2Days&#x60; etcetera to &#x60;OnlineLast7Days&#x60;: Indicates when in the past week the terminal was last online.   - &#x60;SwitchedOff&#x60;: Indicates it was more than a week ago that the terminal was last online.   - &#x60;ReAssignToInventoryPending&#x60;, &#x60;ReAssignToStorePending&#x60;, &#x60;ReAssignToMerchantInventoryPending&#x60;: Indicates the terminal is scheduled to be reassigned.
        /// </summary>
        /// <value>The status of the terminal:   - &#x60;OnlineToday&#x60;, &#x60;OnlineLast1Day&#x60;, &#x60;OnlineLast2Days&#x60; etcetera to &#x60;OnlineLast7Days&#x60;: Indicates when in the past week the terminal was last online.   - &#x60;SwitchedOff&#x60;: Indicates it was more than a week ago that the terminal was last online.   - &#x60;ReAssignToInventoryPending&#x60;, &#x60;ReAssignToStorePending&#x60;, &#x60;ReAssignToMerchantInventoryPending&#x60;: Indicates the terminal is scheduled to be reassigned.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TerminalStatusEnum
        {
            /// <summary>
            /// Enum OnlineLast1Day for value: OnlineLast1Day
            /// </summary>
            [EnumMember(Value = "OnlineLast1Day")]
            OnlineLast1Day = 1,

            /// <summary>
            /// Enum OnlineLast2Days for value: OnlineLast2Days
            /// </summary>
            [EnumMember(Value = "OnlineLast2Days")]
            OnlineLast2Days = 2,

            /// <summary>
            /// Enum OnlineLast3Days for value: OnlineLast3Days
            /// </summary>
            [EnumMember(Value = "OnlineLast3Days")]
            OnlineLast3Days = 3,

            /// <summary>
            /// Enum OnlineLast4Days for value: OnlineLast4Days
            /// </summary>
            [EnumMember(Value = "OnlineLast4Days")]
            OnlineLast4Days = 4,

            /// <summary>
            /// Enum OnlineLast5Days for value: OnlineLast5Days
            /// </summary>
            [EnumMember(Value = "OnlineLast5Days")]
            OnlineLast5Days = 5,

            /// <summary>
            /// Enum OnlineLast6Days for value: OnlineLast6Days
            /// </summary>
            [EnumMember(Value = "OnlineLast6Days")]
            OnlineLast6Days = 6,

            /// <summary>
            /// Enum OnlineLast7Days for value: OnlineLast7Days
            /// </summary>
            [EnumMember(Value = "OnlineLast7Days")]
            OnlineLast7Days = 7,

            /// <summary>
            /// Enum OnlineToday for value: OnlineToday
            /// </summary>
            [EnumMember(Value = "OnlineToday")]
            OnlineToday = 8,

            /// <summary>
            /// Enum ReAssignToInventoryPending for value: ReAssignToInventoryPending
            /// </summary>
            [EnumMember(Value = "ReAssignToInventoryPending")]
            ReAssignToInventoryPending = 9,

            /// <summary>
            /// Enum ReAssignToMerchantInventoryPending for value: ReAssignToMerchantInventoryPending
            /// </summary>
            [EnumMember(Value = "ReAssignToMerchantInventoryPending")]
            ReAssignToMerchantInventoryPending = 10,

            /// <summary>
            /// Enum ReAssignToStorePending for value: ReAssignToStorePending
            /// </summary>
            [EnumMember(Value = "ReAssignToStorePending")]
            ReAssignToStorePending = 11,

            /// <summary>
            /// Enum SwitchedOff for value: SwitchedOff
            /// </summary>
            [EnumMember(Value = "SwitchedOff")]
            SwitchedOff = 12

        }


        /// <summary>
        /// The status of the terminal:   - &#x60;OnlineToday&#x60;, &#x60;OnlineLast1Day&#x60;, &#x60;OnlineLast2Days&#x60; etcetera to &#x60;OnlineLast7Days&#x60;: Indicates when in the past week the terminal was last online.   - &#x60;SwitchedOff&#x60;: Indicates it was more than a week ago that the terminal was last online.   - &#x60;ReAssignToInventoryPending&#x60;, &#x60;ReAssignToStorePending&#x60;, &#x60;ReAssignToMerchantInventoryPending&#x60;: Indicates the terminal is scheduled to be reassigned.
        /// </summary>
        /// <value>The status of the terminal:   - &#x60;OnlineToday&#x60;, &#x60;OnlineLast1Day&#x60;, &#x60;OnlineLast2Days&#x60; etcetera to &#x60;OnlineLast7Days&#x60;: Indicates when in the past week the terminal was last online.   - &#x60;SwitchedOff&#x60;: Indicates it was more than a week ago that the terminal was last online.   - &#x60;ReAssignToInventoryPending&#x60;, &#x60;ReAssignToStorePending&#x60;, &#x60;ReAssignToMerchantInventoryPending&#x60;: Indicates the terminal is scheduled to be reassigned.</value>
        [DataMember(Name = "terminalStatus", EmitDefaultValue = false)]
        public TerminalStatusEnum? TerminalStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTerminalDetailsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetTerminalDetailsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTerminalDetailsResponse" /> class.
        /// </summary>
        /// <param name="bluetoothIp">The Bluetooth IP address of the terminal..</param>
        /// <param name="bluetoothMac">The Bluetooth MAC address of the terminal..</param>
        /// <param name="companyAccount">The company account that the terminal is associated with. If this is the only account level shown in the response, the terminal is assigned to the inventory of the company account. (required).</param>
        /// <param name="country">The country where the terminal is used..</param>
        /// <param name="deviceModel">The model name of the terminal..</param>
        /// <param name="dhcpEnabled">Indicates whether assigning IP addresses through a DHCP server is enabled on the terminal..</param>
        /// <param name="displayLabel">The label shown on the status bar of the display. This label (if any) is specified in your Customer Area..</param>
        /// <param name="ethernetIp">The terminal&#39;s IP address in your Ethernet network..</param>
        /// <param name="ethernetMac">The terminal&#39;s MAC address in your Ethernet network..</param>
        /// <param name="firmwareVersion">The software release currently in use on the terminal..</param>
        /// <param name="iccid">The integrated circuit card identifier (ICCID) of the SIM card in the terminal..</param>
        /// <param name="lastActivityDateTime">Date and time of the last activity on the terminal. Not included when the last activity was more than 14 days ago..</param>
        /// <param name="lastTransactionDateTime">Date and time of the last transaction on the terminal. Not included when the last transaction was more than 14 days ago..</param>
        /// <param name="linkNegotiation">The Ethernet link negotiation that the terminal uses:   - &#x60;auto&#x60;: Auto-negotiation  - &#x60;100full&#x60;: 100 Mbps full duplex.</param>
        /// <param name="merchantAccount">The merchant account that the terminal is associated with. If the response doesn&#39;t contain a &#x60;store&#x60; the terminal is assigned to this merchant account..</param>
        /// <param name="merchantInventory">Boolean that indicates if the terminal is assigned to the merchant inventory. This is returned when the terminal is assigned to a merchant account.  - If **true**, this indicates that the terminal is in the merchant inventory. This also means that the terminal cannot be boarded.  - If **false**, this indicates that the terminal is assigned to the merchant account as an in-store terminal. This means that the terminal is ready to be boarded, or is already boarded..</param>
        /// <param name="permanentTerminalId">The permanent terminal ID..</param>
        /// <param name="serialNumber">The serial number of the terminal..</param>
        /// <param name="simStatus">On a terminal that supports 3G or 4G connectivity, indicates the status of the SIM card in the terminal: ACTIVE or INVENTORY..</param>
        /// <param name="store">The store code of the store that the terminal is assigned to..</param>
        /// <param name="storeDetails">storeDetails.</param>
        /// <param name="terminal">The unique terminal ID. (required).</param>
        /// <param name="terminalStatus">The status of the terminal:   - &#x60;OnlineToday&#x60;, &#x60;OnlineLast1Day&#x60;, &#x60;OnlineLast2Days&#x60; etcetera to &#x60;OnlineLast7Days&#x60;: Indicates when in the past week the terminal was last online.   - &#x60;SwitchedOff&#x60;: Indicates it was more than a week ago that the terminal was last online.   - &#x60;ReAssignToInventoryPending&#x60;, &#x60;ReAssignToStorePending&#x60;, &#x60;ReAssignToMerchantInventoryPending&#x60;: Indicates the terminal is scheduled to be reassigned..</param>
        /// <param name="wifiIp">The terminal&#39;s IP address in your Wi-Fi network..</param>
        /// <param name="wifiMac">The terminal&#39;s MAC address in your Wi-Fi network..</param>
        public GetTerminalDetailsResponse(string bluetoothIp = default(string), string bluetoothMac = default(string), string companyAccount = default(string), string country = default(string), string deviceModel = default(string), bool dhcpEnabled = default(bool), string displayLabel = default(string), string ethernetIp = default(string), string ethernetMac = default(string), string firmwareVersion = default(string), string iccid = default(string), DateTime lastActivityDateTime = default(DateTime), DateTime lastTransactionDateTime = default(DateTime), string linkNegotiation = default(string), string merchantAccount = default(string), bool merchantInventory = default(bool), string permanentTerminalId = default(string), string serialNumber = default(string), string simStatus = default(string), string store = default(string), Store storeDetails = default(Store), string terminal = default(string), TerminalStatusEnum? terminalStatus = default(TerminalStatusEnum?), string wifiIp = default(string), string wifiMac = default(string))
        {
            this.CompanyAccount = companyAccount;
            this.Terminal = terminal;
            this.BluetoothIp = bluetoothIp;
            this.BluetoothMac = bluetoothMac;
            this.Country = country;
            this.DeviceModel = deviceModel;
            this.DhcpEnabled = dhcpEnabled;
            this.DisplayLabel = displayLabel;
            this.EthernetIp = ethernetIp;
            this.EthernetMac = ethernetMac;
            this.FirmwareVersion = firmwareVersion;
            this.Iccid = iccid;
            this.LastActivityDateTime = lastActivityDateTime;
            this.LastTransactionDateTime = lastTransactionDateTime;
            this.LinkNegotiation = linkNegotiation;
            this.MerchantAccount = merchantAccount;
            this.MerchantInventory = merchantInventory;
            this.PermanentTerminalId = permanentTerminalId;
            this.SerialNumber = serialNumber;
            this.SimStatus = simStatus;
            this.Store = store;
            this.StoreDetails = storeDetails;
            this.TerminalStatus = terminalStatus;
            this.WifiIp = wifiIp;
            this.WifiMac = wifiMac;
        }

        /// <summary>
        /// The Bluetooth IP address of the terminal.
        /// </summary>
        /// <value>The Bluetooth IP address of the terminal.</value>
        [DataMember(Name = "bluetoothIp", EmitDefaultValue = false)]
        public string BluetoothIp { get; set; }

        /// <summary>
        /// The Bluetooth MAC address of the terminal.
        /// </summary>
        /// <value>The Bluetooth MAC address of the terminal.</value>
        [DataMember(Name = "bluetoothMac", EmitDefaultValue = false)]
        public string BluetoothMac { get; set; }

        /// <summary>
        /// The company account that the terminal is associated with. If this is the only account level shown in the response, the terminal is assigned to the inventory of the company account.
        /// </summary>
        /// <value>The company account that the terminal is associated with. If this is the only account level shown in the response, the terminal is assigned to the inventory of the company account.</value>
        [DataMember(Name = "companyAccount", IsRequired = false, EmitDefaultValue = false)]
        public string CompanyAccount { get; set; }

        /// <summary>
        /// The country where the terminal is used.
        /// </summary>
        /// <value>The country where the terminal is used.</value>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// The model name of the terminal.
        /// </summary>
        /// <value>The model name of the terminal.</value>
        [DataMember(Name = "deviceModel", EmitDefaultValue = false)]
        public string DeviceModel { get; set; }

        /// <summary>
        /// Indicates whether assigning IP addresses through a DHCP server is enabled on the terminal.
        /// </summary>
        /// <value>Indicates whether assigning IP addresses through a DHCP server is enabled on the terminal.</value>
        [DataMember(Name = "dhcpEnabled", EmitDefaultValue = false)]
        public bool DhcpEnabled { get; set; }

        /// <summary>
        /// The label shown on the status bar of the display. This label (if any) is specified in your Customer Area.
        /// </summary>
        /// <value>The label shown on the status bar of the display. This label (if any) is specified in your Customer Area.</value>
        [DataMember(Name = "displayLabel", EmitDefaultValue = false)]
        public string DisplayLabel { get; set; }

        /// <summary>
        /// The terminal&#39;s IP address in your Ethernet network.
        /// </summary>
        /// <value>The terminal&#39;s IP address in your Ethernet network.</value>
        [DataMember(Name = "ethernetIp", EmitDefaultValue = false)]
        public string EthernetIp { get; set; }

        /// <summary>
        /// The terminal&#39;s MAC address in your Ethernet network.
        /// </summary>
        /// <value>The terminal&#39;s MAC address in your Ethernet network.</value>
        [DataMember(Name = "ethernetMac", EmitDefaultValue = false)]
        public string EthernetMac { get; set; }

        /// <summary>
        /// The software release currently in use on the terminal.
        /// </summary>
        /// <value>The software release currently in use on the terminal.</value>
        [DataMember(Name = "firmwareVersion", EmitDefaultValue = false)]
        public string FirmwareVersion { get; set; }

        /// <summary>
        /// The integrated circuit card identifier (ICCID) of the SIM card in the terminal.
        /// </summary>
        /// <value>The integrated circuit card identifier (ICCID) of the SIM card in the terminal.</value>
        [DataMember(Name = "iccid", EmitDefaultValue = false)]
        public string Iccid { get; set; }

        /// <summary>
        /// Date and time of the last activity on the terminal. Not included when the last activity was more than 14 days ago.
        /// </summary>
        /// <value>Date and time of the last activity on the terminal. Not included when the last activity was more than 14 days ago.</value>
        [DataMember(Name = "lastActivityDateTime", EmitDefaultValue = false)]
        public DateTime LastActivityDateTime { get; set; }

        /// <summary>
        /// Date and time of the last transaction on the terminal. Not included when the last transaction was more than 14 days ago.
        /// </summary>
        /// <value>Date and time of the last transaction on the terminal. Not included when the last transaction was more than 14 days ago.</value>
        [DataMember(Name = "lastTransactionDateTime", EmitDefaultValue = false)]
        public DateTime LastTransactionDateTime { get; set; }

        /// <summary>
        /// The Ethernet link negotiation that the terminal uses:   - &#x60;auto&#x60;: Auto-negotiation  - &#x60;100full&#x60;: 100 Mbps full duplex
        /// </summary>
        /// <value>The Ethernet link negotiation that the terminal uses:   - &#x60;auto&#x60;: Auto-negotiation  - &#x60;100full&#x60;: 100 Mbps full duplex</value>
        [DataMember(Name = "linkNegotiation", EmitDefaultValue = false)]
        public string LinkNegotiation { get; set; }

        /// <summary>
        /// The merchant account that the terminal is associated with. If the response doesn&#39;t contain a &#x60;store&#x60; the terminal is assigned to this merchant account.
        /// </summary>
        /// <value>The merchant account that the terminal is associated with. If the response doesn&#39;t contain a &#x60;store&#x60; the terminal is assigned to this merchant account.</value>
        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// Boolean that indicates if the terminal is assigned to the merchant inventory. This is returned when the terminal is assigned to a merchant account.  - If **true**, this indicates that the terminal is in the merchant inventory. This also means that the terminal cannot be boarded.  - If **false**, this indicates that the terminal is assigned to the merchant account as an in-store terminal. This means that the terminal is ready to be boarded, or is already boarded.
        /// </summary>
        /// <value>Boolean that indicates if the terminal is assigned to the merchant inventory. This is returned when the terminal is assigned to a merchant account.  - If **true**, this indicates that the terminal is in the merchant inventory. This also means that the terminal cannot be boarded.  - If **false**, this indicates that the terminal is assigned to the merchant account as an in-store terminal. This means that the terminal is ready to be boarded, or is already boarded.</value>
        [DataMember(Name = "merchantInventory", EmitDefaultValue = false)]
        public bool MerchantInventory { get; set; }

        /// <summary>
        /// The permanent terminal ID.
        /// </summary>
        /// <value>The permanent terminal ID.</value>
        [DataMember(Name = "permanentTerminalId", EmitDefaultValue = false)]
        public string PermanentTerminalId { get; set; }

        /// <summary>
        /// The serial number of the terminal.
        /// </summary>
        /// <value>The serial number of the terminal.</value>
        [DataMember(Name = "serialNumber", EmitDefaultValue = false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// On a terminal that supports 3G or 4G connectivity, indicates the status of the SIM card in the terminal: ACTIVE or INVENTORY.
        /// </summary>
        /// <value>On a terminal that supports 3G or 4G connectivity, indicates the status of the SIM card in the terminal: ACTIVE or INVENTORY.</value>
        [DataMember(Name = "simStatus", EmitDefaultValue = false)]
        public string SimStatus { get; set; }

        /// <summary>
        /// The store code of the store that the terminal is assigned to.
        /// </summary>
        /// <value>The store code of the store that the terminal is assigned to.</value>
        [DataMember(Name = "store", EmitDefaultValue = false)]
        public string Store { get; set; }

        /// <summary>
        /// Gets or Sets StoreDetails
        /// </summary>
        [DataMember(Name = "storeDetails", EmitDefaultValue = false)]
        public Store StoreDetails { get; set; }

        /// <summary>
        /// The unique terminal ID.
        /// </summary>
        /// <value>The unique terminal ID.</value>
        [DataMember(Name = "terminal", IsRequired = false, EmitDefaultValue = false)]
        public string Terminal { get; set; }

        /// <summary>
        /// The terminal&#39;s IP address in your Wi-Fi network.
        /// </summary>
        /// <value>The terminal&#39;s IP address in your Wi-Fi network.</value>
        [DataMember(Name = "wifiIp", EmitDefaultValue = false)]
        public string WifiIp { get; set; }

        /// <summary>
        /// The terminal&#39;s MAC address in your Wi-Fi network.
        /// </summary>
        /// <value>The terminal&#39;s MAC address in your Wi-Fi network.</value>
        [DataMember(Name = "wifiMac", EmitDefaultValue = false)]
        public string WifiMac { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetTerminalDetailsResponse {\n");
            sb.Append("  BluetoothIp: ").Append(BluetoothIp).Append("\n");
            sb.Append("  BluetoothMac: ").Append(BluetoothMac).Append("\n");
            sb.Append("  CompanyAccount: ").Append(CompanyAccount).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  DeviceModel: ").Append(DeviceModel).Append("\n");
            sb.Append("  DhcpEnabled: ").Append(DhcpEnabled).Append("\n");
            sb.Append("  DisplayLabel: ").Append(DisplayLabel).Append("\n");
            sb.Append("  EthernetIp: ").Append(EthernetIp).Append("\n");
            sb.Append("  EthernetMac: ").Append(EthernetMac).Append("\n");
            sb.Append("  FirmwareVersion: ").Append(FirmwareVersion).Append("\n");
            sb.Append("  Iccid: ").Append(Iccid).Append("\n");
            sb.Append("  LastActivityDateTime: ").Append(LastActivityDateTime).Append("\n");
            sb.Append("  LastTransactionDateTime: ").Append(LastTransactionDateTime).Append("\n");
            sb.Append("  LinkNegotiation: ").Append(LinkNegotiation).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  MerchantInventory: ").Append(MerchantInventory).Append("\n");
            sb.Append("  PermanentTerminalId: ").Append(PermanentTerminalId).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  SimStatus: ").Append(SimStatus).Append("\n");
            sb.Append("  Store: ").Append(Store).Append("\n");
            sb.Append("  StoreDetails: ").Append(StoreDetails).Append("\n");
            sb.Append("  Terminal: ").Append(Terminal).Append("\n");
            sb.Append("  TerminalStatus: ").Append(TerminalStatus).Append("\n");
            sb.Append("  WifiIp: ").Append(WifiIp).Append("\n");
            sb.Append("  WifiMac: ").Append(WifiMac).Append("\n");
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
            return this.Equals(input as GetTerminalDetailsResponse);
        }

        /// <summary>
        /// Returns true if GetTerminalDetailsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTerminalDetailsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTerminalDetailsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BluetoothIp == input.BluetoothIp ||
                    (this.BluetoothIp != null &&
                    this.BluetoothIp.Equals(input.BluetoothIp))
                ) && 
                (
                    this.BluetoothMac == input.BluetoothMac ||
                    (this.BluetoothMac != null &&
                    this.BluetoothMac.Equals(input.BluetoothMac))
                ) && 
                (
                    this.CompanyAccount == input.CompanyAccount ||
                    (this.CompanyAccount != null &&
                    this.CompanyAccount.Equals(input.CompanyAccount))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.DeviceModel == input.DeviceModel ||
                    (this.DeviceModel != null &&
                    this.DeviceModel.Equals(input.DeviceModel))
                ) && 
                (
                    this.DhcpEnabled == input.DhcpEnabled ||
                    this.DhcpEnabled.Equals(input.DhcpEnabled)
                ) && 
                (
                    this.DisplayLabel == input.DisplayLabel ||
                    (this.DisplayLabel != null &&
                    this.DisplayLabel.Equals(input.DisplayLabel))
                ) && 
                (
                    this.EthernetIp == input.EthernetIp ||
                    (this.EthernetIp != null &&
                    this.EthernetIp.Equals(input.EthernetIp))
                ) && 
                (
                    this.EthernetMac == input.EthernetMac ||
                    (this.EthernetMac != null &&
                    this.EthernetMac.Equals(input.EthernetMac))
                ) && 
                (
                    this.FirmwareVersion == input.FirmwareVersion ||
                    (this.FirmwareVersion != null &&
                    this.FirmwareVersion.Equals(input.FirmwareVersion))
                ) && 
                (
                    this.Iccid == input.Iccid ||
                    (this.Iccid != null &&
                    this.Iccid.Equals(input.Iccid))
                ) && 
                (
                    this.LastActivityDateTime == input.LastActivityDateTime ||
                    (this.LastActivityDateTime != null &&
                    this.LastActivityDateTime.Equals(input.LastActivityDateTime))
                ) && 
                (
                    this.LastTransactionDateTime == input.LastTransactionDateTime ||
                    (this.LastTransactionDateTime != null &&
                    this.LastTransactionDateTime.Equals(input.LastTransactionDateTime))
                ) && 
                (
                    this.LinkNegotiation == input.LinkNegotiation ||
                    (this.LinkNegotiation != null &&
                    this.LinkNegotiation.Equals(input.LinkNegotiation))
                ) && 
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    (this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(input.MerchantAccount))
                ) && 
                (
                    this.MerchantInventory == input.MerchantInventory ||
                    this.MerchantInventory.Equals(input.MerchantInventory)
                ) && 
                (
                    this.PermanentTerminalId == input.PermanentTerminalId ||
                    (this.PermanentTerminalId != null &&
                    this.PermanentTerminalId.Equals(input.PermanentTerminalId))
                ) && 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
                ) && 
                (
                    this.SimStatus == input.SimStatus ||
                    (this.SimStatus != null &&
                    this.SimStatus.Equals(input.SimStatus))
                ) && 
                (
                    this.Store == input.Store ||
                    (this.Store != null &&
                    this.Store.Equals(input.Store))
                ) && 
                (
                    this.StoreDetails == input.StoreDetails ||
                    (this.StoreDetails != null &&
                    this.StoreDetails.Equals(input.StoreDetails))
                ) && 
                (
                    this.Terminal == input.Terminal ||
                    (this.Terminal != null &&
                    this.Terminal.Equals(input.Terminal))
                ) && 
                (
                    this.TerminalStatus == input.TerminalStatus ||
                    this.TerminalStatus.Equals(input.TerminalStatus)
                ) && 
                (
                    this.WifiIp == input.WifiIp ||
                    (this.WifiIp != null &&
                    this.WifiIp.Equals(input.WifiIp))
                ) && 
                (
                    this.WifiMac == input.WifiMac ||
                    (this.WifiMac != null &&
                    this.WifiMac.Equals(input.WifiMac))
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
                if (this.BluetoothIp != null)
                {
                    hashCode = (hashCode * 59) + this.BluetoothIp.GetHashCode();
                }
                if (this.BluetoothMac != null)
                {
                    hashCode = (hashCode * 59) + this.BluetoothMac.GetHashCode();
                }
                if (this.CompanyAccount != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyAccount.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.DeviceModel != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceModel.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DhcpEnabled.GetHashCode();
                if (this.DisplayLabel != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayLabel.GetHashCode();
                }
                if (this.EthernetIp != null)
                {
                    hashCode = (hashCode * 59) + this.EthernetIp.GetHashCode();
                }
                if (this.EthernetMac != null)
                {
                    hashCode = (hashCode * 59) + this.EthernetMac.GetHashCode();
                }
                if (this.FirmwareVersion != null)
                {
                    hashCode = (hashCode * 59) + this.FirmwareVersion.GetHashCode();
                }
                if (this.Iccid != null)
                {
                    hashCode = (hashCode * 59) + this.Iccid.GetHashCode();
                }
                if (this.LastActivityDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.LastActivityDateTime.GetHashCode();
                }
                if (this.LastTransactionDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.LastTransactionDateTime.GetHashCode();
                }
                if (this.LinkNegotiation != null)
                {
                    hashCode = (hashCode * 59) + this.LinkNegotiation.GetHashCode();
                }
                if (this.MerchantAccount != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantAccount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MerchantInventory.GetHashCode();
                if (this.PermanentTerminalId != null)
                {
                    hashCode = (hashCode * 59) + this.PermanentTerminalId.GetHashCode();
                }
                if (this.SerialNumber != null)
                {
                    hashCode = (hashCode * 59) + this.SerialNumber.GetHashCode();
                }
                if (this.SimStatus != null)
                {
                    hashCode = (hashCode * 59) + this.SimStatus.GetHashCode();
                }
                if (this.Store != null)
                {
                    hashCode = (hashCode * 59) + this.Store.GetHashCode();
                }
                if (this.StoreDetails != null)
                {
                    hashCode = (hashCode * 59) + this.StoreDetails.GetHashCode();
                }
                if (this.Terminal != null)
                {
                    hashCode = (hashCode * 59) + this.Terminal.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TerminalStatus.GetHashCode();
                if (this.WifiIp != null)
                {
                    hashCode = (hashCode * 59) + this.WifiIp.GetHashCode();
                }
                if (this.WifiMac != null)
                {
                    hashCode = (hashCode * 59) + this.WifiMac.GetHashCode();
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
