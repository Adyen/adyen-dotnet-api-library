## Adyen.Management.Services.WebhooksCompanyLevelService

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
    IWebhooksCompanyLevelService webhooksCompanyLevelService = host.Services.GetRequiredService<IWebhooksCompanyLevelService>();
```

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
### **POST** **/companies/{companyId}/webhooks/{webhookId}/generateHmac**

Generate an HMAC key

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **webhookId** | [string] | Unique identifier of the webhook configuration. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `WebhooksCompanyLevelService.GenerateHmacKey` usage:
// Provide the following values: companyId, webhookId
IGenerateHmacKeyResponse response = await webhooksCompanyLevelService.GenerateHmacKeyAsync(
    string companyId,
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
### **GET** **/companies/{companyId}/webhooks/{webhookId}**

Get a webhook

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | Unique identifier of the [company account](https://docs.adyen.com/account/account-structure#company-account). |
| **webhookId** | [string] | Unique identifier of the webhook configuration. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `WebhooksCompanyLevelService.GetWebhook` usage:
// Provide the following values: companyId, webhookId
IWebhook response = await webhooksCompanyLevelService.GetWebhookAsync(
    string companyId,
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
### **GET** **/companies/{companyId}/webhooks**

List all webhooks

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | Unique identifier of the [company account](https://docs.adyen.com/account/account-structure#company-account). |
| **pageNumber** | [int] | The number of the page to fetch. |
| **pageSize** | [int] | The number of items to have on a page, maximum 100. The default is 10 items on a page. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `WebhooksCompanyLevelService.ListAllWebhooks` usage:
// Provide the following values: companyId, pageNumber, pageSize
IListWebhooksResponse response = await webhooksCompanyLevelService.ListAllWebhooksAsync(
    string companyId,
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
### **DELETE** **/companies/{companyId}/webhooks/{webhookId}**

Remove a webhook

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **webhookId** | [string] | Unique identifier of the webhook configuration. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `WebhooksCompanyLevelService.RemoveWebhook` usage:
// Provide the following values: companyId, webhookId
await webhooksCompanyLevelService.RemoveWebhookAsync(
    string companyId,
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
### **POST** **/companies/{companyId}/webhooks**

Set up a webhook

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | Unique identifier of the [company account](https://docs.adyen.com/account/account-structure#company-account). |
| **createCompanyWebhookRequest** | **CreateCompanyWebhookRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `WebhooksCompanyLevelService.SetUpWebhook` usage:
// Provide the following values: companyId, createCompanyWebhookRequest
IWebhook response = await webhooksCompanyLevelService.SetUpWebhookAsync(
    string companyId,
    CreateCompanyWebhookRequest createCompanyWebhookRequest, 
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
### **POST** **/companies/{companyId}/webhooks/{webhookId}/test**

Test a webhook

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **webhookId** | [string] | Unique identifier of the webhook configuration. |
| **testCompanyWebhookRequest** | **TestCompanyWebhookRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `WebhooksCompanyLevelService.TestWebhook` usage:
// Provide the following values: companyId, webhookId, testCompanyWebhookRequest
ITestWebhookResponse response = await webhooksCompanyLevelService.TestWebhookAsync(
    string companyId,
    string webhookId,
    TestCompanyWebhookRequest testCompanyWebhookRequest, 
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
### **PATCH** **/companies/{companyId}/webhooks/{webhookId}**

Update a webhook

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **webhookId** | [string] | Unique identifier of the webhook configuration. |
| **updateCompanyWebhookRequest** | **UpdateCompanyWebhookRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `WebhooksCompanyLevelService.UpdateWebhook` usage:
// Provide the following values: companyId, webhookId, updateCompanyWebhookRequest
IWebhook response = await webhooksCompanyLevelService.UpdateWebhookAsync(
    string companyId,
    string webhookId,
    UpdateCompanyWebhookRequest updateCompanyWebhookRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out Webhook result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[Webhook]()


