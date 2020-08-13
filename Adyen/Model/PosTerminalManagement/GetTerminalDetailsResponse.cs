#region Licence

// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2020 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

#endregion

using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.Model.PosTerminalManagement
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class GetTerminalDetailsResponse
    {
        /// <summary>
        /// The Bluetooth IP address of the terminal.
        /// </summary>
        /// <value>The Bluetooth IP address of the terminal.</value>
        [DataMember(Name = "bluetoothIp", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bluetoothIp")]
        public string BluetoothIp { get; set; }

        /// <summary>
        /// The Bluetooth MAC address of the terminal.
        /// </summary>
        /// <value>The Bluetooth MAC address of the terminal.</value>
        [DataMember(Name = "bluetoothMac", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bluetoothMac")]
        public string BluetoothMac { get; set; }

        /// <summary>
        /// The company account that the terminal is associated with. If this is the only account level shown in the response, the terminal is assigned to the inventory of the company account.
        /// </summary>
        /// <value>The company account that the terminal is associated with. If this is the only account level shown in the response, the terminal is assigned to the inventory of the company account.</value>
        [DataMember(Name = "companyAccount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "companyAccount")]
        public string CompanyAccount { get; set; }

        /// <summary>
        /// The country where the terminal is used.
        /// </summary>
        /// <value>The country where the terminal is used.</value>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        /// <summary>
        /// The model name of the terminal.
        /// </summary>
        /// <value>The model name of the terminal.</value>
        [DataMember(Name = "deviceModel", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "deviceModel")]
        public string DeviceModel { get; set; }

        /// <summary>
        /// Indicates whether assigning IP addresses through a DHCP server is enabled on the terminal.
        /// </summary>
        /// <value>Indicates whether assigning IP addresses through a DHCP server is enabled on the terminal.</value>
        [DataMember(Name = "dhcpEnabled", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dhcpEnabled")]
        public bool? DhcpEnabled { get; set; }

        /// <summary>
        /// The label shown on the status bar of the display. This label (if any) is specified in your Customer Area.
        /// </summary>
        /// <value>The label shown on the status bar of the display. This label (if any) is specified in your Customer Area.</value>
        [DataMember(Name = "displayLabel", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "displayLabel")]
        public string DisplayLabel { get; set; }

        /// <summary>
        /// The terminal's IP address in your Ethernet network.
        /// </summary>
        /// <value>The terminal's IP address in your Ethernet network.</value>
        [DataMember(Name = "ethernetIp", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ethernetIp")]
        public string EthernetIp { get; set; }

        /// <summary>
        /// The terminal's MAC address in your Ethernet network.
        /// </summary>
        /// <value>The terminal's MAC address in your Ethernet network.</value>
        [DataMember(Name = "ethernetMac", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ethernetMac")]
        public string EthernetMac { get; set; }

        /// <summary>
        /// The software release currently in use on the terminal.
        /// </summary>
        /// <value>The software release currently in use on the terminal.</value>
        [DataMember(Name = "firmwareVersion", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "firmwareVersion")]
        public string FirmwareVersion { get; set; }

        /// <summary>
        /// The integrated circuit card identifier (ICCID) of the SIM card in the terminal.
        /// </summary>
        /// <value>The integrated circuit card identifier (ICCID) of the SIM card in the terminal.</value>
        [DataMember(Name = "iccid", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "iccid")]
        public string Iccid { get; set; }

        /// <summary>
        /// Date and time of the last activity on the terminal. Not included when the last activity was more than 14 days ago.
        /// </summary>
        /// <value>Date and time of the last activity on the terminal. Not included when the last activity was more than 14 days ago.</value>
        [DataMember(Name = "lastActivityDateTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastActivityDateTime")]
        public DateTime? LastActivityDateTime { get; set; }

        /// <summary>
        /// Date and time of the last transaction on the terminal. Not included when the last transaction was more than 14 days ago.
        /// </summary>
        /// <value>Date and time of the last transaction on the terminal. Not included when the last transaction was more than 14 days ago.</value>
        [DataMember(Name = "lastTransactionDateTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastTransactionDateTime")]
        public DateTime? LastTransactionDateTime { get; set; }

        /// <summary>
        /// The Ethernet link negotiation that the terminal uses:   - `auto`: Auto-negotiation  - `100full`: 100 Mbps full duplex
        /// </summary>
        /// <value>The Ethernet link negotiation that the terminal uses:   - `auto`: Auto-negotiation  - `100full`: 100 Mbps full duplex</value>
        [DataMember(Name = "linkNegotiation", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "linkNegotiation")]
        public string LinkNegotiation { get; set; }

        /// <summary>
        /// The merchant account that the terminal is associated with. If the response doesn't contain a `store` the terminal is assigned to this merchant account.
        /// </summary>
        /// <value>The merchant account that the terminal is associated with. If the response doesn't contain a `store` the terminal is assigned to this merchant account.</value>
        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantAccount")]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// Boolean that indicates if the terminal is assigned to the merchant inventory. This is returned when the terminal is assigned to a merchant account.  - If **true**, this indicates that the terminal is in the merchant inventory. This also means that the terminal cannot be boarded.  - If **false**, this indicates that the terminal is assigned to the merchant account as an in-store terminal. This means that the terminal is ready to be boarded, or is already boarded.
        /// </summary>
        /// <value>Boolean that indicates if the terminal is assigned to the merchant inventory. This is returned when the terminal is assigned to a merchant account.  - If **true**, this indicates that the terminal is in the merchant inventory. This also means that the terminal cannot be boarded.  - If **false**, this indicates that the terminal is assigned to the merchant account as an in-store terminal. This means that the terminal is ready to be boarded, or is already boarded.</value>
        [DataMember(Name = "merchantInventory", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "merchantInventory")]
        public bool? MerchantInventory { get; set; }

        /// <summary>
        /// The permanent terminal ID.
        /// </summary>
        /// <value>The permanent terminal ID.</value>
        [DataMember(Name = "permanentTerminalId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "permanentTerminalId")]
        public string PermanentTerminalId { get; set; }

        /// <summary>
        /// The serial number of the terminal.
        /// </summary>
        /// <value>The serial number of the terminal.</value>
        [DataMember(Name = "serialNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "serialNumber")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// On a terminal that supports 3G or 4G connectivity, indicates the status of the SIM card in the terminal: ACTIVE or INVENTORY.
        /// </summary>
        /// <value>On a terminal that supports 3G or 4G connectivity, indicates the status of the SIM card in the terminal: ACTIVE or INVENTORY.</value>
        [DataMember(Name = "simStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "simStatus")]
        public string SimStatus { get; set; }

        /// <summary>
        /// The store code of the store that the terminal is assigned to.
        /// </summary>
        /// <value>The store code of the store that the terminal is assigned to.</value>
        [DataMember(Name = "store", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "store")]
        public string Store { get; set; }

        /// <summary>
        /// Gets or Sets StoreDetails
        /// </summary>
        [DataMember(Name = "storeDetails", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "storeDetails")]
        public Store StoreDetails { get; set; }

        /// <summary>
        /// The unique terminal ID.
        /// </summary>
        /// <value>The unique terminal ID.</value>
        [DataMember(Name = "terminal", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "terminal")]
        public string Terminal { get; set; }

        /// <summary>
        /// The status of the terminal:   - `OnlineToday`, `OnlineLast1Day`, `OnlineLast2Days` etcetera to `OnlineLast7Days`: Indicates when in the past week the terminal was last online.   - `SwitchedOff`: Indicates it was more than a week ago that the terminal was last online.   - `ReAssignToInventoryPending`, `ReAssignToStorePending`, `ReAssignToMerchantInventoryPending`: Indicates the terminal is scheduled to be reassigned.
        /// </summary>
        /// <value>The status of the terminal:   - `OnlineToday`, `OnlineLast1Day`, `OnlineLast2Days` etcetera to `OnlineLast7Days`: Indicates when in the past week the terminal was last online.   - `SwitchedOff`: Indicates it was more than a week ago that the terminal was last online.   - `ReAssignToInventoryPending`, `ReAssignToStorePending`, `ReAssignToMerchantInventoryPending`: Indicates the terminal is scheduled to be reassigned.</value>
        [DataMember(Name = "terminalStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "terminalStatus")]
        public string TerminalStatus { get; set; }

        /// <summary>
        /// The terminal's IP address in your Wi-Fi network.
        /// </summary>
        /// <value>The terminal's IP address in your Wi-Fi network.</value>
        [DataMember(Name = "wifiIp", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wifiIp")]
        public string WifiIp { get; set; }

        /// <summary>
        /// The terminal's MAC address in your Wi-Fi network.
        /// </summary>
        /// <value>The terminal's MAC address in your Wi-Fi network.</value>
        [DataMember(Name = "wifiMac", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wifiMac")]
        public string WifiMac { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}