/*
* Management API
*
*
* The version of the OpenAPI document: 3
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

namespace Adyen.Model.Management
{
    /// <summary>
    /// TerminalSettings
    /// </summary>
    [DataContract(Name = "TerminalSettings")]
    public partial class TerminalSettings : IEquatable<TerminalSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TerminalSettings" /> class.
        /// </summary>
        /// <param name="cardholderReceipt">cardholderReceipt.</param>
        /// <param name="connectivity">connectivity.</param>
        /// <param name="gratuities">Settings for tipping with or without predefined options to choose from. The maximum number of predefined options is four, or three plus the option to enter a custom tip..</param>
        /// <param name="hardware">hardware.</param>
        /// <param name="localization">localization.</param>
        /// <param name="nexo">nexo.</param>
        /// <param name="offlineProcessing">offlineProcessing.</param>
        /// <param name="opi">opi.</param>
        /// <param name="passcodes">passcodes.</param>
        /// <param name="payAtTable">payAtTable.</param>
        /// <param name="payment">payment.</param>
        /// <param name="receiptOptions">receiptOptions.</param>
        /// <param name="receiptPrinting">receiptPrinting.</param>
        /// <param name="signature">signature.</param>
        /// <param name="standalone">standalone.</param>
        /// <param name="surcharge">surcharge.</param>
        /// <param name="timeouts">timeouts.</param>
        /// <param name="wifiProfiles">wifiProfiles.</param>
        public TerminalSettings(CardholderReceipt cardholderReceipt = default(CardholderReceipt), Connectivity connectivity = default(Connectivity), List<Gratuity> gratuities = default(List<Gratuity>), Hardware hardware = default(Hardware), Localization localization = default(Localization), Nexo nexo = default(Nexo), OfflineProcessing offlineProcessing = default(OfflineProcessing), Opi opi = default(Opi), Passcodes passcodes = default(Passcodes), PayAtTable payAtTable = default(PayAtTable), Payment payment = default(Payment), ReceiptOptions receiptOptions = default(ReceiptOptions), ReceiptPrinting receiptPrinting = default(ReceiptPrinting), Signature signature = default(Signature), Standalone standalone = default(Standalone), Surcharge surcharge = default(Surcharge), Timeouts timeouts = default(Timeouts), WifiProfiles wifiProfiles = default(WifiProfiles))
        {
            this.CardholderReceipt = cardholderReceipt;
            this.Connectivity = connectivity;
            this.Gratuities = gratuities;
            this.Hardware = hardware;
            this.Localization = localization;
            this.Nexo = nexo;
            this.OfflineProcessing = offlineProcessing;
            this.Opi = opi;
            this.Passcodes = passcodes;
            this.PayAtTable = payAtTable;
            this.Payment = payment;
            this.ReceiptOptions = receiptOptions;
            this.ReceiptPrinting = receiptPrinting;
            this.Signature = signature;
            this.Standalone = standalone;
            this.Surcharge = surcharge;
            this.Timeouts = timeouts;
            this.WifiProfiles = wifiProfiles;
        }

        /// <summary>
        /// Gets or Sets CardholderReceipt
        /// </summary>
        [DataMember(Name = "cardholderReceipt", EmitDefaultValue = false)]
        public CardholderReceipt CardholderReceipt { get; set; }

        /// <summary>
        /// Gets or Sets Connectivity
        /// </summary>
        [DataMember(Name = "connectivity", EmitDefaultValue = false)]
        public Connectivity Connectivity { get; set; }

        /// <summary>
        /// Settings for tipping with or without predefined options to choose from. The maximum number of predefined options is four, or three plus the option to enter a custom tip.
        /// </summary>
        /// <value>Settings for tipping with or without predefined options to choose from. The maximum number of predefined options is four, or three plus the option to enter a custom tip.</value>
        [DataMember(Name = "gratuities", EmitDefaultValue = false)]
        public List<Gratuity> Gratuities { get; set; }

        /// <summary>
        /// Gets or Sets Hardware
        /// </summary>
        [DataMember(Name = "hardware", EmitDefaultValue = false)]
        public Hardware Hardware { get; set; }

        /// <summary>
        /// Gets or Sets Localization
        /// </summary>
        [DataMember(Name = "localization", EmitDefaultValue = false)]
        public Localization Localization { get; set; }

        /// <summary>
        /// Gets or Sets Nexo
        /// </summary>
        [DataMember(Name = "nexo", EmitDefaultValue = false)]
        public Nexo Nexo { get; set; }

        /// <summary>
        /// Gets or Sets OfflineProcessing
        /// </summary>
        [DataMember(Name = "offlineProcessing", EmitDefaultValue = false)]
        public OfflineProcessing OfflineProcessing { get; set; }

        /// <summary>
        /// Gets or Sets Opi
        /// </summary>
        [DataMember(Name = "opi", EmitDefaultValue = false)]
        public Opi Opi { get; set; }

        /// <summary>
        /// Gets or Sets Passcodes
        /// </summary>
        [DataMember(Name = "passcodes", EmitDefaultValue = false)]
        public Passcodes Passcodes { get; set; }

        /// <summary>
        /// Gets or Sets PayAtTable
        /// </summary>
        [DataMember(Name = "payAtTable", EmitDefaultValue = false)]
        public PayAtTable PayAtTable { get; set; }

        /// <summary>
        /// Gets or Sets Payment
        /// </summary>
        [DataMember(Name = "payment", EmitDefaultValue = false)]
        public Payment Payment { get; set; }

        /// <summary>
        /// Gets or Sets ReceiptOptions
        /// </summary>
        [DataMember(Name = "receiptOptions", EmitDefaultValue = false)]
        public ReceiptOptions ReceiptOptions { get; set; }

        /// <summary>
        /// Gets or Sets ReceiptPrinting
        /// </summary>
        [DataMember(Name = "receiptPrinting", EmitDefaultValue = false)]
        public ReceiptPrinting ReceiptPrinting { get; set; }

        /// <summary>
        /// Gets or Sets Signature
        /// </summary>
        [DataMember(Name = "signature", EmitDefaultValue = false)]
        public Signature Signature { get; set; }

        /// <summary>
        /// Gets or Sets Standalone
        /// </summary>
        [DataMember(Name = "standalone", EmitDefaultValue = false)]
        public Standalone Standalone { get; set; }

        /// <summary>
        /// Gets or Sets Surcharge
        /// </summary>
        [DataMember(Name = "surcharge", EmitDefaultValue = false)]
        public Surcharge Surcharge { get; set; }

        /// <summary>
        /// Gets or Sets Timeouts
        /// </summary>
        [DataMember(Name = "timeouts", EmitDefaultValue = false)]
        public Timeouts Timeouts { get; set; }

        /// <summary>
        /// Gets or Sets WifiProfiles
        /// </summary>
        [DataMember(Name = "wifiProfiles", EmitDefaultValue = false)]
        public WifiProfiles WifiProfiles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TerminalSettings {\n");
            sb.Append("  CardholderReceipt: ").Append(CardholderReceipt).Append("\n");
            sb.Append("  Connectivity: ").Append(Connectivity).Append("\n");
            sb.Append("  Gratuities: ").Append(Gratuities).Append("\n");
            sb.Append("  Hardware: ").Append(Hardware).Append("\n");
            sb.Append("  Localization: ").Append(Localization).Append("\n");
            sb.Append("  Nexo: ").Append(Nexo).Append("\n");
            sb.Append("  OfflineProcessing: ").Append(OfflineProcessing).Append("\n");
            sb.Append("  Opi: ").Append(Opi).Append("\n");
            sb.Append("  Passcodes: ").Append(Passcodes).Append("\n");
            sb.Append("  PayAtTable: ").Append(PayAtTable).Append("\n");
            sb.Append("  Payment: ").Append(Payment).Append("\n");
            sb.Append("  ReceiptOptions: ").Append(ReceiptOptions).Append("\n");
            sb.Append("  ReceiptPrinting: ").Append(ReceiptPrinting).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  Standalone: ").Append(Standalone).Append("\n");
            sb.Append("  Surcharge: ").Append(Surcharge).Append("\n");
            sb.Append("  Timeouts: ").Append(Timeouts).Append("\n");
            sb.Append("  WifiProfiles: ").Append(WifiProfiles).Append("\n");
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
            return this.Equals(input as TerminalSettings);
        }

        /// <summary>
        /// Returns true if TerminalSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of TerminalSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TerminalSettings input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CardholderReceipt == input.CardholderReceipt ||
                    (this.CardholderReceipt != null &&
                    this.CardholderReceipt.Equals(input.CardholderReceipt))
                ) && 
                (
                    this.Connectivity == input.Connectivity ||
                    (this.Connectivity != null &&
                    this.Connectivity.Equals(input.Connectivity))
                ) && 
                (
                    this.Gratuities == input.Gratuities ||
                    this.Gratuities != null &&
                    input.Gratuities != null &&
                    this.Gratuities.SequenceEqual(input.Gratuities)
                ) && 
                (
                    this.Hardware == input.Hardware ||
                    (this.Hardware != null &&
                    this.Hardware.Equals(input.Hardware))
                ) && 
                (
                    this.Localization == input.Localization ||
                    (this.Localization != null &&
                    this.Localization.Equals(input.Localization))
                ) && 
                (
                    this.Nexo == input.Nexo ||
                    (this.Nexo != null &&
                    this.Nexo.Equals(input.Nexo))
                ) && 
                (
                    this.OfflineProcessing == input.OfflineProcessing ||
                    (this.OfflineProcessing != null &&
                    this.OfflineProcessing.Equals(input.OfflineProcessing))
                ) && 
                (
                    this.Opi == input.Opi ||
                    (this.Opi != null &&
                    this.Opi.Equals(input.Opi))
                ) && 
                (
                    this.Passcodes == input.Passcodes ||
                    (this.Passcodes != null &&
                    this.Passcodes.Equals(input.Passcodes))
                ) && 
                (
                    this.PayAtTable == input.PayAtTable ||
                    (this.PayAtTable != null &&
                    this.PayAtTable.Equals(input.PayAtTable))
                ) && 
                (
                    this.Payment == input.Payment ||
                    (this.Payment != null &&
                    this.Payment.Equals(input.Payment))
                ) && 
                (
                    this.ReceiptOptions == input.ReceiptOptions ||
                    (this.ReceiptOptions != null &&
                    this.ReceiptOptions.Equals(input.ReceiptOptions))
                ) && 
                (
                    this.ReceiptPrinting == input.ReceiptPrinting ||
                    (this.ReceiptPrinting != null &&
                    this.ReceiptPrinting.Equals(input.ReceiptPrinting))
                ) && 
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
                ) && 
                (
                    this.Standalone == input.Standalone ||
                    (this.Standalone != null &&
                    this.Standalone.Equals(input.Standalone))
                ) && 
                (
                    this.Surcharge == input.Surcharge ||
                    (this.Surcharge != null &&
                    this.Surcharge.Equals(input.Surcharge))
                ) && 
                (
                    this.Timeouts == input.Timeouts ||
                    (this.Timeouts != null &&
                    this.Timeouts.Equals(input.Timeouts))
                ) && 
                (
                    this.WifiProfiles == input.WifiProfiles ||
                    (this.WifiProfiles != null &&
                    this.WifiProfiles.Equals(input.WifiProfiles))
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
                if (this.CardholderReceipt != null)
                {
                    hashCode = (hashCode * 59) + this.CardholderReceipt.GetHashCode();
                }
                if (this.Connectivity != null)
                {
                    hashCode = (hashCode * 59) + this.Connectivity.GetHashCode();
                }
                if (this.Gratuities != null)
                {
                    hashCode = (hashCode * 59) + this.Gratuities.GetHashCode();
                }
                if (this.Hardware != null)
                {
                    hashCode = (hashCode * 59) + this.Hardware.GetHashCode();
                }
                if (this.Localization != null)
                {
                    hashCode = (hashCode * 59) + this.Localization.GetHashCode();
                }
                if (this.Nexo != null)
                {
                    hashCode = (hashCode * 59) + this.Nexo.GetHashCode();
                }
                if (this.OfflineProcessing != null)
                {
                    hashCode = (hashCode * 59) + this.OfflineProcessing.GetHashCode();
                }
                if (this.Opi != null)
                {
                    hashCode = (hashCode * 59) + this.Opi.GetHashCode();
                }
                if (this.Passcodes != null)
                {
                    hashCode = (hashCode * 59) + this.Passcodes.GetHashCode();
                }
                if (this.PayAtTable != null)
                {
                    hashCode = (hashCode * 59) + this.PayAtTable.GetHashCode();
                }
                if (this.Payment != null)
                {
                    hashCode = (hashCode * 59) + this.Payment.GetHashCode();
                }
                if (this.ReceiptOptions != null)
                {
                    hashCode = (hashCode * 59) + this.ReceiptOptions.GetHashCode();
                }
                if (this.ReceiptPrinting != null)
                {
                    hashCode = (hashCode * 59) + this.ReceiptPrinting.GetHashCode();
                }
                if (this.Signature != null)
                {
                    hashCode = (hashCode * 59) + this.Signature.GetHashCode();
                }
                if (this.Standalone != null)
                {
                    hashCode = (hashCode * 59) + this.Standalone.GetHashCode();
                }
                if (this.Surcharge != null)
                {
                    hashCode = (hashCode * 59) + this.Surcharge.GetHashCode();
                }
                if (this.Timeouts != null)
                {
                    hashCode = (hashCode * 59) + this.Timeouts.GetHashCode();
                }
                if (this.WifiProfiles != null)
                {
                    hashCode = (hashCode * 59) + this.WifiProfiles.GetHashCode();
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
