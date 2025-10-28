# Adyen.BalancePlatform.Services.NetworkTokensService

### API Base-Path: **https://balanceplatform-api-test.adyen.com/bcl/v2**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth), [clientKey](../README.md#clientKey)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetNetworkToken**](NetworkTokensService.md#getnetworktoken) | **GET** /networkTokens/{networkTokenId} | Get a network token |
| [**UpdateNetworkToken**](NetworkTokensService.md#updatenetworktoken) | **PATCH** /networkTokens/{networkTokenId} | Update a network token |

<a id="getnetworktoken"></a>
# **GET** **/networkTokens/{networkTokenId}**

Get a network token

```csharp 
IGetNetworkTokenResponse GetNetworkTokenAsync(string networkTokenId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **networkTokenId** | **string** | The unique identifier of the network token. |

### Return type

[**GetNetworkTokenResponse**](GetNetworkTokenResponse.md)

<a id="updatenetworktoken"></a>
# **PATCH** **/networkTokens/{networkTokenId}**

Update a network token

```csharp 
Ivoid UpdateNetworkTokenAsync(string networkTokenId, UpdateNetworkTokenRequest updateNetworkTokenRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **networkTokenId** | **string** | The unique identifier of the network token. |
| **updateNetworkTokenRequest** | [**UpdateNetworkTokenRequest**](UpdateNetworkTokenRequest.md) |  |

### Return type

void (empty response body)

