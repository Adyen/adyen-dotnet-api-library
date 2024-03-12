/*
* Configuration webhooks
*
*
* The version of the OpenAPI document: 1
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

namespace Adyen.Model.ConfigurationWebhooks
{
    /// <summary>
    /// PaymentInstrumentAdditionalBankAccountIdentificationsInner
    /// </summary>
    [JsonConverter(typeof(PaymentInstrumentAdditionalBankAccountIdentificationsInnerJsonConverter))]
    [DataContract(Name = "PaymentInstrument_additionalBankAccountIdentifications_inner")]
    public partial class PaymentInstrumentAdditionalBankAccountIdentificationsInner : AbstractOpenAPISchema, IEquatable<PaymentInstrumentAdditionalBankAccountIdentificationsInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInstrumentAdditionalBankAccountIdentificationsInner" /> class
        /// with the <see cref="IbanAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of IbanAccountIdentification.</param>
        public PaymentInstrumentAdditionalBankAccountIdentificationsInner(IbanAccountIdentification actualInstance)
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
                if (value.GetType() == typeof(IbanAccountIdentification))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: IbanAccountIdentification");
                }
            }
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentInstrumentAdditionalBankAccountIdentificationsInner {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, PaymentInstrumentAdditionalBankAccountIdentificationsInner.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of PaymentInstrumentAdditionalBankAccountIdentificationsInner
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of PaymentInstrumentAdditionalBankAccountIdentificationsInner</returns>
        public static PaymentInstrumentAdditionalBankAccountIdentificationsInner FromJson(string jsonString)
        {
            PaymentInstrumentAdditionalBankAccountIdentificationsInner newPaymentInstrumentAdditionalBankAccountIdentificationsInner = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newPaymentInstrumentAdditionalBankAccountIdentificationsInner;
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
                // Check if the jsonString type enum matches the IbanAccountIdentification type enums
                if (ContainsValue<IbanAccountIdentification.TypeEnum>(type))
                {
                    newPaymentInstrumentAdditionalBankAccountIdentificationsInner = new PaymentInstrumentAdditionalBankAccountIdentificationsInner(JsonConvert.DeserializeObject<IbanAccountIdentification>(jsonString, PaymentInstrumentAdditionalBankAccountIdentificationsInner.SerializerSettings));
                    matchedTypes.Add("IbanAccountIdentification");
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
            return newPaymentInstrumentAdditionalBankAccountIdentificationsInner;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PaymentInstrumentAdditionalBankAccountIdentificationsInner);
        }

        /// <summary>
        /// Returns true if PaymentInstrumentAdditionalBankAccountIdentificationsInner instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentInstrumentAdditionalBankAccountIdentificationsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentInstrumentAdditionalBankAccountIdentificationsInner input)
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
    /// Custom JSON converter for PaymentInstrumentAdditionalBankAccountIdentificationsInner
    /// </summary>
    public class PaymentInstrumentAdditionalBankAccountIdentificationsInnerJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(PaymentInstrumentAdditionalBankAccountIdentificationsInner).GetMethod("ToJson").Invoke(value, null)));
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
                return PaymentInstrumentAdditionalBankAccountIdentificationsInner.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
