# Adyen.Management.Services.WebhooksCompanyLevelService

### API Base-Path: **https://management-test.adyen.com/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GenerateHmacKey**](WebhooksCompanyLevelService.md#generatehmackey) | **POST** /companies/{companyId}/webhooks/{webhookId}/generateHmac | Generate an HMAC key |
| [**GetWebhook**](WebhooksCompanyLevelService.md#getwebhook) | **GET** /companies/{companyId}/webhooks/{webhookId} | Get a webhook |
| [**ListAllWebhooks**](WebhooksCompanyLevelService.md#listallwebhooks) | **GET** /companies/{companyId}/webhooks | List all webhooks |
| [**RemoveWebhook**](WebhooksCompanyLevelService.md#removewebhook) | **DELETE** /companies/{companyId}/webhooks/{webhookId} | Remove a webhook |
| [**SetUpWebhook**](WebhooksCompanyLevelService.md#setupwebhook) | **POST** /companies/{companyId}/webhooks | Set up a webhook |
| [**TestWebhook**](WebhooksCompanyLevelService.md#testwebhook) | **POST** /companies/{companyId}/webhooks/{webhookId}/test | Test a webhook |
| [**UpdateWebhook**](WebhooksCompanyLevelService.md#updatewebhook) | **PATCH** /companies/{companyId}/webhooks/{webhookId} | Update a webhook |

<a id="generatehmackey"></a>
# **POST** **/companies/{companyId}/webhooks/{webhookId}/generateHmac**

Generate an HMAC key

```csharp 
IGenerateHmacKeyResponse GenerateHmacKeyAsync(string companyId, string webhookId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **webhookId** | **string** | Unique identifier of the webhook configuration. |

### Return type

[**GenerateHmacKeyResponse**](GenerateHmacKeyResponse.md)

<a id="getwebhook"></a>
# **GET** **/companies/{companyId}/webhooks/{webhookId}**

Get a webhook

```csharp 
IWebhook GetWebhookAsync(string companyId, string webhookId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | Unique identifier of the [company account](https://docs.adyen.com/account/account-structure#company-account). |
| **webhookId** | **string** | Unique identifier of the webhook configuration. |

### Return type

[**Webhook**](Webhook.md)

<a id="listallwebhooks"></a>
# **GET** **/companies/{companyId}/webhooks**

List all webhooks

```csharp 
IListWebhooksResponse ListAllWebhooksAsync(string companyId, int pageNumber = null, int pageSize = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | Unique identifier of the [company account](https://docs.adyen.com/account/account-structure#company-account). |
| **pageNumber** | **int** | The number of the page to fetch. |
| **pageSize** | **int** | The number of items to have on a page, maximum 100. The default is 10 items on a page. |

### Return type

[**ListWebhooksResponse**](ListWebhooksResponse.md)

<a id="removewebhook"></a>
# **DELETE** **/companies/{companyId}/webhooks/{webhookId}**

Remove a webhook

```csharp 
Ivoid RemoveWebhookAsync(string companyId, string webhookId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **webhookId** | **string** | Unique identifier of the webhook configuration. |

### Return type

void (empty response body)

<a id="setupwebhook"></a>
# **POST** **/companies/{companyId}/webhooks**

Set up a webhook

```csharp 
IWebhook SetUpWebhookAsync(string companyId, CreateCompanyWebhookRequest createCompanyWebhookRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | Unique identifier of the [company account](https://docs.adyen.com/account/account-structure#company-account). |
| **createCompanyWebhookRequest** | [**CreateCompanyWebhookRequest**](CreateCompanyWebhookRequest.md) |  |

### Return type

[**Webhook**](Webhook.md)

<a id="testwebhook"></a>
# **POST** **/companies/{companyId}/webhooks/{webhookId}/test**

Test a webhook

```csharp 
ITestWebhookResponse TestWebhookAsync(string companyId, string webhookId, TestCompanyWebhookRequest testCompanyWebhookRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **webhookId** | **string** | Unique identifier of the webhook configuration. |
| **testCompanyWebhookRequest** | [**TestCompanyWebhookRequest**](TestCompanyWebhookRequest.md) |  |

### Return type

[**TestWebhookResponse**](TestWebhookResponse.md)

<a id="updatewebhook"></a>
# **PATCH** **/companies/{companyId}/webhooks/{webhookId}**

Update a webhook

```csharp 
IWebhook UpdateWebhookAsync(string companyId, string webhookId, UpdateCompanyWebhookRequest updateCompanyWebhookRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **webhookId** | **string** | Unique identifier of the webhook configuration. |
| **updateCompanyWebhookRequest** | [**UpdateCompanyWebhookRequest**](UpdateCompanyWebhookRequest.md) |  |

### Return type

[**Webhook**](Webhook.md)

