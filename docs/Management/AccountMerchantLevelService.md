## Adyen.Management.Services.AccountMerchantLevelService

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
    IAccountMerchantLevelService accountMerchantLevelService = host.Services.GetRequiredService<IAccountMerchantLevelService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateMerchantAccount**](AccountMerchantLevelService.md#createmerchantaccount) | **POST** /merchants | Create a merchant account |
| [**GetMerchantAccount**](AccountMerchantLevelService.md#getmerchantaccount) | **GET** /merchants/{merchantId} | Get a merchant account |
| [**ListMerchantAccounts**](AccountMerchantLevelService.md#listmerchantaccounts) | **GET** /merchants | Get a list of merchant accounts |
| [**RequestToActivateMerchantAccount**](AccountMerchantLevelService.md#requesttoactivatemerchantaccount) | **POST** /merchants/{merchantId}/activate | Request to activate a merchant account |

<a id="createmerchantaccount"></a>
### **POST** **/merchants**

Create a merchant account

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **createMerchantRequest** | **CreateMerchantRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `AccountMerchantLevelService.CreateMerchantAccount` usage:
// Provide the following values: createMerchantRequest
ICreateMerchantResponse response = await accountMerchantLevelService.CreateMerchantAccountAsync(
    CreateMerchantRequest createMerchantRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out CreateMerchantResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[CreateMerchantResponse]()


<a id="getmerchantaccount"></a>
### **GET** **/merchants/{merchantId}**

Get a merchant account

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `AccountMerchantLevelService.GetMerchantAccount` usage:
// Provide the following values: merchantId
IMerchant response = await accountMerchantLevelService.GetMerchantAccountAsync(
    string merchantId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out Merchant result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[Merchant]()


<a id="listmerchantaccounts"></a>
### **GET** **/merchants**

Get a list of merchant accounts

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **pageNumber** | [int] | The number of the page to fetch. |
| **pageSize** | [int] | The number of items to have on a page, maximum 100. The default is 10 items on a page. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `AccountMerchantLevelService.ListMerchantAccounts` usage:
// Provide the following values: pageNumber, pageSize
IListMerchantResponse response = await accountMerchantLevelService.ListMerchantAccountsAsync(
    int pageNumber,
    int pageSize, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ListMerchantResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ListMerchantResponse]()


<a id="requesttoactivatemerchantaccount"></a>
### **POST** **/merchants/{merchantId}/activate**

Request to activate a merchant account

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | The unique identifier of the merchant account. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `AccountMerchantLevelService.RequestToActivateMerchantAccount` usage:
// Provide the following values: merchantId
IRequestActivationResponse response = await accountMerchantLevelService.RequestToActivateMerchantAccountAsync(
    string merchantId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out RequestActivationResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[RequestActivationResponse]()


