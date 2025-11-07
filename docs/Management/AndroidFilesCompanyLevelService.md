## Adyen.Management.Services.AndroidFilesCompanyLevelService

#### API Base-Path: **https://management-test.adyen.com/v3**


#### Authorization: ApiKeyAuth


#### Initialization


```csharp
using Adyen.Core.Options;
using Adyen.Management.Extensions;
using Adyen.Management.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureManagement((context, services, config) =>
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
    IAndroidFilesCompanyLevelService androidFilesCompanyLevelService = host.Services.GetRequiredService<IAndroidFilesCompanyLevelService>();
```

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAndroidApp**](AndroidFilesCompanyLevelService.md#getandroidapp) | **GET** /companies/{companyId}/androidApps/{id} | Get Android app |
| [**ListAndroidApps**](AndroidFilesCompanyLevelService.md#listandroidapps) | **GET** /companies/{companyId}/androidApps | Get a list of Android apps |
| [**ListAndroidCertificates**](AndroidFilesCompanyLevelService.md#listandroidcertificates) | **GET** /companies/{companyId}/androidCertificates | Get a list of Android certificates |
| [**ReprocessAndroidApp**](AndroidFilesCompanyLevelService.md#reprocessandroidapp) | **PATCH** /companies/{companyId}/androidApps/{id} | Reprocess Android App |
| [**UploadAndroidApp**](AndroidFilesCompanyLevelService.md#uploadandroidapp) | **POST** /companies/{companyId}/androidApps | Upload Android App |
| [**UploadAndroidCertificate**](AndroidFilesCompanyLevelService.md#uploadandroidcertificate) | **POST** /companies/{companyId}/androidCertificates | Upload Android Certificate |

<a id="getandroidapp"></a>
### **GET** **/companies/{companyId}/androidApps/{id}**

Get Android app

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **id** | [string] | The unique identifier of the app. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `AndroidFilesCompanyLevelService.GetAndroidApp` usage:
// Provide the following values: companyId, id.
IAndroidApp response = await androidFilesCompanyLevelService.GetAndroidAppAsync(
    string companyId,
    string id, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out AndroidApp result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[AndroidApp]()


<a id="listandroidapps"></a>
### **GET** **/companies/{companyId}/androidApps**

Get a list of Android apps

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **pageNumber** | [int] | The number of the page to fetch. |
| **pageSize** | [int] | The number of items to have on a page, maximum 100. The default is 20 items on a page. |
| **packageName** | [string] | The package name that uniquely identifies the Android app. |
| **versionCode** | [int] | The version number of the app. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `AndroidFilesCompanyLevelService.ListAndroidApps` usage:
// Provide the following values: companyId, pageNumber, pageSize, packageName, versionCode.
IAndroidAppsResponse response = await androidFilesCompanyLevelService.ListAndroidAppsAsync(
    string companyId,
    int pageNumber,
    int pageSize,
    string packageName,
    int versionCode, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out AndroidAppsResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[AndroidAppsResponse]()


<a id="listandroidcertificates"></a>
### **GET** **/companies/{companyId}/androidCertificates**

Get a list of Android certificates

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **pageNumber** | [int] | The number of the page to fetch. |
| **pageSize** | [int] | The number of items to have on a page, maximum 100. The default is 20 items on a page. |
| **certificateName** | [string] | The name of the certificate. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `AndroidFilesCompanyLevelService.ListAndroidCertificates` usage:
// Provide the following values: companyId, pageNumber, pageSize, certificateName.
IAndroidCertificatesResponse response = await androidFilesCompanyLevelService.ListAndroidCertificatesAsync(
    string companyId,
    int pageNumber,
    int pageSize,
    string certificateName, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out AndroidCertificatesResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[AndroidCertificatesResponse]()


<a id="reprocessandroidapp"></a>
### **PATCH** **/companies/{companyId}/androidApps/{id}**

Reprocess Android App

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |
| **id** | [string] | The unique identifier of the app. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `AndroidFilesCompanyLevelService.ReprocessAndroidApp` usage:
// Provide the following values: companyId, id.
IReprocessAndroidAppResponse response = await androidFilesCompanyLevelService.ReprocessAndroidAppAsync(
    string companyId,
    string id, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out ReprocessAndroidAppResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[ReprocessAndroidAppResponse]()


<a id="uploadandroidapp"></a>
### **POST** **/companies/{companyId}/androidApps**

Upload Android App

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `AndroidFilesCompanyLevelService.UploadAndroidApp` usage:
// Provide the following values: companyId.
IUploadAndroidAppResponse response = await androidFilesCompanyLevelService.UploadAndroidAppAsync(
    string companyId, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out UploadAndroidAppResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[UploadAndroidAppResponse]()


<a id="uploadandroidcertificate"></a>
### **POST** **/companies/{companyId}/androidCertificates**

Upload Android Certificate

#### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | [string] | The unique identifier of the company account. |

#### Example usage

```csharp
using Adyen.Management.Models;
using Adyen.Management.Services;

// Example `AndroidFilesCompanyLevelService.UploadAndroidCertificate` usage:
// Provide the following values: companyId.
IUploadAndroidCertificateResponse response = await androidFilesCompanyLevelService.UploadAndroidCertificateAsync(
    string companyId, 
    CancellationToken cancellationToken = default);

if (response.TryDeserializeOkResponse(out UploadAndroidCertificateResponse result))
{
    // Handle result, if 200 OK response
}

```

#### Return type
[UploadAndroidCertificateResponse]()


