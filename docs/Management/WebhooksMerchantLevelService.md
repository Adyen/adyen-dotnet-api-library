## Adyen.Management.Services.WebhooksMerchantLevelService

#### API Base-Path: **https://management-test.adyen.com/v3**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.Management.Extensions;
using Adyen.Management.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureManagement((context, services, config) =>
    {
        config.ConfigureAdyenOptions(options =>
        {
            // Set your ADYEN_API_KEY or use get it from your environment using context.Configuration["ADYEN_API_KEY"].
            options.AdyenApiKey = context.Configuration["ADYEN_API_KEY"];

            // Set your environment, e.g. `Test` or `Live`.
            options.Environment = AdyenEnvironment.Test;

            // For the Live environment, additionally include your LiveEndpointUrlPrefix.
            options.LiveEndpointUrlPrefix = "your-live-endpoint-url-prefix";
        });
    })
    .Build();

    // You can inject this service in your constructor.
    IWebhooksMerchantLevelService webhooksMerchantLevelService = host.Services.GetRequiredService<IWebhooksMerchantLevelService>();
```

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
### **POST** **/merchants/{merchantId}/webhooks/{webhookId}/generateHmac**

Generate an HMAC key

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **webhookId** | [string] |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `WebhooksMerchantLevelService.GenerateHmacKey` usage:
// Provide the following values: merchantId, webhookId
IGenerateHmacKeyResponse response = await webhooksMerchantLevelService.GenerateHmacKeyAsync(
    string merchantId,
    string webhookId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out GenerateHmacKeyResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[GenerateHmacKeyResponse]()


<a id="getwebhook"></a>
### **GET** **/merchants/{merchantId}/webhooks/{webhookId}**

Get a webhook

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **webhookId** | [string] | Unique identifier of the webhook configuration. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `WebhooksMerchantLevelService.GetWebhook` usage:
// Provide the following values: merchantId, webhookId
IWebhook response = await webhooksMerchantLevelService.GetWebhookAsync(
    string merchantId,
    string webhookId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out Webhook result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[Webhook]()


<a id="listallwebhooks"></a>
### **GET** **/merchants/{merchantId}/webhooks**

List all webhooks

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **pageNumber** | [int] | The number of the page to fetch. |
| **pageSize** | [int] | The number of items to have on a page, maximum 100. The default is 10 items on a page. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `WebhooksMerchantLevelService.ListAllWebhooks` usage:
// Provide the following values: merchantId, pageNumber, pageSize
IListWebhooksResponse response = await webhooksMerchantLevelService.ListAllWebhooksAsync(
    string merchantId,
    int pageNumber,
    int pageSize, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ListWebhooksResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ListWebhooksResponse]()


<a id="removewebhook"></a>
### **DELETE** **/merchants/{merchantId}/webhooks/{webhookId}**

Remove a webhook

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **webhookId** | [string] | Unique identifier of the webhook configuration. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `WebhooksMerchantLevelService.RemoveWebhook` usage:
// Provide the following values: merchantId, webhookId
await webhooksMerchantLevelService.RemoveWebhookAsync(
    string merchantId,
    string webhookId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out  result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
void (empty response body)


<a id="setupwebhook"></a>
### **POST** **/merchants/{merchantId}/webhooks**

Set up a webhook

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **createMerchantWebhookRequest** | **CreateMerchantWebhookRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `WebhooksMerchantLevelService.SetUpWebhook` usage:
// Provide the following values: merchantId, createMerchantWebhookRequest
IWebhook response = await webhooksMerchantLevelService.SetUpWebhookAsync(
    string merchantId,
    CreateMerchantWebhookRequest createMerchantWebhookRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out Webhook result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[Webhook]()


<a id="testwebhook"></a>
### **POST** **/merchants/{merchantId}/webhooks/{webhookId}/test**

Test a webhook

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **webhookId** | [string] | Unique identifier of the webhook configuration. |
| **testWebhookRequest** | **TestWebhookRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `WebhooksMerchantLevelService.TestWebhook` usage:
// Provide the following values: merchantId, webhookId, testWebhookRequest
ITestWebhookResponse response = await webhooksMerchantLevelService.TestWebhookAsync(
    string merchantId,
    string webhookId,
    TestWebhookRequest testWebhookRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TestWebhookResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TestWebhookResponse]()


<a id="updatewebhook"></a>
### **PATCH** **/merchants/{merchantId}/webhooks/{webhookId}**

Update a webhook

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |
| **webhookId** | [string] | Unique identifier of the webhook configuration. |
| **updateMerchantWebhookRequest** | **UpdateMerchantWebhookRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `WebhooksMerchantLevelService.UpdateWebhook` usage:
// Provide the following values: merchantId, webhookId, updateMerchantWebhookRequest
IWebhook response = await webhooksMerchantLevelService.UpdateWebhookAsync(
    string merchantId,
    string webhookId,
    UpdateMerchantWebhookRequest updateMerchantWebhookRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out Webhook result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[Webhook]()


