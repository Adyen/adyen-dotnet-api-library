# Adyen.Transfers.Services.CapitalService

### API Base-Path: **https://balanceplatform-api-test.adyen.com/btl/v4**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth), [clientKey](../README.md#clientKey)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCapitalAccount**](CapitalService.md#getcapitalaccount) | **GET** /grants | Get a capital account |
| [**GetGrantReferenceDetails**](CapitalService.md#getgrantreferencedetails) | **GET** /grants/{id} | Get grant reference details |
| [**RequestGrantPayout**](CapitalService.md#requestgrantpayout) | **POST** /grants | Request a grant payout |

<a id="getcapitalaccount"></a>
# **GET** **/grants**

Get a capital account

```csharp 
ICapitalGrants GetCapitalAccountAsync(string counterpartyAccountHolderId = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **counterpartyAccountHolderId** | **string** | The counterparty account holder id. |

### Return type

[**CapitalGrants**](CapitalGrants.md)

<a id="getgrantreferencedetails"></a>
# **GET** **/grants/{id}**

Get grant reference details

```csharp 
ICapitalGrant GetGrantReferenceDetailsAsync(string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the grant. |

### Return type

[**CapitalGrant**](CapitalGrant.md)

<a id="requestgrantpayout"></a>
# **POST** **/grants**

Request a grant payout

```csharp 
ICapitalGrant RequestGrantPayoutAsync(string idempotencyKey = null, CapitalGrantInfo capitalGrantInfo = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **idempotencyKey** | **string** | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| **capitalGrantInfo** | [**CapitalGrantInfo**](CapitalGrantInfo.md) |  |

### Return type

[**CapitalGrant**](CapitalGrant.md)

