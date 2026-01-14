## Adyen.Management.Services.AccountCompanyLevelService

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
    IAccountCompanyLevelService accountCompanyLevelService = host.Services.GetRequiredService<IAccountCompanyLevelService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCompanyAccount**](AccountCompanyLevelService.md#getcompanyaccount) | **GET** /companies/{companyId} | Get a company account |
| [**ListCompanyAccounts**](AccountCompanyLevelService.md#listcompanyaccounts) | **GET** /companies | Get a list of company accounts |
| [**ListMerchantAccounts**](AccountCompanyLevelService.md#listmerchantaccounts) | **GET** /companies/{companyId}/merchants | Get a list of merchant accounts |

<a id="getcompanyaccount"></a>
### **GET** **/companies/{companyId}**

Get a company account

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `AccountCompanyLevelService.GetCompanyAccount` usage:
// Provide the following values: companyId
ICompany response = await accountCompanyLevelService.GetCompanyAccountAsync(
    string companyId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out Company result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[Company]()


<a id="listcompanyaccounts"></a>
### **GET** **/companies**

Get a list of company accounts

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **pageNumber** | [int] | The number of the page to fetch. |
| **pageSize** | [int] | The number of items to have on a page, maximum 100. The default is 10 items on a page. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `AccountCompanyLevelService.ListCompanyAccounts` usage:
// Provide the following values: pageNumber, pageSize
IListCompanyResponse response = await accountCompanyLevelService.ListCompanyAccountsAsync(
    Option<int> pageNumber = default, Option<int> pageSize = default, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ListCompanyResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ListCompanyResponse]()


<a id="listmerchantaccounts"></a>
### **GET** **/companies/{companyId}/merchants**

Get a list of merchant accounts

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **pageNumber** | [int] | The number of the page to fetch. |
| **pageSize** | [int] | The number of items to have on a page, maximum 100. The default is 10 items on a page. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `AccountCompanyLevelService.ListMerchantAccounts` usage:
// Provide the following values: companyId, pageNumber, pageSize
IListMerchantResponse response = await accountCompanyLevelService.ListMerchantAccountsAsync(
    string companyId, Option<int> pageNumber = default, Option<int> pageSize = default, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ListMerchantResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ListMerchantResponse]()


