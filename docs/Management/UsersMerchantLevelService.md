# Adyen.Management.Services.UsersMerchantLevelService

### API Base-Path: **https://management-test.adyen.com/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateNewUser**](UsersMerchantLevelService.md#createnewuser) | **POST** /merchants/{merchantId}/users | Create a new user |
| [**GetUserDetails**](UsersMerchantLevelService.md#getuserdetails) | **GET** /merchants/{merchantId}/users/{userId} | Get user details |
| [**ListUsers**](UsersMerchantLevelService.md#listusers) | **GET** /merchants/{merchantId}/users | Get a list of users |
| [**UpdateUser**](UsersMerchantLevelService.md#updateuser) | **PATCH** /merchants/{merchantId}/users/{userId} | Update a user |

<a id="createnewuser"></a>
# **POST** **/merchants/{merchantId}/users**

Create a new user

```csharp 
ICreateUserResponse CreateNewUserAsync(string merchantId, CreateMerchantUserRequest createMerchantUserRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | Unique identifier of the merchant. |
| **createMerchantUserRequest** | [**CreateMerchantUserRequest**](CreateMerchantUserRequest.md) |  |

### Return type

[**CreateUserResponse**](CreateUserResponse.md)

<a id="getuserdetails"></a>
# **GET** **/merchants/{merchantId}/users/{userId}**

Get user details

```csharp 
IUser GetUserDetailsAsync(string merchantId, string userId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | Unique identifier of the merchant. |
| **userId** | **string** | Unique identifier of the user. |

### Return type

[**User**](User.md)

<a id="listusers"></a>
# **GET** **/merchants/{merchantId}/users**

Get a list of users

```csharp 
IListMerchantUsersResponse ListUsersAsync(string merchantId, int pageNumber = null, int pageSize = null, string username = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | Unique identifier of the merchant. |
| **pageNumber** | **int** | The number of the page to fetch. |
| **pageSize** | **int** | The number of items to have on a page. Maximum value is **100**. The default is **10** items on a page. |
| **username** | **string** | The partial or complete username to select all users that match. |

### Return type

[**ListMerchantUsersResponse**](ListMerchantUsersResponse.md)

<a id="updateuser"></a>
# **PATCH** **/merchants/{merchantId}/users/{userId}**

Update a user

```csharp 
IUser UpdateUserAsync(string merchantId, string userId, UpdateMerchantUserRequest updateMerchantUserRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **merchantId** | **string** | Unique identifier of the merchant. |
| **userId** | **string** | Unique identifier of the user. |
| **updateMerchantUserRequest** | [**UpdateMerchantUserRequest**](UpdateMerchantUserRequest.md) |  |

### Return type

[**User**](User.md)

