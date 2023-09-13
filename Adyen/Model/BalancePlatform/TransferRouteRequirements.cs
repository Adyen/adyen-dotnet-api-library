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
    /// A set of rules defined by clearing houses and banking partners. Your transfer request must adhere to these rules to ensure successful initiation of transfer. Based on the priority, one or more requirements may be returned. Each requirement is defined with a &#x60;type&#x60; and &#x60;description&#x60;.
    /// </summary>
    [JsonConverter(typeof(TransferRouteRequirementsJsonConverter))]
    [DataContract(Name = "TransferRoute_requirements")]
    public partial class TransferRouteRequirements : AbstractOpenAPISchema, IEquatable<TransferRouteRequirements>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferRouteRequirements" /> class
        /// with the <see cref="AddressRequirement" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AddressRequirement.</param>
        public TransferRouteRequirements(AddressRequirement actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferRouteRequirements" /> class
        /// with the <see cref="AmountMinMaxRequirement" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AmountMinMaxRequirement.</param>
        public TransferRouteRequirements(AmountMinMaxRequirement actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferRouteRequirements" /> class
        /// with the <see cref="BankAccountIdentificationTypeRequirement" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of BankAccountIdentificationTypeRequirement.</param>
        public TransferRouteRequirements(BankAccountIdentificationTypeRequirement actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferRouteRequirements" /> class
        /// with the <see cref="PaymentInstrumentRequirement" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PaymentInstrumentRequirement.</param>
        public TransferRouteRequirements(PaymentInstrumentRequirement actualInstance)
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
                if (value.GetType() == typeof(AddressRequirement))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AmountMinMaxRequirement))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(BankAccountIdentificationTypeRequirement))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(PaymentInstrumentRequirement))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AddressRequirement, AmountMinMaxRequirement, BankAccountIdentificationTypeRequirement, PaymentInstrumentRequirement");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AddressRequirement`. If the actual instance is not `AddressRequirement`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AddressRequirement</returns>
        public AddressRequirement GetAddressRequirement()
        {
            return (AddressRequirement)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AmountMinMaxRequirement`. If the actual instance is not `AmountMinMaxRequirement`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AmountMinMaxRequirement</returns>
        public AmountMinMaxRequirement GetAmountMinMaxRequirement()
        {
            return (AmountMinMaxRequirement)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `BankAccountIdentificationTypeRequirement`. If the actual instance is not `BankAccountIdentificationTypeRequirement`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of BankAccountIdentificationTypeRequirement</returns>
        public BankAccountIdentificationTypeRequirement GetBankAccountIdentificationTypeRequirement()
        {
            return (BankAccountIdentificationTypeRequirement)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `PaymentInstrumentRequirement`. If the actual instance is not `PaymentInstrumentRequirement`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PaymentInstrumentRequirement</returns>
        public PaymentInstrumentRequirement GetPaymentInstrumentRequirement()
        {
            return (PaymentInstrumentRequirement)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferRouteRequirements {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, TransferRouteRequirements.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of TransferRouteRequirements
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of TransferRouteRequirements</returns>
        public static TransferRouteRequirements FromJson(string jsonString)
        {
            TransferRouteRequirements newTransferRouteRequirements = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newTransferRouteRequirements;
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
                // Check if the jsonString type enum matches the AddressRequirement type enums
                if (ContainsValue<AddressRequirement.TypeEnum>(type))
                {
                    newTransferRouteRequirements = new TransferRouteRequirements(JsonConvert.DeserializeObject<AddressRequirement>(jsonString, TransferRouteRequirements.SerializerSettings));
                    matchedTypes.Add("AddressRequirement");
                    match++;
                }
                // Check if the jsonString type enum matches the AmountMinMaxRequirement type enums
                if (ContainsValue<AmountMinMaxRequirement.TypeEnum>(type))
                {
                    newTransferRouteRequirements = new TransferRouteRequirements(JsonConvert.DeserializeObject<AmountMinMaxRequirement>(jsonString, TransferRouteRequirements.SerializerSettings));
                    matchedTypes.Add("AmountMinMaxRequirement");
                    match++;
                }
                // Check if the jsonString type enum matches the BankAccountIdentificationTypeRequirement type enums
                if (ContainsValue<BankAccountIdentificationTypeRequirement.TypeEnum>(type))
                {
                    newTransferRouteRequirements = new TransferRouteRequirements(JsonConvert.DeserializeObject<BankAccountIdentificationTypeRequirement>(jsonString, TransferRouteRequirements.SerializerSettings));
                    matchedTypes.Add("BankAccountIdentificationTypeRequirement");
                    match++;
                }
                // Check if the jsonString type enum matches the PaymentInstrumentRequirement type enums
                if (ContainsValue<PaymentInstrumentRequirement.TypeEnum>(type))
                {
                    newTransferRouteRequirements = new TransferRouteRequirements(JsonConvert.DeserializeObject<PaymentInstrumentRequirement>(jsonString, TransferRouteRequirements.SerializerSettings));
                    matchedTypes.Add("PaymentInstrumentRequirement");
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
            return newTransferRouteRequirements;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransferRouteRequirements);
        }

        /// <summary>
        /// Returns true if TransferRouteRequirements instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferRouteRequirements to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferRouteRequirements input)
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
    /// Custom JSON converter for TransferRouteRequirements
    /// </summary>
    public class TransferRouteRequirementsJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(TransferRouteRequirements).GetMethod("ToJson").Invoke(value, null)));
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
                return TransferRouteRequirements.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
