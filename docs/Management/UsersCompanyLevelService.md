# Adyen.Management.Services.UsersCompanyLevelService

### API Base-Path: **https://management-test.adyen.com/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateNewUser**](UsersCompanyLevelService.md#createnewuser) | **POST** /companies/{companyId}/users | Create a new user |
| [**GetUserDetails**](UsersCompanyLevelService.md#getuserdetails) | **GET** /companies/{companyId}/users/{userId} | Get user details |
| [**ListUsers**](UsersCompanyLevelService.md#listusers) | **GET** /companies/{companyId}/users | Get a list of users |
| [**UpdateUserDetails**](UsersCompanyLevelService.md#updateuserdetails) | **PATCH** /companies/{companyId}/users/{userId} | Update user details |

<a id="createnewuser"></a>
# **POST** **/companies/{companyId}/users**

Create a new user

```csharp 
ICreateCompanyUserResponse CreateNewUserAsync(string companyId, CreateCompanyUserRequest createCompanyUserRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **createCompanyUserRequest** | [**CreateCompanyUserRequest**](CreateCompanyUserRequest.md) |  |

### Return type

[**CreateCompanyUserResponse**](CreateCompanyUserResponse.md)

<a id="getuserdetails"></a>
# **GET** **/companies/{companyId}/users/{userId}**

Get user details

```csharp 
ICompanyUser GetUserDetailsAsync(string companyId, string userId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **userId** | **string** | The unique identifier of the user. |

### Return type

[**CompanyUser**](CompanyUser.md)

<a id="listusers"></a>
# **GET** **/companies/{companyId}/users**

Get a list of users

```csharp 
IListCompanyUsersResponse ListUsersAsync(string companyId, int pageNumber = null, int pageSize = null, string username = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **pageNumber** | **int** | The number of the page to return. |
| **pageSize** | **int** | The number of items to have on a page. Maximum value is **100**. The default is **10** items on a page. |
| **username** | **string** | The partial or complete username to select all users that match. |

### Return type

[**ListCompanyUsersResponse**](ListCompanyUsersResponse.md)

<a id="updateuserdetails"></a>
# **PATCH** **/companies/{companyId}/users/{userId}**

Update user details

```csharp 
ICompanyUser UpdateUserDetailsAsync(string companyId, string userId, UpdateCompanyUserRequest updateCompanyUserRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **userId** | **string** | The unique identifier of the user. |
| **updateCompanyUserRequest** | [**UpdateCompanyUserRequest**](UpdateCompanyUserRequest.md) |  |

### Return type

[**CompanyUser**](CompanyUser.md)

