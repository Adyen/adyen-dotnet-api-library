## Adyen.BalancePlatform.Services.TransactionRulesService

#### API Base-Path: **https://balanceplatform-api-test.adyen.com/bcl/v2**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.BalancePlatform.Extensions;
using Adyen.BalancePlatform.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureBalancePlatform((context, services, config) =>
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
    ITransactionRulesService transactionRulesService = host.Services.GetRequiredService<ITransactionRulesService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateTransactionRule**](TransactionRulesService.md#createtransactionrule) | **POST** /transactionRules | Create a transaction rule |
| [**DeleteTransactionRule**](TransactionRulesService.md#deletetransactionrule) | **DELETE** /transactionRules/{transactionRuleId} | Delete a transaction rule |
| [**GetTransactionRule**](TransactionRulesService.md#gettransactionrule) | **GET** /transactionRules/{transactionRuleId} | Get a transaction rule |
| [**UpdateTransactionRule**](TransactionRulesService.md#updatetransactionrule) | **PATCH** /transactionRules/{transactionRuleId} | Update a transaction rule |

<a id="createtransactionrule"></a>
### **POST** **/transactionRules**

Create a transaction rule

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **transactionRuleInfo** | **TransactionRuleInfo** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `TransactionRulesService.CreateTransactionRule` usage:
// Provide the following values: transactionRuleInfo.
ITransactionRule response = await transactionRulesService.CreateTransactionRuleAsync(
    TransactionRuleInfo transactionRuleInfo, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TransactionRule result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TransactionRule]()


<a id="deletetransactionrule"></a>
### **DELETE** **/transactionRules/{transactionRuleId}**

Delete a transaction rule

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **transactionRuleId** | [string] | The unique identifier of the transaction rule. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `TransactionRulesService.DeleteTransactionRule` usage:
// Provide the following values: transactionRuleId.
ITransactionRule response = await transactionRulesService.DeleteTransactionRuleAsync(
    string transactionRuleId, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TransactionRule result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TransactionRule]()


<a id="gettransactionrule"></a>
### **GET** **/transactionRules/{transactionRuleId}**

Get a transaction rule

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **transactionRuleId** | [string] | The unique identifier of the transaction rule. |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `TransactionRulesService.GetTransactionRule` usage:
// Provide the following values: transactionRuleId.
ITransactionRuleResponse response = await transactionRulesService.GetTransactionRuleAsync(
    string transactionRuleId, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TransactionRuleResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TransactionRuleResponse]()


<a id="updatetransactionrule"></a>
### **PATCH** **/transactionRules/{transactionRuleId}**

Update a transaction rule

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **transactionRuleId** | [string] | The unique identifier of the transaction rule. |
| **transactionRuleInfo** | **TransactionRuleInfo** |  |

#### Example usage

```csharp
using Adyen.BalancePlatform.Models;
using Adyen.BalancePlatform.Services;

// Example `TransactionRulesService.UpdateTransactionRule` usage:
// Provide the following values: transactionRuleId, transactionRuleInfo.
ITransactionRule response = await transactionRulesService.UpdateTransactionRuleAsync(
    string transactionRuleId,
    TransactionRuleInfo transactionRuleInfo, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out TransactionRule result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[TransactionRule]()


