# Adyen.LegalEntityManagement.Services.TransferInstrumentsService

### API Base-Path: **https://kyc-test.adyen.com/lem/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateTransferInstrument**](TransferInstrumentsService.md#createtransferinstrument) | **POST** /transferInstruments | Create a transfer instrument |
| [**DeleteTransferInstrument**](TransferInstrumentsService.md#deletetransferinstrument) | **DELETE** /transferInstruments/{id} | Delete a transfer instrument |
| [**GetTransferInstrument**](TransferInstrumentsService.md#gettransferinstrument) | **GET** /transferInstruments/{id} | Get a transfer instrument |
| [**UpdateTransferInstrument**](TransferInstrumentsService.md#updatetransferinstrument) | **PATCH** /transferInstruments/{id} | Update a transfer instrument |

<a id="createtransferinstrument"></a>
# **POST** **/transferInstruments**

Create a transfer instrument

```csharp 
ITransferInstrument CreateTransferInstrumentAsync(string xRequestedVerificationCode = null, TransferInstrumentInfo transferInstrumentInfo = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **xRequestedVerificationCode** | **string** | Use a suberror code as your requested verification code. You can include one code at a time in your request header. Requested verification codes can only be used in your test environment. |
| **transferInstrumentInfo** | [**TransferInstrumentInfo**](TransferInstrumentInfo.md) |  |

### Return type

[**TransferInstrument**](TransferInstrument.md)

<a id="deletetransferinstrument"></a>
# **DELETE** **/transferInstruments/{id}**

Delete a transfer instrument

```csharp 
Ivoid DeleteTransferInstrumentAsync(string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the transfer instrument to be deleted. |

### Return type

void (empty response body)

<a id="gettransferinstrument"></a>
# **GET** **/transferInstruments/{id}**

Get a transfer instrument

```csharp 
ITransferInstrument GetTransferInstrumentAsync(string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the transfer instrument. |

### Return type

[**TransferInstrument**](TransferInstrument.md)

<a id="updatetransferinstrument"></a>
# **PATCH** **/transferInstruments/{id}**

Update a transfer instrument

```csharp 
ITransferInstrument UpdateTransferInstrumentAsync(string id, string xRequestedVerificationCode = null, TransferInstrumentInfo transferInstrumentInfo = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the transfer instrument. |
| **xRequestedVerificationCode** | **string** | Use the requested verification code 0_0001 to resolve any suberrors associated with the transfer instrument. Requested verification codes can only be used in your test environment. |
| **transferInstrumentInfo** | [**TransferInstrumentInfo**](TransferInstrumentInfo.md) |  |

### Return type

[**TransferInstrument**](TransferInstrument.md)

