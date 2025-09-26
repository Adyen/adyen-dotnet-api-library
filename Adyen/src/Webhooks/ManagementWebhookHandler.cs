using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using Adyen.Model.ManagementWebhooks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Adyen.Webhooks
{
    public class ManagementWebhookHandler
    {
        /// <summary>
        /// Deserializes to a generic management webhook from the <paramref name="jsonPayload"/>. Use this either to catch the
        /// webhook type if unknown or if the explicit type is not required.
        /// </summary>
        /// <param name="jsonPayload">The json payload of the webhook.</param>
        /// <returns>The parsed webhook packaged in a dynamic object.</returns>
        /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
        public dynamic GetGenericManagementWebhook(string jsonPayload)
        {
            if (GetMerchantCreatedNotificationRequest(jsonPayload, out var merchantCreatedNotificationRequest)) 
            {
                return merchantCreatedNotificationRequest;
            }
            
            if (GetMerchantUpdatedNotificationRequest(jsonPayload, out var merchantUpdatedNotificationRequest)) 
            {
                return merchantUpdatedNotificationRequest;
            }
            
            if (GetPaymentMethodCreatedNotificationRequest(jsonPayload, out var paymentMethodCreatedNotificationRequest)) 
            {
                return paymentMethodCreatedNotificationRequest;
            }
            
            if (GetPaymentMethodRequestRemovedNotificationRequest(jsonPayload, out var PaymentMethodRequestRemovedNotificationRequest)) 
            {
                return PaymentMethodRequestRemovedNotificationRequest;
            }
            
            if (GetPaymentMethodScheduledForRemovalNotificationRequest(jsonPayload, out var PaymentMethodScheduledForRemovalNotificationRequest)) 
            {
                return PaymentMethodScheduledForRemovalNotificationRequest;
            }
            
            throw new JsonReaderException("Could not parse webhook");
        }
        
        /// <summary>
        /// Deserializes <see cref="MerchantCreatedNotificationRequest"/> from the <paramref name="jsonPayload"/>.
        /// </summary>
        /// <param name="jsonPayload">The json payload of the webhook.</param>
        /// <param name="result"><see cref="MerchantCreatedNotificationRequest"/>.</param>
        /// <returns>A return value indicates whether the deserialization succeeded.</returns>
        /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
        public bool GetMerchantCreatedNotificationRequest(string jsonPayload, out MerchantCreatedNotificationRequest result)
        {
            result = null;
            if (!ContainsValue<MerchantCreatedNotificationRequest.TypeEnum>(jsonPayload)) return false;
            result = JsonConvert.DeserializeObject<MerchantCreatedNotificationRequest>(jsonPayload);
            return true;
        }
        
        /// <summary>
        /// Deserializes <see cref="MerchantUpdatedNotificationRequest"/> from the <paramref name="jsonPayload"/>.
        /// </summary>
        /// <param name="jsonPayload">The json payload of the webhook.</param>
        /// <param name="result"><see cref="MerchantUpdatedNotificationRequest"/>.</param>
        /// <returns>A return value indicates whether the deserialization succeeded.</returns>
        /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
        public bool GetMerchantUpdatedNotificationRequest(string jsonPayload, out MerchantUpdatedNotificationRequest result)
        {
            result = null;
            if (!ContainsValue<MerchantUpdatedNotificationRequest.TypeEnum>(jsonPayload)) return false;
            result = JsonConvert.DeserializeObject<MerchantUpdatedNotificationRequest>(jsonPayload);
            return true;
        }

        /// <summary>
        /// Deserializes <see cref="PaymentMethodCreatedNotificationRequest"/> from the <paramref name="jsonPayload"/>.
        /// </summary>
        /// <param name="jsonPayload">The json payload of the webhook.</param>
        /// <param name="result"><see cref="PaymentMethodCreatedNotificationRequest"/>.</param>
        /// <returns>A return value indicates whether the deserialization succeeded.</returns>
        /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
        public bool GetPaymentMethodCreatedNotificationRequest(string jsonPayload, out PaymentMethodCreatedNotificationRequest result)
        {
            result = null;
            if (!ContainsValue<PaymentMethodCreatedNotificationRequest.TypeEnum>(jsonPayload)) return false;
            result = JsonConvert.DeserializeObject<PaymentMethodCreatedNotificationRequest>(jsonPayload);
            return true;
        }
        
        /// <summary>
        /// Deserializes <see cref="PaymentMethodRequestRemovedNotificationRequest"/> from the <paramref name="jsonPayload"/>.
        /// </summary>
        /// <param name="jsonPayload">The json payload of the webhook.</param>
        /// <param name="result"><see cref="PaymentMethodRequestRemovedNotificationRequest"/>.</param>
        /// <returns>A return value indicates whether the deserialization succeeded.</returns>
        /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
        public bool GetPaymentMethodRequestRemovedNotificationRequest(string jsonPayload, out PaymentMethodRequestRemovedNotificationRequest result)
        {
            result = null;
            if (!ContainsValue<PaymentMethodRequestRemovedNotificationRequest.TypeEnum>(jsonPayload)) return false;
            result = JsonConvert.DeserializeObject<PaymentMethodRequestRemovedNotificationRequest>(jsonPayload);
            return true;
        }
        
        /// <summary>
        /// Deserializes <see cref="PaymentMethodScheduledForRemovalNotificationRequest"/> from the <paramref name="jsonPayload"/>.
        /// </summary>
        /// <param name="jsonPayload">The json payload of the webhook.</param>
        /// <param name="result"><see cref="PaymentMethodScheduledForRemovalNotificationRequest"/>.</param>
        /// <returns>A return value indicates whether the deserialization succeeded.</returns>
        /// <exception cref="JsonReaderException">Throws when json is invalid.</exception>
        public bool GetPaymentMethodScheduledForRemovalNotificationRequest(string jsonPayload, out PaymentMethodScheduledForRemovalNotificationRequest result)
        {
            result = null;
            if (!ContainsValue<PaymentMethodScheduledForRemovalNotificationRequest.TypeEnum>(jsonPayload)) return false;
            result = JsonConvert.DeserializeObject<PaymentMethodScheduledForRemovalNotificationRequest>(jsonPayload);
            return true;
        }
        
        // Check if the <T> contains TypeEnum value
        private static bool ContainsValue<T>(string jsonPayload) where T : struct, IConvertible
        {
            // Retrieve type from payload
            JToken typeToken = JObject.Parse(jsonPayload).GetValue("type");
            string type = typeToken?.Value<string>();
            
            // Search for type in <T>.TypeEnum
            List<string> list = new List<string>();
            var members = typeof(T)
                .GetTypeInfo()
                .DeclaredMembers;
            foreach (var member in members)
            {
                var val = member?.GetCustomAttribute<EnumMemberAttribute>(false)?.Value;
                if (!string.IsNullOrEmpty(val))
                    list.Add(val);
            }

            return list.Contains(type);
        }
    }
}