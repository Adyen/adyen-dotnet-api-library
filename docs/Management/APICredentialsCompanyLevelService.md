## Adyen.Management.Services.APICredentialsCompanyLevelService

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
    IAPICredentialsCompanyLevelService aPICredentialsCompanyLevelService = host.Services.GetRequiredService<IAPICredentialsCompanyLevelService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateApiCredential**](APICredentialsCompanyLevelService.md#createapicredential) | **POST** /companies/{companyId}/apiCredentials | Create an API credential. |
| [**GetApiCredential**](APICredentialsCompanyLevelService.md#getapicredential) | **GET** /companies/{companyId}/apiCredentials/{apiCredentialId} | Get an API credential |
| [**ListApiCredentials**](APICredentialsCompanyLevelService.md#listapicredentials) | **GET** /companies/{companyId}/apiCredentials | Get a list of API credentials |
| [**UpdateApiCredential**](APICredentialsCompanyLevelService.md#updateapicredential) | **PATCH** /companies/{companyId}/apiCredentials/{apiCredentialId} | Update an API credential. |

<a id="createapicredential"></a>
### **POST** **/companies/{companyId}/apiCredentials**

Create an API credential.

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **createCompanyApiCredentialRequest** | **CreateCompanyApiCredentialRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `APICredentialsCompanyLevelService.CreateApiCredential` usage:
// Provide the following values: companyId, createCompanyApiCredentialRequest.
ICreateCompanyApiCredentialResponse response = await aPICredentialsCompanyLevelService.CreateApiCredentialAsync(
    string companyId,
    CreateCompanyApiCredentialRequest createCompanyApiCredentialRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out CreateCompanyApiCredentialResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[CreateCompanyApiCredentialResponse]()


<a id="getapicredential"></a>
### **GET** **/companies/{companyId}/apiCredentials/{apiCredentialId}**

Get an API credential

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **apiCredentialId** | [string] | Unique identifier of the API credential. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `APICredentialsCompanyLevelService.GetApiCredential` usage:
// Provide the following values: companyId, apiCredentialId.
ICompanyApiCredential response = await aPICredentialsCompanyLevelService.GetApiCredentialAsync(
    string companyId,
    string apiCredentialId, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out CompanyApiCredential result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[CompanyApiCredential]()


<a id="listapicredentials"></a>
### **GET** **/companies/{companyId}/apiCredentials**

Get a list of API credentials

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

// Example `APICredentialsCompanyLevelService.ListApiCredentials` usage:
// Provide the following values: companyId, pageNumber, pageSize.
IListCompanyApiCredentialsResponse response = await aPICredentialsCompanyLevelService.ListApiCredentialsAsync(
    string companyId,
    int pageNumber,
    int pageSize, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ListCompanyApiCredentialsResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ListCompanyApiCredentialsResponse]()


<a id="updateapicredential"></a>
### **PATCH** **/companies/{companyId}/apiCredentials/{apiCredentialId}**

Update an API credential.

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **apiCredentialId** | [string] | Unique identifier of the API credential. |
| **updateCompanyApiCredentialRequest** | **UpdateCompanyApiCredentialRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `APICredentialsCompanyLevelService.UpdateApiCredential` usage:
// Provide the following values: companyId, apiCredentialId, updateCompanyApiCredentialRequest.
ICompanyApiCredential response = await aPICredentialsCompanyLevelService.UpdateApiCredentialAsync(
    string companyId,
    string apiCredentialId,
    UpdateCompanyApiCredentialRequest updateCompanyApiCredentialRequest, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out CompanyApiCredential result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[CompanyApiCredential]()


