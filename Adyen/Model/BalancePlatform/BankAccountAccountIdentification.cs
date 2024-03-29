/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
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
using System.Reflection;

namespace Adyen.Model.BalancePlatform
{
    /// <summary>
    /// Contains the bank account details. The fields required in this object depend on the country of the bank account and the currency of the transfer.
    /// </summary>
    [JsonConverter(typeof(BankAccountAccountIdentificationJsonConverter))]
    [DataContract(Name = "BankAccount_accountIdentification")]
    public partial class BankAccountAccountIdentification : AbstractOpenAPISchema, IEquatable<BankAccountAccountIdentification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountAccountIdentification" /> class
        /// with the <see cref="AULocalAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AULocalAccountIdentification.</param>
        public BankAccountAccountIdentification(AULocalAccountIdentification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountAccountIdentification" /> class
        /// with the <see cref="BRLocalAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of BRLocalAccountIdentification.</param>
        public BankAccountAccountIdentification(BRLocalAccountIdentification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountAccountIdentification" /> class
        /// with the <see cref="CALocalAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CALocalAccountIdentification.</param>
        public BankAccountAccountIdentification(CALocalAccountIdentification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountAccountIdentification" /> class
        /// with the <see cref="CZLocalAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CZLocalAccountIdentification.</param>
        public BankAccountAccountIdentification(CZLocalAccountIdentification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountAccountIdentification" /> class
        /// with the <see cref="DKLocalAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DKLocalAccountIdentification.</param>
        public BankAccountAccountIdentification(DKLocalAccountIdentification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountAccountIdentification" /> class
        /// with the <see cref="HKLocalAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of HKLocalAccountIdentification.</param>
        public BankAccountAccountIdentification(HKLocalAccountIdentification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountAccountIdentification" /> class
        /// with the <see cref="HULocalAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of HULocalAccountIdentification.</param>
        public BankAccountAccountIdentification(HULocalAccountIdentification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountAccountIdentification" /> class
        /// with the <see cref="IbanAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of IbanAccountIdentification.</param>
        public BankAccountAccountIdentification(IbanAccountIdentification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountAccountIdentification" /> class
        /// with the <see cref="NOLocalAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NOLocalAccountIdentification.</param>
        public BankAccountAccountIdentification(NOLocalAccountIdentification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountAccountIdentification" /> class
        /// with the <see cref="NZLocalAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NZLocalAccountIdentification.</param>
        public BankAccountAccountIdentification(NZLocalAccountIdentification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountAccountIdentification" /> class
        /// with the <see cref="NumberAndBicAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NumberAndBicAccountIdentification.</param>
        public BankAccountAccountIdentification(NumberAndBicAccountIdentification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountAccountIdentification" /> class
        /// with the <see cref="PLLocalAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PLLocalAccountIdentification.</param>
        public BankAccountAccountIdentification(PLLocalAccountIdentification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountAccountIdentification" /> class
        /// with the <see cref="SELocalAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SELocalAccountIdentification.</param>
        public BankAccountAccountIdentification(SELocalAccountIdentification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountAccountIdentification" /> class
        /// with the <see cref="SGLocalAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SGLocalAccountIdentification.</param>
        public BankAccountAccountIdentification(SGLocalAccountIdentification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountAccountIdentification" /> class
        /// with the <see cref="UKLocalAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UKLocalAccountIdentification.</param>
        public BankAccountAccountIdentification(UKLocalAccountIdentification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountAccountIdentification" /> class
        /// with the <see cref="USLocalAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of USLocalAccountIdentification.</param>
        public BankAccountAccountIdentification(USLocalAccountIdentification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(AULocalAccountIdentification))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(BRLocalAccountIdentification))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(CALocalAccountIdentification))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(CZLocalAccountIdentification))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(DKLocalAccountIdentification))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(HKLocalAccountIdentification))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(HULocalAccountIdentification))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(IbanAccountIdentification))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NOLocalAccountIdentification))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NZLocalAccountIdentification))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NumberAndBicAccountIdentification))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(PLLocalAccountIdentification))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(SELocalAccountIdentification))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(SGLocalAccountIdentification))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(UKLocalAccountIdentification))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(USLocalAccountIdentification))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AULocalAccountIdentification, BRLocalAccountIdentification, CALocalAccountIdentification, CZLocalAccountIdentification, DKLocalAccountIdentification, HKLocalAccountIdentification, HULocalAccountIdentification, IbanAccountIdentification, NOLocalAccountIdentification, NZLocalAccountIdentification, NumberAndBicAccountIdentification, PLLocalAccountIdentification, SELocalAccountIdentification, SGLocalAccountIdentification, UKLocalAccountIdentification, USLocalAccountIdentification");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AULocalAccountIdentification`. If the actual instance is not `AULocalAccountIdentification`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AULocalAccountIdentification</returns>
        public AULocalAccountIdentification GetAULocalAccountIdentification()
        {
            return (AULocalAccountIdentification)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `BRLocalAccountIdentification`. If the actual instance is not `BRLocalAccountIdentification`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of BRLocalAccountIdentification</returns>
        public BRLocalAccountIdentification GetBRLocalAccountIdentification()
        {
            return (BRLocalAccountIdentification)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `CALocalAccountIdentification`. If the actual instance is not `CALocalAccountIdentification`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CALocalAccountIdentification</returns>
        public CALocalAccountIdentification GetCALocalAccountIdentification()
        {
            return (CALocalAccountIdentification)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `CZLocalAccountIdentification`. If the actual instance is not `CZLocalAccountIdentification`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CZLocalAccountIdentification</returns>
        public CZLocalAccountIdentification GetCZLocalAccountIdentification()
        {
            return (CZLocalAccountIdentification)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `DKLocalAccountIdentification`. If the actual instance is not `DKLocalAccountIdentification`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DKLocalAccountIdentification</returns>
        public DKLocalAccountIdentification GetDKLocalAccountIdentification()
        {
            return (DKLocalAccountIdentification)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `HKLocalAccountIdentification`. If the actual instance is not `HKLocalAccountIdentification`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of HKLocalAccountIdentification</returns>
        public HKLocalAccountIdentification GetHKLocalAccountIdentification()
        {
            return (HKLocalAccountIdentification)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `HULocalAccountIdentification`. If the actual instance is not `HULocalAccountIdentification`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of HULocalAccountIdentification</returns>
        public HULocalAccountIdentification GetHULocalAccountIdentification()
        {
            return (HULocalAccountIdentification)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `IbanAccountIdentification`. If the actual instance is not `IbanAccountIdentification`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of IbanAccountIdentification</returns>
        public IbanAccountIdentification GetIbanAccountIdentification()
        {
            return (IbanAccountIdentification)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `NOLocalAccountIdentification`. If the actual instance is not `NOLocalAccountIdentification`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of NOLocalAccountIdentification</returns>
        public NOLocalAccountIdentification GetNOLocalAccountIdentification()
        {
            return (NOLocalAccountIdentification)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `NZLocalAccountIdentification`. If the actual instance is not `NZLocalAccountIdentification`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of NZLocalAccountIdentification</returns>
        public NZLocalAccountIdentification GetNZLocalAccountIdentification()
        {
            return (NZLocalAccountIdentification)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `NumberAndBicAccountIdentification`. If the actual instance is not `NumberAndBicAccountIdentification`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of NumberAndBicAccountIdentification</returns>
        public NumberAndBicAccountIdentification GetNumberAndBicAccountIdentification()
        {
            return (NumberAndBicAccountIdentification)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `PLLocalAccountIdentification`. If the actual instance is not `PLLocalAccountIdentification`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PLLocalAccountIdentification</returns>
        public PLLocalAccountIdentification GetPLLocalAccountIdentification()
        {
            return (PLLocalAccountIdentification)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `SELocalAccountIdentification`. If the actual instance is not `SELocalAccountIdentification`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of SELocalAccountIdentification</returns>
        public SELocalAccountIdentification GetSELocalAccountIdentification()
        {
            return (SELocalAccountIdentification)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `SGLocalAccountIdentification`. If the actual instance is not `SGLocalAccountIdentification`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of SGLocalAccountIdentification</returns>
        public SGLocalAccountIdentification GetSGLocalAccountIdentification()
        {
            return (SGLocalAccountIdentification)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `UKLocalAccountIdentification`. If the actual instance is not `UKLocalAccountIdentification`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UKLocalAccountIdentification</returns>
        public UKLocalAccountIdentification GetUKLocalAccountIdentification()
        {
            return (UKLocalAccountIdentification)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `USLocalAccountIdentification`. If the actual instance is not `USLocalAccountIdentification`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of USLocalAccountIdentification</returns>
        public USLocalAccountIdentification GetUSLocalAccountIdentification()
        {
            return (USLocalAccountIdentification)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankAccountAccountIdentification {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, BankAccountAccountIdentification.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of BankAccountAccountIdentification
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of BankAccountAccountIdentification</returns>
        public static BankAccountAccountIdentification FromJson(string jsonString)
        {
            BankAccountAccountIdentification newBankAccountAccountIdentification = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newBankAccountAccountIdentification;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();
            JToken typeToken = JObject.Parse(jsonString).GetValue("type");
            string type = typeToken?.Value<string>();
            // Throw exception if jsonString does not contain type param
            if (type == null)
            {
                throw new InvalidDataException("JsonString does not contain required enum type for deserialization.");
            }
            try
            {
                // Check if the jsonString type enum matches the AULocalAccountIdentification type enums
                if (ContainsValue<AULocalAccountIdentification.TypeEnum>(type))
                {
                    newBankAccountAccountIdentification = new BankAccountAccountIdentification(JsonConvert.DeserializeObject<AULocalAccountIdentification>(jsonString, BankAccountAccountIdentification.SerializerSettings));
                    matchedTypes.Add("AULocalAccountIdentification");
                    match++;
                }
                // Check if the jsonString type enum matches the BRLocalAccountIdentification type enums
                if (ContainsValue<BRLocalAccountIdentification.TypeEnum>(type))
                {
                    newBankAccountAccountIdentification = new BankAccountAccountIdentification(JsonConvert.DeserializeObject<BRLocalAccountIdentification>(jsonString, BankAccountAccountIdentification.SerializerSettings));
                    matchedTypes.Add("BRLocalAccountIdentification");
                    match++;
                }
                // Check if the jsonString type enum matches the CALocalAccountIdentification type enums
                if (ContainsValue<CALocalAccountIdentification.TypeEnum>(type))
                {
                    newBankAccountAccountIdentification = new BankAccountAccountIdentification(JsonConvert.DeserializeObject<CALocalAccountIdentification>(jsonString, BankAccountAccountIdentification.SerializerSettings));
                    matchedTypes.Add("CALocalAccountIdentification");
                    match++;
                }
                // Check if the jsonString type enum matches the CZLocalAccountIdentification type enums
                if (ContainsValue<CZLocalAccountIdentification.TypeEnum>(type))
                {
                    newBankAccountAccountIdentification = new BankAccountAccountIdentification(JsonConvert.DeserializeObject<CZLocalAccountIdentification>(jsonString, BankAccountAccountIdentification.SerializerSettings));
                    matchedTypes.Add("CZLocalAccountIdentification");
                    match++;
                }
                // Check if the jsonString type enum matches the DKLocalAccountIdentification type enums
                if (ContainsValue<DKLocalAccountIdentification.TypeEnum>(type))
                {
                    newBankAccountAccountIdentification = new BankAccountAccountIdentification(JsonConvert.DeserializeObject<DKLocalAccountIdentification>(jsonString, BankAccountAccountIdentification.SerializerSettings));
                    matchedTypes.Add("DKLocalAccountIdentification");
                    match++;
                }
                // Check if the jsonString type enum matches the HKLocalAccountIdentification type enums
                if (ContainsValue<HKLocalAccountIdentification.TypeEnum>(type))
                {
                    newBankAccountAccountIdentification = new BankAccountAccountIdentification(JsonConvert.DeserializeObject<HKLocalAccountIdentification>(jsonString, BankAccountAccountIdentification.SerializerSettings));
                    matchedTypes.Add("HKLocalAccountIdentification");
                    match++;
                }
                // Check if the jsonString type enum matches the HULocalAccountIdentification type enums
                if (ContainsValue<HULocalAccountIdentification.TypeEnum>(type))
                {
                    newBankAccountAccountIdentification = new BankAccountAccountIdentification(JsonConvert.DeserializeObject<HULocalAccountIdentification>(jsonString, BankAccountAccountIdentification.SerializerSettings));
                    matchedTypes.Add("HULocalAccountIdentification");
                    match++;
                }
                // Check if the jsonString type enum matches the IbanAccountIdentification type enums
                if (ContainsValue<IbanAccountIdentification.TypeEnum>(type))
                {
                    newBankAccountAccountIdentification = new BankAccountAccountIdentification(JsonConvert.DeserializeObject<IbanAccountIdentification>(jsonString, BankAccountAccountIdentification.SerializerSettings));
                    matchedTypes.Add("IbanAccountIdentification");
                    match++;
                }
                // Check if the jsonString type enum matches the NOLocalAccountIdentification type enums
                if (ContainsValue<NOLocalAccountIdentification.TypeEnum>(type))
                {
                    newBankAccountAccountIdentification = new BankAccountAccountIdentification(JsonConvert.DeserializeObject<NOLocalAccountIdentification>(jsonString, BankAccountAccountIdentification.SerializerSettings));
                    matchedTypes.Add("NOLocalAccountIdentification");
                    match++;
                }
                // Check if the jsonString type enum matches the NZLocalAccountIdentification type enums
                if (ContainsValue<NZLocalAccountIdentification.TypeEnum>(type))
                {
                    newBankAccountAccountIdentification = new BankAccountAccountIdentification(JsonConvert.DeserializeObject<NZLocalAccountIdentification>(jsonString, BankAccountAccountIdentification.SerializerSettings));
                    matchedTypes.Add("NZLocalAccountIdentification");
                    match++;
                }
                // Check if the jsonString type enum matches the NumberAndBicAccountIdentification type enums
                if (ContainsValue<NumberAndBicAccountIdentification.TypeEnum>(type))
                {
                    newBankAccountAccountIdentification = new BankAccountAccountIdentification(JsonConvert.DeserializeObject<NumberAndBicAccountIdentification>(jsonString, BankAccountAccountIdentification.SerializerSettings));
                    matchedTypes.Add("NumberAndBicAccountIdentification");
                    match++;
                }
                // Check if the jsonString type enum matches the PLLocalAccountIdentification type enums
                if (ContainsValue<PLLocalAccountIdentification.TypeEnum>(type))
                {
                    newBankAccountAccountIdentification = new BankAccountAccountIdentification(JsonConvert.DeserializeObject<PLLocalAccountIdentification>(jsonString, BankAccountAccountIdentification.SerializerSettings));
                    matchedTypes.Add("PLLocalAccountIdentification");
                    match++;
                }
                // Check if the jsonString type enum matches the SELocalAccountIdentification type enums
                if (ContainsValue<SELocalAccountIdentification.TypeEnum>(type))
                {
                    newBankAccountAccountIdentification = new BankAccountAccountIdentification(JsonConvert.DeserializeObject<SELocalAccountIdentification>(jsonString, BankAccountAccountIdentification.SerializerSettings));
                    matchedTypes.Add("SELocalAccountIdentification");
                    match++;
                }
                // Check if the jsonString type enum matches the SGLocalAccountIdentification type enums
                if (ContainsValue<SGLocalAccountIdentification.TypeEnum>(type))
                {
                    newBankAccountAccountIdentification = new BankAccountAccountIdentification(JsonConvert.DeserializeObject<SGLocalAccountIdentification>(jsonString, BankAccountAccountIdentification.SerializerSettings));
                    matchedTypes.Add("SGLocalAccountIdentification");
                    match++;
                }
                // Check if the jsonString type enum matches the UKLocalAccountIdentification type enums
                if (ContainsValue<UKLocalAccountIdentification.TypeEnum>(type))
                {
                    newBankAccountAccountIdentification = new BankAccountAccountIdentification(JsonConvert.DeserializeObject<UKLocalAccountIdentification>(jsonString, BankAccountAccountIdentification.SerializerSettings));
                    matchedTypes.Add("UKLocalAccountIdentification");
                    match++;
                }
                // Check if the jsonString type enum matches the USLocalAccountIdentification type enums
                if (ContainsValue<USLocalAccountIdentification.TypeEnum>(type))
                {
                    newBankAccountAccountIdentification = new BankAccountAccountIdentification(JsonConvert.DeserializeObject<USLocalAccountIdentification>(jsonString, BankAccountAccountIdentification.SerializerSettings));
                    matchedTypes.Add("USLocalAccountIdentification");
                    match++;
                }
            } 
            catch (Exception ex)
            {
                if (!(ex is JsonSerializationException))
                {
                     throw new InvalidDataException(string.Format("Failed to deserialize `{0}` into target: {1}", jsonString, ex.ToString()));
                }
            }

            if (match != 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined. MatchedTypes are: " + matchedTypes);
            }
            
            // deserialization is considered successful at this point if no exception has been thrown.
            return newBankAccountAccountIdentification;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BankAccountAccountIdentification);
        }

        /// <summary>
        /// Returns true if BankAccountAccountIdentification instances are equal
        /// </summary>
        /// <param name="input">Instance of BankAccountAccountIdentification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankAccountAccountIdentification input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
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

    /// <summary>
    /// Custom JSON converter for BankAccountAccountIdentification
    /// </summary>
    public class BankAccountAccountIdentificationJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(BankAccountAccountIdentification).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return BankAccountAccountIdentification.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
