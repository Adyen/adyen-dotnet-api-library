/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 69
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
using System.Reflection;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// Action to be taken for completing the payment.
    /// </summary>
    [JsonConverter(typeof(PaymentResponseActionJsonConverter))]
    [DataContract(Name = "PaymentResponse_action")]
    public partial class PaymentResponseAction : AbstractOpenAPISchema, IEquatable<PaymentResponseAction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResponseAction" /> class
        /// with the <see cref="CheckoutAwaitAction" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CheckoutAwaitAction.</param>
        public PaymentResponseAction(CheckoutAwaitAction actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResponseAction" /> class
        /// with the <see cref="CheckoutQrCodeAction" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CheckoutQrCodeAction.</param>
        public PaymentResponseAction(CheckoutQrCodeAction actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResponseAction" /> class
        /// with the <see cref="CheckoutRedirectAction" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CheckoutRedirectAction.</param>
        public PaymentResponseAction(CheckoutRedirectAction actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResponseAction" /> class
        /// with the <see cref="CheckoutSDKAction" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CheckoutSDKAction.</param>
        public PaymentResponseAction(CheckoutSDKAction actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResponseAction" /> class
        /// with the <see cref="CheckoutThreeDS2Action" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CheckoutThreeDS2Action.</param>
        public PaymentResponseAction(CheckoutThreeDS2Action actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResponseAction" /> class
        /// with the <see cref="CheckoutVoucherAction" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CheckoutVoucherAction.</param>
        public PaymentResponseAction(CheckoutVoucherAction actualInstance)
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
                if (value.GetType() == typeof(CheckoutAwaitAction))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(CheckoutQrCodeAction))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(CheckoutRedirectAction))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(CheckoutSDKAction))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(CheckoutThreeDS2Action))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(CheckoutVoucherAction))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: CheckoutAwaitAction, CheckoutQrCodeAction, CheckoutRedirectAction, CheckoutSDKAction, CheckoutThreeDS2Action, CheckoutVoucherAction");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `CheckoutAwaitAction`. If the actual instance is not `CheckoutAwaitAction`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CheckoutAwaitAction</returns>
        public CheckoutAwaitAction GetCheckoutAwaitAction()
        {
            return (CheckoutAwaitAction)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `CheckoutQrCodeAction`. If the actual instance is not `CheckoutQrCodeAction`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CheckoutQrCodeAction</returns>
        public CheckoutQrCodeAction GetCheckoutQrCodeAction()
        {
            return (CheckoutQrCodeAction)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `CheckoutRedirectAction`. If the actual instance is not `CheckoutRedirectAction`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CheckoutRedirectAction</returns>
        public CheckoutRedirectAction GetCheckoutRedirectAction()
        {
            return (CheckoutRedirectAction)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `CheckoutSDKAction`. If the actual instance is not `CheckoutSDKAction`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CheckoutSDKAction</returns>
        public CheckoutSDKAction GetCheckoutSDKAction()
        {
            return (CheckoutSDKAction)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `CheckoutThreeDS2Action`. If the actual instance is not `CheckoutThreeDS2Action`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CheckoutThreeDS2Action</returns>
        public CheckoutThreeDS2Action GetCheckoutThreeDS2Action()
        {
            return (CheckoutThreeDS2Action)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `CheckoutVoucherAction`. If the actual instance is not `CheckoutVoucherAction`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CheckoutVoucherAction</returns>
        public CheckoutVoucherAction GetCheckoutVoucherAction()
        {
            return (CheckoutVoucherAction)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentResponseAction {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, PaymentResponseAction.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of PaymentResponseAction
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of PaymentResponseAction</returns>
        public static PaymentResponseAction FromJson(string jsonString)
        {
            PaymentResponseAction newPaymentResponseAction = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newPaymentResponseAction;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(CheckoutAwaitAction).GetProperty("AdditionalProperties") == null)
                {
                    newPaymentResponseAction = new PaymentResponseAction(JsonConvert.DeserializeObject<CheckoutAwaitAction>(jsonString, PaymentResponseAction.SerializerSettings));
                }
                else
                {
                    newPaymentResponseAction = new PaymentResponseAction(JsonConvert.DeserializeObject<CheckoutAwaitAction>(jsonString, PaymentResponseAction.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("CheckoutAwaitAction");
                match++;
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
                if (typeof(CheckoutQrCodeAction).GetProperty("AdditionalProperties") == null)
                {
                    newPaymentResponseAction = new PaymentResponseAction(JsonConvert.DeserializeObject<CheckoutQrCodeAction>(jsonString, PaymentResponseAction.SerializerSettings));
                }
                else
                {
                    newPaymentResponseAction = new PaymentResponseAction(JsonConvert.DeserializeObject<CheckoutQrCodeAction>(jsonString, PaymentResponseAction.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("CheckoutQrCodeAction");
                match++;
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
                if (typeof(CheckoutRedirectAction).GetProperty("AdditionalProperties") == null)
                {
                    newPaymentResponseAction = new PaymentResponseAction(JsonConvert.DeserializeObject<CheckoutRedirectAction>(jsonString, PaymentResponseAction.SerializerSettings));
                }
                else
                {
                    newPaymentResponseAction = new PaymentResponseAction(JsonConvert.DeserializeObject<CheckoutRedirectAction>(jsonString, PaymentResponseAction.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("CheckoutRedirectAction");
                match++;
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
                if (typeof(CheckoutSDKAction).GetProperty("AdditionalProperties") == null)
                {
                    newPaymentResponseAction = new PaymentResponseAction(JsonConvert.DeserializeObject<CheckoutSDKAction>(jsonString, PaymentResponseAction.SerializerSettings));
                }
                else
                {
                    newPaymentResponseAction = new PaymentResponseAction(JsonConvert.DeserializeObject<CheckoutSDKAction>(jsonString, PaymentResponseAction.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("CheckoutSDKAction");
                match++;
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
                if (typeof(CheckoutThreeDS2Action).GetProperty("AdditionalProperties") == null)
                {
                    newPaymentResponseAction = new PaymentResponseAction(JsonConvert.DeserializeObject<CheckoutThreeDS2Action>(jsonString, PaymentResponseAction.SerializerSettings));
                }
                else
                {
                    newPaymentResponseAction = new PaymentResponseAction(JsonConvert.DeserializeObject<CheckoutThreeDS2Action>(jsonString, PaymentResponseAction.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("CheckoutThreeDS2Action");
                match++;
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
                if (typeof(CheckoutVoucherAction).GetProperty("AdditionalProperties") == null)
                {
                    newPaymentResponseAction = new PaymentResponseAction(JsonConvert.DeserializeObject<CheckoutVoucherAction>(jsonString, PaymentResponseAction.SerializerSettings));
                }
                else
                {
                    newPaymentResponseAction = new PaymentResponseAction(JsonConvert.DeserializeObject<CheckoutVoucherAction>(jsonString, PaymentResponseAction.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("CheckoutVoucherAction");
                match++;
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
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newPaymentResponseAction;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PaymentResponseAction);
        }

        /// <summary>
        /// Returns true if PaymentResponseAction instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentResponseAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentResponseAction input)
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
    /// Custom JSON converter for PaymentResponseAction
    /// </summary>
    public class PaymentResponseActionJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(PaymentResponseAction).GetMethod("ToJson").Invoke(value, null)));
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
                return PaymentResponseAction.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
