## Adyen.Management.Services.UsersMerchantLevelService

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
    IUsersMerchantLevelService usersMerchantLevelService = host.Services.GetRequiredService<IUsersMerchantLevelService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateNewUser**](UsersMerchantLevelService.md#createnewuser) | **POST** /merchants/{merchantId}/users | Create a new user |
| [**GetUserDetails**](UsersMerchantLevelService.md#getuserdetails) | **GET** /merchants/{merchantId}/users/{userId} | Get user details |
| [**ListUsers**](UsersMerchantLevelService.md#listusers) | **GET** /merchants/{merchantId}/users | Get a list of users |
| [**UpdateUser**](UsersMerchantLevelService.md#updateuser) | **PATCH** /merchants/{merchantId}/users/{userId} | Update a user |

<a id="createnewuser"></a>
### **POST** **/merchants/{merchantId}/users**

Create a new user

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | Unique identifier of the merchant. |
| **createMerchantUserRequest** | **CreateMerchantUserRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `UsersMerchantLevelService.CreateNewUser` usage:
// Provide the following values: merchantId, createMerchantUserRequest
ICreateUserResponse response = await usersMerchantLevelService.CreateNewUserAsync(
    string merchantId,
    CreateMerchantUserRequest createMerchantUserRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out CreateUserResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[CreateUserResponse]()


<a id="getuserdetails"></a>
### **GET** **/merchants/{merchantId}/users/{userId}**

Get user details

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | Unique identifier of the merchant. |
| **userId** | [string] | Unique identifier of the user. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `UsersMerchantLevelService.GetUserDetails` usage:
// Provide the following values: merchantId, userId
IUser response = await usersMerchantLevelService.GetUserDetailsAsync(
    string merchantId,
    string userId, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out User result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[User]()


<a id="listusers"></a>
### **GET** **/merchants/{merchantId}/users**

Get a list of users

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | Unique identifier of the merchant. |
| **pageNumber** | [int] | The number of the page to fetch. |
| **pageSize** | [int] | The number of items to have on a page. Maximum value is **100**. The default is **10** items on a page. |
| **username** | [string] | The partial or complete username to select all users that match. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `UsersMerchantLevelService.ListUsers` usage:
// Provide the following values: merchantId, pageNumber, pageSize, username
IListMerchantUsersResponse response = await usersMerchantLevelService.ListUsersAsync(
    string merchantId,
    int pageNumber,
    int pageSize,
    string username, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ListMerchantUsersResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ListMerchantUsersResponse]()


<a id="updateuser"></a>
### **PATCH** **/merchants/{merchantId}/users/{userId}**

Update a user

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | [string] | Unique identifier of the merchant. |
| **userId** | [string] | Unique identifier of the user. |
| **updateMerchantUserRequest** | **UpdateMerchantUserRequest** |  |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `UsersMerchantLevelService.UpdateUser` usage:
// Provide the following values: merchantId, userId, updateMerchantUserRequest
IUser response = await usersMerchantLevelService.UpdateUserAsync(
    string merchantId,
    string userId,
    UpdateMerchantUserRequest updateMerchantUserRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out User result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[User]()


