/*
* Legal Entity Management API
*
*
* The version of the OpenAPI document: 3
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
using System.Reflection;

namespace Adyen.Model.LegalEntityManagement
{
    /// <summary>
    /// Identification of the bank account.
    /// </summary>
    [JsonConverter(typeof(BankAccountInfoAccountIdentificationJsonConverter))]
    [DataContract(Name = "BankAccountInfo_accountIdentification")]
    public partial class BankAccountInfoAccountIdentification : AbstractOpenAPISchema, IEquatable<BankAccountInfoAccountIdentification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountInfoAccountIdentification" /> class
        /// with the <see cref="AULocalAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AULocalAccountIdentification.</param>
        public BankAccountInfoAccountIdentification(AULocalAccountIdentification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountInfoAccountIdentification" /> class
        /// with the <see cref="CALocalAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CALocalAccountIdentification.</param>
        public BankAccountInfoAccountIdentification(CALocalAccountIdentification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountInfoAccountIdentification" /> class
        /// with the <see cref="CZLocalAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CZLocalAccountIdentification.</param>
        public BankAccountInfoAccountIdentification(CZLocalAccountIdentification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountInfoAccountIdentification" /> class
        /// with the <see cref="DKLocalAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DKLocalAccountIdentification.</param>
        public BankAccountInfoAccountIdentification(DKLocalAccountIdentification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountInfoAccountIdentification" /> class
        /// with the <see cref="HULocalAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of HULocalAccountIdentification.</param>
        public BankAccountInfoAccountIdentification(HULocalAccountIdentification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountInfoAccountIdentification" /> class
        /// with the <see cref="IbanAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of IbanAccountIdentification.</param>
        public BankAccountInfoAccountIdentification(IbanAccountIdentification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountInfoAccountIdentification" /> class
        /// with the <see cref="NOLocalAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NOLocalAccountIdentification.</param>
        public BankAccountInfoAccountIdentification(NOLocalAccountIdentification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountInfoAccountIdentification" /> class
        /// with the <see cref="NumberAndBicAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NumberAndBicAccountIdentification.</param>
        public BankAccountInfoAccountIdentification(NumberAndBicAccountIdentification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountInfoAccountIdentification" /> class
        /// with the <see cref="PLLocalAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PLLocalAccountIdentification.</param>
        public BankAccountInfoAccountIdentification(PLLocalAccountIdentification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountInfoAccountIdentification" /> class
        /// with the <see cref="SELocalAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SELocalAccountIdentification.</param>
        public BankAccountInfoAccountIdentification(SELocalAccountIdentification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountInfoAccountIdentification" /> class
        /// with the <see cref="UKLocalAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UKLocalAccountIdentification.</param>
        public BankAccountInfoAccountIdentification(UKLocalAccountIdentification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountInfoAccountIdentification" /> class
        /// with the <see cref="USLocalAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of USLocalAccountIdentification.</param>
        public BankAccountInfoAccountIdentification(USLocalAccountIdentification actualInstance)
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
                    throw new ArgumentException("Invalid instance found. Must be the following types: AULocalAccountIdentification, CALocalAccountIdentification, CZLocalAccountIdentification, DKLocalAccountIdentification, HULocalAccountIdentification, IbanAccountIdentification, NOLocalAccountIdentification, NumberAndBicAccountIdentification, PLLocalAccountIdentification, SELocalAccountIdentification, UKLocalAccountIdentification, USLocalAccountIdentification");
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
            sb.Append("class BankAccountInfoAccountIdentification {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, BankAccountInfoAccountIdentification.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of BankAccountInfoAccountIdentification
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of BankAccountInfoAccountIdentification</returns>
        public static BankAccountInfoAccountIdentification FromJson(string jsonString)
        {
            BankAccountInfoAccountIdentification newBankAccountInfoAccountIdentification = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newBankAccountInfoAccountIdentification;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();
            var type = (string)JObject.Parse(jsonString)["type"];

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AULocalAccountIdentification).GetProperty("AdditionalProperties") == null)
                {
                    newBankAccountInfoAccountIdentification = new BankAccountInfoAccountIdentification(JsonConvert.DeserializeObject<AULocalAccountIdentification>(jsonString, BankAccountInfoAccountIdentification.SerializerSettings));
                }
                else
                {
                    newBankAccountInfoAccountIdentification = new BankAccountInfoAccountIdentification(JsonConvert.DeserializeObject<AULocalAccountIdentification>(jsonString, BankAccountInfoAccountIdentification.AdditionalPropertiesSerializerSettings));
                }
                if (type != null || JsonConvert.SerializeObject((AULocalAccountIdentification.TypeEnum) 1).Contains(type))
                {
                    matchedTypes.Add("AULocalAccountIdentification");
                    match++;
                }
            }
            catch (Exception ex)
            {
                if (!(ex is JsonSerializationException))
                {
                    throw new Exception(string.Format("Failed to deserialize `{0}` into CheckoutThreeDS2Action: {1}", jsonString, ex.ToString()));
                }
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(CALocalAccountIdentification).GetProperty("AdditionalProperties") == null)
                {
                    newBankAccountInfoAccountIdentification = new BankAccountInfoAccountIdentification(JsonConvert.DeserializeObject<CALocalAccountIdentification>(jsonString, BankAccountInfoAccountIdentification.SerializerSettings));
                }
                else
                {
                    newBankAccountInfoAccountIdentification = new BankAccountInfoAccountIdentification(JsonConvert.DeserializeObject<CALocalAccountIdentification>(jsonString, BankAccountInfoAccountIdentification.AdditionalPropertiesSerializerSettings));
                }
                if (type != null || JsonConvert.SerializeObject((CALocalAccountIdentification.TypeEnum) 1).Contains(type))
                {
                    matchedTypes.Add("CALocalAccountIdentification");
                    match++;
                }
            }
            catch (Exception ex)
            {
                if (!(ex is JsonSerializationException))
                {
                    throw new Exception(string.Format("Failed to deserialize `{0}` into CheckoutThreeDS2Action: {1}", jsonString, ex.ToString()));
                }
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(CZLocalAccountIdentification).GetProperty("AdditionalProperties") == null)
                {
                    newBankAccountInfoAccountIdentification = new BankAccountInfoAccountIdentification(JsonConvert.DeserializeObject<CZLocalAccountIdentification>(jsonString, BankAccountInfoAccountIdentification.SerializerSettings));
                }
                else
                {
                    newBankAccountInfoAccountIdentification = new BankAccountInfoAccountIdentification(JsonConvert.DeserializeObject<CZLocalAccountIdentification>(jsonString, BankAccountInfoAccountIdentification.AdditionalPropertiesSerializerSettings));
                }
                if (type != null || JsonConvert.SerializeObject((CZLocalAccountIdentification.TypeEnum) 1).Contains(type))
                {
                    matchedTypes.Add("CZLocalAccountIdentification");
                    match++;
                }
            }
            catch (Exception ex)
            {
                if (!(ex is JsonSerializationException))
                {
                    throw new Exception(string.Format("Failed to deserialize `{0}` into CheckoutThreeDS2Action: {1}", jsonString, ex.ToString()));
                }
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(DKLocalAccountIdentification).GetProperty("AdditionalProperties") == null)
                {
                    newBankAccountInfoAccountIdentification = new BankAccountInfoAccountIdentification(JsonConvert.DeserializeObject<DKLocalAccountIdentification>(jsonString, BankAccountInfoAccountIdentification.SerializerSettings));
                }
                else
                {
                    newBankAccountInfoAccountIdentification = new BankAccountInfoAccountIdentification(JsonConvert.DeserializeObject<DKLocalAccountIdentification>(jsonString, BankAccountInfoAccountIdentification.AdditionalPropertiesSerializerSettings));
                }
                if (type != null || JsonConvert.SerializeObject((DKLocalAccountIdentification.TypeEnum) 1).Contains(type))
                {
                    matchedTypes.Add("DKLocalAccountIdentification");
                    match++;
                }
            }
            catch (Exception ex)
            {
                if (!(ex is JsonSerializationException))
                {
                    throw new Exception(string.Format("Failed to deserialize `{0}` into CheckoutThreeDS2Action: {1}", jsonString, ex.ToString()));
                }
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(HULocalAccountIdentification).GetProperty("AdditionalProperties") == null)
                {
                    newBankAccountInfoAccountIdentification = new BankAccountInfoAccountIdentification(JsonConvert.DeserializeObject<HULocalAccountIdentification>(jsonString, BankAccountInfoAccountIdentification.SerializerSettings));
                }
                else
                {
                    newBankAccountInfoAccountIdentification = new BankAccountInfoAccountIdentification(JsonConvert.DeserializeObject<HULocalAccountIdentification>(jsonString, BankAccountInfoAccountIdentification.AdditionalPropertiesSerializerSettings));
                }
                if (type != null || JsonConvert.SerializeObject((HULocalAccountIdentification.TypeEnum) 1).Contains(type))
                {
                    matchedTypes.Add("HULocalAccountIdentification");
                    match++;
                }
            }
            catch (Exception ex)
            {
                if (!(ex is JsonSerializationException))
                {
                    throw new Exception(string.Format("Failed to deserialize `{0}` into CheckoutThreeDS2Action: {1}", jsonString, ex.ToString()));
                }
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(IbanAccountIdentification).GetProperty("AdditionalProperties") == null)
                {
                    newBankAccountInfoAccountIdentification = new BankAccountInfoAccountIdentification(JsonConvert.DeserializeObject<IbanAccountIdentification>(jsonString, BankAccountInfoAccountIdentification.SerializerSettings));
                }
                else
                {
                    newBankAccountInfoAccountIdentification = new BankAccountInfoAccountIdentification(JsonConvert.DeserializeObject<IbanAccountIdentification>(jsonString, BankAccountInfoAccountIdentification.AdditionalPropertiesSerializerSettings));
                }
                if (type != null || JsonConvert.SerializeObject((IbanAccountIdentification.TypeEnum) 1).Contains(type))
                {
                    matchedTypes.Add("IbanAccountIdentification");
                    match++;
                }
            }
            catch (Exception ex)
            {
                if (!(ex is JsonSerializationException))
                {
                    throw new Exception(string.Format("Failed to deserialize `{0}` into CheckoutThreeDS2Action: {1}", jsonString, ex.ToString()));
                }
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NOLocalAccountIdentification).GetProperty("AdditionalProperties") == null)
                {
                    newBankAccountInfoAccountIdentification = new BankAccountInfoAccountIdentification(JsonConvert.DeserializeObject<NOLocalAccountIdentification>(jsonString, BankAccountInfoAccountIdentification.SerializerSettings));
                }
                else
                {
                    newBankAccountInfoAccountIdentification = new BankAccountInfoAccountIdentification(JsonConvert.DeserializeObject<NOLocalAccountIdentification>(jsonString, BankAccountInfoAccountIdentification.AdditionalPropertiesSerializerSettings));
                }
                if (type != null || JsonConvert.SerializeObject((NOLocalAccountIdentification.TypeEnum) 1).Contains(type))
                {
                    matchedTypes.Add("NOLocalAccountIdentification");
                    match++;
                }
            }
            catch (Exception ex)
            {
                if (!(ex is JsonSerializationException))
                {
                    throw new Exception(string.Format("Failed to deserialize `{0}` into CheckoutThreeDS2Action: {1}", jsonString, ex.ToString()));
                }
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NumberAndBicAccountIdentification).GetProperty("AdditionalProperties") == null)
                {
                    newBankAccountInfoAccountIdentification = new BankAccountInfoAccountIdentification(JsonConvert.DeserializeObject<NumberAndBicAccountIdentification>(jsonString, BankAccountInfoAccountIdentification.SerializerSettings));
                }
                else
                {
                    newBankAccountInfoAccountIdentification = new BankAccountInfoAccountIdentification(JsonConvert.DeserializeObject<NumberAndBicAccountIdentification>(jsonString, BankAccountInfoAccountIdentification.AdditionalPropertiesSerializerSettings));
                }
                if (type != null || JsonConvert.SerializeObject((NumberAndBicAccountIdentification.TypeEnum) 1).Contains(type))
                {
                    matchedTypes.Add("NumberAndBicAccountIdentification");
                    match++;
                }
            }
            catch (Exception ex)
            {
                if (!(ex is JsonSerializationException))
                {
                    throw new Exception(string.Format("Failed to deserialize `{0}` into CheckoutThreeDS2Action: {1}", jsonString, ex.ToString()));
                }
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(PLLocalAccountIdentification).GetProperty("AdditionalProperties") == null)
                {
                    newBankAccountInfoAccountIdentification = new BankAccountInfoAccountIdentification(JsonConvert.DeserializeObject<PLLocalAccountIdentification>(jsonString, BankAccountInfoAccountIdentification.SerializerSettings));
                }
                else
                {
                    newBankAccountInfoAccountIdentification = new BankAccountInfoAccountIdentification(JsonConvert.DeserializeObject<PLLocalAccountIdentification>(jsonString, BankAccountInfoAccountIdentification.AdditionalPropertiesSerializerSettings));
                }
                if (type != null || JsonConvert.SerializeObject((PLLocalAccountIdentification.TypeEnum) 1).Contains(type))
                {
                    matchedTypes.Add("PLLocalAccountIdentification");
                    match++;
                }
            }
            catch (Exception ex)
            {
                if (!(ex is JsonSerializationException))
                {
                    throw new Exception(string.Format("Failed to deserialize `{0}` into CheckoutThreeDS2Action: {1}", jsonString, ex.ToString()));
                }
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SELocalAccountIdentification).GetProperty("AdditionalProperties") == null)
                {
                    newBankAccountInfoAccountIdentification = new BankAccountInfoAccountIdentification(JsonConvert.DeserializeObject<SELocalAccountIdentification>(jsonString, BankAccountInfoAccountIdentification.SerializerSettings));
                }
                else
                {
                    newBankAccountInfoAccountIdentification = new BankAccountInfoAccountIdentification(JsonConvert.DeserializeObject<SELocalAccountIdentification>(jsonString, BankAccountInfoAccountIdentification.AdditionalPropertiesSerializerSettings));
                }
                if (type != null || JsonConvert.SerializeObject((SELocalAccountIdentification.TypeEnum) 1).Contains(type))
                {
                    matchedTypes.Add("SELocalAccountIdentification");
                    match++;
                }
            }
            catch (Exception ex)
            {
                if (!(ex is JsonSerializationException))
                {
                    throw new Exception(string.Format("Failed to deserialize `{0}` into CheckoutThreeDS2Action: {1}", jsonString, ex.ToString()));
                }
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UKLocalAccountIdentification).GetProperty("AdditionalProperties") == null)
                {
                    newBankAccountInfoAccountIdentification = new BankAccountInfoAccountIdentification(JsonConvert.DeserializeObject<UKLocalAccountIdentification>(jsonString, BankAccountInfoAccountIdentification.SerializerSettings));
                }
                else
                {
                    newBankAccountInfoAccountIdentification = new BankAccountInfoAccountIdentification(JsonConvert.DeserializeObject<UKLocalAccountIdentification>(jsonString, BankAccountInfoAccountIdentification.AdditionalPropertiesSerializerSettings));
                }
                if (type != null || JsonConvert.SerializeObject((UKLocalAccountIdentification.TypeEnum) 1).Contains(type))
                {
                    matchedTypes.Add("UKLocalAccountIdentification");
                    match++;
                }
            }
            catch (Exception ex)
            {
                if (!(ex is JsonSerializationException))
                {
                    throw new Exception(string.Format("Failed to deserialize `{0}` into CheckoutThreeDS2Action: {1}", jsonString, ex.ToString()));
                }
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(USLocalAccountIdentification).GetProperty("AdditionalProperties") == null)
                {
                    newBankAccountInfoAccountIdentification = new BankAccountInfoAccountIdentification(JsonConvert.DeserializeObject<USLocalAccountIdentification>(jsonString, BankAccountInfoAccountIdentification.SerializerSettings));
                }
                else
                {
                    newBankAccountInfoAccountIdentification = new BankAccountInfoAccountIdentification(JsonConvert.DeserializeObject<USLocalAccountIdentification>(jsonString, BankAccountInfoAccountIdentification.AdditionalPropertiesSerializerSettings));
                }
                if (type != null || JsonConvert.SerializeObject((USLocalAccountIdentification.TypeEnum) 1).Contains(type))
                {
                    matchedTypes.Add("USLocalAccountIdentification");
                    match++;
                }
            }
            catch (Exception ex)
            {
                if (!(ex is JsonSerializationException))
                {
                    throw new Exception(string.Format("Failed to deserialize `{0}` into CheckoutThreeDS2Action: {1}", jsonString, ex.ToString()));
                }
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            
            // deserialization is considered successful at this point if no exception has been thrown.
            return newBankAccountInfoAccountIdentification;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BankAccountInfoAccountIdentification);
        }

        /// <summary>
        /// Returns true if BankAccountInfoAccountIdentification instances are equal
        /// </summary>
        /// <param name="input">Instance of BankAccountInfoAccountIdentification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankAccountInfoAccountIdentification input)
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
    /// Custom JSON converter for BankAccountInfoAccountIdentification
    /// </summary>
    public class BankAccountInfoAccountIdentificationJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(BankAccountInfoAccountIdentification).GetMethod("ToJson").Invoke(value, null)));
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
                return BankAccountInfoAccountIdentification.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
