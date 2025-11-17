## Adyen.BalancePlatform.Services.AccountHoldersService

#### API Base-Path: **https://balanceplatform-api-test.adyen.com/bcl/v2**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureBalancePlatform((context, services, config) =>
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
    IAccountHoldersService accountHoldersService = host.Services.GetRequiredService<IAccountHoldersService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateAccountHolder**](AccountHoldersService.md#createaccountholder) | **POST** /accountHolders | Create an account holder |
| [**GetAccountHolder**](AccountHoldersService.md#getaccountholder) | **GET** /accountHolders/{id} | Get an account holder |
| [**GetAllBalanceAccountsOfAccountHolder**](AccountHoldersService.md#getallbalanceaccountsofaccountholder) | **GET** /accountHolders/{id}/balanceAccounts | Get all balance accounts of an account holder |
| [**GetAllTransactionRulesForAccountHolder**](AccountHoldersService.md#getalltransactionrulesforaccountholder) | **GET** /accountHolders/{id}/transactionRules | Get all transaction rules for an account holder |
| [**GetTaxForm**](AccountHoldersService.md#gettaxform) | **GET** /accountHolders/{id}/taxForms | Get a tax form |
| [**UpdateAccountHolder**](AccountHoldersService.md#updateaccountholder) | **PATCH** /accountHolders/{id} | Update an account holder |

<a id="createaccountholder"></a>
### **POST** **/accountHolders**

Create an account holder

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **accountHolderInfo** | **AccountHolderInfo** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `AccountHoldersService.CreateAccountHolder` usage:
// Provide the following values: accountHolderInfo
IAccountHolder response = await accountHoldersService.CreateAccountHolderAsync(
    AccountHolderInfo accountHolderInfo, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out AccountHolder result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[AccountHolder]()


<a id="getaccountholder"></a>
### **GET** **/accountHolders/{id}**

Get an account holder

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the account holder. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `AccountHoldersService.GetAccountHolder` usage:
// Provide the following values: id
IAccountHolder response = await accountHoldersService.GetAccountHolderAsync(
    string id, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out AccountHolder result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[AccountHolder]()


<a id="getallbalanceaccountsofaccountholder"></a>
### **GET** **/accountHolders/{id}/balanceAccounts**

Get all balance accounts of an account holder

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the account holder. |
| **offset** | [int] | The number of items that you want to skip. |
| **limit** | [int] | The number of items returned per page, maximum 100 items. By default, the response returns 10 items per page. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `AccountHoldersService.GetAllBalanceAccountsOfAccountHolder` usage:
// Provide the following values: id, offset, limit
IPaginatedBalanceAccountsResponse response = await accountHoldersService.GetAllBalanceAccountsOfAccountHolderAsync(
    string id, Option<int> offset = default, Option<int> limit = default, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out PaginatedBalanceAccountsResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[PaginatedBalanceAccountsResponse]()


<a id="getalltransactionrulesforaccountholder"></a>
### **GET** **/accountHolders/{id}/transactionRules**

Get all transaction rules for an account holder

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the account holder. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `AccountHoldersService.GetAllTransactionRulesForAccountHolder` usage:
// Provide the following values: id
ITransactionRulesResponse response = await accountHoldersService.GetAllTransactionRulesForAccountHolderAsync(
    string id, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TransactionRulesResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TransactionRulesResponse]()


<a id="gettaxform"></a>
### **GET** **/accountHolders/{id}/taxForms**

Get a tax form

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the account holder. |
| **formType** | [string] | The type of tax form you want to retrieve. Accepted values are **US1099k** and **US1099nec** |
| **year** | [int] | The tax year in YYYY format for the tax form you want to retrieve |
| **legalEntityId** | [string] | The legal entity reference whose tax form you want to retrieve |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `AccountHoldersService.GetTaxForm` usage:
// Provide the following values: id, formType, year, legalEntityId
IGetTaxFormResponse response = await accountHoldersService.GetTaxFormAsync(
    string id, string formType, int year, Option<string> legalEntityId = default, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out GetTaxFormResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[GetTaxFormResponse]()


<a id="updateaccountholder"></a>
### **PATCH** **/accountHolders/{id}**

Update an account holder

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | [string] | The unique identifier of the account holder. |
| **accountHolderUpdateRequest** | **AccountHolderUpdateRequest** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `AccountHoldersService.UpdateAccountHolder` usage:
// Provide the following values: id, accountHolderUpdateRequest
IAccountHolder response = await accountHoldersService.UpdateAccountHolderAsync(
    string id, AccountHolderUpdateRequest accountHolderUpdateRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out AccountHolder result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[AccountHolder]()


