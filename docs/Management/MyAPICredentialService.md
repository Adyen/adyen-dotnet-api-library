# Adyen.Management.Services.MyAPICredentialService

### API Base-Path: **https://management-test.adyen.com/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddAllowedOrigin**](MyAPICredentialService.md#addallowedorigin) | **POST** /me/allowedOrigins | Add allowed origin |
| [**GenerateClientKey**](MyAPICredentialService.md#generateclientkey) | **POST** /me/generateClientKey | Generate a client key |
| [**GetAllowedOriginDetails**](MyAPICredentialService.md#getallowedorigindetails) | **GET** /me/allowedOrigins/{originId} | Get allowed origin details |
| [**GetAllowedOrigins**](MyAPICredentialService.md#getallowedorigins) | **GET** /me/allowedOrigins | Get allowed origins |
| [**GetApiCredentialDetails**](MyAPICredentialService.md#getapicredentialdetails) | **GET** /me | Get API credential details |
| [**RemoveAllowedOrigin**](MyAPICredentialService.md#removeallowedorigin) | **DELETE** /me/allowedOrigins/{originId} | Remove allowed origin |

<a id="addallowedorigin"></a>
# **POST** **/me/allowedOrigins**

Add allowed origin

```csharp 
IAllowedOrigin AddAllowedOriginAsync(CreateAllowedOriginRequest createAllowedOriginRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **createAllowedOriginRequest** | [**CreateAllowedOriginRequest**](CreateAllowedOriginRequest.md) |  |

### Return type

[**AllowedOrigin**](AllowedOrigin.md)

<a id="generateclientkey"></a>
# **POST** **/me/generateClientKey**

Generate a client key

```csharp 
IGenerateClientKeyResponse GenerateClientKeyAsync()
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GenerateClientKeyResponse**](GenerateClientKeyResponse.md)

<a id="getallowedorigindetails"></a>
# **GET** **/me/allowedOrigins/{originId}**

Get allowed origin details

```csharp 
IAllowedOrigin GetAllowedOriginDetailsAsync(string originId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **originId** | **string** | Unique identifier of the allowed origin. |

### Return type

[**AllowedOrigin**](AllowedOrigin.md)

<a id="getallowedorigins"></a>
# **GET** **/me/allowedOrigins**

Get allowed origins

```csharp 
IAllowedOriginsResponse GetAllowedOriginsAsync()
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AllowedOriginsResponse**](AllowedOriginsResponse.md)

<a id="getapicredentialdetails"></a>
# **GET** **/me**

Get API credential details

```csharp 
IMeApiCredential GetApiCredentialDetailsAsync()
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**MeApiCredential**](MeApiCredential.md)

<a id="removeallowedorigin"></a>
# **DELETE** **/me/allowedOrigins/{originId}**

Remove allowed origin

```csharp 
Ivoid RemoveAllowedOriginAsync(string originId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **originId** | **string** | Unique identifier of the allowed origin. |

### Return type

void (empty response body)

