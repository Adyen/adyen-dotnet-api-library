# Adyen.SessionAuthentication.Services.SessionAuthenticationService

### API Base-Path: **https://test.adyen.com/authe/api/v1**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateAuthenticationSession**](SessionAuthenticationService.md#createauthenticationsession) | **POST** /sessions | Create a session token |

<a id="createauthenticationsession"></a>
# **POST** **/sessions**

Create a session token

```csharp 
IAuthenticationSessionResponse CreateAuthenticationSessionAsync(AuthenticationSessionRequest authenticationSessionRequest)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **authenticationSessionRequest** | [**AuthenticationSessionRequest**](AuthenticationSessionRequest.md) |  |

### Return type

[**AuthenticationSessionResponse**](AuthenticationSessionResponse.md)

