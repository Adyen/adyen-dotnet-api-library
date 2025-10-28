# Adyen.BinLookup.Services.BinLookupService

### API Base-Path: **https://pal-test.adyen.com/pal/servlet/BinLookup/v54**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Get3dsAvailability**](BinLookupService.md#get3dsavailability) | **POST** /get3dsAvailability | Check if 3D Secure is available |
| [**GetCostEstimate**](BinLookupService.md#getcostestimate) | **POST** /getCostEstimate | Get a fees cost estimate |

<a id="get3dsavailability"></a>
# **POST** **/get3dsAvailability**

Check if 3D Secure is available

```csharp 
IThreeDSAvailabilityResponse Get3dsAvailabilityAsync(ThreeDSAvailabilityRequest threeDSAvailabilityRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **threeDSAvailabilityRequest** | [**ThreeDSAvailabilityRequest**](ThreeDSAvailabilityRequest.md) |  |

### Return type

[**ThreeDSAvailabilityResponse**](ThreeDSAvailabilityResponse.md)

<a id="getcostestimate"></a>
# **POST** **/getCostEstimate**

Get a fees cost estimate

```csharp 
ICostEstimateResponse GetCostEstimateAsync(CostEstimateRequest costEstimateRequest = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **costEstimateRequest** | [**CostEstimateRequest**](CostEstimateRequest.md) |  |

### Return type

[**CostEstimateResponse**](CostEstimateResponse.md)

