# Adyen.Disputes.Services.DisputesService

### API Base-Path: **https://ca-test.adyen.com/ca/services/DisputeService/v30**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AcceptDispute**](DisputesService.md#acceptdispute) | **POST** /acceptDispute | Accept a dispute |
| [**DefendDispute**](DisputesService.md#defenddispute) | **POST** /defendDispute | Defend a dispute |
| [**DeleteDisputeDefenseDocument**](DisputesService.md#deletedisputedefensedocument) | **POST** /deleteDisputeDefenseDocument | Delete a defense document |
| [**RetrieveApplicableDefenseReasons**](DisputesService.md#retrieveapplicabledefensereasons) | **POST** /retrieveApplicableDefenseReasons | Get applicable defense reasons |
| [**SupplyDefenseDocument**](DisputesService.md#supplydefensedocument) | **POST** /supplyDefenseDocument | Supply a defense document |

<a id="acceptdispute"></a>
# **POST** **/acceptDispute**

Accept a dispute

```csharp 
IAcceptDisputeResponse AcceptDisputeAsync(AcceptDisputeRequest acceptDisputeRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **acceptDisputeRequest** | [**AcceptDisputeRequest**](AcceptDisputeRequest.md) |  |

### Return type

[**AcceptDisputeResponse**](AcceptDisputeResponse.md)

<a id="defenddispute"></a>
# **POST** **/defendDispute**

Defend a dispute

```csharp 
IDefendDisputeResponse DefendDisputeAsync(DefendDisputeRequest defendDisputeRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **defendDisputeRequest** | [**DefendDisputeRequest**](DefendDisputeRequest.md) |  |

### Return type

[**DefendDisputeResponse**](DefendDisputeResponse.md)

<a id="deletedisputedefensedocument"></a>
# **POST** **/deleteDisputeDefenseDocument**

Delete a defense document

```csharp 
IDeleteDefenseDocumentResponse DeleteDisputeDefenseDocumentAsync(DeleteDefenseDocumentRequest deleteDefenseDocumentRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **deleteDefenseDocumentRequest** | [**DeleteDefenseDocumentRequest**](DeleteDefenseDocumentRequest.md) |  |

### Return type

[**DeleteDefenseDocumentResponse**](DeleteDefenseDocumentResponse.md)

<a id="retrieveapplicabledefensereasons"></a>
# **POST** **/retrieveApplicableDefenseReasons**

Get applicable defense reasons

```csharp 
IDefenseReasonsResponse RetrieveApplicableDefenseReasonsAsync(DefenseReasonsRequest defenseReasonsRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **defenseReasonsRequest** | [**DefenseReasonsRequest**](DefenseReasonsRequest.md) |  |

### Return type

[**DefenseReasonsResponse**](DefenseReasonsResponse.md)

<a id="supplydefensedocument"></a>
# **POST** **/supplyDefenseDocument**

Supply a defense document

```csharp 
ISupplyDefenseDocumentResponse SupplyDefenseDocumentAsync(SupplyDefenseDocumentRequest supplyDefenseDocumentRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **supplyDefenseDocumentRequest** | [**SupplyDefenseDocumentRequest**](SupplyDefenseDocumentRequest.md) |  |

### Return type

[**SupplyDefenseDocumentResponse**](SupplyDefenseDocumentResponse.md)

