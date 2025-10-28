# Adyen.Management.Services.WebhooksMerchantLevelService

### API Base-Path: **https://management-test.adyen.com/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GenerateHmacKey**](WebhooksMerchantLevelService.md#generatehmackey) | **POST** /merchants/{merchantId}/webhooks/{webhookId}/generateHmac | Generate an HMAC key |
| [**GetWebhook**](WebhooksMerchantLevelService.md#getwebhook) | **GET** /merchants/{merchantId}/webhooks/{webhookId} | Get a webhook |
| [**ListAllWebhooks**](WebhooksMerchantLevelService.md#listallwebhooks) | **GET** /merchants/{merchantId}/webhooks | List all webhooks |
| [**RemoveWebhook**](WebhooksMerchantLevelService.md#removewebhook) | **DELETE** /merchants/{merchantId}/webhooks/{webhookId} | Remove a webhook |
| [**SetUpWebhook**](WebhooksMerchantLevelService.md#setupwebhook) | **POST** /merchants/{merchantId}/webhooks | Set up a webhook |
| [**TestWebhook**](WebhooksMerchantLevelService.md#testwebhook) | **POST** /merchants/{merchantId}/webhooks/{webhookId}/test | Test a webhook |
| [**UpdateWebhook**](WebhooksMerchantLevelService.md#updatewebhook) | **PATCH** /merchants/{merchantId}/webhooks/{webhookId} | Update a webhook |

<a id="generatehmackey"></a>
# **POST** **/merchants/{merchantId}/webhooks/{webhookId}/generateHmac**

Generate an HMAC key

```csharp 
IGenerateHmacKeyResponse GenerateHmacKeyAsync(string merchantId, string webhookId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **webhookId** | **string** |  |

### Return type

[**GenerateHmacKeyResponse**](GenerateHmacKeyResponse.md)

<a id="getwebhook"></a>
# **GET** **/merchants/{merchantId}/webhooks/{webhookId}**

Get a webhook

```csharp 
IWebhook GetWebhookAsync(string merchantId, string webhookId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **webhookId** | **string** | Unique identifier of the webhook configuration. |

### Return type

[**Webhook**](Webhook.md)

<a id="listallwebhooks"></a>
# **GET** **/merchants/{merchantId}/webhooks**

List all webhooks

```csharp 
IListWebhooksResponse ListAllWebhooksAsync(string merchantId, int pageNumber = null, int pageSize = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **pageNumber** | **int** | The number of the page to fetch. |
| **pageSize** | **int** | The number of items to have on a page, maximum 100. The default is 10 items on a page. |

### Return type

[**ListWebhooksResponse**](ListWebhooksResponse.md)

<a id="removewebhook"></a>
# **DELETE** **/merchants/{merchantId}/webhooks/{webhookId}**

Remove a webhook

```csharp 
Ivoid RemoveWebhookAsync(string merchantId, string webhookId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **webhookId** | **string** | Unique identifier of the webhook configuration. |

### Return type

void (empty response body)

<a id="setupwebhook"></a>
# **POST** **/merchants/{merchantId}/webhooks**

Set up a webhook

```csharp 
IWebhook SetUpWebhookAsync(string merchantId, CreateMerchantWebhookRequest createMerchantWebhookRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **createMerchantWebhookRequest** | [**CreateMerchantWebhookRequest**](CreateMerchantWebhookRequest.md) |  |

### Return type

[**Webhook**](Webhook.md)

<a id="testwebhook"></a>
# **POST** **/merchants/{merchantId}/webhooks/{webhookId}/test**

Test a webhook

```csharp 
ITestWebhookResponse TestWebhookAsync(string merchantId, string webhookId, TestWebhookRequest testWebhookRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **webhookId** | **string** | Unique identifier of the webhook configuration. |
| **testWebhookRequest** | [**TestWebhookRequest**](TestWebhookRequest.md) |  |

### Return type

[**TestWebhookResponse**](TestWebhookResponse.md)

<a id="updatewebhook"></a>
# **PATCH** **/merchants/{merchantId}/webhooks/{webhookId}**

Update a webhook

```csharp 
IWebhook UpdateWebhookAsync(string merchantId, string webhookId, UpdateMerchantWebhookRequest updateMerchantWebhookRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | The unique identifier of the merchant account. |
| **webhookId** | **string** | Unique identifier of the webhook configuration. |
| **updateMerchantWebhookRequest** | [**UpdateMerchantWebhookRequest**](UpdateMerchantWebhookRequest.md) |  |

### Return type

[**Webhook**](Webhook.md)

