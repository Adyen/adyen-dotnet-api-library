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

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.BinLookup
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class ThreeDSAvailabilityResponse
    {
        /// <summary>
        /// Gets or Sets BinDetails
        /// </summary>
        [DataMember(Name = "binDetails", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "binDetails")]
        public BinDetail BinDetails { get; set; }

        /// <summary>
        /// List of Directory Server (DS) public keys.
        /// </summary>
        /// <value>List of Directory Server (DS) public keys.</value>
        [DataMember(Name = "dsPublicKeys", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dsPublicKeys")]
        public List<DSPublicKeyDetail> DsPublicKeys { get; set; }

        /// <summary>
        /// Indicator if 3D Secure 1 is supported.
        /// </summary>
        /// <value>Indicator if 3D Secure 1 is supported.</value>
        [DataMember(Name = "threeDS1Supported", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "threeDS1Supported")]
        public bool? ThreeDS1Supported { get; set; }

        /// <summary>
        /// List of brand and card range pairs.
        /// </summary>
        /// <value>List of brand and card range pairs.</value>
        [DataMember(Name = "threeDS2CardRangeDetails", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "threeDS2CardRangeDetails")]
        public List<ThreeDS2CardRangeDetail> ThreeDS2CardRangeDetails { get; set; }

        /// <summary>
        /// Indicator if 3D Secure 2 is supported.
        /// </summary>
        /// <value>Indicator if 3D Secure 2 is supported.</value>
        [DataMember(Name = "threeDS2supported", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "threeDS2supported")]
        public bool? ThreeDS2supported { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThreeDSAvailabilityResponse {\n");
            sb.Append("  BinDetails: ").Append(BinDetails).Append("\n");
            sb.Append("  DsPublicKeys: ").Append(DsPublicKeys).Append("\n");
            sb.Append("  ThreeDS1Supported: ").Append(ThreeDS1Supported).Append("\n");
            sb.Append("  ThreeDS2CardRangeDetails: ").Append(ThreeDS2CardRangeDetails).Append("\n");
            sb.Append("  ThreeDS2supported: ").Append(ThreeDS2supported).Append("\n");
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
