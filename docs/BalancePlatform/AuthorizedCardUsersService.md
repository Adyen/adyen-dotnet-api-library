# Adyen.BalancePlatform.Services.AuthorizedCardUsersService

### API Base-Path: **https://balanceplatform-api-test.adyen.com/bcl/v2**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth), [clientKey](../README.md#clientKey)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateAuthorisedCardUsers**](AuthorizedCardUsersService.md#createauthorisedcardusers) | **POST** /paymentInstruments/{paymentInstrumentId}/authorisedCardUsers | Create authorized users for a card. |
| [**DeleteAuthorisedCardUsers**](AuthorizedCardUsersService.md#deleteauthorisedcardusers) | **DELETE** /paymentInstruments/{paymentInstrumentId}/authorisedCardUsers | Delete the authorized users for a card. |
| [**GetAllAuthorisedCardUsers**](AuthorizedCardUsersService.md#getallauthorisedcardusers) | **GET** /paymentInstruments/{paymentInstrumentId}/authorisedCardUsers | Get authorized users for a card. |
| [**UpdateAuthorisedCardUsers**](AuthorizedCardUsersService.md#updateauthorisedcardusers) | **PATCH** /paymentInstruments/{paymentInstrumentId}/authorisedCardUsers | Update the authorized users for a card. |

<a id="createauthorisedcardusers"></a>
# **POST** **/paymentInstruments/{paymentInstrumentId}/authorisedCardUsers**

Create authorized users for a card.

```csharp 
Ivoid CreateAuthorisedCardUsersAsync(string paymentInstrumentId, AuthorisedCardUsers authorisedCardUsers)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentInstrumentId** | **string** |  |
| **authorisedCardUsers** | [**AuthorisedCardUsers**](AuthorisedCardUsers.md) |  |

### Return type

void (empty response body)

<a id="deleteauthorisedcardusers"></a>
# **DELETE** **/paymentInstruments/{paymentInstrumentId}/authorisedCardUsers**

Delete the authorized users for a card.

```csharp 
Ivoid DeleteAuthorisedCardUsersAsync(string paymentInstrumentId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentInstrumentId** | **string** |  |

### Return type

void (empty response body)

<a id="getallauthorisedcardusers"></a>
# **GET** **/paymentInstruments/{paymentInstrumentId}/authorisedCardUsers**

Get authorized users for a card.

```csharp 
IAuthorisedCardUsers GetAllAuthorisedCardUsersAsync(string paymentInstrumentId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentInstrumentId** | **string** |  |

### Return type

[**AuthorisedCardUsers**](AuthorisedCardUsers.md)

<a id="updateauthorisedcardusers"></a>
# **PATCH** **/paymentInstruments/{paymentInstrumentId}/authorisedCardUsers**

Update the authorized users for a card.

```csharp 
Ivoid UpdateAuthorisedCardUsersAsync(string paymentInstrumentId, AuthorisedCardUsers authorisedCardUsers)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **paymentInstrumentId** | **string** |  |
| **authorisedCardUsers** | [**AuthorisedCardUsers**](AuthorisedCardUsers.md) |  |

### Return type

void (empty response body)

