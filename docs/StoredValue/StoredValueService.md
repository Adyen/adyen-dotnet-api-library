## Adyen.StoredValue.Services.StoredValueService

#### API Base-Path: **https://pal-test.adyen.com/pal/servlet/StoredValue/v46**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.StoredValue.Extensions;
using Adyen.StoredValue.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureStoredValue((context, services, config) =>
    {
        config.ConfigureAdyenOptions(options =>
        {
            // Set your ADYEN_API_KEY or use get it from your environment using context.Configuration["ADYEN_API_KEY"].
            options.AdyenApiKey = context.Configuration["ADYEN_API_KEY"];

            // Set your environment, e.g. `Test` or `Live`.
            options.Environment = AdyenEnvironment.Test;

            // For the Live environment, additionally include your LiveEndpointUrlPrefix.
            options.LiveEndpointUrlPrefix = "your-live-endpoint-url-prefix";
        });
    })
    .Build();

    // You can inject this service in your constructor.
    IStoredValueService storedValueService = host.Services.GetRequiredService<IStoredValueService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ChangeStatus**](StoredValueService.md#changestatus) | **POST** /changeStatus | Changes the status of the payment method. |
| [**CheckBalance**](StoredValueService.md#checkbalance) | **POST** /checkBalance | Checks the balance. |
| [**Issue**](StoredValueService.md#issue) | **POST** /issue | Issues a new card. |
| [**Load**](StoredValueService.md#load) | **POST** /load | Loads the payment method. |
| [**MergeBalance**](StoredValueService.md#mergebalance) | **POST** /mergeBalance | Merge the balance of two cards. |
| [**VoidTransaction**](StoredValueService.md#voidtransaction) | **POST** /voidTransaction | Voids a transaction. |

<a id="changestatus"></a>
### **POST** **/changeStatus**

Changes the status of the payment method.

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storedValueStatusChangeRequest** | **StoredValueStatusChangeRequest** |  |

#### Example usage

```csharp
using Adyen.StoredValue.Models;
using Adyen.StoredValue.Services;

// Example `StoredValueService.ChangeStatus` usage:
// Provide the following values: storedValueStatusChangeRequest
IStoredValueStatusChangeResponse response = await storedValueService.ChangeStatusAsync(
    StoredValueStatusChangeRequest storedValueStatusChangeRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out StoredValueStatusChangeResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[StoredValueStatusChangeResponse]()


<a id="checkbalance"></a>
### **POST** **/checkBalance**

Checks the balance.

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storedValueBalanceCheckRequest** | **StoredValueBalanceCheckRequest** |  |

#### Example usage

```csharp
using Adyen.StoredValue.Models;
using Adyen.StoredValue.Services;

// Example `StoredValueService.CheckBalance` usage:
// Provide the following values: storedValueBalanceCheckRequest
IStoredValueBalanceCheckResponse response = await storedValueService.CheckBalanceAsync(
    StoredValueBalanceCheckRequest storedValueBalanceCheckRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out StoredValueBalanceCheckResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[StoredValueBalanceCheckResponse]()


<a id="issue"></a>
### **POST** **/issue**

Issues a new card.

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storedValueIssueRequest** | **StoredValueIssueRequest** |  |

#### Example usage

```csharp
using Adyen.StoredValue.Models;
using Adyen.StoredValue.Services;

// Example `StoredValueService.Issue` usage:
// Provide the following values: storedValueIssueRequest
IStoredValueIssueResponse response = await storedValueService.IssueAsync(
    StoredValueIssueRequest storedValueIssueRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out StoredValueIssueResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[StoredValueIssueResponse]()


<a id="load"></a>
### **POST** **/load**

Loads the payment method.

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storedValueLoadRequest** | **StoredValueLoadRequest** |  |

#### Example usage

```csharp
using Adyen.StoredValue.Models;
using Adyen.StoredValue.Services;

// Example `StoredValueService.Load` usage:
// Provide the following values: storedValueLoadRequest
IStoredValueLoadResponse response = await storedValueService.LoadAsync(
    StoredValueLoadRequest storedValueLoadRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out StoredValueLoadResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[StoredValueLoadResponse]()


<a id="mergebalance"></a>
### **POST** **/mergeBalance**

Merge the balance of two cards.

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storedValueBalanceMergeRequest** | **StoredValueBalanceMergeRequest** |  |

#### Example usage

```csharp
using Adyen.StoredValue.Models;
using Adyen.StoredValue.Services;

// Example `StoredValueService.MergeBalance` usage:
// Provide the following values: storedValueBalanceMergeRequest
IStoredValueBalanceMergeResponse response = await storedValueService.MergeBalanceAsync(
    StoredValueBalanceMergeRequest storedValueBalanceMergeRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out StoredValueBalanceMergeResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[StoredValueBalanceMergeResponse]()


<a id="voidtransaction"></a>
### **POST** **/voidTransaction**

Voids a transaction.

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **storedValueVoidRequest** | **StoredValueVoidRequest** |  |

#### Example usage

```csharp
using Adyen.StoredValue.Models;
using Adyen.StoredValue.Services;

// Example `StoredValueService.VoidTransaction` usage:
// Provide the following values: storedValueVoidRequest
IStoredValueVoidResponse response = await storedValueService.VoidTransactionAsync(
    StoredValueVoidRequest storedValueVoidRequest, 
    RequestOptions requestOptions = default, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out StoredValueVoidResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[StoredValueVoidResponse]()


