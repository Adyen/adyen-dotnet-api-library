## Adyen.Management.Services.UsersCompanyLevelService

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
    IUsersCompanyLevelService usersCompanyLevelService = host.Services.GetRequiredService<IUsersCompanyLevelService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateNewUser**](UsersCompanyLevelService.md#createnewuser) | **POST** /companies/{companyId}/users | Create a new user |
| [**GetUserDetails**](UsersCompanyLevelService.md#getuserdetails) | **GET** /companies/{companyId}/users/{userId} | Get user details |
| [**ListUsers**](UsersCompanyLevelService.md#listusers) | **GET** /companies/{companyId}/users | Get a list of users |
| [**UpdateUserDetails**](UsersCompanyLevelService.md#updateuserdetails) | **PATCH** /companies/{companyId}/users/{userId} | Update user details |

<a id="createnewuser"></a>
### **POST** **/companies/{companyId}/users**

Create a new user

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **createCompanyUserRequest** | **CreateCompanyUserRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `UsersCompanyLevelService.CreateNewUser` usage:
// Provide the following values: companyId, createCompanyUserRequest
ICreateCompanyUserResponse response = await usersCompanyLevelService.CreateNewUserAsync(
    string companyId, CreateCompanyUserRequest createCompanyUserRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out CreateCompanyUserResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[CreateCompanyUserResponse]()


<a id="getuserdetails"></a>
### **GET** **/companies/{companyId}/users/{userId}**

Get user details

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **userId** | [string] | The unique identifier of the user. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `UsersCompanyLevelService.GetUserDetails` usage:
// Provide the following values: companyId, userId
ICompanyUser response = await usersCompanyLevelService.GetUserDetailsAsync(
    string companyId, string userId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out CompanyUser result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[CompanyUser]()


<a id="listusers"></a>
### **GET** **/companies/{companyId}/users**

Get a list of users

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **pageNumber** | [int] | The number of the page to return. |
| **pageSize** | [int] | The number of items to have on a page. Maximum value is **100**. The default is **10** items on a page. |
| **username** | [string] | The partial or complete username to select all users that match. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `UsersCompanyLevelService.ListUsers` usage:
// Provide the following values: companyId, pageNumber, pageSize, username
IListCompanyUsersResponse response = await usersCompanyLevelService.ListUsersAsync(
    string companyId, Option<int> pageNumber = default, Option<int> pageSize = default, Option<string> username = default, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ListCompanyUsersResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ListCompanyUsersResponse]()


<a id="updateuserdetails"></a>
### **PATCH** **/companies/{companyId}/users/{userId}**

Update user details

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **userId** | [string] | The unique identifier of the user. |
| **updateCompanyUserRequest** | **UpdateCompanyUserRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `UsersCompanyLevelService.UpdateUserDetails` usage:
// Provide the following values: companyId, userId, updateCompanyUserRequest
ICompanyUser response = await usersCompanyLevelService.UpdateUserDetailsAsync(
    string companyId, string userId, UpdateCompanyUserRequest updateCompanyUserRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out CompanyUser result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[CompanyUser]()


